namespace Front
{
    partial class ListaSmartphones
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
            dgvSmartphones = new DataGridView();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            marcaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            modeloDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            gbAlmacenamientoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            precioDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            smartphoneBindingSource = new BindingSource(components);
            btnVolver = new Button();
            btnModificar = new Button();
            btnEliminar = new Button();
            btnAgregar = new Button();
            groupBox2 = new GroupBox();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvSmartphones).BeginInit();
            ((System.ComponentModel.ISupportInitialize)smartphoneBindingSource).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // dgvSmartphones
            // 
            dgvSmartphones.AllowUserToAddRows = false;
            dgvSmartphones.AllowUserToDeleteRows = false;
            dgvSmartphones.AllowUserToResizeColumns = false;
            dgvSmartphones.AllowUserToResizeRows = false;
            dgvSmartphones.AutoGenerateColumns = false;
            dgvSmartphones.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSmartphones.BackgroundColor = SystemColors.Window;
            dgvSmartphones.BorderStyle = BorderStyle.None;
            dgvSmartphones.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvSmartphones.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Window;
            dataGridViewCellStyle1.SelectionForeColor = Color.Black;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvSmartphones.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvSmartphones.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvSmartphones.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, marcaDataGridViewTextBoxColumn, modeloDataGridViewTextBoxColumn, gbAlmacenamientoDataGridViewTextBoxColumn, precioDataGridViewTextBoxColumn });
            dgvSmartphones.DataSource = smartphoneBindingSource;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvSmartphones.DefaultCellStyle = dataGridViewCellStyle2;
            dgvSmartphones.EnableHeadersVisualStyles = false;
            dgvSmartphones.GridColor = Color.MidnightBlue;
            dgvSmartphones.Location = new Point(215, 70);
            dgvSmartphones.Name = "dgvSmartphones";
            dgvSmartphones.ReadOnly = true;
            dgvSmartphones.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvSmartphones.RowHeadersVisible = false;
            dgvSmartphones.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(49, 66, 82);
            dataGridViewCellStyle3.SelectionForeColor = Color.White;
            dgvSmartphones.RowsDefaultCellStyle = dataGridViewCellStyle3;
            dgvSmartphones.RowTemplate.Height = 25;
            dgvSmartphones.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSmartphones.Size = new Size(581, 474);
            dgvSmartphones.TabIndex = 5;
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
            // gbAlmacenamientoDataGridViewTextBoxColumn
            // 
            gbAlmacenamientoDataGridViewTextBoxColumn.DataPropertyName = "GbAlmacenamiento";
            gbAlmacenamientoDataGridViewTextBoxColumn.HeaderText = "GB Almacenamiento";
            gbAlmacenamientoDataGridViewTextBoxColumn.Name = "gbAlmacenamientoDataGridViewTextBoxColumn";
            gbAlmacenamientoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // precioDataGridViewTextBoxColumn
            // 
            precioDataGridViewTextBoxColumn.DataPropertyName = "Precio";
            precioDataGridViewTextBoxColumn.HeaderText = "Precio";
            precioDataGridViewTextBoxColumn.Name = "precioDataGridViewTextBoxColumn";
            precioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // smartphoneBindingSource
            // 
            smartphoneBindingSource.DataSource = typeof(Back.Clases.Smartphone);
            // 
            // btnVolver
            // 
            btnVolver.BackColor = SystemColors.Window;
            btnVolver.FlatStyle = FlatStyle.Flat;
            btnVolver.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnVolver.Location = new Point(819, 513);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(130, 50);
            btnVolver.TabIndex = 12;
            btnVolver.Text = "VOLVER";
            btnVolver.UseVisualStyleBackColor = false;
            btnVolver.Click += btnVolver_Click;
            // 
            // btnModificar
            // 
            btnModificar.BackColor = Color.FromArgb(192, 255, 192);
            btnModificar.FlatStyle = FlatStyle.Flat;
            btnModificar.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnModificar.Location = new Point(23, 213);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(130, 50);
            btnModificar.TabIndex = 17;
            btnModificar.Text = "MODIFICAR";
            btnModificar.UseVisualStyleBackColor = false;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.FromArgb(192, 255, 192);
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnEliminar.Location = new Point(23, 311);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(130, 50);
            btnEliminar.TabIndex = 16;
            btnEliminar.Text = "ELIMINAR";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.FromArgb(192, 255, 192);
            btnAgregar.FlatStyle = FlatStyle.Flat;
            btnAgregar.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnAgregar.Location = new Point(23, 119);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(130, 50);
            btnAgregar.TabIndex = 15;
            btnAgregar.Text = "AGREGAR";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.FromArgb(192, 255, 192);
            groupBox2.Controls.Add(label4);
            groupBox2.Location = new Point(4, -13);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(254, 60);
            groupBox2.TabIndex = 18;
            groupBox2.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(15, 22);
            label4.Name = "label4";
            label4.Size = new Size(233, 24);
            label4.TabIndex = 5;
            label4.Text = "LISTA SMARTPHONES";
            // 
            // ListaSmartphones
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(972, 575);
            Controls.Add(groupBox2);
            Controls.Add(btnModificar);
            Controls.Add(btnEliminar);
            Controls.Add(btnAgregar);
            Controls.Add(btnVolver);
            Controls.Add(dgvSmartphones);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "ListaSmartphones";
            Load += ListaSmartphones_Load;
            ((System.ComponentModel.ISupportInitialize)dgvSmartphones).EndInit();
            ((System.ComponentModel.ISupportInitialize)smartphoneBindingSource).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvSmartphones;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn marcaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn modeloDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn gbAlmacenamientoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn precioDataGridViewTextBoxColumn;
        private BindingSource smartphoneBindingSource;
        private Button btnVolver;
        private Button btnModificar;
        private Button btnEliminar;
        private Button btnAgregar;
        private GroupBox groupBox2;
        private Label label4;
    }
}