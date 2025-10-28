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

        public void Add(Suscripcion suscripcion)
        {
            _context.Suscripciones.Add(suscripcion);
            _context.SaveChanges();
        }

        public void Update(Suscripcion suscripcion)
        {
            _context.Suscripciones.Update(suscripcion);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var suscripcion = _context.Suscripciones.Find(id);
            if (suscripcion != null)
            {
                _context.Suscripciones.Remove(suscripcion);
                _context.SaveChanges();
            }
        }

        public Suscripcion? GetById(int id)
        {
            return _context.Suscripciones.Find(id);
        }

        public Suscripcion? GetByName(string nombre)
        {
            return _context.Suscripciones.FirstOrDefault(s => s.Nombre == nombre);
        }

        public List<Suscripcion> GetAll()
        {
            return _context.Suscripciones.ToList();
        }
    }
}