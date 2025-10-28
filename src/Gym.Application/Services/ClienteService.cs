using Gym.Domain.Entities;
using Gym.Domain.Interfaces;

namespace Gym.Application.Services
{
    public class ClienteService
    {
        private readonly IClienteRepository _clienteRepository;
        private readonly ISuscripcionClienteRepository _suscripcionClienteRepository;

        public ClienteService(IClienteRepository clienteRepository, ISuscripcionClienteRepository suscripcionClienteRepository)
        {
            _clienteRepository = clienteRepository ?? throw new ArgumentNullException(nameof(clienteRepository));
            _suscripcionClienteRepository = suscripcionClienteRepository ?? throw new ArgumentNullException(nameof(suscripcionClienteRepository));
        }

        public void AgregarClienteConSuscripcion(Cliente cliente, int suscripcionId, DateTime fechaInicio)
        {
            // Validaciones simples
            if (string.IsNullOrWhiteSpace(cliente.Nombre))
                throw new ArgumentException("El nombre es obligatorio");
            
            if (string.IsNullOrWhiteSpace(cliente.Apellido))
                throw new ArgumentException("El apellido es obligatorio");
            
            if (cliente.Dni <= 0)
                throw new ArgumentException("El DNI debe ser válido");

            // Calcular fecha de fin por defecto (1 mes)
            var fechaFin = fechaInicio.AddMonths(1);

            // 1. Crear cliente
            _clienteRepository.Agregar(cliente);

            // 2. Verificar si ya tiene una suscripción activa
            var suscripcionActiva = _suscripcionClienteRepository.ObtenerSuscripcionActiva(cliente.Id);
            if (suscripcionActiva != null)
            {
                // Si ya tiene una activa, terminar la anterior
                suscripcionActiva.FechaFin = DateTime.Now;
                _suscripcionClienteRepository.Actualizar(suscripcionActiva);
            }

            // 3. Crear nueva suscripción
            var suscripcionCliente = new SuscripcionCliente
            {
                ClienteId = cliente.Id,
                SuscripcionId = suscripcionId,
                FechaInicio = fechaInicio,
                FechaFin = fechaFin
            };
            _suscripcionClienteRepository.Agregar(suscripcionCliente);
        }

        public Cliente? ObtenerClientePorDni(int dni)
        {
            return _clienteRepository.ObtenerPorDni(dni);
        }

        public List<Cliente> ObtenerTodosLosClientes()
        {
            return _clienteRepository.ObtenerTodos();
        }

        public void EliminarCliente(int id)
        {
            _clienteRepository.Eliminar(id);
        }

        public void ActualizarCliente(Cliente cliente)
        {
            _clienteRepository.Actualizar(cliente);
        }
    }
}
