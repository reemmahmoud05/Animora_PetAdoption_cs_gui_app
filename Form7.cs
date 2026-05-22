using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PetsimulatorGUI
{
    public partial class Form7 : Form

    {
        
        Dog dog1= new Dog("fluffy");
        
        public Form7(string textBoxpetname)
        {

            SoundPlayer player2 = new SoundPlayer(@"C:\Users\Sana\Downloads\music.wav");
            player2.Play();
            InitializeComponent();
          
           

        }

        private void Form7_Load(object sender, EventArgs e)
        {

        }



        private void button1_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 f = new Form3();
            f.Show();

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            label6.Text = dog1.tail();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            label5.Text = dog1.toeat();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            label5.Text = dog1.toplay();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label5.Text = dog1.sound();
            SoundPlayer player6 = new SoundPlayer(@"C:\Users\Sana\Downloads\dog.wav");
            player6.Play();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label5.Text = dog1.checkmood();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            
               
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form9 f = new Form9();
            f.Show();
        }
    }
}
