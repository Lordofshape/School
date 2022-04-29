namespace ShopingCar
{
    public class Truck : Car
    {
        private int tonnage;

        public Truck(string brand, int year, int millage, double value,int tonnage) : base(brand, year, millage, value)
        {
            this.Brand = brand;
            this.Year = year;
            this.Millage = millage;
            this.Value = value;
            this.tonnage = tonnage;
        }

        public int Tonnage {
            get 
            {
                return tonnage; 
            } 
            set 
            {
                this.tonnage = value;
            } 
        }

        public override double GetPrice()
        {
            int age = DateTime.Now.Year - Year;
            if (age<=5&&Tonnage<5)
            {
                double v = Value * 0.3;
                return v;
            }
            else if(age > 5 && Tonnage < 5)
            {
                double v = Value * 0.3;
                return v;
            }
            else if (age>5&&Tonnage<=10)
            {
                double v = Value * 0.6;
                return v;
            }
            else if (age>5&&Tonnage>10)
            {
                double v = Value * 0.8;
                return v;
            }
            else
            {
                return Value;
            }
            
        }
        public override string ToString()
        {
            return $"{this.Brand}: {this.Millage} km, {GetPrice():f2}";
        }
    }
}

