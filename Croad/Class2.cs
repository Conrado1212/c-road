using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Croad
{
    class Class2
    {
        public void Calc()
        {
            //bool exit = false;
            do
            {


                double num1 = 0;
                double num2 = 0;
                double result = 0;
                Console.WriteLine("-------------------");
                Console.WriteLine("Caluclator Program:");
                Console.WriteLine("-------------------");
                Console.Write("Enter number1: ");

                num1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Enter number2: ");

                num2 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Enter an option: ");
                Console.WriteLine("\t+ : Add");
                Console.WriteLine("\t- : Substract");
                Console.WriteLine("\t* : Multiply");
                Console.WriteLine("\t/ : Divide");



                switch (Console.ReadLine())
                {
                    case "+":
                        result = num1 + num2;
                        Console.WriteLine($"Your result: {num1} + {num2} = {result}");
                        break;
                    case "-":
                        result = num1 - num2;
                        Console.WriteLine($"Your result: {num1} - {num2} = {result}");
                        break;
                    case "*":
                        result = num1 * num2;
                        Console.WriteLine($"Your result: {num1} * {num2} = {result}");
                        break;
                    case "/":
                        result = num1 / num2;
                        Console.WriteLine($"Your result: {num1} / {num2} = {result}");
                        break;
                    default:
                        Console.WriteLine("That was not a valid char:");
                        break;
                }
                Console.WriteLine("Would you lie to continue ? (Y/N)");
                
                

            } while (Console.ReadLine().ToUpper() == "Y");

            Console.WriteLine("Thanks for your calcution");
            Console.ReadKey();
        }
      
    }
}
