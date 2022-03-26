namespace P05_Farm
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public abstract class Animal
    {
        public string AnimalName { get; set; }

        public string AnimaType { get; set; }

        public double AnimalWeight { get; set; }

        public int FoodEaten { get; set; }

        public abstract string MakeSound();

        public abstract string Eat(Food food);

    }

    
}
