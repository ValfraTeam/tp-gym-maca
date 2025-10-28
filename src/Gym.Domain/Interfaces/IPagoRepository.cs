using Gym.Domain.Entities;

namespace Gym.Domain.Interfaces
{
    public interface IPagoRepository
    {
        void Add(Pago pago);
        void Update(Pago pago);
        void Delete(int id);
        Pago GetById(int id);
        List<Pago> GetAll();
    }
}

