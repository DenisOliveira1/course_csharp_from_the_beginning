using System;

namespace _2___Variables_and_their_types
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Variables Example!");

            int v1 = 1;
            double v2 = 1.2; //double até 15 digitos decimais, float até 7, decimal até 29
            string v3 = "Bom dia!";
            char v4 = 'a';
            bool v5 = true;
            var v6 = 5; //o próprio compilador define o tipo

            Console.WriteLine("Reference Example!");

            char[] refVal1 = new char[3] { 'a', 'b', 'c' };
            char[] refVal2 = refVal1;

            refVal1[1] = 'z'; 
            Console.WriteLine("refVal1: = " + new string(refVal1));
            Console.WriteLine("refVal2: = " + new string(refVal2));

            Console.WriteLine("--------------------------------------");
            Console.WriteLine("Value Example!");

            int a = 120;
            int b = a;

            a = 2000;
            Console.WriteLine("a: = " + a);
            Console.WriteLine("b: = " + b);

            Console.WriteLine("--------------------------------------");
            Console.WriteLine("Boxing Example! Value type inside reference type.");

            int v = 100;
            object obj = v;

            obj = 20;
            Console.WriteLine("v: = " + v);
            Console.WriteLine("obj: = " + (int)obj);

        }
    }
}
