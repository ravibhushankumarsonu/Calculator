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
    public partial class Calculator : Form
    {
        Double value = 0;
        string operation = "";
        bool operation_pressed = false;
        public Calculator()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            if ((result.Text == "0")||(operation_pressed))
            {
                result.Clear();
                operation_pressed = false;
            }
            Button bt = (Button)sender;
            result.Text = result.Text + bt.Text;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            result.Text="0";
        }

        private void operator_click(object sender, EventArgs e)
        {
            Button bt = (Button)sender;
            operation = bt.Text;
            value = Double.Parse(result.Text);
            operation_pressed = true;
            equation.Text = result.Text + " " + operation;
        }

        private void button20_Click(object sender, EventArgs e)
        {
            equation.Text = "";
            switch (operation)
            {
                case "+":
                    result.Text = (value + Double.Parse(result.Text)).ToString();
                    break;
                case "-":
                    result.Text = (value - Double.Parse(result.Text)).ToString();
                    break;
                case "*":
                    result.Text = (value * Double.Parse(result.Text)).ToString();
                    break;
                case "/":
                    result.Text = (value / Double.Parse(result.Text)).ToString();
                    break;
                default:
                    break;
            }
            operation_pressed = false;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
