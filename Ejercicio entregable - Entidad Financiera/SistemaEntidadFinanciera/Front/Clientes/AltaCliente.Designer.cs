namespace Front
{
    partial class AltaCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AltaCliente));
            groupBox1 = new GroupBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            groupBox2 = new GroupBox();
            btnCrear = new Button();
            txtApellido = new TextBox();
            txtDNI = new TextBox();
            txtNombre = new TextBox();
            label5 = new Label();
            label4 = new Label();
            btnVolver = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.SteelBlue;
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(-3, -10);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1123, 83);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Gadugi", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(457, 32);
            label1.Name = "label1";
            label1.Size = new Size(219, 32);
            label1.TabIndex = 1;
            label1.Text = "NUEVO CLIENTE";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(52, 100);
            label2.Name = "label2";
            label2.Size = new Size(52, 16);
            label2.TabIndex = 1;
            label2.Text = "Nombre";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(52, 150);
            label3.Name = "label3";
            label3.Size = new Size(53, 16);
            label3.TabIndex = 2;
            label3.Text = "Apellido";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.WhiteSmoke;
            groupBox2.Controls.Add(btnCrear);
            groupBox2.Controls.Add(txtApellido);
            groupBox2.Controls.Add(txtDNI);
            groupBox2.Controls.Add(txtNombre);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(label3);
            groupBox2.Location = new Point(334, 98);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(466, 400);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            // 
            // btnCrear
            // 
            btnCrear.BackColor = Color.MintCream;
            btnCrear.FlatAppearance.BorderSize = 3;
            btnCrear.FlatStyle = FlatStyle.Popup;
            btnCrear.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnCrear.Location = new Point(165, 301);
            btnCrear.Name = "btnCrear";
            btnCrear.Size = new Size(154, 35);
            btnCrear.TabIndex = 8;
            btnCrear.Text = "CREAR";
            btnCrear.UseVisualStyleBackColor = false;
            btnCrear.Click += btnCrear_Click;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(134, 148);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(263, 23);
            txtApellido.TabIndex = 7;
            // 
            // txtDNI
            // 
            txtDNI.Location = new Point(134, 207);
            txtDNI.Name = "txtDNI";
            txtDNI.Size = new Size(263, 23);
            txtDNI.TabIndex = 6;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(134, 93);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(263, 23);
            txtNombre.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(154, 19);
            label5.Name = "label5";
            label5.Size = new Size(165, 18);
            label5.TabIndex = 4;
            label5.Text = "DATOS PERSONALES";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(52, 214);
            label4.Name = "label4";
            label4.Size = new Size(28, 16);
            label4.TabIndex = 3;
            label4.Text = "DNI";
            // 
            // btnVolver
            // 
            btnVolver.BackColor = Color.MistyRose;
            btnVolver.FlatAppearance.BorderColor = Color.White;
            btnVolver.FlatAppearance.BorderSize = 3;
            btnVolver.FlatStyle = FlatStyle.Popup;
            btnVolver.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnVolver.Location = new Point(930, 527);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(141, 35);
            btnVolver.TabIndex = 9;
            btnVolver.Text = "VOLVER";
            btnVolver.UseVisualStyleBackColor = false;
            btnVolver.Click += btnVolver_Click;
            // 
            // AltaCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1120, 574);
            Controls.Add(btnVolver);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "AltaCliente";
            StartPosition = FormStartPosition.CenterScreen;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private GroupBox groupBox2;
        private TextBox txtApellido;
        private TextBox txtDNI;
        private TextBox txtNombre;
        private Label label5;
        private Label label4;
        private Button btnCrear;
        private Button btnVolver;
    }
}