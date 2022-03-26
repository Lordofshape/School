using System;
using System.Collections.Generic;
using System.Text;

namespace P05_Farm
{
    public abstract class Mammals : Animal
    {
        public string LivingRegiom { get; set; }

        public override string ToString()
        {
            return $"{ this.GetType().Name} {this.AnimalName},[{this.AnimalWeight}, {this.LivingRegiom},{this.FoodEaten}]";
        }
    }
}
