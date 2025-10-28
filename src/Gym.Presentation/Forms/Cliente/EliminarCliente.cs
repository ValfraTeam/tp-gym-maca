using Gym.Application.Services;
using Gym.Application;
﻿using System;
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
    public partial class EliminarCliente : Form
    {
        private ClienteService _clienteService;
        private Cliente? _clienteEncontrado;

        public EliminarCliente()
        {
            InitializeComponent();
            _clienteService = ServiceContainer.ClienteService;
        }

        private void Volver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EliminarCliente_Load(object sender, EventArgs e)
        {
            // Configurar controles iniciales
            LimpiarFormulario();
        }

        private void LimpiarFormulario()
        {
            // Usar controles existentes o crear mensaje simple
            _clienteEncontrado = null;
            MostrarInformacionCliente(null);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                // Usar InputBox para obtener DNI
                string dniTexto = Microsoft.VisualBasic.Interaction.InputBox(
                    "Ingrese el DNI del cliente a buscar:", 
                    "Buscar Cliente", 
                    "");

                if (string.IsNullOrWhiteSpace(dniTexto))
                    return;

                if (!int.TryParse(dniTexto, out int dni))
                {
                    MessageBox.Show("Por favor, ingrese un DNI válido (solo números).", 
                        "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                _clienteEncontrado = _clienteService.ObtenerClientePorDni(dni);
                
                if (_clienteEncontrado == null)
                {
                    MessageBox.Show($"No se encontró ningún cliente con DNI: {dni}", 
                        "Cliente no encontrado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MostrarInformacionCliente(null);
                }
                else
                {
                    MostrarInformacionCliente(_clienteEncontrado);
                    // Preguntar si quiere eliminar
                    var resultado = MessageBox.Show(
                        $"Cliente encontrado:\n\n" +
                        $"Nombre: {_clienteEncontrado.Nombre} {_clienteEncontrado.Apellido}\n" +
                        $"DNI: {_clienteEncontrado.Dni}\n\n" +
                        "¿Desea eliminar este cliente?",
                        "Confirmar Eliminación",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question);

                    if (resultado == DialogResult.Yes)
                    {
                        EliminarClienteSeleccionado();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al buscar cliente: {ex.Message}", "Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MostrarInformacionCliente(Cliente? cliente)
        {
            if (cliente == null)
            {
                MessageBox.Show("No hay cliente seleccionado.");
            }
            else
            {
                MessageBox.Show(
                    $"Información del Cliente:\n\n" +
                    $"Nombre: {cliente.Nombre}\n" +
                    $"Apellido: {cliente.Apellido}\n" +
                    $"DNI: {cliente.Dni}\n" +
                    $"Dirección: {cliente.Direccion}\n" +
                    $"Teléfono: {cliente.Telefono}",
                    "Información del Cliente",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }

        private void EliminarClienteSeleccionado()
        {
            try
            {
                if (_clienteEncontrado == null)
                {
                    MessageBox.Show("No hay cliente para eliminar.", 
                        "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Confirmar eliminación
                var resultado = MessageBox.Show(
                    $"¿Está seguro que desea eliminar al cliente?\n\n" +
                    $"Nombre: {_clienteEncontrado.Nombre} {_clienteEncontrado.Apellido}\n" +
                    $"DNI: {_clienteEncontrado.Dni}\n\n" +
                    "Esta acción NO se puede deshacer.",
                    "Confirmar Eliminación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (resultado == DialogResult.Yes)
                {
                    _clienteService.EliminarCliente(_clienteEncontrado.Id);
                    MessageBox.Show("Cliente eliminado con éxito.", "Éxito", 
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                    // Limpiar formulario
                    LimpiarFormulario();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al eliminar el cliente: {ex.Message}", "Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
