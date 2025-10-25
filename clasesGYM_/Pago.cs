using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clasesGYM_
{
    public class Pago
    {
        public int Id { get; set; }
        public DateTime FechaPago { get; set; }
        public decimal Monto { get; set; }
        public string MetodoPago { get; set; } 
        public Cliente ClientePago { get; set; }    
        public Suscripcion SuscripcionPago { get; set; }
    }
}
