using Gym.Infrastructure.Data;
﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Gym.Domain.Entities;
using Gym.Infrastructure.Repositories;

namespace Gym.Presentation
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
            using (ApplicationDbContext context = new ApplicationDbContext())
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
                var claseRepository = new ClaseRepository(new ApplicationDbContext());
                claseRepository.Add(nuevaClase);
                MessageBox.Show("Clase creada con éxito.");
            }
        }

        private void Volver_Click(object sender, EventArgs e)
        {
            this.Close();           
        }
    }
}
