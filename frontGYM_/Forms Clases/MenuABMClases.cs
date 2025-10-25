using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using frontGYM_.Forms_Clases;

namespace frontGYM_
{
    public partial class MenuABMClases : Form
    {
        public MenuABMClases()
        {
            InitializeComponent();
        }

        private void AltaClase_Click(object sender, EventArgs e)
        {
            using (AltaClase altaClase = new AltaClase()) { altaClase.ShowDialog(); }
        }

        private void ModificarClase_Click(object sender, EventArgs e)
        {

        }
    }
}
