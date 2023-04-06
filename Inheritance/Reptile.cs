using System;
namespace Inheritance
{
    public class Reptile : Animal
    {

        public bool HasScales { get; set; }
        public bool ColdBlooded { get; set; }
        public bool Vertebrates { get; set; }
        public bool BreatheWithLungs { get; set; }

        public Reptile()
        {
            legs = 4;
            age = 0;
            LandAirSea = "Land";
            NeedsFood = true;

        }

    }
}

