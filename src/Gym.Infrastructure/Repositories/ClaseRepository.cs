using Gym.Domain.Entities;
using Gym.Domain.Interfaces;
using Gym.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Gym.Infrastructure.Repositories
{
    public class ClaseRepository : IClaseRepository
    {
        private readonly ApplicationDbContext _context;

        public ClaseRepository(ApplicationDbContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public void Agregar(Clase clase)
        {
            _context.Clases.Add(clase);
            _context.SaveChanges();
        }

        public void Actualizar(Clase clase)
        {
            _context.Clases.Update(clase);
            _context.SaveChanges();
        }

        public void Eliminar(int id)
        {
            var clase = _context.Clases.Find(id);
            if (clase != null)
            {
                _context.Clases.Remove(clase);
                _context.SaveChanges();
            }
        }

        public Clase? ObtenerPorId(int id)
        {
            return _context.Clases.Find(id);
        }

        public List<Clase> ObtenerTodas()
        {
            return _context.Clases.ToList();
        }
    }
}
