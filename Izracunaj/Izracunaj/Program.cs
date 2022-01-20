using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Izracunaj
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length != 3)
                throw new ArgumentException(
                    "Please enter command line arguments in the following form: firstNumber operator secondNumber");

            string operand = args[1];
            double firstNumber = 0.0, secondNumber = 0.0;

            try
            {
                firstNumber = double.Parse(args[0]);
                secondNumber = double.Parse(args[2]);
            }
            catch (FormatException  e)
            {
                Console.WriteLine($"Catching the exception -> {e}");
            }
            
            switch (operand)
            {
                case "+":
                    Console.WriteLine(firstNumber + secondNumber);
                    break;
                case "-":
                    Console.WriteLine(firstNumber - secondNumber);
                    break;
                case "*":
                    Console.WriteLine(firstNumber * secondNumber);
                    break;
                case "/":
                    Console.WriteLine(firstNumber / secondNumber);
                    break;
            }
        }
    }
}
