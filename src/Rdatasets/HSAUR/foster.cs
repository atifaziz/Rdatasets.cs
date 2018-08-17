// ReSharper disable All

namespace Rdatasets.HSAUR
{
    using System.Collections.Generic;

    /// <summary>
    /// Foster Feeding Experiment
    /// </summary>

    public class foster
    {
        public readonly string litgen;
        public readonly string motgen;
        public readonly double weight;

        public foster(string litgen, string motgen, double weight)
        {
            this.litgen = litgen;
            this.motgen = motgen;
            this.weight = weight;
        }

        public static IEnumerable<foster> Data
        {
            get
            {
                yield return new foster("A", "A", 61.5);
                yield return new foster("A", "A", 68.2);
                yield return new foster("A", "A", 64);
                yield return new foster("A", "A", 65);
                yield return new foster("A", "A", 59.7);
                yield return new foster("A", "B", 55);
                yield return new foster("A", "B", 42);
                yield return new foster("A", "B", 60.2);
                yield return new foster("A", "I", 52.5);
                yield return new foster("A", "I", 61.8);
                yield return new foster("A", "I", 49.5);
                yield return new foster("A", "I", 52.7);
                yield return new foster("A", "J", 42);
                yield return new foster("A", "J", 54);
                yield return new foster("A", "J", 61);
                yield return new foster("A", "J", 48.2);
                yield return new foster("A", "J", 39.6);
                yield return new foster("B", "A", 60.3);
                yield return new foster("B", "A", 51.7);
                yield return new foster("B", "A", 49.3);
                yield return new foster("B", "A", 48);
                yield return new foster("B", "B", 50.8);
                yield return new foster("B", "B", 64.7);
                yield return new foster("B", "B", 61.7);
                yield return new foster("B", "B", 64);
                yield return new foster("B", "B", 62);
                yield return new foster("B", "I", 56.5);
                yield return new foster("B", "I", 59);
                yield return new foster("B", "I", 47.2);
                yield return new foster("B", "I", 53);
                yield return new foster("B", "J", 51.3);
                yield return new foster("B", "J", 40.5);
                yield return new foster("I", "A", 37);
                yield return new foster("I", "A", 36.3);
                yield return new foster("I", "A", 68);
                yield return new foster("I", "B", 56.3);
                yield return new foster("I", "B", 69.8);
                yield return new foster("I", "B", 67);
                yield return new foster("I", "I", 39.7);
                yield return new foster("I", "I", 46);
                yield return new foster("I", "I", 61.3);
                yield return new foster("I", "I", 55.3);
                yield return new foster("I", "I", 55.7);
                yield return new foster("I", "J", 50);
                yield return new foster("I", "J", 43.8);
                yield return new foster("I", "J", 54.5);
                yield return new foster("J", "A", 59);
                yield return new foster("J", "A", 57.4);
                yield return new foster("J", "A", 54);
                yield return new foster("J", "A", 47);
                yield return new foster("J", "B", 59.5);
                yield return new foster("J", "B", 52.8);
                yield return new foster("J", "B", 56);
                yield return new foster("J", "I", 45.2);
                yield return new foster("J", "I", 57);
                yield return new foster("J", "I", 61.4);
                yield return new foster("J", "J", 44.8);
                yield return new foster("J", "J", 51.5);
                yield return new foster("J", "J", 53);
                yield return new foster("J", "J", 42);
                yield return new foster("J", "J", 54);
            }
        }
    }
}
