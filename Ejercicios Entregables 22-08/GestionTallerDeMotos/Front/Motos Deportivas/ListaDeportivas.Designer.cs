namespace Front
{
    partial class ListaDeportivas
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
            dgvDeportivas = new DataGridView();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            marcaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            modeloDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            cilindradaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            deportivaBindingSource = new BindingSource(components);
            btnAgregar = new Button();
            button1 = new Button();
            btnEliminar = new Button();
            btnModificar = new Button();
            btnVolver = new Button();
            groupBox2 = new GroupBox();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvDeportivas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)deportivaBindingSource).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // dgvDeportivas
            // 
            dgvDeportivas.AllowUserToAddRows = false;
            dgvDeportivas.AllowUserToDeleteRows = false;
            dgvDeportivas.AllowUserToResizeColumns = false;
            dgvDeportivas.AllowUserToResizeRows = false;
            dgvDeportivas.AutoGenerateColumns = false;
            dgvDeportivas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDeportivas.BackgroundColor = SystemColors.Window;
            dgvDeportivas.BorderStyle = BorderStyle.None;
            dgvDeportivas.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvDeportivas.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Window;
            dataGridViewCellStyle1.SelectionForeColor = Color.Black;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvDeportivas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvDeportivas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvDeportivas.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, marcaDataGridViewTextBoxColumn, modeloDataGridViewTextBoxColumn, cilindradaDataGridViewTextBoxColumn });
            dgvDeportivas.DataSource = deportivaBindingSource;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvDeportivas.DefaultCellStyle = dataGridViewCellStyle2;
            dgvDeportivas.EnableHeadersVisualStyles = false;
            dgvDeportivas.GridColor = Color.MidnightBlue;
            dgvDeportivas.Location = new Point(228, 80);
            dgvDeportivas.Name = "dgvDeportivas";
            dgvDeportivas.ReadOnly = true;
            dgvDeportivas.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvDeportivas.RowHeadersVisible = false;
            dgvDeportivas.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(49, 66, 82);
            dataGridViewCellStyle3.SelectionForeColor = Color.White;
            dgvDeportivas.RowsDefaultCellStyle = dataGridViewCellStyle3;
            dgvDeportivas.RowTemplate.Height = 25;
            dgvDeportivas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDeportivas.Size = new Size(563, 474);
            dgvDeportivas.TabIndex = 3;
            dgvDeportivas.CellContentClick += dgvDeportivas_CellContentClick;
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.HeaderText = "Id";
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
            // cilindradaDataGridViewTextBoxColumn
            // 
            cilindradaDataGridViewTextBoxColumn.DataPropertyName = "Cilindrada";
            cilindradaDataGridViewTextBoxColumn.HeaderText = "Cilindrada";
            cilindradaDataGridViewTextBoxColumn.Name = "cilindradaDataGridViewTextBoxColumn";
            cilindradaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // deportivaBindingSource
            // 
            deportivaBindingSource.DataSource = typeof(Back.Clases.Deportiva);
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.FromArgb(255, 192, 128);
            btnAgregar.FlatStyle = FlatStyle.Flat;
            btnAgregar.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnAgregar.Location = new Point(26, 97);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(130, 50);
            btnAgregar.TabIndex = 4;
            btnAgregar.Text = "AGREGAR";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // button1
            // 
            button1.Location = new Point(935, 233);
            button1.Name = "button1";
            button1.Size = new Size(8, 8);
            button1.TabIndex = 5;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.FromArgb(255, 192, 128);
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnEliminar.Location = new Point(26, 289);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(130, 50);
            btnEliminar.TabIndex = 6;
            btnEliminar.Text = "ELIMINAR";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnModificar
            // 
            btnModificar.BackColor = Color.FromArgb(255, 192, 128);
            btnModificar.FlatStyle = FlatStyle.Flat;
            btnModificar.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnModificar.Location = new Point(26, 191);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(130, 50);
            btnModificar.TabIndex = 7;
            btnModificar.Text = "MODIFICAR";
            btnModificar.UseVisualStyleBackColor = false;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnVolver
            // 
            btnVolver.BackColor = SystemColors.Window;
            btnVolver.FlatStyle = FlatStyle.Flat;
            btnVolver.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnVolver.Location = new Point(813, 513);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(130, 50);
            btnVolver.TabIndex = 10;
            btnVolver.Text = "VOLVER";
            btnVolver.UseVisualStyleBackColor = false;
            btnVolver.Click += btnVolver_Click;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.FromArgb(255, 192, 128);
            groupBox2.Controls.Add(label4);
            groupBox2.Location = new Point(-2, -11);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(318, 52);
            groupBox2.TabIndex = 16;
            groupBox2.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(14, 20);
            label4.Name = "label4";
            label4.Size = new Size(287, 24);
            label4.TabIndex = 5;
            label4.Text = "LISTA MOTOS DEPORTIVAS";
            // 
            // ListaDeportivas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(972, 575);
            Controls.Add(groupBox2);
            Controls.Add(btnVolver);
            Controls.Add(btnModificar);
            Controls.Add(btnEliminar);
            Controls.Add(button1);
            Controls.Add(btnAgregar);
            Controls.Add(dgvDeportivas);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "ListaDeportivas";
            Load += Lista_Load;
            ((System.ComponentModel.ISupportInitialize)dgvDeportivas).EndInit();
            ((System.ComponentModel.ISupportInitialize)deportivaBindingSource).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvDeportivas;
        private DataGridViewTextBoxColumn cilindradaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn marcaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn modeloDataGridViewTextBoxColumn;
        private BindingSource deportivaBindingSource;
        private Button btnAgregar;
        private Button button1;
        private Button btnEliminar;
        private Button btnModificar;
        private Button btnVolver;
        private GroupBox groupBox2;
        private Label label4;
    }
}