using System;
using System.Runtime.InteropServices;

namespace Conditional_CoinToss
{
    class Program
    {
        const string DEV_NAME = "Jessica Wren";
        static void Main(string[] args)
        {
            // Declare some variables
            string HT = "heads";

            Console.WriteLine("Lets play a game. Pick heads or tails.");
            HT = Console.ReadLine();

            Random rnd = new Random();
            int number = rnd.Next(0, 2);
            if (number == 0)
            {
                Console.WriteLine("It landed on . . . heads");
            }
            else
            {
                Console.WriteLine("It landed on . . . tails");
            }

            Console.WriteLine("Your guess was . . . " + HT);

            double answer = 0;
            if (HT == "heads" || HT == "Heads" || HT == "HEADS")
            {
                answer = 0;
            }
            else
            {
                answer = 1;
            }


            if (answer == number)
            {
                Console.WriteLine("You guessed correctly. You win!");
            }
            else
            {
                Console.WriteLine("You guessed incorrectly. You lose . . . sad.");
            }
            Console.WriteLine();

            Console.WriteLine("This game was made by developer " + DEV_NAME + "." + " Thanks for playing!");

            Console.ReadKey();
        }
    }
}
