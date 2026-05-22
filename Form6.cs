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
    public partial class Form6 : Form
    {
        private string name;
        public Form6()
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
            name = pictureBox1.Text;
            Form7 newForm = new Form7(name);
            newForm.Show();
            timer1.Stop();

            

        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }
    }
}
