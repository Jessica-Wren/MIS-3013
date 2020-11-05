using System;
using System.Collections.Generic;

namespace ClassesVsParallelCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> firstNames = new List<string>();
            List<string> lastNames = new List<string>();
            List<string> dobs = new List<string>();
            List<string> favFood = new List<string>();
            List<double> accountBalance = new List<double>();

            firstNames.Add("Jessica");
            lastNames.Add("Wren");
            dobs.Add("11/05/2020");
            favFood.Add("Pizza");
            accountBalance.Add(500);

            firstNames.Add("Cathy");
            lastNames.Add("Salvo");
            dobs.Add("12/25/2020");
            favFood.Add("Mango");
            accountBalance.Add(1000);

            for (int i = 0; i < firstNames.Count; i++)
            {
                Console.WriteLine(firstNames[i] + " " + lastNames[i] + " " + dobs[i] + " likes " + favFood[i] + " and has account balance of " + accountBalance[i].ToString("c") + ".");
            }





            Console.WriteLine("Press any key to exit");






            Console.ReadKey();
        }
    }
}
