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
    public partial class Form16 : Form
    {
        
        public Form16()
        {
            InitializeComponent();
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SoundPlayer player2 = new SoundPlayer(@"C:\Users\Sana\Downloads\click2.wav");
            player2.Play();
            Form15 s = new Form15();
            s.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SoundPlayer player2 = new SoundPlayer(@"C:\Users\Sana\Downloads\click2.wav");
            player2.Play();
            Form17 s = new Form17();
            s.Show();
        }
    }
}
