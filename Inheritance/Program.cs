using System;
using System.Collections.Generic;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO Be sure to follow best practice when creating your classes

            // Create a class Animal -- DONE
            // give this class 4 members that all Animals have in common--DONE


            // Create a class Bird -- DONE
            // give this class 4 members that are specific to Bird -- DONE
            // Set this class to inherit from your Animal Class -- DONE

            // Create a class Reptile -- DONE
            // give this class 4 members that are specific to Reptile --DONE
            // Set this class to inherit from your Animal Class --DONE




            /*Create an object of your Bird class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */

            /*Create an object of your Reptile class
             *  give values to your members using the object of your Reptile class
             *  
             * Creatively display the class member values 
             */


            var peacock = new Bird();

            peacock.CanFly = true;
            peacock.LaysEggs = true;  
            peacock.BeakLength = 3.4;
            peacock.FeatherColor = "Red";


            var lizard = new Reptile();

            lizard.BreatheWithLungs = true;
            lizard.ColdBlooded = true;
            lizard.HasScales = true;
            lizard.Vertebrates = true;
       


            List<Object> animals = new List<Object>();

            animals.Add(peacock);
            animals.Add(lizard);
      
            foreach (var animal in animals)
            {

                Console.WriteLine("-----Peacock:---------");
                Console.WriteLine($"Habitat: {peacock.LandAirSea}");
                Console.WriteLine($"Age: {peacock.age}");
                Console.WriteLine($"Legs: {peacock.legs}");
                Console.WriteLine($"Food: {peacock.NeedsFood}");
                Console.WriteLine($"Flys: {peacock.CanFly}");
                Console.WriteLine($"LaysEggs: {peacock.LaysEggs}");
                Console.WriteLine($"Beak Length: {peacock.BeakLength}");
                Console.WriteLine($"Feather Color: {peacock.FeatherColor}");
                Console.WriteLine("");
                Console.WriteLine("-------Lizard-----------");
                Console.WriteLine($"Habitat: {lizard.LandAirSea}");
                Console.WriteLine($"Age: {lizard.age}");
                Console.WriteLine($"Legs: {lizard.legs}");
                Console.WriteLine($"Food: {lizard.NeedsFood}");
                Console.WriteLine($"Breathes With Lungs: {lizard.BreatheWithLungs}");
                Console.WriteLine($"Cold Blooded: {lizard.ColdBlooded}");
                Console.WriteLine($"Has Scales: {lizard.HasScales}");
                Console.WriteLine($"Vertebates: {lizard.Vertebrates}");
                Console.WriteLine("");




            }





        }
    }
}
