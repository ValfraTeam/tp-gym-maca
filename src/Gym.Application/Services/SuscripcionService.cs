using Gym.Domain.Entities;
using Gym.Domain.Interfaces;

namespace Gym.Application.Services
{
    public class SuscripcionService
    {
        private readonly ISuscripcionRepository _repository;

        public SuscripcionService(ISuscripcionRepository repository)
        {
            _repository = repository ?? throw new ArgumentNullException(nameof(repository));
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
            return _repository.ObtenerTodas();
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

            // TODO: Aquí se podría agregar validación adicional
            // Por ejemplo, verificar si hay clientes usando esta suscripción
            // antes de permitir la eliminación

            _repository.Eliminar(id);
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

