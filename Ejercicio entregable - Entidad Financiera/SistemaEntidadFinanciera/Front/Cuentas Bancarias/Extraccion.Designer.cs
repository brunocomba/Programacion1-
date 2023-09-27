namespace Front
{
    partial class Extraccion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Extraccion));
            btnVolver = new Button();
            groupBox2 = new GroupBox();
            label8 = new Label();
            label7 = new Label();
            cmboxTitular = new ComboBox();
            cmboxCuenta = new ComboBox();
            btnExtraer = new Button();
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
            btnVolver.Location = new Point(929, 520);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(141, 42);
            btnVolver.TabIndex = 26;
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
            groupBox2.Controls.Add(btnExtraer);
            groupBox2.Controls.Add(txtImporte);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(label3);
            groupBox2.Location = new Point(326, 109);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(466, 410);
            groupBox2.TabIndex = 25;
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
            // btnExtraer
            // 
            btnExtraer.BackColor = Color.MintCream;
            btnExtraer.FlatAppearance.BorderSize = 3;
            btnExtraer.FlatStyle = FlatStyle.Popup;
            btnExtraer.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnExtraer.Location = new Point(156, 326);
            btnExtraer.Name = "btnExtraer";
            btnExtraer.Size = new Size(154, 41);
            btnExtraer.TabIndex = 8;
            btnExtraer.Text = "EXTRAER";
            btnExtraer.UseVisualStyleBackColor = false;
            btnExtraer.Click += btnExtraer_Click;
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
            label5.Location = new Point(140, 38);
            label5.Name = "label5";
            label5.Size = new Size(214, 18);
            label5.TabIndex = 4;
            label5.Text = "DATOS NUEVA EXTRACCION";
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
            groupBox1.Location = new Point(-8, -11);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1137, 82);
            groupBox1.TabIndex = 24;
            groupBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Gadugi", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(334, 32);
            label1.Name = "label1";
            label1.Size = new Size(522, 32);
            label1.TabIndex = 1;
            label1.Text = "REALIZAR EXTRACCION CTA BANCARIA";
            // 
            // Extraccion
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
            Name = "Extraccion";
            StartPosition = FormStartPosition.CenterScreen;
            Load += Extraccion_Load;
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnVolver;
        private GroupBox groupBox2;
        private Label label8;
        private Label label7;
        private ComboBox cmboxTitular;
        private ComboBox cmboxCuenta;
        private Button btnExtraer;
        private TextBox txtImporte;
        private Label label5;
        private Label label2;
        private Label label3;
        private GroupBox groupBox1;
        private Label label1;
    }
}