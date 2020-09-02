using System;
using System.Transactions;

namespace SumOf3
{
    class Program
    {
        const double LUCKY_NUMBER = 7.777;
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.DarkCyan;

            string firstNumber;
            string secondNumber;
            string thirdNumber;

            Console.WriteLine("I am the magical sum of 3 genie. I will have you enter 3 numbers." +
                " Then, I will add them together. Numbers can be decimals");

            Console.WriteLine("Enter your first number. >>");
            firstNumber = Console.ReadLine();
            double firstConverted = Convert.ToDouble(firstNumber);

            Console.WriteLine("Enter your second number. >>");
            secondNumber = Console.ReadLine();
            double secondConverted = Convert.ToDouble(secondNumber);

            Console.WriteLine(" Finally, enter your third number. >>");
            thirdNumber = Console.ReadLine();
            double thirdConverted = Convert.ToDouble(thirdNumber);

            double answer = firstConverted + secondConverted + thirdConverted;

            Console.WriteLine(answer.ToString("n3"));


            


        }
    }
}