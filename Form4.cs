using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.IO;
using System.Collections.Specialized;
namespace My_project
{
    public partial class Level_3 : Form
    {
        int k = 0;
        int count = 2;
        bool flag = true, d = false, l = false, z = true;
        public Level_2 frm3;
        public Form1 frm1;
        public Level_4 frm5;
        Graphics g;
        Graphics g1;
        Image fon = new Bitmap("bGnwSrKvQWs.jpg");
        Image img = new Bitmap("life1.png");
        int count1 = 0;
        public Level_3()
        {
            InitializeComponent();
            g = pictureBox2.CreateGraphics();
            g1 = this.CreateGraphics();
        }
        private void Level_3_Load(object sender, EventArgs e)
        {
            pictureBox1.Visible = true;
            button2.Visible = true;
            button3.Visible = true;
            button5.Visible = true;
            button6.Visible = true;
            cancel.Visible = true;
        }
        private void Level_3_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        private void cancel_Click(object sender, EventArgs e)
        {
            g.Clear(BackColor);
            pictureBox2.Image = fon;
            button2.Visible = true;
            button3.Visible = true;
            button5.Visible = true;
            button6.Visible = true;
            k = 0;
            flag = true;
            d = false;
            l = false;
            z = true;
            count1++;
            if (count1 == 1 || k == 4)
                cancel.Enabled = false;
        }
        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            button6.Visible = false;
            SolidBrush brush = new SolidBrush(Color.Yellow);
            for (int i = 1; i < 283; i += 10)
            {
                g.FillRectangle(brush, 11, 50, i, 70);
                Thread.Sleep(20);
            }
            k++;
            if (d == true || l == true || z == false)
                flag = false;
            else
                flag = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            button5.Visible = false;
            SolidBrush brush = new SolidBrush(Color.LimeGreen);
            for (int i = 1; i < 283; i += 10)
            {
                g.FillRectangle(brush, 58, 5, 70, i);
                Thread.Sleep(20);
            }
            k++;
            d = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button3.Visible = false;
            SolidBrush brush = new SolidBrush(Color.DodgerBlue);
            for (int i = 1; i < 283; i += 10)
            {
                g.FillRectangle(brush, 11, 170, i, 70);
                Thread.Sleep(20);
            }
            k++;
            if (d == false)
                l = false;
            else
                l = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.Visible = false;
            SolidBrush brush = new SolidBrush(Color.Red);
            for (int i = 1; i < 283; i += 10)
            {
                g.FillRectangle(brush, 173, 5, 70, i);
                Thread.Sleep(20);
            }
            k++;
            if (l == true && d == true)
                z = false;
            else
                z = true;
            button4.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (flag == true && z == false && k == 4 && l == true)
            {
                MessageBox.Show("Верно!");
                frm5 = new Level_4();
                frm5.Show();
                frm5.frm4 = this;
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
                    pictureBox1.Visible = true;
                    button2.Visible = true;
                    button3.Visible = true;
                    button5.Visible = true;
                    button6.Visible = true;
                    cancel.Visible = true;
                    k = 0;
                    flag = true;
                    d = false;
                    l = false;
                    z = true;

                }
                else
                {
                    if (count == 0)
                    {
                        MessageBox.Show("Если вы хотите начать игру заново, нажмите 'Новая игра'", "Вы проиграли!");
                        frm1 = new Form1();
                        frm1.Show();
                        frm1.frm4 = this;
                        this.Hide();
                    }
                }
            }
        }
        private void Form4_Paint(object sender, PaintEventArgs e)
        {
            if (count == 2)
            {
                for (int i = 1; i <= 2; i++)
                    g1.DrawImage(img, i * 35, 50);
            }
            else if (count == 1)
            {
                for (int i = 1; i <= 1; i++)
                    g1.DrawImage(img, i * 35, 50);
            }
        }

        private void новаяИграToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult t;
            t = MessageBox.Show("Хотите начать игру сначала?", "", MessageBoxButtons.YesNo);
            if (t == DialogResult.Yes)
            {
                frm1 = new Form1();
                frm1.Show();
                frm1.frm4 = this;
                this.Hide();
            }
        }
    }
}
