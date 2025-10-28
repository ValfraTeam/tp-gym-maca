using Gym.Application.Services;
using Gym.Infrastructure.Data;
using Gym.Infrastructure.Repositories;
﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using Gym.Domain.Entities;

namespace Gym.Presentation
{
    public partial class AltaSuscripcion : Form
    {
        private void AltaSuscripcion_Load(object sender, EventArgs e)
        {
            
        }
        public AltaSuscripcion()
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
                // Validar campos obligatorios
                if (string.IsNullOrWhiteSpace(Nombre.Text))
                {
                    MessageBox.Show("Por favor, ingrese el nombre de la suscripción.");
                    return;
                }

                if (string.IsNullOrWhiteSpace(Precio.Text))
                {
                    MessageBox.Show("Por favor, ingrese el precio de la suscripción.");
                    return;
                }

                // Crear nueva suscripción (sin Vigencia)
                var nuevaSuscripcion = new Suscripcion
                {
                    Nombre = Nombre.Text.Trim(),
                    Precio = decimal.Parse(Precio.Text)
                };

                // Usar el servicio (maneja validaciones de negocio)
                var suscripcionService = new SuscripcionService(
                    new SuscripcionRepository(new ApplicationDbContext())
                );
                suscripcionService.AgregarSuscripcion(nuevaSuscripcion);
                
                MessageBox.Show("Suscripción registrada con éxito.");
                this.Close();
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, ingrese un precio válido (solo números).");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al registrar la suscripción: {ex.Message}");
            }
        }


    }
}
