using Gym.Application.Services;
using Gym.Application;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Gym.Domain.Entities;  

namespace Gym.Presentation
{
    public partial class AltaCliente : Form
    {
        public AltaCliente()
        {
            InitializeComponent();
        }

        private void Volver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Registro_Click(object sender, EventArgs e)
        {
            try
            {
                var tipoSuscripcion = comboBox1.SelectedItem as Suscripcion;
                if (tipoSuscripcion == null)
                {
                    MessageBox.Show("Por favor, seleccione un tipo de suscripción.");
                    return;
                }

                // Validar campos obligatorios
                if (string.IsNullOrWhiteSpace(Nombre.Text) || string.IsNullOrWhiteSpace(Apellido.Text))
                {
                    MessageBox.Show("Por favor, complete todos los campos obligatorios.");
                    return;
                }

                // Crear cliente (sin suscripción)
                var nuevoCliente = new Cliente
                {
                    Dni = int.Parse(Dni.Text),
                    Direccion = Direccion.Text,
                    Nombre = Nombre.Text.Trim(),
                    Apellido = Apellido.Text.Trim(),
                    Telefono = int.Parse(Telefono.Text)
                };

                var fechaInicio = FechaInicio.Value;

                // Usar el servicio para agregar cliente con suscripción
                // El servicio calculará automáticamente la fecha de fin (1 mes por defecto)
                ServiceContainer.ClienteService.AgregarClienteConSuscripcion(
                    nuevoCliente, 
                    tipoSuscripcion.Id, 
                    fechaInicio
                );

                MessageBox.Show("Cliente registrado con éxito.");
                this.Close();
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, ingrese valores numéricos válidos para DNI y Teléfono.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al registrar el cliente: {ex.Message}");
            }
        }

        private void AltaCliente_Load(object sender, EventArgs e)
        {
            comboBox1.DataSource = ServiceContainer.SuscripcionService.ObtenerTodasLasSuscripciones();
            comboBox1.DisplayMember = "Nombre";
        }
    }
}
