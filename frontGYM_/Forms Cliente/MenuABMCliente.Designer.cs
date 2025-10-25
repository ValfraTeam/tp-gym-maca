namespace frontGYM_
{
    partial class MenuABMCliente
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
            AltaCliente = new Button();
            ActualizarCliente = new Button();
            BajaCliente = new Button();
            label1 = new Label();
            Volver = new Button();
            SuspendLayout();
            // 
            // AltaCliente
            // 
            AltaCliente.Location = new Point(207, 128);
            AltaCliente.Name = "AltaCliente";
            AltaCliente.Size = new Size(407, 41);
            AltaCliente.TabIndex = 0;
            AltaCliente.Text = "Dar de alta cliente";
            AltaCliente.UseVisualStyleBackColor = true;
            AltaCliente.Click += AltaCliente_Click;
            // 
            // ActualizarCliente
            // 
            ActualizarCliente.Location = new Point(207, 198);
            ActualizarCliente.Name = "ActualizarCliente";
            ActualizarCliente.Size = new Size(407, 41);
            ActualizarCliente.TabIndex = 1;
            ActualizarCliente.Text = "Actualizar cliente";
            ActualizarCliente.UseVisualStyleBackColor = true;
            ActualizarCliente.Click += ActualizarCliente_Click;
            // 
            // BajaCliente
            // 
            BajaCliente.Location = new Point(207, 271);
            BajaCliente.Name = "BajaCliente";
            BajaCliente.Size = new Size(407, 41);
            BajaCliente.TabIndex = 2;
            BajaCliente.Text = "Dar de baja cliente";
            BajaCliente.UseVisualStyleBackColor = true;
            BajaCliente.Click += BajaCliente_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(337, 61);
            label1.Name = "label1";
            label1.Size = new Size(151, 20);
            label1.TabIndex = 3;
            label1.Text = "ABM CLIENTES";
            // 
            // Volver
            // 
            Volver.BackColor = Color.Red;
            Volver.Font = new Font("Tahoma", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Volver.ForeColor = SystemColors.ControlLightLight;
            Volver.Location = new Point(714, 413);
            Volver.Name = "Volver";
            Volver.Size = new Size(105, 36);
            Volver.TabIndex = 7;
            Volver.Text = "volver!";
            Volver.UseVisualStyleBackColor = false;
            Volver.Click += Volver_Click;
            // 
            // MenuABMCliente
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(850, 479);
            Controls.Add(Volver);
            Controls.Add(label1);
            Controls.Add(BajaCliente);
            Controls.Add(ActualizarCliente);
            Controls.Add(AltaCliente);
            Name = "MenuABMCliente";
            Text = "MenuABMCliente";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button AltaCliente;
        private Button ActualizarCliente;
        private Button BajaCliente;
        private Label label1;
        private Button Volver;
    }
}