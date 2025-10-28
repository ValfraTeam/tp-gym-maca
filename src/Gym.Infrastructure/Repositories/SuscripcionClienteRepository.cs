using Gym.Domain.Entities;
using Gym.Domain.Interfaces;
using Gym.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Gym.Infrastructure.Repositories
{
    public class SuscripcionClienteRepository : ISuscripcionClienteRepository
    {
        private readonly ApplicationDbContext _context;

        public SuscripcionClienteRepository(ApplicationDbContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public void Add(SuscripcionCliente suscripcionCliente)
        {
            _context.SuscripcionClientes.Add(suscripcionCliente);
            _context.SaveChanges();
        }

        public void Update(SuscripcionCliente suscripcionCliente)
        {
            _context.SuscripcionClientes.Update(suscripcionCliente);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            // Nota: Este método necesita ser ajustado según la clave primaria compuesta
            throw new NotImplementedException("Delete method needs to be implemented for composite key");
        }

        public SuscripcionCliente? GetById(int id)
        {
            // Nota: Este método necesita ser ajustado según la clave primaria compuesta
            throw new NotImplementedException("GetById method needs to be implemented for composite key");
        }

        public List<SuscripcionCliente> GetByClienteId(int clienteId)
        {
            return _context.SuscripcionClientes
                .Include(sc => sc.Suscripcion)
                .Include(sc => sc.Cliente)
                .Where(sc => sc.ClienteId == clienteId)
                .OrderByDescending(sc => sc.FechaInicio)
                .ToList();
        }

        public SuscripcionCliente? GetSuscripcionActiva(int clienteId)
        {
            var ahora = DateTime.Now;
            return _context.SuscripcionClientes
                .Include(sc => sc.Suscripcion)
                .Include(sc => sc.Cliente)
                .FirstOrDefault(sc => sc.ClienteId == clienteId && 
                                     ahora >= sc.FechaInicio && 
                                     ahora <= sc.FechaFin);
        }

        public List<SuscripcionCliente> GetSuscripcionesActivas()
        {
            var ahora = DateTime.Now;
            return _context.SuscripcionClientes
                .Include(sc => sc.Cliente)
                .Include(sc => sc.Suscripcion)
                .Where(sc => ahora >= sc.FechaInicio && ahora <= sc.FechaFin)
                .ToList();
        }

        public List<SuscripcionCliente> GetAll()
        {
            return _context.SuscripcionClientes
                .Include(sc => sc.Cliente)
                .Include(sc => sc.Suscripcion)
                .ToList();
        }
    }
}