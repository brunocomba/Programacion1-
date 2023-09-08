namespace Front
{
    partial class ModificacionSmartphone
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
            groupBox1 = new GroupBox();
            label6 = new Label();
            txtPrecio = new TextBox();
            btnModificar = new Button();
            txtModelo = new TextBox();
            txtGB = new TextBox();
            label5 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtMarca = new TextBox();
            groupBox2 = new GroupBox();
            label4 = new Label();
            btnVolver = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.Menu;
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(txtPrecio);
            groupBox1.Controls.Add(btnModificar);
            groupBox1.Controls.Add(txtModelo);
            groupBox1.Controls.Add(txtGB);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtMarca);
            groupBox1.Location = new Point(287, 92);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(398, 390);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(30, 248);
            label6.Name = "label6";
            label6.Size = new Size(53, 15);
            label6.TabIndex = 10;
            label6.Text = "PRECIO";
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(110, 245);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(201, 23);
            txtPrecio.TabIndex = 9;
            txtPrecio.KeyPress += txtPrecio_KeyPress;
            // 
            // btnModificar
            // 
            btnModificar.BackColor = Color.FromArgb(192, 255, 192);
            btnModificar.FlatStyle = FlatStyle.Flat;
            btnModificar.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnModificar.Location = new Point(137, 312);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(123, 31);
            btnModificar.TabIndex = 8;
            btnModificar.Text = "MODIFICAR";
            btnModificar.UseVisualStyleBackColor = false;
            btnModificar.Click += btnModificar_Click;
            // 
            // txtModelo
            // 
            txtModelo.Location = new Point(110, 140);
            txtModelo.Name = "txtModelo";
            txtModelo.Size = new Size(201, 23);
            txtModelo.TabIndex = 7;
            txtModelo.KeyPress += txtModelo_KeyPress;
            // 
            // txtGB
            // 
            txtGB.Location = new Point(110, 194);
            txtGB.Name = "txtGB";
            txtGB.Size = new Size(201, 23);
            txtGB.TabIndex = 6;
            txtGB.KeyPress += txtGB_KeyPress;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(49, 202);
            label5.Name = "label5";
            label5.Size = new Size(24, 15);
            label5.TabIndex = 5;
            label5.Text = "GB";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(101, 30);
            label3.Name = "label3";
            label3.Size = new Size(195, 16);
            label3.TabIndex = 4;
            label3.Text = "DATOS NUEVO SMARTPHONE";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(25, 148);
            label2.Name = "label2";
            label2.Size = new Size(58, 15);
            label2.TabIndex = 3;
            label2.Text = "MODELO";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(25, 96);
            label1.Name = "label1";
            label1.Size = new Size(48, 15);
            label1.TabIndex = 0;
            label1.Text = "MARCA";
            // 
            // txtMarca
            // 
            txtMarca.Location = new Point(110, 88);
            txtMarca.Name = "txtMarca";
            txtMarca.Size = new Size(201, 23);
            txtMarca.TabIndex = 2;
            txtMarca.KeyPress += txtMarca_KeyPress;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.FromArgb(192, 255, 192);
            groupBox2.Controls.Add(label4);
            groupBox2.Location = new Point(-6, -9);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(348, 57);
            groupBox2.TabIndex = 20;
            groupBox2.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(15, 19);
            label4.Name = "label4";
            label4.Size = new Size(327, 24);
            label4.TabIndex = 5;
            label4.Text = "MODIFICACION SMARTPHONES";
            // 
            // btnVolver
            // 
            btnVolver.BackColor = SystemColors.Window;
            btnVolver.FlatStyle = FlatStyle.Flat;
            btnVolver.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnVolver.Location = new Point(808, 513);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(130, 50);
            btnVolver.TabIndex = 21;
            btnVolver.Text = "VOLVER";
            btnVolver.UseVisualStyleBackColor = false;
            btnVolver.Click += btnVolver_Click;
            // 
            // ModificacionSmartphone
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(972, 575);
            Controls.Add(btnVolver);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "ModificacionSmartphone";
            Load += ModificacionSmartphone_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label6;
        private TextBox txtPrecio;
        private Button btnModificar;
        private TextBox txtModelo;
        private TextBox txtGB;
        private Label label5;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtMarca;
        private GroupBox groupBox2;
        private Label label4;
        private Button btnVolver;
    }
}