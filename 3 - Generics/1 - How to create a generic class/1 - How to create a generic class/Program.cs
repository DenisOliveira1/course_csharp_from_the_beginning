using System;

namespace _1___How_to_create_a_generic_class
{
    class Program
    {
        static void Main(string[] args)
        {
            GenericQueue<String> stringQueue = new GenericQueue<string>();

            var s0 = stringQueue.Pop();
            stringQueue.Push("First");
            stringQueue.Push("Second");
            stringQueue.Push("Third");

            var s1 = stringQueue.Pop();
            var s2 = stringQueue.Pop();
            var s3 = stringQueue.Pop();

            Console.WriteLine(s0);
            Console.WriteLine(s1);
            Console.WriteLine(s2);
            Console.WriteLine(s3);
        }
    }
}
