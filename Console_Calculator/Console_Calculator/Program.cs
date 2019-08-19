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
            Console.WriteLine("This is console Calculator. Want to count something?\n\n");
            GetValues getValues = new GetValues();
            char continueOrNot = 'y';
            do
            {
                Console.Write("Type the first number: ");                
                double numberOne = getValues.GetValuesToCount();

                Console.Write("Choose what you want to do. Type some of this: '+'; '-'; '*'; '/':  ");
                char mathOperator;
                bool propperMathOperator = char.TryParse(Console.ReadLine(), out mathOperator);
                while (!propperMathOperator)
                {
                    Console.Write("Try again. You should type only the math operator: ");
                    propperMathOperator = char.TryParse(Console.ReadLine(), out mathOperator);
                }

                Console.Write("Type the second number: ");
                double numberTwo = getValues.GetValuesToCount();                

                Math_Operations.Operations(numberOne, mathOperator, numberTwo);

                Console.WriteLine("Would you like to count something else? Type 'y' if YES, and 'n' if NO: ");
                bool propperDesition = char.TryParse(Console.ReadLine(), out continueOrNot);
                while (!propperDesition)
                {
                    Console.WriteLine("Try again, you should type 'y' (continue) or 'n' (break)");
                    propperDesition = char.TryParse(Console.ReadLine(), out continueOrNot);
                }

            } while (continueOrNot == 'y');       
        }
    }
}
