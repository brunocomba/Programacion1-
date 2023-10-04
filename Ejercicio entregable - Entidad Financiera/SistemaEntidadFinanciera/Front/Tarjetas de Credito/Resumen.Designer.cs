namespace Front.Tarjetas_de_Credito
{
    partial class Resumen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Resumen));
            btnVolver = new Button();
            label1 = new Label();
            groupBox1 = new GroupBox();
            cmboxTitular = new ComboBox();
            label2 = new Label();
            cmboxNroTarjeta = new ComboBox();
            label3 = new Label();
            groupBox2 = new GroupBox();
            btnPagar = new Button();
            label4 = new Label();
            dgvResumenTarjeta = new DataGridView();
            clienteDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nroTarjetaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            limiteCreditoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            saldoDisponibleDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            montoDeudaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            estadoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            tarjetaCreditoBindingSource = new BindingSource(components);
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvResumenTarjeta).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tarjetaCreditoBindingSource).BeginInit();
            SuspendLayout();
            // 
            // btnVolver
            // 
            btnVolver.BackColor = Color.MistyRose;
            btnVolver.FlatAppearance.BorderColor = Color.White;
            btnVolver.FlatAppearance.BorderSize = 3;
            btnVolver.FlatStyle = FlatStyle.Popup;
            btnVolver.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnVolver.Location = new Point(1027, 530);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(120, 35);
            btnVolver.TabIndex = 27;
            btnVolver.Text = "VOLVER";
            btnVolver.UseVisualStyleBackColor = false;
            btnVolver.Click += btnVolver_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Gadugi", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(376, 32);
            label1.Name = "label1";
            label1.Size = new Size(425, 32);
            label1.TabIndex = 5;
            label1.Text = "RESUMEN TARJETA DE CREDITO";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.SteelBlue;
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(-10, -9);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1183, 84);
            groupBox1.TabIndex = 24;
            groupBox1.TabStop = false;
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
            // groupBox2
            // 
            groupBox2.Controls.Add(btnPagar);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(cmboxNroTarjeta);
            groupBox2.Controls.Add(cmboxTitular);
            groupBox2.Controls.Add(label3);
            groupBox2.Location = new Point(12, 105);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(213, 240);
            groupBox2.TabIndex = 32;
            groupBox2.TabStop = false;
            // 
            // btnPagar
            // 
            btnPagar.BackColor = Color.MintCream;
            btnPagar.FlatAppearance.BorderSize = 3;
            btnPagar.FlatStyle = FlatStyle.Popup;
            btnPagar.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnPagar.Location = new Point(38, 199);
            btnPagar.Name = "btnPagar";
            btnPagar.Size = new Size(131, 32);
            btnPagar.TabIndex = 33;
            btnPagar.Text = "BUSCAR";
            btnPagar.UseVisualStyleBackColor = false;
            btnPagar.Click += btnPagar_Click;
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
            dgvResumenTarjeta.Columns.AddRange(new DataGridViewColumn[] { clienteDataGridViewTextBoxColumn, nroTarjetaDataGridViewTextBoxColumn, limiteCreditoDataGridViewTextBoxColumn, saldoDisponibleDataGridViewTextBoxColumn, montoDeudaDataGridViewTextBoxColumn, estadoDataGridViewTextBoxColumn });
            dgvResumenTarjeta.DataSource = tarjetaCreditoBindingSource;
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
            dgvResumenTarjeta.Location = new Point(266, 115);
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
            dgvResumenTarjeta.Size = new Size(736, 449);
            dgvResumenTarjeta.TabIndex = 33;
            // 
            // clienteDataGridViewTextBoxColumn
            // 
            clienteDataGridViewTextBoxColumn.DataPropertyName = "Cliente";
            clienteDataGridViewTextBoxColumn.HeaderText = "Cliente";
            clienteDataGridViewTextBoxColumn.Name = "clienteDataGridViewTextBoxColumn";
            clienteDataGridViewTextBoxColumn.ReadOnly = true;
            clienteDataGridViewTextBoxColumn.Width = 83;
            // 
            // nroTarjetaDataGridViewTextBoxColumn
            // 
            nroTarjetaDataGridViewTextBoxColumn.DataPropertyName = "NroTarjeta";
            nroTarjetaDataGridViewTextBoxColumn.HeaderText = "Numero Tarjeta";
            nroTarjetaDataGridViewTextBoxColumn.Name = "nroTarjetaDataGridViewTextBoxColumn";
            nroTarjetaDataGridViewTextBoxColumn.ReadOnly = true;
            nroTarjetaDataGridViewTextBoxColumn.Width = 141;
            // 
            // limiteCreditoDataGridViewTextBoxColumn
            // 
            limiteCreditoDataGridViewTextBoxColumn.DataPropertyName = "LimiteCredito";
            limiteCreditoDataGridViewTextBoxColumn.HeaderText = "Limite credito";
            limiteCreditoDataGridViewTextBoxColumn.Name = "limiteCreditoDataGridViewTextBoxColumn";
            limiteCreditoDataGridViewTextBoxColumn.ReadOnly = true;
            limiteCreditoDataGridViewTextBoxColumn.Width = 129;
            // 
            // saldoDisponibleDataGridViewTextBoxColumn
            // 
            saldoDisponibleDataGridViewTextBoxColumn.DataPropertyName = "SaldoDisponible";
            saldoDisponibleDataGridViewTextBoxColumn.HeaderText = "Saldo disponible";
            saldoDisponibleDataGridViewTextBoxColumn.Name = "saldoDisponibleDataGridViewTextBoxColumn";
            saldoDisponibleDataGridViewTextBoxColumn.ReadOnly = true;
            saldoDisponibleDataGridViewTextBoxColumn.Width = 150;
            // 
            // montoDeudaDataGridViewTextBoxColumn
            // 
            montoDeudaDataGridViewTextBoxColumn.DataPropertyName = "MontoDeuda";
            montoDeudaDataGridViewTextBoxColumn.HeaderText = "Monto deuda";
            montoDeudaDataGridViewTextBoxColumn.Name = "montoDeudaDataGridViewTextBoxColumn";
            montoDeudaDataGridViewTextBoxColumn.ReadOnly = true;
            montoDeudaDataGridViewTextBoxColumn.Width = 125;
            // 
            // estadoDataGridViewTextBoxColumn
            // 
            estadoDataGridViewTextBoxColumn.DataPropertyName = "Estado";
            estadoDataGridViewTextBoxColumn.HeaderText = "Estado";
            estadoDataGridViewTextBoxColumn.Name = "estadoDataGridViewTextBoxColumn";
            estadoDataGridViewTextBoxColumn.ReadOnly = true;
            estadoDataGridViewTextBoxColumn.Width = 81;
            // 
            // tarjetaCreditoBindingSource
            // 
            tarjetaCreditoBindingSource.DataSource = typeof(Back.Clases.Tarjeta_Credito);
            // 
            // Resumen
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
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Resumen";
            StartPosition = FormStartPosition.CenterScreen;
            Load += Resumen_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvResumenTarjeta).EndInit();
            ((System.ComponentModel.ISupportInitialize)tarjetaCreditoBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnVolver;
        private Label label1;
        private GroupBox groupBox1;
        private ComboBox cmboxTitular;
        private Label label2;
        private ComboBox cmboxNroTarjeta;
        private Label label3;
        private GroupBox groupBox2;
        private Label label4;
        private Button btnPagar;
        private DataGridView dgvResumenTarjeta;
        private BindingSource tarjetaCreditoBindingSource;
        private DataGridViewTextBoxColumn clienteDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nroTarjetaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn limiteCreditoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn saldoDisponibleDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn montoDeudaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn estadoDataGridViewTextBoxColumn;
    }
}