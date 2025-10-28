using Gym.Domain.Entities;
using Gym.Domain.Interfaces;
using Gym.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Gym.Infrastructure.Repositories
{
    public class ClienteRepository : IClienteRepository
    {
        private readonly ApplicationDbContext _context;

        public ClienteRepository(ApplicationDbContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public void Add(Cliente cliente)
        {
            // Verificar si ya existe un cliente con el mismo DNI
            var existente = _context.Clientes.FirstOrDefault(c => c.Dni == cliente.Dni);
            if (existente != null)
            {
                throw new InvalidOperationException("Ya existe un cliente con este DNI");
            }
            
            _context.Clientes.Add(cliente);
            _context.SaveChanges();
        }

        public void Update(Cliente cliente)
        {
            _context.Clientes.Update(cliente);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var cliente = _context.Clientes.Find(id);
            if (cliente != null)
            {
                _context.Clientes.Remove(cliente);
                _context.SaveChanges();
            }
        }

        public Cliente? GetById(int id)
        {
            return _context.Clientes.Find(id);
        }

        public Cliente? GetByDni(int dni)
        {
            return _context.Clientes.FirstOrDefault(c => c.Dni == dni);
        }

        public List<Cliente> GetAll()
        {
            return _context.Clientes.ToList();
        }
    }
}