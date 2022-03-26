using System;
using System.Collections.Generic;

namespace P01_AssociativeArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ',StringSplitOptions.RemoveEmptyEntries);
            Dictionary<char, int> chars = new Dictionary<char,int>();
            foreach (var str in input)
            {
                foreach (var c in str)
                {
                    if (chars.ContainsKey(c))
                    {
                        chars[c]++;
                    }
                    else
                    {
                        chars.Add(c, 1);
                    }
                }
            }
            foreach (var c in chars)
            {
                Console.WriteLine($"{c.Key} -> {c.Value}");
            }
        }
    }
}
