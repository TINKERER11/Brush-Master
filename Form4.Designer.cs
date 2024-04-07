﻿namespace My_project
{
    partial class Level_3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Level_3));
            button4 = new Button();
            button6 = new Button();
            button3 = new Button();
            button2 = new Button();
            button5 = new Button();
            cancel = new Button();
            menuStrip1 = new MenuStrip();
            играToolStripMenuItem = new ToolStripMenuItem();
            новаяИграToolStripMenuItem = new ToolStripMenuItem();
            выходToolStripMenuItem = new ToolStripMenuItem();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // button4
            // 
            button4.Cursor = Cursors.AppStarting;
            button4.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            button4.Location = new Point(699, 416);
            button4.Name = "button4";
            button4.Size = new Size(118, 52);
            button4.TabIndex = 11;
            button4.Text = "Проверить";
            button4.UseVisualStyleBackColor = true;
            button4.Visible = false;
            button4.Click += button4_Click;
            // 
            // button6
            // 
            button6.BackColor = Color.Transparent;
            button6.BackgroundImage = Properties.Resources.yellowperson;
            button6.BackgroundImageLayout = ImageLayout.Center;
            button6.Cursor = Cursors.Hand;
            button6.FlatAppearance.BorderColor = Color.White;
            button6.FlatAppearance.MouseDownBackColor = Color.White;
            button6.FlatAppearance.MouseOverBackColor = Color.White;
            button6.FlatStyle = FlatStyle.Flat;
            button6.Location = new Point(203, 149);
            button6.Name = "button6";
            button6.Size = new Size(70, 64);
            button6.TabIndex = 15;
            button6.UseVisualStyleBackColor = false;
            button6.Visible = false;
            button6.Click += button6_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Transparent;
            button3.BackgroundImage = Properties.Resources.blueperson;
            button3.BackgroundImageLayout = ImageLayout.Center;
            button3.Cursor = Cursors.Hand;
            button3.FlatAppearance.BorderColor = Color.White;
            button3.FlatAppearance.MouseDownBackColor = Color.White;
            button3.FlatAppearance.MouseOverBackColor = Color.White;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Location = new Point(203, 274);
            button3.Name = "button3";
            button3.Size = new Size(70, 62);
            button3.TabIndex = 14;
            button3.UseVisualStyleBackColor = false;
            button3.Visible = false;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Transparent;
            button2.BackgroundImage = Properties.Resources.redperson1;
            button2.BackgroundImageLayout = ImageLayout.Center;
            button2.Cursor = Cursors.Hand;
            button2.FlatAppearance.BorderColor = Color.White;
            button2.FlatAppearance.MouseDownBackColor = Color.White;
            button2.FlatAppearance.MouseOverBackColor = Color.White;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Location = new Point(454, 34);
            button2.Name = "button2";
            button2.Size = new Size(70, 62);
            button2.TabIndex = 13;
            button2.UseVisualStyleBackColor = false;
            button2.Visible = false;
            button2.Click += button2_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.Transparent;
            button5.BackgroundImage = Properties.Resources.greenperson;
            button5.BackgroundImageLayout = ImageLayout.Center;
            button5.Cursor = Cursors.Hand;
            button5.FlatAppearance.BorderColor = Color.White;
            button5.FlatAppearance.MouseDownBackColor = Color.White;
            button5.FlatAppearance.MouseOverBackColor = Color.White;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Location = new Point(337, 33);
            button5.Name = "button5";
            button5.Size = new Size(70, 64);
            button5.TabIndex = 12;
            button5.UseVisualStyleBackColor = false;
            button5.Visible = false;
            button5.Click += button5_Click;
            // 
            // cancel
            // 
            cancel.BackgroundImage = Properties.Resources.free_icon_circular_arrow_44568;
            cancel.BackgroundImageLayout = ImageLayout.Stretch;
            cancel.Cursor = Cursors.Hand;
            cancel.Location = new Point(819, 42);
            cancel.Name = "cancel";
            cancel.Size = new Size(40, 39);
            cancel.TabIndex = 16;
            cancel.UseVisualStyleBackColor = true;
            cancel.Visible = false;
            cancel.Click += cancel_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { играToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(886, 28);
            menuStrip1.TabIndex = 17;
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
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.example3;
            pictureBox1.Location = new Point(642, 42);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(137, 147);
            pictureBox1.TabIndex = 18;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.bGnwSrKvQWs1;
            pictureBox2.Location = new Point(279, 102);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(304, 293);
            pictureBox2.TabIndex = 19;
            pictureBox2.TabStop = false;
            // 
            // Level_3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(886, 517);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(cancel);
            Controls.Add(button6);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Name = "Level_3";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Brush Master";
            FormClosed += Level_3_FormClosed;
            Load += Level_3_Load;
            Paint += Form4_Paint;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button4;
        private Button button6;
        private Button button3;
        private Button button2;
        private Button button5;
        private Button cancel;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem играToolStripMenuItem;
        private ToolStripMenuItem новаяИграToolStripMenuItem;
        private ToolStripMenuItem выходToolStripMenuItem;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}