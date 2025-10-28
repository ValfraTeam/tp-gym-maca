using Gym.Domain.Entities;

namespace Gym.Domain.Interfaces
{
    public interface IClienteRepository
    {
        void Agregar(Cliente cliente);
        void Actualizar(Cliente cliente);
        void Eliminar(int id);
        void Desactivar(int id);
        Cliente? ObtenerPorId(int id);
        Cliente? ObtenerPorDni(int dni);
        List<Cliente> ObtenerTodos();
        List<Cliente> ObtenerActivos();
    }
}
