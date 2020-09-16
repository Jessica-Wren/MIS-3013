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

            Console.WriteLine("Your range is " + minNum + " - " + maxNum);

            Random rnd = new Random();
            int number = rnd.Next(minNum, maxNum);

            Console.WriteLine(rnd);

            Random rnd = new Random();
            int number = rnd.Next

            Console.ReadKey();
        }
    }
}
