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
            txtNombre = new TextBox();
            lblNombre = new Label();
            lblDNI = new Label();
            lblApellido = new Label();
            txtDNI = new TextBox();
            txtApellido = new TextBox();
            btnAregarCliente = new Button();
            btnVolver = new Button();
            SuspendLayout();
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(173, 65);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(261, 23);
            txtNombre.TabIndex = 0;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(98, 73);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(51, 15);
            lblNombre.TabIndex = 1;
            lblNombre.Text = "Nombre";
            // 
            // lblDNI
            // 
            lblDNI.AutoSize = true;
            lblDNI.Location = new Point(98, 170);
            lblDNI.Name = "lblDNI";
            lblDNI.Size = new Size(27, 15);
            lblDNI.TabIndex = 2;
            lblDNI.Text = "DNI";
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Location = new Point(98, 116);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(51, 15);
            lblApellido.TabIndex = 3;
            lblApellido.Text = "Apellido";
            // 
            // txtDNI
            // 
            txtDNI.Location = new Point(173, 162);
            txtDNI.Name = "txtDNI";
            txtDNI.Size = new Size(261, 23);
            txtDNI.TabIndex = 4;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(173, 113);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(261, 23);
            txtApellido.TabIndex = 5;
            // 
            // btnAregarCliente
            // 
            btnAregarCliente.Location = new Point(228, 235);
            btnAregarCliente.Name = "btnAregarCliente";
            btnAregarCliente.Size = new Size(94, 26);
            btnAregarCliente.TabIndex = 6;
            btnAregarCliente.Text = "Aceptar";
            btnAregarCliente.UseVisualStyleBackColor = true;
            btnAregarCliente.Click += btnAregarCliente_Click;
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(377, 362);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(94, 26);
            btnVolver.TabIndex = 7;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // AltaCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(607, 486);
            Controls.Add(btnVolver);
            Controls.Add(btnAregarCliente);
            Controls.Add(txtApellido);
            Controls.Add(txtDNI);
            Controls.Add(lblApellido);
            Controls.Add(lblDNI);
            Controls.Add(lblNombre);
            Controls.Add(txtNombre);
            Name = "AltaCliente";
            Text = "AltaCliente";
            Load += AltaCliente_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNombre;
        private Label lblNombre;
        private Label lblDNI;
        private Label lblApellido;
        private TextBox txtDNI;
        private TextBox txtApellido;
        private Button btnAregarCliente;
        private Button btnVolver;
    }
}