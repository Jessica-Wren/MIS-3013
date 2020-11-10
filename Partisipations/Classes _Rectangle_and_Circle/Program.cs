using System;

namespace Classes__Rectangle_and_Circle
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rectangle1 = new Rectangle(); //making an instance of class rectangle
            rectangle1.Length = 2;
            rectangle1.Width = 2;
            Console.WriteLine("The area of rectangle1 (that has a length and width of 2) is " + rectangle1.CalculateArea());
            // in the Rectangle class...                                                    .CalculateArea is a method 
            Console.WriteLine("Also, the perimeter of rectangle1 is " + rectangle1.CalculatePerimeter());

            Console.WriteLine();

            Rectangle rectangle2 = new Rectangle();
            rectangle2.Length = 3;
            rectangle2.Width = 4;
            Console.WriteLine("The area of rectangle2 (that has a length of 3 and a width of 4) is " + rectangle2.CalculateArea());
            // in the Rectangle class...                                                    .CalculateArea is a method 
            Console.WriteLine("Also, the perimeter of rectangle2 is " + rectangle2.CalculatePerimeter());


            Console.WriteLine();
            Console.WriteLine();


            Circle circle1 = new Circle(); //making an instance of class Circle
            circle1.Radius = 7.5;
            Console.WriteLine("The area of circle1 with " + circle1.Radius + " is " + circle1.CalculateArea());
            //both in the Circle class...                  .Radius is a property         .CalculateArea is a method 
            Console.WriteLine("Also, the perimeter of circle1 is " + circle1.CalculatePerimeter());

            Console.WriteLine();

            Circle circle2 = new Circle(); //making an instance of class Circle
            circle2.Radius = 12;
            Console.WriteLine("The area of circle2 with " + circle2.Radius + " is " + circle2.CalculateArea());
            //both in the Circle class...                  .Radius is a property         .CalculateArea is a method 
            Console.WriteLine("Also, the perimeter of circle2 is " + circle2.CalculatePerimeter());


            Console.ReadKey();
        }
    }
}
