namespace Front
{
    partial class AltaCurso
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
            cmboxProfesores = new ComboBox();
            label5 = new Label();
            btnAgregar = new Button();
            txtDescripcion = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label1 = new Label();
            txtNombre = new TextBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btnVolver
            // 
            btnVolver.Font = new Font("Arial Narrow", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnVolver.Location = new Point(639, 390);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(135, 48);
            btnVolver.TabIndex = 14;
            btnVolver.Text = "VOLVER";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cmboxProfesores);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(btnAgregar);
            groupBox1.Controls.Add(txtDescripcion);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtNombre);
            groupBox1.Location = new Point(160, 27);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(430, 391);
            groupBox1.TabIndex = 13;
            groupBox1.TabStop = false;
            groupBox1.Enter += groupBox1_Enter;
            // 
            // cmboxProfesores
            // 
            cmboxProfesores.FormattingEnabled = true;
            cmboxProfesores.Location = new Point(123, 194);
            cmboxProfesores.Name = "cmboxProfesores";
            cmboxProfesores.Size = new Size(226, 23);
            cmboxProfesores.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(128, 19);
            label5.Name = "label5";
            label5.Size = new Size(150, 16);
            label5.TabIndex = 9;
            label5.Text = "DATOS NUEVO CURSO";
            // 
            // btnAgregar
            // 
            btnAgregar.Font = new Font("Arial Narrow", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnAgregar.Location = new Point(128, 279);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(135, 48);
            btnAgregar.TabIndex = 2;
            btnAgregar.Text = "AGREGAR";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(128, 129);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(221, 23);
            txtDescripcion.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Narrow", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(41, 136);
            label4.Name = "label4";
            label4.Size = new Size(62, 16);
            label4.TabIndex = 6;
            label4.Text = "Descripcion";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Narrow", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(41, 201);
            label3.Name = "label3";
            label3.Size = new Size(47, 16);
            label3.TabIndex = 5;
            label3.Text = "Profesor";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Narrow", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(41, 76);
            label1.Name = "label1";
            label1.Size = new Size(45, 16);
            label1.TabIndex = 1;
            label1.Text = "Nombre";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(128, 69);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(221, 23);
            txtNombre.TabIndex = 0;
            txtNombre.TextChanged += txtNombre_TextChanged;
            // 
            // AltaCurso
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnVolver);
            Controls.Add(groupBox1);
            Name = "AltaCurso";
            Text = "AltaCurso";
            Load += AltaCurso_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnVolver;
        private GroupBox groupBox1;
        private ComboBox cmboxProfesores;
        private Label label5;
        private Button btnAgregar;
        private TextBox txtDescripcion;
        private Label label4;
        private Label label3;
        private Label label1;
        private TextBox txtNombre;
    }
}