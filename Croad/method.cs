using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Croad
{
    class method
    {
        public void methodd(String name, int age)
        {
            Console.WriteLine("Happy birthday" + name + " " + age);
            Console.WriteLine("Happy birthday");
            Console.WriteLine("Happy birthday");
            Console.WriteLine("Happy birthday");
            Console.WriteLine("Happy birthday");
            Console.WriteLine("Happy birthday");
            Console.ReadKey();
        }

        public double Multiply(double a, double b)
        {
            return a * b;
        }
        public double Multiply(double a, double b, double c)
        {
            return a * b * c;
        }
        public double CheckOut(params double[] prices)
        {
            double total = 0;
            foreach(double price in prices)
            {
                total += price;
            }
            return total;
        }
    }
}
