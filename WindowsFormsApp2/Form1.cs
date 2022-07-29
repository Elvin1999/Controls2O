using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        Timer timer=new Timer();    
        public Form1()
        {
            InitializeComponent();
            timer.Interval = 1000;
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            guna2CircleProgressBar1.Value += 5;

        }

        int scroll2 = 0;
        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            if (scroll2 >= vScrollBar1.Value)
            {
                pictureBox1.Location = new Point(pictureBox1.Location.X, vScrollBar1.Value);
            }
            else
            {
                pictureBox1.Location = new Point(pictureBox1.Location.X, vScrollBar1.Value);
            }
            scroll2 = vScrollBar1.Value;
        }
        int scroll1 = 0;
        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            if (scroll1 >= hScrollBar1.Value)
            {
                pictureBox1.Location = new Point(hScrollBar1.Value, pictureBox1.Location.Y);
            }
            else
            {
                pictureBox1.Location = new Point(hScrollBar1.Value, pictureBox1.Location.Y);
            }
            scroll1 = hScrollBar1.Value;
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void sUBVIEWToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void gREENToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Green;
        }

        private void rEDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Red;
        }
    }
}
