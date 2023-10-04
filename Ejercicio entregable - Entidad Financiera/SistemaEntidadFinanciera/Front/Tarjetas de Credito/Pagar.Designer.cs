namespace Front.Tarjetas_de_Credito
{
    partial class Pagar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pagar));
            btnVolver = new Button();
            groupBox2 = new GroupBox();
            txtMonto = new TextBox();
            label6 = new Label();
            cmboxNroTarjeta = new ComboBox();
            label7 = new Label();
            cmboxTitular = new ComboBox();
            btnPagar = new Button();
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
            btnVolver.Location = new Point(926, 521);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(141, 43);
            btnVolver.TabIndex = 30;
            btnVolver.Text = "VOLVER";
            btnVolver.UseVisualStyleBackColor = false;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.WhiteSmoke;
            groupBox2.Controls.Add(txtMonto);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(cmboxNroTarjeta);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(cmboxTitular);
            groupBox2.Controls.Add(btnPagar);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(label3);
            groupBox2.Location = new Point(327, 109);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(466, 408);
            groupBox2.TabIndex = 29;
            groupBox2.TabStop = false;
            // 
            // txtMonto
            // 
            txtMonto.Location = new Point(151, 199);
            txtMonto.Name = "txtMonto";
            txtMonto.Size = new Size(263, 23);
            txtMonto.TabIndex = 30;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(127, 205);
            label6.Name = "label6";
            label6.Size = new Size(16, 17);
            label6.TabIndex = 29;
            label6.Text = "$";
            // 
            // cmboxNroTarjeta
            // 
            cmboxNroTarjeta.DropDownStyle = ComboBoxStyle.DropDownList;
            cmboxNroTarjeta.FormattingEnabled = true;
            cmboxNroTarjeta.Location = new Point(151, 138);
            cmboxNroTarjeta.Name = "cmboxNroTarjeta";
            cmboxNroTarjeta.Size = new Size(263, 23);
            cmboxNroTarjeta.TabIndex = 28;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(38, 206);
            label7.Name = "label7";
            label7.Size = new Size(75, 16);
            label7.TabIndex = 13;
            label7.Text = "Monto pago";
            // 
            // cmboxTitular
            // 
            cmboxTitular.DropDownStyle = ComboBoxStyle.DropDownList;
            cmboxTitular.FormattingEnabled = true;
            cmboxTitular.Location = new Point(151, 77);
            cmboxTitular.Name = "cmboxTitular";
            cmboxTitular.Size = new Size(261, 23);
            cmboxTitular.TabIndex = 9;
            cmboxTitular.SelectedIndexChanged += cmboxTitular_SelectedIndexChanged;
            // 
            // btnPagar
            // 
            btnPagar.BackColor = Color.MintCream;
            btnPagar.FlatAppearance.BorderSize = 3;
            btnPagar.FlatStyle = FlatStyle.Popup;
            btnPagar.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnPagar.Location = new Point(151, 292);
            btnPagar.Name = "btnPagar";
            btnPagar.Size = new Size(154, 35);
            btnPagar.TabIndex = 8;
            btnPagar.Text = "PAGAR";
            btnPagar.UseVisualStyleBackColor = false;
            btnPagar.Click += btnPagar_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(144, 28);
            label5.Name = "label5";
            label5.Size = new Size(161, 18);
            label5.TabIndex = 4;
            label5.Text = "DATOS PAGO DEUDA";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(38, 84);
            label2.Name = "label2";
            label2.Size = new Size(82, 16);
            label2.TabIndex = 1;
            label2.Text = "Titular tarjeta";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(38, 145);
            label3.Name = "label3";
            label3.Size = new Size(87, 16);
            label3.TabIndex = 2;
            label3.Text = "Nro de Tarjeta";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.SteelBlue;
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(-8, -15);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1137, 86);
            groupBox1.TabIndex = 28;
            groupBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Gadugi", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(373, 36);
            label1.Name = "label1";
            label1.Size = new Size(448, 32);
            label1.TabIndex = 1;
            label1.Text = "PAGAR DEUDA TARJETA CREDITO";
            // 
            // Pagar
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
            Name = "Pagar";
            StartPosition = FormStartPosition.CenterScreen;
            Load += Pagar_Load;
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnVolver;
        private GroupBox groupBox2;
        private TextBox txtMonto;
        private Label label6;
        private ComboBox cmboxNroTarjeta;
        private Label label7;
        private ComboBox cmboxTitular;
        private Button btnPagar;
        private Label label5;
        private Label label2;
        private Label label3;
        private GroupBox groupBox1;
        private Label label1;
    }
}