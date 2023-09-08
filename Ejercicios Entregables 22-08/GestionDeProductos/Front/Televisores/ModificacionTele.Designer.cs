namespace Front
{
    partial class ModificacionTele
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
            groupBox2 = new GroupBox();
            label4 = new Label();
            btnVolver = new Button();
            groupBox1 = new GroupBox();
            label6 = new Label();
            txtPrecio = new TextBox();
            btnAgregar = new Button();
            txtModelo = new TextBox();
            txtPulgadas = new TextBox();
            label5 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtMarca = new TextBox();
            groupBox3 = new GroupBox();
            label7 = new Label();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.FromArgb(192, 255, 192);
            groupBox2.Controls.Add(label4);
            groupBox2.Location = new Point(-55, -62);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(269, 59);
            groupBox2.TabIndex = 22;
            groupBox2.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(15, 22);
            label4.Name = "label4";
            label4.Size = new Size(227, 24);
            label4.TabIndex = 5;
            label4.Text = "ALTA SMARTPHONES";
            // 
            // btnVolver
            // 
            btnVolver.BackColor = SystemColors.Window;
            btnVolver.FlatStyle = FlatStyle.Flat;
            btnVolver.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnVolver.Location = new Point(800, 513);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(130, 50);
            btnVolver.TabIndex = 21;
            btnVolver.Text = "VOLVER";
            btnVolver.UseVisualStyleBackColor = false;
            btnVolver.Click += btnVolver_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.Menu;
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(txtPrecio);
            groupBox1.Controls.Add(btnAgregar);
            groupBox1.Controls.Add(txtModelo);
            groupBox1.Controls.Add(txtPulgadas);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtMarca);
            groupBox1.Location = new Point(287, 100);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(398, 390);
            groupBox1.TabIndex = 20;
            groupBox1.TabStop = false;
            groupBox1.Enter += groupBox1_Enter;
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
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.FromArgb(192, 255, 192);
            btnAgregar.FlatStyle = FlatStyle.Flat;
            btnAgregar.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnAgregar.Location = new Point(137, 312);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(123, 31);
            btnAgregar.TabIndex = 8;
            btnAgregar.Text = "MODIFICAR";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // txtModelo
            // 
            txtModelo.Location = new Point(110, 140);
            txtModelo.Name = "txtModelo";
            txtModelo.Size = new Size(201, 23);
            txtModelo.TabIndex = 7;
            txtModelo.KeyPress += txtModelo_KeyPress;
            // 
            // txtPulgadas
            // 
            txtPulgadas.Location = new Point(110, 194);
            txtPulgadas.Name = "txtPulgadas";
            txtPulgadas.Size = new Size(201, 23);
            txtPulgadas.TabIndex = 6;
            txtPulgadas.KeyPress += txtPulgadas_KeyPress;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(25, 202);
            label5.Name = "label5";
            label5.Size = new Size(71, 15);
            label5.TabIndex = 5;
            label5.Text = "PULGADAS";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(115, 37);
            label3.Name = "label3";
            label3.Size = new Size(145, 16);
            label3.TabIndex = 4;
            label3.Text = "DATOS A MODIFICAR ";
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
            // groupBox3
            // 
            groupBox3.BackColor = Color.FromArgb(192, 255, 192);
            groupBox3.Controls.Add(label7);
            groupBox3.Location = new Point(-6, -13);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(366, 61);
            groupBox3.TabIndex = 21;
            groupBox3.TabStop = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(18, 22);
            label7.Name = "label7";
            label7.Size = new Size(312, 24);
            label7.TabIndex = 5;
            label7.Text = "MODIFICACION TELEVISORES";
            // 
            // ModificacionTele
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(972, 575);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(btnVolver);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "ModificacionTele";
            Load += ModificacionTele_Load;
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox2;
        private Label label4;
        private Button btnVolver;
        private GroupBox groupBox1;
        private Label label6;
        private TextBox txtPrecio;
        private Button btnAgregar;
        private TextBox txtModelo;
        private TextBox txtPulgadas;
        private Label label5;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtMarca;
        private GroupBox groupBox3;
        private Label label7;
    }
}