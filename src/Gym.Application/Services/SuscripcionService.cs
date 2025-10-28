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
            // Validaciones simples
            if (string.IsNullOrWhiteSpace(suscripcion.Nombre))
                throw new ArgumentException("El nombre de la suscripción es obligatorio");
            
            if (suscripcion.Precio <= 0)
                throw new ArgumentException("El precio debe ser mayor a 0");

            _repository.Add(suscripcion);
        }

        public List<Suscripcion> ObtenerTodasLasSuscripciones()
        {
            return _repository.GetAll();
        }

        public Suscripcion? ObtenerSuscripcionPorId(int id)
        {
            return _repository.GetById(id);
        }
    }
}

