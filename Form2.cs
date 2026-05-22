using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using WMPLib;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.CodeDom;
using System.Xml.Linq;
using System.Drawing.Text;

namespace PetsimulatorGUI
{
    public partial class Form2 : Form
    {


        private string username;
        public Form2()
        {
            InitializeComponent();

        }
        

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }


        private void textBox2_TextChanged(object sender, EventArgs e)
        {


        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "dd/MM/yyyy";


        }

        private void button1_Click(object sender, EventArgs e)
        {

            string name = textBoxUsername.Text.Trim();
            DateTime birthday = dateTimePicker1.Value;

            bool nameError = false;
            bool birthdayError = false;


            try
            {
                if (string.IsNullOrWhiteSpace(name) || !name.All(char.IsLetter))
                {
                    throw new Exception("Name must contain only letters.");
                }
            }
            catch (Exception)
            {
                nameError = true;
            }


            try
            {
                if (birthday.Year > 2019)
                {
                    throw new Exception("Birth year must be 2019 or earlier.");
                }
            }
            catch (Exception)
            {
                birthdayError = true;
            }


            if (nameError && birthdayError)
            {
                MessageBox.Show("❌ Error: Name must contain only letters AND birth year must be 2019 or earlier.",
                                "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (nameError)
            {
                MessageBox.Show("❌ Error: Name must contain only letters.",
                                "Invalid Name", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (birthdayError)
            {
                MessageBox.Show("❌ Error: Birth year must be 2019 or earlier.",
                                "Invalid Birthday", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                SoundPlayer player1 = new SoundPlayer(@"C:\Users\Sana\Downloads\click2.wav");
                player1.Play();
                Form3 f = new Form3();
                f.Show();
            }


        }


        /* DateTime birthday = dateTimePicker1.Value;


         bool nameError = false;
         bool birthdayError = false;


         try
         {
             if (string.IsNullOrWhiteSpace(username) || !username.All(char.IsLetter))
             {
                 throw new Exception("Name must contain only letters.");
             }
         }
         catch (Exception)
         {
             nameError = true;
         }


         try
         {
             if (birthday.Year > 2019)
             {
                 throw new Exception("Birth year must be 2019 or earlier.");
             }
         }
         catch (Exception)
         {
             birthdayError = true;
             return;
         }


         if (nameError && birthdayError)
         {
             MessageBox.Show("❌ Error: Name must contain only letters AND birth year must be 2019 or earlier.",
                             "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
         }
         else if (nameError)
         {
             MessageBox.Show("❌ Error: Name must contain only letters.",
                             "Invalid Name", MessageBoxButtons.OK, MessageBoxIcon.Warning);
         }
         else if (birthdayError)
         {
             MessageBox.Show("❌ Error: Birth year must be 2019 or earlier.",
                             "Invalid Birthday", MessageBoxButtons.OK, MessageBoxIcon.Warning);
             return;
         }
         else
         {
             SoundPlayer player1 = new SoundPlayer(@"C:\Users\Sana\Downloads\click2.wav");
             player1.Play();
             Form3 newForm = new Form3();
             newForm.Show();




         }

     }*/


        private void button2_Click(object sender, EventArgs e)
        {
            SoundPlayer player1 = new SoundPlayer(@"C:\Users\Sana\Downloads\click2.wav");
            player1.Play();


            Form1 f = new Form1();
            f.Show();
            

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
        }
    }
}
