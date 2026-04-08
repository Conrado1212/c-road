using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Croad
{
    class simple
    {
         public void Simple() { 
            Console.WriteLine("Give number 1: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Give number 1: ");
            double b = Convert.ToDouble(Console.ReadLine());
            double sum = a + b;
            double sub = a - b;
            double multi = a * b;
            double divide = a / b;
            Console.WriteLine("Your sum: " + sum);
            Console.WriteLine("Your sub: " + sub);
            Console.WriteLine("Your multi: " + multi);
            Console.WriteLine("Your divide: " + divide);
        }
        public void OddEvent()
        {
            Console.WriteLine("Give number a: ");

            double number = Convert.ToDouble(Console.ReadLine());

            if (number % 2 == 0)
            {
                Console.WriteLine("the given number is even");
            }
            else
            {
                Console.WriteLine("the given numbver is odd ");
            }
        }

        public void Faren()
        {
            Console.WriteLine("Give number temp: ");

            double temp = Convert.ToDouble(Console.ReadLine());

            double faren = temp * 1.8 + 32;
            Console.WriteLine(faren);
        }

    }
}
