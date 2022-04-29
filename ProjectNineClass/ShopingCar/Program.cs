namespace ShopingCar
{
    using System;
    using System.IO;
    class Program
    {

        static void Main(string[] args)
        {

            string path = @"C:\Users\metko\source\repos\Medikko\School\ProjectNineClass\ShopingCar\data.txt.TXT";
            List<Truck> trucks = new List<Truck>();
            List<Car> cars = new List<Car>();
            using (StreamReader reader = new StreamReader(path))
            {
                string[] input = reader.ReadToEnd().Split(new char[] { ' ', '\r', '\t', '\n' }, StringSplitOptions.RemoveEmptyEntries);
                for (int i = 0; i < input.Length; i += 5)
                {
                    int type = int.Parse(input[i]);
                    if (type == 1)
                    {
                        string carBrand = input[i + 1];
                        int year = int.Parse(input[i + 2]);
                        int milleage = int.Parse(input[i + 3]);
                        double value = double.Parse(input[i + 4]);
                        Car car = new Car(carBrand, year, milleage, value);
                        cars.Add(car);
                    }
                    else if (type == 2)
                    {
                        string truckBrand = input[i + 1];
                        int year = int.Parse(input[i + 2]);
                        int milleage = int.Parse(input[i + 3]);
                        double value = double.Parse(input[i + 4]);
                        int tonnage = int.Parse(input[i + 5]);
                        i++;
                        Truck truck = new Truck(truckBrand, year, milleage, value, tonnage);
                        trucks.Add(truck);
                    }
                }
            }
            string outputPath = @"C:\Users\metko\source\repos\Medikko\School\ProjectNineClass\ShopingCar\Output.txt";
            using (StreamWriter writer = new StreamWriter(outputPath))
            {
                foreach (var truck in trucks)
                {
                    writer.WriteLine(truck);
                }
                foreach (var car in cars)
                {
                    writer.WriteLine(car);
                }
            }
        }
    }
}