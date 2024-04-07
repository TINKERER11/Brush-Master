namespace My_project
{
    partial class Level_6
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Level_6));
            cancel = new Button();
            button11 = new Button();
            menuStrip1 = new MenuStrip();
            играToolStripMenuItem = new ToolStripMenuItem();
            начатьИгруToolStripMenuItem = new ToolStripMenuItem();
            выходToolStripMenuItem = new ToolStripMenuItem();
            pictureBox1 = new PictureBox();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // cancel
            // 
            cancel.BackgroundImage = Properties.Resources.free_icon_circular_arrow_44568;
            cancel.BackgroundImageLayout = ImageLayout.Stretch;
            cancel.Cursor = Cursors.Hand;
            cancel.Location = new Point(807, 31);
            cancel.Name = "cancel";
            cancel.Size = new Size(40, 39);
            cancel.TabIndex = 23;
            cancel.UseVisualStyleBackColor = true;
            cancel.Click += cancel_Click;
            // 
            // button11
            // 
            button11.Cursor = Cursors.AppStarting;
            button11.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            button11.Location = new Point(678, 414);
            button11.Name = "button11";
            button11.Size = new Size(118, 52);
            button11.TabIndex = 24;
            button11.Text = "Проверить";
            button11.UseVisualStyleBackColor = true;
            button11.Click += button11_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { играToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(886, 28);
            menuStrip1.TabIndex = 25;
            menuStrip1.Text = "menuStrip1";
            // 
            // играToolStripMenuItem
            // 
            играToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { начатьИгруToolStripMenuItem, выходToolStripMenuItem });
            играToolStripMenuItem.Name = "играToolStripMenuItem";
            играToolStripMenuItem.Size = new Size(57, 24);
            играToolStripMenuItem.Text = "Игра";
            // 
            // начатьИгруToolStripMenuItem
            // 
            начатьИгруToolStripMenuItem.Name = "начатьИгруToolStripMenuItem";
            начатьИгруToolStripMenuItem.Size = new Size(176, 26);
            начатьИгруToolStripMenuItem.Text = "Начать игру";
            начатьИгруToolStripMenuItem.Click += начатьИгруToolStripMenuItem_Click;
            // 
            // выходToolStripMenuItem
            // 
            выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            выходToolStripMenuItem.Size = new Size(176, 26);
            выходToolStripMenuItem.Text = "Выход";
            выходToolStripMenuItem.Click += выходToolStripMenuItem_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.example7;
            pictureBox1.Location = new Point(642, 65);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(140, 147);
            pictureBox1.TabIndex = 33;
            pictureBox1.TabStop = false;
            // 
            // Level_6
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(886, 517);
            Controls.Add(pictureBox1);
            Controls.Add(button11);
            Controls.Add(cancel);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Name = "Level_6";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Brush Master";
            FormClosed += Level_6_FormClosed;
            Load += Level_6_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button cancel;
        private Button button11;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem играToolStripMenuItem;
        private ToolStripMenuItem начатьИгруToolStripMenuItem;
        private ToolStripMenuItem выходToolStripMenuItem;
        private PictureBox pictureBox1;
    }
}