using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            char continueOrNot = 'y';
            do
            {
                Console.WriteLine("This is console Calculator. Want to count something?\n\n");
            
                Console.Write("Type the first number: ");
                double numberOne = 0;
                bool propperNumberOne = double.TryParse(Console.ReadLine(), out numberOne); ;
                while (!propperNumberOne)
                {
                    Console.Write("Try again. You should type only the number: ");
                    propperNumberOne = double.TryParse(Console.ReadLine(), out numberOne);
                    //Console.Clear();
                }

                Console.Write("Choose what you want to do. Type some of this: '+'; '-'; '*'; '/':  ");
                char mathOperator;
                bool propperMathOperator = char.TryParse(Console.ReadLine(), out mathOperator);
                while (!propperMathOperator)
                {
                    Console.Write("Try again. You should type only the math operator: ");
                    propperMathOperator = char.TryParse(Console.ReadLine(), out mathOperator);
                }

                Console.Write("Type the second number: ");
                double numberTwo = 0;
                bool propperNumberTwo = double.TryParse(Console.ReadLine(), out numberTwo);
                while (!propperNumberTwo)
                {
                    Console.Write("Try again. You should type only the number: ");
                    propperNumberTwo = double.TryParse(Console.ReadLine(), out numberTwo);
                }

                Math_Operations.Operations(numberOne, mathOperator, numberTwo);

                Console.WriteLine("Would you like to count something else? Type 'y' if YES, and 'n' if NO: ");
                bool propperDesition = char.TryParse(Console.ReadLine(), out continueOrNot);
                while (!propperDesition)
                {
                    Console.WriteLine("Try again, you should type 'y' (continue) or 'n' (break)");
                    propperDesition = char.TryParse(Console.ReadLine(), out continueOrNot);
                }

            } while (continueOrNot == 'y');


            //Console.ReadLine();
        }
    }
}
