using System;
using System.Collections.Generic;
using System.Text;
                                                                                      //11/10
namespace Classes__Rectangle_and_Circle
{
    public class Rectangle
    {
        //Lenght and Width are the properties of class Rectangle
        public double Length { get; set; }
        public double Width { get; set; }


        //path A
        //empty/default constructor
        //Method
        public Rectangle()
        {
            Length = 0;
            Width = 0;
        }

        //Method
        public double CalculateArea() 
        {
            double areaCalculation = Length * Width;
            return areaCalculation;
        }


        //Method
        public double CalculatePerimeter() 
        {
            double perimeterCalculation = 2*(Length + Width);
            return perimeterCalculation;
        }
    }
}
