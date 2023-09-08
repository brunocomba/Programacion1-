namespace Pantalla
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtNombreAnimal = new TextBox();
            label2 = new Label();
            btnAceptarAnimales = new Button();
            label3 = new Label();
            button1 = new Button();
            label1 = new Label();
            comboBoxAnimal = new ComboBox();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            lblVeloFin = new Label();
            txtveloIni = new TextBox();
            btnAcelerar = new Button();
            txtVelocidadFin = new TextBox();
            label7 = new Label();
            cmbVehiculo = new ComboBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            groupBox3 = new GroupBox();
            lblDatoFig2 = new Label();
            lblDatoFig1 = new Label();
            txtDatoFig2 = new TextBox();
            txtDatoFig1 = new TextBox();
            label9 = new Label();
            cmbTipofig = new ComboBox();
            label8 = new Label();
            button2 = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // txtNombreAnimal
            // 
            txtNombreAnimal.Location = new Point(94, 118);
            txtNombreAnimal.Name = "txtNombreAnimal";
            txtNombreAnimal.Size = new Size(130, 23);
            txtNombreAnimal.TabIndex = 4;
            txtNombreAnimal.TextChanged += txtNombreAnimal_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Narrow", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(12, 125);
            label2.Name = "label2";
            label2.Size = new Size(51, 16);
            label2.TabIndex = 1;
            label2.Text = "Nombre: ";
            // 
            // btnAceptarAnimales
            // 
            btnAceptarAnimales.Location = new Point(146, 176);
            btnAceptarAnimales.Name = "btnAceptarAnimales";
            btnAceptarAnimales.Size = new Size(78, 27);
            btnAceptarAnimales.TabIndex = 5;
            btnAceptarAnimales.Text = "Agregar";
            btnAceptarAnimales.UseVisualStyleBackColor = true;
            btnAceptarAnimales.Click += btnAceptarAnimales_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Narrow", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(19, 80);
            label3.Name = "label3";
            label3.Size = new Size(44, 16);
            label3.TabIndex = 3;
            label3.Text = "Animal: ";
            // 
            // button1
            // 
            button1.Location = new Point(19, 176);
            button1.Name = "button1";
            button1.Size = new Size(75, 27);
            button1.TabIndex = 6;
            button1.Text = "Mostrar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Narrow", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(19, 30);
            label1.Name = "label1";
            label1.Size = new Size(159, 29);
            label1.TabIndex = 0;
            label1.Text = "Sonido Animales";
            // 
            // comboBoxAnimal
            // 
            comboBoxAnimal.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxAnimal.FormattingEnabled = true;
            comboBoxAnimal.Location = new Point(94, 73);
            comboBoxAnimal.Name = "comboBoxAnimal";
            comboBoxAnimal.Size = new Size(130, 23);
            comboBoxAnimal.TabIndex = 2;
            comboBoxAnimal.SelectedIndexChanged += comboBoxAnimal_SelectedIndexChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(comboBoxAnimal);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(btnAceptarAnimales);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtNombreAnimal);
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(245, 279);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "Ejercicio 1";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(lblVeloFin);
            groupBox2.Controls.Add(txtveloIni);
            groupBox2.Controls.Add(btnAcelerar);
            groupBox2.Controls.Add(txtVelocidadFin);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(cmbVehiculo);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label4);
            groupBox2.Location = new Point(246, 0);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(386, 279);
            groupBox2.TabIndex = 8;
            groupBox2.TabStop = false;
            groupBox2.Text = "Ejercicio 2";
            groupBox2.Enter += groupBox2_Enter;
            // 
            // lblVeloFin
            // 
            lblVeloFin.AutoSize = true;
            lblVeloFin.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblVeloFin.Location = new Point(4, 195);
            lblVeloFin.Name = "lblVeloFin";
            lblVeloFin.Size = new Size(0, 13);
            lblVeloFin.TabIndex = 12;
            // 
            // txtveloIni
            // 
            txtveloIni.Location = new Point(119, 123);
            txtveloIni.Name = "txtveloIni";
            txtveloIni.Size = new Size(124, 23);
            txtveloIni.TabIndex = 11;
            // 
            // btnAcelerar
            // 
            btnAcelerar.Location = new Point(168, 243);
            btnAcelerar.Name = "btnAcelerar";
            btnAcelerar.Size = new Size(75, 30);
            btnAcelerar.TabIndex = 9;
            btnAcelerar.Text = "Acelerar";
            btnAcelerar.UseVisualStyleBackColor = true;
            btnAcelerar.Click += btnAcelerar_Click;
            // 
            // txtVelocidadFin
            // 
            txtVelocidadFin.Enabled = false;
            txtVelocidadFin.Location = new Point(119, 159);
            txtVelocidadFin.Name = "txtVelocidadFin";
            txtVelocidadFin.Size = new Size(118, 23);
            txtVelocidadFin.TabIndex = 10;
            txtVelocidadFin.TextChanged += textBox1_TextChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(9, 166);
            label7.Name = "label7";
            label7.Size = new Size(106, 16);
            label7.TabIndex = 8;
            label7.Text = "Velocidad Final";
            // 
            // cmbVehiculo
            // 
            cmbVehiculo.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbVehiculo.FormattingEnabled = true;
            cmbVehiculo.Location = new Point(78, 73);
            cmbVehiculo.Name = "cmbVehiculo";
            cmbVehiculo.Size = new Size(137, 23);
            cmbVehiculo.TabIndex = 7;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial Narrow", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(9, 130);
            label6.Name = "label6";
            label6.Size = new Size(88, 16);
            label6.TabIndex = 5;
            label6.Text = "Velocidad Inicial: ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial Narrow", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(9, 80);
            label5.Name = "label5";
            label5.Size = new Size(50, 16);
            label5.TabIndex = 4;
            label5.Text = "Vehiculo:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Narrow", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(21, 30);
            label4.Name = "label4";
            label4.Size = new Size(99, 29);
            label4.TabIndex = 1;
            label4.Text = "Velocidad";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(button2);
            groupBox3.Controls.Add(lblDatoFig2);
            groupBox3.Controls.Add(lblDatoFig1);
            groupBox3.Controls.Add(txtDatoFig2);
            groupBox3.Controls.Add(txtDatoFig1);
            groupBox3.Controls.Add(label9);
            groupBox3.Controls.Add(cmbTipofig);
            groupBox3.Controls.Add(label8);
            groupBox3.Location = new Point(638, 3);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(337, 276);
            groupBox3.TabIndex = 9;
            groupBox3.TabStop = false;
            groupBox3.Text = "Ejercicio 3";
            groupBox3.Enter += groupBox3_Enter;
            // 
            // lblDatoFig2
            // 
            lblDatoFig2.AutoSize = true;
            lblDatoFig2.Location = new Point(18, 181);
            lblDatoFig2.Name = "lblDatoFig2";
            lblDatoFig2.Size = new Size(0, 15);
            lblDatoFig2.TabIndex = 13;
            // 
            // lblDatoFig1
            // 
            lblDatoFig1.AutoSize = true;
            lblDatoFig1.Location = new Point(18, 128);
            lblDatoFig1.Name = "lblDatoFig1";
            lblDatoFig1.Size = new Size(0, 15);
            lblDatoFig1.TabIndex = 12;
            // 
            // txtDatoFig2
            // 
            txtDatoFig2.Location = new Point(106, 173);
            txtDatoFig2.Name = "txtDatoFig2";
            txtDatoFig2.Size = new Size(155, 23);
            txtDatoFig2.TabIndex = 11;
            // 
            // txtDatoFig1
            // 
            txtDatoFig1.Location = new Point(104, 120);
            txtDatoFig1.Name = "txtDatoFig1";
            txtDatoFig1.Size = new Size(154, 23);
            txtDatoFig1.TabIndex = 10;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Arial Narrow", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(18, 72);
            label9.Name = "label9";
            label9.Size = new Size(65, 16);
            label9.TabIndex = 9;
            label9.Text = "Tipo Figura:";
            // 
            // cmbTipofig
            // 
            cmbTipofig.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTipofig.FormattingEnabled = true;
            cmbTipofig.Location = new Point(100, 70);
            cmbTipofig.Name = "cmbTipofig";
            cmbTipofig.Size = new Size(157, 23);
            cmbTipofig.TabIndex = 8;
            cmbTipofig.SelectedIndexChanged += cmbTipofig_SelectedIndexChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Arial Narrow", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(6, 27);
            label8.Name = "label8";
            label8.Size = new Size(263, 29);
            label8.TabIndex = 7;
            label8.Text = "Calculo de Area de Fig. Geo.";
            // 
            // button2
            // 
            button2.Location = new Point(125, 240);
            button2.Name = "button2";
            button2.Size = new Size(80, 23);
            button2.TabIndex = 10;
            button2.Text = "Calcular";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(975, 532);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox txtNombreAnimal;
        private Label label2;
        private Button btnAceptarAnimales;
        private Label label3;
        private Button button1;
        private Label label1;
        private ComboBox comboBoxAnimal;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label label6;
        private Label label5;
        private Label label4;
        private ComboBox cmbVehiculo;
        private TextBox txtVelocidadFin;
        private Label label7;
        private Button btnAcelerar;
        private TextBox txtveloIni;
        private Label lblVeloFin;
        private GroupBox groupBox3;
        private Label lblDatoFig2;
        private Label lblDatoFig1;
        private TextBox txtDatoFig2;
        private TextBox txtDatoFig1;
        private Label label9;
        private ComboBox cmbTipofig;
        private Label label8;
        private Button button2;
    }
}