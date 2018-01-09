using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        Double resultValue = 0;
        String operationPerformed = "";
        bool isOperationPerformed = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void button_click(object sender, EventArgs e)
        {
            if ((tbResult.Text == "0") || (isOperationPerformed))
            {
                tbResult.Clear();
            }

            isOperationPerformed = false;
            Button button = (Button)sender;
            if (button.Text == ".")
            {
                if (!tbResult.Text.Contains("."))
                {
                    tbResult.Text = tbResult.Text + button.Text;
                }
            }
            else
                tbResult.Text = tbResult.Text + button.Text;
        }

        private void operator_click_event(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if (resultValue != 0)
            {
                bEqual.PerformClick();
                operationPerformed = button.Text;
                // resultValue = Double.Parse(tbResult.Text, CultureInfo.InvariantCulture);
                labelCurrentOperation.Text = resultValue + " " + operationPerformed;
                isOperationPerformed = true;
            }
            else
            {
                operationPerformed = button.Text;
                resultValue = Double.Parse(tbResult.Text, CultureInfo.InvariantCulture);
                labelCurrentOperation.Text = resultValue + " " + operationPerformed;
                isOperationPerformed = true;
            }
        }

        private void bCe_Click(object sender, EventArgs e)
        {
            tbResult.Text = "0";
        }

        private void bC_Click(object sender, EventArgs e)
        {
            tbResult.Text = "0";
            resultValue = 0;
        }

        private void bEqual_Click(object sender, EventArgs e)
        {
            switch (operationPerformed)
            {
                case "+":
                    tbResult.Text = (resultValue + Double.Parse(tbResult.Text, CultureInfo.InvariantCulture)).ToString();
                    break;

                case "-":
                    tbResult.Text = (resultValue - Double.Parse(tbResult.Text, CultureInfo.InvariantCulture)).ToString();
                    break;

                case "*":
                    tbResult.Text = (resultValue * Double.Parse(tbResult.Text, CultureInfo.InvariantCulture)).ToString();
                    break;

                case "/":
                    tbResult.Text = (resultValue / Double.Parse(tbResult.Text, CultureInfo.InvariantCulture)).ToString();
                    break;
                default:
                    break;
            }
            resultValue = Double.Parse(tbResult.Text, CultureInfo.InvariantCulture);
            labelCurrentOperation.Text = "";
        }
    }
}
