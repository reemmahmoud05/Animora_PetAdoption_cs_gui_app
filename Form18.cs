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
    public partial class Form18 : Form
    {
        
        public Form18()
        {
            InitializeComponent();
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SoundPlayer player1 = new SoundPlayer(@"C:\Users\Sana\Downloads\click2.wav");
            player1.Play();
            Form3 f = new Form3();
            f.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SoundPlayer player1 = new SoundPlayer(@"C:\Users\Sana\Downloads\click2.wav");
            player1.Play();
            string name = textBox1.Text.Trim();
            int age = (int)numericUpDown1.Value;

            bool nameError = false;
            bool ageError = false;

            try
            {

                if (string.IsNullOrEmpty(name) || !name.All(char.IsLetter))
                {
                    nameError = true;
                }


                if (age > 14 || age < 1)
                {
                    ageError = true;
                }


                if (nameError || ageError)
                {
                    throw new Exception();
                }
            }

            catch (Exception)
            {

                if (nameError && ageError)
                {
                    MessageBox.Show("❌ Name must contain only letters AND Age must be less than 14 or greater than 0.",
                                    "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (nameError)
                {
                    MessageBox.Show("❌ Name must contain only letters.",
                                    "Invalid Name", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (ageError)
                {
                    MessageBox.Show("❌ Age must be less than 14 or greater than 0.",
                                    "Invalid Age", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                return;
            }

            Form19 s = new Form19();
            s.Show();
        }
    }
    }

