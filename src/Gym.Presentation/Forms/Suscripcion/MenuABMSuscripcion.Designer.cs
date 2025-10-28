using Gym.Infrastructure.Data;
﻿namespace Gym.Presentation
{
    partial class MenuABMSuscripcion
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
            label1 = new Label();
            BajaSuscripcion = new Button();
            ModificarSuscripcion = new Button();
            AltaSuscripcion = new Button();
            Volver = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(304, 73);
            label1.Name = "label1";
            label1.Size = new Size(190, 20);
            label1.TabIndex = 7;
            label1.Text = "ABM SUSCRIPCIÓN";
            // 
            // BajaSuscripcion
            // 
            BajaSuscripcion.Location = new Point(187, 283);
            BajaSuscripcion.Name = "BajaSuscripcion";
            BajaSuscripcion.Size = new Size(407, 41);
            BajaSuscripcion.TabIndex = 6;
            BajaSuscripcion.Text = "Dar de baja suscripción";
            BajaSuscripcion.UseVisualStyleBackColor = true;
            // 
            // ModificarSuscripcion
            // 
            ModificarSuscripcion.Location = new Point(187, 210);
            ModificarSuscripcion.Name = "ModificarSuscripcion";
            ModificarSuscripcion.Size = new Size(407, 41);
            ModificarSuscripcion.TabIndex = 5;
            ModificarSuscripcion.Text = "Modificar Suscripción";
            ModificarSuscripcion.UseVisualStyleBackColor = true;
            // 
            // AltaSuscripcion
            // 
            AltaSuscripcion.Location = new Point(187, 140);
            AltaSuscripcion.Name = "AltaSuscripcion";
            AltaSuscripcion.Size = new Size(407, 41);
            AltaSuscripcion.TabIndex = 4;
            AltaSuscripcion.Text = "Dar de alta suscripción";
            AltaSuscripcion.UseVisualStyleBackColor = true;
            AltaSuscripcion.Click += AltaSuscripcion_Click;
            // 
            // Volver
            // 
            Volver.BackColor = Color.Red;
            Volver.Font = new Font("Tahoma", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Volver.ForeColor = SystemColors.ControlLightLight;
            Volver.Location = new Point(656, 380);
            Volver.Name = "Volver";
            Volver.Size = new Size(105, 36);
            Volver.TabIndex = 8;
            Volver.Text = "volver!";
            Volver.UseVisualStyleBackColor = false;
            Volver.Click += Volver_Click;
            // 
            // MenuABMSuscripcion
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Volver);
            Controls.Add(label1);
            Controls.Add(BajaSuscripcion);
            Controls.Add(ModificarSuscripcion);
            Controls.Add(AltaSuscripcion);
            Name = "MenuABMSuscripcion";
            Text = "MenuABMSuscripcion";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button BajaSuscripcion;
        private Button ModificarSuscripcion;
        private Button AltaSuscripcion;
        private Button Volver;
    }
}