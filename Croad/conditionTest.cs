using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Croad
{
    class conditionTest
    {
        public void Condition()
        {
            double temp = 20;
            String message;

          message = (temp >= 15)? "Ita hot" :  "Ita cold";


         
            Console.WriteLine(message);


            String firstName = "tttt";
            String lastName = "ttasastt";
            int age = 22;

        
            Console.WriteLine($"Hello {firstName} {lastName}");
            Console.WriteLine($"Your age is  {age} ");
            Console.ReadKey();
        }
    }
}
