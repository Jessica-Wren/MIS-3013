using System;
using System.IO;

namespace ProcessingACSVFile
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"C:\Users\jessi\Downloads\sales_data_sample.csv";

            string[] lines = File.ReadAllLines(filePath);

            foreach (var line in lines)
            {
                Console.WriteLine(line);
            }
            


            Console.ReadKey();
        }
    }
}
