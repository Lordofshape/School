namespace ShopingCar
{
    public  class Car
    {

        private string brand;
        private int year;
        private int millage;
        private double value;
        public Car(string brand,int year,int millage,double value)
        {
            this.brand = brand;
            this.year = year;
            this.millage = millage;
            this.value = value;
        }

        public string Brand
        {
            get { return this.brand; }
            set { this.brand = value; }
        }
        public int Year
        {
            get { return this.year; }
            set { this.year = value; }
        }
        public double Value
        {
            get { return this.value; }
            set { this.value = value; }
        }
        public int Millage
        {
            get { return this.millage; }
            set { this.millage = value; }
        }
       
        public virtual double GetPrice() 
        {
            int age = DateTime.Now.Year - Year;
            if (age <= 3)
            {
                double v = Value *= 0.8;
                return v;
            }
            else if (age > 3 && age <= 6)
            {
                double v = Value *= 0.6;
                return v;
            }
            else
            {
                double v = Value *= 0.3;
                return v;
            }
        }

        public override string ToString()
        {
            return $"{this.Brand}: {this.millage} km, {GetPrice():f2}";
        }
    }
}
