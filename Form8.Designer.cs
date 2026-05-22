namespace PetsimulatorGUI
{
    partial class Form8
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form8));
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            label1 = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Jaro 48pt", 13.8F);
            button1.ForeColor = Color.FromArgb(99, 139, 89);
            button1.Location = new Point(241, 657);
            button1.Name = "button1";
            button1.Size = new Size(94, 36);
            button1.TabIndex = 0;
            button1.Text = "EAT";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Jaro 48pt", 13.8F);
            button2.ForeColor = Color.FromArgb(99, 139, 89);
            button2.Location = new Point(420, 657);
            button2.Name = "button2";
            button2.Size = new Size(94, 36);
            button2.TabIndex = 1;
            button2.Text = "PLAY";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Jaro 48pt", 13.8F);
            button3.ForeColor = Color.FromArgb(99, 139, 89);
            button3.Location = new Point(605, 657);
            button3.Name = "button3";
            button3.Size = new Size(94, 36);
            button3.TabIndex = 2;
            button3.Text = "MEOW";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Font = new Font("Jaro 48pt", 13.8F);
            button4.ForeColor = Color.FromArgb(99, 139, 89);
            button4.Location = new Point(793, 657);
            button4.Name = "button4";
            button4.Size = new Size(94, 36);
            button4.TabIndex = 3;
            button4.Text = "MOOD";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Font = new Font("Jaro 48pt", 13.8F);
            button5.ForeColor = Color.FromArgb(99, 139, 89);
            button5.Location = new Point(12, 39);
            button5.Name = "button5";
            button5.Size = new Size(145, 37);
            button5.TabIndex = 4;
            button5.Text = "CHANGE PET";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Font = new Font("Jaro 48pt", 13.8F);
            button6.ForeColor = Color.FromArgb(99, 139, 89);
            button6.Location = new Point(925, 56);
            button6.Name = "button6";
            button6.Size = new Size(121, 37);
            button6.TabIndex = 5;
            button6.Text = "RESTART";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.Font = new Font("Jaro 48pt", 13.8F);
            button7.ForeColor = Color.FromArgb(99, 139, 89);
            button7.Location = new Point(925, 118);
            button7.Name = "button7";
            button7.Size = new Size(121, 34);
            button7.TabIndex = 6;
            button7.Text = "END GAME";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(237, 153, 80);
            label1.Font = new Font("Jaro 24pt", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(202, 76, 54);
            label1.Location = new Point(91, 226);
            label1.Name = "label1";
            label1.Size = new Size(0, 49);
            label1.TabIndex = 7;
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(237, 153, 80);
            label2.Font = new Font("Jaro 24pt", 22.2F);
            label2.ForeColor = Color.FromArgb(202, 76, 54);
            label2.Location = new Point(684, 325);
            label2.Name = "label2";
            label2.Size = new Size(0, 49);
            label2.TabIndex = 8;
            label2.Click += label2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(475, 325);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(169, 180);
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // Form8
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1078, 705);
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form8";
            Text = "Form8";
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
        private Label label2;
        private PictureBox pictureBox1;
    }
}