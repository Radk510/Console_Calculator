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
            //Program
            Console.WriteLine("This is console Calculator. Want to count something?\n\n");
            GetValues getValues = new GetValues();
            char continueOrNot = 'y';
            do
            {
                Console.Write("Type the first number: ");                
                double numberOne = getValues.GetValuesToCount(); // get first number

                char mathOperator = getValues.GetMathOperator(); // choose the operator      

                Console.Write("Type the second number: ");
                double numberTwo = getValues.GetValuesToCount(); // get second number          

                Math_Operations.Operations(numberOne, mathOperator, numberTwo); // solve the math operstion

                continueOrNot = getValues.ContinueQuit(); // decide what to do: continue or quit

            } while (continueOrNot == 'y');       
        }
    }
}
