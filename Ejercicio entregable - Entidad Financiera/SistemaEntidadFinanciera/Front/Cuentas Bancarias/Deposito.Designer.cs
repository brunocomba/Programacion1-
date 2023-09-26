namespace Front
{
    partial class Deposito
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Deposito));
            btnVolver = new Button();
            groupBox2 = new GroupBox();
            label8 = new Label();
            label7 = new Label();
            cmboxTitular = new ComboBox();
            cmboxCuenta = new ComboBox();
            btnDepositar = new Button();
            txtImporte = new TextBox();
            label5 = new Label();
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
            btnVolver.Location = new Point(929, 529);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(141, 38);
            btnVolver.TabIndex = 23;
            btnVolver.Text = "VOLVER";
            btnVolver.UseVisualStyleBackColor = false;
            btnVolver.Click += btnVolver_Click;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.WhiteSmoke;
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(cmboxTitular);
            groupBox2.Controls.Add(cmboxCuenta);
            groupBox2.Controls.Add(btnDepositar);
            groupBox2.Controls.Add(txtImporte);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(label3);
            groupBox2.Location = new Point(326, 111);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(466, 406);
            groupBox2.TabIndex = 22;
            groupBox2.TabStop = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(127, 245);
            label8.Name = "label8";
            label8.Size = new Size(14, 16);
            label8.TabIndex = 12;
            label8.Text = "$";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(32, 106);
            label7.Name = "label7";
            label7.Size = new Size(85, 16);
            label7.TabIndex = 11;
            label7.Text = "Titular cuenta";
            // 
            // cmboxTitular
            // 
            cmboxTitular.FormattingEnabled = true;
            cmboxTitular.Location = new Point(140, 99);
            cmboxTitular.Name = "cmboxTitular";
            cmboxTitular.Size = new Size(271, 23);
            cmboxTitular.TabIndex = 10;
            cmboxTitular.SelectedIndexChanged += cmboxTitular_SelectedIndexChanged;
            // 
            // cmboxCuenta
            // 
            cmboxCuenta.FormattingEnabled = true;
            cmboxCuenta.Location = new Point(140, 162);
            cmboxCuenta.Name = "cmboxCuenta";
            cmboxCuenta.Size = new Size(271, 23);
            cmboxCuenta.TabIndex = 9;
            // 
            // btnDepositar
            // 
            btnDepositar.BackColor = Color.MintCream;
            btnDepositar.FlatAppearance.BorderSize = 3;
            btnDepositar.FlatStyle = FlatStyle.Popup;
            btnDepositar.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnDepositar.Location = new Point(156, 326);
            btnDepositar.Name = "btnDepositar";
            btnDepositar.Size = new Size(154, 41);
            btnDepositar.TabIndex = 8;
            btnDepositar.Text = "DEPOSITAR";
            btnDepositar.UseVisualStyleBackColor = false;
            btnDepositar.Click += btnDepositar_Click;
            // 
            // txtImporte
            // 
            txtImporte.Location = new Point(140, 243);
            txtImporte.Name = "txtImporte";
            txtImporte.Size = new Size(271, 23);
            txtImporte.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(156, 38);
            label5.Name = "label5";
            label5.Size = new Size(142, 18);
            label5.TabIndex = 4;
            label5.Text = "DATOS DEPOSITO";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(32, 169);
            label2.Name = "label2";
            label2.Size = new Size(95, 16);
            label2.TabIndex = 1;
            label2.Text = "Cuenta numero";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(67, 245);
            label3.Name = "label3";
            label3.Size = new Size(50, 16);
            label3.TabIndex = 2;
            label3.Text = "Importe";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.SteelBlue;
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(-8, -9);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1137, 78);
            groupBox1.TabIndex = 21;
            groupBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Gadugi", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(334, 32);
            label1.Name = "label1";
            label1.Size = new Size(484, 32);
            label1.TabIndex = 1;
            label1.Text = "REALIZAR DEPOSITO CTA BANCARIA";
            // 
            // Deposito
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1120, 574);
            Controls.Add(btnVolver);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Deposito";
            StartPosition = FormStartPosition.CenterScreen;
            Load += Deposito_Load;
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnVolver;
        private GroupBox groupBox2;
        private Label label4;
        private TextBox txtSaldo;
        private Button btnAgregarNuevoCliente;
        private Label label6;
        private Button btnDepositar;
        private TextBox txtImporte;
        private Label label5;
        private Label label2;
        private Label label3;
        private GroupBox groupBox1;
        private Label label1;
        private ComboBox cmboxCuenta;
        private Label label8;
        private Label label7;
        private ComboBox cmboxTitular;
    }
}