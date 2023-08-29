using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_basics
{
    class Assignment1
    {
        static void Main(string[] args)
        {
            int firstNumber, secondNumber;

            PrintMyName();

            firstNumber = Convert.ToInt32(ReadNumberFromConsole());
            secondNumber = Convert.ToInt32(ReadNumberFromConsole());
            SumOfTwoNumbers(firstNumber, secondNumber);
            DivisionOfTwoNumbers(firstNumber, secondNumber);    

            ResultEx4a();
            ResultEx4b();
            ResultEx4c();
            ResultEx4d();
        }

        public static void PrintMyName() {
            //1. Printati "Hello" in consola, iar pe rand nou, printati numele vostru.
            Console.WriteLine("Ex.1:");
            Console.WriteLine("Hello \nLidia\n");
        }

        public static int ReadNumberFromConsole()
        {
            Console.Write("Enter first number: ");
            string val1 = Console.ReadLine();
            int consoleNumber = Convert.ToInt32(val1);
            return consoleNumber;
        }

        public static void SumOfTwoNumbers(int firstNumber, int secondNumber)
        {
            //2. Printati rezultatul sumei a doua numere(orice numere)
            int sum = firstNumber + secondNumber;
            Console.WriteLine("Ex.2. Sum of " + firstNumber + "+" + secondNumber + " is: " + sum);
        }

        public static void DivisionOfTwoNumbers(int firstNumber, int secondNumber)
        {
            //3. Printati rezultatul impartirii a doua numere. Atentie, daca numarul nu este intreg, sa afiseze si valorile dupa virgula.
            float rez = (float)firstNumber / (float)secondNumber;
            Console.WriteLine("Ex.3. Divizion of " + firstNumber + "+" + secondNumber + " is: " + rez);
        }

        public static void ResultEx4a() {
            float rez = -5 + 8 * 6;
            Console.WriteLine("Ex.4.a. Result of  -5 + 8 * 6 is: " + rez);
        }

        public static void ResultEx4b()
        {
            float rez = (55 + 9) % 9;
            Console.WriteLine("Ex.4.b. Result of  (55+9) % 9 is: " + rez);
        }

        public static void ResultEx4c()
        {
            float rez = 20 + -3 * 5 / 8;
            Console.WriteLine("Ex.4.c. Result of  20 + -3*5 / 8 is: " + rez);
        }

        public static void ResultEx4d()
        {
            float rez = 5 + 15 / 3 * 2 - 8 % 3;
            Console.WriteLine("Ex.4.d. Result of  5 + 15 / 3 * 2 - 8 % 3 is: " + rez);
        }
    }
}
