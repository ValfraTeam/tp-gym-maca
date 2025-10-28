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
    public partial class ModificarCliente : Form
    {
        private ClienteService _clienteService;
        private Cliente? _clienteSeleccionado;

        public ModificarCliente()
        {
            InitializeComponent();
            _clienteService = ServiceContainer.ClienteService;
        }

        private void ModificarCliente_Load(object sender, EventArgs e)
        {
            CargarClientes();
        }

        private void CargarClientes()
        {
            try
            {
                var clientes = _clienteService.ObtenerTodosLosClientes();
                dataGridView1.DataSource = clientes;
                
                // Configurar columnas del DataGridView
                if (dataGridView1.Columns.Count > 0)
                {
                    dataGridView1.Columns["Id"].Visible = false; // Ocultar ID
                    dataGridView1.Columns["Dni"].HeaderText = "DNI";
                    dataGridView1.Columns["Nombre"].HeaderText = "Nombre";
                    dataGridView1.Columns["Apellido"].HeaderText = "Apellido";
                    dataGridView1.Columns["Direccion"].HeaderText = "Dirección";
                    dataGridView1.Columns["Telefono"].HeaderText = "Teléfono";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar clientes: {ex.Message}", "Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var cliente = dataGridView1.Rows[e.RowIndex].DataBoundItem as Cliente;
                if (cliente != null)
                {
                    _clienteSeleccionado = cliente;
                    CargarDatosCliente(cliente);
                }
            }
        }

        private void CargarDatosCliente(Cliente cliente)
        {
            Nombre.Text = cliente.Nombre;
            Apellido.Text = cliente.Apellido;
            Direccion.Text = cliente.Direccion;
            Telefono.Text = cliente.Telefono.ToString();
        }

        private void Volver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (_clienteSeleccionado == null)
                {
                    MessageBox.Show("Por favor, seleccione un cliente para modificar.", 
                        "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Validar campos obligatorios
                if (string.IsNullOrWhiteSpace(Nombre.Text))
                {
                    MessageBox.Show("Por favor, ingrese el nombre del cliente.", 
                        "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (string.IsNullOrWhiteSpace(Apellido.Text))
                {
                    MessageBox.Show("Por favor, ingrese el apellido del cliente.", 
                        "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (string.IsNullOrWhiteSpace(Direccion.Text))
                {
                    MessageBox.Show("Por favor, ingrese la dirección del cliente.", 
                        "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (string.IsNullOrWhiteSpace(Telefono.Text))
                {
                    MessageBox.Show("Por favor, ingrese el teléfono del cliente.", 
                        "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Validar teléfono numérico
                if (!int.TryParse(Telefono.Text, out int telefono))
                {
                    MessageBox.Show("Por favor, ingrese un teléfono válido (solo números).", 
                        "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Confirmar modificación
                var resultado = MessageBox.Show(
                    $"¿Está seguro que desea modificar al cliente?\n\n" +
                    $"Nombre: {Nombre.Text.Trim()}\n" +
                    $"Apellido: {Apellido.Text.Trim()}\n" +
                    $"DNI: {_clienteSeleccionado.Dni}\n" +
                    $"Dirección: {Direccion.Text.Trim()}\n" +
                    $"Teléfono: {telefono}",
                    "Confirmar Modificación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (resultado == DialogResult.Yes)
                {
                    // Actualizar el cliente
                    _clienteSeleccionado.Nombre = Nombre.Text.Trim();
                    _clienteSeleccionado.Apellido = Apellido.Text.Trim();
                    _clienteSeleccionado.Direccion = Direccion.Text.Trim();
                    _clienteSeleccionado.Telefono = telefono;

                    _clienteService.ActualizarCliente(_clienteSeleccionado);
                    
                    MessageBox.Show("Cliente modificado con éxito.", "Éxito", 
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                    // Recargar la lista
                    CargarClientes();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al modificar el cliente: {ex.Message}", "Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
