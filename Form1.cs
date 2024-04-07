using System;
using System.Windows.Forms;
using System.Text;
using System.IO;
using Microsoft.VisualBasic.ApplicationServices;
using System.Drawing.Drawing2D;
using System.Reflection.Metadata;
using System.Media;
using System.Diagnostics;
namespace My_project
{
    public partial class Form1 : Form
    {
        public Level_2 frm3;
        public Level_3 frm4;
        public Level_4 frm5;
        public Level_5 frm6;
        public Level_6 frm7;
        public Level_7 frm8;
        public Level_8 frm9;
        public Level_9 frm10;
        public Level_10 frm11;
        public Win frm12;
        Image img = new Bitmap("life1.png");
        Image img1 = new Bitmap("Tvo8UAvTbVo.jpg");
        Graphics g, g1;
        bool flag = true;
        bool h = false;
        int k = 0;
        int count = 2;
        int count1 = 0;
        public Form1()
        {
            InitializeComponent();
            g = this.CreateGraphics();
            g1 = pictureBox2.CreateGraphics();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ïîìîùüToolStripMenuItem_Click(object sender, EventArgs e)
        {
            button1.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            pictureBox2.Visible = true;
            pictureBox2.Image = img1;
            g.Clear(this.BackColor);
            for (int i = 1; i <= count; i++)
                g.DrawImage(img, i * 35, 50);
            button2.Visible = true;
            button3.Visible = true;
            button5.Visible = true;
            button7.Visible = true;
            pictureBox1.Visible = true;
            button1.Visible = false;
            cancel.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            h = true;
            button4.Visible = true;
            Button B = sender as Button;
            SolidBrush greenBrush = new SolidBrush(Color.LimeGreen);
            button2.Visible = false;
            for (int i = 1; i < 286; i += 10)
            {
                g1.FillRectangle(greenBrush, 7, 8, 70, i);
                Thread.Sleep(20);
            }
            k++;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SolidBrush red = new SolidBrush(Color.DodgerBlue);
            button7.Visible = false;
            for (int i = 1; i < 147; i += 10)
            {
                g1.FillRectangle(red, 147, 148, 70, i);
                Thread.Sleep(20);
            }
            h = true;
            k++;
        }
        private void button5_Click(object sender, EventArgs e)
        {
            SolidBrush yellow = new SolidBrush(Color.Red);
            button5.Visible = false;
            k++;
            for (int i = 1; i < 286; i += 10)
            {
                g1.FillRectangle(yellow, 7, 218, i, 71);
                Thread.Sleep(20);
            }

            if (h == true)
            {
                flag = false;
            }
            else
            {
                flag = true;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            SolidBrush blueBrush = new SolidBrush(Color.Yellow);
            button3.Visible = false;
            for (int i = 1; i < 214; i += 10)
            {
                g1.FillRectangle(blueBrush, 77, 78, 70, i);
                Thread.Sleep(20);
            }
            h = true;
            k++;
        }

        private void âûõîäToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void restart()
        {
            pictureBox2.Visible = true;
            pictureBox2.Image = img1;
            g.Clear(this.BackColor);
            count = 2;
            for (int i = 1; i <= count; i++)
                g.DrawImage(img, i * 35, 50);
            button2.Visible = true;
            button3.Visible = true;
            button5.Visible = true;
            button7.Visible = true;
            pictureBox1.Visible = true;
            button1.Visible = false;
            cancel.Visible = true;
            //button1.Visible = true;
        }
        private bool Kol()
        {
            if (k == 4)
                return true;
            else
                return false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (flag == true && Kol())
            {
                MessageBox.Show("Âåðíî!");
                frm3 = new Level_2();
                frm3.Show();
                frm3.frm1 = this;
                this.Hide();
            }
            else
            {
                count--;
                if (count > 0)
                {
                    g.Clear(this.BackColor);
                    for (int i = 1; i <= 1; i++)
                        g.DrawImage(img, i * 35, 50);
                    MessageBox.Show("Íåâåðíî...");
                    g1.Clear(pictureBox2.BackColor);
                    pictureBox2.Image = img1;
                    button2.Visible = true;
                    button3.Visible = true;
                    button5.Visible = true;
                    button7.Visible = true;
                    pictureBox1.Visible = true;
                    //button1.Visible = false;
                    flag = true;
                    h = false;
                    k = 0;
                }
                else
                {
                    if (count == 0)
                    {
                        g.Clear(this.BackColor);
                        g1.Clear(pictureBox2.BackColor);
                        MessageBox.Show("Âû ïðîèãðàëè!\nÈãðà íà÷í¸òñÿ ñàìà àâòîìàòè÷åñêè");
                        restart();
                        //button1.Visible = true;
                        //pictureBox1.Visible = false;
                        //button4.Visible = false;
                        //cancel.Visible = false;
                        flag = true;
                        h = false;
                        k = 0;
                        count = 2;
                    }
                }
            }
        }
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            g1.Clear(pictureBox2.BackColor);
            g.Clear(BackColor);
            pictureBox2.Image = img1;
            count1++;
            if (count1 == 1)
                cancel.Enabled = false;
            for (int i = 1; i < count + 1; i++)
                g.DrawImage(img, i * 35, 50);
            button2.Visible = true;
            button3.Visible = true;
            button5.Visible = true;
            button7.Visible = true;
            flag = true;
            h = false;
            k = 0;
        }
        private void Form1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ñïðàâêàToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("explorer.exe", "rules.pdf");
        }
    }
}
