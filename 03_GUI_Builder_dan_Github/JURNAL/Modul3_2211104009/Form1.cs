using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Modul3_2211104009
{
    public partial class Form1: Form
    {
        private string input = "";
        private int firstNumber = 0;
        private int secondNumber = 0;
        private bool isSecondNumber = false;

        public Form1()
        {
            InitializeComponent();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {


        }

        private void button4_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            input += button.Text;

            if (isSecondNumber)
            {
                label1.Text = firstNumber + " + " + input;
            }
            else
            {
                label1.Text = input;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (isSecondNumber && !string.IsNullOrEmpty(input))
            {
                if (int.TryParse(input, out secondNumber))
                {
                    int result = firstNumber + secondNumber;
                    label1.Text = firstNumber + " + " + secondNumber + " = " + result;
                    input = result.ToString();
                    isSecondNumber = false;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(input))
            {
                if (int.TryParse(input, out firstNumber))
                {
                    isSecondNumber = true;
                    input = "";
                    label1.Text = firstNumber + " + ";
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            input += button.Text;

            if (isSecondNumber)
            {
                label1.Text = firstNumber + " + " + input;
            }
            else
            {
                label1.Text = input;
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            input += button.Text;

            if (isSecondNumber)
            {
                label1.Text = firstNumber + " + " + input;
            }
            else
            {
                label1.Text = input;
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            input += button.Text;

            if (isSecondNumber)
            {
                label1.Text = firstNumber + " + " + input;
            }
            else
            {
                label1.Text = input;
            }
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            input += button.Text;

            if (isSecondNumber)
            {
                label1.Text = firstNumber + " + " + input;
            }
            else
            {
                label1.Text = input;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            input += button.Text;

            if (isSecondNumber)
            {
                label1.Text = firstNumber + " + " + input;
            }
            else
            {
                label1.Text = input;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            input += button.Text;

            if (isSecondNumber)
            {
                label1.Text = firstNumber + " + " + input;
            }
            else
            {
                label1.Text = input;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            input += button.Text;

            if (isSecondNumber)
            {
                label1.Text = firstNumber + " + " + input;
            }
            else
            {
                label1.Text = input;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            input += button.Text;

            if (isSecondNumber)
            {
                label1.Text = firstNumber + " + " + input;
            }
            else
            {
                label1.Text = input;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            input += button.Text;

            if (isSecondNumber)
            {
                label1.Text = firstNumber + " + " + input;
            }
            else
            {
                label1.Text = input;
            }
        }
    }
}
