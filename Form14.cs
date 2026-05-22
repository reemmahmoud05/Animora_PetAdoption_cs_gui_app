using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PetsimulatorGUI
{
    public partial class Form14 : Form
    {
       
        public Form14()
        {


            InitializeComponent();
            timer1.Interval = 5000;
            timer1.Start();
        }


        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            Form8 newForm = new Form8();
            newForm.Show();
            timer1.Stop();
        }
    }
}