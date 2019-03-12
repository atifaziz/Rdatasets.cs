// ReSharper disable All

namespace Rdatasets.MASS
{
    using System.Collections.Generic;

    /// <summary>
    /// Brain and Body Weights for 62 Species of Land Mammals
    /// </summary>

    public class mammals
    {
        public readonly string κ;
        public readonly double body;
        public readonly double brain;

        public mammals(string κ, double body, double brain)
        {
            this.κ = κ;
            this.body = body;
            this.brain = brain;
        }

        public static IEnumerable<mammals> Data
        {
            get
            {
                yield return new mammals("Arctic fox", 3.385, 44.5);
                yield return new mammals("Owl monkey", 0.48, 15.5);
                yield return new mammals("Mountain beaver", 1.35, 8.1);
                yield return new mammals("Cow", 465, 423);
                yield return new mammals("Grey wolf", 36.33, 119.5);
                yield return new mammals("Goat", 27.66, 115);
                yield return new mammals("Roe deer", 14.83, 98.2);
                yield return new mammals("Guinea pig", 1.04, 5.5);
                yield return new mammals("Verbet", 4.19, 58);
                yield return new mammals("Chinchilla", 0.425, 6.4);
                yield return new mammals("Ground squirrel", 0.101, 4);
                yield return new mammals("Arctic ground squirrel", 0.92, 5.7);
                yield return new mammals("African giant pouched rat", 1, 6.6);
                yield return new mammals("Lesser short-tailed shrew", 0.005, 0.14);
                yield return new mammals("Star-nosed mole", 0.06, 1);
                yield return new mammals("Nine-banded armadillo", 3.5, 10.8);
                yield return new mammals("Tree hyrax", 2, 12.3);
                yield return new mammals("N.A. opossum", 1.7, 6.3);
                yield return new mammals("Asian elephant", 2547, 4603);
                yield return new mammals("Big brown bat", 0.023, 0.3);
                yield return new mammals("Donkey", 187.1, 419);
                yield return new mammals("Horse", 521, 655);
                yield return new mammals("European hedgehog", 0.785, 3.5);
                yield return new mammals("Patas monkey", 10, 115);
                yield return new mammals("Cat", 3.3, 25.6);
                yield return new mammals("Galago", 0.2, 5);
                yield return new mammals("Genet", 1.41, 17.5);
                yield return new mammals("Giraffe", 529, 680);
                yield return new mammals("Gorilla", 207, 406);
                yield return new mammals("Grey seal", 85, 325);
                yield return new mammals("Rock hyrax-a", 0.75, 12.3);
                yield return new mammals("Human", 62, 1320);
                yield return new mammals("African elephant", 6654, 5712);
                yield return new mammals("Water opossum", 3.5, 3.9);
                yield return new mammals("Rhesus monkey", 6.8, 179);
                yield return new mammals("Kangaroo", 35, 56);
                yield return new mammals("Yellow-bellied marmot", 4.05, 17);
                yield return new mammals("Golden hamster", 0.12, 1);
                yield return new mammals("Mouse", 0.023, 0.4);
                yield return new mammals("Little brown bat", 0.01, 0.25);
                yield return new mammals("Slow loris", 1.4, 12.5);
                yield return new mammals("Okapi", 250, 490);
                yield return new mammals("Rabbit", 2.5, 12.1);
                yield return new mammals("Sheep", 55.5, 175);
                yield return new mammals("Jaguar", 100, 157);
                yield return new mammals("Chimpanzee", 52.16, 440);
                yield return new mammals("Baboon", 10.55, 179.5);
                yield return new mammals("Desert hedgehog", 0.55, 2.4);
                yield return new mammals("Giant armadillo", 60, 81);
                yield return new mammals("Rock hyrax-b", 3.6, 21);
                yield return new mammals("Raccoon", 4.288, 39.2);
                yield return new mammals("Rat", 0.28, 1.9);
                yield return new mammals("E. American mole", 0.075, 1.2);
                yield return new mammals("Mole rat", 0.122, 3);
                yield return new mammals("Musk shrew", 0.048, 0.33);
                yield return new mammals("Pig", 192, 180);
                yield return new mammals("Echidna", 3, 25);
                yield return new mammals("Brazilian tapir", 160, 169);
                yield return new mammals("Tenrec", 0.9, 2.6);
                yield return new mammals("Phalanger", 1.62, 11.4);
                yield return new mammals("Tree shrew", 0.104, 2.5);
                yield return new mammals("Red fox", 4.235, 50.4);
            }
        }
    }
}
