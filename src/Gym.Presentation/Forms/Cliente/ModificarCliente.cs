using Gym.Infrastructure.Data;
﻿using Gym.Domain.Entities;
using Gym.Infrastructure.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gym.Presentation
{
    public partial class ModificarCliente : Form
    {
        public ModificarCliente()
        {
            InitializeComponent();
        }

        private void ModificarCliente_Load(object sender, EventArgs e)
        {
            using (var context = new ApplicationDbContext())
            {
                var clientes = context.Clientes.ToList();
                dataGridView1.DataSource = clientes;
            }


        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Nombre.Text = dataGridView1.CurrentRow.Cells["Nombre"].Value.ToString();
            Apellido.Text = dataGridView1.CurrentRow.Cells["Apellido"].Value.ToString();
            Direccion.Text = dataGridView1.CurrentRow.Cells["Direccion"].Value.ToString();
            Telefono.Text = dataGridView1.CurrentRow.Cells["Telefono"].Value.ToString();
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
        }
    }
}
