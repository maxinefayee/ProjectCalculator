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
    public partial class Form1 : Form
    {
        calculations method = new calculations();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Button_click(object sender, EventArgs e)
        {
            if ((textBox_results.Text == "0") || (method.operationDone))
                textBox_results.Clear();
            method.operationDone = false;
            Button numbers = (Button)sender;
            if (numbers.Text == ".")
            {
                if (!textBox_results.Text.Contains("."))
                    textBox_results.Text = textBox_results.Text + numbers.Text;

            }
            else
                textBox_results.Text = textBox_results.Text + numbers.Text;
        }


        private void Operation_click(object sender, EventArgs e)
        {
            Button numbers = (Button)sender;
            method.operation = numbers.Text;
            method.firstnum = Double.Parse(textBox_results.Text);
            method.secondnum = Double.Parse(textBox_results.Text);
            OperationLabel.Text = method.firstnum + "" + method.operation;
            method.operationDone = true;


        }

        private void Equals_Click(object sender, EventArgs e)
        {

            method.Value = textBox_results.Text;
            method.results();
            textBox_results.Text = method.Value;
            method.operationDone = false;

        }

        private void Plus_minus_Click(object sender, EventArgs e)
        {
            if (textBox_results.Text.Contains("-"))
            {
                textBox_results.Text = textBox_results.Text.Remove(0, 1);
            }   
            else
            {
                textBox_results.Text = "-" + textBox_results.Text;
            }
        }

        private void Square_root_Click(object sender, EventArgs e)
        {
            textBox_results.Text = Convert.ToString(Math.Sqrt(Convert.ToDouble(textBox_results.Text)));
            OperationLabel.Text = method.firstnum + "" + method.operation;
        }

        private void Squared_Click(object sender, EventArgs e)
        {
            textBox_results.Text = Convert.ToString((Convert.ToDecimal(textBox_results.Text) * (Convert.ToDecimal(textBox_results.Text))));
            OperationLabel.Text = method.firstnum + "" + method.operation;
        }

        private void Reciprocal_Click(object sender, EventArgs e)
        {
            textBox_results.Text = Convert.ToString(1.0 / (Convert.ToDouble(textBox_results.Text)));
            OperationLabel.Text = method.firstnum + "" + method.operation;
        }

        private void Backspace_Click(object sender, EventArgs e)
        {
            if (textBox_results.Text.Length > 0)
            {
                textBox_results.Text = textBox_results.Text.Remove(textBox_results.Text.Length - 1, 1);
            }
            if (textBox_results.Text == "")
            {
                textBox_results.Text = "0";
            }
        }

        private void Clear_entry_Click(object sender, EventArgs e)
        {

            textBox_results.Text = "0";
            String f, s;

            s = Convert.ToString(method.secondnum);
            f = Convert.ToString(method.firstnum);

            s = "";
            f = "";

        }
        private void Clear_Click(object sender, EventArgs e)
        {
            textBox_results.Text = "0";

        }

       
        
    }
}
