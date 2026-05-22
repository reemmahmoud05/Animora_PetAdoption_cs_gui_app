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
    public partial class Form19 : Form
    {
        
        public Form19()
        {
            InitializeComponent();
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SoundPlayer player2 = new SoundPlayer(@"C:\Users\Sana\Downloads\click2.wav");
            player2.Play();
            Form18 f = new Form18();
            f.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SoundPlayer player2 = new SoundPlayer(@"C:\Users\Sana\Downloads\click2.wav");
            player2.Play();
            Form20 f = new Form20();
            f.Show();
        }
    }
}
