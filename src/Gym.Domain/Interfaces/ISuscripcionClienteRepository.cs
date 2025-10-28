using Gym.Domain.Entities;

namespace Gym.Domain.Interfaces
{
    public interface ISuscripcionClienteRepository
    {
        void Agregar(SuscripcionCliente suscripcionCliente);
        void Actualizar(SuscripcionCliente suscripcionCliente);
        void Eliminar(int id);
        SuscripcionCliente? ObtenerPorId(int id);
        List<SuscripcionCliente> ObtenerPorClienteId(int clienteId);
        SuscripcionCliente? ObtenerSuscripcionActiva(int clienteId);
        List<SuscripcionCliente> ObtenerSuscripcionesActivas();
        List<SuscripcionCliente> ObtenerTodas();
    }
}

