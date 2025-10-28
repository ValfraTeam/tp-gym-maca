using Gym.Domain.Entities;

namespace Gym.Domain.Interfaces
{
    public interface IClienteRepository
    {
        void Add(Cliente cliente);
        void Update(Cliente cliente);
        void Delete(int id);
        Cliente? GetById(int id);
        Cliente? GetByDni(int dni);
        List<Cliente> GetAll();
    }
}
