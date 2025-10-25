using System;
using clasesGYM_.Repositorios;

namespace clasesGYM_
{
    public class DatosPrueba
    {
        // METODO: Insertar datos de prueba completos
        public static void InsertarDatosPrueba()
        {
            Console.WriteLine("📊 INSERTANDO DATOS DE PRUEBA");
            Console.WriteLine("=============================");

            try
            {
                // 1. Insertar suscripciones (solo si no existen)
                Console.WriteLine("\n1️⃣ CREANDO SUSCRIPCIONES");
                Console.WriteLine("-------------------------");
                
                var basica = CrearObtenerSuscripcion("BASICA", 50.00m);
                var premium = CrearObtenerSuscripcion("PREMIUM", 100.00m);
                var gold = CrearObtenerSuscripcion("GOLD", 150.00m);
                var platinum = CrearObtenerSuscripcion("PLATINUM", 200.00m);

                // 2. Insertar clientes (solo si no existen)
                Console.WriteLine("\n2️⃣ CREANDO CLIENTES");
                Console.WriteLine("--------------------");
                
                var cliente1 = CrearObtenerCliente("Ana", "García", 11111111, 111111111, "Calle 1, Ciudad");
                var cliente2 = CrearObtenerCliente("Carlos", "López", 22222222, 222222222, "Calle 2, Ciudad");
                var cliente3 = CrearObtenerCliente("María", "Rodríguez", 33333333, 333333333, "Calle 3, Ciudad");
                var cliente4 = CrearObtenerCliente("Juan", "Martín", 44444444, 444444444, "Calle 4, Ciudad");

                // 3. Asignar suscripciones a clientes (solo si no existe la relación)
                Console.WriteLine("\n3️⃣ ASIGNANDO SUSCRIPCIONES");
                Console.WriteLine("---------------------------");
                
                CrearObtenerRelacion(cliente1, basica, DateTime.Now, DateTime.Now.AddMonths(1));
                CrearObtenerRelacion(cliente2, premium, DateTime.Now, DateTime.Now.AddMonths(1));
                CrearObtenerRelacion(cliente3, gold, DateTime.Now, DateTime.Now.AddMonths(1));
                CrearObtenerRelacion(cliente4, platinum, DateTime.Now, DateTime.Now.AddMonths(1));

                // 4. Crear historial de suscripciones (algunas vencidas)
                Console.WriteLine("\n4️⃣ CREANDO HISTORIAL DE SUSCRIPCIONES");
                Console.WriteLine("--------------------------------------");
                
                // Cliente 1 - Historial: GOLD (vencida) → BASICA (actual)
                var historial1 = new SuscripcionCliente
                {
                    ClienteId = cliente1.Id,
                    SuscripcionId = gold.Id,
                    FechaInicio = DateTime.Now.AddMonths(-2),
                    FechaFin = DateTime.Now.AddMonths(-1)
                };
                SuscripcionClienteRepository.AgregarSuscripcionCliente(historial1);
                Console.WriteLine($"✅ {cliente1.Nombre} → {gold.Nombre} (historial vencida)");
                
                // Cliente 2 - Historial: Básica (vencida) → Premium (actual)
                var historial2 = new SuscripcionCliente
                {
                    ClienteId = cliente2.Id,
                    SuscripcionId = basica.Id,
                    FechaInicio = DateTime.Now.AddMonths(-3),
                    FechaFin = DateTime.Now.AddMonths(-2)
                };
                SuscripcionClienteRepository.AgregarSuscripcionCliente(historial2);
                Console.WriteLine($"✅ {cliente2.Nombre} → {basica.Nombre} (historial vencida)");

                Console.WriteLine("\n✅ DATOS DE PRUEBA INSERTADOS EXITOSAMENTE");
                Console.WriteLine("==========================================");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"❌ ERROR AL INSERTAR DATOS: {ex.Message}");
                Console.WriteLine($"Detalles: {ex}");
            }
        }

