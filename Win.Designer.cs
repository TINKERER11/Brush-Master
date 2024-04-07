namespace My_project
{
    partial class Win
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Win));
            menuStrip1 = new MenuStrip();
            играToolStripMenuItem = new ToolStripMenuItem();
            новаяИграToolStripMenuItem = new ToolStripMenuItem();
            выходToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { играToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(886, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // играToolStripMenuItem
            // 
            играToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { новаяИграToolStripMenuItem, выходToolStripMenuItem });
            играToolStripMenuItem.Name = "играToolStripMenuItem";
            играToolStripMenuItem.Size = new Size(57, 24);
            играToolStripMenuItem.Text = "Игра";
            играToolStripMenuItem.Click += играToolStripMenuItem_Click;
            // 
            // новаяИграToolStripMenuItem
            // 
            новаяИграToolStripMenuItem.Name = "новаяИграToolStripMenuItem";
            новаяИграToolStripMenuItem.Size = new Size(224, 26);
            новаяИграToolStripMenuItem.Text = "Новая игра";
            новаяИграToolStripMenuItem.Click += новаяИграToolStripMenuItem_Click;
            // 
            // выходToolStripMenuItem
            // 
            выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            выходToolStripMenuItem.Size = new Size(224, 26);
            выходToolStripMenuItem.Text = "Выход";
            выходToolStripMenuItem.Click += выходToolStripMenuItem_Click;
            // 
            // Win
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = Properties.Resources.win;
            ClientSize = new Size(886, 517);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Name = "Win";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Brush Master";
            FormClosed += Win_FormClosed;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem играToolStripMenuItem;
        private ToolStripMenuItem новаяИграToolStripMenuItem;
        private ToolStripMenuItem выходToolStripMenuItem;
    }
}