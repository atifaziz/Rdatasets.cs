// ReSharper disable All

namespace Rdatasets.HSAUR
{
    using System.Collections.Generic;

    /// <summary>
    /// Foster Feeding Experiment
    /// </summary>

    public class foster
    {
        public readonly int κ;
        public readonly string litgen;
        public readonly string motgen;
        public readonly double weight;

        public foster(int κ, string litgen, string motgen, double weight)
        {
            this.κ = κ;
            this.litgen = litgen;
            this.motgen = motgen;
            this.weight = weight;
        }

        public static IEnumerable<foster> Data
        {
            get
            {
                yield return new foster(1, "A", "A", 61.5);
                yield return new foster(2, "A", "A", 68.2);
                yield return new foster(3, "A", "A", 64);
                yield return new foster(4, "A", "A", 65);
                yield return new foster(5, "A", "A", 59.7);
                yield return new foster(6, "A", "B", 55);
                yield return new foster(7, "A", "B", 42);
                yield return new foster(8, "A", "B", 60.2);
                yield return new foster(9, "A", "I", 52.5);
                yield return new foster(10, "A", "I", 61.8);
                yield return new foster(11, "A", "I", 49.5);
                yield return new foster(12, "A", "I", 52.7);
                yield return new foster(13, "A", "J", 42);
                yield return new foster(14, "A", "J", 54);
                yield return new foster(15, "A", "J", 61);
                yield return new foster(16, "A", "J", 48.2);
                yield return new foster(17, "A", "J", 39.6);
                yield return new foster(18, "B", "A", 60.3);
                yield return new foster(19, "B", "A", 51.7);
                yield return new foster(20, "B", "A", 49.3);
                yield return new foster(21, "B", "A", 48);
                yield return new foster(22, "B", "B", 50.8);
                yield return new foster(23, "B", "B", 64.7);
                yield return new foster(24, "B", "B", 61.7);
                yield return new foster(25, "B", "B", 64);
                yield return new foster(26, "B", "B", 62);
                yield return new foster(27, "B", "I", 56.5);
                yield return new foster(28, "B", "I", 59);
                yield return new foster(29, "B", "I", 47.2);
                yield return new foster(30, "B", "I", 53);
                yield return new foster(31, "B", "J", 51.3);
                yield return new foster(32, "B", "J", 40.5);
                yield return new foster(33, "I", "A", 37);
                yield return new foster(34, "I", "A", 36.3);
                yield return new foster(35, "I", "A", 68);
                yield return new foster(36, "I", "B", 56.3);
                yield return new foster(37, "I", "B", 69.8);
                yield return new foster(38, "I", "B", 67);
                yield return new foster(39, "I", "I", 39.7);
                yield return new foster(40, "I", "I", 46);
                yield return new foster(41, "I", "I", 61.3);
                yield return new foster(42, "I", "I", 55.3);
                yield return new foster(43, "I", "I", 55.7);
                yield return new foster(44, "I", "J", 50);
                yield return new foster(45, "I", "J", 43.8);
                yield return new foster(46, "I", "J", 54.5);
                yield return new foster(47, "J", "A", 59);
                yield return new foster(48, "J", "A", 57.4);
                yield return new foster(49, "J", "A", 54);
                yield return new foster(50, "J", "A", 47);
                yield return new foster(51, "J", "B", 59.5);
                yield return new foster(52, "J", "B", 52.8);
                yield return new foster(53, "J", "B", 56);
                yield return new foster(54, "J", "I", 45.2);
                yield return new foster(55, "J", "I", 57);
                yield return new foster(56, "J", "I", 61.4);
                yield return new foster(57, "J", "J", 44.8);
                yield return new foster(58, "J", "J", 51.5);
                yield return new foster(59, "J", "J", 53);
                yield return new foster(60, "J", "J", 42);
                yield return new foster(61, "J", "J", 54);
            }
        }
    }
}
