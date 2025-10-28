using Gym.Domain.Entities;

namespace Gym.Domain.Interfaces
{
    public interface ISuscripcionClienteRepository
    {
        void Add(SuscripcionCliente suscripcionCliente);
        void Update(SuscripcionCliente suscripcionCliente);
        void Delete(int id);
        SuscripcionCliente GetById(int id);
        List<SuscripcionCliente> GetByClienteId(int clienteId);
        SuscripcionCliente GetSuscripcionActiva(int clienteId);
        List<SuscripcionCliente> GetSuscripcionesActivas();
        List<SuscripcionCliente> GetAll();
    }
}

