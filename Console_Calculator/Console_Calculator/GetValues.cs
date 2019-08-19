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
                Console.Write("Try again. You should type only the number: ");
                propperNumber = double.TryParse(Console.ReadLine(), out number);
            }
            return number;
        }

    }
}
