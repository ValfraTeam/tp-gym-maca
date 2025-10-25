using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frontGYM_.Forms_Cliente
{
    public partial class EliminarCliente : Form
    {
        public EliminarCliente()
        {
            InitializeComponent();
        }

        private void Volver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EliminarCliente_Load(object sender, EventArgs e)
        {
            using (var context = new AplicationDbContext())
            {
                var clientes = context.Clientes.ToList();
                dataGridView1.DataSource = clientes;
            }
        }
    }
}
