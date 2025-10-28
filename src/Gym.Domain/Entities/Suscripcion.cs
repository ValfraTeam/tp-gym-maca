using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gym.Domain.Entities
{
    public class Suscripcion
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "El nombre de la suscripción es obligatorio")]
        [StringLength(100, ErrorMessage = "El nombre no puede exceder los 100 caracteres")]
        public string Nombre { get; set; }
        
        [Required(ErrorMessage = "El precio es obligatorio")]
        [Range(0.01, 999999.99, ErrorMessage = "El precio debe ser mayor a 0 y menor a 999999.99")]
        public decimal Precio { get; set; }
      
        // Navegación N:M a través de SuscripcionCliente
        public List<SuscripcionCliente> Clientes { get; set; } = new List<SuscripcionCliente>();
    }
}