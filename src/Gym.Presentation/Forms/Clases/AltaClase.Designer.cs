using Gym.Infrastructure.Data;
﻿namespace Gym.Presentation
{
    partial class AltaClase
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
            button1 = new Button();
            dateTimePicker2 = new DateTimePicker();
            label5 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label4 = new Label();
            label3 = new Label();
            comboBox1 = new ComboBox();
            Profesor = new TextBox();
            label2 = new Label();
            label1 = new Label();
            Nombre = new TextBox();
            label6 = new Label();
            SuspendLayout();
            // 
            // Volver
            // 
            Volver.BackColor = Color.Red;
            Volver.Font = new Font("Tahoma", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Volver.ForeColor = SystemColors.ControlLightLight;
            Volver.Location = new Point(638, 388);
            Volver.Name = "Volver";
            Volver.Size = new Size(105, 36);
            Volver.TabIndex = 23;
            Volver.Text = "volver!";
            Volver.UseVisualStyleBackColor = false;
            Volver.Click += Volver_Click;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ScrollBar;
            button1.Location = new Point(318, 339);
            button1.Name = "button1";
            button1.Size = new Size(165, 36);
            button1.TabIndex = 29;
            button1.Text = "Modificar!";
            button1.UseVisualStyleBackColor = false;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(275, 279);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(298, 27);
            dateTimePicker2.TabIndex = 26;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(109, 284);
            label5.Name = "label5";
            label5.Size = new Size(143, 20);
            label5.TabIndex = 28;
            label5.Text = "Hora de finalización";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(275, 225);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(297, 27);
            dateTimePicker1.TabIndex = 25;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(149, 230);
            label4.Name = "label4";
            label4.Size = new Size(103, 20);
            label4.TabIndex = 27;
            label4.Text = "Hora de inicio";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(214, 179);
            label3.Name = "label3";
            label3.Size = new Size(38, 20);
            label3.TabIndex = 17;
            label3.Text = "Días";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(275, 176);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(297, 28);
            comboBox1.TabIndex = 24;
            // 
            // Profesor
            // 
            Profesor.Location = new Point(275, 128);
            Profesor.Name = "Profesor";
            Profesor.Size = new Size(298, 27);
            Profesor.TabIndex = 20;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(188, 131);
            label2.Name = "label2";
            label2.Size = new Size(64, 20);
            label2.TabIndex = 16;
            label2.Text = "Profesor";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(188, 85);
            label1.Name = "label1";
            label1.Size = new Size(64, 20);
            label1.TabIndex = 15;
            label1.Text = "Nombre";
            // 
            // Nombre
            // 
            Nombre.Location = new Point(275, 82);
            Nombre.Name = "Nombre";
            Nombre.Size = new Size(298, 27);
            Nombre.TabIndex = 19;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Verdana", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label6.Location = new Point(318, 48);
            label6.Name = "label6";
            label6.Size = new Size(138, 20);
            label6.TabIndex = 18;
            label6.Text = "CREAR CLASE";
            // 
            // AltaClase
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(dateTimePicker2);
            Controls.Add(dateTimePicker1);
            Controls.Add(comboBox1);
            Controls.Add(Volver);
            Controls.Add(Profesor);
            Controls.Add(Nombre);
            Controls.Add(label6);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "AltaClase";
            Text = "AltaClase";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox Horario;
        private Button Volver;
        private Button button1;
        private DateTimePicker dateTimePicker2;
        private Label label5;
        private DateTimePicker dateTimePicker1;
        private Label label4;
        private Label label3;
        private ComboBox comboBox1;
        private TextBox Profesor;
        private Label label2;
        private Label label1;
        private TextBox Nombre;
        private Label label6;
    }
}