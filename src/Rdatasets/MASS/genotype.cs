// ReSharper disable All

namespace Rdatasets.MASS
{
    using System.Collections.Generic;

    /// <summary>
    /// Rat Genotype Data
    /// </summary>

    public class genotype
    {
        public readonly string Litter;
        public readonly string Mother;
        public readonly double Wt;

        public genotype(string Litter, string Mother, double Wt)
        {
            this.Litter = Litter;
            this.Mother = Mother;
            this.Wt = Wt;
        }

        public static IEnumerable<genotype> Data
        {
            get
            {
                yield return new genotype("A", "A", 61.5);
                yield return new genotype("A", "A", 68.2);
                yield return new genotype("A", "A", 64);
                yield return new genotype("A", "A", 65);
                yield return new genotype("A", "A", 59.7);
                yield return new genotype("A", "B", 55);
                yield return new genotype("A", "B", 42);
                yield return new genotype("A", "B", 60.2);
                yield return new genotype("A", "I", 52.5);
                yield return new genotype("A", "I", 61.8);
                yield return new genotype("A", "I", 49.5);
                yield return new genotype("A", "I", 52.7);
                yield return new genotype("A", "J", 42);
                yield return new genotype("A", "J", 54);
                yield return new genotype("A", "J", 61);
                yield return new genotype("A", "J", 48.2);
                yield return new genotype("A", "J", 39.6);
                yield return new genotype("B", "A", 60.3);
                yield return new genotype("B", "A", 51.7);
                yield return new genotype("B", "A", 49.3);
                yield return new genotype("B", "A", 48);
                yield return new genotype("B", "B", 50.8);
                yield return new genotype("B", "B", 64.7);
                yield return new genotype("B", "B", 61.7);
                yield return new genotype("B", "B", 64);
                yield return new genotype("B", "B", 62);
                yield return new genotype("B", "I", 56.5);
                yield return new genotype("B", "I", 59);
                yield return new genotype("B", "I", 47.2);
                yield return new genotype("B", "I", 53);
                yield return new genotype("B", "J", 51.3);
                yield return new genotype("B", "J", 40.5);
                yield return new genotype("I", "A", 37);
                yield return new genotype("I", "A", 36.3);
                yield return new genotype("I", "A", 68);
                yield return new genotype("I", "B", 56.3);
                yield return new genotype("I", "B", 69.8);
                yield return new genotype("I", "B", 67);
                yield return new genotype("I", "I", 39.7);
                yield return new genotype("I", "I", 46);
                yield return new genotype("I", "I", 61.3);
                yield return new genotype("I", "I", 55.3);
                yield return new genotype("I", "I", 55.7);
                yield return new genotype("I", "J", 50);
                yield return new genotype("I", "J", 43.8);
                yield return new genotype("I", "J", 54.5);
                yield return new genotype("J", "A", 59);
                yield return new genotype("J", "A", 57.4);
                yield return new genotype("J", "A", 54);
                yield return new genotype("J", "A", 47);
                yield return new genotype("J", "B", 59.5);
                yield return new genotype("J", "B", 52.8);
                yield return new genotype("J", "B", 56);
                yield return new genotype("J", "I", 45.2);
                yield return new genotype("J", "I", 57);
                yield return new genotype("J", "I", 61.4);
                yield return new genotype("J", "J", 44.8);
                yield return new genotype("J", "J", 51.5);
                yield return new genotype("J", "J", 53);
                yield return new genotype("J", "J", 42);
                yield return new genotype("J", "J", 54);
            }
        }
    }
}
