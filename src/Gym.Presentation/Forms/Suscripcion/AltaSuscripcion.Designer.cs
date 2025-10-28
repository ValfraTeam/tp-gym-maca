using System;
using System.Drawing;
using System.Windows.Forms;

﻿namespace Gym.Presentation
{
    partial class AltaSuscripcion
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label2 = new Label();
            label = new Label();
            textbox = new Label();
            Nombre = new TextBox();
            Precio = new TextBox();
            Vigencia = new TextBox();
            label1 = new Label();
            Registro = new Button();
            Volver = new Button();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(199, 108);
            label2.Name = "label2";
            label2.Size = new Size(64, 20);
            label2.TabIndex = 0;
            label2.Text = "Nombre";
            // 
            // label
            // 
            label.AutoSize = true;
            label.Location = new Point(213, 161);
            label.Name = "label";
            label.Size = new Size(50, 20);
            label.TabIndex = 1;
            label.Text = "Precio";
            // 
            // textbox
            // 
            textbox.AutoSize = true;
            textbox.Location = new Point(197, 222);
            textbox.Name = "textbox";
            textbox.Size = new Size(66, 20);
            textbox.TabIndex = 2;
            textbox.Text = "Vigencia";
            // 
            // Nombre
            // 
            Nombre.Location = new Point(288, 101);
            Nombre.Name = "Nombre";
            Nombre.Size = new Size(169, 27);
            Nombre.TabIndex = 3;
            // 
            // Precio
            // 
            Precio.Location = new Point(288, 154);
            Precio.Name = "Precio";
            Precio.Size = new Size(169, 27);
            Precio.TabIndex = 4;
            // 
            // Vigencia
            // 
            Vigencia.Location = new Point(288, 215);
            Vigencia.Name = "Vigencia";
            Vigencia.Size = new Size(169, 27);
            Vigencia.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(277, 31);
            label1.Name = "label1";
            label1.Size = new Size(197, 20);
            label1.TabIndex = 6;
            label1.Text = "ALTA SUSCRIPCIÓN";
            // 
            // Registro
            // 
            Registro.BackColor = SystemColors.GradientInactiveCaption;
            Registro.ForeColor = SystemColors.Desktop;
            Registro.Location = new Point(317, 303);
            Registro.Name = "Registro";
            Registro.Size = new Size(94, 29);
            Registro.TabIndex = 7;
            Registro.Text = "Registrar";
            Registro.UseVisualStyleBackColor = false;
            Registro.Click += Registro_Click;
            // 
            // Volver
            // 
            Volver.BackColor = Color.Red;
            Volver.Font = new Font("Tahoma", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Volver.ForeColor = SystemColors.ControlLightLight;
            Volver.Location = new Point(661, 382);
            Volver.Name = "Volver";
            Volver.Size = new Size(105, 36);
            Volver.TabIndex = 8;
            Volver.Text = "volver!";
            Volver.UseVisualStyleBackColor = false;
            Volver.Click += Volver_Click;
            // 
            // AltaSuscripcion
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Volver);
            Controls.Add(Registro);
            Controls.Add(label1);
            Controls.Add(Vigencia);
            Controls.Add(Precio);
            Controls.Add(Nombre);
            Controls.Add(textbox);
            Controls.Add(label);
            Controls.Add(label2);
            Name = "AltaSuscripcion";
            Text = "AltaSuscripcion";
            Load += AltaSuscripcion_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label label;
        private Label textbox;
        private TextBox Nombre;
        private TextBox Precio;
        private TextBox Vigencia;
        private Label label1;
        private Button Registro;
        private Button Volver;
    }
}