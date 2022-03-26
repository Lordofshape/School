using System;
using System.Collections.Generic;
using System.Linq;

namespace P07_Student_Academy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, List<double>> system = new Dictionary<string, List<double>>();
            for (int i = 0; i < n; i++)
            {
                string student = Console.ReadLine();
                double grade = double.Parse(Console.ReadLine());
                if (system.ContainsKey(student))
                {
                    system[student].Add(grade);
                }
                else
                {
                    system.Add(student, new List<double>());
                    system[student].Add(grade);
                }
            }
            Dictionary<string, double> bestStudents = new Dictionary<string, double>();

            foreach (var s in system)
            {
                double currSum = s.Value.Sum();
                double currGrades = s.Value.Count();
                double averageGrade = currSum / currGrades;
                if (averageGrade>=4.50)
                {
                    bestStudents.Add(s.Key, averageGrade);
                }
            }
            foreach (var student in bestStudents)
            {
                Console.WriteLine($"{student.Key} -> {student.Value:f2}");
            }
        }
    }
}
