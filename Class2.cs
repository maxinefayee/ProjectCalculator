using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class calculations
    {
        public String operation = "";
        public Double firstnum, secondnum;
        public bool operationDone = false;
        public String Value = Double.Parse(firstnum, secondnum);

        public void results()
        {
            secondnum = double.Parse(textBox_results.Text);
            switch (operation)
            {
                case "+":
                    textBox_results.Text = Convert.ToString(firstnum + secondnum);
                    break;

                case "-":
                    textBox_results.Text = Convert.ToString(firstnum - secondnum);
                    break;

                case "*":
                    textBox_results.Text = Convert.ToString(firstnum * secondnum);
                    break;

                case "/":
                    textBox_results.Text = Convert.ToString(firstnum / secondnum);
                    break;

                default:
                    break;

                    operationDone = true;
                    
            }
        }
    }
}
