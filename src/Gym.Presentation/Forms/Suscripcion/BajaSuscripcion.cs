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
    public partial class BajaSuscripcion : Form
    {
        private SuscripcionService _suscripcionService;

        public BajaSuscripcion()
        {
            InitializeComponent();
            _suscripcionService = ServiceContainer.SuscripcionService;
        }

        private void BajaSuscripcion_Load(object sender, EventArgs e)
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
                
                // Mostrar información adicional
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
            labelNombre.Text = $"Nombre: {suscripcion.Nombre}";
            labelPrecio.Text = $"Precio: ${suscripcion.Precio:F2}";
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                var suscripcionSeleccionada = comboBoxSuscripciones.SelectedItem as Suscripcion;
                if (suscripcionSeleccionada == null)
                {
                    MessageBox.Show("Por favor, seleccione una suscripción para eliminar.", 
                        "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Confirmar eliminación
                var resultado = MessageBox.Show(
                    $"¿Está seguro que desea eliminar la suscripción '{suscripcionSeleccionada.Nombre}'?\n\n" +
                    "Esta acción no se puede deshacer.",
                    "Confirmar Eliminación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (resultado == DialogResult.Yes)
                {
                    _suscripcionService.EliminarSuscripcion(suscripcionSeleccionada.Id);
                    MessageBox.Show("Suscripción eliminada con éxito.", "Éxito", 
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                    // Recargar la lista
                    CargarSuscripciones();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al eliminar la suscripción: {ex.Message}", "Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
