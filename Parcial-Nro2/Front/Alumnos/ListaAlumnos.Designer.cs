namespace Front
{
    partial class ListaAlumnos
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
            dgvAlumnos = new DataGridView();
            alumnoBindingSource1 = new BindingSource(components);
            alumnoBindingSource = new BindingSource(components);
            btnModificar = new Button();
            btnVolver = new Button();
            btnEliminar = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvAlumnos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)alumnoBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)alumnoBindingSource).BeginInit();
            SuspendLayout();
            // 
            // dgvAlumnos
            // 
            dgvAlumnos.AllowUserToAddRows = false;
            dgvAlumnos.AllowUserToDeleteRows = false;
            dgvAlumnos.AllowUserToResizeColumns = false;
            dgvAlumnos.AllowUserToResizeRows = false;
            dgvAlumnos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvAlumnos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAlumnos.BackgroundColor = Color.FromArgb(26, 32, 40);
            dgvAlumnos.BorderStyle = BorderStyle.None;
            dgvAlumnos.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvAlumnos.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(26, 32, 40);
            dataGridViewCellStyle1.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(26, 32, 40);
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvAlumnos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvAlumnos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(26, 32, 40);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvAlumnos.DefaultCellStyle = dataGridViewCellStyle2;
            dgvAlumnos.EnableHeadersVisualStyles = false;
            dgvAlumnos.GridColor = Color.MidnightBlue;
            dgvAlumnos.Location = new Point(152, 50);
            dgvAlumnos.Name = "dgvAlumnos";
            dgvAlumnos.ReadOnly = true;
            dgvAlumnos.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvAlumnos.RowHeadersVisible = false;
            dgvAlumnos.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(26, 32, 40);
            dataGridViewCellStyle3.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(49, 66, 82);
            dataGridViewCellStyle3.SelectionForeColor = Color.White;
            dgvAlumnos.RowsDefaultCellStyle = dataGridViewCellStyle3;
            dgvAlumnos.RowTemplate.Height = 25;
            dgvAlumnos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAlumnos.Size = new Size(745, 386);
            dgvAlumnos.TabIndex = 3;
            // 
            // alumnoBindingSource1
            // 
            alumnoBindingSource1.DataSource = typeof(Back.Clases.Alumno);
            // 
            // alumnoBindingSource
            // 
            alumnoBindingSource.DataSource = typeof(Back.Clases.Alumno);
            // 
            // btnModificar
            // 
            btnModificar.Font = new Font("Arial Narrow", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnModificar.Location = new Point(12, 76);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(119, 54);
            btnModificar.TabIndex = 15;
            btnModificar.Text = "MODIFICAR";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnVolver
            // 
            btnVolver.Font = new Font("Arial Narrow", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnVolver.Location = new Point(762, 442);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(135, 34);
            btnVolver.TabIndex = 16;
            btnVolver.Text = "VOLVER";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Font = new Font("Arial Narrow", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnEliminar.Location = new Point(12, 175);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(119, 54);
            btnEliminar.TabIndex = 17;
            btnEliminar.Text = "ELIMINAR";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(331, 9);
            label1.Name = "label1";
            label1.Size = new Size(338, 24);
            label1.TabIndex = 18;
            label1.Text = "LISTA ALUMNOS REGISTRADOS";
            // 
            // ListaAlumnos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(936, 488);
            Controls.Add(label1);
            Controls.Add(btnEliminar);
            Controls.Add(btnVolver);
            Controls.Add(btnModificar);
            Controls.Add(dgvAlumnos);
            Name = "ListaAlumnos";
            Text = "ListaAlumnos";
            Load += ListaAlumnos_Load;
            ((System.ComponentModel.ISupportInitialize)dgvAlumnos).EndInit();
            ((System.ComponentModel.ISupportInitialize)alumnoBindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)alumnoBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvAlumnos;
        private BindingSource alumnoBindingSource;
        private Button btnModificar;
        private Button btnVolver;
        private BindingSource alumnoBindingSource1;
        private Button btnEliminar;
        private Label label1;
    }
}