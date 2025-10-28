using Gym.Infrastructure.Data;
﻿namespace Gym.Presentation.Reportes
{
    partial class Reportes
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
            Volver = new Button();
            label6 = new Label();
            ABMSuscrip = new Button();
            ABMCliente = new Button();
            SuspendLayout();
            // 
            // Volver
            // 
            Volver.BackColor = Color.Red;
            Volver.Font = new Font("Tahoma", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Volver.ForeColor = SystemColors.ControlLightLight;
            Volver.Location = new Point(649, 387);
            Volver.Name = "Volver";
            Volver.Size = new Size(105, 36);
            Volver.TabIndex = 44;
            Volver.Text = "volver!";
            Volver.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Verdana", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label6.Location = new Point(351, 96);
            label6.Name = "label6";
            label6.Size = new Size(109, 20);
            label6.TabIndex = 43;
            label6.Text = "REPORTES";
            // 
            // ABMSuscrip
            // 
            ABMSuscrip.Location = new Point(64, 179);
            ABMSuscrip.Name = "ABMSuscrip";
            ABMSuscrip.Size = new Size(293, 81);
            ABMSuscrip.TabIndex = 47;
            ABMSuscrip.Text = "Ver ganancias";
            ABMSuscrip.UseVisualStyleBackColor = true;
            // 
            // ABMCliente
            // 
            ABMCliente.Location = new Point(459, 179);
            ABMCliente.Name = "ABMCliente";
            ABMCliente.Size = new Size(293, 81);
            ABMCliente.TabIndex = 46;
            ABMCliente.Text = "Ver clientes";
            ABMCliente.UseVisualStyleBackColor = true;
            // 
            // Reportes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ABMSuscrip);
            Controls.Add(ABMCliente);
            Controls.Add(Volver);
            Controls.Add(label6);
            Name = "Reportes";
            Text = "Resportes";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button Volver;
        private Label label6;
        private Button ABMSuscrip;
        private Button ABMCliente;
    }
}