using System;
using System.Collections.Generic;

namespace _3___Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string,int> newDict = new Dictionary<string, int>();

            newDict["a1"] = 23;
            newDict["a3"] = 24;
            
            Console.WriteLine(newDict.Count);
            Console.WriteLine(newDict["a1"]);
            newDict.Remove("a1");
            Console.WriteLine(newDict.Count);
        }
    }
}
