using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace clasesGYM_.Repositorios
{
    public class SuscripcionClienteRepository
    {
        // MÉTODO: Agregar suscripción a cliente
        public static void AgregarSuscripcionCliente(SuscripcionCliente suscripcionCliente)
        {
            using (var context = new AplicationDbContext())
            {
                // Verificar si ya tiene una suscripción activa
                var ahora = DateTime.Now;
                var suscripcionActiva = context.SuscripcionClientes
                    .FirstOrDefault(sc => sc.ClienteId == suscripcionCliente.ClienteId && 
                                         ahora >= sc.FechaInicio && 
                                         ahora <= sc.FechaFin);
                
                if (suscripcionActiva != null)
                {
                    // Si ya tiene una activa, terminar la anterior y crear la nueva
                    suscripcionActiva.FechaFin = ahora;
                }
                
                // Crear la nueva suscripción
                context.SuscripcionClientes.Add(suscripcionCliente);
                context.SaveChanges();
            }
        }

        // MÉTODO: Agregar cliente con suscripción (para frontend)
        public static void AgregarClienteConSuscripcion(Cliente cliente, int suscripcionId, DateTime fechaInicio, DateTime fechaFin)
        {
            using (var context = new AplicationDbContext())
            {
                // 1. Crear cliente
                context.Clientes.Add(cliente);
                context.SaveChanges();

                // 2. Verificar si ya tiene una suscripción activa (por si acaso)
                var ahora = DateTime.Now;
                var suscripcionActiva = context.SuscripcionClientes
                    .FirstOrDefault(sc => sc.ClienteId == cliente.Id && 
                                         ahora >= sc.FechaInicio && 
                                         ahora <= sc.FechaFin);
                
                if (suscripcionActiva != null)
                {
                    // Si ya tiene una activa, terminar la anterior
                    suscripcionActiva.FechaFin = ahora;
                }

                // 3. Crear nueva suscripción
                var suscripcionCliente = new SuscripcionCliente
                {
                    ClienteId = cliente.Id,
                    SuscripcionId = suscripcionId,
                    FechaInicio = fechaInicio,
                    FechaFin = fechaFin
                };
                context.SuscripcionClientes.Add(suscripcionCliente);
                context.SaveChanges();
            }
        }

        // MÉTODO: Obtener todas las suscripciones de un cliente
        public static List<SuscripcionCliente> ObtenerSuscripcionesCliente(int clienteId)
        {
            using (var context = new AplicationDbContext())
            {
                return context.SuscripcionClientes
                    .Include(sc => sc.Suscripcion)
                    .Include(sc => sc.Cliente)
                    .Where(sc => sc.ClienteId == clienteId)
                    .OrderByDescending(sc => sc.FechaInicio)
                    .ToList();
            }
        }

        // MÉTODO: Obtener suscripción activa de un cliente
        public static SuscripcionCliente ObtenerSuscripcionActiva(int clienteId)
        {
            using (var context = new AplicationDbContext())
            {
                var ahora = DateTime.Now;
                return context.SuscripcionClientes
                    .Include(sc => sc.Suscripcion)
                    .Include(sc => sc.Cliente)
                    .FirstOrDefault(sc => sc.ClienteId == clienteId && 
                                         ahora >= sc.FechaInicio && 
                                         ahora <= sc.FechaFin);
            }
        }

        // MÉTODO: Cambiar suscripción de un cliente
        public static void CambiarSuscripcion(int clienteId, int nuevaSuscripcionId, DateTime fechaInicio, DateTime fechaFin)
        {
            using (var context = new AplicationDbContext())
            {
                // 1. Terminar suscripción actual (si existe)
                var ahora = DateTime.Now;
                var suscripcionActual = context.SuscripcionClientes
                    .FirstOrDefault(sc => sc.ClienteId == clienteId && 
                                         ahora >= sc.FechaInicio && 
                                         ahora <= sc.FechaFin);
                
                if (suscripcionActual != null)
                {
                    // Terminar la suscripción actual estableciendo FechaFin = ahora
                    suscripcionActual.FechaFin = ahora;
                }

                // 2. Crear nueva suscripción
                var nuevaSuscripcion = new SuscripcionCliente
                {
                    ClienteId = clienteId,
                    SuscripcionId = nuevaSuscripcionId,
                    FechaInicio = fechaInicio,
                    FechaFin = fechaFin
                };
                
                context.SuscripcionClientes.Add(nuevaSuscripcion);
                context.SaveChanges();
            }
        }

        // MÉTODO: Obtener clientes con suscripciones activas
        public static List<SuscripcionCliente> ObtenerSuscripcionesActivas()
        {
            using (var context = new AplicationDbContext())
            {
                var ahora = DateTime.Now;
                return context.SuscripcionClientes
                    .Include(sc => sc.Cliente)
                    .Include(sc => sc.Suscripcion)
                    .Where(sc => ahora >= sc.FechaInicio && ahora <= sc.FechaFin)
                    .ToList();
            }
        }

        // MÉTODO: Obtener suscripciones próximas a vencer
        public static List<SuscripcionCliente> ObtenerSuscripcionesPorVencer(int diasAntes = 7)
        {
            using (var context = new AplicationDbContext())
            {
                var fechaLimite = DateTime.Now.AddDays(diasAntes);
                
                var ahora = DateTime.Now;
                return context.SuscripcionClientes
                    .Include(sc => sc.Cliente)
                    .Include(sc => sc.Suscripcion)
                    .Where(sc => ahora >= sc.FechaInicio && 
                                 ahora <= sc.FechaFin &&
                                 sc.FechaFin <= fechaLimite && 
                                 sc.FechaFin > ahora)
                    .ToList();
            }
        }

        // MÉTODO: Obtener suscripciones vencidas
        public static List<SuscripcionCliente> ObtenerSuscripcionesVencidas()
        {
            using (var context = new AplicationDbContext())
            {
                return context.SuscripcionClientes
                    .Include(sc => sc.Cliente)
                    .Include(sc => sc.Suscripcion)
                    .Where(sc => sc.FechaFin < DateTime.Now)
                    .ToList();
            }
        }

        // MÉTODO: Obtener historial de suscripciones de un cliente
        public static List<SuscripcionCliente> ObtenerHistorialSuscripciones(int clienteId)
        {
            using (var context = new AplicationDbContext())
            {
                return context.SuscripcionClientes
                    .Include(sc => sc.Suscripcion)
                    .Include(sc => sc.Cliente)
                    .Where(sc => sc.ClienteId == clienteId)
                    .OrderByDescending(sc => sc.FechaInicio)
                    .ToList();
            }
        }

        // MÉTODO: Verificar si cliente puede acceder al gimnasio
        public static bool ClientePuedeAcceder(int clienteId)
        {
            using (var context = new AplicationDbContext())
            {
                var ahora = DateTime.Now;
                var suscripcionActiva = context.SuscripcionClientes
                    .FirstOrDefault(sc => sc.ClienteId == clienteId && 
                                         ahora >= sc.FechaInicio && 
                                         ahora <= sc.FechaFin);
                
                return suscripcionActiva != null;
            }
        }

        // MÉTODO: Obtener días restantes de suscripción
        public static int ObtenerDiasRestantes(int clienteId)
        {
            using (var context = new AplicationDbContext())
            {
                var ahora = DateTime.Now;
                var suscripcionActiva = context.SuscripcionClientes
                    .FirstOrDefault(sc => sc.ClienteId == clienteId && 
                                         ahora >= sc.FechaInicio && 
                                         ahora <= sc.FechaFin);
                
                if (suscripcionActiva == null) return 0;
                
                var diasRestantes = (suscripcionActiva.FechaFin - ahora).Days;
                return Math.Max(0, diasRestantes);
            }
        }

        // MÉTODO: Eliminar suscripción (solo para casos especiales)
        public static void EliminarSuscripcionCliente(int clienteId, int suscripcionId)
        {
            using (var context = new AplicationDbContext())
            {
                var suscripcionCliente = context.SuscripcionClientes
                    .FirstOrDefault(sc => sc.ClienteId == clienteId && sc.SuscripcionId == suscripcionId);
                
                if (suscripcionCliente != null)
                {
                    context.SuscripcionClientes.Remove(suscripcionCliente);
                    context.SaveChanges();
                }
            }
        }
    }
}
