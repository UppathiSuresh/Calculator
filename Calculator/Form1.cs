using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class CalculatorApplication : Form
    {
        double firstNumber;
        String operation;
        public CalculatorApplication()
        {
            InitializeComponent();
        }
        public void one()
        {
            if (CtlTxtDispaly.Text == "0" && CtlTxtDispaly.Text != null)
            {
                CtlTxtDispaly.Text = "1";
            }
            else
            {
                CtlTxtDispaly.Text = CtlTxtDispaly.Text + "1";
            }
        }
        public void two()
        {
            if(CtlTxtDispaly.Text=="0" && CtlTxtDispaly.Text != null)
            {
                CtlTxtDispaly.Text = "2";
            }
            else
            {
                CtlTxtDispaly.Text = CtlTxtDispaly.Text + "2";
            }
        }
        public void three()
        {
            if (CtlTxtDispaly.Text == "0" && CtlTxtDispaly.Text != null)
            {
                CtlTxtDispaly.Text = "3";
            }
            else
            {
                CtlTxtDispaly.Text = CtlTxtDispaly.Text + "3";
            }
        }
        public void four()
        {
            if (CtlTxtDispaly.Text == "0" && CtlTxtDispaly.Text != null)
            {
                CtlTxtDispaly.Text = "4";
            }
            else
            {
                CtlTxtDispaly.Text = CtlTxtDispaly.Text + "4";
            }
        }
        public void five()
        {
            if (CtlTxtDispaly.Text == "0" && CtlTxtDispaly.Text != null)
            {
                CtlTxtDispaly.Text = "5";
            }
            else
            {
                CtlTxtDispaly.Text = CtlTxtDispaly.Text + "5";
            }
        }
        public void six()
        {
            if (CtlTxtDispaly.Text == "0" && CtlTxtDispaly.Text != null)
            {
                CtlTxtDispaly.Text = "6";
            }
            else
            {
                CtlTxtDispaly.Text = CtlTxtDispaly.Text + "6";
            }
        }
        public void seven()
        {
            if(CtlTxtDispaly.Text=="0" && CtlTxtDispaly.Text != null)
            {
                CtlTxtDispaly.Text = "7";
            }
            else
            {
                CtlTxtDispaly.Text += "7";
            }
        }
        public void eight()
        {
            if(CtlTxtDispaly.Text=="0" && CtlTxtDispaly.Text != null)
            {
                CtlTxtDispaly.Text = "8";
            }
            else
            {
                CtlTxtDispaly.Text += "8";
            }
        }
        public void nine()
        {
            if (CtlTxtDispaly.Text == "0" && CtlTxtDispaly.Text != null)
            {
                CtlTxtDispaly.Text = "9";
            }
            else
            {
                CtlTxtDispaly.Text += "9";
            }
        }
        public void equals()
        {
            double secondNumber;
            double result;
            secondNumber = Convert.ToDouble(CtlTxtDispaly.Text);
            if (operation == "+")
            {
                result = (firstNumber + secondNumber);
                //CtlTxtDispaly.Text = Convert.ToString(result);
                //MessageBox.Show("sum is : "+result.ToString());
                ctlRichTxtHistory.AppendText("sum : "+result.ToString());
                ctlRichTxtHistory.AppendText("\n");
                firstNumber = result;
            }
            if (operation == "-")
            {
                result = (firstNumber - secondNumber);
                //CtlTxtDispaly.Text = Convert.ToString(result);
                ctlRichTxtHistory.AppendText("sub : " + result.ToString());
                ctlRichTxtHistory.AppendText("\n");
                firstNumber = result;
            }
            if (operation == "*")
            {
                result = firstNumber * secondNumber;
                //CtlTxtDispaly.Text = Convert.ToString(result);
                ctlRichTxtHistory.AppendText("mul : " + result.ToString());
                ctlRichTxtHistory.AppendText("\n");
                firstNumber = result;

            }
            if (operation == "/")
            {
                try
                {
                    if (secondNumber != 0)
                    {
                        result = firstNumber / secondNumber;
                        //CtlTxtDispaly.Text = Convert.ToString(result);
                        ctlRichTxtHistory.AppendText("div : " + result.ToString());
                        ctlRichTxtHistory.AppendText("\n");
                        firstNumber = result;
                    }
                    else
                    {
                        throw new ArithmeticException();
                    }
                }
                catch (ArithmeticException ex)
                {
                    MessageBox.Show("Arthamatic Exceptions" + ex.Message);

                }

            }
        }
        public void zero()
        {
            CtlTxtDispaly.Text += "0";
        }
        private void CtlBtn1_Click(object sender, EventArgs e)
        {           
            one();
        }
        private void CtlBtn2_Click(object sender, EventArgs e)
        {
            two();
        }

        private void CtlBtn3_Click(object sender, EventArgs e)
        {
            three();
        }

        private void CtlBtn4_Click(object sender, EventArgs e)
        {
            four();
        }

        private void CtlBtn5_Click(object sender, EventArgs e)
        {
            five();
        }

        private void CtlBtn6_Click(object sender, EventArgs e)
        {
            six();
        }

        private void CtlBtn7_Click(object sender, EventArgs e)
        {
            seven();
        }

        private void CtlBtn8_Click(object sender, EventArgs e)
        {
            eight();
        }

        private void CtlBtn9_Click(object sender, EventArgs e)
        {
            nine();
        }

        private void CtlBtn0_Click(object sender, EventArgs e)
        {
            zero();
        }

        private void CtlBtnAdd_Click(object sender, EventArgs e)
        {
            firstNumber = Convert.ToDouble(CtlTxtDispaly.Text);
            CtlTxtDispaly.Text = "0";
            operation = "+";
        }

        private void CtlBtnSub_Click(object sender, EventArgs e)
        {
            firstNumber = Convert.ToDouble(CtlTxtDispaly.Text);
            CtlTxtDispaly.Text = "0";
            operation = "-";
        }

        private void CtlBtnMul_Click(object sender, EventArgs e)
        {
            firstNumber = Convert.ToDouble(CtlTxtDispaly.Text);
            CtlTxtDispaly.Text = "0";
            operation = "*";
        }

        private void CtlBtnDiv_Click(object sender, EventArgs e)
        {
            firstNumber = Convert.ToDouble(CtlTxtDispaly.Text);
            CtlTxtDispaly.Text = "0";
            operation = "/";
        }

        private void CtlBtnCLR_Click(object sender, EventArgs e)
        {
            CtlTxtDispaly.Text = "0";
        }

        private void CtlBtnEqul_Click(object sender, EventArgs e)
        {
            equals();
        }
    }
}
