namespace PetsimulatorGUI
{
    partial class Form11
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form11));
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Jaro 48pt", 13.8F);
            button1.ForeColor = Color.FromArgb(99, 139, 89);
            button1.Location = new Point(662, 32);
            button1.Name = "button1";
            button1.Size = new Size(126, 37);
            button1.TabIndex = 0;
            button1.Text = "RESTART";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // button2
            // 
            button2.Font = new Font("Jaro 48pt", 13.8F);
            button2.ForeColor = Color.FromArgb(99, 139, 89);
            button2.Location = new Point(43, 32);
            button2.Name = "button2";
            button2.Size = new Size(124, 37);
            button2.TabIndex = 1;
            button2.Text = "CHANGE PET";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click_1;
            // 
            // button3
            // 
            button3.Font = new Font("Jaro 48pt", 13.8F);
            button3.ForeColor = Color.FromArgb(99, 139, 89);
            button3.Location = new Point(109, 383);
            button3.Name = "button3";
            button3.Size = new Size(94, 34);
            button3.TabIndex = 2;
            button3.Text = "EAT";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click_1;
            // 
            // button4
            // 
            button4.Font = new Font("Jaro 48pt", 13.8F);
            button4.ForeColor = Color.FromArgb(99, 139, 89);
            button4.Location = new Point(260, 383);
            button4.Name = "button4";
            button4.Size = new Size(94, 34);
            button4.TabIndex = 3;
            button4.Text = "PLAY";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click_1;
            // 
            // button5
            // 
            button5.Font = new Font("Jaro 48pt", 13.8F);
            button5.ForeColor = Color.FromArgb(99, 139, 89);
            button5.Location = new Point(428, 383);
            button5.Name = "button5";
            button5.Size = new Size(94, 34);
            button5.TabIndex = 4;
            button5.Text = "BUBBLES";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click_1;
            // 
            // button6
            // 
            button6.Font = new Font("Jaro 48pt", 13.8F);
            button6.ForeColor = Color.FromArgb(99, 139, 89);
            button6.Location = new Point(574, 383);
            button6.Name = "button6";
            button6.Size = new Size(94, 34);
            button6.TabIndex = 5;
            button6.Text = "MOOD";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click_1;
            // 
            // button7
            // 
            button7.Font = new Font("Jaro 48pt", 13.8F);
            button7.ForeColor = Color.FromArgb(99, 139, 89);
            button7.Location = new Point(662, 88);
            button7.Name = "button7";
            button7.Size = new Size(126, 35);
            button7.TabIndex = 6;
            button7.Text = "END GAME";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(202, 76, 54);
            label1.Font = new Font("Jaro", 18F);
            label1.ForeColor = Color.FromArgb(237, 153, 80);
            label1.Location = new Point(332, 83);
            label1.Name = "label1";
            label1.Size = new Size(0, 40);
            label1.TabIndex = 7;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(315, 161);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(139, 168);
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // Form11
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form11";
            Text = "Form11";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Label label1;
        private PictureBox pictureBox1;
    }
}