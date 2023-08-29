using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_basics
{
    internal class Assignment2
    {
        public static int SumOfTwoNumbers(int firstNumber, int secondNumber)
        {
            int sum = firstNumber + secondNumber;

            return sum;
        }

        public static int SubstractionOfTwoNumbers(int firstNumber, int secondNumber)
        {
            int sub = firstNumber - secondNumber;
            return sub;
        }

        public static int MultiplicationOfTwoNumbers(int firstNumber, int secondNumber)
        {
            int rez = firstNumber * secondNumber;
            return rez;  
        }
        public static float DivisionOfTwoNumbers(int firstNumber, int secondNumber)
        {
            float rez = (float)firstNumber / (float)secondNumber;
            return rez;
        }
    }
}
