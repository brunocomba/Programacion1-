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
            clienteBindingSource8 = new BindingSource(components);
            clienteBindingSource6 = new BindingSource(components);
            clienteBindingSource3 = new BindingSource(components);
            clienteBindingSource2 = new BindingSource(components);
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
            button4 = new Button();
            clienteBindingSource4 = new BindingSource(components);
            principalBindingSource4 = new BindingSource(components);
            clienteBindingSource5 = new BindingSource(components);
            clienteBindingSource7 = new BindingSource(components);
            principalBindingSource5 = new BindingSource(components);
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dniDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nombreDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            apellidoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)clienteBindingSource8).BeginInit();
            ((System.ComponentModel.ISupportInitialize)clienteBindingSource6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)clienteBindingSource3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)clienteBindingSource2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)clienteBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)principalBindingSource3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)clienteBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)principalBindingSource2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)principalBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)principalBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)libroFisicoBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)clienteBindingSource4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)principalBindingSource4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)clienteBindingSource5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)clienteBindingSource7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)principalBindingSource5).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, dniDataGridViewTextBoxColumn, nombreDataGridViewTextBoxColumn, apellidoDataGridViewTextBoxColumn });
            dataGridView1.DataSource = clienteBindingSource8;
            dataGridView1.Location = new Point(54, 58);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(541, 428);
            dataGridView1.TabIndex = 0;
            // 
            // clienteBindingSource8
            // 
            clienteBindingSource8.DataSource = typeof(Logica.Clases.Cliente);
            // 
            // clienteBindingSource6
            // 
            clienteBindingSource6.DataSource = typeof(Logica.Clases.Cliente);
            // 
            // clienteBindingSource3
            // 
            clienteBindingSource3.DataSource = typeof(Logica.Clases.Cliente);
            // 
            // clienteBindingSource2
            // 
            clienteBindingSource2.DataSource = typeof(Logica.Clases.Cliente);
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
            button1.Location = new Point(54, 516);
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
            button2.Location = new Point(679, 546);
            button2.Name = "button2";
            button2.Size = new Size(91, 38);
            button2.TabIndex = 4;
            button2.Text = "Volver ";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(260, 9);
            label1.Name = "label1";
            label1.Size = new Size(114, 32);
            label1.TabIndex = 3;
            label1.Text = "CLIENTES";
            // 
            // button3
            // 
            button3.Location = new Point(260, 516);
            button3.Name = "button3";
            button3.Size = new Size(115, 49);
            button3.TabIndex = 2;
            button3.Text = "ELIMINAR";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(476, 516);
            button4.Name = "button4";
            button4.Size = new Size(119, 49);
            button4.TabIndex = 3;
            button4.Text = "Modificar";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // clienteBindingSource4
            // 
            clienteBindingSource4.DataSource = typeof(Logica.Clases.Cliente);
            // 
            // principalBindingSource4
            // 
            principalBindingSource4.DataSource = typeof(Logica.Clases.Principal);
            // 
            // clienteBindingSource5
            // 
            clienteBindingSource5.DataSource = typeof(Logica.Clases.Cliente);
            // 
            // clienteBindingSource7
            // 
            clienteBindingSource7.DataSource = typeof(Logica.Clases.Cliente);
            // 
            // principalBindingSource5
            // 
            principalBindingSource5.DataSource = typeof(Logica.Clases.Principal);
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "id";
            idDataGridViewTextBoxColumn.HeaderText = "ID";
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
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
            // ClientesMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(819, 596);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Name = "ClientesMenu";
            Text = "ClientesMenu";
            Load += ClientesMenu_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)clienteBindingSource8).EndInit();
            ((System.ComponentModel.ISupportInitialize)clienteBindingSource6).EndInit();
            ((System.ComponentModel.ISupportInitialize)clienteBindingSource3).EndInit();
            ((System.ComponentModel.ISupportInitialize)clienteBindingSource2).EndInit();
            ((System.ComponentModel.ISupportInitialize)clienteBindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)principalBindingSource3).EndInit();
            ((System.ComponentModel.ISupportInitialize)clienteBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)principalBindingSource2).EndInit();
            ((System.ComponentModel.ISupportInitialize)principalBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)principalBindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)libroFisicoBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)clienteBindingSource4).EndInit();
            ((System.ComponentModel.ISupportInitialize)principalBindingSource4).EndInit();
            ((System.ComponentModel.ISupportInitialize)clienteBindingSource5).EndInit();
            ((System.ComponentModel.ISupportInitialize)clienteBindingSource7).EndInit();
            ((System.ComponentModel.ISupportInitialize)principalBindingSource5).EndInit();
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
        private BindingSource clienteBindingSource1;
        private Button button2;
        private Label label1;
        private Button button3;
        private BindingSource clienteBindingSource2;
        private BindingSource clienteBindingSource3;
        private Button button4;
        private BindingSource clienteBindingSource6;
        private BindingSource clienteBindingSource4;
        private BindingSource principalBindingSource4;
        private BindingSource clienteBindingSource5;
        private BindingSource clienteBindingSource8;
        private BindingSource clienteBindingSource7;
        private BindingSource principalBindingSource5;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dniDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn apellidoDataGridViewTextBoxColumn;
    }
}