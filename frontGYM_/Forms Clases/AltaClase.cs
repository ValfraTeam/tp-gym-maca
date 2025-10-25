using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using clasesGYM_;
using clasesGYM_.Repositorios;

namespace frontGYM_.Forms_Clases
{
    public partial class AltaClase : Form
    {
        public AltaClase()
        {
            InitializeComponent();
        }
        private void AltaClase_Load(object sender, EventArgs e)
        {
        }

        private void CrearClase_Click(object sender, EventArgs e)
        {
            using (AplicationDbContext context = new AplicationDbContext())
            {
                var horario = comboBox1.SelectedItem as Clase;
                if (horario == null)
                {
                    MessageBox.Show("Por favor, seleccione un tipo de suscripción.");
                    return;
                }

                var nuevaClase = new Clase
                {
                    Nombre = Nombre.Text,
                    Profesor = Profesor.Text
                };
                ClaseRepository.AgregarClase(nuevaClase);
                MessageBox.Show("Clase creada con éxito.");
            }
        }

        private void Volver_Click(object sender, EventArgs e)
        {
            this.Close();           
        }
    }
}
