using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomGuess
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declare some variables

            int maxNum = 0;
            int minNum = 0;

            Console.WriteLine("We are going to play a game. You will attempt to guess a random number that I pick. " +
                "You can pick minimum and maximum number that the random number can be between. Let's begin.");
            Console.WriteLine(); // SPACE

            Console.WriteLine("Pick a minimum number.");
            minNum = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Pick a maximum number.");
            maxNum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Your range is " + minNum + " - " + maxNum);
            Console.WriteLine();

            Random rnd = new Random();
            int number = rnd.Next(minNum, maxNum);

            int iteration = 0;
            int guess = 0;

            do
            {
                iteration += 1;
                Console.WriteLine("What is your guess?");
                Console.WriteLine();
                guess = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
                Console.WriteLine("The number you picked was " + guess);
                if (guess != number)
                {
                    Console.WriteLine();
                    Console.WriteLine("try again.");
                }
            } while (guess != number);

            Console.WriteLine();
            Console.WriteLine("The number I picked was " + number);
            Console.WriteLine();
            Console.WriteLine("You guessed the right number! Yay!");

            Console.ReadKey();
        }
    }
}
