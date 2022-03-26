using System;
using System.Collections.Generic;

namespace P03_Legendary_Farming
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> resources = new Dictionary<string, int>();
            string command;
            resources.Add("shards", 0);
            resources.Add("motes", 0);
            resources.Add("fragments", 0);
            while (resources["shards"]<250  && resources["fragments"] < 250 &&  resources["motes"] < 250)
            {

                string[] input = Console.ReadLine().Split(new char[] { ' ', '\t'}, StringSplitOptions.RemoveEmptyEntries);
                for (int i = 1; i < input.Length; i += 2)
                {
                    string currStr = input[i].ToLower();
                    if (resources.ContainsKey(currStr))
                    {
                        resources[currStr] += int.Parse(input[i - 1]);
                    }
                    else
                    {
                        resources.Add(currStr, int.Parse(input[i - 1]));
                    }
                    if (resources["shards"] >= 250 || resources["fragments"] >= 250 || resources["motes"] >= 250)
                    {
                        break;
                    }
                }

            }

           
                if (resources["shards"] >= 250)
                {
                    Console.WriteLine($"Shadowmourne obtained!");
                    resources["shards"] -= 250;
                }
                if (resources["fragments"] >= 250)
                {
                    Console.WriteLine($"Valanyr obtained!");
                    resources["fragments"] -= 250;
                }
                if (resources["motes"] >= 250)
                {
                    Console.WriteLine($"Dragonwrath obtained!");
                    resources["motes"] -= 250;
                }
            Console.WriteLine($"shards: {resources["shards"]}");
            Console.WriteLine($"motes: {resources["motes"]}");
            Console.WriteLine($"fragments: {resources["fragments"]}");
            foreach (var item in resources)
            {
                if (item.Key!="shards"&& item.Key!="motes" && item.Key!="fragments")
                {
                    Console.WriteLine($"{item.Key}: {item.Value}");
                }
            }
        }
    }
}
