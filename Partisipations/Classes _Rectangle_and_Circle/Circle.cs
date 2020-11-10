using System;
using System.Collections.Generic;
using System.Text;
                                                                                      //11/10
namespace Classes__Rectangle_and_Circle
{
    class Circle
    {
        public double Radius { get; set; } //prop tab tab

        public Circle() //ctor tab tab
        {
            Radius = 0;

        }

        public double CalculateArea()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }
        
        public double CalculatePerimeter() 
        {
            return 2 * Math.PI * Radius;
        }

    }
}
