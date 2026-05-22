using System.Media;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace PetsimulatorGUI
{
    public partial class Form4 : Form
    {
        private string name;
        public Form4()
        {
            InitializeComponent();
           
        }




        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }



        private void button2_Click(object sender, EventArgs e)
        {
            SoundPlayer player2 = new SoundPlayer(@"C:\Users\Sana\Downloads\click2.wav");
            player2.Play();
            Form3 f = new Form3();
            f.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.name = PetName.Text;
            string name = PetName.Text.Trim();
            int age = (int)numericUpDownPetAge.Value;

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
            //next botton
            Form5 s = new Form5();
            s.Show();
        }
        /*  string PetName = textBoxPetName.Text;
          int PetAge;


          SoundPlayer player1 = new SoundPlayer(@"C:\Users\Sana\Downloads\click2.wav");
          player1.Play();
          string name = textBoxPetName.Text.Trim();
          int age = (int)numericUpDownPetAge.Value;

          bool nameError = false;
          bool ageError = false;

          try
          {

              if (string.IsNullOrWhiteSpace(name) || !name.All(char.IsLetter))
              {
                  nameError = true;
              }


              if (age > 14)
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
                  MessageBox.Show("❌ Name must contain only letters AND age must be 14 or less.",
                                  "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
              }
              else if (nameError)
              {
                  MessageBox.Show("❌ Name must contain only letters.",
                                  "Invalid Name", MessageBoxButtons.OK, MessageBoxIcon.Warning);
              }
              else if (ageError)
              {
                  MessageBox.Show("❌ Age must be 14 or less.",
                                  "Invalid Age", MessageBoxButtons.OK, MessageBoxIcon.Warning);
              }
              return;
          }


          Form5 newForm = new Form5();
          newForm.Show();


      }*/

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void textBoxPetName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
