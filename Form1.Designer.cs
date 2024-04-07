namespace My_project
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            button4 = new Button();
            pictureBox1 = new PictureBox();
            button5 = new Button();
            menuStrip1 = new MenuStrip();
            новаяИграToolStripMenuItem = new ToolStripMenuItem();
            помощьToolStripMenuItem = new ToolStripMenuItem();
            выходToolStripMenuItem = new ToolStripMenuItem();
            справкаToolStripMenuItem = new ToolStripMenuItem();
            button1 = new Button();
            cancel = new Button();
            button2 = new Button();
            pictureBox2 = new PictureBox();
            button7 = new Button();
            button3 = new Button();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // button4
            // 
            button4.Cursor = Cursors.AppStarting;
            button4.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            button4.Location = new Point(699, 416);
            button4.Name = "button4";
            button4.Size = new Size(118, 52);
            button4.TabIndex = 3;
            button4.Text = "Проверить";
            button4.UseVisualStyleBackColor = true;
            button4.Visible = false;
            button4.Click += button4_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.example;
            pictureBox1.Location = new Point(612, 42);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(140, 147);
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            pictureBox1.Visible = false;
            // 
            // button5
            // 
            button5.BackColor = Color.Transparent;
            button5.BackgroundImage = Properties.Resources.redperson1;
            button5.BackgroundImageLayout = ImageLayout.Center;
            button5.Cursor = Cursors.Hand;
            button5.FlatAppearance.BorderColor = Color.White;
            button5.FlatAppearance.MouseDownBackColor = Color.White;
            button5.FlatAppearance.MouseOverBackColor = Color.White;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Location = new Point(125, 333);
            button5.Name = "button5";
            button5.Size = new Size(70, 64);
            button5.TabIndex = 5;
            button5.UseVisualStyleBackColor = false;
            button5.Visible = false;
            button5.Click += button5_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { новаяИграToolStripMenuItem, справкаToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(886, 28);
            menuStrip1.TabIndex = 7;
            menuStrip1.Text = "menuStrip1";
            // 
            // новаяИграToolStripMenuItem
            // 
            новаяИграToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { помощьToolStripMenuItem, выходToolStripMenuItem });
            новаяИграToolStripMenuItem.Name = "новаяИграToolStripMenuItem";
            новаяИграToolStripMenuItem.Size = new Size(57, 24);
            новаяИграToolStripMenuItem.Text = "Игра";
            // 
            // помощьToolStripMenuItem
            // 
            помощьToolStripMenuItem.Name = "помощьToolStripMenuItem";
            помощьToolStripMenuItem.Size = new Size(172, 26);
            помощьToolStripMenuItem.Text = "Новая игра";
            помощьToolStripMenuItem.Click += помощьToolStripMenuItem_Click;
            // 
            // выходToolStripMenuItem
            // 
            выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            выходToolStripMenuItem.Size = new Size(172, 26);
            выходToolStripMenuItem.Text = "Выход";
            выходToolStripMenuItem.Click += выходToolStripMenuItem_Click;
            // 
            // справкаToolStripMenuItem
            // 
            справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            справкаToolStripMenuItem.Size = new Size(81, 24);
            справкаToolStripMenuItem.Text = "Справка";
            справкаToolStripMenuItem.Click += справкаToolStripMenuItem_Click;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ButtonHighlight;
            button1.Cursor = Cursors.AppStarting;
            button1.FlatAppearance.BorderColor = SystemColors.Highlight;
            button1.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(385, 188);
            button1.Name = "button1";
            button1.Size = new Size(127, 64);
            button1.TabIndex = 8;
            button1.Text = "Начать игру";
            button1.UseVisualStyleBackColor = false;
            button1.Visible = false;
            button1.Click += button1_Click;
            // 
            // cancel
            // 
            cancel.BackgroundImage = Properties.Resources.free_icon_circular_arrow_44568;
            cancel.BackgroundImageLayout = ImageLayout.Stretch;
            cancel.Cursor = Cursors.Hand;
            cancel.Location = new Point(819, 42);
            cancel.Name = "cancel";
            cancel.Size = new Size(40, 39);
            cancel.TabIndex = 9;
            cancel.UseVisualStyleBackColor = true;
            cancel.Visible = false;
            cancel.Click += cancel_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Transparent;
            button2.BackgroundImage = Properties.Resources.greenperson;
            button2.BackgroundImageLayout = ImageLayout.Center;
            button2.Cursor = Cursors.Hand;
            button2.FlatAppearance.BorderColor = Color.White;
            button2.FlatAppearance.MouseDownBackColor = Color.White;
            button2.FlatAppearance.MouseOverBackColor = Color.White;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Location = new Point(211, 52);
            button2.Name = "button2";
            button2.Size = new Size(70, 64);
            button2.TabIndex = 10;
            button2.UseVisualStyleBackColor = false;
            button2.Visible = false;
            button2.Click += button2_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.Tvo8UAvTbVo;
            pictureBox2.Location = new Point(201, 111);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(298, 299);
            pictureBox2.TabIndex = 13;
            pictureBox2.TabStop = false;
            pictureBox2.Visible = false;
            // 
            // button7
            // 
            button7.BackColor = Color.Transparent;
            button7.BackgroundImage = Properties.Resources.blueperson;
            button7.BackgroundImageLayout = ImageLayout.Center;
            button7.Cursor = Cursors.Hand;
            button7.FlatAppearance.BorderColor = Color.White;
            button7.FlatAppearance.MouseDownBackColor = Color.White;
            button7.FlatAppearance.MouseOverBackColor = Color.White;
            button7.FlatStyle = FlatStyle.Flat;
            button7.Location = new Point(350, 191);
            button7.Name = "button7";
            button7.Size = new Size(70, 64);
            button7.TabIndex = 15;
            button7.UseVisualStyleBackColor = false;
            button7.Visible = false;
            button7.Click += button3_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Transparent;
            button3.BackgroundImage = Properties.Resources.yellowperson;
            button3.BackgroundImageLayout = ImageLayout.Center;
            button3.Cursor = Cursors.Hand;
            button3.FlatAppearance.BorderColor = Color.White;
            button3.FlatAppearance.MouseDownBackColor = Color.White;
            button3.FlatAppearance.MouseOverBackColor = Color.White;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Location = new Point(280, 125);
            button3.Name = "button3";
            button3.Size = new Size(70, 64);
            button3.TabIndex = 16;
            button3.UseVisualStyleBackColor = false;
            button3.Visible = false;
            button3.Click += button6_Click;
            // 
            // panel1
            // 
            panel1.BackgroundImage = Properties.Resources.Back;
            panel1.Controls.Add(button1);
            panel1.Location = new Point(0, 31);
            panel1.Name = "panel1";
            panel1.Size = new Size(904, 484);
            panel1.TabIndex = 17;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(886, 517);
            Controls.Add(panel1);
            Controls.Add(button3);
            Controls.Add(button7);
            Controls.Add(pictureBox2);
            Controls.Add(button2);
            Controls.Add(cancel);
            Controls.Add(button5);
            Controls.Add(pictureBox1);
            Controls.Add(button4);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Brush Master";
            FormClosed += Form1_FormClosed;
            Load += Form1_Load;
            Paint += Form1_Paint;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button4;
        private PictureBox pictureBox1;
        private Button button5;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem новаяИграToolStripMenuItem;
        private ToolStripMenuItem помощьToolStripMenuItem;
        private ToolStripMenuItem выходToolStripMenuItem;
        private Button button1;
        private Button cancel;
        private Button button2;
        private Button button6;
        private PictureBox pictureBox2;
        //private Button button6;
        private Button button7;
        private Button button3;
        private ToolStripMenuItem справкаToolStripMenuItem;
        private Panel panel1;
    }
}