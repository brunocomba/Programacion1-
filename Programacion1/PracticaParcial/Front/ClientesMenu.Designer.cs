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
            label1 = new Label();
            button3 = new Button();
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
            dataGridView1.Location = new Point(45, 65);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(550, 264);
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
            button1.Location = new Point(45, 360);
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
            button2.Location = new Point(660, 400);
            button2.Name = "button2";
            button2.Size = new Size(91, 38);
            button2.TabIndex = 2;
            button2.Text = "Volver ";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(241, 9);
            label1.Name = "label1";
            label1.Size = new Size(114, 32);
            label1.TabIndex = 3;
            label1.Text = "CLIENTES";
            // 
            // button3
            // 
            button3.Location = new Point(212, 363);
            button3.Name = "button3";
            button3.Size = new Size(115, 46);
            button3.TabIndex = 4;
            button3.Text = "ELIMINAR";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // ClientesMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button3);
            Controls.Add(label1);
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
            PerformLayout();
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
        private Label label1;
        private Button button3;
    }
}