using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace slot_machines
{
    public partial class Form1 : Form
    {

        int KazanılanPara;
        int JetonAdeti;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnBasla_Click(object sender, EventArgs e)
        {
            if (JetonAdeti > 0)
            {
                timer1.Start();
                btnDurdur.Enabled = true;
                lblPara.Text = KazanılanPara + "TL".ToString();
                lblJeton.Text = JetonAdeti + "Jeton".ToString();
            }
            else
            {
                MessageBox.Show("Oyuna başlamak için JETON alın...!");
                btnDurdur.Enabled = false;
            }



        }

        private void btnDurdur_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            if (JetonAdeti < 0)
            {
                MessageBox.Show("Oyuna başlamak için JETON alın...!");
                btnDurdur.Enabled = false;
            }

            if (pictureBox1.ImageLocation == pictureBox2.ImageLocation && pictureBox1.ImageLocation == pictureBox3.ImageLocation)
            {
                KazanılanPara = KazanılanPara + 100;
                lblPara.Text = KazanılanPara.ToString();
            }

            else if (pictureBox1.ImageLocation == pictureBox2.ImageLocation || pictureBox2.ImageLocation == pictureBox3.ImageLocation || pictureBox1.ImageLocation == pictureBox3.ImageLocation)
            {
                KazanılanPara = KazanılanPara + 50;
                lblPara.Text = KazanılanPara.ToString();
            }
            else
            {
                MessageBox.Show("Oyun bitti" + " " + KazanılanPara + "TL".ToString() + " " +"kazandınız");

                JetonAdeti = JetonAdeti - 1;
                lblJeton.Text = JetonAdeti.ToString();
                KazanılanPara = 0;
                lblPara.Text = KazanılanPara.ToString();
                btnDurdur.Enabled = false;
            }
            if (KazanılanPara == 1000)
            {
                Application.Exit();
            }
        }

        private void btnJeton_Click(object sender, EventArgs e)
        {

            JetonAdeti = JetonAdeti + 1;
            lblJeton.Text = JetonAdeti.ToString();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            ArrayList images = new ArrayList();
            Random rnd = new Random();

            images.Add(@"C:\Users\SEMA\source\repos\slot_machines\images\1.jpg");
            images.Add(@"C:\Users\SEMA\source\repos\slot_machines\images\2.jpg");
            images.Add(@"C:\Users\SEMA\source\repos\slot_machines\images\3.jpg");
            images.Add(@"C:\Users\SEMA\source\repos\slot_machines\images\4.jpg");
            images.Add(@"C:\Users\SEMA\source\repos\slot_machines\images\5.jpg");
            images.Add(@"C:\Users\SEMA\source\repos\slot_machines\images\6.jpg");

            pictureBox1.ImageLocation = (string)images[rnd.Next(0, 6)];
            pictureBox2.ImageLocation = (string)images[rnd.Next(0, 6)];
            pictureBox3.ImageLocation = (string)images[rnd.Next(0, 6)];


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnDurdur.Enabled = false;
        }
    }
}
