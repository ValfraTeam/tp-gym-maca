using frontGYM_.Forms_Cliente;
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
    public partial class MenuABMCliente : Form
    {

        public MenuABMCliente()
        {
            InitializeComponent();
        }


        private void AltaCliente_Click(object sender, EventArgs e)
        {
            using (AltaCliente altaClienteForm = new AltaCliente())
            {
                altaClienteForm.ShowDialog();
            }
        }

        private void Volver_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void ActualizarCliente_Click(object sender, EventArgs e)
        {
            using (ModificarCliente modificarClienteForm = new ModificarCliente())
            {
                modificarClienteForm.ShowDialog();
            }
        }

        private void BajaCliente_Click(object sender, EventArgs e)
        {
            using (EliminarCliente eliminarClienteForm = new EliminarCliente())
            {
                eliminarClienteForm.ShowDialog();
            }
        }
    }
}
