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

            foreach(String car in cars)
            {
                Console.WriteLine(car);
            }


            String[] BMW = { "f22", "f15", "f11" };
            String[] VW = { "golf", "tiguan", "tuareg" };
            String[] Audi = { "a3", "a4", "a5" };

            String[,] parking = { { "f22", "f15", "f11" },
                { "golf", "tiguan", "tuareg" },
                { "a3", "a4", "a5" } };

            parking[0, 2] = "f12";
            parking[2, 0] = "a7";

            foreach(String car in parking)
            {
                Console.WriteLine(car);
            }
            for(int i = 0; i < parking.GetLength(0); i++)
            {
                for(int j = 0; j<parking.GetLength(1); j++)
                {
                    Console.WriteLine(parking[1,j] +" car");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
    
}
 