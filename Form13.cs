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
    public partial class Form13 : Form
    {
       
        public Form13()
        {
            InitializeComponent();
        }



        
       

        private void Form5_Load(object sender, EventArgs e)
        {
            

        }
        private void label2_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            SoundPlayer player2 = new SoundPlayer(@"C:\Users\Sana\Downloads\click2.wav");
            player2.Play();
            Form14 newForm = new Form14();
            newForm.Show();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            SoundPlayer player2 = new SoundPlayer(@"C:\Users\Sana\Downloads\click2.wav");
            player2.Play();
            Form12 f = new Form12();
            f.Show();
        }
    }
}

