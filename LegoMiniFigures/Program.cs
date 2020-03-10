using LegoMiniFigures.Composition.Heads;
using LegoMiniFigures.Composition.Legs;
using LegoMiniFigures.Composition.Torsos;
using System;

namespace LegoMiniFigures
{
    class Program
    {
        static void Main(string[] args)
        {
            var head = new ZoeHead
            {
                FacialExpression = "Smiling",
                Color = LegoColor.Orange,
                EyeColor = LegoColor.Green,
                Helmeted = true
            };

            var legs = new AstronautLegs
            {
                HasPants = true,
                Shoes = ShoeType.FlipFlops
            };

            var torso = new AstronautTorso
            {
                HandType = HandType.Baby,
                ChiseledAbs = true,
                NumberOfArms = 3,
                Shirted = true
            };

            var astronaut = new Astronaut("Space Person", "Janitor", head, torso, legs);
            var astronaut2 = new Astronaut("Space Lady", "Janitor", head, torso, legs);

            astronaut.DoYourJob();

            var casper = new Ghost("Casper", DateTime.Today)
            {
                Friendly = true
            };

            casper.Spook();
            casper.Haunt("Whipstaff Manor");
            casper.Spook();

            var fatso = new Ghost("Fatso", new DateTime(1924,12,1))
            {
                Friendly = false
            };

            fatso.Spook();
            fatso.Haunt("Whipstaff Manor");
            fatso.Spook();
        }
    }
}
