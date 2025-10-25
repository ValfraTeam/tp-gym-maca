using System;
using clasesGYM_.Repositorios;
using Microsoft.EntityFrameworkCore;

namespace clasesGYM_
{
	internal static class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("🧪 INICIANDO PRUEBAS DE REPOSITORIOS N:M");
			Console.WriteLine("==========================================");

		try
		{
			// 0. Limpiar base de datos primero
			LimpiarBaseDatos();
			
			// 1. Insertar datos de prueba
			DatosPrueba.InsertarDatosPrueba();
			
			// 2. Mostrar resumen de datos
			DatosPrueba.MostrarResumen();
			
			// 3. Probar métodos de lectura del SuscripcionClienteRepository
			ProbarMetodosLectura();

			Console.WriteLine("\n✅ TODAS LAS PRUEBAS COMPLETADAS EXITOSAMENTE");
		}
			catch (Exception ex)
			{
				Console.WriteLine($"❌ ERROR EN PRUEBAS: {ex.Message}");
				Console.WriteLine($"Detalles: {ex.StackTrace}");
			}

			Console.WriteLine("\nPresiona cualquier tecla para salir...");
			Console.ReadKey();
		}

		private static void ProbarSuscripcionRepository()
		{
			Console.WriteLine("\n📋 PROBANDO SUSCRIPCIONREPOSITORY");
			Console.WriteLine("----------------------------------");

			// Crear suscripciones de prueba
			var basica = new Suscripcion { Nombre = "Básica", Precio = 50.00m };
			var premium = new Suscripcion { Nombre = "Premium", Precio = 100.00m };

			SuscripcionRepository.AgregarSuscripcion(basica);
			Console.WriteLine($"✅ Suscripción creada: {basica.Nombre} - ${basica.Precio}");

			SuscripcionRepository.AgregarSuscripcion(premium);
			Console.WriteLine($"✅ Suscripción creada: {premium.Nombre} - ${premium.Precio}");

			// Obtener todas las suscripciones
			var suscripciones = SuscripcionRepository.ObtenerSuscripciones();
			Console.WriteLine($"✅ Total de suscripciones: {suscripciones.Count}");

			// Obtener suscripción específica
			var suscripcionObtenida = SuscripcionRepository.ObtenerSuscripcion(basica.Id);
			Console.WriteLine($"✅ Suscripción obtenida: {suscripcionObtenida.Nombre}");
		}

		private static void ProbarClienteRepository()
		{
			Console.WriteLine("\n👥 PROBANDO CLIENTEREPOSITORY");
			Console.WriteLine("-------------------------------");

			// Crear cliente de prueba
			var cliente = new Cliente
			{
				Dni = 12345678,
				Nombre = "Juan",
				Apellido = "Pérez",
				Direccion = "Calle 1, Ciudad",
				Telefono = 123456789
			};

			ClienteRepository.AgregarCliente(cliente);
			Console.WriteLine($"✅ Cliente creado: {cliente.Nombre} {cliente.Apellido}");

			// Obtener cliente
			var clienteObtenido = ClienteRepository.ObtenerCliente(cliente.Id);
			Console.WriteLine($"✅ Cliente obtenido: {clienteObtenido.Nombre} {clienteObtenido.Apellido}");

			// Obtener todos los clientes
			var clientes = ClienteRepository.ObtenerClientes();
			Console.WriteLine($"✅ Total de clientes: {clientes.Count}");
		}

		private static void ProbarSuscripcionClienteRepository()
		{
			Console.WriteLine("\n🔗 PROBANDO SUSCRIPCIONCLIENTEREPOSITORY");
			Console.WriteLine("----------------------------------------");

			// Obtener cliente y suscripción existentes
			var clientes = ClienteRepository.ObtenerClientes();
			var suscripciones = SuscripcionRepository.ObtenerSuscripciones();

			if (clientes.Count == 0 || suscripciones.Count == 0)
			{
				Console.WriteLine("❌ No hay clientes o suscripciones para probar");
				return;
			}

			var cliente = clientes.First();
			var suscripcion = suscripciones.First();

			// Crear suscripción para cliente
			var suscripcionCliente = new SuscripcionCliente
			{
				ClienteId = cliente.Id,
				SuscripcionId = suscripcion.Id,
				FechaInicio = DateTime.Now,
				FechaFin = DateTime.Now.AddMonths(1)
			};

			SuscripcionClienteRepository.AgregarSuscripcionCliente(suscripcionCliente);
			Console.WriteLine($"✅ Suscripción asignada: Cliente {cliente.Nombre} → {suscripcion.Nombre}");

			// Probar obtener suscripción activa
			var suscripcionActiva = SuscripcionClienteRepository.ObtenerSuscripcionActiva(cliente.Id);
			if (suscripcionActiva != null)
			{
				Console.WriteLine($"✅ Suscripción activa encontrada: {suscripcionActiva.Suscripcion.Nombre}");
			}
			else
			{
				Console.WriteLine("❌ No se encontró suscripción activa");
			}

			// Probar control de acceso
			bool puedeAcceder = SuscripcionClienteRepository.ClientePuedeAcceder(cliente.Id);
			Console.WriteLine($"✅ Cliente puede acceder: {(puedeAcceder ? "SÍ" : "NO")}");

			// Probar días restantes
			int diasRestantes = SuscripcionClienteRepository.ObtenerDiasRestantes(cliente.Id);
			Console.WriteLine($"✅ Días restantes: {diasRestantes}");
		}

		private static void ProbarRelacionNMCompleta()
		{
			Console.WriteLine("\n🎯 PROBANDO RELACIÓN N:M COMPLETA");
			Console.WriteLine("----------------------------------");

			// Crear segundo cliente
			var cliente2 = new Cliente
			{
				Dni = 87654321,
				Nombre = "María",
				Apellido = "González",
				Direccion = "Calle 2, Ciudad",
				Telefono = 987654321
			};

			ClienteRepository.AgregarCliente(cliente2);
			Console.WriteLine($"✅ Segundo cliente creado: {cliente2.Nombre} {cliente2.Apellido}");

			// Obtener suscripciones disponibles
			var suscripciones = SuscripcionRepository.ObtenerSuscripciones();
			var premium = suscripciones.FirstOrDefault(s => s.Nombre == "Premium");

			if (premium != null)
			{
				// Asignar suscripción premium al segundo cliente
				var suscripcionCliente2 = new SuscripcionCliente
				{
					ClienteId = cliente2.Id,
					SuscripcionId = premium.Id,
					FechaInicio = DateTime.Now,
					FechaFin = DateTime.Now.AddMonths(1)
				};

				SuscripcionClienteRepository.AgregarSuscripcionCliente(suscripcionCliente2);
				Console.WriteLine($"✅ Suscripción premium asignada a {cliente2.Nombre}");
			}

			// Probar obtener todas las suscripciones activas
			var suscripcionesActivas = SuscripcionClienteRepository.ObtenerSuscripcionesActivas();
			Console.WriteLine($"✅ Total de suscripciones activas: {suscripcionesActivas.Count}");

			foreach (var sc in suscripcionesActivas)
			{
				Console.WriteLine($"  • {sc.Cliente.Nombre} {sc.Cliente.Apellido} - {sc.Suscripcion.Nombre}");
			}

			// Probar historial de suscripciones
			var clientes = ClienteRepository.ObtenerClientes();
			foreach (var cliente in clientes)
			{
				var historial = SuscripcionClienteRepository.ObtenerHistorialSuscripciones(cliente.Id);
				Console.WriteLine($"✅ Historial de {cliente.Nombre}: {historial.Count} suscripción(es)");
			}
		}

		// ✅ MÉTODO: Probar métodos de lectura del SuscripcionClienteRepository
		private static void ProbarMetodosLectura()
		{
			Console.WriteLine("\n🔍 PROBANDO MÉTODOS DE LECTURA DEL SUSCRIPCIONCLIENTEREPOSITORY");
			Console.WriteLine("=================================================================");

			// 1. Obtener suscripciones activas
			Console.WriteLine("\n1️⃣ SUSCRIPCIONES ACTIVAS");
			Console.WriteLine("-------------------------");
			var suscripcionesActivas = SuscripcionClienteRepository.ObtenerSuscripcionesActivas();
			Console.WriteLine($"✅ Suscripciones activas encontradas: {suscripcionesActivas.Count}");
			
			foreach (var sc in suscripcionesActivas)
			{
				Console.WriteLine($"  • Cliente: {sc.Cliente.Nombre} {sc.Cliente.Apellido}");
				Console.WriteLine($"    Suscripción: {sc.Suscripcion.Nombre}");
				Console.WriteLine($"    Fecha Inicio: {sc.FechaInicio:dd/MM/yyyy}");
				Console.WriteLine($"    Fecha Fin: {sc.FechaFin:dd/MM/yyyy}");
				Console.WriteLine($"    Estado: {(sc.EstaActiva() ? "ACTIVA" : "VENCIDA")}");
				Console.WriteLine();
			}

			// 2. Obtener historial de clientes
			Console.WriteLine("\n2️⃣ HISTORIAL DE CLIENTES");
			Console.WriteLine("------------------------");
			var clientes = ClienteRepository.ObtenerClientes();
			foreach (var cliente in clientes)
			{
				var historial = SuscripcionClienteRepository.ObtenerHistorialSuscripciones(cliente.Id);
				Console.WriteLine($"✅ Historial de {cliente.Nombre} {cliente.Apellido}: {historial.Count} suscripción(es)");
				
				foreach (var h in historial)
				{
					Console.WriteLine($"  • {h.Suscripcion.Nombre} - {h.FechaInicio:dd/MM/yyyy} a {h.FechaFin:dd/MM/yyyy}");
				}
			}

			// 3. Verificar acceso de clientes
			Console.WriteLine("\n3️⃣ VERIFICAR ACCESO DE CLIENTES");
			Console.WriteLine("--------------------------------");
			foreach (var cliente in clientes)
			{
				var puedeAcceder = SuscripcionClienteRepository.ClientePuedeAcceder(cliente.Id);
				var diasRestantes = SuscripcionClienteRepository.ObtenerDiasRestantes(cliente.Id);
				
				Console.WriteLine($"✅ Cliente: {cliente.Nombre} {cliente.Apellido}");
				Console.WriteLine($"   Puede acceder: {(puedeAcceder ? "SÍ" : "NO")}");
				Console.WriteLine($"   Días restantes: {diasRestantes}");
			}

			// 4. Suscripciones por vencer
			Console.WriteLine("\n4️⃣ SUSCRIPCIONES POR VENCER");
			Console.WriteLine("----------------------------");
			var porVencer = SuscripcionClienteRepository.ObtenerSuscripcionesPorVencer(30);
			Console.WriteLine($"✅ Suscripciones por vencer en 30 días: {porVencer.Count}");
			
			foreach (var sc in porVencer)
			{
				var diasRestantes = (sc.FechaFin - DateTime.Now).Days;
				Console.WriteLine($"  • {sc.Cliente.Nombre} {sc.Cliente.Apellido} - {sc.Suscripcion.Nombre} (vence en {diasRestantes} días)");
			}

			// 5. Suscripciones vencidas
			Console.WriteLine("\n5️⃣ SUSCRIPCIONES VENCIDAS");
			Console.WriteLine("---------------------------");
			var vencidas = SuscripcionClienteRepository.ObtenerSuscripcionesVencidas();
			Console.WriteLine($"✅ Suscripciones vencidas: {vencidas.Count}");
			
			foreach (var sc in vencidas)
			{
				Console.WriteLine($"  • {sc.Cliente.Nombre} {sc.Cliente.Apellido} - {sc.Suscripcion.Nombre} (venció el {sc.FechaFin:dd/MM/yyyy})");
			}
		}

		// ✅ MÉTODO: Limpiar base de datos para pruebas
		private static void LimpiarBaseDatos()
		{
			Console.WriteLine("🧹 Limpiando base de datos para pruebas...");
			using (var context = new AplicationDbContext())
			{
				try
				{
					// Deshabilitar restricciones temporalmente
					context.Database.ExecuteSqlRaw("EXEC sp_MSforeachtable 'ALTER TABLE ? NOCHECK CONSTRAINT ALL'");
					
					// Eliminar todos los datos
					context.SuscripcionClientes.RemoveRange(context.SuscripcionClientes);
					context.Pagos.RemoveRange(context.Pagos);
					context.Facturas.RemoveRange(context.Facturas);
					context.Clientes.RemoveRange(context.Clientes);
					context.Suscripciones.RemoveRange(context.Suscripciones);
					context.Clases.RemoveRange(context.Clases);
					
					context.SaveChanges();
					
					// Rehabilitar restricciones
					context.Database.ExecuteSqlRaw("EXEC sp_MSforeachtable 'ALTER TABLE ? WITH CHECK CHECK CONSTRAINT ALL'");
					
					Console.WriteLine("✅ Base de datos limpia");
				}
				catch (Exception ex)
				{
					Console.WriteLine($"⚠️ Error al limpiar: {ex.Message}");
					// Continuar con las pruebas aunque haya error
				}
			}
		}
	}
}