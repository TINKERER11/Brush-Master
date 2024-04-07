using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace My_project
{
    public partial class Level_5 : Form
    {
        const int n = 5;
        Graphics g;
        int[,] a = new int[n, n];
        int d = 50, x0 = 275, y0 = 100, count = 2;
        Button[,] btn = new Button[n, n];
        Image img = new Bitmap("life1.png");
        public Level_4 frm5;
        public Level_6 frm7;
        public Form1 frm1;
        int count1 = 0;
        PictureBox[] pic = new PictureBox[2];
        public Level_5()
        {
            InitializeComponent();
            g = this.CreateGraphics();
        }

        private void Level_5_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void draw_str(Button[,] btn, int[,] a, int c, Color g)
        {
            for (int j = n - 1; j >= 0; j--)
            {
                btn[c, j].BackColor = g;
                Refresh();
                Thread.Sleep(20);
                if (g == Color.Yellow)
                    a[c, j] = 1;
                else if (g == Color.DodgerBlue)
                    a[c, j] = 2;
            }
        }
        private void draw_stol(Button[,] btn, int[,] a, int c, Color g)
        {
            for (int i = n - 1; i >= 0; i--)
            {
                btn[i, c].BackColor = g;
                Refresh();
                Thread.Sleep(20);
                if (g == Color.Yellow)
                    a[i, c] = 1;
                else if (g == Color.DodgerBlue)
                    a[i, c] = 2;
            }
        }
        private void Level_5_Load(object sender, EventArgs e)
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
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            draw_stol(btn, a, n - 2, Color.DodgerBlue);
        }
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            draw_stol(btn, a, n - 3, Color.DodgerBlue);
        }
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            draw_stol(btn, a, n - 4, Color.DodgerBlue);
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            draw_stol(btn, a, n - 5, Color.DodgerBlue);
        }
        private void pictureBox5_Click(object sender, EventArgs e)
        {
            draw_str(btn, a, n - 2, Color.DodgerBlue);
        }
        private void pictureBox6_Click(object sender, EventArgs e)
        {
            draw_str(btn, a, n - 3, Color.DodgerBlue);
        }
        private void pictureBox7_Click(object sender, EventArgs e)
        {
            draw_str(btn, a, n - 4, Color.DodgerBlue);
        }
        private void pictureBox8_Click(object sender, EventArgs e)
        {
            draw_str(btn, a, n - 5, Color.DodgerBlue);
        }
        private void pictureBox9_Click(object sender, EventArgs e)
        {
            draw_str(btn, a, n - 1, Color.Yellow);
        }
        private void pictureBox10_Click(object sender, EventArgs e)
        {
            draw_stol(btn, a, n - 1, Color.Yellow);
        }
        private void button11_Click(object sender, EventArgs e)
        {
            int ch = 0, ch1 = 0;
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
            if (ch == 1 && ch1 == 24)
            {
                if (a[n - 1, n - 1] == 1)
                {
                    MessageBox.Show("Верно!");
                    frm7 = new Level_6();
                    frm7.Show();
                    frm7.frm6 = this;
                    this.Hide();
                }
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
                        frm1.frm6 = this;
                        this.Hide();
                    }
                }
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
                cancel.Visible = false;
        }
        private void новаяИграToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult t;
            t = MessageBox.Show("Хотите начать игру сначала?", "", MessageBoxButtons.YesNo);
            if (t == DialogResult.Yes)
            {
                frm1 = new Form1();
                frm1.Show();
                frm1.frm6 = this;
                this.Hide();
            }
        }
    }
}
