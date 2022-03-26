using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace P08_Company_Users
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string,List<string>> dic = new Dictionary<string,List<string>>();
            string command;
            while ((command=Console.ReadLine())!="End")
            {
                MatchCollection collection = Regex.Matches(command, @"\w+ \w+|\w+\w+");
                string company = string.Join("",collection[0]);
                string employeeId = string.Join("", collection[1]);
                if (dic.ContainsKey(company))
                {
                    if (dic[company].Any(x => x == employeeId))
                    {
                        continue;
                    }
                    else
                    {
                        dic[company].Add(employeeId);
                    }
                }
                else
                {
                    dic.Add(company, new List<string>());
                    dic[company].Add(employeeId);
                }
            }
            foreach (var company in dic)
            {
                Console.WriteLine(company.Key);
                foreach (var employee in company.Value)
                {
                    Console.WriteLine($"-- {employee}");
                }
            }
        }
    }
}
