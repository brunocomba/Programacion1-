namespace Front.INICIO
{
    partial class Menu
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
            GroupBox groupBox2;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            label2 = new Label();
            label1 = new Label();
            groupBox1 = new GroupBox();
            button2 = new Button();
            btnCrear = new Button();
            button1 = new Button();
            panelClientes = new Panel();
            btnListaClientes = new Button();
            btnAgregarCliente = new Button();
            panelCtaBancaria = new Panel();
            btnTransferir = new Button();
            btnExtraer = new Button();
            btnDeposito = new Button();
            btnListaCtas = new Button();
            btnAddCta = new Button();
            panelTarjetaCredit = new Panel();
            btnResumen = new Button();
            btnListaTarjetas = new Button();
            btnAltaTarjeta = new Button();
            groupBox2 = new GroupBox();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            panelClientes.SuspendLayout();
            panelCtaBancaria.SuspendLayout();
            panelTarjetaCredit.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.Gold;
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(label1);
            groupBox2.FlatStyle = FlatStyle.Popup;
            groupBox2.Location = new Point(0, 0);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(342, 74);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 9.75F, FontStyle.Italic, GraphicsUnit.Point);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(18, 54);
            label2.Name = "label2";
            label2.Size = new Size(313, 16);
            label2.TabIndex = 2;
            label2.Text = "La entidad financiera del club mas grande del mundo";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Gadugi", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(18, 19);
            label1.Name = "label1";
            label1.Size = new Size(199, 35);
            label1.TabIndex = 1;
            label1.Text = "BOCA BANK  ";
            label1.Click += label1_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.SteelBlue;
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(btnCrear);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Location = new Point(-6, -13);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1141, 152);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            // 
            // button2
            // 
            button2.BackColor = Color.LightYellow;
            button2.Cursor = Cursors.Hand;
            button2.FlatAppearance.BorderSize = 3;
            button2.FlatStyle = FlatStyle.Popup;
            button2.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(593, 98);
            button2.Name = "button2";
            button2.Size = new Size(154, 42);
            button2.TabIndex = 11;
            button2.Text = "TARJETAS DE CREDITO";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // btnCrear
            // 
            btnCrear.BackColor = Color.LightYellow;
            btnCrear.Cursor = Cursors.Hand;
            btnCrear.FlatAppearance.BorderSize = 3;
            btnCrear.FlatStyle = FlatStyle.Popup;
            btnCrear.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnCrear.Location = new Point(63, 98);
            btnCrear.Name = "btnCrear";
            btnCrear.Size = new Size(154, 42);
            btnCrear.TabIndex = 9;
            btnCrear.Text = "CLIENTES";
            btnCrear.UseVisualStyleBackColor = false;
            btnCrear.Click += btnCrear_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.LightYellow;
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderSize = 3;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(328, 98);
            button1.Name = "button1";
            button1.Size = new Size(154, 42);
            button1.TabIndex = 10;
            button1.Text = "CUENTAS BANCARIAS";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // panelClientes
            // 
            panelClientes.BackColor = Color.LightYellow;
            panelClientes.BorderStyle = BorderStyle.FixedSingle;
            panelClientes.Controls.Add(btnListaClientes);
            panelClientes.Controls.Add(btnAgregarCliente);
            panelClientes.Location = new Point(57, 145);
            panelClientes.Name = "panelClientes";
            panelClientes.Size = new Size(154, 96);
            panelClientes.TabIndex = 4;
            panelClientes.Visible = false;
            // 
            // btnListaClientes
            // 
            btnListaClientes.BackColor = Color.LightYellow;
            btnListaClientes.Cursor = Cursors.Hand;
            btnListaClientes.FlatAppearance.BorderSize = 3;
            btnListaClientes.FlatStyle = FlatStyle.Popup;
            btnListaClientes.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnListaClientes.Location = new Point(-1, 43);
            btnListaClientes.Name = "btnListaClientes";
            btnListaClientes.Size = new Size(154, 52);
            btnListaClientes.TabIndex = 12;
            btnListaClientes.Text = "Listado clientes";
            btnListaClientes.UseVisualStyleBackColor = false;
            btnListaClientes.Click += btnListaClientes_Click;
            // 
            // btnAgregarCliente
            // 
            btnAgregarCliente.BackColor = Color.LightYellow;
            btnAgregarCliente.Cursor = Cursors.Hand;
            btnAgregarCliente.FlatAppearance.BorderSize = 3;
            btnAgregarCliente.FlatStyle = FlatStyle.Popup;
            btnAgregarCliente.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnAgregarCliente.Location = new Point(-1, -1);
            btnAgregarCliente.Name = "btnAgregarCliente";
            btnAgregarCliente.Size = new Size(154, 47);
            btnAgregarCliente.TabIndex = 11;
            btnAgregarCliente.Text = "Agregar nuevo Cliente";
            btnAgregarCliente.UseVisualStyleBackColor = false;
            btnAgregarCliente.Click += btnAgregarCliente_Click;
            // 
            // panelCtaBancaria
            // 
            panelCtaBancaria.BackColor = Color.LightYellow;
            panelCtaBancaria.BorderStyle = BorderStyle.FixedSingle;
            panelCtaBancaria.Controls.Add(btnTransferir);
            panelCtaBancaria.Controls.Add(btnExtraer);
            panelCtaBancaria.Controls.Add(btnDeposito);
            panelCtaBancaria.Controls.Add(btnListaCtas);
            panelCtaBancaria.Controls.Add(btnAddCta);
            panelCtaBancaria.Location = new Point(322, 145);
            panelCtaBancaria.Name = "panelCtaBancaria";
            panelCtaBancaria.Size = new Size(154, 238);
            panelCtaBancaria.TabIndex = 5;
            panelCtaBancaria.Visible = false;
            // 
            // btnTransferir
            // 
            btnTransferir.BackColor = Color.LightYellow;
            btnTransferir.Cursor = Cursors.Hand;
            btnTransferir.FlatAppearance.BorderSize = 3;
            btnTransferir.FlatStyle = FlatStyle.Popup;
            btnTransferir.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnTransferir.Location = new Point(-1, 92);
            btnTransferir.Name = "btnTransferir";
            btnTransferir.Size = new Size(154, 52);
            btnTransferir.TabIndex = 15;
            btnTransferir.Text = "Tranferir dinero";
            btnTransferir.UseVisualStyleBackColor = false;
            btnTransferir.Click += btnTransferir_Click;
            // 
            // btnExtraer
            // 
            btnExtraer.BackColor = Color.LightYellow;
            btnExtraer.Cursor = Cursors.Hand;
            btnExtraer.FlatAppearance.BorderSize = 3;
            btnExtraer.FlatStyle = FlatStyle.Popup;
            btnExtraer.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnExtraer.Location = new Point(-1, 136);
            btnExtraer.Name = "btnExtraer";
            btnExtraer.Size = new Size(154, 52);
            btnExtraer.TabIndex = 14;
            btnExtraer.Text = "Extraer dinero";
            btnExtraer.UseVisualStyleBackColor = false;
            btnExtraer.Click += btnExtraer_Click;
            // 
            // btnDeposito
            // 
            btnDeposito.BackColor = Color.LightYellow;
            btnDeposito.Cursor = Cursors.Hand;
            btnDeposito.FlatAppearance.BorderSize = 3;
            btnDeposito.FlatStyle = FlatStyle.Popup;
            btnDeposito.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnDeposito.Location = new Point(-1, 43);
            btnDeposito.Name = "btnDeposito";
            btnDeposito.Size = new Size(154, 52);
            btnDeposito.TabIndex = 13;
            btnDeposito.Text = "Realizar deposito";
            btnDeposito.UseVisualStyleBackColor = false;
            btnDeposito.Click += btnDeposito_Click;
            // 
            // btnListaCtas
            // 
            btnListaCtas.BackColor = Color.LightYellow;
            btnListaCtas.Cursor = Cursors.Hand;
            btnListaCtas.FlatAppearance.BorderSize = 3;
            btnListaCtas.FlatStyle = FlatStyle.Popup;
            btnListaCtas.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnListaCtas.Location = new Point(-1, 185);
            btnListaCtas.Name = "btnListaCtas";
            btnListaCtas.Size = new Size(154, 52);
            btnListaCtas.TabIndex = 12;
            btnListaCtas.Text = "Listado cuentas";
            btnListaCtas.UseVisualStyleBackColor = false;
            btnListaCtas.Click += btnListaCtas_Click;
            // 
            // btnAddCta
            // 
            btnAddCta.BackColor = Color.LightYellow;
            btnAddCta.Cursor = Cursors.Hand;
            btnAddCta.FlatAppearance.BorderSize = 3;
            btnAddCta.FlatStyle = FlatStyle.Popup;
            btnAddCta.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnAddCta.Location = new Point(-1, -1);
            btnAddCta.Name = "btnAddCta";
            btnAddCta.Size = new Size(154, 47);
            btnAddCta.TabIndex = 11;
            btnAddCta.Text = "Crear nueva Cta Bancaria";
            btnAddCta.UseVisualStyleBackColor = false;
            btnAddCta.Click += btnAddCta_Click;
            // 
            // panelTarjetaCredit
            // 
            panelTarjetaCredit.BackColor = Color.LightYellow;
            panelTarjetaCredit.BorderStyle = BorderStyle.FixedSingle;
            panelTarjetaCredit.Controls.Add(btnResumen);
            panelTarjetaCredit.Controls.Add(btnListaTarjetas);
            panelTarjetaCredit.Controls.Add(btnAltaTarjeta);
            panelTarjetaCredit.Location = new Point(587, 145);
            panelTarjetaCredit.Name = "panelTarjetaCredit";
            panelTarjetaCredit.Size = new Size(154, 147);
            panelTarjetaCredit.TabIndex = 13;
            panelTarjetaCredit.Visible = false;
            // 
            // btnResumen
            // 
            btnResumen.BackColor = Color.LightYellow;
            btnResumen.Cursor = Cursors.Hand;
            btnResumen.FlatAppearance.BorderSize = 3;
            btnResumen.FlatStyle = FlatStyle.Popup;
            btnResumen.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnResumen.Location = new Point(-1, 46);
            btnResumen.Name = "btnResumen";
            btnResumen.Size = new Size(154, 52);
            btnResumen.TabIndex = 13;
            btnResumen.Text = "Generar resumen";
            btnResumen.UseVisualStyleBackColor = false;
            // 
            // btnListaTarjetas
            // 
            btnListaTarjetas.BackColor = Color.LightYellow;
            btnListaTarjetas.Cursor = Cursors.Hand;
            btnListaTarjetas.FlatAppearance.BorderSize = 3;
            btnListaTarjetas.FlatStyle = FlatStyle.Popup;
            btnListaTarjetas.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnListaTarjetas.Location = new Point(-1, 92);
            btnListaTarjetas.Name = "btnListaTarjetas";
            btnListaTarjetas.Size = new Size(154, 52);
            btnListaTarjetas.TabIndex = 12;
            btnListaTarjetas.Text = "Listado tarjetas de credito";
            btnListaTarjetas.UseVisualStyleBackColor = false;
            btnListaTarjetas.Click += btnListaTarjetas_Click;
            // 
            // btnAltaTarjeta
            // 
            btnAltaTarjeta.BackColor = Color.LightYellow;
            btnAltaTarjeta.Cursor = Cursors.Hand;
            btnAltaTarjeta.FlatAppearance.BorderSize = 3;
            btnAltaTarjeta.FlatStyle = FlatStyle.Popup;
            btnAltaTarjeta.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnAltaTarjeta.Location = new Point(-1, -1);
            btnAltaTarjeta.Name = "btnAltaTarjeta";
            btnAltaTarjeta.Size = new Size(154, 47);
            btnAltaTarjeta.TabIndex = 11;
            btnAltaTarjeta.Text = "Emitir nueva tarjeta de credito";
            btnAltaTarjeta.UseVisualStyleBackColor = false;
            btnAltaTarjeta.Click += btnAltaTarjeta_Click;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SlateGray;
            ClientSize = new Size(1120, 574);
            Controls.Add(panelTarjetaCredit);
            Controls.Add(panelCtaBancaria);
            Controls.Add(panelClientes);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Menu";
            StartPosition = FormStartPosition.CenterScreen;
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            panelClientes.ResumeLayout(false);
            panelCtaBancaria.ResumeLayout(false);
            panelTarjetaCredit.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label1;
        private GroupBox groupBox2;
        private Button btnCrear;
        private Button button2;
        private Button button1;
        private Label label2;
        private Panel panelClientes;
        private Button btnListaClientes;
        private Button btnAgregarCliente;
        private Panel panelCtaBancaria;
        private Button btnListaCtas;
        private Button btnAddCta;
        private Panel panelTarjetaCredit;
        private Button btnListaTarjetas;
        private Button btnAltaTarjeta;
        private Button btnTransferir;
        private Button btnExtraer;
        private Button btnDeposito;
        private Button btnResumen;
    }
}