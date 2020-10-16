using System;
using System.Collections.Generic;

namespace Methods
{
    class Program
    {
        //define at the class level so all these methods know about the list
        static List<int> values = new List<int>(); 
        static void Main(string[] args)
        {
            // Random rand = new Random();  rand is an instance of the class random (Dont need to know)

            bool isSuccess = PossiblyAddStringToAList("cat");
            if(isSuccess == false)
            {
                Console.WriteLine("Cat wasn't a valid integer :(");
            }

            isSuccess = PossiblyAddStringToAList("5");

            Console.ReadKey();
        }

        /// <summary>
        /// Checks to make sure that a string is a valid integer and if it is, will add it to the List
        /// </summary>
        /// <param name="inputFromWhoeverCalledMe">A string that holds an integer value (hopfully)</param>
        /// <returns>
        /// True if it was able to convert the value and add it to the list
        /// False if it was unable to convert the value
        /// </returns>

        static bool PossiblyAddStringToAList(string inputFromWhoeverCalledMe)
        {
            bool wasSuccess = true;
            int value;

            //tryparse is a method
            wasSuccess = int.TryParse(inputFromWhoeverCalledMe, out value); 

            if (wasSuccess)
            {
                //we want to tell them they have an invailid input
                Console.WriteLine(inputFromWhoeverCalledMe + " was not a valid integer. You must enter an integer.");
            }
            else
            {
                //we want to add it to the list
                values.Add(value);
            }


            return wasSuccess; 
        }
    }
}