        // METODO: Mostrar resumen de datos insertados
        public static void MostrarResumen()
        {
            Console.WriteLine("\n📊 RESUMEN DE DATOS INSERTADOS");
            Console.WriteLine("===============================");

            try
            {
                // Contar suscripciones
                var suscripciones = SuscripcionRepository.ObtenerSuscripciones();
                Console.WriteLine($"📋 Suscripciones: {suscripciones.Count}");
                foreach (var s in suscripciones)
                {
                    Console.WriteLine($"  • {s.Nombre} - ${s.Precio}");
                }

                // Contar clientes
                var clientes = ClienteRepository.ObtenerClientes();
                Console.WriteLine($"\n👥 Clientes: {clientes.Count}");
                foreach (var c in clientes)
                {
                    Console.WriteLine($"  • {c.Nombre} {c.Apellido} (DNI: {c.Dni})");
                }

                // Contar relaciones
                var suscripcionesActivas = SuscripcionClienteRepository.ObtenerSuscripcionesActivas();
                Console.WriteLine($"\n🔗 Suscripciones activas: {suscripcionesActivas.Count}");
                foreach (var sc in suscripcionesActivas)
                {
                    Console.WriteLine($"  • {sc.Cliente.Nombre} {sc.Cliente.Apellido} → {sc.Suscripcion.Nombre}");
                }

                // Historial total
                var historialTotal = 0;
                foreach (var cliente in clientes)
                {
                    var historial = SuscripcionClienteRepository.ObtenerHistorialSuscripciones(cliente.Id);
                    historialTotal += historial.Count;
                }
                Console.WriteLine($"\n📚 Total de relaciones (historial): {historialTotal}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"❌ ERROR AL MOSTRAR RESUMEN: {ex.Message}");
            }
        }

        // METODO AUXILIAR: Crear o obtener suscripcion existente
        private static Suscripcion CrearObtenerSuscripcion(string nombre, decimal precio)
        {
            // Buscar si ya existe
            var suscripciones = SuscripcionRepository.ObtenerSuscripciones();
            var existente = suscripciones.FirstOrDefault(s => s.Nombre == nombre);
            
            if (existente != null)
            {
                Console.WriteLine($"✅ Suscripción ya existe: {existente.Nombre} - ${existente.Precio}");
                return existente;
            }
            
            // Si no existe, crear nueva
            var nueva = new Suscripcion { Nombre = nombre, Precio = precio };
            SuscripcionRepository.AgregarSuscripcion(nueva);
            Console.WriteLine($"✅ Suscripción creada: {nueva.Nombre} - ${nueva.Precio}");
            return nueva;
        }

        // METODO AUXILIAR: Crear o obtener cliente existente
        private static Cliente CrearObtenerCliente(string nombre, string apellido, int dni, int telefono, string direccion)
        {
            // Buscar si ya existe por DNI
            var clientes = ClienteRepository.ObtenerClientes();
            var existente = clientes.FirstOrDefault(c => c.Dni == dni);
            
            if (existente != null)
            {
                Console.WriteLine($"✅ Cliente ya existe: {existente.Nombre} {existente.Apellido}");
                return existente;
            }
            
            // Si no existe, crear nuevo
            var nuevo = new Cliente 
            { 
                Nombre = nombre, 
                Apellido = apellido, 
                Dni = dni, 
                Telefono = telefono, 
                Direccion = direccion 
            };
            ClienteRepository.AgregarCliente(nuevo);
            Console.WriteLine($"✅ Cliente creado: {nuevo.Nombre} {nuevo.Apellido}");
            return nuevo;
        }

        // METODO AUXILIAR: Crear o verificar relacion cliente-suscripcion
        private static void CrearObtenerRelacion(Cliente cliente, Suscripcion suscripcion, DateTime fechaInicio, DateTime fechaFin)
        {
            // Verificar si ya existe la relación activa
            var suscripcionActiva = SuscripcionClienteRepository.ObtenerSuscripcionActiva(cliente.Id);
            
            if (suscripcionActiva != null && suscripcionActiva.SuscripcionId == suscripcion.Id)
            {
                Console.WriteLine($"✅ Relación ya existe: {cliente.Nombre} → {suscripcion.Nombre}");
                return;
            }
            
            // Si no existe, crear nueva relación
            var nuevaRelacion = new SuscripcionCliente
            {
                ClienteId = cliente.Id,
                SuscripcionId = suscripcion.Id,
                FechaInicio = fechaInicio,
                FechaFin = fechaFin
            };
            
            try
            {
                SuscripcionClienteRepository.AgregarSuscripcionCliente(nuevaRelacion);
                Console.WriteLine($"✅ {cliente.Nombre} → {suscripcion.Nombre} (activa)");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"⚠️ Relación ya existe: {cliente.Nombre} → {suscripcion.Nombre}");
            }
        }
    }
}
