namespace Front
{
    partial class ClientesMenu
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
            dataGridView1 = new DataGridView();
            dniDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nombreDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            apellidoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            clienteBindingSource1 = new BindingSource(components);
            principalBindingSource3 = new BindingSource(components);
            clienteBindingSource = new BindingSource(components);
            principalBindingSource2 = new BindingSource(components);
            principalBindingSource = new BindingSource(components);
            button1 = new Button();
            principalBindingSource1 = new BindingSource(components);
            libroFisicoBindingSource = new BindingSource(components);
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)clienteBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)principalBindingSource3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)clienteBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)principalBindingSource2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)principalBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)principalBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)libroFisicoBindingSource).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { dniDataGridViewTextBoxColumn, nombreDataGridViewTextBoxColumn, apellidoDataGridViewTextBoxColumn });
            dataGridView1.DataSource = clienteBindingSource1;
            dataGridView1.Location = new Point(80, 37);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(343, 230);
            dataGridView1.TabIndex = 0;
            // 
            // dniDataGridViewTextBoxColumn
            // 
            dniDataGridViewTextBoxColumn.DataPropertyName = "dni";
            dniDataGridViewTextBoxColumn.HeaderText = "DNI";
            dniDataGridViewTextBoxColumn.Name = "dniDataGridViewTextBoxColumn";
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            nombreDataGridViewTextBoxColumn.DataPropertyName = "nombre";
            nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            // 
            // apellidoDataGridViewTextBoxColumn
            // 
            apellidoDataGridViewTextBoxColumn.DataPropertyName = "apellido";
            apellidoDataGridViewTextBoxColumn.HeaderText = "Apellido";
            apellidoDataGridViewTextBoxColumn.Name = "apellidoDataGridViewTextBoxColumn";
            // 
            // clienteBindingSource1
            // 
            clienteBindingSource1.DataSource = typeof(Logica.Clases.Cliente);
            // 
            // principalBindingSource3
            // 
            principalBindingSource3.DataSource = typeof(Logica.Clases.Principal);
            // 
            // clienteBindingSource
            // 
            clienteBindingSource.DataSource = typeof(Logica.Clases.Cliente);
            // 
            // principalBindingSource2
            // 
            principalBindingSource2.DataSource = typeof(Logica.Clases.Principal);
            // 
            // principalBindingSource
            // 
            principalBindingSource.DataSource = typeof(Logica.Clases.Principal);
            // 
            // button1
            // 
            button1.Location = new Point(80, 324);
            button1.Name = "button1";
            button1.Size = new Size(112, 49);
            button1.TabIndex = 1;
            button1.Text = "Registrar nuevo cliente";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // principalBindingSource1
            // 
            principalBindingSource1.DataSource = typeof(Logica.Clases.Principal);
            // 
            // libroFisicoBindingSource
            // 
            libroFisicoBindingSource.DataSource = typeof(Logica.Clases.LibroFisico);
            // 
            // button2
            // 
            button2.Location = new Point(304, 324);
            button2.Name = "button2";
            button2.Size = new Size(119, 49);
            button2.TabIndex = 2;
            button2.Text = "Volver ";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // ClientesMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Name = "ClientesMenu";
            Text = "ClientesMenu";
            Load += ClientesMenu_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)clienteBindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)principalBindingSource3).EndInit();
            ((System.ComponentModel.ISupportInitialize)clienteBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)principalBindingSource2).EndInit();
            ((System.ComponentModel.ISupportInitialize)principalBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)principalBindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)libroFisicoBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Button button1;
        private BindingSource principalBindingSource;
        private BindingSource clienteBindingSource;
        private BindingSource principalBindingSource1;
        private BindingSource principalBindingSource2;
        private BindingSource libroFisicoBindingSource;
        private BindingSource principalBindingSource3;
        private DataGridViewTextBoxColumn dniDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn apellidoDataGridViewTextBoxColumn;
        private BindingSource clienteBindingSource1;
        private Button button2;
    }
}