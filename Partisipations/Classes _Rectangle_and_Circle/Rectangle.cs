using System;
using System.Collections.Generic;
using System.Text;

namespace Classes__Rectangle_and_Circle
{
    public class Rectangle
    {
        public double Length;
        public double Width;

        //path A
        //empty/default constructor
        public Rectangle()
        {
            Length = 0;
            Width = 0;
        }

        public double CalculateArea() 
        {
            double areaCalculation = Length * Width;
            return areaCalculation;
        }

        public double CalculatePerimeter() 
        {
            double perimeterCalculation = 2*(Length + Width);
            return perimeterCalculation;
        }
    }
}
