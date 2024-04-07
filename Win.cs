using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace My_project
{
    public partial class Win : Form
    {
        public Level_10 frm11;
        public Form1 frm1;
        public Win()
        {
            InitializeComponent();
        }

        private void играToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void новаяИграToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult t, t1;
            t = MessageBox.Show("Хотите начать игру заново?", "Игра пройдена!", MessageBoxButtons.YesNo);
            if (t == DialogResult.Yes)
            {
                frm1 = new Form1();
                frm1.Show();
                frm1.frm12 = this;
                this.Hide();
            }
            else
            {
                t1 = MessageBox.Show("Хотите выйти из игры?", "", MessageBoxButtons.YesNo);
                if (t1 == DialogResult.Yes)
                {
                    Application.Exit();
                }
            }
        }

        private void Win_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
