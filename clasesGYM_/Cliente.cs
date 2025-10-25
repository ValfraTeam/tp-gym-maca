using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clasesGYM_
{
    public class Cliente
    {
        public int Id { get; set; }
        public int Dni { get; set; }
        public string Direccion { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Telefono { get; set; }
        
        // Navegación N:M a través de SuscripcionCliente
        public List<SuscripcionCliente> Suscripciones { get; set; } = new List<SuscripcionCliente>();
    }
}
