namespace Gym.Presentation
{
    partial class ModificarSuscripcion
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
            this.comboBoxSuscripciones = new System.Windows.Forms.ComboBox();
            this.labelTitulo = new System.Windows.Forms.Label();
            this.labelSeleccionar = new System.Windows.Forms.Label();
            this.labelInfoActual = new System.Windows.Forms.Label();
            this.groupBoxModificar = new System.Windows.Forms.GroupBox();
            this.textBoxPrecio = new System.Windows.Forms.TextBox();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.labelPrecio = new System.Windows.Forms.Label();
            this.labelNombre = new System.Windows.Forms.Label();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.groupBoxModificar.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBoxSuscripciones
            // 
            this.comboBoxSuscripciones.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSuscripciones.FormattingEnabled = true;
            this.comboBoxSuscripciones.Location = new System.Drawing.Point(20, 80);
            this.comboBoxSuscripciones.Name = "comboBoxSuscripciones";
            this.comboBoxSuscripciones.Size = new System.Drawing.Size(300, 23);
            this.comboBoxSuscripciones.TabIndex = 0;
            this.comboBoxSuscripciones.SelectedIndexChanged += new System.EventHandler(this.comboBoxSuscripciones_SelectedIndexChanged);
            // 
            // labelTitulo
            // 
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.labelTitulo.Location = new System.Drawing.Point(20, 20);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(220, 25);
            this.labelTitulo.TabIndex = 1;
            this.labelTitulo.Text = "Modificar Suscripción";
            // 
            // labelSeleccionar
            // 
            this.labelSeleccionar.AutoSize = true;
            this.labelSeleccionar.Location = new System.Drawing.Point(20, 60);
            this.labelSeleccionar.Name = "labelSeleccionar";
            this.labelSeleccionar.Size = new System.Drawing.Size(120, 15);
            this.labelSeleccionar.TabIndex = 2;
            this.labelSeleccionar.Text = "Seleccione suscripción:";
            // 
            // labelInfoActual
            // 
            this.labelInfoActual.AutoSize = true;
            this.labelInfoActual.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.labelInfoActual.ForeColor = System.Drawing.Color.Blue;
            this.labelInfoActual.Location = new System.Drawing.Point(20, 120);
            this.labelInfoActual.Name = "labelInfoActual";
            this.labelInfoActual.Size = new System.Drawing.Size(200, 15);
            this.labelInfoActual.TabIndex = 3;
            this.labelInfoActual.Text = "Suscripción seleccionada: ";
            // 
            // groupBoxModificar
            // 
            this.groupBoxModificar.Controls.Add(this.textBoxPrecio);
            this.groupBoxModificar.Controls.Add(this.textBoxNombre);
            this.groupBoxModificar.Controls.Add(this.labelPrecio);
            this.groupBoxModificar.Controls.Add(this.labelNombre);
            this.groupBoxModificar.Location = new System.Drawing.Point(20, 150);
            this.groupBoxModificar.Name = "groupBoxModificar";
            this.groupBoxModificar.Size = new System.Drawing.Size(300, 120);
            this.groupBoxModificar.TabIndex = 4;
            this.groupBoxModificar.TabStop = false;
            this.groupBoxModificar.Text = "Datos a Modificar";
            // 
            // textBoxPrecio
            // 
            this.textBoxPrecio.Location = new System.Drawing.Point(80, 70);
            this.textBoxPrecio.Name = "textBoxPrecio";
            this.textBoxPrecio.Size = new System.Drawing.Size(100, 23);
            this.textBoxPrecio.TabIndex = 3;
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(80, 30);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(200, 23);
            this.textBoxNombre.TabIndex = 2;
            // 
            // labelPrecio
            // 
            this.labelPrecio.AutoSize = true;
            this.labelPrecio.Location = new System.Drawing.Point(15, 73);
            this.labelPrecio.Name = "labelPrecio";
            this.labelPrecio.Size = new System.Drawing.Size(43, 15);
            this.labelPrecio.TabIndex = 1;
            this.labelPrecio.Text = "Precio:";
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Location = new System.Drawing.Point(15, 33);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(54, 15);
            this.labelNombre.TabIndex = 0;
            this.labelNombre.Text = "Nombre:";
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.Orange;
            this.btnModificar.ForeColor = System.Drawing.Color.White;
            this.btnModificar.Location = new System.Drawing.Point(20, 290);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(100, 35);
            this.btnModificar.TabIndex = 5;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(220, 290);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(100, 35);
            this.btnVolver.TabIndex = 6;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // ModificarSuscripcion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 350);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.groupBoxModificar);
            this.Controls.Add(this.labelInfoActual);
            this.Controls.Add(this.labelSeleccionar);
            this.Controls.Add(this.labelTitulo);
            this.Controls.Add(this.comboBoxSuscripciones);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ModificarSuscripcion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Modificar Suscripción";
            this.Load += new System.EventHandler(this.ModificarSuscripcion_Load);
            this.groupBoxModificar.ResumeLayout(false);
            this.groupBoxModificar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxSuscripciones;
        private System.Windows.Forms.Label labelTitulo;
        private System.Windows.Forms.Label labelSeleccionar;
        private System.Windows.Forms.Label labelInfoActual;
        private System.Windows.Forms.GroupBox groupBoxModificar;
        private System.Windows.Forms.TextBox textBoxPrecio;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.Label labelPrecio;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnVolver;
    }
}
