using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace meme
{
    public partial class Form1 : Form
    {
        private int remainingTime = 60;
        public Form1()
        {
            InitializeComponent();
            MessageBox.Show("You executed Meme.exe that will encrypt your files and if you do not enter the corect password in 1 minute all of your files will be deleated, good luck");
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (textBox1.Text == "S{h96KrFcb07/6vs{9b4]37b1RxZ0l`S94=OZAzK>£*£;HR9£:" || textBox1.Text == "7>6i5=>8_~yfe8ug.!*#[nnwbaa5t2gh*n" || textBox1.Text == "PxQ710M89McmHZY2fA0mzznU8fTeOVkS4AySHxyst2veF72vFD")
            {
                if (remainingTime > 0)
                    MessageBox.Show("You got the corect password , Congrats");
                    timer1.Stop();
                    MessageBox.Show("All of your files will not be deleaed , Yay");
                    Application.Exit();

            }
            else
            {
                MessageBox.Show("You got the wrong password");
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (remainingTime > 0)
            {
                remainingTime--;
                label1.Text = "Time : " + remainingTime.ToString() + " seconds";
            }
            else
            {
                timer1.Stop();
                MessageBox.Show("All of your files are deleated now , sorry");
                MessageBox.Show("Bye!");

                Application.Exit();

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = "Time : " + remainingTime.ToString() + " seconds";
            timer1.Interval = 1000;
            timer1.Start();
        }
    }
}
