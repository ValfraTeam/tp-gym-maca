using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using clasesGYM_;
using clasesGYM_.Repositorios;  

namespace frontGYM_
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
                 // Calcular fecha de fin por defecto por 1 mes
                var fechaFin = fechaInicio.AddMonths(1); 

                // Usar el nuevo método que maneja la relación N:M
                SuscripcionClienteRepository.AgregarClienteConSuscripcion(
                    nuevoCliente, 
                    tipoSuscripcion.Id, 
                    fechaInicio, 
                    fechaFin
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
            comboBox1.DataSource = SuscripcionRepository.ObtenerSuscripciones();
            comboBox1.DisplayMember = "Nombre";
        }
    }
}
