using System;

namespace diceroller
{
    public class Die
    {
        public Die(int sides)
        {
            if (sides < 1)
                throw new ArgumentException(
                    nameof(sides), 
                    "Must be at least one or more."
                );

            Sides = sides;
        }

        public int Sides { get; set; }
    }
}