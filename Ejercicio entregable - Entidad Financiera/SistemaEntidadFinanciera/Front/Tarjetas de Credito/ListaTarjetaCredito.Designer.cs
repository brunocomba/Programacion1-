namespace Front.Tarjetas_de_Credito
{
    partial class ListaTarjetaCredito
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListaTarjetaCredito));
            btnVolver = new Button();
            dgvTarjetaDeCredito = new DataGridView();
            tarjetaCreditoBindingSource = new BindingSource(components);
            groupBox3 = new GroupBox();
            btnNuevaTarjeta = new Button();
            btnEliminar = new Button();
            groupBox1 = new GroupBox();
            label1 = new Label();
            appDbContextBindingSource = new BindingSource(components);
            initialCreateBindingSource = new BindingSource(components);
            initialCreateBindingSource1 = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)dgvTarjetaDeCredito).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tarjetaCreditoBindingSource).BeginInit();
            groupBox3.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)appDbContextBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)initialCreateBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)initialCreateBindingSource1).BeginInit();
            SuspendLayout();
            // 
            // btnVolver
            // 
            btnVolver.BackColor = Color.MistyRose;
            btnVolver.FlatAppearance.BorderColor = Color.White;
            btnVolver.FlatAppearance.BorderSize = 3;
            btnVolver.FlatStyle = FlatStyle.Popup;
            btnVolver.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnVolver.Location = new Point(941, 527);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(141, 35);
            btnVolver.TabIndex = 23;
            btnVolver.Text = "VOLVER";
            btnVolver.UseVisualStyleBackColor = false;
            btnVolver.Click += btnVolver_Click;
            // 
            // dgvTarjetaDeCredito
            // 
            dgvTarjetaDeCredito.AllowUserToAddRows = false;
            dgvTarjetaDeCredito.AllowUserToDeleteRows = false;
            dgvTarjetaDeCredito.AllowUserToResizeColumns = false;
            dgvTarjetaDeCredito.AllowUserToResizeRows = false;
            dgvTarjetaDeCredito.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvTarjetaDeCredito.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvTarjetaDeCredito.BackgroundColor = Color.WhiteSmoke;
            dgvTarjetaDeCredito.BorderStyle = BorderStyle.None;
            dgvTarjetaDeCredito.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvTarjetaDeCredito.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.SteelBlue;
            dataGridViewCellStyle1.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.SteelBlue;
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvTarjetaDeCredito.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvTarjetaDeCredito.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvTarjetaDeCredito.DefaultCellStyle = dataGridViewCellStyle2;
            dgvTarjetaDeCredito.EnableHeadersVisualStyles = false;
            dgvTarjetaDeCredito.GridColor = Color.Black;
            dgvTarjetaDeCredito.Location = new Point(301, 116);
            dgvTarjetaDeCredito.Name = "dgvTarjetaDeCredito";
            dgvTarjetaDeCredito.ReadOnly = true;
            dgvTarjetaDeCredito.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvTarjetaDeCredito.RowHeadersVisible = false;
            dgvTarjetaDeCredito.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = Color.Gold;
            dataGridViewCellStyle3.SelectionForeColor = Color.Black;
            dgvTarjetaDeCredito.RowsDefaultCellStyle = dataGridViewCellStyle3;
            dgvTarjetaDeCredito.RowTemplate.Height = 25;
            dgvTarjetaDeCredito.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvTarjetaDeCredito.Size = new Size(578, 446);
            dgvTarjetaDeCredito.TabIndex = 22;
            // 
            // tarjetaCreditoBindingSource
            // 
            tarjetaCreditoBindingSource.DataSource = typeof(Back.Clases.Tarjeta_Credito);
            // 
            // groupBox3
            // 
            groupBox3.BackColor = Color.SteelBlue;
            groupBox3.Controls.Add(btnNuevaTarjeta);
            groupBox3.Controls.Add(btnEliminar);
            groupBox3.Location = new Point(-10, 62);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(192, 519);
            groupBox3.TabIndex = 21;
            groupBox3.TabStop = false;
            // 
            // btnNuevaTarjeta
            // 
            btnNuevaTarjeta.BackColor = Color.LightYellow;
            btnNuevaTarjeta.FlatAppearance.BorderSize = 3;
            btnNuevaTarjeta.FlatStyle = FlatStyle.Popup;
            btnNuevaTarjeta.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnNuevaTarjeta.Location = new Point(22, 54);
            btnNuevaTarjeta.Name = "btnNuevaTarjeta";
            btnNuevaTarjeta.Size = new Size(154, 64);
            btnNuevaTarjeta.TabIndex = 9;
            btnNuevaTarjeta.Text = "NUEVA TARJETA DE CREDITO";
            btnNuevaTarjeta.UseVisualStyleBackColor = false;
            btnNuevaTarjeta.Click += btnNuevaTarjeta_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.LightYellow;
            btnEliminar.FlatAppearance.BorderSize = 3;
            btnEliminar.FlatStyle = FlatStyle.Popup;
            btnEliminar.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnEliminar.Location = new Point(22, 163);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(154, 59);
            btnEliminar.TabIndex = 11;
            btnEliminar.Text = "DAR DE BAJA";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.SteelBlue;
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(-10, -12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1141, 84);
            groupBox1.TabIndex = 20;
            groupBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Gadugi", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(365, 34);
            label1.Name = "label1";
            label1.Size = new Size(425, 32);
            label1.TabIndex = 5;
            label1.Text = "LISTADO TARJETAS DE CREDITO";
            // 
            // appDbContextBindingSource
            // 
            appDbContextBindingSource.DataSource = typeof(Back.ConeccionBD.AppDbContext);
            // 
            // initialCreateBindingSource
            // 
            initialCreateBindingSource.DataSource = typeof(Back.Migrations.InitialCreate);
            // 
            // initialCreateBindingSource1
            // 
            initialCreateBindingSource1.DataSource = typeof(Back.Migrations.InitialCreate);
            // 
            // ListaTarjetaCredito
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1120, 574);
            Controls.Add(btnVolver);
            Controls.Add(dgvTarjetaDeCredito);
            Controls.Add(groupBox3);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "ListaTarjetaCredito";
            StartPosition = FormStartPosition.CenterScreen;
            Load += ListaTarjetaCredito_Load;
            ((System.ComponentModel.ISupportInitialize)dgvTarjetaDeCredito).EndInit();
            ((System.ComponentModel.ISupportInitialize)tarjetaCreditoBindingSource).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)appDbContextBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)initialCreateBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)initialCreateBindingSource1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnVolver;
        private DataGridView dgvTarjetaDeCredito;
        private GroupBox groupBox3;
        private Button btnNuevaTarjeta;
        private Button btnEliminar;
        private GroupBox groupBox1;
        private Label label1;
        private DataGridViewTextBoxColumn clienteDataGridViewTextBoxColumn;
        private BindingSource appDbContextBindingSource;
        private BindingSource initialCreateBindingSource;
        private BindingSource tarjetaCreditoBindingSource;
        private BindingSource initialCreateBindingSource1;
    }
}