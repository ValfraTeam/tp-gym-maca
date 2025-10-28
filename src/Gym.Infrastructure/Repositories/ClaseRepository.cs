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

        public void Add(Clase clase)
        {
            _context.Clases.Add(clase);
            _context.SaveChanges();
        }

        public void Update(Clase clase)
        {
            _context.Clases.Update(clase);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var clase = _context.Clases.Find(id);
            if (clase != null)
            {
                _context.Clases.Remove(clase);
                _context.SaveChanges();
            }
        }

        public Clase? GetById(int id)
        {
            return _context.Clases.Find(id);
        }

        public List<Clase> GetAll()
        {
            return _context.Clases.ToList();
        }
    }
}
