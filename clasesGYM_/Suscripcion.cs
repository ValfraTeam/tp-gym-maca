using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clasesGYM_
{
    public class Suscripcion
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public decimal Precio { get; set; }
      
        // Navegación N:M a través de SuscripcionCliente
        public List<SuscripcionCliente> Clientes { get; set; } = new List<SuscripcionCliente>();
    }
}