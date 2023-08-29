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

        public static void WriteCSharpOnCommandLine(){
            Console.WriteLine("   C C C           /            /\n" +
                              "C             ----/------------/----\n" +
                              "C                /            /\n" +
                              "C               /            /\n" +
                              "C          ----/------------/----\n" +
                              "   C C C      /            /\n");
        }

        public static float arithmeticMean(int num1, int num2, int num3)
        {
            float arithmeticMean = (float)((num1 + num2 + num3) / 3);
            return arithmeticMean;
        }

        public static int remainderOfTheNumberDivizion(int num1, int num2)
        {
            int divisionReminder = num1%num2;
            return divisionReminder;
        }

        public static double convertoTemperatureFromFToC(double f)
        {
            double convertoTemperatureToC = ((f - 32)*5)/9;
            return convertoTemperatureToC;
        }
    }
}
