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
            this.Text = "first task";
            timer.Interval = 1000;
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            timeLbl.Text=DateTime.Now.ToLongTimeString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PictureBox pb1 = new PictureBox();
            pb1.ImageLocation = "https://i.pinimg.com/originals/51/9d/47/519d4750ebfd7df5fa7788fb0850621e.jpg";
            pb1.SizeMode = PictureBoxSizeMode.AutoSize;
            this.Controls.Add(pb1);
            
        }


        private void LondonBtn_Click(object sender, EventArgs e)
        {
            
            PictureBox pb2 = new PictureBox();
            pb2.ImageLocation = "https://ustaliy.ru/wp-content/uploads/2021/11/1-741.jpg";
            pb2.SizeMode = PictureBoxSizeMode.AutoSize;
            this.Controls.Add(pb2);
        }

        private void BakuBtn_Click(object sender, EventArgs e)
        {
            PictureBox pb1 = new PictureBox();
            pb1.ImageLocation = "https://i.pinimg.com/originals/51/9d/47/519d4750ebfd7df5fa7788fb0850621e.jpg";
            pb1.SizeMode = PictureBoxSizeMode.AutoSize;
            this.Controls.Add(pb1);
        }
    }
}
