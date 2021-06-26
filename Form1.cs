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
        String operation = "";
        Double firstnum, secondnum;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button_click(object sender, EventArgs e)
        {
            if (textBox_results.Text == "0")
                textBox_results.Clear();

            Button numbers = (Button)sender;
            textBox_results.Text = textBox_results.Text + numbers.Text;
        }

        private void clear_entry_Click(object sender, EventArgs e)
        {
            textBox_results.Text = "0";
        }

        private void Operation_click(object sender, EventArgs e)
        {

        }

        private void clear_Click(object sender, EventArgs e)
        {
            textBox_results.Text = "0";
            String f, s;

            s = Convert.ToString(firstnum);
            f = Convert.ToString(secondnum);

            s = "";
            f = "";

        }
    }
}
