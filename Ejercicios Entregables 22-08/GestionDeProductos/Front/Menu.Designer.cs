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
            btnSmartphones = new Button();
            btnTelevisores = new Button();
            SuspendLayout();
            // 
            // btnSmartphones
            // 
            btnSmartphones.BackColor = Color.FromArgb(192, 255, 192);
            btnSmartphones.FlatStyle = FlatStyle.Flat;
            btnSmartphones.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnSmartphones.Location = new Point(222, 224);
            btnSmartphones.Name = "btnSmartphones";
            btnSmartphones.Size = new Size(183, 99);
            btnSmartphones.TabIndex = 1;
            btnSmartphones.Text = "SMARTPHONES";
            btnSmartphones.UseVisualStyleBackColor = false;
            btnSmartphones.Click += btnSmartphones_Click;
            // 
            // btnTelevisores
            // 
            btnTelevisores.BackColor = Color.FromArgb(192, 255, 192);
            btnTelevisores.FlatStyle = FlatStyle.Flat;
            btnTelevisores.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnTelevisores.Location = new Point(535, 224);
            btnTelevisores.Name = "btnTelevisores";
            btnTelevisores.Size = new Size(183, 99);
            btnTelevisores.TabIndex = 2;
            btnTelevisores.Text = "TELEVISORES";
            btnTelevisores.UseVisualStyleBackColor = false;
            btnTelevisores.Click += btnTelevisores_Click;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(972, 575);
            Controls.Add(btnTelevisores);
            Controls.Add(btnSmartphones);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Menu";
            ResumeLayout(false);
        }

        #endregion

        private Button btnSmartphones;
        private Button btnTelevisores;
    }
}