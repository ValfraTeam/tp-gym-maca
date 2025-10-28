using Gym.Domain.Entities;

namespace Gym.Domain.Interfaces
{
    public interface IPagoRepository
    {
        void Agregar(Pago pago);
        void Actualizar(Pago pago);
        void Eliminar(int id);
        Pago? ObtenerPorId(int id);
        List<Pago> ObtenerTodos();
    }
}

