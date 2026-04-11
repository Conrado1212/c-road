using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Croad
{
    class Program
    {
        static void Main(string[] args)
        {



            exc exc = new exc();
            exc.exceptionTest();

            double x, y, result;
            Console.WriteLine("Enter in number 1: ");

            x = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter in number 1: ");

           y = Convert.ToDouble(Console.ReadLine());

            String name = "KonraD";
            int age = 28;

            method method = new method();

          double test =   method.CheckOut(3.99, 5.57, 15);
            Console.WriteLine(test);
            method.methodd(name,age);

             result =  method.Multiply(x,y);

            Array array = new Array();

            array.array();

            Class2 class2 = new Class2();

            class2.Calc();

            Class1 class1 = new Class1();

            class1.Game();
            //   Console.WriteLine("adadadadadad world");
            //   Console.WriteLine(" wor\bld");
            //   Console.Write(" world");
            //  Console.Beep();

            //     int ddd = 1;

            //varaible

            //      int y = 321;

            //      int z = ddd + y;

            //      int aga = 28;
            //       double daga = 28.22;

            ///bool aaa = true;

            //    char sym = ';';

            //     String name = "aadadad";
            //  Console.Write(ddd);
            //   Console.Write(y);
            //  Console.Write(z);

            //   Console.Write("Yopu age is:" +  aga + daga + aaa + sym + name);



            // const  double pi = 3.14159;


            //    pi = 420;


            //  double a = 3.14;

            //  int b = Convert.ToInt32(a);

            //   int c = 123;

            //   double d = Convert.ToDouble(c) + 0.1;


            //   int t = 321;


            //    String f = Convert.ToString(t);

            //    String j = "$";

            //    char h = Convert.ToChar(j);


            //     String i = "true";


            //    bool k = Convert.ToBoolean(i);
            //    Console.WriteLine(f.GetType());
            //   Console.WriteLine(d);
            //    Console.WriteLine(b);
            //    Console.WriteLine(h);
            //    Console.WriteLine(k);

            //    Console.WriteLine("What is  your name ?");
            //     String name = Console.ReadLine();


            //   Console.WriteLine("Hello " + name);

            //     Console.WriteLine("What is  your age ?");
            //     int age = Convert.ToInt32(Console.ReadLine());

            //    Console.WriteLine("Hello " + name + " your age is: " + age);




            // int friends = 5;

            //  friends++;
            //  friends--;
            //  friends = friends *2;

            //  friends /= 2;

            //   friends %= 2;

            //     Console.WriteLine(friends);



            //  double x = 3.14;
            //    double y = 5;
            //    double a = Math.Pow(x,2);

            // double b = Math.Sqrt(x);


            //   double c = Math.Abs(x);

            //double d = Math.Round(x);
            //   double e = Math.Ceiling(x);
            //    double f = Math.Floor(x);

            //double g = Math.Max(x, y);
            //  double h = Math.Min(x, y);

            //    Console.WriteLine(h);


            // Random random = new Random();

            //   int num =  random.Next(1,7);
            //   int num2 =  random.Next(1,7);
            //   int num3 =  random.Next(1,7);
            //  double num =  random.NextDouble();

            //  Console.WriteLine("Enter the a:");

            //    double a = Convert.ToDouble(Console.ReadLine());

            //    Console.WriteLine("Enter the b:");

            //    double b = Convert.ToDouble(Console.ReadLine());

            //    double c = Convert.ToDouble(Math.Sqrt(Math.Pow(a,2) + Math.Pow(b,2)));

            //     Console.WriteLine("The hypotenuse is: " + c);



            //    String fullName = "Bro code";
            //   String phone = "123-456-789";


            // fullName =  fullName.ToUpper();
            //  fullName =  fullName.ToLower();

            //    phone =  phone.Replace("-", " ");
            //     Console.WriteLine(phone);

            //    String userName = fullName.Insert(0,"@");

            //    Console.WriteLine(userName);

            //   Console.WriteLine(fullName.Length);


            //   String firstName = fullName.Substring(0,3);
            //   String lastName = fullName.Substring(4,4);

            //    Console.WriteLine(firstName);
            //    Console.WriteLine(lastName);




            //   Console.WriteLine("Please enter your name: ");


            //    int age = Convert.ToInt32(Console.ReadLine());
            //    String name = Console.ReadLine();
            //    if (name != "")
            //   {
            //       Console.WriteLine("You dit not enter your name");
            //    }
            //   else
            //   {
            ////       Console.WriteLine("Hello " + name);
            //   }
            /*   if (age > 100)
               {
                   Console.WriteLine("You died ");

               }
               else if (age >=18)
               {
                   Console.WriteLine("You are now signed up  ");
               }
               else if (age < 0 )
               {
                   Console.WriteLine("Youhavent been  born yet  ");
               }
               else
               {
                   Console.WriteLine("You must be 18+ to sign up ");
               }*/





            //   String day = Console.ReadLine();


            /*     switch (day) {
                    case "Monday":
                         Console.WriteLine("It s MOnday");
                         break;
                     case "Tuesday":
                         Console.WriteLine("It s Tuesday");
                         break;
                     case "Wednesday":
                         Console.WriteLine("It s Wednesday");
                         break;
                     case "thrusday":
                         Console.WriteLine("It s thrusday");
                         break;
                     case "Friday":
                         Console.WriteLine("It s Friday");
                         break;
                     case "Saturday":
                         Console.WriteLine("It s Saturday");
                         break;
                     case "Sunday":
                         Console.WriteLine("It s Sunday");

                         break;
                     default:
                         Console.Write(day + " Its not a day");
                         break;
                 }*/



            //    Console.WriteLine("What's the temperature outside ?");

            //     double temp = Convert.ToDouble(Console.ReadLine());

            //     if(temp >= 10 && temp <= 25)
            //    {
            //         Console.WriteLine("its warm outside "+temp);
            //    }else if (temp <= -50 || temp >=50)
            //   {
            //      Console.WriteLine("Do not go outside " + temp);
            //  }


            //  Console.Write("What's your name ?");

            // String name = "";
            //   while(name =="")
            //   {
            //       Console.Write("What's your name ? ");
            //       name = Console.ReadLine();
            //   }

            //  Console.WriteLine("Your name is " + name);



            //  for (int i =5;i>=0;i--)
            //   {
            //       Console.WriteLine(i);
            //   }


            //  Console.WriteLine("How many rows: ");


            //    int rows = Convert.ToInt32(Console.ReadLine());



            //     Console.WriteLine("How many columns: ");


            //     int col = Convert.ToInt32(Console.ReadLine());


            //     Console.WriteLine("Give me the symbol: ");


            //     String symbol = Console.ReadLine();

            //    for(int i = 0; i < rows; i++)
            //    {
            //        for (int j = 0; j < col; j++)
            //        {
            //            Console.Write(symbol);
            //        }
            //        Console.WriteLine();
            //    }

            Random random = new Random();


           bool playAgain = true;


            int min = 1;

            int max = 100;

            int guess;


            int number;


            int guesses;

            String response;

            while (playAgain)
            {
                guess = 0;
                guesses = 0;
                response = "";
                number = random.Next(min, max+1);


                while (guess != number)
                {
                    Console.WriteLine("Guess a number between " + min + " - " + max + " :");

                    guess = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Guess: " + guess);
                    if (guess > number)
                    {
                        Console.WriteLine(guess + " is too high!");
                    }
                    else if(guess< number){
                        Console.WriteLine(guess + " is too low!");
                    }
                    guesses++;
                }
                Console.WriteLine("Number: " + number);
                Console.WriteLine("You win : " + "your number of guesses: "+ guesses);

                Console.WriteLine("Would you like to play again (Y/N) ?");
                response = Console.ReadLine();
                response = response.ToUpper();
                if(response == "Y")
                {
                    playAgain = true;

                }
                else
                {
                    playAgain = false;
                }
            }
            Console.WriteLine("Thanks for the playing !");
            Console.ReadKey();
        }
    }
}
