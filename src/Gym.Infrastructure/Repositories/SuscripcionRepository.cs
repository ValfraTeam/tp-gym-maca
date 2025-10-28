using Gym.Domain.Entities;
using Gym.Domain.Interfaces;
using Gym.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Gym.Infrastructure.Repositories
{
    public class SuscripcionRepository : ISuscripcionRepository
    {
        private readonly ApplicationDbContext _context;

        public SuscripcionRepository(ApplicationDbContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public void Agregar(Suscripcion suscripcion)
        {
            _context.Suscripciones.Add(suscripcion);
            _context.SaveChanges();
        }

        public void Actualizar(Suscripcion suscripcion)
        {
            _context.Suscripciones.Update(suscripcion);
            _context.SaveChanges();
        }

        public void Eliminar(int id)
        {
            var suscripcion = _context.Suscripciones.Find(id);
            if (suscripcion != null)
            {
                _context.Suscripciones.Remove(suscripcion);
                _context.SaveChanges();
            }
        }

        public void Desactivar(int id)
        {
            var suscripcion = _context.Suscripciones.Find(id);
            if (suscripcion != null)
            {
                suscripcion.EstaActivo = false;
                _context.SaveChanges();
            }
        }

        public Suscripcion? ObtenerPorId(int id)
        {
            return _context.Suscripciones.Find(id);
        }

        public Suscripcion? ObtenerPorNombre(string nombre)
        {
            return _context.Suscripciones.FirstOrDefault(s => s.Nombre == nombre);
        }

        public List<Suscripcion> ObtenerTodas()
        {
            return _context.Suscripciones.ToList();
        }

        public List<Suscripcion> ObtenerActivas()
        {
            return _context.Suscripciones.Where(s => s.EstaActivo).ToList();
        }
    }
}