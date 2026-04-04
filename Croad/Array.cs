using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Croad
{
    class Array
    {
       public void array()
        {

            //String[] cars = { "BMW", "AUDI", "VW" };

            String[] cars = new string[3];
           cars[0] = "Tesla";
           cars[1] = "BMW";
           cars[2] = "VW";

            foreach(var car in cars)
            {
                Console.WriteLine(car);
            }
            
            Console.ReadKey();
        }
    }
    
}
 