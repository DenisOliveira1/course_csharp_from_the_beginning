using System;
using System.Collections;

namespace _4___Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack myStack = new Stack();

            myStack.Push("Hello");
            myStack.Push("World");
            myStack.Push("!");


            Console.WriteLine(myStack.Count);
            Console.WriteLine(myStack.Peek());
            Console.WriteLine(myStack.Pop());
            Console.WriteLine(myStack.Peek());
        }
    }
}
