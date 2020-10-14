using System;
using System.IO;

namespace ProcessingACSVFile_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"SalesJan2009.csv";

            string[] lines = File.ReadAllLines(filePath);

            //Transaction_date is at position 0
            //Transaction_date,Product,Price,Payment_Type,Name,City,State,Country,Account_Created,Last_Login,Latitude,Longitude

            //Name = 4 
            //Transaction_date = 0 
            //Payment_Type = 3  (VISA)
            //Country = 7   (USA)

            for (int i = 1; i < lines.Length; i++)
            {
                string line = lines[i];
                string[] pieces = line.Split(',');
                string date = pieces[0];
                string name = pieces[4];
                if (pieces[3].Trim().ToLower() == "visa" && pieces[7].Trim().ToLower() == "united states")
                {
                    Console.WriteLine(name + " purchased a product with a Visa in the United States on " + date + ".");
                }
            }

            

                Console.ReadKey();

        }
    }
}
