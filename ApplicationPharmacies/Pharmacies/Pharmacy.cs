using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacies
{
    public class Pharmacy
    {
        public Pharmacy(string name)
        {
            this.Name = name;
            this.Medicines = new List<Medicine>();
        }
        public string Name { get; set; }
        public List<Medicine> Medicines { get; set; }

       public string PharmacyInfo()
        {
            string medicines = string.Join(Environment.NewLine,Medicines);
            return medicines; 
        }

        public override string ToString()
        {
            if (this.Medicines.Count > 0)
            {
                return $@"Pharmacy {this.Name} has {this.Medicines.Count} medicines and they are {Environment.NewLine}{PharmacyInfo()}";
               
            }
            else
            {
                return $@"Pharmacy {this.Name} has 0 medicines and they are: {Environment.NewLine}N/A";
            }
        }
        public void Order(Medicine medicine)
        {

            this.Medicines.Add(medicine);
        }
        public bool Sell(Medicine medicine)
        {
            if (Medicines.Any(x => x==medicine))
            {
                Medicines.Remove(medicine);
                return true;
            }
            else
            {
                return false;
            }
            
        }

        public double CalculateTotalPrice()
        {
            double totalPrice = 0;
            foreach (var medicine in Medicines)
            {
                totalPrice += medicine.Price;
            }
            return totalPrice;
        }

        public Medicine GetMedicineWithHighestPrice()
        {
            Medicine medicine = Medicines[0];
            foreach (var m in Medicines)
            {
                if (medicine.Price < m.Price)
                {
                    medicine = m;
                }
            }
            return medicine;
          
        }

        public Medicine GetMedicineWithLowestPrice()
        {
            Medicine medicine = Medicines[0];
            foreach (var m in Medicines)
            {
                if (medicine.Price > m.Price)
                {
                    medicine = m;
                }
            }

            return medicine;
        }

        public void RenamePharmacy(string newName)
        {
            this.Name = newName;
        }

        public void SellAllMedicines()
        {
            Medicines.Clear();
        }

    }
}
