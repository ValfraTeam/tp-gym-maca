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
    public partial class ModificarSuscripcion : Form
    {
        private SuscripcionService _suscripcionService;
        private Suscripcion? _suscripcionSeleccionada;

        public ModificarSuscripcion()
        {
            InitializeComponent();
            _suscripcionService = ServiceContainer.SuscripcionService;
        }

        private void ModificarSuscripcion_Load(object sender, EventArgs e)
        {
            CargarSuscripciones();
        }

        private void CargarSuscripciones()
        {
            try
            {
                var suscripciones = _suscripcionService.ObtenerTodasLasSuscripciones();
                comboBoxSuscripciones.DataSource = suscripciones;
                comboBoxSuscripciones.DisplayMember = "Nombre";
                comboBoxSuscripciones.ValueMember = "Id";
                
                // Mostrar información de la primera suscripción si existe
                if (suscripciones.Any())
                {
                    MostrarInformacionSuscripcion(suscripciones.First());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar suscripciones: {ex.Message}", "Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void comboBoxSuscripciones_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxSuscripciones.SelectedItem is Suscripcion suscripcion)
            {
                MostrarInformacionSuscripcion(suscripcion);
            }
        }

        private void MostrarInformacionSuscripcion(Suscripcion suscripcion)
        {
            _suscripcionSeleccionada = suscripcion;
            textBoxNombre.Text = suscripcion.Nombre;
            textBoxPrecio.Text = suscripcion.Precio.ToString("F2");
            
            // Mostrar información actual
            labelInfoActual.Text = $"Suscripción seleccionada: {suscripcion.Nombre} - ${suscripcion.Precio:F2}";
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                if (_suscripcionSeleccionada == null)
                {
                    MessageBox.Show("Por favor, seleccione una suscripción para modificar.", 
                        "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Validar campos obligatorios
                if (string.IsNullOrWhiteSpace(textBoxNombre.Text))
                {
                    MessageBox.Show("Por favor, ingrese el nombre de la suscripción.", 
                        "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (string.IsNullOrWhiteSpace(textBoxPrecio.Text))
                {
                    MessageBox.Show("Por favor, ingrese el precio de la suscripción.", 
                        "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Validar precio numérico
                if (!decimal.TryParse(textBoxPrecio.Text, out decimal precio))
                {
                    MessageBox.Show("Por favor, ingrese un precio válido (solo números).", 
                        "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (precio <= 0)
                {
                    MessageBox.Show("El precio debe ser mayor a 0.", 
                        "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Confirmar modificación
                var resultado = MessageBox.Show(
                    $"¿Está seguro que desea modificar la suscripción '{_suscripcionSeleccionada.Nombre}'?\n\n" +
                    $"Nuevo nombre: {textBoxNombre.Text.Trim()}\n" +
                    $"Nuevo precio: ${precio:F2}",
                    "Confirmar Modificación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (resultado == DialogResult.Yes)
                {
                    // Actualizar la suscripción
                    _suscripcionSeleccionada.Nombre = textBoxNombre.Text.Trim().ToUpper();
                    _suscripcionSeleccionada.Precio = precio;

                    _suscripcionService.ActualizarSuscripcion(_suscripcionSeleccionada);
                    
                    MessageBox.Show("Suscripción modificada con éxito.", "Éxito", 
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                    // Recargar la lista
                    CargarSuscripciones();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al modificar la suscripción: {ex.Message}", "Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
