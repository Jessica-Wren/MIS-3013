/*
 * If you collaborate wuth someone, give them credit by:
 * @Author: Jessica Wren
 * Collaborated with Prof. Ackerman and the Class
 */
using System;
using System.Drawing;

namespace InputOutput
{
    class Program
    {
        const string CLASS_NAME = "MIS 3013";
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.DarkCyan;

            // This wont work bc it is a constant: CLASS_NAME = "MIS 3353";
            //String firstName, lastName;
            string firstName = "Jessica";
            string lastName = "Wren";

            Console.WriteLine("Please enter your first name >>");
            firstName = Console.ReadLine(); //Setting what the user typed and storing it in the variable firstName

            Console.WriteLine("Please enter your last name");
            lastName = Console.ReadLine();

            Console.WriteLine("What is your GPA? >>");
            string gpaInput = Console.ReadLine();
            double gpa = Convert.ToDouble(gpaInput);

            // This makes no sense BUT it shows we can use it in calculations 
            // double gpaEnhanced = gpa + 1.5;

            Console.WriteLine(firstName+ " " + lastName + " is attending " + CLASS_NAME + " with a GPA of " 
                + gpa.ToString("N2"));

        }
    }
}
