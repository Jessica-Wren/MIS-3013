using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
                                                                                          //11/12/2020
namespace Classes_Toys
{
    class Program
    {
        static void Main(string[] args)
        {
            Toy toy1 = new Toy();
            toy1.Manufacturer = "FunTime";
            toy1.Name = "Boardgame";
            toy1.Price = 10.00;
            Console.WriteLine("Toy1 manufacturer is " + toy1.Manufacturer + ". Toy1 name is " + toy1.Name + ". Toy1 price is price is " + toy1.Price);
            Console.WriteLine("Toy2 is found on isle " + toy1.GetAisle() + ".");

            Console.WriteLine();

            Toy toy2 = new Toy();
            toy2.Manufacturer = "SuperPlay";
            toy2.Name = "Dinosaur";
            toy2.Price = 1.00;
            Console.WriteLine("Toy2 manufacturer is " + toy2.Manufacturer + ". Toy2 name is " + toy2.Name + ". Toy2 price is price is " + toy2.Price);
            Console.WriteLine("Toy2 is found on isle " + toy2.GetAisle() + ".");

            Console.WriteLine();
            Console.WriteLine();

            string response = "";
            string newToy = "";

            do
            {
                Console.WriteLine("Do you want to add a toy to the box?");
                response = Console.ReadLine();

                if (response.ToLower() == "yes")
                {
                    Console.WriteLine("Add a toy to the toybox.");
                    newToy = Console.ReadLine();
                   // Toys.Add(newToy);
                }
                else
                {
                    Console.WriteLine("Goodbye.");
                }

            } while (response.ToLower() == "yes");



            Console.ReadKey();
        }
    }
}
