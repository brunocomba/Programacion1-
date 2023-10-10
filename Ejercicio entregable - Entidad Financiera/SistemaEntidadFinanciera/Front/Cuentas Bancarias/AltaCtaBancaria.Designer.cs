namespace Front
{
    partial class AltaCtaBancaria
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AltaCtaBancaria));
            groupBox1 = new GroupBox();
            label1 = new Label();
            groupBox2 = new GroupBox();
            label4 = new Label();
            txtSaldo = new TextBox();
            btnAgregarNuevoCliente = new Button();
            label6 = new Label();
            cmboxTipo = new ComboBox();
            cmboxCliente = new ComboBox();
            btnCrear = new Button();
            label5 = new Label();
            label2 = new Label();
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
            groupBox1.Location = new Point(-2, -11);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1137, 75);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Gadugi", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(377, 29);
            label1.Name = "label1";
            label1.Size = new Size(366, 32);
            label1.TabIndex = 1;
            label1.Text = "NUEVA CUENTA BANCARIA";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.WhiteSmoke;
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(txtSaldo);
            groupBox2.Controls.Add(btnAgregarNuevoCliente);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(cmboxTipo);
            groupBox2.Controls.Add(cmboxCliente);
            groupBox2.Controls.Add(btnCrear);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label2);
            groupBox2.Location = new Point(332, 109);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(466, 400);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(44, 157);
            label4.Name = "label4";
            label4.Size = new Size(40, 16);
            label4.TabIndex = 14;
            label4.Text = "Saldo";
            // 
            // txtSaldo
            // 
            txtSaldo.Location = new Point(146, 157);
            txtSaldo.Name = "txtSaldo";
            txtSaldo.Size = new Size(263, 23);
            txtSaldo.TabIndex = 13;
            // 
            // btnAgregarNuevoCliente
            // 
            btnAgregarNuevoCliente.BackColor = Color.MintCream;
            btnAgregarNuevoCliente.FlatAppearance.BorderSize = 3;
            btnAgregarNuevoCliente.FlatStyle = FlatStyle.Popup;
            btnAgregarNuevoCliente.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnAgregarNuevoCliente.Location = new Point(429, 98);
            btnAgregarNuevoCliente.Name = "btnAgregarNuevoCliente";
            btnAgregarNuevoCliente.Size = new Size(31, 29);
            btnAgregarNuevoCliente.TabIndex = 12;
            btnAgregarNuevoCliente.Text = "+";
            btnAgregarNuevoCliente.UseVisualStyleBackColor = false;
            btnAgregarNuevoCliente.Click += btnAgregarNuevoCliente_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(44, 227);
            label6.Name = "label6";
            label6.Size = new Size(31, 16);
            label6.TabIndex = 11;
            label6.Text = "Tipo";
            // 
            // cmboxTipo
            // 
            cmboxTipo.FormattingEnabled = true;
            cmboxTipo.Location = new Point(146, 220);
            cmboxTipo.Name = "cmboxTipo";
            cmboxTipo.Size = new Size(264, 23);
            cmboxTipo.TabIndex = 10;
            // 
            // cmboxCliente
            // 
            cmboxCliente.FormattingEnabled = true;
            cmboxCliente.Location = new Point(146, 98);
            cmboxCliente.Name = "cmboxCliente";
            cmboxCliente.Size = new Size(264, 23);
            cmboxCliente.TabIndex = 9;
            // 
            // btnCrear
            // 
            btnCrear.BackColor = Color.MintCream;
            btnCrear.FlatAppearance.BorderSize = 3;
            btnCrear.FlatStyle = FlatStyle.Popup;
            btnCrear.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnCrear.Location = new Point(168, 293);
            btnCrear.Name = "btnCrear";
            btnCrear.Size = new Size(154, 35);
            btnCrear.TabIndex = 8;
            btnCrear.Text = "CREAR";
            btnCrear.UseVisualStyleBackColor = false;
            btnCrear.Click += btnCrear_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(146, 19);
            label5.Name = "label5";
            label5.Size = new Size(202, 18);
            label5.TabIndex = 4;
            label5.Text = "DATOS CUENTA BANCARIA";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(43, 100);
            label2.Name = "label2";
            label2.Size = new Size(47, 16);
            label2.TabIndex = 1;
            label2.Text = "Cliente";
            // 
            // btnVolver
            // 
            btnVolver.BackColor = Color.MistyRose;
            btnVolver.FlatAppearance.BorderColor = Color.White;
            btnVolver.FlatAppearance.BorderSize = 3;
            btnVolver.FlatStyle = FlatStyle.Popup;
            btnVolver.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnVolver.Location = new Point(935, 527);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(141, 35);
            btnVolver.TabIndex = 20;
            btnVolver.Text = "VOLVER";
            btnVolver.UseVisualStyleBackColor = false;
            btnVolver.Click += btnVolver_Click;
            // 
            // AltaCtaBancaria
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
            Name = "AltaCtaBancaria";
            StartPosition = FormStartPosition.CenterScreen;
            Load += AltaCtaBancaria_Load;
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
        private Button btnCrear;
        private Label label5;
        private Label label2;
        private Label label6;
        private ComboBox cmboxTipo;
        private ComboBox cmboxCliente;
        private Button btnAgregarNuevoCliente;
        private ToolTip toolTip1;
        private Button btnVolver;
        private Label label4;
        private TextBox txtSaldo;
    }
}