using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacies
{
    public class Medicine
    {
        public Medicine(string name,double price)
        {
            AddMedicine(name,price);

        }
        public string Name { get; set; }
        public double Price { get; set; }

        public void	AddMedicine(string name,double price)
        {
            this.Name = name;
            this.Price = price;
        }
        public override string ToString()
        {
            return $"Medicine: {this.Name} with price {this.Price}"; 
        }
    }
}
