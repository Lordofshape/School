using System;
using System.Collections.Generic;

namespace P02_A_Miner_Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string command;
            int counter = 1;
            string currKeyValue = null;
            Dictionary<string,int> resources = new Dictionary<string,int>();
            while ((command=Console.ReadLine())!="stop")
            {
                if (counter%2!=0)
                {
                    counter++;
                    if (resources.ContainsKey(command))
                    {
                        currKeyValue = command;
                        continue;
                    }
                    else
                    {
                        currKeyValue = command;
                        resources.Add(command, 0);
                    }
                }
                else
                {
                    counter++;
                    resources[currKeyValue] += int.Parse(command);
                }
            }
            foreach (var resource in resources)
            {
                Console.WriteLine($"{resource.Key} -> {resource.Value}");
            }
        }
    }
}
