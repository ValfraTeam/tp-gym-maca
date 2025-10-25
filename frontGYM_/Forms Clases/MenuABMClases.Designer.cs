namespace frontGYM_
{
    partial class MenuABMClases
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
            label1 = new Label();
            BajaClase = new Button();
            ModificarClase = new Button();
            AltaClase = new Button();
            SuspendLayout();
            // 
            // Volver
            // 
            Volver.BackColor = Color.Red;
            Volver.Font = new Font("Tahoma", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Volver.ForeColor = SystemColors.ControlLightLight;
            Volver.Location = new Point(658, 380);
            Volver.Name = "Volver";
            Volver.Size = new Size(105, 36);
            Volver.TabIndex = 13;
            Volver.Text = "volver!";
            Volver.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(335, 71);
            label1.Name = "label1";
            label1.Size = new Size(117, 20);
            label1.TabIndex = 12;
            label1.Text = "ABM CLASE";
            // 
            // BajaClase
            // 
            BajaClase.Location = new Point(189, 283);
            BajaClase.Name = "BajaClase";
            BajaClase.Size = new Size(407, 41);
            BajaClase.TabIndex = 11;
            BajaClase.Text = "Dar de baja clase";
            BajaClase.UseVisualStyleBackColor = true;
            // 
            // ModificarClase
            // 
            ModificarClase.Location = new Point(189, 210);
            ModificarClase.Name = "ModificarClase";
            ModificarClase.Size = new Size(407, 41);
            ModificarClase.TabIndex = 10;
            ModificarClase.Text = "Modificar Clase";
            ModificarClase.UseVisualStyleBackColor = true;
            ModificarClase.Click += ModificarClase_Click;
            // 
            // AltaClase
            // 
            AltaClase.Location = new Point(189, 140);
            AltaClase.Name = "AltaClase";
            AltaClase.Size = new Size(407, 41);
            AltaClase.TabIndex = 9;
            AltaClase.Text = "Dar de alta clase";
            AltaClase.UseVisualStyleBackColor = true;
            AltaClase.Click += AltaClase_Click;
            // 
            // MenuABMClases
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Volver);
            Controls.Add(label1);
            Controls.Add(BajaClase);
            Controls.Add(ModificarClase);
            Controls.Add(AltaClase);
            Name = "MenuABMClases";
            Text = "MenuABMClases";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Volver;
        private Label label1;
        private Button BajaClase;
        private Button ModificarClase;
        private Button AltaClase;
    }
}