using System.Media;
using System.Collections.Generic;

namespace PetsimulatorGUI
{
   

    public partial class Form1 : Form
    {
        private string text = "Welcome To Animora Adoption Center!";
        private int i = 0;
        
        public Form1()
        {
            InitializeComponent();
            SoundPlayer player = new SoundPlayer(@"C:\Users\Sana\Downloads\magic.wav");
            player.Play();
            button1.Visible = false;
            timer2.Interval = 4000;
            timer2.Tick += timer2_Tick;
            timer2.Start();
            
        }
        private void form1_load(object sender, EventArgs e)
        {
            label3.Text = "";
            timer1.Interval = 50;
            timer1.Start();
           
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (i < text.Length)
            {
                label3.Text += text[i];
                i++;
               

            }
            else
            {
                timer1.Stop();
            }
        }
        private void timer2_Tick(object? sender, EventArgs e)
        {
            button1.Visible = true;
            timer2.Stop();
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            
            SoundPlayer player1 = new SoundPlayer(@"C:\Users\Sana\Downloads\click2.wav");
            player1.Play();
            Form2 newForm = new Form2();
            newForm.Show();
            
        }
        
    }
}
