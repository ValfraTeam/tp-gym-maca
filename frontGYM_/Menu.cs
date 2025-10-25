using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frontGYM_
{
    public partial class Menu : Form
    {
        public Menu(string Email, string Contraseña)
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ABMCliente_Click(object sender, EventArgs e)
        {
            using (MenuABMCliente abmCliente = new MenuABMCliente()) { abmCliente.ShowDialog(); }
        }

        private void ABMClases_Click(object sender, EventArgs e)
        {
            using (MenuABMClases abmClases = new MenuABMClases()) { abmClases.ShowDialog(); }
        }

        private void ABMSuscrip_Click(object sender, EventArgs e)
        {
            using (MenuABMSuscripcion abmSuscrip = new MenuABMSuscripcion()) { abmSuscrip.ShowDialog(); }
        }
    }
}
