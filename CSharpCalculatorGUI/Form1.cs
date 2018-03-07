using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpCalculatorGUI
{
    public partial class form1 : Form
    {

        Double result = 0;
        String operationPerformed = "";
        bool isDone = false;

        public form1()
        {
            InitializeComponent();
        }

        private void btnClickNum(object sender, EventArgs e)
        {

            if ((tbResult.Text == "0") || isDone)
                tbResult.Clear();

            isDone = false;
            Button button = (Button) sender;

            if(button.Text == ".")
            {
                if(!tbResult.Text.Contains("."))
                {
                    tbResult.Text = tbResult.Text + button.Text;
                }
            } else 
            tbResult.Text = tbResult.Text + button.Text;
            
        }

        private void btnOperator(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if (result != 0)
            {
                btnEqual.PerformClick();
                operationPerformed = button.Text;
                lblCurrentOp.Text = result.ToString() + " " + operationPerformed;
                isDone = true;
            }
            else
            {

                operationPerformed = button.Text;
                result = Double.Parse(tbResult.Text);
                lblCurrentOp.Text = result.ToString() + " " + operationPerformed;
                isDone = true;
            }
        }

        private void clickCE(object sender, EventArgs e)
        {
            tbResult.Text = "0";
        }

        private void clickClear(object sender, EventArgs e)
        {
            tbResult.Text = "0";
            result = 0;
        }

        private void clickEqual(object sender, EventArgs e)
        {
            switch(operationPerformed)
            {
                case "+":
                    tbResult.Text = (result + Double.Parse(tbResult.Text)).ToString();
                    break;
                case "-":
                    tbResult.Text = (result - Double.Parse(tbResult.Text)).ToString();
                    break;
                case "*":
                    tbResult.Text = (result * Double.Parse(tbResult.Text)).ToString();
                    break;
                case "/":
                    tbResult.Text = (result / Double.Parse(tbResult.Text)).ToString();
                    break;
                default:
                    break;

            }
            result = Double.Parse(tbResult.Text);
            lblCurrentOp.Text = "";
        }
    }
}
