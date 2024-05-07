using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate_Calculator
{
    internal class CalculatorEventArgs : EventArgs
    {
        public double Operand1 { get; set; }
        public double Operand2 { get; set; }
        public double Result { get; }


        public CalculatorEventArgs(double operand1, double operand2, double result)
        { 
            Operand1 = operand1;
            Operand2 = operand2;    
            Result = result;
        }
    }
}
