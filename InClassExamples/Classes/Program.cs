using System;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {

            Rectangle r1 = new Rectangle(10, 15);
            double r1Area = r1.Area();

            Console.WriteLine("The area of r1 is " + r1Area.ToString("n1"));

            //OR you can do it like this
            Rectangle r2 = new Rectangle(7, 8);
            Console.WriteLine("The area of r2 is " + r2.Area().ToString("n1"));

            //OR you can do it all on one line Probably never do this
            Console.WriteLine("The area of this new rectangle is " + new Rectangle(5,5).Area());



            Console.ReadKey();
        }
    }
}
