namespace frontGYM_
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            ABMCliente = new Button();
            titulo = new Label();
            ABMClases = new Button();
            ABMSuscrip = new Button();
            CargarPago = new Button();
            Reportes = new Button();
            Volver = new Button();
            SuspendLayout();
            // 
            // ABMCliente
            // 
            ABMCliente.Location = new Point(573, 101);
            ABMCliente.Name = "ABMCliente";
            ABMCliente.Size = new Size(140, 81);
            ABMCliente.TabIndex = 0;
            ABMCliente.Text = "ABM de clientes";
            ABMCliente.UseVisualStyleBackColor = true;
            ABMCliente.Click += ABMCliente_Click;
            // 
            // titulo
            // 
            titulo.AutoSize = true;
            titulo.Font = new Font("Verdana", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            titulo.Location = new Point(59, 22);
            titulo.Name = "titulo";
            titulo.Size = new Size(571, 22);
            titulo.TabIndex = 1;
            titulo.Text = "Bienvenido, seleccione la actividad que desea realizar: ";
            // 
            // ABMClases
            // 
            ABMClases.Location = new Point(74, 101);
            ABMClases.Name = "ABMClases";
            ABMClases.Size = new Size(140, 81);
            ABMClases.TabIndex = 2;
            ABMClases.Text = "ABM de clases";
            ABMClases.UseVisualStyleBackColor = true;
            ABMClases.Click += ABMClases_Click;
            // 
            // ABMSuscrip
            // 
            ABMSuscrip.Location = new Point(317, 101);
            ABMSuscrip.Name = "ABMSuscrip";
            ABMSuscrip.Size = new Size(140, 81);
            ABMSuscrip.TabIndex = 3;
            ABMSuscrip.Text = "ABM de suscripciones";
            ABMSuscrip.UseVisualStyleBackColor = true;
            ABMSuscrip.Click += ABMSuscrip_Click;
            // 
            // CargarPago
            // 
            CargarPago.Location = new Point(74, 230);
            CargarPago.Name = "CargarPago";
            CargarPago.Size = new Size(140, 81);
            CargarPago.TabIndex = 4;
            CargarPago.Text = "Cargar Pago";
            CargarPago.UseVisualStyleBackColor = true;
            // 
            // Reportes
            // 
            Reportes.Location = new Point(317, 230);
            Reportes.Name = "Reportes";
            Reportes.Size = new Size(140, 81);
            Reportes.TabIndex = 5;
            Reportes.Text = "Ver Reportes";
            Reportes.UseVisualStyleBackColor = true;
            // 
            // Volver
            // 
            Volver.BackColor = Color.Red;
            Volver.Font = new Font("Tahoma", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Volver.ForeColor = SystemColors.ControlLightLight;
            Volver.Location = new Point(654, 381);
            Volver.Name = "Volver";
            Volver.Size = new Size(105, 36);
            Volver.TabIndex = 6;
            Volver.Text = "volver!";
            Volver.UseVisualStyleBackColor = false;
            Volver.Click += Salir_Click;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Volver);
            Controls.Add(Reportes);
            Controls.Add(CargarPago);
            Controls.Add(ABMSuscrip);
            Controls.Add(ABMClases);
            Controls.Add(titulo);
            Controls.Add(ABMCliente);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Menu";
            Text = "Sistema GYM_";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button ABMCliente;
        private Label titulo;
        private Button ABMClases;
        private Button ABMSuscrip;
        private Button CargarPago;
        private Button Reportes;
        private Button Volver;
    }
}