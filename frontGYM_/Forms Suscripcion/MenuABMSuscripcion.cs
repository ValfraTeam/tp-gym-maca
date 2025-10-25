using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frontGYM_
{
    public partial class MenuABMSuscripcion : Form
    {
        public MenuABMSuscripcion()
        {
            InitializeComponent();
        }

        private void AltaSuscripcion_Click(object sender, EventArgs e)
        {
            using (AltaSuscripcion altaSuscripcion = new AltaSuscripcion()) { altaSuscripcion.ShowDialog(); }
        }

        private void Volver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
