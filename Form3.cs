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

namespace PetsimulatorGUI
{
    public partial class Form3 : Form
    {
        private string animal;
        private string username;
      
        public Form3()
        {

            InitializeComponent();
            SoundPlayer player3 = new SoundPlayer(@"C:\Users\Sana\Downloads\click2.wav");
            player3.Play();
            
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            SoundPlayer player1 = new SoundPlayer(@"C:\Users\Sana\Downloads\click2.wav");
            player1.Play();

            try
            {
                if (!characterSelected)
                {
                    throw new Exception("❌ You must select a character before proceeding.");
                }

                if (animal == "dog")
                {
                    Form4 nextForm = new Form4();
                    nextForm.Show();
                }
                else if (animal == "cat")
                {
                    Form12 nextForm = new Form12();
                    nextForm.Show();
                }
                else if (animal == "bird")
                {
                    Form15 nextForm = new Form15();
                    nextForm.Show();
                }
                else
                {
                    Form18 nextForm = new Form18();
                    nextForm.Show();
                }

               
              
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SoundPlayer player2 = new SoundPlayer(@"C:\Users\Sana\Downloads\click2.wav");
            player2.Play();
            Form2 f = new Form2();
            f.Show();


        }



        private void pictureBox3_Click(object sender, EventArgs e)
        {
            SoundPlayer player5 = new SoundPlayer(@"C:\Users\Sana\Downloads\fish.wav");
            player5.Play();
        }





        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            SoundPlayer player6 = new SoundPlayer(@"C:\Users\Sana\Downloads\dog.wav");
            player6.Play();

        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            SoundPlayer player4 = new SoundPlayer(@"C:\Users\Sana\Downloads\cat.wav");
            player4.Play();

        }

        private void pictureBox4_Click_1(object sender, EventArgs e)
        {
            SoundPlayer player6 = new SoundPlayer(@"C:\Users\Sana\Downloads\bird.wav");
            player6.Play();
        }
        bool characterSelected = false;
        private void button3_Click(object sender, EventArgs e)
        {
            characterSelected = true;
           animal = "dog";
            SoundPlayer player6 = new SoundPlayer(@"C:\Users\Sana\Downloads\dog.wav");
            player6.Play();
        }



        private void button4_Click(object sender, EventArgs e)
        {
            characterSelected = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            characterSelected = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            characterSelected = true;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            SoundPlayer player6 = new SoundPlayer(@"C:\Users\Sana\Downloads\cat.wav");
            player6.Play();
            characterSelected = true;
            animal = "cat";
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            characterSelected = true;
            animal = "fish";
            SoundPlayer player5 = new SoundPlayer(@"C:\Users\Sana\Downloads\fish.wav");
            player5.Play();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            characterSelected = true;
            animal = "bird";
            SoundPlayer player6 = new SoundPlayer(@"C:\Users\Sana\Downloads\bird.wav");
            player6.Play();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}
