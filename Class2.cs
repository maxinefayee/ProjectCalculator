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
        public String Value = 0;

        public void results()
        {
            secondnum = double.Parse(Value);
            switch (operation)
            {
                case "+":
                    Value = Convert.ToString(firstnum + secondnum);
                    break;

                case "-":
                    Value = Convert.ToString(firstnum - secondnum);
                    break;

                case "*":
                    Value = Convert.ToString(firstnum * secondnum);
                    break;

                case "/":
                    Value = Convert.ToString(firstnum / secondnum);
                    break;

                default:
                    break;

                    operationDone = true;
              
            }
        }
    }
}
