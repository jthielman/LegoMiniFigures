using LegoMiniFigures.Composition.Heads;
using LegoMiniFigures.Composition.Legs;
using LegoMiniFigures.Composition.Torsos;
using System;
using System.Collections.Generic;
using System.Text;

namespace LegoMiniFigures
{
    class Astronaut
    {
        public Location Location { get; set; } // Public property
        public bool SuitedUp => Name != "Space Person"; // expression-bodied property (the value is never set; it has a value based on other things)
        public string Name { get; } // Read-Only property (Name can only be set in constructor)
        public string Job { get; private set; } // Public property with a private setter (Job can be set by a method in this class, but not from without)
        public int OxygenLevel { private get; set; } // Public property with a private getter (can be set but not retrieved from without)

        public AstronautTorso Torso { get; set; }
        public AstronautLegs Legs { get; set; }
        public ZoeHead Head { get; set; }

        public Astronaut(string name, string job,
                         ZoeHead head, AstronautTorso torso,
                         AstronautLegs legs)
        {
            Name = name;
            Job = job;

            Head = head;
            Torso = torso;
            Legs = legs;
        }

        public void Promote()
        {
            Job = "Commander of Janitors";
        }

        public void DoYourJob(int stepsToWalk)
        {
            Console.WriteLine($"Doing all my {Job} duties...");
            Legs.Walk(stepsToWalk);
            Head.EatPie("Cherry");
            Torso.Flex();
            Legs.Walk(stepsToWalk);
        }
    }
}
