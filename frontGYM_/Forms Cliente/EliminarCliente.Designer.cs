namespace frontGYM_.Forms_Cliente
{
    partial class EliminarCliente
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
            dataGridView1 = new DataGridView();
            label6 = new Label();
            Volver = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            Nombre = new TextBox();
            Apellido = new TextBox();
            Direccion = new TextBox();
            Telefono = new TextBox();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(410, 54);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(488, 357);
            dataGridView1.TabIndex = 0;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Verdana", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label6.Location = new Point(184, 24);
            label6.Name = "label6";
            label6.Size = new Size(194, 20);
            label6.TabIndex = 7;
            label6.Text = "ELIMINAR CLIENTE";
            // 
            // Volver
            // 
            Volver.BackColor = Color.Red;
            Volver.Font = new Font("Tahoma", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Volver.ForeColor = SystemColors.ControlLightLight;
            Volver.Location = new Point(870, 428);
            Volver.Name = "Volver";
            Volver.Size = new Size(105, 36);
            Volver.TabIndex = 17;
            Volver.Text = "volver!";
            Volver.UseVisualStyleBackColor = false;
            Volver.Click += Volver_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(44, 72);
            label1.Name = "label1";
            label1.Size = new Size(64, 20);
            label1.TabIndex = 18;
            label1.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(42, 117);
            label2.Name = "label2";
            label2.Size = new Size(66, 20);
            label2.TabIndex = 19;
            label2.Text = "Apellido";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(36, 158);
            label3.Name = "label3";
            label3.Size = new Size(72, 20);
            label3.TabIndex = 20;
            label3.Text = "Dirección";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(41, 200);
            label4.Name = "label4";
            label4.Size = new Size(67, 20);
            label4.TabIndex = 21;
            label4.Text = "Teléfono";
            // 
            // Nombre
            // 
            Nombre.Location = new Point(130, 69);
            Nombre.Name = "Nombre";
            Nombre.Size = new Size(220, 27);
            Nombre.TabIndex = 24;
            // 
            // Apellido
            // 
            Apellido.Location = new Point(130, 114);
            Apellido.Name = "Apellido";
            Apellido.Size = new Size(220, 27);
            Apellido.TabIndex = 25;
            // 
            // Direccion
            // 
            Direccion.Location = new Point(130, 155);
            Direccion.Name = "Direccion";
            Direccion.Size = new Size(220, 27);
            Direccion.TabIndex = 26;
            // 
            // Telefono
            // 
            Telefono.Location = new Point(130, 197);
            Telefono.Name = "Telefono";
            Telefono.Size = new Size(220, 27);
            Telefono.TabIndex = 27;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ScrollBar;
            button1.Location = new Point(130, 349);
            button1.Name = "button1";
            button1.Size = new Size(165, 36);
            button1.TabIndex = 28;
            button1.Text = "Modificar!";
            button1.UseVisualStyleBackColor = false;
            // 
            // EliminarCliente
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1011, 508);
            Controls.Add(button1);
            Controls.Add(Telefono);
            Controls.Add(Direccion);
            Controls.Add(Apellido);
            Controls.Add(Nombre);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Volver);
            Controls.Add(label6);
            Controls.Add(dataGridView1);
            Name = "EliminarCliente";
            Text = "EliminarCliente";
            Load += EliminarCliente_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label6;
        private Button Volver;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox Nombre;
        private TextBox Apellido;
        private TextBox Direccion;
        private TextBox Telefono;
        private Button button1;
    }
}