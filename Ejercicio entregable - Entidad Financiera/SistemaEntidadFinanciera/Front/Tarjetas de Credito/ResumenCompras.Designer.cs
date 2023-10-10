namespace Front.Tarjetas_de_Credito
{
    partial class ResumenCompras
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
            dgvResumenTarjeta = new DataGridView();
            iDDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            tarjetaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            detalleDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            precioDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            fechaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            compraTarjetaBindingSource1 = new BindingSource(components);
            compraTarjetaBindingSource = new BindingSource(components);
            groupBox2 = new GroupBox();
            btnBuscar = new Button();
            label4 = new Label();
            label2 = new Label();
            cmboxNroTarjeta = new ComboBox();
            cmboxTitular = new ComboBox();
            label3 = new Label();
            btnVolver = new Button();
            groupBox1 = new GroupBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvResumenTarjeta).BeginInit();
            ((System.ComponentModel.ISupportInitialize)compraTarjetaBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)compraTarjetaBindingSource).BeginInit();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvResumenTarjeta
            // 
            dgvResumenTarjeta.AllowUserToAddRows = false;
            dgvResumenTarjeta.AllowUserToDeleteRows = false;
            dgvResumenTarjeta.AllowUserToResizeColumns = false;
            dgvResumenTarjeta.AllowUserToResizeRows = false;
            dgvResumenTarjeta.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvResumenTarjeta.AutoGenerateColumns = false;
            dgvResumenTarjeta.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dgvResumenTarjeta.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            dgvResumenTarjeta.BackgroundColor = Color.WhiteSmoke;
            dgvResumenTarjeta.BorderStyle = BorderStyle.None;
            dgvResumenTarjeta.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.SteelBlue;
            dataGridViewCellStyle1.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.SteelBlue;
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvResumenTarjeta.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvResumenTarjeta.ColumnHeadersHeight = 28;
            dgvResumenTarjeta.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvResumenTarjeta.Columns.AddRange(new DataGridViewColumn[] { iDDataGridViewTextBoxColumn, tarjetaDataGridViewTextBoxColumn, detalleDataGridViewTextBoxColumn, precioDataGridViewTextBoxColumn, fechaDataGridViewTextBoxColumn });
            dgvResumenTarjeta.DataSource = compraTarjetaBindingSource1;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvResumenTarjeta.DefaultCellStyle = dataGridViewCellStyle2;
            dgvResumenTarjeta.EnableHeadersVisualStyles = false;
            dgvResumenTarjeta.GridColor = Color.Black;
            dgvResumenTarjeta.Location = new Point(369, 97);
            dgvResumenTarjeta.Name = "dgvResumenTarjeta";
            dgvResumenTarjeta.ReadOnly = true;
            dgvResumenTarjeta.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dgvResumenTarjeta.RowHeadersVisible = false;
            dgvResumenTarjeta.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = Color.WhiteSmoke;
            dataGridViewCellStyle3.SelectionForeColor = Color.Black;
            dgvResumenTarjeta.RowsDefaultCellStyle = dataGridViewCellStyle3;
            dgvResumenTarjeta.RowTemplate.Height = 25;
            dgvResumenTarjeta.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvResumenTarjeta.Size = new Size(591, 449);
            dgvResumenTarjeta.TabIndex = 37;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            iDDataGridViewTextBoxColumn.HeaderText = "ID";
            iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            iDDataGridViewTextBoxColumn.ReadOnly = true;
            iDDataGridViewTextBoxColumn.Width = 47;
            // 
            // tarjetaDataGridViewTextBoxColumn
            // 
            tarjetaDataGridViewTextBoxColumn.DataPropertyName = "Tarjeta";
            tarjetaDataGridViewTextBoxColumn.HeaderText = "Numero Tarjeta";
            tarjetaDataGridViewTextBoxColumn.Name = "tarjetaDataGridViewTextBoxColumn";
            tarjetaDataGridViewTextBoxColumn.ReadOnly = true;
            tarjetaDataGridViewTextBoxColumn.Width = 141;
            // 
            // detalleDataGridViewTextBoxColumn
            // 
            detalleDataGridViewTextBoxColumn.DataPropertyName = "Detalle";
            detalleDataGridViewTextBoxColumn.HeaderText = "Detalle Compra";
            detalleDataGridViewTextBoxColumn.Name = "detalleDataGridViewTextBoxColumn";
            detalleDataGridViewTextBoxColumn.ReadOnly = true;
            detalleDataGridViewTextBoxColumn.Width = 141;
            // 
            // precioDataGridViewTextBoxColumn
            // 
            precioDataGridViewTextBoxColumn.DataPropertyName = "Precio";
            precioDataGridViewTextBoxColumn.HeaderText = "Precio";
            precioDataGridViewTextBoxColumn.Name = "precioDataGridViewTextBoxColumn";
            precioDataGridViewTextBoxColumn.ReadOnly = true;
            precioDataGridViewTextBoxColumn.Width = 78;
            // 
            // fechaDataGridViewTextBoxColumn
            // 
            fechaDataGridViewTextBoxColumn.DataPropertyName = "Fecha";
            fechaDataGridViewTextBoxColumn.HeaderText = "Fecha";
            fechaDataGridViewTextBoxColumn.Name = "fechaDataGridViewTextBoxColumn";
            fechaDataGridViewTextBoxColumn.ReadOnly = true;
            fechaDataGridViewTextBoxColumn.Width = 75;
            // 
            // compraTarjetaBindingSource1
            // 
            compraTarjetaBindingSource1.DataSource = typeof(Back.Clases.Compra_Tarjeta);
            // 
            // compraTarjetaBindingSource
            // 
            compraTarjetaBindingSource.DataSource = typeof(Back.Clases.Compra_Tarjeta);
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnBuscar);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(cmboxNroTarjeta);
            groupBox2.Controls.Add(cmboxTitular);
            groupBox2.Controls.Add(label3);
            groupBox2.Location = new Point(15, 97);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(213, 240);
            groupBox2.TabIndex = 36;
            groupBox2.TabStop = false;
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.MintCream;
            btnBuscar.FlatAppearance.BorderSize = 3;
            btnBuscar.FlatStyle = FlatStyle.Popup;
            btnBuscar.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnBuscar.Location = new Point(38, 199);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(131, 32);
            btnBuscar.TabIndex = 33;
            btnBuscar.Text = "BUSCAR";
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(35, 19);
            label4.Name = "label4";
            label4.Size = new Size(134, 16);
            label4.TabIndex = 32;
            label4.Text = "TARJETA A BUSCAR";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(6, 56);
            label2.Name = "label2";
            label2.Size = new Size(82, 16);
            label2.TabIndex = 28;
            label2.Text = "Titular tarjeta";
            // 
            // cmboxNroTarjeta
            // 
            cmboxNroTarjeta.DropDownStyle = ComboBoxStyle.DropDownList;
            cmboxNroTarjeta.FormattingEnabled = true;
            cmboxNroTarjeta.Location = new Point(6, 150);
            cmboxNroTarjeta.Name = "cmboxNroTarjeta";
            cmboxNroTarjeta.Size = new Size(185, 23);
            cmboxNroTarjeta.TabIndex = 31;
            // 
            // cmboxTitular
            // 
            cmboxTitular.DropDownStyle = ComboBoxStyle.DropDownList;
            cmboxTitular.FormattingEnabled = true;
            cmboxTitular.Location = new Point(6, 75);
            cmboxTitular.Name = "cmboxTitular";
            cmboxTitular.Size = new Size(185, 23);
            cmboxTitular.TabIndex = 29;
            cmboxTitular.SelectedIndexChanged += cmboxTitular_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(6, 131);
            label3.Name = "label3";
            label3.Size = new Size(87, 16);
            label3.TabIndex = 30;
            label3.Text = "Nro de Tarjeta";
            // 
            // btnVolver
            // 
            btnVolver.BackColor = Color.MistyRose;
            btnVolver.FlatAppearance.BorderColor = Color.White;
            btnVolver.FlatAppearance.BorderSize = 3;
            btnVolver.FlatStyle = FlatStyle.Popup;
            btnVolver.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnVolver.Location = new Point(1030, 522);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(120, 35);
            btnVolver.TabIndex = 35;
            btnVolver.Text = "VOLVER";
            btnVolver.UseVisualStyleBackColor = false;
            btnVolver.Click += btnVolver_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.SteelBlue;
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(-7, -17);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1183, 84);
            groupBox1.TabIndex = 34;
            groupBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Gadugi", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(376, 32);
            label1.Name = "label1";
            label1.Size = new Size(451, 32);
            label1.TabIndex = 5;
            label1.Text = "RESUMEN COMPRAS REALIZADAS";
            // 
            // ResumenCompras
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1169, 577);
            Controls.Add(dgvResumenTarjeta);
            Controls.Add(groupBox2);
            Controls.Add(btnVolver);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "ResumenCompras";
            StartPosition = FormStartPosition.CenterScreen;
            Load += ResumenCompras_Load;
            ((System.ComponentModel.ISupportInitialize)dgvResumenTarjeta).EndInit();
            ((System.ComponentModel.ISupportInitialize)compraTarjetaBindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)compraTarjetaBindingSource).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvResumenTarjeta;
        private BindingSource compraTarjetaBindingSource;
        private GroupBox groupBox2;
        private Button btnBuscar;
        private Label label4;
        private Label label2;
        private ComboBox cmboxNroTarjeta;
        private ComboBox cmboxTitular;
        private Label label3;
        private Button btnVolver;
        private GroupBox groupBox1;
        private Label label1;
        private BindingSource compraTarjetaBindingSource1;
        private DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn tarjetaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn detalleDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn precioDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn fechaDataGridViewTextBoxColumn;
    }
}