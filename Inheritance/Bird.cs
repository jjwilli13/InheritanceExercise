using System;
namespace Inheritance
{
    public class Bird : Animal
    {
     
        public bool CanFly { get; set; }
        public string FeatherColor { get; set; }
        public bool LaysEggs { get; set; }
        public double BeakLength { get; set; }

        public Bird()
        {
            legs = 2;
            age = 0;
            LandAirSea = "Air";
            NeedsFood = true;
            
        }

       

    }
}

