using System;

namespace Simple_Method
{
    class Program
    {
        static void Main(string[] args)
        {
         
            Speak();
            

            Console.ReadKey();
        }

        static void Speak ()
        {
            string response = "";
            Console.WriteLine("Please enter dog, monkey, or goat.");
            response = Console.ReadLine();
            Console.WriteLine();

            if (response.ToLower() == "dog")
            {
                Console.WriteLine("bark!");
            }
            else if (response.ToLower() == "monkey")
            {
                Console.WriteLine("oo oo ah ah!");
            }
            else
            {
                Console.WriteLine("baaaa!");
            }
        }
    }
}
