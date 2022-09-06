using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator_form
{
    public partial class Form1 : Form
    {
        double kq = 0;
        double x1 = 0.0;
        double x2 = 0.0;
        string s;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            kq1.Text = kq2.Text + "% =";
            x1 = double.Parse(kq2.Text);
            kq2.Text = (x1/100).ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (kq1.Text.Contains("="))
                kq1.Clear();
            else if (kq2.TextLength > 1)
                kq2.Text = kq2.Text.Remove(kq2.TextLength - 1, 1);
            else
                kq2.Text = "0";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (kq1.Text.Contains("=") || kq2.Text == "0")
            {
                kq1.Clear();
                kq2.Clear();
            }
            kq2.Text = kq2.Text + "9";
        }

        private void button19_Click(object sender, EventArgs e)
        {
            if (kq1.Text.Contains("=") || kq2.Text == "0")
            {
                kq1.Clear();
                kq2.Clear();
            }
            kq2.Text = kq2.Text + "6";
        }

        private void zero_Click(object sender, EventArgs e)
        {
            if (kq1.Text.Contains("=") || kq2.Text == "0")
            {
                kq1.Clear();
                kq2.Clear();
            }
            else
            kq2.Text +=  "0";
        }

        private void one_Click(object sender, EventArgs e)
        {
            if (kq1.Text.Contains("=") || kq2.Text == "0")
            {
                kq1.Clear();
                kq2.Clear();
            }
            kq2.Text = kq2.Text + "1";
        }

        private void two_Click(object sender, EventArgs e)
        {
            if (kq1.Text.Contains("=") || kq2.Text == "0")
            {
                kq1.Clear();
                kq2.Clear();
            }
            kq2.Text = kq2.Text + "2";
        }

        private void three_Click(object sender, EventArgs e)
        {
            if (kq1.Text.Contains("=") || kq2.Text == "0")
            {
                kq1.Clear();
                kq2.Clear();
            }
            kq2.Text = kq2.Text + "3";
        }

        private void four_Click(object sender, EventArgs e)
        {
            if (kq1.Text.Contains("=") || kq2.Text == "0")
            {
                kq1.Clear();
                kq2.Clear();
            }
            kq2.Text = kq2.Text + "4";
        }

        private void five_Click(object sender, EventArgs e)
        {
            if (kq1.Text.Contains("=") || kq2.Text == "0")
            {
                kq1.Clear();
                kq2.Clear();
            }
            kq2.Text = kq2.Text + "5";
        }

        private void seven_Click(object sender, EventArgs e)
        {

            if (kq1.Text.Contains("=") || kq2.Text == "0")
            {
                kq1.Clear();
                kq2.Clear();
            }
            kq2.Text = kq2.Text + "7";
        }

        private void eight_Click(object sender, EventArgs e)
        {
            if (kq1.Text.Contains("=") || kq2.Text == "0")
            {
                kq1.Clear();
                kq2.Clear();
            }
            kq2.Text = kq2.Text + "8";
        }

        private void dot_Click(object sender, EventArgs e)
        {
            if (!kq2.Text.Contains(".")) //neu kq2 khong ton tai .
            kq2.Text = kq2.Text + ".";
        }

        private void PoNe_Click(object sender, EventArgs e)
        {
            if (kq1.Text.Contains("=") || kq2.Text == "0")
            {
                kq1.Clear();
            }
                if (kq2.Text.Contains("-"))
                {
                    kq2.Text = kq2.Text.Trim('-');
                }
                else
                {
                    kq2.Text = '-' + kq2.Text;
                }
 
        }

        private void ce_Click(object sender, EventArgs e)
        {
            if (kq1.Text.Contains('%') || kq1.Text.Contains("1/") || kq1.Text.Contains('√'))
                kq1.Clear();
            kq2.Text = "0";
        }

        private void clear_Click(object sender, EventArgs e)
        {
            kq2.Text = "0";
            kq1.Clear();
            kq = 0;
        }

        private void add_Click(object sender, EventArgs e)
        {
            x1 = double.Parse(kq2.Text);
            kq1.Text = kq2.Text + " + ";
            kq2.Clear();
        }

        private void sub_Click(object sender, EventArgs e)
        {
            x1 = double.Parse(kq2.Text);
            kq1.Text = kq2.Text + " - ";
            kq2.Clear();
        }

        private void multi_Click(object sender, EventArgs e)
        {
            x1 = double.Parse(kq2.Text);
            kq1.Text = kq2.Text + " × ";
            kq2.Clear();
        }

        private void div_Click(object sender, EventArgs e)
        {
            x1 = double.Parse(kq2.Text);
            kq1.Text = kq2.Text + " ÷ ";
            kq2.Clear();
        }

        private void equal_Click(object sender, EventArgs e)
        {
            
            if (kq1.Text.Contains("+"))
               {
                if (kq1.Text.Contains("="))
                {
                    s = kq1.Text.Substring(kq1.Text.IndexOf('+') + 2, kq1.Text.IndexOf('=') - kq1.Text.IndexOf('+') - 3);
                    x2 = double.Parse(s);
                    kq1.Text = kq2.Text + " + " + s + " = ";
                    kq2.Text = (double.Parse(kq2.Text) + x2).ToString();
                }
                else
                {
                    kq1.Text = kq1.Text + kq2.Text + " = ";
                    kq2.Text = (x1 + double.Parse(kq2.Text)).ToString();
                }
            }

            else if (kq1.Text.Contains("-"))
                {
                if (kq1.Text.Contains("="))
                    {
                    s = kq1.Text.Substring(kq1.Text.IndexOf('-') + 2, kq1.Text.IndexOf('=') - kq1.Text.IndexOf('-') - 3);
                    x2 = double.Parse(s);
                    kq1.Text = kq2.Text + " - " + s + " = ";
                    kq2.Text = (double.Parse(kq2.Text) - x2).ToString(); 
                }
                else
                {
                    kq1.Text = kq1.Text + kq2.Text + " = ";
                    kq2.Text = (x1 - double.Parse(kq2.Text)).ToString();
                }    
                
            }
            else if (kq1.Text.Contains("×"))
                {
                if (kq1.Text.Contains("="))
                {
                    s = kq1.Text.Substring(kq1.Text.IndexOf('×') + 2, kq1.Text.IndexOf('=') - kq1.Text.IndexOf('×') - 3);
                    x2 = double.Parse(s);
                    kq1.Text = kq2.Text + " × " + s + " = ";
                    kq2.Text = (double.Parse(kq2.Text) * x2).ToString();
                }
                else
                {
                    kq1.Text = kq1.Text + kq2.Text + " = ";
                    kq2.Text = (x1 * double.Parse(kq2.Text)).ToString();
                }
            }

            else if (kq1.Text.Contains("÷"))
            {
                if (kq1.Text.Contains("="))
                {
                    s = kq1.Text.Substring(kq1.Text.IndexOf('÷') + 2, kq1.Text.IndexOf('=') - kq1.Text.IndexOf('÷') - 3);
                    x2 = double.Parse(s);
                    kq1.Text = kq2.Text + " ÷ " + s + " = ";
                    kq2.Text = (double.Parse(kq2.Text) / x2).ToString();
                }
                else
                {
                    kq1.Text = kq1.Text + kq2.Text + " = ";
                    kq2.Text = (x1 / double.Parse(kq2.Text)).ToString();
                }
            }
            else
            {
                kq1.Text = kq2.Text + " = "; 
            } 
                


        }

        private void sqrt_Click(object sender, EventArgs e)
        {
            kq1.Text = "√(" + kq2.Text + ") = ";
            x1 = double.Parse(kq2.Text);
            kq2.Text = (Math.Sqrt(x1)).ToString();
        }

        private void square_Click(object sender, EventArgs e)
        {
            kq1.Text = kq2.Text + "^2 =";
            x1 = double.Parse(kq2.Text);
            kq2.Text = (x1 * x1).ToString();
        }

        private void inversion_Click(object sender, EventArgs e)
        {
            kq1.Text = "1/" + kq2.Text + " = ";
            x1 = double.Parse(kq2.Text);
            kq2.Text = (1 / x1).ToString();
        }
    }
}
