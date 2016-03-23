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
    public enum State
    {
        WaitingForFirstNumber,
        WaitingForSecondNumber,
        WaitingForResult,
        WaitingForOperation
    }
    public partial class Calculator : Form
    {
        Double resultValue = 0;
        //string state = 'init';
        String operation = "";
        bool isOperation = false;
        
        public Calculator()
        {
            InitializeComponent();
          
        }

        private void Operation_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if(resultValue != 0)
            {
                OperationResult.PerformClick();
                operation = btn.Text;
                labelCurrentOperation.Text = resultValue + " " + operation;
                isOperation = true;
            }
            else
            {
                operation = btn.Text;
                resultValue = Double.Parse(display.Text);
                labelCurrentOperation.Text = resultValue + " " + operation;
                isOperation = true;
            }
       }

        private void pad_Click(object sender, EventArgs e)
        {
            if ((display.Text == "0") || (isOperation))
            {
                display.Clear();
            }
            isOperation = false;
            Button btn = sender as Button;
            if (btn.Text == ",")
            {
                if(!display.Text.Contains(","))
                    display.Text = display.Text + btn.Text;
            }
            else
                display.Text = display.Text + btn.Text;
        }
        private void OperationResult_Click(object sender, EventArgs e)
        {
            labelCurrentOperation.Text = "";
            switch(operation)
            {
                case "+":
                    display.Text = (resultValue + Double.Parse(display.Text)).ToString();
                    break;
                case "-":
                    display.Text = (resultValue - Double.Parse(display.Text)).ToString();
                    break;
                case "/":
                    display.Text = (resultValue / Double.Parse(display.Text)).ToString();
                    break;
                case "*":
                    display.Text = (resultValue * Double.Parse(display.Text)).ToString();
                    break;
                default:
                    break;
            }
            isOperation = false;
            resultValue = Double.Parse(display.Text);
            operation = "";
        }

        private void OperationClear_Click(object sender, EventArgs e)
        {
            display.Clear();
            display.Text = "0";
            resultValue = 0;
        }    
        private void OperationClearOneDigit_Click(object sender, EventArgs e)
        {
            display.Text = "0";
        }

        private void padPower_Click(object sender, EventArgs e)
        {
            if (display.Text != "")
            {
                double x;
                x = Convert.ToDouble(display.Text) * Convert.ToDouble(display.Text);
                display.Text = Convert.ToString(x);
            }
            else
            {
                return;
            }
        }

        private void display_TextChanged(object sender, EventArgs e)
        {

        }

        private void padSqrt_Click(object sender, EventArgs e)
        {
            if (display.Text != "")
            {
                double k;
                k = Convert.ToDouble(display.Text);
                display.Text = Convert.ToString(Math.Sqrt(k));
            }
            else
            {
                return; 
            }
        }

        private void pad11_Click(object sender, EventArgs e)
        {
            double y;
            y = Convert.ToDouble(display.Text);
            display.Text = Convert.ToString(1/y);
        }

        private void padProcent_Click(object sender, EventArgs e)
        {
            double n;
            n = Convert.ToDouble(display.Text);
            display.Text = Convert.ToString(n / 100);
        }

        private void padBackspace_Click(object sender, EventArgs e)
        {
            int length = display.TextLength - 1;
            string text = display.Text;
            display.Clear();
            for (int i=0; i<length; i++)
            {
                display.Text = display.Text + text[i];
            }
        }

        
    }
}
