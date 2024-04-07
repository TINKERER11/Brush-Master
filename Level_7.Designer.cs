namespace My_project
{
    partial class Level_7
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Level_7));
            menuStrip1 = new MenuStrip();
            играToolStripMenuItem = new ToolStripMenuItem();
            новаяИграToolStripMenuItem = new ToolStripMenuItem();
            выходToolStripMenuItem = new ToolStripMenuItem();
            button11 = new Button();
            cancel = new Button();
            pictureBox1 = new PictureBox();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
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
            // 
            // новаяИграToolStripMenuItem
            // 
            новаяИграToolStripMenuItem.Name = "новаяИграToolStripMenuItem";
            новаяИграToolStripMenuItem.Size = new Size(172, 26);
            новаяИграToolStripMenuItem.Text = "Новая игра";
            новаяИграToolStripMenuItem.Click += новаяИграToolStripMenuItem_Click;
            // 
            // выходToolStripMenuItem
            // 
            выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            выходToolStripMenuItem.Size = new Size(172, 26);
            выходToolStripMenuItem.Text = "Выход";
            выходToolStripMenuItem.Click += выходToolStripMenuItem_Click;
            // 
            // button11
            // 
            button11.Cursor = Cursors.AppStarting;
            button11.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            button11.Location = new Point(676, 394);
            button11.Name = "button11";
            button11.Size = new Size(118, 52);
            button11.TabIndex = 25;
            button11.Text = "Проверить";
            button11.UseVisualStyleBackColor = true;
            button11.Click += button11_Click;
            // 
            // cancel
            // 
            cancel.BackgroundImage = Properties.Resources.free_icon_circular_arrow_44568;
            cancel.BackgroundImageLayout = ImageLayout.Stretch;
            cancel.Cursor = Cursors.Hand;
            cancel.Location = new Point(808, 47);
            cancel.Name = "cancel";
            cancel.Size = new Size(40, 39);
            cancel.TabIndex = 26;
            cancel.UseVisualStyleBackColor = true;
            cancel.Click += cancel_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.example8;
            pictureBox1.Location = new Point(624, 67);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(140, 147);
            pictureBox1.TabIndex = 34;
            pictureBox1.TabStop = false;
            // 
            // Level_7
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(886, 517);
            Controls.Add(pictureBox1);
            Controls.Add(cancel);
            Controls.Add(button11);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Name = "Level_7";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Brush Master";
            FormClosed += Level_7_FormClosed;
            Load += Level_7_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem играToolStripMenuItem;
        private ToolStripMenuItem новаяИграToolStripMenuItem;
        private ToolStripMenuItem выходToolStripMenuItem;
        private Button button11;
        private Button cancel;
        private PictureBox pictureBox1;
    }
}