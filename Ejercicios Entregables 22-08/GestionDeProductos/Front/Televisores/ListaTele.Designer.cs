namespace Front
{
    partial class ListaTele
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
            dgvTelevisores = new DataGridView();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            marcaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            modeloDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            pulgadasDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            precioDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            televisorBindingSource = new BindingSource(components);
            groupBox2 = new GroupBox();
            label4 = new Label();
            btnModificar = new Button();
            btnEliminar = new Button();
            btnAgregar = new Button();
            btnVolver = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvTelevisores).BeginInit();
            ((System.ComponentModel.ISupportInitialize)televisorBindingSource).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // dgvTelevisores
            // 
            dgvTelevisores.AllowUserToAddRows = false;
            dgvTelevisores.AllowUserToDeleteRows = false;
            dgvTelevisores.AllowUserToResizeColumns = false;
            dgvTelevisores.AllowUserToResizeRows = false;
            dgvTelevisores.AutoGenerateColumns = false;
            dgvTelevisores.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvTelevisores.BackgroundColor = SystemColors.Window;
            dgvTelevisores.BorderStyle = BorderStyle.None;
            dgvTelevisores.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvTelevisores.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Window;
            dataGridViewCellStyle1.SelectionForeColor = Color.Black;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvTelevisores.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvTelevisores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvTelevisores.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, marcaDataGridViewTextBoxColumn, modeloDataGridViewTextBoxColumn, pulgadasDataGridViewTextBoxColumn, precioDataGridViewTextBoxColumn });
            dgvTelevisores.DataSource = televisorBindingSource;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvTelevisores.DefaultCellStyle = dataGridViewCellStyle2;
            dgvTelevisores.EnableHeadersVisualStyles = false;
            dgvTelevisores.GridColor = Color.MidnightBlue;
            dgvTelevisores.Location = new Point(214, 72);
            dgvTelevisores.Name = "dgvTelevisores";
            dgvTelevisores.ReadOnly = true;
            dgvTelevisores.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvTelevisores.RowHeadersVisible = false;
            dgvTelevisores.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(49, 66, 82);
            dataGridViewCellStyle3.SelectionForeColor = Color.White;
            dgvTelevisores.RowsDefaultCellStyle = dataGridViewCellStyle3;
            dgvTelevisores.RowTemplate.Height = 25;
            dgvTelevisores.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvTelevisores.Size = new Size(581, 474);
            dgvTelevisores.TabIndex = 6;
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.HeaderText = "ID";
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // marcaDataGridViewTextBoxColumn
            // 
            marcaDataGridViewTextBoxColumn.DataPropertyName = "Marca";
            marcaDataGridViewTextBoxColumn.HeaderText = "Marca";
            marcaDataGridViewTextBoxColumn.Name = "marcaDataGridViewTextBoxColumn";
            marcaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // modeloDataGridViewTextBoxColumn
            // 
            modeloDataGridViewTextBoxColumn.DataPropertyName = "Modelo";
            modeloDataGridViewTextBoxColumn.HeaderText = "Modelo";
            modeloDataGridViewTextBoxColumn.Name = "modeloDataGridViewTextBoxColumn";
            modeloDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pulgadasDataGridViewTextBoxColumn
            // 
            pulgadasDataGridViewTextBoxColumn.DataPropertyName = "Pulgadas";
            pulgadasDataGridViewTextBoxColumn.HeaderText = "Pulgadas";
            pulgadasDataGridViewTextBoxColumn.Name = "pulgadasDataGridViewTextBoxColumn";
            pulgadasDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // precioDataGridViewTextBoxColumn
            // 
            precioDataGridViewTextBoxColumn.DataPropertyName = "Precio";
            precioDataGridViewTextBoxColumn.HeaderText = "Precio";
            precioDataGridViewTextBoxColumn.Name = "precioDataGridViewTextBoxColumn";
            precioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // televisorBindingSource
            // 
            televisorBindingSource.DataSource = typeof(Back.Clases.Televisor);
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.FromArgb(192, 255, 192);
            groupBox2.Controls.Add(label4);
            groupBox2.Location = new Point(-6, -5);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(262, 58);
            groupBox2.TabIndex = 22;
            groupBox2.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(15, 22);
            label4.Name = "label4";
            label4.Size = new Size(218, 24);
            label4.TabIndex = 5;
            label4.Text = "LISTA TELEVISORES";
            // 
            // btnModificar
            // 
            btnModificar.BackColor = Color.FromArgb(192, 255, 192);
            btnModificar.FlatStyle = FlatStyle.Flat;
            btnModificar.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnModificar.Location = new Point(23, 223);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(148, 55);
            btnModificar.TabIndex = 21;
            btnModificar.Text = "MODIFICAR";
            btnModificar.UseVisualStyleBackColor = false;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.FromArgb(192, 255, 192);
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnEliminar.Location = new Point(23, 321);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(148, 55);
            btnEliminar.TabIndex = 20;
            btnEliminar.Text = "ELIMINAR";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.FromArgb(192, 255, 192);
            btnAgregar.FlatStyle = FlatStyle.Flat;
            btnAgregar.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnAgregar.Location = new Point(23, 129);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(148, 55);
            btnAgregar.TabIndex = 19;
            btnAgregar.Text = "AGREGAR";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnVolver
            // 
            btnVolver.BackColor = SystemColors.Window;
            btnVolver.FlatStyle = FlatStyle.Flat;
            btnVolver.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnVolver.Location = new Point(821, 513);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(130, 50);
            btnVolver.TabIndex = 23;
            btnVolver.Text = "VOLVER";
            btnVolver.UseVisualStyleBackColor = false;
            btnVolver.Click += btnVolver_Click;
            // 
            // ListaTele
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(972, 575);
            Controls.Add(btnVolver);
            Controls.Add(groupBox2);
            Controls.Add(btnModificar);
            Controls.Add(btnEliminar);
            Controls.Add(btnAgregar);
            Controls.Add(dgvTelevisores);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "ListaTele";
            Load += ListaTele_Load;
            ((System.ComponentModel.ISupportInitialize)dgvTelevisores).EndInit();
            ((System.ComponentModel.ISupportInitialize)televisorBindingSource).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvTelevisores;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn marcaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn modeloDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn pulgadasDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn precioDataGridViewTextBoxColumn;
        private BindingSource televisorBindingSource;
        private GroupBox groupBox2;
        private Label label4;
        private Button btnModificar;
        private Button btnEliminar;
        private Button btnAgregar;
        private Button btnVolver;
    }
}