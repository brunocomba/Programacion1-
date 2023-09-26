namespace Front
{
    partial class AltaTarjetaCredito
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AltaTarjetaCredito));
            groupBox1 = new GroupBox();
            label1 = new Label();
            groupBox2 = new GroupBox();
            btnAgregarNuevoCliente = new Button();
            label7 = new Label();
            cmboxEstado = new ComboBox();
            cmboxCliente = new ComboBox();
            btnCrear = new Button();
            txtNroTarjeta = new TextBox();
            txtLimiteCredito = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label2 = new Label();
            label3 = new Label();
            toolTip1 = new ToolTip(components);
            btnVolver = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.SteelBlue;
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(0, -9);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1137, 78);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Gadugi", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(322, 28);
            label1.Name = "label1";
            label1.Size = new Size(488, 32);
            label1.TabIndex = 1;
            label1.Text = "EMITIR NUEVA TARJETA DE CREDITO";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.WhiteSmoke;
            groupBox2.Controls.Add(btnAgregarNuevoCliente);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(cmboxEstado);
            groupBox2.Controls.Add(cmboxCliente);
            groupBox2.Controls.Add(btnCrear);
            groupBox2.Controls.Add(txtNroTarjeta);
            groupBox2.Controls.Add(txtLimiteCredito);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(label3);
            groupBox2.Location = new Point(335, 115);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(466, 400);
            groupBox2.TabIndex = 5;
            groupBox2.TabStop = false;
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
            btnAgregarNuevoCliente.Click += btnAgregarNuevoCliente_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(38, 239);
            label7.Name = "label7";
            label7.Size = new Size(48, 16);
            label7.TabIndex = 13;
            label7.Text = "Estado";
            // 
            // cmboxEstado
            // 
            cmboxEstado.FormattingEnabled = true;
            cmboxEstado.Location = new Point(149, 232);
            cmboxEstado.Name = "cmboxEstado";
            cmboxEstado.Size = new Size(263, 23);
            cmboxEstado.TabIndex = 12;
            // 
            // cmboxCliente
            // 
            cmboxCliente.FormattingEnabled = true;
            cmboxCliente.Location = new Point(151, 70);
            cmboxCliente.Name = "cmboxCliente";
            cmboxCliente.Size = new Size(261, 23);
            cmboxCliente.TabIndex = 9;
            // 
            // btnCrear
            // 
            btnCrear.BackColor = Color.MintCream;
            btnCrear.FlatAppearance.BorderSize = 3;
            btnCrear.FlatStyle = FlatStyle.Popup;
            btnCrear.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnCrear.Location = new Point(172, 346);
            btnCrear.Name = "btnCrear";
            btnCrear.Size = new Size(154, 35);
            btnCrear.TabIndex = 8;
            btnCrear.Text = "CREAR";
            btnCrear.UseVisualStyleBackColor = false;
            btnCrear.Click += btnCrear_Click;
            // 
            // txtNroTarjeta
            // 
            txtNroTarjeta.Location = new Point(151, 119);
            txtNroTarjeta.Name = "txtNroTarjeta";
            txtNroTarjeta.Size = new Size(261, 23);
            txtNroTarjeta.TabIndex = 7;
            // 
            // txtLimiteCredito
            // 
            txtLimiteCredito.Location = new Point(151, 170);
            txtLimiteCredito.Name = "txtLimiteCredito";
            txtLimiteCredito.Size = new Size(263, 23);
            txtLimiteCredito.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(129, 19);
            label5.Name = "label5";
            label5.Size = new Size(225, 18);
            label5.TabIndex = 4;
            label5.Text = "DATOS TARJETA DE CREDITO";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(38, 177);
            label4.Name = "label4";
            label4.Size = new Size(105, 16);
            label4.TabIndex = 3;
            label4.Text = "Limite de Credito";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(38, 77);
            label2.Name = "label2";
            label2.Size = new Size(47, 16);
            label2.TabIndex = 1;
            label2.Text = "Cliente";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(38, 126);
            label3.Name = "label3";
            label3.Size = new Size(87, 16);
            label3.TabIndex = 2;
            label3.Text = "Nro de Tarjeta";
            // 
            // btnVolver
            // 
            btnVolver.BackColor = Color.MistyRose;
            btnVolver.FlatAppearance.BorderColor = Color.White;
            btnVolver.FlatAppearance.BorderSize = 3;
            btnVolver.FlatStyle = FlatStyle.Popup;
            btnVolver.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnVolver.Location = new Point(934, 527);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(141, 35);
            btnVolver.TabIndex = 24;
            btnVolver.Text = "VOLVER";
            btnVolver.UseVisualStyleBackColor = false;
            btnVolver.Click += btnVolver_Click;
            // 
            // AltaTarjetaCredito
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
            Name = "AltaTarjetaCredito";
            StartPosition = FormStartPosition.CenterScreen;
            Load += AltaTarjetaCredito_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label1;
        private GroupBox groupBox2;
        private ComboBox cmboxCliente;
        private Button btnCrear;
        private TextBox txtNroTarjeta;
        private TextBox txtLimiteCredito;
        private Label label5;
        private Label label4;
        private Label label2;
        private Label label3;
        private Label label7;
        private ComboBox cmboxEstado;
        private Button btnAgregarNuevoCliente;
        private ToolTip toolTip1;
        private Button btnVolver;
    }
}