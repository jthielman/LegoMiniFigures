using System;
using System.Collections.Generic;
using System.Text;

namespace LegoMiniFigures.Composition.Heads
{
    class DragonHead
    {
        public int NumberOfTeeth { get; set; }
        public bool Spiked { get; set; }
        public LegoColor Color { get; set; }
        public BreathType BreathType { get; set; }

        public void Talk()
        {
            Console.WriteLine("You are crunchy and good with ketchup");
        }


    }
    enum BreathType
    {
        Stanky,
        Fire,
        Poison
    }
}
