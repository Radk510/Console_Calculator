using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Calculator
{
    class GetValues
    {       
        public double GetValuesToCount()
        {
            double number = 0;
            bool propperNumber = double.TryParse(Console.ReadLine(), out number); ;
            while (!propperNumber)
            {
                Console.BackgroundColor = ConsoleColor.DarkRed;
                Console.Write("Try again. You should type only the number: ");
                Console.BackgroundColor = ConsoleColor.Black;
                propperNumber = double.TryParse(Console.ReadLine(), out number);
            }
            return number;
        }

        public char GetMathOperator()
        {
            Console.Write("Choose what you want to do. Type some of this: '+'; '-'; '*'; '/':  ");
            char mathOperator;
            bool propperMathOperator = char.TryParse(Console.ReadLine(), out mathOperator);
            while (!propperMathOperator)
            {
                Console.BackgroundColor = ConsoleColor.DarkRed;
                Console.Write("Try again. You should type only the math operator: ");
                Console.BackgroundColor = ConsoleColor.Black;
                propperMathOperator = char.TryParse(Console.ReadLine(), out mathOperator);
            }
            return mathOperator;
        }

        public char ContinueQuit()
        {
            char continueOrNot = 'y';
            Console.WriteLine("Would you like to count something else? Type 'y' if YES, and 'n' if NO: ");
            bool propperDesition = char.TryParse(Console.ReadLine(), out continueOrNot);
            while (!propperDesition)
            {
                Console.BackgroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Try again, you should type 'y' (continue) or 'n' (break)");
                Console.BackgroundColor = ConsoleColor.Black;
                propperDesition = char.TryParse(Console.ReadLine(), out continueOrNot);
            }            
            return continueOrNot;
        }

    }
}
