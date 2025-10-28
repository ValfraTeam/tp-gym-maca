using System;
using System.Drawing;
using System.Windows.Forms;
using Gym.Domain.Entities;

namespace Gym.Presentation
{
	 public partial class Inicio : Form
    {
        private readonly Administrador admin = new()
        {
            mail = "admin@gmail.com",
            contraseña = "admin123"
        };

        public Inicio()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Ingreso.Enabled = false;
        }

        private void Verificar()
        {
            bool emailValido = !string.IsNullOrWhiteSpace(Email.Text) && Email.Text == admin.mail;
            bool contraseñaValida = !string.IsNullOrWhiteSpace(Contraseña.Text) && Contraseña.Text == admin.contraseña;
            Ingreso.Enabled = emailValido && contraseñaValida;
            if (!emailValido)
            {
                errorProvider1.SetError(Email, "Correo electrónico inválido.");
            }
            else
            {
                errorProvider1.SetError(Email, string.Empty);
            }
            if (!contraseñaValida)
            {
                errorProvider1.SetError(Contraseña, "Contraseña inválida.");
            }
            else
            {
                errorProvider1.SetError(Contraseña, string.Empty);
            }
        }
        private void Email_TextChanged(object sender, EventArgs e)
        {
            Verificar();
        }

        private void Contraseña_TextChanged(object sender, EventArgs e)
        {
            Verificar();
        }

        private void Ingreso_Click(object sender, EventArgs e)
        {
            

        }

        private void Ingreso_Click_1(object sender, EventArgs e)
        {
            using (Menu menu = new Menu(Email.Text, Contraseña.Text)) { menu.ShowDialog(); }
        }
    }
}