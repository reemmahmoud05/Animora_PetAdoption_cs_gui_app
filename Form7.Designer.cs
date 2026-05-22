namespace PetsimulatorGUI
{
    partial class Form7
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form7));
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            pictureBox1 = new PictureBox();
            notifyIcon1 = new NotifyIcon(components);
            notifyIcon2 = new NotifyIcon(components);
            notifyIcon3 = new NotifyIcon(components);
            notifyIcon4 = new NotifyIcon(components);
            notifyIcon5 = new NotifyIcon(components);
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            button7 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.Font = new Font("Jaro 48pt", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.FromArgb(99, 139, 89);
            button1.Location = new Point(783, 34);
            button1.Name = "button1";
            button1.Size = new Size(130, 36);
            button1.TabIndex = 1;
            button1.Text = "RESTART";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Jaro 48pt", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.FromArgb(99, 139, 89);
            button2.Location = new Point(12, 34);
            button2.Name = "button2";
            button2.Size = new Size(140, 36);
            button2.TabIndex = 2;
            button2.Text = "CHANGE PET";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Jaro 48pt", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.FromArgb(99, 139, 89);
            button3.Location = new Point(675, 525);
            button3.Name = "button3";
            button3.Size = new Size(130, 36);
            button3.TabIndex = 3;
            button3.Text = "MOOD";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Font = new Font("Jaro 48pt", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button4.ForeColor = Color.FromArgb(99, 139, 89);
            button4.Location = new Point(485, 525);
            button4.Name = "button4";
            button4.Size = new Size(130, 36);
            button4.TabIndex = 4;
            button4.Text = "BARK";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Font = new Font("Jaro 48pt", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button5.ForeColor = Color.FromArgb(99, 139, 89);
            button5.Location = new Point(296, 525);
            button5.Name = "button5";
            button5.Size = new Size(130, 36);
            button5.TabIndex = 5;
            button5.Text = "PLAY";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Font = new Font("Jaro 48pt", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button6.ForeColor = Color.FromArgb(99, 139, 89);
            button6.Location = new Point(124, 525);
            button6.Name = "button6";
            button6.Size = new Size(130, 36);
            button6.TabIndex = 6;
            button6.Text = "EAT";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(432, 333);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(148, 150);
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click_1;
            // 
            // notifyIcon1
            // 
            notifyIcon1.Text = "notifyIcon1";
            notifyIcon1.Visible = true;
            notifyIcon1.Click += pictureBox1_Click_1;
            // 
            // notifyIcon2
            // 
            notifyIcon2.Text = "notifyIcon2";
            notifyIcon2.Visible = true;
            notifyIcon2.Click += button6_Click;
            // 
            // notifyIcon3
            // 
            notifyIcon3.Text = "notifyIcon3";
            notifyIcon3.Visible = true;
            notifyIcon3.Click += button5_Click;
            // 
            // notifyIcon4
            // 
            notifyIcon4.Text = "notifyIcon4";
            notifyIcon4.Visible = true;
            notifyIcon4.Click += button4_Click;
            // 
            // notifyIcon5
            // 
            notifyIcon5.Text = "notifyIcon5";
            notifyIcon5.Visible = true;
            notifyIcon5.Click += button3_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(170, 490);
            label1.Name = "label1";
            label1.Size = new Size(0, 20);
            label1.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(339, 490);
            label2.Name = "label2";
            label2.Size = new Size(0, 20);
            label2.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(530, 490);
            label3.Name = "label3";
            label3.Size = new Size(0, 20);
            label3.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(724, 490);
            label4.Name = "label4";
            label4.Size = new Size(0, 20);
            label4.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.FromArgb(237, 153, 80);
            label5.Font = new Font("Jaro 24pt", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(202, 76, 54);
            label5.Location = new Point(97, 210);
            label5.Name = "label5";
            label5.Size = new Size(0, 49);
            label5.TabIndex = 12;
            label5.Click += label5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.FromArgb(237, 153, 80);
            label6.Font = new Font("Jaro", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(202, 76, 54);
            label6.Location = new Point(562, 342);
            label6.Name = "label6";
            label6.Size = new Size(0, 37);
            label6.TabIndex = 13;
            // 
            // button7
            // 
            button7.Font = new Font("Jaro", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button7.ForeColor = Color.FromArgb(99, 139, 89);
            button7.Location = new Point(783, 76);
            button7.Name = "button7";
            button7.Size = new Size(130, 38);
            button7.TabIndex = 14;
            button7.Text = "END GAME";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // Form7
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(952, 594);
            Controls.Add(button7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form7";
            Text = "Form7";
            Load += Form7_Load;
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
        private PictureBox pictureBox1;
        private NotifyIcon notifyIcon1;
        private NotifyIcon notifyIcon2;
        private NotifyIcon notifyIcon3;
        private NotifyIcon notifyIcon4;
        private NotifyIcon notifyIcon5;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button button7;
    }
}