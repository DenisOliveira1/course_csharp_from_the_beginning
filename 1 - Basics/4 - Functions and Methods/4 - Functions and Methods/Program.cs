using System;

namespace _4___Functions_and_Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            FunctionsClass fc = new FunctionsClass();

            fc.HelloSharp("Denis");

            Console.WriteLine("Area = " + fc.Area(3, 4));
            Console.WriteLine("Area = " + fc.Area(15, 5));
            Console.WriteLine("Area = " + fc.Area(15.4, 50.4));
        }
    }
}
