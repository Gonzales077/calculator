using System;

namespace Basic_Calculator
{
    public partial class Form1 : Form
    {
        double firstnum, secondnum;
        string op;
        public Form1()
        {
            InitializeComponent();
        }

        private void Displaytext_TextChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Displaytext.Text = "0";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Displaytext.Text.Length > 0)
            {
                Displaytext.Text = Displaytext.Text.Remove(Displaytext.Text.Length - 1, 1);
            }

            if (Displaytext.Text == "")
            {
                Displaytext.Text = "0";
            }
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (Displaytext.Text == "0")
            {
                Displaytext.Text = "1";
            }
            else
            {
                Displaytext.Text = Displaytext.Text + "1";
            }
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (Displaytext.Text == "0")
            {
                Displaytext.Text = "2";
            }
            else
            {
                Displaytext.Text = Displaytext.Text + "2";
            }
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (Displaytext.Text == "0")
            {
                Displaytext.Text = "3";
            }
            else
            {
                Displaytext.Text = Displaytext.Text + "3";
            }
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (Displaytext.Text == "0")
            {
                Displaytext.Text = "4";
            }
            else
            {
                Displaytext.Text = Displaytext.Text + "4";
            }
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (Displaytext.Text == "0")
            {
                Displaytext.Text = "5";
            }
            else
            {
                Displaytext.Text = Displaytext.Text + "5";
            }
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (Displaytext.Text == "0")
            {
                Displaytext.Text = "6";
            }
            else
            {
                Displaytext.Text = Displaytext.Text + "6";
            }
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (Displaytext.Text == "0")
            {
                Displaytext.Text = "7";
            }
            else
            {
                Displaytext.Text = Displaytext.Text + "7";
            }
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (Displaytext.Text == "0")
            {
                Displaytext.Text = "8";
            }
            else
            {
                Displaytext.Text = Displaytext.Text + "8";
            }
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (Displaytext.Text == "0")
            {
                Displaytext.Text = "9";
            }
            else
            {
                Displaytext.Text = Displaytext.Text + "9";
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            firstnum = double.Parse(Displaytext.Text);
            op = "+";
            Displaytext.Text = "";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (Displaytext.Text == "0")
            {
                Displaytext.Text = "0";
            }
            else
            {
                Displaytext.Text = Displaytext.Text + "0";
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            firstnum = double.Parse(Displaytext.Text);
            op = "-";
            Displaytext.Text = "";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            firstnum = double.Parse(Displaytext.Text);
            op = "x";
            Displaytext.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            firstnum = double.Parse(Displaytext.Text);
            op = "÷";
            Displaytext.Text = "";
        }

        private void btmPlusM_Click(object sender, EventArgs e)
        {
            double q = Convert.ToDouble(Displaytext.Text);
            Displaytext.Text = Convert.ToString(-1 * q);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            secondnum = double.Parse(Displaytext.Text);
            switch (op)
            {
                case "+":
                    Displaytext.Text = (firstnum + secondnum).ToString();
                    break;
                case "-":
                    Displaytext.Text = (firstnum - secondnum).ToString();
                    break;
                case "x":
                    Displaytext.Text = (firstnum * secondnum).ToString();
                    break;
                case "÷":
                    Displaytext.Text = (firstnum / secondnum).ToString();
                    break;

                default:
                    break;
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (Displaytext.Text == "0")
            {
                Displaytext.Text = ".";
            }
            else
            {
                Displaytext.Text = Displaytext.Text + ".";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double percent = double.Parse(Displaytext.Text) / 100;
            Displaytext.Text = percent.ToString();
        }
    }
}
