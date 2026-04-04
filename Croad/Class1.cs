using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Croad
{
    class Class1
    {
      public void Game()
        {

       
            Random random = new Random();

            bool playAgain = true;

            String player;

            String computer;

            String response;
            while (playAgain)
            {
                player = "";
                computer = "";
                response = "";
                while (player != "ROCK" && player != "PAPER" && player != "SCISSORS")
                {
                    Console.Write("Enter Rock, Paper, or Scissors: ");

                    player = Console.ReadLine();
                    player = player.ToUpper();
                    //Console.WriteLine(player);
                }
               
                switch (random.Next(1, 4))
                {
                    case 1:
                        computer = "ROCK";
                        break;
                    case 2:
                        computer = "PAPER";
                        break;
                    case 3:
                        computer = "SCISSORS";
                        break;
                }
                Console.WriteLine("Player choose: "+ player);
                Console.WriteLine("Computer choose: "+ computer);

                switch (player) {
                    case "ROCK":
                        if(computer == "ROCK")
                        {
                            Console.WriteLine("Its a draw");
                        }else if (computer == "PAPER")
                        {
                            Console.WriteLine("Computer won!");
                        }
                        else
                        {
                            Console.WriteLine("Player won");
                        }
                        break;
                    case "PAPER":
                        if (computer == "ROCK")
                        {
                            Console.WriteLine("Player won");
                        }else if(computer == "PAPER")
                        {
                            Console.WriteLine("Its a draw");
                        }
                        else
                        {
                            Console.WriteLine("Computer won!");
                        }
                        break;
                    case "SCISSORS":
                        if (computer == "ROCK")
                        {
                            Console.WriteLine("Computer won");
                        }
                        else if (computer == "PAPER")
                        {
                            Console.WriteLine("Player won");
                        }
                        else
                        {
                            Console.WriteLine("Its a draw");
                        }
                        break;
                }
                Console.Write("Would you play again (Y/N)");
                response = Console.ReadLine();
                if (response.ToUpper() == "Y" )
                {
                    playAgain = true;
                }
                else
                {
                    playAgain = false;
                }
            }

            Console.Write("Thanks for a game");

            Console.ReadKey();
        }
    }
}

