using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PetsimulatorGUI
{
    public partial class Form11 : Form
    {
        Fish fish1 = new Fish("blob");
        
        public Form11()
        {

            SoundPlayer player2 = new SoundPlayer(@"C:\Users\Sana\Downloads\music.wav");
            player2.Play();
            InitializeComponent();
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();

        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            Form9 f = new Form9();
            f.Show();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            label1.Text = fish1.toeat();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            label1.Text = fish1.toplay();
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            label1.Text = fish1.bubbles();
            SoundPlayer player6 = new SoundPlayer(@"C:\Users\Sana\Downloads\fish.wav");
            player6.Play();
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            label1.Text = fish1.checkmood();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Form3 f = new Form3();
            f.Show();
        }
    }
}
