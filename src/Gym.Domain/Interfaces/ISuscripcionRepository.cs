using Gym.Domain.Entities;

namespace Gym.Domain.Interfaces
{
    public interface ISuscripcionRepository
    {
        void Agregar(Suscripcion suscripcion);
        void Actualizar(Suscripcion suscripcion);
        void Eliminar(int id);
        Suscripcion? ObtenerPorId(int id);
        Suscripcion? ObtenerPorNombre(string nombre);
        List<Suscripcion> ObtenerTodas();
    }
}

