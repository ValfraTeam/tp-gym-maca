using Gym.Domain.Entities;

namespace Gym.Domain.Interfaces
{
    public interface ISuscripcionRepository
    {
        void Add(Suscripcion suscripcion);
        void Update(Suscripcion suscripcion);
        void Delete(int id);
        Suscripcion GetById(int id);
        Suscripcion GetByName(string nombre);
        List<Suscripcion> GetAll();
    }
}

