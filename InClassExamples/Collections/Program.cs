using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, double> studentGpas = new Dictionary<int, double>();

            if (studentGpas.ContainsKey(1) == true)
            {
                studentGpas[1] = 1.7;
            }
            else
            {
                studentGpas.Add(1, 1.7);
            }
             
            studentGpas.Add(2, 3.5);
            studentGpas.Add(3, 4.0);


            foreach (var studentID in studentGpas.Keys)
            {
                Console.WriteLine(studentID);
            }


            Console.WriteLine("Please pick an ID to display the GPA of.");
            int id = Convert.ToInt32(Console.ReadLine());

            if (studentGpas.ContainsKey(id) == true)
            {
                double gpa = studentGpas[id];
                Console.WriteLine("Student with id " + id + " has a gpa of " + gpa + ".");
            }
            else
            {
                Console.WriteLine("INVALID ID. GOODBYE.");
            }

            Console.ReadKey();
        }

        static void ArrayExample()
        {
            int[] studentIds = new int[3];
            double[] gpas = new double[3];

            //Assign values to the studentId's array
            studentIds[0] = 1;
            studentIds[1] = 2;
            studentIds[2] = 3;

            //Assign values to the gpas array
            gpas[0] = 1.75;
            gpas[1] = 2.99;
            gpas[2] = 4.0;

            /*
            for (int i = 0; i < studentIds.Length; i++)
            {
                //The format to get a value out of an array:
                //Creating a temp variable to hold the current students id
                int studentId = studentIds[i];
                Console.WriteLine(studentId);
            }*/

            foreach (int studentId in studentIds)
            {
                Console.WriteLine(studentId);
            }

            Console.WriteLine("Please pick an ID to display the GPA of.");
            int id = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < studentIds.Length; i++)
            {
                int studentId = studentIds[i];
                if (studentId == id)
                {
                    double gpa = gpas[i];
                    Console.WriteLine("Student with id " + id + " has a gpa of " + gpa + ".");
                    break;
                }
            }



            Console.ReadKey();

        }
    }
}
