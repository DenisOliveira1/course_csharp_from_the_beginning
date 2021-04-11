using System;
using System.Collections.Generic;
using System.Linq;

namespace deferredExecutionExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // Let's define an input array of kittens
            List<Kitten> kittens = new List<Kitten>
            {
                new Kitten(1.0f, Kitten.KitGender.MALE, "Brown", "Nick"),
                new Kitten(0.8f, Kitten.KitGender.FEMALE, "White", "Valery"),
                new Kitten(3.0f, Kitten.KitGender.FEMALE, "LightGray", "Jessie"),
                new Kitten(3.1f, Kitten.KitGender.MALE, "Black", "Stevie"),
                new Kitten(4.0f, Kitten.KitGender.MALE, "White", "Johnie"),
                new Kitten(2.0f, Kitten.KitGender.FEMALE, "LightBrown", "Lucy"),
                new Kitten(5.0f, Kitten.KitGender.FEMALE, "Orange", "Daisie"),
                new Kitten(6.0f, Kitten.KitGender.MALE, "Orange", "Rockie")
            };

            // Let's define our selector
            KitSelector selector = new KitSelector( kittens );

            // Now, it's time to select using some criteria
            // All males
            var maleKittens = selector.SelectByGender(Kitten.KitGender.MALE);

            Console.WriteLine("\r\n\r\n"); 
            // Query execution is here!
            foreach (Kitten kit in maleKittens)
            {
                Console.WriteLine("MALE: " + kit.GetInfo());
            }

            // All kittens in age between 1 to 3 months
            var ageKittens = selector.SelectByAge(1.0f, 3.0f);

            Console.WriteLine("\r\n\r\n");

            // Query execution is here!
            foreach (Kitten kit in ageKittens)
            {
                Console.WriteLine("AGE: " + kit.GetInfo());
            }

            // Now, let's combine age and gender criteria...
            // All FEMALE kittens aged from 0.5 to 4.0 mounths 
            IEnumerable<Kitten> combinedQuery =
                from kit in selector.SelectByAge(0.5f, 4.0f)
                where selector.SelectByGender(Kitten.KitGender.FEMALE).Contains(kit)
                select kit;

            Console.WriteLine("\r\n\r\n");
            // Query execution is here!
            foreach (Kitten kit in combinedQuery)
            {
                Console.WriteLine("AGE & GENDER: " + kit.GetInfo());
            }


            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
