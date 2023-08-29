using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_basics
{
    internal class Assignment2
    {
        public static void SumOfTwoNumbers(int firstNumber, int secondNumber)
        {
            int sum = firstNumber + secondNumber;
            Console.WriteLine("Sum of " + firstNumber + "+" + secondNumber + " is: " + sum);
        }

        public static void SubstractionOfTwoNumbers(int firstNumber, int secondNumber)
        {
            int sub = firstNumber - secondNumber;
            Console.WriteLine("Substraction of " + firstNumber + "-" + secondNumber + " is: " + sub);
        }

        public static void MultiplicationOfTwoNumbers(int firstNumber, int secondNumber)
        {
            float rez = (float)firstNumber * (float)secondNumber;
            Console.WriteLine("Multiplication of " + firstNumber + "*" + secondNumber + " is: " + rez);
        }
        public static void DivisionOfTwoNumbers(int firstNumber, int secondNumber)
        {
            float rez = (float)firstNumber / (float)secondNumber;
            Console.WriteLine("Divizion of " + firstNumber + "/" + secondNumber + " is: " + rez);
        }
    }
}
