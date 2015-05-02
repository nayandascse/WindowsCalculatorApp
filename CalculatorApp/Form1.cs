using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace CalculatorApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public int clear = 0;
        public decimal result, mResult = 0;
        public string op;

        int Clear(int cl)
        {
            switch (cl)
            {
                case 1:
                {
                    resultLabel.Text = "";
            
                }break;
                case 2:
                {
                    resultLabel.Text = "";
                    controlLabel.Text = "";
                    op = "";
                    
                }break;
                case 3:
                {
                    resultLabel.Text = "";
                    controlLabel.Text = controlLabel.Text.Remove(controlLabel.Text.IndexOf('r'));
                    
                }break;
                case 4:
                {
                    resultLabel.Text = "";
                    controlLabel.Text = controlLabel.Text.Remove(controlLabel.Text.IndexOf('s'));
                    
                }break;
                case 5:
                {
                    resultLabel.Text = "";
                    controlLabel.Text = controlLabel.Text.Remove(controlLabel.Text.LastIndexOf(' ') +1);
                }break;

            }
            return 0;
        }

        decimal eval(string op)
        {
            clear = 1;
            try
            {
                switch (op)
                {
                    case "+":
                        result = result + Convert.ToDecimal(resultLabel.Text);
                        break;
                    case "-":
                        result = result - Convert.ToDecimal(resultLabel.Text);
                        break;
                    case "*":
                        result = result * Convert.ToDecimal(resultLabel.Text);
                        break;
                    case "/":
                        result = result / Convert.ToDecimal(resultLabel.Text);
                        break;
                        case "mod":
                        result = result % Convert.ToDecimal(resultLabel.Text);
                        break;
                    default:
                        result = Convert.ToDecimal(resultLabel.Text);
                        break;
                }
            }
            catch (System.OverflowException)
            {
                controlLabel.Text = "";
                controlLabel.Text = "Overflow";
                clear = 2;
                SystemSounds.Asterisk.Play();
            }
            catch (System.DivideByZeroException)
            {
                controlLabel.Text = "";
                controlLabel.Text = "Cannot divided by zero";
                clear = 2;
                SystemSounds.Asterisk.Play();
            }
            return result;
        }


        private void zeroButton_Click(object sender, EventArgs e)
        {
            clear = Clear(clear);
            if (resultLabel.Text.Length < 28)
            {
                resultLabel.Text = resultLabel.Text + "0";
            }
            else
            {
                SystemSounds.Beep.Play();
            }
        }

        private void oneButton_Click(object sender, EventArgs e)
        {
            clear = Clear(clear);
            if (resultLabel.Text.Length < 28)
            {
                resultLabel.Text = resultLabel.Text + "1";
            }
            else
            {
                SystemSounds.Beep.Play();
            }
        }

        private void twoButton_Click(object sender, EventArgs e)
        {
            clear = Clear(clear);
            if (resultLabel.Text.Length < 28)
            {
                resultLabel.Text = resultLabel.Text + "2";
            }
            else
            {
                SystemSounds.Beep.Play();
            }
        }

        private void threeButton_Click(object sender, EventArgs e)
        {
            clear = Clear(clear);
            if (resultLabel.Text.Length < 28)
            {
                resultLabel.Text = resultLabel.Text + "3";
            }
            else
            {
                SystemSounds.Beep.Play();
            }
        }

        private void fourButton_Click(object sender, EventArgs e)
        {
            clear = Clear(clear);
            if (resultLabel.Text.Length < 28)
            {
                resultLabel.Text = resultLabel.Text + "4";
            }
            else
            {
                SystemSounds.Beep.Play();
            }
        }

        private void fiveButton_Click(object sender, EventArgs e)
        {
            clear = Clear(clear);
            if (resultLabel.Text.Length < 28)
            {
                resultLabel.Text = resultLabel.Text + "5";
            }
            else
            {
                SystemSounds.Beep.Play();
            }
        }

        private void sixButton_Click(object sender, EventArgs e)
        {
            clear = Clear(clear);
            if (resultLabel.Text.Length < 28)
            {
                resultLabel.Text = resultLabel.Text + "6";
            }
            else
            {
                SystemSounds.Beep.Play();
            }
        }

        private void sevenButton_Click(object sender, EventArgs e)
        {
            clear = Clear(clear);
            if (resultLabel.Text.Length < 28)
            {
                resultLabel.Text = resultLabel.Text + "7";
            }
            else
            {
                SystemSounds.Beep.Play();
            }
        }

        private void eightButton_Click(object sender, EventArgs e)
        {
            clear = Clear(clear);
            if (resultLabel.Text.Length < 28)
            {
                resultLabel.Text = resultLabel.Text + "8";
            }
            else
            {
                SystemSounds.Beep.Play();
            }
        }

        private void nineButton_Click(object sender, EventArgs e)
        {
            clear = Clear(clear);
            if (resultLabel.Text.Length < 28)
            {
                resultLabel.Text = resultLabel.Text + "9";
            }
            else
            {
                SystemSounds.Beep.Play();
            }
        }

        private void pointButton_Click(object sender, EventArgs e)
        {
            if (resultLabel.Text.Contains("."))
            {
                SystemSounds.Beep.Play();
            }
            else
            {
                resultLabel.Text = resultLabel.Text + ".";
            }
        }

        private void plusButton_Click(object sender, EventArgs e)
        {
            if (clear == 3 || clear == 4 || clear == 5)
            {
                controlLabel.Text = controlLabel.Text + "+";
            }
            else
            {
                controlLabel.Text = controlLabel.Text + resultLabel.Text + "+";
                resultLabel.Text = eval(op).ToString();
                op = "+";
            }
        }

        private void minusButton_Click(object sender, EventArgs e)
        {
            if (clear == 3 || clear == 4 || clear == 5)
            {
                controlLabel.Text = controlLabel.Text + "-";
            }
            else
            {
                controlLabel.Text = controlLabel.Text + resultLabel.Text + "-";
                resultLabel.Text = eval(op).ToString();
                op = "-";
            }
        }

        private void multiplyButton_Click(object sender, EventArgs e)
        {
            if (clear == 3 || clear == 4 || clear == 5)
            {
                controlLabel.Text = controlLabel.Text + "*";
            }
            else
            {
                controlLabel.Text = controlLabel.Text + resultLabel.Text + "*";
                resultLabel.Text = eval(op).ToString();
                op = "*";
            }
        }
        private void divideButton_Click(object sender, EventArgs e)
        {
            if (clear == 3 || clear == 4 || clear == 5)
            {
                controlLabel.Text = controlLabel.Text + "/";
            }
            else
            {
                controlLabel.Text = controlLabel.Text + resultLabel.Text + "/";
                resultLabel.Text = eval(op).ToString();
                op = "/";
            }
        }

        private void modButton_Click(object sender, EventArgs e)
        {
            if (clear == 3 || clear == 4 || clear == 5)
            {
                controlLabel.Text = controlLabel.Text + "Mod";
            }
            else
            {
                controlLabel.Text = controlLabel.Text + resultLabel.Text + "Mod";
                resultLabel.Text = eval(op).ToString();
                op = "Mod";
            }
        }

        private void reciprocButton_Click(object sender, EventArgs e)
        {
            if (controlLabel.Text.Contains("reciproc"))
            {
                controlLabel.Text = controlLabel.Text.Insert(controlLabel.Text.IndexOf('r'),"reciproc(");
                controlLabel.Text = controlLabel.Text.Insert(controlLabel.Text.IndexOf(')'),")");
            }
            else
            {
                controlLabel.Text = controlLabel.Text + "reciproc(" + resultLabel.Text + ")";
                resultLabel.Text = (1 / Convert.ToDecimal(resultLabel.Text)).ToString();
                clear = 3; 
            }
        }

        private void rootButton_Click(object sender, EventArgs e)
        {
            if (controlLabel.Text.Contains("sqrt"))
            {
                controlLabel.Text = controlLabel.Text.Insert(controlLabel.Text.IndexOf('s'), "sqrt(");
                controlLabel.Text = controlLabel.Text.Insert(controlLabel.Text.IndexOf(')'), ")");
            }
            else
            {
                controlLabel.Text = controlLabel.Text + "sqrt(" + resultLabel.Text + ")";
                resultLabel.Text = Math.Sqrt(Convert.ToDouble(resultLabel.Text)).ToString();
                clear = 4 ;
            }
        }

        private void persentButton_Click(object sender, EventArgs e)
        {
            resultLabel.Text = (result * Convert.ToDecimal(resultLabel.Text)/100).ToString();
            controlLabel.Text = controlLabel.Text + resultLabel.Text;
            clear = 5;

        }

        private void plusMinusbutton_Click(object sender, EventArgs e)
        {
            if (resultLabel.Text.Contains('-'))
            {
                resultLabel.Text = resultLabel.Text.Remove(resultLabel.Text.IndexOf('-'), 1);
            }
            else
            {
                resultLabel.Text = "-" + resultLabel.Text;
            }
        }

        private void equalButton_Click(object sender, EventArgs e)
        {
            if (clear !=3 && clear!=4 && clear!=5)
            {
                controlLabel.Text = controlLabel.Text + resultLabel.Text;
                resultLabel.Text = eval(op).ToString();
                clear = 2;
            }
        }

        private void ceButton_Click(object sender, EventArgs e)
        {
            Clear(2);
            clear = 1;
            resultLabel.Text = "0";
            result = 0;
        }

        private void cButton_Click(object sender, EventArgs e)
        {
            Clear(1);
            clear = 1;
            resultLabel.Text = "0";
        }

        private void msButton_Click(object sender, EventArgs e)
        {
            mResult = Convert.ToDecimal(resultLabel.Text);
            clear = 1;
            mLabel.Text = "M";
        }

        private void mrButton_Click(object sender, EventArgs e)
        {
            resultLabel.Text = mResult.ToString();
            clear = 1;
        }

        private void mPlusbutton_Click(object sender, EventArgs e)
        {
            mResult = mResult + Convert.ToDecimal(resultLabel.Text);
            clear = 1;
        }

        private void mMinusbutton_Click(object sender, EventArgs e)
        {
            mResult = mResult - Convert.ToDecimal(resultLabel.Text);
            clear = 1;
        }

        private void mcButton_Click(object sender, EventArgs e)
        {
            mResult = 0;
            clear = 1;
            mLabel.Text = "";
        }

        private void resultLabel_TextChanged(object sender, EventArgs e)
        {
            if (resultLabel.Text.Length <= 20)
            {
                Font font = new Font("Consolas", 14, FontStyle.Regular);
                resultLabel.Font = font;
            }
            else if (resultLabel.Text.Length > 20 && resultLabel.Text.Length <= 26)
            {
                Font font = new Font("Consolas", 11, FontStyle.Regular);
                resultLabel.Font = font;
            }
            else
            {
                Font font = new Font("Consolas", 9, FontStyle.Regular);
                resultLabel.Font = font;
            }
        }

    }
}
