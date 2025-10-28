using Gym.Domain.Entities;

namespace Gym.Domain.Interfaces
{
    public interface IClaseRepository
    {
        void Add(Clase clase);
        void Update(Clase clase);
        void Delete(int id);
        Clase GetById(int id);
        List<Clase> GetAll();
    }
}

