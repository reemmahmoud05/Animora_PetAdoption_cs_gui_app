using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace PetsimulatorGUI
{
    public partial class Form10 : Form
    {
        Bird bird1 = new Bird("sew");
        

        private void Form10_Load(object sender, EventArgs e)
        {

        }
        public Form10()
        {
            SoundPlayer player2 = new SoundPlayer(@"C:\Users\Sana\Downloads\music.wav");
            player2.Play();
            InitializeComponent();
            
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            label2.Text = bird1.Fly();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Form3 f = new Form3();
            f.Show();
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
            label1.Text = bird1.toeat();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            label1.Text = bird1.toplay();
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            label1.Text = bird1.sound();
            SoundPlayer player6 = new SoundPlayer(@"C:\Users\Sana\Downloads\bird.wav");
            player6.Play();
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            label1.Text = bird1.checkmood();
        }
    }
}
