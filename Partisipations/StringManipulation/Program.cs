using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringManipulation
{
    class Program
       
    {
        static void Main(string[] args)
        {
            string instanceOfString = "Programming today is a race between software engineers striving to build bigger and better idiot-proof programs, and the universe trying to build bigger and better idiots. So far, the universe is winning.";
            string response1 = "";
            string response2 = "";

            Console.WriteLine("Programming today is a race between software engineers striving to build bigger and better idiot-proof programs, and the universe trying to build bigger and better idiots. So far, the universe is winning.");
            Console.WriteLine();

            bool b = false;
            do
            {
                Console.WriteLine("What word do you want to look for in the above sentence?");
                response1 = Console.ReadLine();
                Console.WriteLine();

                Console.WriteLine("What word do you want to change it to?");
                response2 = Console.ReadLine();
                Console.WriteLine();

                if (instanceOfString.Contains(response1))
                {
                    b = true;
                    string output = instanceOfString.Replace(response1.ToString(), response2.ToString());
                    Console.WriteLine(output);
                }
                else
                {
                    string reversed = "";
                    Console.WriteLine("Sorry, I could not find your word, " + response1 + ".");

                    int length = response1.Length - 1;
                    for (int i = length; i>=0; i--)
                    {
                        reversed = reversed + response1[i];
                    }


                    Console.WriteLine("For some reason, your word reversed is: " + reversed);
                    Console.WriteLine();
                }
            } while (b == false);

            



            Console.ReadKey();
        }
    }
}
