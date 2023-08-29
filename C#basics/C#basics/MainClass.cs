using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_basics
{
    internal class MainClass
    {
        static void Main(string[] args)
        {
            int firstNumber, secondNumber;

            Assignment1.PrintMyName();
            firstNumber = Convert.ToInt32(Assignment1.ReadNumberFromConsole());
            secondNumber = Convert.ToInt32(Assignment1.ReadNumberFromConsole());
            Assignment1.SumOfTwoNumbers(firstNumber, secondNumber);
            Assignment1.DivisionOfTwoNumbers(firstNumber, secondNumber);
            Assignment1.ResultEx4a();
            Assignment1.ResultEx4b();
            Assignment1.ResultEx4c();
            Assignment1.ResultEx4d();

            Assignment2.SumOfTwoNumbers(firstNumber, secondNumber);
            Assignment2.SubstractionOfTwoNumbers(firstNumber, secondNumber); 
            Assignment2.MultiplicationOfTwoNumbers(firstNumber, secondNumber);
            Assignment2.DivisionOfTwoNumbers(firstNumber, secondNumber);
        }
    }
}
