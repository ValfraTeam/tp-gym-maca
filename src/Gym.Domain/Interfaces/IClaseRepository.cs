using Gym.Domain.Entities;

namespace Gym.Domain.Interfaces
{
    public interface IClaseRepository
    {
        void Agregar(Clase clase);
        void Actualizar(Clase clase);
        void Eliminar(int id);
        Clase? ObtenerPorId(int id);
        List<Clase> ObtenerTodas();
    }
}

