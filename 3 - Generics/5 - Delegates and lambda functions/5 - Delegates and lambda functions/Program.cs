using System;

namespace _5___Delegates_and_lambda_functions
{
    class Program
    {
        public delegate string SimpleDelegate(string arg);

        public static string SomeFunction1(string msg) {
            Console.WriteLine("Executing SomeFunction1");
            return "Msg1: " + msg;
        }

        public static string SomeFunction2(string msg)
        {
            Console.WriteLine("Executing SomeFunction2");
            return "Msg2: " + msg;
        }

        public delegate string SimpleDelegateLambda(string arg);

        static void Main(string[] args)
        {
            //Delegates
            SimpleDelegate a;

            a = SomeFunction1;
            Console.WriteLine(a("oi"));
            Console.WriteLine("----------------");

            a += SomeFunction2;
            Console.WriteLine(a("oi"));
            Console.WriteLine("----------------");

            a += SomeFunction1;
            Console.WriteLine(a("oi"));
            Console.WriteLine("----------------");

            //Lambda
            SimpleDelegateLambda b;

            b = (arg) =>
            {
                Console.WriteLine("Executing Lambda Function");
                return arg;
            };

            Console.WriteLine(b("ola"));

        }
    }
}
