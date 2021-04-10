using System;

namespace _3___Arrays
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Arrays 1-dimensional");

            string[] vegetables1 = { "banana", "potato", "onion" };

            for(int i = 0; i < vegetables1.Length; i++) {
                Console.WriteLine("vegetables1[" + i + "] = " + vegetables1[i]);
            }

            Console.WriteLine("------------------------------------");
            string[] vegetables2 = new string[4];
            vegetables2[1] = "potato";
            vegetables2[2] = "onion";

            for (int i = 0; i < vegetables2.Length; i++)
            {
                Console.WriteLine("vegetables2[" + i + "] = " + vegetables2[i]);
            }


            Console.WriteLine("------------------------------------");
            Console.WriteLine("Arrays 2-dimensional");

            int[,] matrix1 = {{1,2,3},{4,5,6}};

            for (int i = 0; i < matrix1.GetLength(0); i++) // linhas
            {
                for (int y = 0; y < matrix1.GetLength(1); y++) // colunas
                {
                    Console.WriteLine("matrix1[" + i + "," + y +"] = " + matrix1[i,y]);
                }
            }

            Console.WriteLine("------------------------------------");
            Console.WriteLine("Array of arrays");

            string[][] animals = new string[2][];

            animals[0] = new string[] { "Bunny", "Mouse", "Deer" };
            animals[1] = new string[] { "Fox", "Wolf", "Tiger","Lion" };

            foreach(string[] arr1 in animals){
                Console.WriteLine("--------");
                foreach (string arrElement in arr1){
                    Console.WriteLine(arrElement);
                }
            }

        }
    }
}
