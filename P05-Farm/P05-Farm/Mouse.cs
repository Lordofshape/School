namespace P05_Farm
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Mouse : Mammals
    {
        public override string Eat(Food food)
        {
            throw new NotImplementedException();
        }

        public override string MakeSound()
        {
            return "SQUEEEAAK!";
        }
    }
}
