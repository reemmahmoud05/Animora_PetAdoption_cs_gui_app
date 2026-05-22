using System;
using PetsimulatorGUI;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PetsimulatorGUI
{
    public partial class Form5 : Form
    {
        
        public Form5()
        {
            InitializeComponent();
            
            
        }



        
        private void Form5_Load(object sender, EventArgs e)
        {
           
        }



        private void button1_Click(object sender, EventArgs e)
        {
            SoundPlayer player2 = new SoundPlayer(@"C:\Users\Sana\Downloads\click2.wav");
            player2.Play();
            Form6 newForm = new Form6();
            newForm.Show();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            SoundPlayer player2 = new SoundPlayer(@"C:\Users\Sana\Downloads\click2.wav");
            player2.Play();
            Form4 f = new Form4();
            f.Show();

        }
        

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
