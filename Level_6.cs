using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Security.Authentication.ExtendedProtection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace My_project
{
    public partial class Level_6 : Form
    {
        const int n = 5;
        Button[,] btn = new Button[n, n];
        int[,] a = new int[n, n];
        Graphics g;
        PictureBox[] str = new PictureBox[n];
        PictureBox[] stol = new PictureBox[n];
        PictureBox[] pic = new PictureBox[2];
        int d = 50, x0 = 275, y0 = 100, count = 2, count1 = 0;
        Image yel = new Bitmap("oOWEHQ-hHi8.jpg");
        Image bl = new Bitmap("f1f8rTxyHNM.jpg");
        Image img = new Bitmap("life1.png");
        public Level_5 frm6;
        public Form1 frm1;
        public Level_7 frm8;
        public Level_6()
        {
            InitializeComponent();
            g = this.CreateGraphics();
        }
        private void draw_str(Button[,] btn, int[,] a, int c)
        {
            for (int j = n - 1; j >= 0; j--)
            {
                btn[c, j].BackColor = Color.Yellow;
                Refresh();
                Thread.Sleep(20);
                a[c, j] = 1;
            }
        }
        private void draw_stol(Button[,] btn, int[,] a, int c)
        {
            for (int i = n - 1; i >= 0; i--)
            {
                btn[i, c].BackColor = Color.DodgerBlue;
                Refresh();
                Thread.Sleep(20);
                a[i, c] = 2;
            }
        }
        private void str_Click(object sender, EventArgs e)
        {
            PictureBox B = (PictureBox)sender;
            int i;
            i = (B.Top - 100) / d;
            draw_str(btn, a, i);
        }
        private void stol_Click(object sender, EventArgs e)
        {
            PictureBox B = (PictureBox)sender;
            int j;
            j = (B.Left - 275) / d;
            draw_stol(btn, a, j);
        }
        private void Level_6_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    btn[i, j] = new Button();
                    btn[i, j].Size = new Size(d, d);
                    btn[i, j].Left = x0 + j * d;
                    btn[i, j].Top = y0 + i * d;
                    this.Controls.Add(btn[i, j]);

                    a[i, j] = 0;
                }
            }
            for (int h = 0; h < n; h++)
            {
                str[h] = new PictureBox();
                str[h].Size = new Size(66, 47);
                str[h].Image = yel;
                str[h].SizeMode = PictureBoxSizeMode.StretchImage;
                str[h].Left = 525;
                str[h].Top = 100 + h * d;
                str[h].Click += str_Click;
                this.Controls.Add(str[h]);

                stol[h] = new PictureBox();
                stol[h].Size = new Size(47, 66);
                stol[h].Image = bl;
                stol[h].SizeMode = PictureBoxSizeMode.StretchImage;
                stol[h].Left = 275 + h * d;
                stol[h].Top = 350;
                stol[h].Click += stol_Click;
                this.Controls.Add(stol[h]);
            }

            for (int s = 0; s < count; s++)
            {
                pic[s] = new PictureBox();
                pic[s].Size = new Size(25, 25);
                pic[s].Image = img;
                pic[s].SizeMode = PictureBoxSizeMode.StretchImage;
                pic[s].Left = 35 * s + 35;
                pic[s].Top = 50;
                this.Controls.Add(pic[s]);
            }
        }
        private void Level_6_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        private void button11_Click(object sender, EventArgs e)
        {
            int ch = 0, ch1 = 0;
            bool flag = false, h = false;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (a[i, j] == 1)
                        ch++;
                    else if (a[i, j] == 2)
                        ch1++;
                }
            }
            for (int i = 0; i < n; i++)
            {
                if (a[i, 0] == 2 && a[i, 4] == 2)
                {
                    flag = true;
                }
            }
            for (int j = 0; j < n; j++)
            {
                if (a[0, j] == 2 && a[4, j] == 2)
                {
                    h = true;
                }
            }
            if (ch == 9 && ch1 == 16 && flag == true && h == true)
            {
                MessageBox.Show("Верно!");
                frm8 = new Level_7();
                frm8.Show();
                frm8.frm7 = this;
                this.Hide();
            }
            else
            {
                for (int s = 0; s < count; s++)
                    pic[s].Visible = false;
                count--;
                Array.Resize(ref pic, count);
                for (int s = 0; s < count; s++)
                    pic[s].Visible = true;
                if (count > 0)
                {
                    MessageBox.Show("Неверно...");
                    for (int i = 0; i < n; i++)
                    {
                        for (int j = 0; j < n; j++)
                        {
                            btn[i, j].BackColor = Color.White;
                            a[i, j] = 0;
                        }
                    }
                }
                else
                {
                    if (count == 0)
                    {
                        MessageBox.Show("Нажмите 'Начать игру'", "Вы проиграли!");
                        frm1 = new Form1();
                        frm1.Show();
                        frm1.frm7 = this;
                        this.Hide();
                    }
                }
            }
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void начатьИгруToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult t;
            t = MessageBox.Show("Хотите начать игру сначала?", "", MessageBoxButtons.YesNo);
            if (t == DialogResult.Yes)
            {
                frm1 = new Form1();
                frm1.Show();
                frm1.frm7 = this;
                this.Hide();
            }
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    btn[i, j].BackColor = Color.White;
                    a[i, j] = 0;
                }
            }
            count1++;
            if (count1 == 1)
                cancel.Enabled = false;
        }
    }
}
