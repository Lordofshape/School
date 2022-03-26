using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace P06_Courses
{
    internal class Program
    {
        static void Main()
        {
            string command;
            Dictionary<string, List<string>> softUni = new Dictionary<string, List<string>>(); 
            while ((command=Console.ReadLine())!="end")
            {
                string[] args = command.Split(':', StringSplitOptions.RemoveEmptyEntries);
                string course = args[0].Trim();
                string name = args[1].Trim();
                if (softUni.ContainsKey(course))
                {
                    softUni[course].Add(name);
                }
                else
                {
                    softUni.Add(course, new List<string>());
                    softUni[course].Add(name);
                }


            }

            foreach (var course in softUni)
            {
                Console.WriteLine($"{course.Key}: {course.Value.Count}");
                foreach (var student in course.Value)
                {
                    Console.WriteLine($"-- {student}");
                }
            }
        }
    }
}
