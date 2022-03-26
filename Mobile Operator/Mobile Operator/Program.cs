using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mobile_Operator
{
    class MainClass
    {
        public static void Main()
        {
            Console.Write("Period: ");
            string period = Console.ReadLine();
            Console.Write("Type: ");
            string type = Console.ReadLine();
            Console.Write("Extranet: ");
            string extranet = Console.ReadLine();
            Console.Write("Months: ");
            int months = int.Parse(Console.ReadLine());

            decimal monthlyFee = 0.00m;

            switch (type)
            {
                case "Small":
                    if (period == "one" && extranet == "yes")
                    {
                        monthlyFee = (9.98m + 5.50m) * months;
                    }
                    if (period == "one" && extranet == "no")
                    {
                        monthlyFee = 9.98m * months;
                    }
                    if (period == "two" && extranet == "yes")
                    {
                        monthlyFee = ((8.58m + 5.50m) * months);
                        monthlyFee = monthlyFee - monthlyFee * 0.0375m;
                    }
                    if (period == "two" && extranet == "no")
                    {
                        monthlyFee = monthlyFee - monthlyFee;
                        monthlyFee = (8.58m * months) - 0.0375m;
                    }
                    break;
                case "Middle":
                    if (period == "one" && extranet == "yes")
                    {
                        monthlyFee = (18.99m + 4.35m) * months;
                    }
                    if (period == "one" && extranet == "no")
                    {
                        monthlyFee = 18.99m * months;
                    }
                    if (period == "two" && extranet == "yes")
                    {
                        monthlyFee = (17.09m + 4.35m) * months;
                        monthlyFee = monthlyFee - monthlyFee * 0.0375m;

                    }
                    if (period == "two" && extranet == "no")
                    {
                        monthlyFee = 17.09m * months;
                        monthlyFee = monthlyFee - monthlyFee * 0.0375m;

                    }
                    break;

                case "Large":
                    if (period == "one" && extranet == "yes")
                    {
                        monthlyFee = (25.98m + 4.35m) * months;
                    }
                    if (period == "one" && extranet == "no")
                    {
                        monthlyFee = 25.98m * months;
                    }
                    if (period == "two" && extranet == "yes")
                    {
                        monthlyFee = ((23.59m + 4.35m) * months);
                        monthlyFee = monthlyFee - monthlyFee * 0.0375m;

                    }
                    if (period == "two" && extranet == "no")
                    {
                        monthlyFee = (23.59m * months);
                        monthlyFee = monthlyFee - monthlyFee * 0.0375m;
                    }
                    break;

                case "ExtraLarge":
                    if (period == "one" && extranet == "yes")
                    {
                        monthlyFee = (35.99m + 3.85m) * months;
                    }
                    if (period == "one" && extranet == "no")
                    {
                        monthlyFee = 35.99m * months;
                    }
                    if (period == "two" && extranet == "yes")
                    {
                        monthlyFee = (31.79m + 3.85m) * months;
                        monthlyFee = monthlyFee - monthlyFee * 0.0375m;
                    }
                    if (period == "two" && extranet == "no")
                    {
                        monthlyFee = 31.79m * months;
                        monthlyFee = monthlyFee - monthlyFee * 0.0375m;
                    }
                    break;
            }
            Console.WriteLine("{0:f2} lv.", monthlyFee);

        }

    }
}