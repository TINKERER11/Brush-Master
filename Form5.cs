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
using System.Xml;

namespace My_project
{
    public partial class Level_4 : Form
    {
        Graphics g, g1;
        int k = 0, count = 2;
        public Level_3 frm4;
        public Level_5 frm6;
        public Form1 frm1;
        bool flag = true;
        bool h = false;
        bool d = false;
        bool l = false;
        bool z = false;
        bool p = true;
        int count1 = 0;
        Image fon = new Bitmap("YwDkaD4X-Sc.jpg");
        Image img = new Bitmap("life1.png");
        public Level_4()
        {
            InitializeComponent();
            g = this.CreateGraphics();
            g1 = pictureBox2.CreateGraphics();
        }

        private void Level_4_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Level_4_Load(object sender, EventArgs e)
        {
            button6.Visible = true;
            button1.Visible = true;
            button4.Visible = true;
            button5.Visible = true;
            button2.Visible = true;
            button3.Visible = true;
            cancel.Visible = true;
        }
        private void button5_Click(object sender, EventArgs e) // gr
        {
            SolidBrush green = new SolidBrush(Color.LimeGreen);
            button5.Visible = false;
            for (int i = 1; i < 320; i += 10)
            {
                g1.FillRectangle(green, 185, 10, 70, i);
                Thread.Sleep(20);
            }
            k++;
            button7.Visible = true;
            if (h && d && l && z)
                p = false;
            else
                p = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SolidBrush red = new SolidBrush(Color.Red);
            button2.Visible = false;
            for (int i = 1; i < 320; i += 10)
            {
                g1.FillRectangle(red, 43, 10, 70, i);
                Thread.Sleep(20);
            }
            k++;
            if (h && d)
                l = true;
            else
                l = false;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            SolidBrush blue = new SolidBrush(Color.DodgerBlue);
            button3.Visible = false;
            for (int i = 1; i < 320; i += 10)
            {
                g1.FillRectangle(blue, 113, 10, 72, i);
                Thread.Sleep(20);
            }
            k++;
            if (flag)
                h = true;
            else
                h = false;
        }

        private void button6_Click(object sender, EventArgs e) // yel
        {
            SolidBrush yellow = new SolidBrush(Color.Yellow);
            button6.Visible = false;
            for (int i = 1; i < 292; i += 10)
            {
                g1.FillRectangle(yellow, 7, 33, i, 75);
                Thread.Sleep(20);
            }
            k++;
            if (l || h || d || z || p == false)
                flag = false;
            else
                flag = true;
        }

        private void button1_Click(object sender, EventArgs e) // yel
        {
            SolidBrush yellow = new SolidBrush(Color.Yellow);
            button1.Visible = false;
            for (int i = 1; i < 292; i += 10)
            {
                g1.FillRectangle(yellow, 7, 128, i, 75);
                Thread.Sleep(20);
            }
            k++;
            if (h && d && l)
                z = true;
            else
                z = false;
        }

        private void button4_Click(object sender, EventArgs e) // yel
        {
            SolidBrush yellow = new SolidBrush(Color.Yellow);
            button4.Visible = false;
            for (int i = 1; i < 292; i += 10)
            {
                g1.FillRectangle(yellow, 7, 223, i, 75);
                Thread.Sleep(20);
            }
            k++;
            if (h)
                d = true;
            else
                d = false;
        }
        private void cancel_Click(object sender, EventArgs e)
        {
            g1.Clear(BackColor);
            pictureBox2.Image = fon;
            button6.Visible = true;
            button1.Visible = true;
            button4.Visible = true;
            button5.Visible = true;
            button2.Visible = true;
            button3.Visible = true;
            k = 0;
            flag = true;
            h = false;
            d = false;
            l = false;
            z = false;
            p = true;
            count1++;
            if (count1 == 1 || k == 4)
                cancel.Enabled = false;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (flag == true && k == 6 && p == false)
            {
                MessageBox.Show("Верно!");
                frm6 = new Level_5();
                frm6.Show();
                frm6.frm5 = this;
                this.Hide();
            }
            else
            {
                count--;
                if (count > 0)
                {
                    MessageBox.Show("Неверно...");
                    g.Clear(BackColor);
                    g1.Clear(BackColor);
                    pictureBox2.Image = fon;
                    button6.Visible = true;
                    button1.Visible = true;
                    button4.Visible = true;
                    button5.Visible = true;
                    button2.Visible = true;
                    button3.Visible = true;
                    flag = true;
                    p = true;
                    l = false;
                    z = false;
                    d = false;
                    h = false;
                    k = 0;
                }
                else
                {
                    if (count == 0)
                    {
                        g.Clear(BackColor);
                        MessageBox.Show("Если вы хотите начать игру заново, нажмите 'Новая игра'", "Вы проиграли!");
                        frm1 = new Form1();
                        frm1.Show();
                        frm1.frm5 = this;
                        this.Hide();
                    }
                }
            }
        }

        private void Level_4_Paint(object sender, PaintEventArgs e)
        {
            if (count == 2)
            {
                for (int i = 1; i <= 2; i++)
                    g.DrawImage(img, i * 35, 50);
            }
            else if (count == 1)
            {
                for (int i = 1; i <= 1; i++)
                    g.DrawImage(img, i * 35, 50);
            }
        }

        private void новаяИграToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DialogResult t;
            t = MessageBox.Show("Хотите начать игру сначала?", "", MessageBoxButtons.YesNo);
            if (t == DialogResult.Yes)
            {
                frm1 = new Form1();
                frm1.Show();
                frm1.frm5 = this;
                this.Hide();
            }
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
