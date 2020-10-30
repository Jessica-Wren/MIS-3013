using System;
using System.Transactions;

namespace SumOf3
{
    class Program
    {
        const double LUCKY_NUMBER = 7.777;
        static void Main(string[] args)
        {


        
            

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
            double answer2 = answer * LUCKY_NUMBER;

            Console.WriteLine("Your numbers added together make: " + answer.ToString("n3"));

            Console.WriteLine("Now, with my multiplaction manipulation, I shall multiply your number " +
                "by my lucky number: 7.777!");

            Console.WriteLine("Our new number is: " + answer2.ToString("n3"));

            Console.WriteLine("To celebrate, I will now sing a song!" );
            Console.Beep(310, 2000);




            Console.ReadKey();

            


        }
    }
}