// ReSharper disable All

namespace Rdatasets.robustbase
{
    using System.Collections.Generic;

    /// <summary>
    /// Brain and Body Weights for 65 Species of Land Animals
    /// </summary>

    public class Animals2
    {
        public readonly string κ;
        public readonly double body;
        public readonly double brain;

        public Animals2(string κ, double body, double brain)
        {
            this.κ = κ;
            this.body = body;
            this.brain = brain;
        }

        public static IEnumerable<Animals2> Data
        {
            get
            {
                yield return new Animals2("Mountain beaver", 1.35, 8.1);
                yield return new Animals2("Cow", 465, 423);
                yield return new Animals2("Grey wolf", 36.33, 119.5);
                yield return new Animals2("Goat", 27.66, 115);
                yield return new Animals2("Guinea pig", 1.04, 5.5);
                yield return new Animals2("Dipliodocus", 11700, 50);
                yield return new Animals2("Asian elephant", 2547, 4603);
                yield return new Animals2("Donkey", 187.1, 419);
                yield return new Animals2("Horse", 521, 655);
                yield return new Animals2("Potar monkey", 10, 115);
                yield return new Animals2("Cat", 3.3, 25.6);
                yield return new Animals2("Giraffe", 529, 680);
                yield return new Animals2("Gorilla", 207, 406);
                yield return new Animals2("Human", 62, 1320);
                yield return new Animals2("African elephant", 6654, 5712);
                yield return new Animals2("Triceratops", 9400, 70);
                yield return new Animals2("Rhesus monkey", 6.8, 179);
                yield return new Animals2("Kangaroo", 35, 56);
                yield return new Animals2("Golden hamster", 0.12, 1);
                yield return new Animals2("Mouse", 0.023, 0.4);
                yield return new Animals2("Rabbit", 2.5, 12.1);
                yield return new Animals2("Sheep", 55.5, 175);
                yield return new Animals2("Jaguar", 100, 157);
                yield return new Animals2("Chimpanzee", 52.16, 440);
                yield return new Animals2("Rat", 0.28, 1.9);
                yield return new Animals2("Brachiosaurus", 87000, 154.5);
                yield return new Animals2("Mole", 0.122, 3);
                yield return new Animals2("Pig", 192, 180);
                yield return new Animals2("Artic fox", 3.385, 44.5);
                yield return new Animals2("Owl monkey", 0.48, 15.5);
                yield return new Animals2("Roe deer", 14.83, 98.2);
                yield return new Animals2("Verbet", 4.19, 58);
                yield return new Animals2("Chinchilla", 0.425, 6.4);
                yield return new Animals2("Ground squirrel", 0.101, 4);
                yield return new Animals2("Artic ground squirrel", 0.92, 5.7);
                yield return new Animals2("African giant pouched rat", 1, 6.6);
                yield return new Animals2("Lesser short-tailed shrew", 0.005, 0.14);
                yield return new Animals2("Star-nosed mole", 0.06, 1);
                yield return new Animals2("Nine-banded armadillo", 3.5, 10.8);
                yield return new Animals2("Tree hyrax", 2, 12.3);
                yield return new Animals2("N.A. opossum", 1.7, 6.3);
                yield return new Animals2("Big brown bat", 0.023, 0.3);
                yield return new Animals2("European hedgehog", 0.785, 3.5);
                yield return new Animals2("Galago", 0.2, 5);
                yield return new Animals2("Genet", 1.41, 17.5);
                yield return new Animals2("Grey seal", 85, 325);
                yield return new Animals2("Rock hyrax-a", 0.75, 12.3);
                yield return new Animals2("Water opossum", 3.5, 3.9);
                yield return new Animals2("Yellow-bellied marmot", 4.05, 17);
                yield return new Animals2("Little brown bat", 0.01, 0.25);
                yield return new Animals2("Slow loris", 1.4, 12.5);
                yield return new Animals2("Okapi", 250, 490);
                yield return new Animals2("Baboon", 10.55, 179.5);
                yield return new Animals2("Desert hedgehog", 0.55, 2.4);
                yield return new Animals2("Giant armadillo", 60, 81);
                yield return new Animals2("Rock hyrax-b", 3.6, 21);
                yield return new Animals2("Raccoon", 4.288, 39.2);
                yield return new Animals2("E. American mole", 0.075, 1.2);
                yield return new Animals2("Musk shrew", 0.048, 0.33);
                yield return new Animals2("Echidna", 3, 25);
                yield return new Animals2("Brazilian tapir", 160, 169);
                yield return new Animals2("Tenrec", 0.9, 2.6);
                yield return new Animals2("Phalanger", 1.62, 11.4);
                yield return new Animals2("Tree shrew", 0.104, 2.5);
                yield return new Animals2("Red fox", 4.235, 50.4);
            }
        }
    }
}
