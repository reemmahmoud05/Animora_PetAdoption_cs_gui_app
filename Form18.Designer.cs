namespace PetsimulatorGUI
{
    partial class Form18
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
            label5 = new Label();
            label3 = new Label();
            label4 = new Label();
            textBox1 = new TextBox();
            numericUpDown1 = new NumericUpDown();
            button2 = new Button();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Jaro 24pt", 28.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(99, 139, 89);
            label5.Location = new Point(49, 45);
            label5.Name = "label5";
            label5.Size = new Size(673, 63);
            label5.TabIndex = 10;
            label5.Text = "CHOOSE YOUR PET'S NAME AND AGE!";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Jaro", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(99, 139, 89);
            label3.Location = new Point(181, 187);
            label3.Name = "label3";
            label3.Size = new Size(159, 40);
            label3.TabIndex = 11;
            label3.Text = "Pet's Name:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Jaro", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(99, 139, 89);
            label4.Location = new Point(203, 257);
            label4.Name = "label4";
            label4.Size = new Size(137, 40);
            label4.TabIndex = 12;
            label4.Text = "Pet's Age:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(364, 198);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(160, 27);
            textBox1.TabIndex = 13;
            textBox1.Text = "Mochi";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(364, 269);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(160, 27);
            numericUpDown1.TabIndex = 14;
            numericUpDown1.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // button2
            // 
            button2.Font = new Font("Jaro", 12F);
            button2.ForeColor = Color.FromArgb(99, 139, 89);
            button2.Location = new Point(694, 409);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 15;
            button2.Text = "NEXT";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Jaro", 12F);
            button1.ForeColor = Color.FromArgb(99, 139, 89);
            button1.Location = new Point(12, 409);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 16;
            button1.Text = "BACK";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form18
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(176, 219, 156);
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(button2);
            Controls.Add(numericUpDown1);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label5);
            Name = "Form18";
            Text = "Form18";
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label5;
        private Label label3;
        private Label label4;
        private TextBox textBox1;
        private NumericUpDown numericUpDown1;
        private Button button2;
        private Button button1;
    }
}