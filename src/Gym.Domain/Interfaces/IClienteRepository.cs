using Gym.Domain.Entities;

namespace Gym.Domain.Interfaces
{
    public interface IClienteRepository
    {
        void Agregar(Cliente cliente);
        void Actualizar(Cliente cliente);
        void Eliminar(int id);
        Cliente? ObtenerPorId(int id);
        Cliente? ObtenerPorDni(int dni);
        List<Cliente> ObtenerTodos();
    }
}
