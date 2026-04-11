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
        static void Word()
        {
            Console.WriteLine("Write the sentance: ");
            String words = Console.ReadLine();
            string[] splitWords = words.Split(' ');
            String max = splitWords[0];
            for (int i = 0; i < splitWords.Length; i++)
            {
                if (splitWords[i].Length > max.Length)
                {
                    max = splitWords[i];
                }
            }
            Console.WriteLine(max);
        }
        static double[] Reverse(params double[] w)
        {
            double[] c = new double[w.Length];
            for (int i = 0; i < w.Length; i++)
            {
                c[i] = w[w.Length - 1 - i];
            }
            return c;
        }
        static void sam()
        {
            Console.WriteLine("Write the sentance: ");
            int sum = 0;
            String words = Console.ReadLine();
            char[] charArr = words.ToCharArray();
            foreach (char h in charArr)
            {
                if (h == 'a' || h == 'ą' || h == 'e' || h == 'ę' || h == 'i' || h == 'o' || h == 'u' || h == 'ó' || h == 'y')
                {
                    sum++;
                }
            }
            Console.WriteLine(sum);
        }

        static void calc()
        {
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

        }
        static List<(string user, string pass)> users = new List<(string, string)>();

        static void sign()
        {
            Console.WriteLine("Enter your userName: ");
            String name = Console.ReadLine();
            Console.WriteLine("Enter your password: ");
            String pass = Console.ReadLine();

            users.Add((name.ToLower(), pass.ToLower()));

            Console.WriteLine("Data saved");
        }


        static void login()
        {
            Console.Write("Enter your userName: ");
            string name = Console.ReadLine();

            Console.Write("Enter your password: ");
            string pass = Console.ReadLine();

            foreach (var u in users)
            {
                if (u.user.ToLower() == name.ToLower() && u.pass.ToLower() == pass.ToLower())
                {
                    Console.WriteLine("Logged in!");
                    return;
                }
            }

            Console.WriteLine("Wrong data");

        }
        static void rockScissorsGame()
        {
            String[] options = { "ROCK", "SCISSORS", "PAPER" };
            Random random = new Random();
            String computer = options[random.Next(options.Length)];
            String player = "";
            while (player != "ROCK" && player != "PAPER" && player != "SCISSORS")
            {
                Console.WriteLine("Enter your choice: ROCK Scissors PAPER");
                player = Console.ReadLine().ToUpper();
            }
            Console.WriteLine("Player choose: " + player);
            Console.WriteLine("Computer choose: " + computer);
            if (player == computer)
            {
                Console.WriteLine("Its a draw");
            }
            else if ((player == "ROCK" && computer == "SCISSORS") ||
               (player == "SCISSORS" && computer == "PAPER") ||
               (player == "PAPER" && computer == "ROCK")
           )
            {
                Console.WriteLine("Player won");
            }
            else
            {
                Console.WriteLine("Computer won");
            }

        }
    }
}    
