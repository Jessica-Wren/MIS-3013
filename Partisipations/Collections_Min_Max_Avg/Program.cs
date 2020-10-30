using System;
using System.Collections.Generic;
using System.Net;

namespace Collections_Min_Max_Avg
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> examScores = new List<double>();

            string answer = "";

            
            do
            {
                Console.WriteLine("enter all of your exam grades one at a time");
                examScores.Add(Convert.ToDouble(Console.ReadLine()));

                Console.WriteLine("Do you need to enter more grades?");
                answer = Console.ReadLine();

            } while (answer.ToLower() == "yes");



            double max = 0;
            double min = 110;
            double average = 0;
            int i = 0;
            foreach (double scores in examScores)
            {
                i++;

                if (scores > max)
                {
                    max = scores;
                }
                if (scores < min)
                {
                    min = scores;
                }
                average += scores;
            }

            average /=  i;


            Console.WriteLine();
            Console.WriteLine("Your maximum score was " + max.ToString() + ".");
            Console.WriteLine("Your minimum score was " + min.ToString() + ".");
            Console.WriteLine("Your average score was " + average.ToString() + ".");


            Console.ReadKey();








            /* Console.WriteLine("Please, enter all of your exam grades.");

            List<double> examScores = new List<double>();

            string response = "yes";
            do
            {
                Console.WriteLine("Enter one of your exam grades.");
                examScores.Add(Convert.ToDouble(Console.ReadLine()));

                Console.WriteLine("Do you have any more grades to enter? Yes or No?");
                response = Console.ReadLine();
            } while (response.ToLower() == "yes");


            double max = 0;
            double min = 101;
            double average = 0;
            int i = 0;
            foreach (double scores in examScores)
            {
                i++;
                if (scores > max)
                {
                    max = scores;
                }
                if (scores < min)
                {
                    min = scores;
                }
                average += scores;
            }

            average = average / i;

            Console.WriteLine();
            Console.WriteLine("Your maximum score was " + max.ToString() + ".");
            Console.WriteLine("Your minimum score was " + min.ToString() + ".");
            Console.WriteLine("Your average score was " + average.ToString() + ".");

            Console.ReadKey();*/
        }
    }
}
