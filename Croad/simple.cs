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
        public void Old()
        {
            Console.WriteLine("Give me your name: ");
            String name = Console.ReadLine();
            Console.WriteLine("Give me your age: ");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Hi " + name + ", you are " + age + " years old");
        }

        static double Higher(params double[] c)
        {
            double max = c[0];
            for (int i = 0; i < c.Length; i++)
            {
                if (c[i] > max)
                {
                    max = c[i];
                }
            }
            return max;
        }
        static void Muilti()
        {
            for (int i = 1; i <= 10; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    Console.Write(i * j + " ");
                }
                Console.WriteLine();
            }

        }
        static void RandomNumber()
        {
            Random random = new Random();
            int guess = 0;
            int number = random.Next(1, 101);
            while (guess != number)
            {
                Console.WriteLine("Guess a number");
                guess = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Guess: " + guess);
                if (guess > number)
                {
                    Console.WriteLine(guess + " is too high!");
                }
                else if (guess < number)
                {
                    Console.WriteLine(guess + " is too low!");
                }
            }
            Console.WriteLine("Number: " + number);

        }
        static int sum(int n)
        {
            int sum = 0;
            for (int i = 1; i <= n; i++)
            {
                sum += i;
            }
            return sum;
        }
        static double Average(params int[] c)
        {
            double avg = 0;
            double sum = 0;
            for (int i = 0; i < c.Length; i++)
            {
                sum += c[i];
            }
            return avg = sum / c.Length;
        }
    }
}    
