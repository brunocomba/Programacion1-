namespace Front
{
    partial class AltaProfesor
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
            btnVolver = new Button();
            groupBox1 = new GroupBox();
            txtTel = new TextBox();
            label5 = new Label();
            btnAgregar = new Button();
            txtEmail = new TextBox();
            txtApellido = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtNombre = new TextBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btnVolver
            // 
            btnVolver.Font = new Font("Arial Narrow", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnVolver.Location = new Point(620, 390);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(135, 48);
            btnVolver.TabIndex = 12;
            btnVolver.Text = "VOLVER";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtTel);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(btnAgregar);
            groupBox1.Controls.Add(txtEmail);
            groupBox1.Controls.Add(txtApellido);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtNombre);
            groupBox1.Location = new Point(141, 27);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(430, 391);
            groupBox1.TabIndex = 11;
            groupBox1.TabStop = false;
            // 
            // txtTel
            // 
            txtTel.Location = new Point(128, 240);
            txtTel.Name = "txtTel";
            txtTel.Size = new Size(221, 23);
            txtTel.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(128, 19);
            label5.Name = "label5";
            label5.Size = new Size(176, 16);
            label5.TabIndex = 9;
            label5.Text = "DATOS NUEVO PROFESOR";
            // 
            // btnAgregar
            // 
            btnAgregar.Font = new Font("Arial Narrow", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnAgregar.Location = new Point(128, 304);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(135, 48);
            btnAgregar.TabIndex = 2;
            btnAgregar.Text = "AGREGAR";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(128, 178);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(221, 23);
            txtEmail.TabIndex = 8;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(128, 113);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(221, 23);
            txtApellido.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Narrow", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(41, 120);
            label4.Name = "label4";
            label4.Size = new Size(44, 16);
            label4.TabIndex = 6;
            label4.Text = "Apellido";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Narrow", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(41, 185);
            label3.Name = "label3";
            label3.Size = new Size(37, 16);
            label3.TabIndex = 5;
            label3.Text = "E-Mail";
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Narrow", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(37, 247);
            label2.Name = "label2";
            label2.Size = new Size(48, 16);
            label2.TabIndex = 4;
            label2.Text = "Telefono";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Narrow", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(41, 60);
            label1.Name = "label1";
            label1.Size = new Size(45, 16);
            label1.TabIndex = 1;
            label1.Text = "Nombre";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(128, 53);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(221, 23);
            txtNombre.TabIndex = 0;
            // 
            // AltaProfesor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnVolver);
            Controls.Add(groupBox1);
            Name = "AltaProfesor";
            Text = "AltaProfesor";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnVolver;
        private GroupBox groupBox1;
        private Label label5;
        private Button btnAgregar;
        private TextBox txtEmail;
        private TextBox txtApellido;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtNombre;
        private TextBox txtTel;
    }
}