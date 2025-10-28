using System;
using System.Drawing;
using System.Windows.Forms;

namespace Gym.Presentation
{
	// Formulario Inicio mínimo y válido. Ajusta controles y eventos según tu UI.
	public partial class Inicio : Form
	{
		public Inicio()
		{
			InitializeComponent(); // Método generado por el diseñador (no volver a declarar)

			// Añade aquí modificaciones/controles adicionales sin recrear InitializeComponent
			var labelBienvenida = new Label
			{
				Text = "Bienvenido al sistema GYM",
				AutoSize = true,
				Location = new Point(20, 20)
			};
			this.Controls.Add(labelBienvenida);
		}

		// Métodos que el Designer espera (stubs mínimos para compilar).
		private void Email_TextChanged(object sender, EventArgs e)
		{
			// TODO: validar o reaccionar al cambio del email
		}

		private void Contraseña_TextChanged(object sender, EventArgs e)
		{
			// TODO: validar o reaccionar al cambio de contraseña
		}

		private void Ingreso_Click_1(object sender, EventArgs e)
		{
			// TODO: lógica de ingreso; por ahora un mensaje mínimo para verificar el evento
			MessageBox.Show("Botón Ingreso pulsado.", "Ingreso", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			// TODO: inicializaciones al cargar el formulario
		}
	}
}
