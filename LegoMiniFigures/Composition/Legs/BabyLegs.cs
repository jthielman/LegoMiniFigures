using System;
using System.Collections.Generic;
using System.Text;

namespace LegoMiniFigures.Composition.Legs
{
    class BabyLegs
    {
        public bool CanWalk { get; set; }
        public int NumberOfRolls { get; set; }
        public bool IsClumsy => true;
        public bool HasPants { get; set; }

        public void Walk(int steps)
        {
            if (CanWalk)
            {
                Console.WriteLine($"Baby legs walk around {steps} steps and then fall over.");
            }
            else
            {
                Console.WriteLine($"Baby legs crawl {steps} baby feet.");
            }
        }

        public void Kick()
        {
            Console.WriteLine($"Baby legs kisk with the pwoer of {NumberOfRolls}.");
        }
    }
}
