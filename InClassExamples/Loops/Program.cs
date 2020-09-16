using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {

            // add all the values up from 1 to 100 and output the sum

            int sum = 0;
            // controll var  Condition  Incrementation/decrementation
            for (int i = 1; i < 101; i++)
            {

                // same thing as saying/putting that sum += i;
                sum = sum + i;
            }

            Console.WriteLine("The sum of the values from 1 - 100 is " + sum);

            // SECOND PROBLEM
            // ask the user if they want to perform another iteration until they say no. 
            // output the number of iterations (or times the user said yes).

            int iterations = 0;
            string response;
            do
            {
                iterations += 1;
                Console.WriteLine("Do you want to perform another iteration, yes or no?");
                response = Console.ReadLine();
            } while (response.ToLower() == "yes");


            // FOR WHILE LOOP
            /* while (response.ToLower() == "yes")
            {
                iterations += 1;
                Console.WriteLine("Do you want to perform another iteration, yes or no?");
                response = Console.ReadLine();
            }*/

            Console.WriteLine("The number of iterations (or times we asked the user) was " + iterations);

            Console.ReadKey(); // Waiting for the user to press a key to exit
        }

    }
}
