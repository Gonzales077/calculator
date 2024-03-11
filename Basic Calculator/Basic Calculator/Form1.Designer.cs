namespace Basic_Calculator
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Displaytext = new TextBox();
            btnC = new Button();
            button16 = new Button();
            button14 = new Button();
            button13 = new Button();
            btn4 = new Button();
            btn5 = new Button();
            btn6 = new Button();
            button5 = new Button();
            btn7 = new Button();
            btn8 = new Button();
            button9 = new Button();
            btn9 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button15 = new Button();
            btn3 = new Button();
            btn2 = new Button();
            btn1 = new Button();
            btmPlusM = new Button();
            SuspendLayout();
            // 
            // Displaytext
            // 
            Displaytext.BackColor = Color.White;
            Displaytext.Font = new Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Displaytext.Location = new Point(13, 18);
            Displaytext.Name = "Displaytext";
            Displaytext.ReadOnly = true;
            Displaytext.Size = new Size(330, 54);
            Displaytext.TabIndex = 16;
            Displaytext.TextChanged += Displaytext_TextChanged;
            // 
            // btnC
            // 
            btnC.BackColor = Color.White;
            btnC.FlatAppearance.BorderSize = 0;
            btnC.FlatStyle = FlatStyle.Flat;
            btnC.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnC.ForeColor = Color.OrangeRed;
            btnC.Location = new Point(13, 78);
            btnC.Name = "btnC";
            btnC.Size = new Size(78, 52);
            btnC.TabIndex = 0;
            btnC.Text = "C";
            btnC.UseVisualStyleBackColor = false;
            btnC.Click += button1_Click;
            // 
            // button16
            // 
            button16.BackColor = Color.White;
            button16.FlatAppearance.BorderSize = 0;
            button16.FlatStyle = FlatStyle.Flat;
            button16.Location = new Point(13, 314);
            button16.Name = "button16";
            button16.Size = new Size(78, 52);
            button16.TabIndex = 12;
            button16.Text = "0";
            button16.UseVisualStyleBackColor = false;
            button16.Click += button16_Click;
            // 
            // button14
            // 
            button14.BackColor = Color.White;
            button14.FlatAppearance.BorderSize = 0;
            button14.FlatStyle = FlatStyle.Flat;
            button14.Location = new Point(181, 314);
            button14.Name = "button14";
            button14.Size = new Size(78, 52);
            button14.TabIndex = 14;
            button14.Text = ".";
            button14.UseVisualStyleBackColor = false;
            button14.Click += button14_Click;
            // 
            // button13
            // 
            button13.BackColor = Color.White;
            button13.FlatAppearance.BorderSize = 0;
            button13.FlatStyle = FlatStyle.Flat;
            button13.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button13.ForeColor = Color.FromArgb(255, 128, 0);
            button13.Location = new Point(265, 314);
            button13.Name = "button13";
            button13.Size = new Size(78, 52);
            button13.TabIndex = 15;
            button13.Text = "=";
            button13.UseVisualStyleBackColor = false;
            button13.Click += button13_Click;
            // 
            // btn4
            // 
            btn4.BackColor = Color.White;
            btn4.FlatAppearance.BorderSize = 0;
            btn4.FlatStyle = FlatStyle.Flat;
            btn4.Location = new Point(13, 196);
            btn4.Name = "btn4";
            btn4.Size = new Size(78, 52);
            btn4.TabIndex = 4;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = false;
            btn4.Click += btn4_Click;
            // 
            // btn5
            // 
            btn5.BackColor = Color.White;
            btn5.FlatAppearance.BorderSize = 0;
            btn5.FlatStyle = FlatStyle.Flat;
            btn5.Location = new Point(97, 196);
            btn5.Name = "btn5";
            btn5.Size = new Size(78, 52);
            btn5.TabIndex = 5;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = false;
            btn5.Click += btn5_Click;
            // 
            // btn6
            // 
            btn6.BackColor = Color.White;
            btn6.FlatAppearance.BorderSize = 0;
            btn6.FlatStyle = FlatStyle.Flat;
            btn6.Location = new Point(181, 196);
            btn6.Name = "btn6";
            btn6.Size = new Size(78, 52);
            btn6.TabIndex = 6;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = false;
            btn6.Click += btn6_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.White;
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button5.ForeColor = Color.FromArgb(255, 128, 0);
            button5.Location = new Point(265, 137);
            button5.Name = "button5";
            button5.Size = new Size(78, 52);
            button5.TabIndex = 7;
            button5.Text = "x";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // btn7
            // 
            btn7.BackColor = Color.White;
            btn7.FlatAppearance.BorderSize = 0;
            btn7.FlatStyle = FlatStyle.Flat;
            btn7.Location = new Point(13, 138);
            btn7.Name = "btn7";
            btn7.Size = new Size(78, 52);
            btn7.TabIndex = 1;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = false;
            btn7.Click += btn7_Click;
            // 
            // btn8
            // 
            btn8.BackColor = Color.White;
            btn8.FlatAppearance.BorderSize = 0;
            btn8.FlatStyle = FlatStyle.Flat;
            btn8.Location = new Point(97, 138);
            btn8.Name = "btn8";
            btn8.Size = new Size(78, 52);
            btn8.TabIndex = 9;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = false;
            btn8.Click += btn8_Click;
            // 
            // button9
            // 
            button9.BackColor = Color.White;
            button9.FlatAppearance.BorderSize = 0;
            button9.FlatStyle = FlatStyle.Flat;
            button9.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button9.ForeColor = Color.FromArgb(255, 128, 0);
            button9.Location = new Point(265, 255);
            button9.Name = "button9";
            button9.Size = new Size(78, 52);
            button9.TabIndex = 11;
            button9.Text = "+";
            button9.UseVisualStyleBackColor = false;
            button9.Click += button9_Click;
            // 
            // btn9
            // 
            btn9.BackColor = Color.White;
            btn9.FlatAppearance.BorderSize = 0;
            btn9.FlatStyle = FlatStyle.Flat;
            btn9.Location = new Point(181, 138);
            btn9.Name = "btn9";
            btn9.Size = new Size(78, 52);
            btn9.TabIndex = 10;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = false;
            btn9.Click += btn9_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.White;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.OrangeRed;
            button2.Location = new Point(97, 78);
            button2.Name = "button2";
            button2.Size = new Size(78, 52);
            button2.TabIndex = 1;
            button2.Text = "⌫";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.White;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.OrangeRed;
            button3.Location = new Point(181, 78);
            button3.Name = "button3";
            button3.Size = new Size(78, 52);
            button3.TabIndex = 2;
            button3.Text = "%";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.White;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button4.ForeColor = Color.OrangeRed;
            button4.Location = new Point(265, 78);
            button4.Name = "button4";
            button4.Size = new Size(78, 52);
            button4.TabIndex = 3;
            button4.Text = "÷";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button15
            // 
            button15.BackColor = Color.White;
            button15.FlatAppearance.BorderSize = 0;
            button15.FlatStyle = FlatStyle.Flat;
            button15.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button15.ForeColor = Color.FromArgb(255, 128, 0);
            button15.Location = new Point(265, 196);
            button15.Name = "button15";
            button15.Size = new Size(78, 52);
            button15.TabIndex = 20;
            button15.Text = "-";
            button15.UseVisualStyleBackColor = false;
            button15.Click += button15_Click;
            // 
            // btn3
            // 
            btn3.BackColor = Color.White;
            btn3.FlatAppearance.BorderSize = 0;
            btn3.FlatStyle = FlatStyle.Flat;
            btn3.Location = new Point(181, 255);
            btn3.Name = "btn3";
            btn3.Size = new Size(78, 52);
            btn3.TabIndex = 19;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = false;
            btn3.Click += btn3_Click;
            // 
            // btn2
            // 
            btn2.BackColor = Color.White;
            btn2.FlatAppearance.BorderSize = 0;
            btn2.FlatStyle = FlatStyle.Flat;
            btn2.Location = new Point(97, 255);
            btn2.Name = "btn2";
            btn2.Size = new Size(78, 52);
            btn2.TabIndex = 18;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = false;
            btn2.Click += btn2_Click;
            // 
            // btn1
            // 
            btn1.BackColor = Color.White;
            btn1.FlatAppearance.BorderSize = 0;
            btn1.FlatStyle = FlatStyle.Flat;
            btn1.Location = new Point(13, 255);
            btn1.Name = "btn1";
            btn1.Size = new Size(78, 52);
            btn1.TabIndex = 17;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = false;
            btn1.Click += btn1_Click;
            // 
            // btmPlusM
            // 
            btmPlusM.BackColor = Color.White;
            btmPlusM.FlatAppearance.BorderSize = 0;
            btmPlusM.FlatStyle = FlatStyle.Flat;
            btmPlusM.Location = new Point(97, 314);
            btmPlusM.Name = "btmPlusM";
            btmPlusM.Size = new Size(78, 52);
            btmPlusM.TabIndex = 21;
            btmPlusM.Text = "±";
            btmPlusM.UseVisualStyleBackColor = false;
            btmPlusM.Click += btmPlusM_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.RosyBrown;
            ClientSize = new Size(355, 378);
            Controls.Add(btmPlusM);
            Controls.Add(button15);
            Controls.Add(btn3);
            Controls.Add(btn2);
            Controls.Add(btn1);
            Controls.Add(Displaytext);
            Controls.Add(button13);
            Controls.Add(button14);
            Controls.Add(button16);
            Controls.Add(button9);
            Controls.Add(btn9);
            Controls.Add(btn8);
            Controls.Add(btn7);
            Controls.Add(button5);
            Controls.Add(btn6);
            Controls.Add(btn5);
            Controls.Add(btn4);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(btnC);
            Name = "Form1";
            Text = "Calculator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnC;
        private TextBox Displaytext;
        private Button button16;
        private Button button14;
        private Button button13;
        private Button btn4;
        private Button btn5;
        private Button btn6;
        private Button button5;
        private Button btn7;
        private Button btn8;
        private Button button9;
        private Button btn9;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button15;
        private Button btn3;
        private Button btn2;
        private Button btn1;
        private Button btmPlusM;
    }
}
