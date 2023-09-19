namespace FrontEnd
{
    partial class Menu
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.opcionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.altaLibroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.libroFisicoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.libroDigitalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.principalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.libroFisicoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.libroDigitalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.libroFisicoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.libroDigitalBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.principalBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.libroFisicoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.libroDigitalBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.libroFisicoBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.libroDigitalBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.opcionesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(743, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // opcionesToolStripMenuItem
            // 
            this.opcionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.altaLibroToolStripMenuItem});
            this.opcionesToolStripMenuItem.Name = "opcionesToolStripMenuItem";
            this.opcionesToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.opcionesToolStripMenuItem.Text = "Opciones";
            // 
            // altaLibroToolStripMenuItem
            // 
            this.altaLibroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.libroFisicoToolStripMenuItem,
            this.libroDigitalToolStripMenuItem});
            this.altaLibroToolStripMenuItem.Name = "altaLibroToolStripMenuItem";
            this.altaLibroToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.altaLibroToolStripMenuItem.Text = "Alta Libro";
            // 
            // libroFisicoToolStripMenuItem
            // 
            this.libroFisicoToolStripMenuItem.Name = "libroFisicoToolStripMenuItem";
            this.libroFisicoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.libroFisicoToolStripMenuItem.Text = "Libro Fisico";
            this.libroFisicoToolStripMenuItem.Click += new System.EventHandler(this.libroFisicoToolStripMenuItem_Click_1);
            // 
            // libroDigitalToolStripMenuItem
            // 
            this.libroDigitalToolStripMenuItem.Name = "libroDigitalToolStripMenuItem";
            this.libroDigitalToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.libroDigitalToolStripMenuItem.Text = "Libro Digital";
            this.libroDigitalToolStripMenuItem.Click += new System.EventHandler(this.libroDigitalToolStripMenuItem_Click);
            // 
            // principalBindingSource
            // 
            this.principalBindingSource.DataSource = typeof(LogicaClases.Principal);
            // 
            // libroFisicoBindingSource
            // 
            this.libroFisicoBindingSource.DataSource = typeof(LogicaClases.LibroFisico);
            // 
            // libroDigitalBindingSource
            // 
            this.libroDigitalBindingSource.DataSource = typeof(LogicaClases.LibroDigital);
            // 
            // libroFisicoBindingSource1
            // 
            this.libroFisicoBindingSource1.DataSource = typeof(LogicaClases.LibroFisico);
            // 
            // libroDigitalBindingSource1
            // 
            this.libroDigitalBindingSource1.DataSource = typeof(LogicaClases.LibroDigital);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 365);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Menu";
            this.Text = "Menu";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.principalBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.libroFisicoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.libroDigitalBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.libroFisicoBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.libroDigitalBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem opcionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem altaLibroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem libroFisicoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem libroDigitalToolStripMenuItem;
        private System.Windows.Forms.BindingSource principalBindingSource;
        private System.Windows.Forms.BindingSource libroFisicoBindingSource;
        private System.Windows.Forms.BindingSource libroDigitalBindingSource;
        private System.Windows.Forms.BindingSource libroFisicoBindingSource1;
        private System.Windows.Forms.BindingSource libroDigitalBindingSource1;
    }
}