using Gym.Domain.Entities;
using Gym.Domain.Interfaces;
using Gym.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Gym.Infrastructure.Repositories
{
    public class PagoRepository : IPagoRepository
    {
        private readonly ApplicationDbContext _context;

        public PagoRepository(ApplicationDbContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public void Agregar(Pago pago)
        {
            _context.Pagos.Add(pago);
            _context.SaveChanges();
        }

        public void Actualizar(Pago pago)
        {
            _context.Pagos.Update(pago);
            _context.SaveChanges();
        }

        public void Eliminar(int id)
        {
            var pago = _context.Pagos.Find(id);
            if (pago != null)
            {
                _context.Pagos.Remove(pago);
                _context.SaveChanges();
            }
        }

        public Pago? ObtenerPorId(int id)
        {
            return _context.Pagos.Find(id);
        }

        public List<Pago> ObtenerTodos()
        {
            return _context.Pagos.ToList();
        }
    }
}