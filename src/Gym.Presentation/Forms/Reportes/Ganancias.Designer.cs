using Gym.Infrastructure.Data;
﻿namespace Gym.Presentation.Reportes
{
    partial class Ganancias
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
            label6 = new Label();
            dataGridView1 = new DataGridView();
            Nombre = new TextBox();
            label1 = new Label();
            Volver = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Verdana", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label6.Location = new Point(351, 35);
            label6.Name = "label6";
            label6.Size = new Size(74, 20);
            label6.TabIndex = 44;
            label6.Text = "PAGOS";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(91, 94);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(627, 188);
            dataGridView1.TabIndex = 45;
            // 
            // Nombre
            // 
            Nombre.Location = new Point(204, 310);
            Nombre.Name = "Nombre";
            Nombre.Size = new Size(204, 27);
            Nombre.TabIndex = 47;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(93, 313);
            label1.Name = "label1";
            label1.Size = new Size(105, 20);
            label1.TabIndex = 46;
            label1.Text = "Ganancia total";
            // 
            // Volver
            // 
            Volver.BackColor = Color.Red;
            Volver.Font = new Font("Tahoma", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Volver.ForeColor = SystemColors.ControlLightLight;
            Volver.Location = new Point(613, 383);
            Volver.Name = "Volver";
            Volver.Size = new Size(105, 36);
            Volver.TabIndex = 48;
            Volver.Text = "volver!";
            Volver.UseVisualStyleBackColor = false;
            // 
            // Ganancias
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Volver);
            Controls.Add(Nombre);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Controls.Add(label6);
            Name = "Ganancias";
            Text = "Ganancias";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label6;
        private DataGridView dataGridView1;
        private TextBox Nombre;
        private Label label1;
        private Button Volver;
    }
}