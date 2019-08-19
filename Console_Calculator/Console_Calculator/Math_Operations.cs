using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Calculator
{
    public static class Math_Operations
    {       
        public static void Operations(double numberOne, char mathOperator, double numberTwo)
        {
            switch (mathOperator)
            {
                case '+':
                    Console.BackgroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine("The answer is: " + (numberOne + numberTwo));
                    Console.BackgroundColor = ConsoleColor.Black;
                    break;
                case '-':
                    Console.BackgroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine("The answer is: " + (numberOne - numberTwo));
                    Console.BackgroundColor = ConsoleColor.Black;
                    break;
                case '*':
                    Console.BackgroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine("The answer is: " + (numberOne * numberTwo));
                    Console.BackgroundColor = ConsoleColor.Black;
                    break;
                case '/':
                    Console.BackgroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine("The answer is: " + (numberOne / numberTwo));
                    Console.BackgroundColor = ConsoleColor.Black;
                    break;
                default:
                    Console.BackgroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine("Type the propper sign to make the calculation");
                    Console.BackgroundColor = ConsoleColor.Black;
                    break;
            }
        }



    }
}
