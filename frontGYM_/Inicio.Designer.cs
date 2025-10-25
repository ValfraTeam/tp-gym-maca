namespace frontGYM_
{
    partial class Inicio
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inicio));
            label1 = new Label();
            Email = new TextBox();
            Contraseña = new TextBox();
            label2 = new Label();
            label3 = new Label();
            Ingreso = new Button();
            label4 = new Label();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(334, 85);
            label1.Name = "label1";
            label1.Size = new Size(111, 20);
            label1.TabIndex = 0;
            label1.Text = "Inicio de sesión";
            // 
            // Email
            // 
            Email.Location = new Point(334, 140);
            Email.Name = "Email";
            Email.Size = new Size(193, 27);
            Email.TabIndex = 1;
            Email.TextChanged += Email_TextChanged;
            // 
            // Contraseña
            // 
            Contraseña.Location = new Point(334, 210);
            Contraseña.Name = "Contraseña";
            Contraseña.Size = new Size(193, 27);
            Contraseña.TabIndex = 2;
            Contraseña.TextChanged += Contraseña_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(272, 147);
            label2.Name = "label2";
            label2.Size = new Size(46, 20);
            label2.TabIndex = 3;
            label2.Text = "Email";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(235, 217);
            label3.Name = "label3";
            label3.Size = new Size(83, 20);
            label3.TabIndex = 4;
            label3.Text = "Contraseña";
            // 
            // Ingreso
            // 
            Ingreso.BackColor = SystemColors.GradientInactiveCaption;
            Ingreso.ForeColor = SystemColors.Desktop;
            Ingreso.Location = new Point(334, 305);
            Ingreso.Name = "Ingreso";
            Ingreso.Size = new Size(94, 29);
            Ingreso.TabIndex = 5;
            Ingreso.Text = "Ingresar";
            Ingreso.UseVisualStyleBackColor = false;
            Ingreso.Click += Ingreso_Click_1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Black", 19.8000011F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label4.Location = new Point(334, 18);
            label4.Name = "label4";
            label4.Size = new Size(101, 46);
            label4.TabIndex = 6;
            label4.Text = "GYM";
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // Inicio
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(Ingreso);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(Contraseña);
            Controls.Add(Email);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Inicio";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox Email;
        private TextBox Contraseña;
        private Label label2;
        private Label label3;
        private Button Ingreso;
        private Label label4;
        private ErrorProvider errorProvider1;
    }
}
