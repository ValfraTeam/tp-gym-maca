namespace frontGYM_
{
    partial class ModificarCliente
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            button1 = new Button();
            Volver = new Button();
            Nombre = new TextBox();
            Apellido = new TextBox();
            Direccion = new TextBox();
            Telefono = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Verdana", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label6.Location = new Point(190, 22);
            label6.Name = "label6";
            label6.Size = new Size(208, 20);
            label6.TabIndex = 6;
            label6.Text = "MODIFICAR CLIENTE";
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(349, 65);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(542, 378);
            dataGridView1.TabIndex = 7;
            dataGridView1.CellClick += dataGridView1_CellClick;
            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(31, 72);
            label2.Name = "label2";
            label2.Size = new Size(64, 20);
            label2.TabIndex = 9;
            label2.Text = "Nombre";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(29, 122);
            label3.Name = "label3";
            label3.Size = new Size(66, 20);
            label3.TabIndex = 10;
            label3.Text = "Apellido";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(23, 165);
            label4.Name = "label4";
            label4.Size = new Size(72, 20);
            label4.TabIndex = 11;
            label4.Text = "Dirección";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(28, 208);
            label5.Name = "label5";
            label5.Size = new Size(67, 20);
            label5.TabIndex = 12;
            label5.Text = "Teléfono";
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ScrollBar;
            button1.Location = new Point(106, 372);
            button1.Name = "button1";
            button1.Size = new Size(165, 36);
            button1.TabIndex = 15;
            button1.Text = "Modificar!";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Volver
            // 
            Volver.BackColor = Color.Red;
            Volver.Font = new Font("Tahoma", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Volver.ForeColor = SystemColors.ControlLightLight;
            Volver.Location = new Point(874, 482);
            Volver.Name = "Volver";
            Volver.Size = new Size(105, 36);
            Volver.TabIndex = 16;
            Volver.Text = "volver!";
            Volver.UseVisualStyleBackColor = false;
            Volver.Click += Volver_Click;
            // 
            // Nombre
            // 
            Nombre.Location = new Point(117, 65);
            Nombre.Name = "Nombre";
            Nombre.Size = new Size(191, 27);
            Nombre.TabIndex = 17;
            // 
            // Apellido
            // 
            Apellido.Location = new Point(117, 115);
            Apellido.Name = "Apellido";
            Apellido.Size = new Size(191, 27);
            Apellido.TabIndex = 18;
            // 
            // Direccion
            // 
            Direccion.Location = new Point(117, 158);
            Direccion.Name = "Direccion";
            Direccion.Size = new Size(191, 27);
            Direccion.TabIndex = 19;
            // 
            // Telefono
            // 
            Telefono.Location = new Point(117, 201);
            Telefono.Name = "Telefono";
            Telefono.Size = new Size(191, 27);
            Telefono.TabIndex = 20;
            // 
            // ModificarCliente
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1009, 546);
            Controls.Add(Telefono);
            Controls.Add(Direccion);
            Controls.Add(Apellido);
            Controls.Add(Nombre);
            Controls.Add(Volver);
            Controls.Add(button1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(dataGridView1);
            Controls.Add(label6);
            Name = "ModificarCliente";
            Text = "ModificarCliente";
            Load += ModificarCliente_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label6;
        private DataGridView dataGridView1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button button1;
        private Button Volver;
        private TextBox Nombre;
        private TextBox Apellido;
        private TextBox Direccion;
        private TextBox Telefono;
    }
}