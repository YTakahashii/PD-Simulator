using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace Simulator
{
    public partial class Form2 : Form
    {
        DateTime startTime;
        public Form2()
        {
            InitializeComponent();
            this.Top = (Screen.PrimaryScreen.WorkingArea.Height - this.Height) / 2;
            this.Left = (Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 2;
            startTime = DateTime.Now;
            timer1.Enabled = true;
            string CurrentDir = Environment.CurrentDirectory;
            string filename1 = CurrentDir + "/media/splash/loading.png";
            Bitmap back = new Bitmap(filename1);
            pictureBox1.Image = back;
            progressBar1.Parent = pictureBox1;
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            TimeSpan t = DateTime.Now - startTime;
            if (t.Seconds <= 5)
            {
                int count = (int)t.Seconds * 10;
                if (count >= 50) count = 50;
                progressBar1.Maximum = 50;
                progressBar1.Value = count;        
            }
            else if (t.Seconds <= 6)
            {
                string CurrentDir = Environment.CurrentDirectory;
                string filename1 = CurrentDir + "/media/splash/loadcomp.png";
                Bitmap back = new Bitmap(filename1);
                pictureBox1.Image = back;
            }
            else if (t.Seconds > 7)
            {
                this.Close();
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
