namespace Front.Cuentas_Bancarias
{
    partial class ListaCtaBancaria
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListaCtaBancaria));
            btnVolver = new Button();
            dgvCtasBancarias = new DataGridView();
            tarjetaCreditoBindingSource = new BindingSource(components);
            groupBox3 = new GroupBox();
            btnNuevaCtaBancaria = new Button();
            groupBox1 = new GroupBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvCtasBancarias).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tarjetaCreditoBindingSource).BeginInit();
            groupBox3.SuspendLayout();
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
            btnVolver.Location = new Point(937, 534);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(141, 35);
            btnVolver.TabIndex = 19;
            btnVolver.Text = "VOLVER";
            btnVolver.UseVisualStyleBackColor = false;
            btnVolver.Click += btnVolver_Click;
            // 
            // dgvCtasBancarias
            // 
            dgvCtasBancarias.AllowUserToAddRows = false;
            dgvCtasBancarias.AllowUserToDeleteRows = false;
            dgvCtasBancarias.AllowUserToResizeColumns = false;
            dgvCtasBancarias.AllowUserToResizeRows = false;
            dgvCtasBancarias.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvCtasBancarias.BackgroundColor = Color.WhiteSmoke;
            dgvCtasBancarias.BorderStyle = BorderStyle.None;
            dgvCtasBancarias.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvCtasBancarias.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.SteelBlue;
            dataGridViewCellStyle1.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.SteelBlue;
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvCtasBancarias.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvCtasBancarias.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvCtasBancarias.DefaultCellStyle = dataGridViewCellStyle2;
            dgvCtasBancarias.EnableHeadersVisualStyles = false;
            dgvCtasBancarias.GridColor = Color.Black;
            dgvCtasBancarias.Location = new Point(310, 116);
            dgvCtasBancarias.Name = "dgvCtasBancarias";
            dgvCtasBancarias.ReadOnly = true;
            dgvCtasBancarias.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvCtasBancarias.RowHeadersVisible = false;
            dgvCtasBancarias.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = Color.Gold;
            dataGridViewCellStyle3.SelectionForeColor = Color.Black;
            dgvCtasBancarias.RowsDefaultCellStyle = dataGridViewCellStyle3;
            dgvCtasBancarias.RowTemplate.Height = 25;
            dgvCtasBancarias.ScrollBars = ScrollBars.Vertical;
            dgvCtasBancarias.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCtasBancarias.Size = new Size(578, 446);
            dgvCtasBancarias.TabIndex = 18;
            dgvCtasBancarias.CellContentClick += dgvCtasBancarias_CellContentClick;
            // 
            // tarjetaCreditoBindingSource
            // 
            tarjetaCreditoBindingSource.DataSource = typeof(Back.Clases.Tarjeta_Credito);
            // 
            // groupBox3
            // 
            groupBox3.BackColor = Color.SteelBlue;
            groupBox3.Controls.Add(btnNuevaCtaBancaria);
            groupBox3.Location = new Point(-10, 64);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(189, 514);
            groupBox3.TabIndex = 17;
            groupBox3.TabStop = false;
            // 
            // btnNuevaCtaBancaria
            // 
            btnNuevaCtaBancaria.BackColor = Color.LightYellow;
            btnNuevaCtaBancaria.FlatAppearance.BorderSize = 3;
            btnNuevaCtaBancaria.FlatStyle = FlatStyle.Popup;
            btnNuevaCtaBancaria.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnNuevaCtaBancaria.Location = new Point(22, 61);
            btnNuevaCtaBancaria.Name = "btnNuevaCtaBancaria";
            btnNuevaCtaBancaria.Size = new Size(154, 59);
            btnNuevaCtaBancaria.TabIndex = 9;
            btnNuevaCtaBancaria.Text = "NUEVA CUENTA BANCARIA";
            btnNuevaCtaBancaria.UseVisualStyleBackColor = false;
            btnNuevaCtaBancaria.Click += btnNuevaCtaBancaria_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.SteelBlue;
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(-10, -10);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1141, 84);
            groupBox1.TabIndex = 16;
            groupBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Gadugi", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(365, 34);
            label1.Name = "label1";
            label1.Size = new Size(417, 32);
            label1.TabIndex = 5;
            label1.Text = "LISTADO CUENTAS BANCARIAS";
            // 
            // ListaCtaBancaria
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1120, 574);
            Controls.Add(btnVolver);
            Controls.Add(dgvCtasBancarias);
            Controls.Add(groupBox3);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "ListaCtaBancaria";
            StartPosition = FormStartPosition.CenterScreen;
            Load += ListaCtaBancaria_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCtasBancarias).EndInit();
            ((System.ComponentModel.ISupportInitialize)tarjetaCreditoBindingSource).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnVolver;
        private DataGridView dgvCtasBancarias;
        private GroupBox groupBox3;
        private Button btnNuevaCtaBancaria;
        private GroupBox groupBox1;
        private Label label1;
        private BindingSource tarjetaCreditoBindingSource;
    }
}