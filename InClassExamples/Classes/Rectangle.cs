using System;
using System.Collections.Generic;
using System.Text;

namespace Classes
{
    public class Rectangle
    {
        private int width;
        private int height;

        /// <summary>
        /// This is the default/empty constructor for the class. //path A
        /// </summary>
        public Rectangle()
        {
            width = 0;
            height = 0;
        }

        /// <summary>
        /// This is the overloaded constructor passing in the starting values for width and height //Path B
        /// </summary>
        /// <param name="width"></param>
        /// <param name="height"></param>
        public Rectangle(int width, int height)
        {
            this.width = width;  // this makes the first width and height connect with the method at the top width and height
            this.height = height;
        }

        public double Area() 
        {
            double result = width * height;

            return result;
        }

    }
}
