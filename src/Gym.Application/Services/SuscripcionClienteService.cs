using Gym.Domain.Entities;
using Gym.Domain.Interfaces;

namespace Gym.Application.Services
{
    public class SuscripcionClienteService
    {
        private readonly ISuscripcionClienteRepository _repository;

        public SuscripcionClienteService(ISuscripcionClienteRepository repository)
        {
            _repository = repository ?? throw new ArgumentNullException(nameof(repository));
        }

        public void AgregarSuscripcionCliente(SuscripcionCliente suscripcionCliente)
        {
            // Validaciones simples
            if (suscripcionCliente.FechaInicio >= suscripcionCliente.FechaFin)
                throw new ArgumentException("La fecha de inicio debe ser anterior a la fecha de fin");
            
            if (suscripcionCliente.ClienteId <= 0)
                throw new ArgumentException("El ID del cliente debe ser válido");
            
            if (suscripcionCliente.SuscripcionId <= 0)
                throw new ArgumentException("El ID de la suscripción debe ser válido");

            // Verificar si ya tiene una suscripción activa
            var suscripcionActiva = _repository.ObtenerSuscripcionActiva(suscripcionCliente.ClienteId);
            if (suscripcionActiva != null)
            {
                // Si ya tiene una activa, terminar la anterior
                suscripcionActiva.FechaFin = DateTime.Now;
                _repository.Actualizar(suscripcionActiva);
            }
            
            // Crear la nueva suscripción
            _repository.Agregar(suscripcionCliente);
        }

        public void CambiarSuscripcion(int clienteId, int nuevaSuscripcionId, DateTime fechaInicio, DateTime fechaFin)
        {
            // 1. Terminar suscripción actual (si existe)
            var suscripcionActual = _repository.ObtenerSuscripcionActiva(clienteId);
            if (suscripcionActual != null)
            {
                // Terminar la suscripción actual estableciendo FechaFin = ahora
                suscripcionActual.FechaFin = DateTime.Now;
                _repository.Actualizar(suscripcionActual);
            }

            // 2. Crear nueva suscripción
            var nuevaSuscripcion = new SuscripcionCliente
            {
                ClienteId = clienteId,
                SuscripcionId = nuevaSuscripcionId,
                FechaInicio = fechaInicio,
                FechaFin = fechaFin
            };
            
            _repository.Agregar(nuevaSuscripcion);
        }

        public SuscripcionCliente? ObtenerSuscripcionActiva(int clienteId)
        {
            return _repository.ObtenerSuscripcionActiva(clienteId);
        }

        public List<SuscripcionCliente> ObtenerSuscripcionesActivas()
        {
            return _repository.ObtenerSuscripcionesActivas();
        }

        public List<SuscripcionCliente> ObtenerHistorialCliente(int clienteId)
        {
            return _repository.ObtenerPorClienteId(clienteId);
        }
    }
}
