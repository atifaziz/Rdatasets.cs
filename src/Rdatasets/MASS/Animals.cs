// ReSharper disable All

namespace Rdatasets.MASS
{
    using System.Collections.Generic;

    /// <summary>
    /// Brain and Body Weights for 28 Species
    /// </summary>

    public class Animals
    {
        public readonly string κ;
        public readonly double body;
        public readonly double brain;

        public Animals(string κ, double body, double brain)
        {
            this.κ = κ;
            this.body = body;
            this.brain = brain;
        }

        public static IEnumerable<Animals> Data
        {
            get
            {
                yield return new Animals("Mountain beaver", 1.35, 8.1);
                yield return new Animals("Cow", 465, 423);
                yield return new Animals("Grey wolf", 36.33, 119.5);
                yield return new Animals("Goat", 27.66, 115);
                yield return new Animals("Guinea pig", 1.04, 5.5);
                yield return new Animals("Dipliodocus", 11700, 50);
                yield return new Animals("Asian elephant", 2547, 4603);
                yield return new Animals("Donkey", 187.1, 419);
                yield return new Animals("Horse", 521, 655);
                yield return new Animals("Potar monkey", 10, 115);
                yield return new Animals("Cat", 3.3, 25.6);
                yield return new Animals("Giraffe", 529, 680);
                yield return new Animals("Gorilla", 207, 406);
                yield return new Animals("Human", 62, 1320);
                yield return new Animals("African elephant", 6654, 5712);
                yield return new Animals("Triceratops", 9400, 70);
                yield return new Animals("Rhesus monkey", 6.8, 179);
                yield return new Animals("Kangaroo", 35, 56);
                yield return new Animals("Golden hamster", 0.12, 1);
                yield return new Animals("Mouse", 0.023, 0.4);
                yield return new Animals("Rabbit", 2.5, 12.1);
                yield return new Animals("Sheep", 55.5, 175);
                yield return new Animals("Jaguar", 100, 157);
                yield return new Animals("Chimpanzee", 52.16, 440);
                yield return new Animals("Rat", 0.28, 1.9);
                yield return new Animals("Brachiosaurus", 87000, 154.5);
                yield return new Animals("Mole", 0.122, 3);
                yield return new Animals("Pig", 192, 180);
            }
        }
    }
}
