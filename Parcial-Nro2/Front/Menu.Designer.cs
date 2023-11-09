namespace Front
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            menuStrip1 = new MenuStrip();
            aCCIONESToolStripMenuItem = new ToolStripMenuItem();
            profesoresToolStripMenuItem = new ToolStripMenuItem();
            aLTAToolStripMenuItem = new ToolStripMenuItem();
            cURSOSToolStripMenuItem = new ToolStripMenuItem();
            aLTAToolStripMenuItem2 = new ToolStripMenuItem();
            aLUMNOSToolStripMenuItem = new ToolStripMenuItem();
            aLTAToolStripMenuItem1 = new ToolStripMenuItem();
            mODIFICARToolStripMenuItem = new ToolStripMenuItem();
            eLIMINARToolStripMenuItem = new ToolStripMenuItem();
            label1 = new Label();
            label2 = new Label();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { aCCIONESToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(7, 2, 0, 2);
            menuStrip1.Size = new Size(914, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // aCCIONESToolStripMenuItem
            // 
            aCCIONESToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { profesoresToolStripMenuItem, cURSOSToolStripMenuItem, aLUMNOSToolStripMenuItem });
            aCCIONESToolStripMenuItem.Name = "aCCIONESToolStripMenuItem";
            aCCIONESToolStripMenuItem.Size = new Size(76, 20);
            aCCIONESToolStripMenuItem.Text = "OPCIONES";
            // 
            // profesoresToolStripMenuItem
            // 
            profesoresToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { aLTAToolStripMenuItem });
            profesoresToolStripMenuItem.Name = "profesoresToolStripMenuItem";
            profesoresToolStripMenuItem.Size = new Size(180, 22);
            profesoresToolStripMenuItem.Text = "PROFESORES";
            profesoresToolStripMenuItem.Click += profesoresToolStripMenuItem_Click;
            // 
            // aLTAToolStripMenuItem
            // 
            aLTAToolStripMenuItem.Name = "aLTAToolStripMenuItem";
            aLTAToolStripMenuItem.Size = new Size(100, 22);
            aLTAToolStripMenuItem.Text = "ALTA";
            aLTAToolStripMenuItem.Click += aLTAToolStripMenuItem_Click;
            // 
            // cURSOSToolStripMenuItem
            // 
            cURSOSToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { aLTAToolStripMenuItem2 });
            cURSOSToolStripMenuItem.Name = "cURSOSToolStripMenuItem";
            cURSOSToolStripMenuItem.Size = new Size(180, 22);
            cURSOSToolStripMenuItem.Text = "CURSOS";
            // 
            // aLTAToolStripMenuItem2
            // 
            aLTAToolStripMenuItem2.Name = "aLTAToolStripMenuItem2";
            aLTAToolStripMenuItem2.Size = new Size(100, 22);
            aLTAToolStripMenuItem2.Text = "ALTA";
            aLTAToolStripMenuItem2.Click += aLTAToolStripMenuItem2_Click;
            // 
            // aLUMNOSToolStripMenuItem
            // 
            aLUMNOSToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { aLTAToolStripMenuItem1, mODIFICARToolStripMenuItem, eLIMINARToolStripMenuItem });
            aLUMNOSToolStripMenuItem.Name = "aLUMNOSToolStripMenuItem";
            aLUMNOSToolStripMenuItem.Size = new Size(180, 22);
            aLUMNOSToolStripMenuItem.Text = "ALUMNOS";
            aLUMNOSToolStripMenuItem.Click += aLUMNOSToolStripMenuItem_Click;
            // 
            // aLTAToolStripMenuItem1
            // 
            aLTAToolStripMenuItem1.Name = "aLTAToolStripMenuItem1";
            aLTAToolStripMenuItem1.Size = new Size(180, 22);
            aLTAToolStripMenuItem1.Text = "ALTA";
            aLTAToolStripMenuItem1.Click += aLTAToolStripMenuItem1_Click;
            // 
            // mODIFICARToolStripMenuItem
            // 
            mODIFICARToolStripMenuItem.Name = "mODIFICARToolStripMenuItem";
            mODIFICARToolStripMenuItem.Size = new Size(180, 22);
            mODIFICARToolStripMenuItem.Text = "MODIFICAR";
            mODIFICARToolStripMenuItem.Click += mODIFICARToolStripMenuItem_Click;
            // 
            // eLIMINARToolStripMenuItem
            // 
            eLIMINARToolStripMenuItem.Name = "eLIMINARToolStripMenuItem";
            eLIMINARToolStripMenuItem.Size = new Size(180, 22);
            eLIMINARToolStripMenuItem.Text = "ELIMINAR";
            eLIMINARToolStripMenuItem.Click += eLIMINARToolStripMenuItem_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Narrow", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(22, 317);
            label1.Name = "label1";
            label1.Size = new Size(744, 80);
            label1.TabIndex = 1;
            label1.Text = resources.GetString("label1.Text");
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(22, 299);
            label2.Name = "label2";
            label2.Size = new Size(253, 18);
            label2.TabIndex = 2;
            label2.Text = "PREGUNTA PARA PROMOCION";
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(8F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 480);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            Font = new Font("Arial", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            MainMenuStrip = menuStrip1;
            Name = "Menu";
            Text = "Menu";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem aCCIONESToolStripMenuItem;
        private ToolStripMenuItem profesoresToolStripMenuItem;
        private ToolStripMenuItem aLTAToolStripMenuItem;
        private ToolStripMenuItem cURSOSToolStripMenuItem;
        private ToolStripMenuItem aLUMNOSToolStripMenuItem;
        private ToolStripMenuItem aLTAToolStripMenuItem1;
        private ToolStripMenuItem aLTAToolStripMenuItem2;
        private ToolStripMenuItem mODIFICARToolStripMenuItem;
        private ToolStripMenuItem eLIMINARToolStripMenuItem;
        private Label label1;
        private Label label2;
    }
}