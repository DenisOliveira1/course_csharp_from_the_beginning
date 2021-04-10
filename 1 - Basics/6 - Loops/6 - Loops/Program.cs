using System;

namespace _6___Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 12, 54, 23, 78 };

            for (int i = 0; i < array.Length; i++) {
                Console.WriteLine(array[i]);
            }

            Console.WriteLine("----------------");
            foreach (int item in array)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("----------------");
            int num = 0;

            while (num < 10) {
                if (num % 2 == 0) {
                    Console.WriteLine(num + " é par!");
                }
                num++;
            }

            Console.WriteLine("----------------");
            Console.WriteLine("Break e Continue");

            foreach (int item in array)
            {
                if (item == 23) {
                    break; // Encerra o for
                }
                else if (item == 54)
                {
                    continue; // Vai paraa próxima interação do for
                }

                Console.WriteLine(item);
            }
        }
    }
}
