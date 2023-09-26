namespace Front.Clientes
{
    partial class ListadoClientes
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListadoClientes));
            groupBox1 = new GroupBox();
            label1 = new Label();
            groupBox3 = new GroupBox();
            btnNuevoCliente = new Button();
            btnEliminar = new Button();
            dgvClientes = new DataGridView();
            btnVolver = new Button();
            groupBox1.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvClientes).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.SteelBlue;
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(1, -11);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1141, 85);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Gadugi", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(365, 34);
            label1.Name = "label1";
            label1.Size = new Size(444, 32);
            label1.TabIndex = 5;
            label1.Text = "LISTADO CLIENTES REGISTRADOS";
            // 
            // groupBox3
            // 
            groupBox3.BackColor = Color.SteelBlue;
            groupBox3.Controls.Add(btnNuevoCliente);
            groupBox3.Controls.Add(btnEliminar);
            groupBox3.Location = new Point(1, 64);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(186, 507);
            groupBox3.TabIndex = 4;
            groupBox3.TabStop = false;
            // 
            // btnNuevoCliente
            // 
            btnNuevoCliente.BackColor = Color.LightYellow;
            btnNuevoCliente.FlatAppearance.BorderSize = 3;
            btnNuevoCliente.FlatStyle = FlatStyle.Popup;
            btnNuevoCliente.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnNuevoCliente.Location = new Point(11, 70);
            btnNuevoCliente.Name = "btnNuevoCliente";
            btnNuevoCliente.Size = new Size(154, 57);
            btnNuevoCliente.TabIndex = 9;
            btnNuevoCliente.Text = "NUEVO CLIENTE";
            btnNuevoCliente.UseVisualStyleBackColor = false;
            btnNuevoCliente.Click += btnNuevoCliente_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.LightYellow;
            btnEliminar.FlatAppearance.BorderSize = 3;
            btnEliminar.FlatStyle = FlatStyle.Popup;
            btnEliminar.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnEliminar.Location = new Point(11, 198);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(154, 58);
            btnEliminar.TabIndex = 11;
            btnEliminar.Text = "ELIMINAR";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // dgvClientes
            // 
            dgvClientes.AllowUserToAddRows = false;
            dgvClientes.AllowUserToDeleteRows = false;
            dgvClientes.AllowUserToResizeColumns = false;
            dgvClientes.AllowUserToResizeRows = false;
            dgvClientes.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvClientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvClientes.BackgroundColor = Color.WhiteSmoke;
            dgvClientes.BorderStyle = BorderStyle.None;
            dgvClientes.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvClientes.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.SteelBlue;
            dataGridViewCellStyle1.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.SteelBlue;
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvClientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvClientes.DefaultCellStyle = dataGridViewCellStyle2;
            dgvClientes.EnableHeadersVisualStyles = false;
            dgvClientes.GridColor = Color.Black;
            dgvClientes.Location = new Point(296, 116);
            dgvClientes.Name = "dgvClientes";
            dgvClientes.ReadOnly = true;
            dgvClientes.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvClientes.RowHeadersVisible = false;
            dgvClientes.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = Color.Gold;
            dataGridViewCellStyle3.SelectionForeColor = Color.Black;
            dgvClientes.RowsDefaultCellStyle = dataGridViewCellStyle3;
            dgvClientes.RowTemplate.Height = 25;
            dgvClientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvClientes.Size = new Size(578, 446);
            dgvClientes.TabIndex = 14;
            // 
            // btnVolver
            // 
            btnVolver.BackColor = Color.MistyRose;
            btnVolver.FlatAppearance.BorderColor = Color.White;
            btnVolver.FlatAppearance.BorderSize = 3;
            btnVolver.FlatStyle = FlatStyle.Popup;
            btnVolver.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnVolver.Location = new Point(948, 527);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(141, 35);
            btnVolver.TabIndex = 15;
            btnVolver.Text = "VOLVER";
            btnVolver.UseVisualStyleBackColor = false;
            btnVolver.Click += btnVolver_Click;
            // 
            // ListadoClientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1120, 574);
            Controls.Add(btnVolver);
            Controls.Add(dgvClientes);
            Controls.Add(groupBox3);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "ListadoClientes";
            StartPosition = FormStartPosition.CenterScreen;
            Load += ListadoClientes_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvClientes).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox3;
        private Button btnNuevoCliente;
        private Button btnEliminar;
        private Label label1;
        private DataGridView dgvClientes;
        private Button btnVolver;
    }
}