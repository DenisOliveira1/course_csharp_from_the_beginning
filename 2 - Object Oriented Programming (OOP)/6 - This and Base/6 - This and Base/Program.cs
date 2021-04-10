using System;

namespace _6___This_and_Base
{
    class Program
    {
        static void Main(string[] args)
        {
            //This
            GeoPoint gp = new GeoPoint();
            gp.SetCoordinates(1, 3);
            Console.WriteLine( gp.ToString());
            Console.WriteLine("---------------");

            //Base
            Dog a = new Dog();
            a.Voice();
            Console.WriteLine(a.name);//Nick
            Console.WriteLine("---------------");

            Dog b = new Dog("Mila");//Joey
            Console.WriteLine(b.name);
        }
    }

}
