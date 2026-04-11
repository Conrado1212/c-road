using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Croad
{
    class exc
    {
       public void exceptionTest()
        {

            double x;
            double y;
            double result;


            try
            {

           
            Console.WriteLine("Enter number1: ");

            x = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter number2: ");

            y = Convert.ToDouble(Console.ReadLine());

            result = x / y;

            Console.WriteLine("Result " + result);
            }
            catch (FormatException e)
            {
                Console.WriteLine("Only numbers ");
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("Not divide by 0 ");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            finally{
                Console.WriteLine("Thanks for visiting: ");
            }
            Console.ReadKey();
        }
    }
}
