using System;

namespace ConditionalStatement
{
    class Program
    {
        static void Main(string[] args)
        {
            //DECLARE VARIABLES

            double weight = 0;
            double distance = 0;
            string response = "";
            bool containsHazardous = false; // doesnt matter what value it equals for now
            //double quote = (0.55 * distance) + (.73 * weight);
            //double hazardousCost = 0;
            //double netTotal = quote + hazardousCost;
            //double discount = 0;
            //double total = netTotal - discount;

            //INPUT

            Console.WriteLine("What is the weight of your shippment in pounds? >>");
            response = Console.ReadLine();
            weight = Convert.ToDouble(response);

            Console.WriteLine("What is the distance of your shippment in miles? >>");
            distance = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Does your shippment contain any hazardous material, yes or no? >>");
            response = Console.ReadLine();

            if (response == "yes")
            {
                containsHazardous = true;
            }
            else if (response == "no")
            {
                containsHazardous = false;
            }
            else
            {
                Console.WriteLine("INVALID INPUT. GOODBYE!");
                return;
            }

            double quote = (0.55 * distance) + (.73 * weight);
            double hazardousCost = 0;

            if (containsHazardous == true)
            {
                hazardousCost = 0.15 * weight;
            }
            else
            {
                hazardousCost = 0;
            }

            double netTotal = quote + hazardousCost;
            double discount = 0;


            if (distance < 150 && weight > 500);
            {
                discount = netTotal * .10;
            }

            //Your flowchart said +, but discounts should be subtracted
            double total = netTotal - discount;

            Console.WriteLine(); //adding an extra line
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Quote: \t\t" + quote.ToString("C")); //Converting to currency
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Hazardous Cost: " + hazardousCost.ToString("C"));
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Net Total: \t" + netTotal.ToString("C"));
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Discount: \t" + discount.ToString("C"));
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine($"Total: \t\t{total.ToString("C")}");
        }

    }
}
