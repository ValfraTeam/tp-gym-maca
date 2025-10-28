using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gym.Domain.Entities
{
    public class SuscripcionCliente
    {
        // Clave primaria compuesta (ClienteId + SuscripcionId)
        public int ClienteId { get; set; }
        public int SuscripcionId { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        
        // Método para calcular si la suscripción está activa
        public bool EstaActiva()
        {
            var ahora = DateTime.Now;
            return ahora >= FechaInicio && ahora <= FechaFin;
        }
        
        // Navegaciones
        public Cliente Cliente { get; set; }
        public Suscripcion Suscripcion { get; set; }
    }
}
