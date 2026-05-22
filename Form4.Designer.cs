namespace PetsimulatorGUI
{
    partial class Form4
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            PetName = new TextBox();
            numericUpDownPetAge = new NumericUpDown();
            button1 = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDownPetAge).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Jaro", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(99, 139, 89);
            label1.Location = new Point(174, 185);
            label1.Name = "label1";
            label1.Size = new Size(159, 40);
            label1.TabIndex = 0;
            label1.Text = "Pet's Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Jaro", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(99, 139, 89);
            label2.Location = new Point(196, 258);
            label2.Name = "label2";
            label2.Size = new Size(137, 40);
            label2.TabIndex = 1;
            label2.Text = "Pet's Age:";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Jaro 24pt", 28.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(99, 139, 89);
            label3.Location = new Point(57, 39);
            label3.Name = "label3";
            label3.Size = new Size(673, 63);
            label3.TabIndex = 2;
            label3.Text = "CHOOSE YOUR PET'S NAME AND AGE!";
            // 
            // PetName
            // 
            PetName.Location = new Point(386, 196);
            PetName.Name = "PetName";
            PetName.Size = new Size(171, 27);
            PetName.TabIndex = 3;
            PetName.Text = "Mochi";
            PetName.TextChanged += textBoxPetName_TextChanged;
            // 
            // numericUpDownPetAge
            // 
            numericUpDownPetAge.Location = new Point(386, 270);
            numericUpDownPetAge.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDownPetAge.Name = "numericUpDownPetAge";
            numericUpDownPetAge.Size = new Size(171, 27);
            numericUpDownPetAge.TabIndex = 4;
            numericUpDownPetAge.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // button1
            // 
            button1.Font = new Font("Jaro", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.FromArgb(99, 139, 89);
            button1.Location = new Point(684, 401);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 5;
            button1.Text = "NEXT";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Jaro", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.FromArgb(99, 139, 89);
            button2.Location = new Point(22, 401);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 6;
            button2.Text = "BACK";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(176, 219, 156);
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(numericUpDownPetAge);
            Controls.Add(PetName);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form4";
            Text = "Form4";
            Load += Form4_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDownPetAge).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox PetName;
        private NumericUpDown numericUpDownPetAge;
        private Button button1;
        private Button button2;
    }
}