namespace Front
{
    partial class ListaUtilitarias
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
            dgvUtilitarias = new DataGridView();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            marcaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            modeloDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            usoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            utilitariaBindingSource = new BindingSource(components);
            btnVolver = new Button();
            btnModificar = new Button();
            btnEliminar = new Button();
            btnAgregar = new Button();
            groupBox2 = new GroupBox();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvUtilitarias).BeginInit();
            ((System.ComponentModel.ISupportInitialize)utilitariaBindingSource).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // dgvUtilitarias
            // 
            dgvUtilitarias.AllowUserToAddRows = false;
            dgvUtilitarias.AllowUserToDeleteRows = false;
            dgvUtilitarias.AllowUserToResizeColumns = false;
            dgvUtilitarias.AllowUserToResizeRows = false;
            dgvUtilitarias.AutoGenerateColumns = false;
            dgvUtilitarias.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvUtilitarias.BackgroundColor = SystemColors.Window;
            dgvUtilitarias.BorderStyle = BorderStyle.None;
            dgvUtilitarias.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvUtilitarias.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Window;
            dataGridViewCellStyle1.SelectionForeColor = Color.Black;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvUtilitarias.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvUtilitarias.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvUtilitarias.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, marcaDataGridViewTextBoxColumn, modeloDataGridViewTextBoxColumn, usoDataGridViewTextBoxColumn });
            dgvUtilitarias.DataSource = utilitariaBindingSource;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvUtilitarias.DefaultCellStyle = dataGridViewCellStyle2;
            dgvUtilitarias.EnableHeadersVisualStyles = false;
            dgvUtilitarias.GridColor = Color.MidnightBlue;
            dgvUtilitarias.Location = new Point(221, 75);
            dgvUtilitarias.Name = "dgvUtilitarias";
            dgvUtilitarias.ReadOnly = true;
            dgvUtilitarias.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvUtilitarias.RowHeadersVisible = false;
            dgvUtilitarias.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(49, 66, 82);
            dataGridViewCellStyle3.SelectionForeColor = Color.White;
            dgvUtilitarias.RowsDefaultCellStyle = dataGridViewCellStyle3;
            dgvUtilitarias.RowTemplate.Height = 25;
            dgvUtilitarias.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvUtilitarias.Size = new Size(563, 474);
            dgvUtilitarias.TabIndex = 4;
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
            // usoDataGridViewTextBoxColumn
            // 
            usoDataGridViewTextBoxColumn.DataPropertyName = "Uso";
            usoDataGridViewTextBoxColumn.HeaderText = "Uso";
            usoDataGridViewTextBoxColumn.Name = "usoDataGridViewTextBoxColumn";
            usoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // utilitariaBindingSource
            // 
            utilitariaBindingSource.DataSource = typeof(Back.Clases.Utilitaria);
            // 
            // btnVolver
            // 
            btnVolver.BackColor = SystemColors.Window;
            btnVolver.FlatStyle = FlatStyle.Flat;
            btnVolver.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnVolver.Location = new Point(810, 513);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(130, 50);
            btnVolver.TabIndex = 11;
            btnVolver.Text = "VOLVER";
            btnVolver.UseVisualStyleBackColor = false;
            btnVolver.Click += btnVolver_Click;
            // 
            // btnModificar
            // 
            btnModificar.BackColor = Color.FromArgb(255, 192, 128);
            btnModificar.FlatStyle = FlatStyle.Flat;
            btnModificar.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnModificar.Location = new Point(29, 196);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(130, 50);
            btnModificar.TabIndex = 14;
            btnModificar.Text = "MODIFICAR";
            btnModificar.UseVisualStyleBackColor = false;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.FromArgb(255, 192, 128);
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnEliminar.Location = new Point(29, 294);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(130, 50);
            btnEliminar.TabIndex = 13;
            btnEliminar.Text = "ELIMINAR";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.FromArgb(255, 192, 128);
            btnAgregar.FlatStyle = FlatStyle.Flat;
            btnAgregar.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnAgregar.Location = new Point(29, 102);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(130, 50);
            btnAgregar.TabIndex = 12;
            btnAgregar.Text = "AGREGAR";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.FromArgb(255, 192, 128);
            groupBox2.Controls.Add(label4);
            groupBox2.Location = new Point(-12, -17);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(317, 64);
            groupBox2.TabIndex = 15;
            groupBox2.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(27, 30);
            label4.Name = "label4";
            label4.Size = new Size(280, 24);
            label4.TabIndex = 5;
            label4.Text = "LISTA MOTOS UTILITARIAS";
            label4.Click += label4_Click;
            // 
            // ListaUtilitarias
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
            Controls.Add(dgvUtilitarias);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "ListaUtilitarias";
            Load += ListaUtilitarias_Load;
            ((System.ComponentModel.ISupportInitialize)dgvUtilitarias).EndInit();
            ((System.ComponentModel.ISupportInitialize)utilitariaBindingSource).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvUtilitarias;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn marcaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn modeloDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn usoDataGridViewTextBoxColumn;
        private BindingSource utilitariaBindingSource;
        private Button btnVolver;
        private Button btnModificar;
        private Button btnEliminar;
        private Button btnAgregar;
        private GroupBox groupBox2;
        private Label label4;
    }
}