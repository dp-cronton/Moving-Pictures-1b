using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Moving_Pictures
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.Location = new Point(pictureBox1.Location.X + 50, pictureBox1.Location.Y);
            await Task.Delay(500);
            pictureBox1.Location = new Point(pictureBox1.Location.X, pictureBox1.Location.Y+50);
            await Task.Delay(500);
            pictureBox1.Location = new Point(pictureBox1.Location.X - 50, pictureBox1.Location.Y);
            await Task.Delay(500);
            pictureBox1.Location = new Point(pictureBox1.Location.X, pictureBox1.Location.Y-50);
            await Task.Delay(500);
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            pictureBox1.Location = new Point(pictureBox1.Location.X + 50, pictureBox1.Location.Y+50);
            await Task.Delay(500);
            pictureBox1.Location = new Point(pictureBox1.Location.X-100, pictureBox1.Location.Y);
            await Task.Delay(500);
            pictureBox1.Location = new Point(pictureBox1.Location.X + 50, pictureBox1.Location.Y-50);
            await Task.Delay(500);
        }

        private void left_Click(object sender, EventArgs e)
            // move left
        {
            if (pictureBox1.Location.X - 50 > 0)
            {
                pictureBox1.Location = new Point(pictureBox1.Location.X - 50, pictureBox1.Location.Y);
            }
            else
            {
                pictureBox1.Location = new Point(0, pictureBox1.Location.Y);
            }
            
        }

        private async void fullleft_Click(object sender, EventArgs e)
            // move to left of screen
        {
            while (pictureBox1.Location.X - 1 > 0)
            {
                pictureBox1.Location = new Point(pictureBox1.Location.X - 5, pictureBox1.Location.Y);
                await Task.Delay(10);
            }
        }
    }
}
