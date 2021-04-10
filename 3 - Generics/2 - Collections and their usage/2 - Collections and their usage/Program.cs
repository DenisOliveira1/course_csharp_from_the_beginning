using System;
using System.Collections.Generic;

namespace _2___Collections_and_their_usage
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> cities = new List<string>();
            cities.Add("San Francisco");
            cities.Add("London");
            cities.Add("Poços de Caldas");

            //Access using indexes
            Console.WriteLine(cities[0]);
            Console.WriteLine("-----------------");

            //Access using for
            foreach (string item in cities){
                Console.WriteLine(item);
            }
            Console.WriteLine("-----------------");

            //Remove
            cities.Remove("London");
            cities.RemoveAt(0);

            Console.WriteLine(cities.Count);
            Console.WriteLine(cities[0]);
        }
    }
}
