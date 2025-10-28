using Gym.Domain.Entities;
using Gym.Domain.Interfaces;

namespace Gym.Application.Services
{
    public class ClaseService
    {
        private readonly IClaseRepository _repository;

        public ClaseService(IClaseRepository repository)
        {
            _repository = repository ?? throw new ArgumentNullException(nameof(repository));
        }

        public void AgregarClase(Clase clase)
        {
            // Validaciones simples
            if (string.IsNullOrWhiteSpace(clase.Nombre))
                throw new ArgumentException("El nombre de la clase es obligatorio");
            
            if (string.IsNullOrWhiteSpace(clase.Profesor))
                throw new ArgumentException("El nombre del profesor es obligatorio");

            _repository.Agregar(clase);
        }

        public List<Clase> ObtenerTodasLasClases()
        {
            return _repository.ObtenerActivas();
        }

        public Clase? ObtenerClasePorId(int id)
        {
            return _repository.ObtenerPorId(id);
        }

        public void ActualizarClase(Clase clase)
        {
            _repository.Actualizar(clase);
        }

        public void EliminarClase(int id)
        {
            _repository.Desactivar(id);
        }

        public void DesactivarClase(int id)
        {
            _repository.Desactivar(id);
        }
    }
}
