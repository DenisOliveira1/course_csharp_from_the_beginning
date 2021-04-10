using System;
using System.Collections.Generic;
using System.Text;

namespace _1___Object_Oriented_Programming__OOP_
{
    class Rectangle2
    {
        //member variables
        private double length;
        private double width;

        // getters and setters 1
        public double Length { get => length; set => length = value; }
        public double Width { get => width; set => width = value; }

        // getters and setters 2
        public double getLength() {
            return length;
        }

        public void setLength(double value) {
            length = value;
        }

        public double getWidth()
        {
            return width;
        }
        public void setWidth(double value)
        {
            width = value;
        }

        public void Acceptdetails()
        {
            Console.WriteLine("Enter Length: ");
            Length = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Width: ");
            Width = Convert.ToDouble(Console.ReadLine());
        }
        public double GetArea()
        {
            return Length * Width;
        }
        public void Display()
        {
            Console.WriteLine("Length: {0}", Length);
            Console.WriteLine("Width: {0}", Width);
            Console.WriteLine("Area: {0}", GetArea());
        }

    }//end class Rectangle

}
