using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace My_project
{
    public partial class Level_2 : Form
    {
        public Form1 frm1;
        public Level_3 frm4;
        Graphics g, g1;
        bool flag = true;
        bool h = false;
        bool d = true;
        bool s = false;
        int k = 0;
        int count = 2;
        Image img1 = new Bitmap("b7sQH-QFH3o.jpg");
        Image img = new Bitmap("life1.png");
        int count1 = 0;
        public Level_2()
        {
            InitializeComponent();
            g = this.CreateGraphics();
            g1 = pictureBox2.CreateGraphics();
        }

        private void Level_2_Load(object sender, EventArgs e)
        {
            button6.Visible = true;
            button3.Visible = true;
            button2.Visible = true;
            button5.Visible = true;
            cancel.Visible = true;
        }

        private void Level_2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SolidBrush bl = new SolidBrush(Color.DodgerBlue);
            for (int i = 1; i < 202; i += 10)
            {
                g1.FillRectangle(bl, 7, 9, 70, i);
                Thread.Sleep(20);
            }
            h = true;
            button3.Visible = false;
            k++;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            SolidBrush yellow = new SolidBrush(Color.Yellow);
            for (int i = 1; i < 202; i += 10)
            {
                g1.FillRectangle(yellow, 147, 9, 70, i);
                Thread.Sleep(20);
            }
            s = true;
            button6.Visible = false;
            k++;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SolidBrush red = new SolidBrush(Color.Red);
            for (int i = 1; i < 213; i += 10)
            {
                g1.FillRectangle(red, 7, 70, i, 70);
                Thread.Sleep(20);
            }
            button2.Visible = false;
            if (h == true || d == false || s == true)
                flag = false;
            else
                flag = true;
            k++;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SolidBrush green = new SolidBrush(Color.LimeGreen);
            for (int i = 1; i < 213; i += 10)
            {
                g1.FillRectangle(green, 7, 140, i, 71);
                Thread.Sleep(20);
            }
            button5.Visible = false;
            if (h == true && s == true)
                d = false;
            else
                d = true;
            k++;
            button4.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (flag == true && k == 4 && d == false)
            {
                MessageBox.Show("Верно!");
                frm4 = new Level_3();
                frm4.Show();
                frm4.frm3 = this;
                this.Hide();
            }
            else
            {
                count--;
                SolidBrush white = new SolidBrush(Color.White);
                if (count > 0)
                {
                    MessageBox.Show("Неверно...");
                    g1.Clear(BackColor);
                    g.Clear(BackColor);
                    pictureBox2.Image = img1;
                    button6.Visible = true;
                    button3.Visible = true;
                    button2.Visible = true;
                    button4.Visible = false;
                    button5.Visible = true;
                    flag = true;
                    h = false;
                    d = true;
                    s = false;
                    k = 0;
                    //for (int i = 1; i <= count; i++)
                    //    g.DrawImage(img, i * 35, 50);
                }
                else
                {
                    if (count == 0)
                    {
                        g.Clear(BackColor);
                        MessageBox.Show("Если вы хотите начать игру заново, нажмите 'Новая игра'", "Вы проиграли!");
                        frm1 = new Form1();
                        frm1.Show();
                        frm1.frm3 = this;
                        this.Hide();
                    }
                }
            }
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            g1.Clear(BackColor);
            count1++;
            if (count1 == 1)
                cancel.Enabled = false;
            pictureBox2.Image = img1;
            button6.Visible = true;
            button3.Visible = true;
            button2.Visible = true;
            button5.Visible = true;
            flag = true;
            h = false;
            d = true;
            s = false;
            k = 0;

        }

        private void новаяИграToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult t;
            t = MessageBox.Show("Хотите начать игру сначала?", "", MessageBoxButtons.YesNo);
            if (t == DialogResult.Yes)
            {
                frm1 = new Form1();
                frm1.Show();
                frm1.frm3 = this;
                this.Hide();
            }
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Level_2_Paint(object sender, PaintEventArgs e)
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
    }
}
