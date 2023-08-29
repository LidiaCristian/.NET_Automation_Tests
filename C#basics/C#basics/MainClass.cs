using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_basics
{
    internal class MainClass
    {
        int firstNumber, secondNumber, thirdNumber;
        static void Main(string[] args)
        {

            MainClass ass1 = new MainClass();

            ass1.assignment1();
            ass1.assignment2();
            
        }

        public void assignment1()
        {           
            Assignment1.PrintMyName();
            firstNumber = Convert.ToInt32(Assignment1.ReadNumberFromConsole());
            secondNumber = Convert.ToInt32(Assignment1.ReadNumberFromConsole());
            Assignment1.SumOfTwoNumbers(firstNumber, secondNumber);
            Assignment1.DivisionOfTwoNumbers(firstNumber, secondNumber);
            Assignment1.ResultEx4a();
            Assignment1.ResultEx4b();
            Assignment1.ResultEx4c();
            Assignment1.ResultEx4d();
        }

        public void assignment2()
        {
            Console.WriteLine("Rezultatul adunarii este: " + Assignment2.SumOfTwoNumbers(firstNumber, secondNumber));
            Console.WriteLine("Rezultatul scaderii este: " + Assignment2.SubstractionOfTwoNumbers(firstNumber, secondNumber));
            Console.WriteLine("Rezultatul inmultirii este: " + Assignment2.MultiplicationOfTwoNumbers(firstNumber, secondNumber));
            Console.WriteLine("Rezultatul impartirii este: " + Assignment2.DivisionOfTwoNumbers(firstNumber, secondNumber));
            Assignment2.WriteCSharpOnCommandLine();
            thirdNumber = Convert.ToInt32(Assignment1.ReadNumberFromConsole());
            Console.WriteLine("Rezultatul mediei aritmetice este: " + Assignment2.arithmeticMean(firstNumber, secondNumber, thirdNumber));
            Console.WriteLine("Restul impartirii numerelor " + firstNumber + ", " + secondNumber + " este: " + Assignment2.remainderOfTheNumberDivizion(firstNumber, secondNumber));
            Console.Write("Introduceti temperatura in F:");
            double f = Convert.ToDouble(Assignment1.ReadNumberFromConsole());
            Console.WriteLine("Rezultatul schimbarii tempraturii din F in C este: " + Assignment2.convertoTemperatureFromFToC(f));
        }
    }
}
