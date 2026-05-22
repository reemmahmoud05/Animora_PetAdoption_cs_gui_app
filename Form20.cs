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
    public partial class Form20 : Form
    {
        
        public Form20()
        {
            InitializeComponent();
            timer1.Interval = 5000;
            timer1.Start();
            

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Form11 newForm = new Form11();
            newForm.Show();
            timer1.Stop();
        }
    }
}
