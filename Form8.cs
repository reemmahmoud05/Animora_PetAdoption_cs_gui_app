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
using static System.Windows.Forms.DataFormats;

namespace PetsimulatorGUI
{
    public partial class Form8 : Form
    {
        Cat cat1 = new Cat("mimi");
       
        public Form8()
        {
            SoundPlayer player2 = new SoundPlayer(@"C:\Users\Sana\Downloads\music.wav");
            player2.Play();
            InitializeComponent();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label1.Text = cat1.sound();
            SoundPlayer player6 = new SoundPlayer(@"C:\Users\Sana\Downloads\cat.wav");
            player6.Play();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = cat1.toeat();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = cat1.toplay();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label1.Text = cat1.checkmood();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form3 f = new Form3();
            f.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form9 f = new Form9();
            f.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            label2.Text = cat1.purr();
        }
    }
}
