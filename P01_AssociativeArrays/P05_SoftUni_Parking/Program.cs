using System;
using System.Collections.Generic;

namespace P05_SoftUni_Parking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string,string> system = new Dictionary<string,string>();

            for (int i = 0; i < n; i++)
            {
                string[] command = Console.ReadLine().Split();
                if (command[0]=="register")
                {
                    if (system.ContainsKey(command[1]))
                    {
                        Console.WriteLine($"ERROR: already registered with plate number {system[command[1]]}");
                    }
                    else
                    {
                        system.Add(command[1],command[2]);
                        Console.WriteLine($"{command[1]} registered {command[2]} successfully");
                    }
                }
                else
                {
                    if (system.ContainsKey(command[1]))
                    {
                        system.Remove(command[1]);
                        Console.WriteLine($"{command[1]} unregistered successfully");
                    }
                    else
                    {
                        Console.WriteLine($"ERROR: user {command[1]} not found");
                    }
                }
            }
            foreach (var user in system)
            {
                Console.WriteLine($"{user.Key} => {user.Value}");
            }
        }
    }
}
