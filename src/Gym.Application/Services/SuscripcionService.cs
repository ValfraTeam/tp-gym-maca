using Gym.Domain.Entities;
using Gym.Domain.Interfaces;

namespace Gym.Application.Services
{
    public class SuscripcionService
    {
        private readonly ISuscripcionRepository _repository;
        private readonly ISuscripcionClienteRepository _suscripcionClienteRepository;

        public SuscripcionService(ISuscripcionRepository repository, ISuscripcionClienteRepository suscripcionClienteRepository)
        {
            _repository = repository ?? throw new ArgumentNullException(nameof(repository));
            _suscripcionClienteRepository = suscripcionClienteRepository ?? throw new ArgumentNullException(nameof(suscripcionClienteRepository));
        }

        public void AgregarSuscripcion(Suscripcion suscripcion)
        {
            // Validaciones básicas
            if (string.IsNullOrWhiteSpace(suscripcion.Nombre))
                throw new ArgumentException("El nombre de la suscripción es obligatorio");
            
            if (suscripcion.Precio <= 0)
                throw new ArgumentException("El precio debe ser mayor a 0");

            // Normalizar nombre a mayúsculas
            suscripcion.Nombre = suscripcion.Nombre.Trim().ToUpper();

            // Verificar si ya existe una suscripción con el mismo nombre
            var suscripcionExistente = _repository.ObtenerPorNombre(suscripcion.Nombre);
            if (suscripcionExistente != null)
            {
                throw new InvalidOperationException($"Ya existe una suscripción con el nombre '{suscripcion.Nombre}'");
            }

            _repository.Agregar(suscripcion);
        }

        public List<Suscripcion> ObtenerTodasLasSuscripciones()
        {
            return _repository.ObtenerActivas();
        }

        public Suscripcion? ObtenerSuscripcionPorId(int id)
        {
            return _repository.ObtenerPorId(id);
        }

        public void EliminarSuscripcion(int id)
        {
            // Verificar que la suscripción existe
            var suscripcion = _repository.ObtenerPorId(id);
            if (suscripcion == null)
            {
                throw new ArgumentException("La suscripción no existe");
            }

            // Desactivar en lugar de eliminar físicamente
            _repository.Desactivar(id);
        }

        public void DesactivarSuscripcion(int id)
        {
            _repository.Desactivar(id);
        }

        public void ActualizarSuscripcion(Suscripcion suscripcion)
        {
            // Validaciones básicas
            if (string.IsNullOrWhiteSpace(suscripcion.Nombre))
                throw new ArgumentException("El nombre de la suscripción es obligatorio");
            
            if (suscripcion.Precio <= 0)
                throw new ArgumentException("El precio debe ser mayor a 0");

            // Normalizar nombre a mayúsculas
            suscripcion.Nombre = suscripcion.Nombre.Trim().ToUpper();

            // Verificar si ya existe otra suscripción con el mismo nombre (excluyendo la actual)
            var suscripcionExistente = _repository.ObtenerPorNombre(suscripcion.Nombre);
            if (suscripcionExistente != null && suscripcionExistente.Id != suscripcion.Id)
            {
                throw new InvalidOperationException($"Ya existe otra suscripción con el nombre '{suscripcion.Nombre}'");
            }

            _repository.Actualizar(suscripcion);
        }
    }
}

