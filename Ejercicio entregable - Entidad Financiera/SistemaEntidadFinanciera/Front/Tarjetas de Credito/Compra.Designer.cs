namespace Front
{
    partial class Compra
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Compra));
            btnVolver = new Button();
            groupBox2 = new GroupBox();
            txtPrecio = new TextBox();
            label6 = new Label();
            cmboxNroTarjeta = new ComboBox();
            btnAgregarNuevoCliente = new Button();
            label7 = new Label();
            cmboxTitular = new ComboBox();
            btnComprar = new Button();
            txtDetalle = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label2 = new Label();
            label3 = new Label();
            groupBox1 = new GroupBox();
            label1 = new Label();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btnVolver
            // 
            btnVolver.BackColor = Color.MistyRose;
            btnVolver.FlatAppearance.BorderColor = Color.White;
            btnVolver.FlatAppearance.BorderSize = 3;
            btnVolver.FlatStyle = FlatStyle.Popup;
            btnVolver.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnVolver.Location = new Point(926, 516);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(141, 44);
            btnVolver.TabIndex = 27;
            btnVolver.Text = "VOLVER";
            btnVolver.UseVisualStyleBackColor = false;
            btnVolver.Click += btnVolver_Click;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.WhiteSmoke;
            groupBox2.Controls.Add(txtPrecio);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(cmboxNroTarjeta);
            groupBox2.Controls.Add(btnAgregarNuevoCliente);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(cmboxTitular);
            groupBox2.Controls.Add(btnComprar);
            groupBox2.Controls.Add(txtDetalle);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(label3);
            groupBox2.Location = new Point(327, 104);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(466, 409);
            groupBox2.TabIndex = 26;
            groupBox2.TabStop = false;
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(151, 238);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(263, 23);
            txtPrecio.TabIndex = 30;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(127, 244);
            label6.Name = "label6";
            label6.Size = new Size(16, 17);
            label6.TabIndex = 29;
            label6.Text = "$";
            // 
            // cmboxNroTarjeta
            // 
            cmboxNroTarjeta.DropDownStyle = ComboBoxStyle.DropDownList;
            cmboxNroTarjeta.FormattingEnabled = true;
            cmboxNroTarjeta.Location = new Point(151, 126);
            cmboxNroTarjeta.Name = "cmboxNroTarjeta";
            cmboxNroTarjeta.Size = new Size(263, 23);
            cmboxNroTarjeta.TabIndex = 28;
            // 
            // btnAgregarNuevoCliente
            // 
            btnAgregarNuevoCliente.BackColor = Color.MintCream;
            btnAgregarNuevoCliente.FlatAppearance.BorderSize = 3;
            btnAgregarNuevoCliente.FlatStyle = FlatStyle.Popup;
            btnAgregarNuevoCliente.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnAgregarNuevoCliente.Location = new Point(429, 69);
            btnAgregarNuevoCliente.Name = "btnAgregarNuevoCliente";
            btnAgregarNuevoCliente.Size = new Size(31, 29);
            btnAgregarNuevoCliente.TabIndex = 9;
            btnAgregarNuevoCliente.Text = "+";
            btnAgregarNuevoCliente.UseVisualStyleBackColor = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(38, 245);
            label7.Name = "label7";
            label7.Size = new Size(44, 16);
            label7.TabIndex = 13;
            label7.Text = "Precio";
            // 
            // cmboxTitular
            // 
            cmboxTitular.DropDownStyle = ComboBoxStyle.DropDownList;
            cmboxTitular.FormattingEnabled = true;
            cmboxTitular.Location = new Point(151, 70);
            cmboxTitular.Name = "cmboxTitular";
            cmboxTitular.Size = new Size(261, 23);
            cmboxTitular.TabIndex = 9;
            cmboxTitular.SelectedIndexChanged += cmboxTitular_SelectedIndexChanged;
            // 
            // btnComprar
            // 
            btnComprar.BackColor = Color.MintCream;
            btnComprar.FlatAppearance.BorderSize = 3;
            btnComprar.FlatStyle = FlatStyle.Popup;
            btnComprar.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnComprar.Location = new Point(172, 346);
            btnComprar.Name = "btnComprar";
            btnComprar.Size = new Size(154, 35);
            btnComprar.TabIndex = 8;
            btnComprar.Text = "COMPRAR";
            btnComprar.UseVisualStyleBackColor = false;
            btnComprar.Click += btnComprar_Click;
            // 
            // txtDetalle
            // 
            txtDetalle.Location = new Point(151, 180);
            txtDetalle.Name = "txtDetalle";
            txtDetalle.Size = new Size(263, 23);
            txtDetalle.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(129, 28);
            label5.Name = "label5";
            label5.Size = new Size(181, 18);
            label5.TabIndex = 4;
            label5.Text = "DATOS NUEVA COMPRA";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(38, 187);
            label4.Name = "label4";
            label4.Size = new Size(94, 16);
            label4.TabIndex = 3;
            label4.Text = "Detalle compra";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(38, 77);
            label2.Name = "label2";
            label2.Size = new Size(82, 16);
            label2.TabIndex = 1;
            label2.Text = "Titular tarjeta";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(38, 133);
            label3.Name = "label3";
            label3.Size = new Size(87, 16);
            label3.TabIndex = 2;
            label3.Text = "Nro de Tarjeta";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.SteelBlue;
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(-8, -20);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1137, 87);
            groupBox1.TabIndex = 25;
            groupBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Gadugi", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(431, 40);
            label1.Name = "label1";
            label1.Size = new Size(230, 32);
            label1.TabIndex = 1;
            label1.Text = "NUEVA COMPRA";
            // 
            // Compra
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
            Name = "Compra";
            StartPosition = FormStartPosition.CenterScreen;
            Load += Compra_Load;
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnVolver;
        private GroupBox groupBox2;
        private Button btnAgregarNuevoCliente;
        private Label label7;
        private ComboBox cmboxTitular;
        private Button btnComprar;
        private TextBox txtDetalle;
        private Label label5;
        private Label label4;
        private Label label2;
        private Label label3;
        private GroupBox groupBox1;
        private Label label1;
        private ComboBox cmboxNroTarjeta;
        private Label label6;
        private TextBox txtPrecio;
    }
}