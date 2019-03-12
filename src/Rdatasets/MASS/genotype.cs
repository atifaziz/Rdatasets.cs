// ReSharper disable All

namespace Rdatasets.MASS
{
    using System.Collections.Generic;

    /// <summary>
    /// Rat Genotype Data
    /// </summary>

    public class genotype
    {
        public readonly int κ;
        public readonly string Litter;
        public readonly string Mother;
        public readonly double Wt;

        public genotype(int κ, string Litter, string Mother, double Wt)
        {
            this.κ = κ;
            this.Litter = Litter;
            this.Mother = Mother;
            this.Wt = Wt;
        }

        public static IEnumerable<genotype> Data
        {
            get
            {
                yield return new genotype(1, "A", "A", 61.5);
                yield return new genotype(2, "A", "A", 68.2);
                yield return new genotype(3, "A", "A", 64);
                yield return new genotype(4, "A", "A", 65);
                yield return new genotype(5, "A", "A", 59.7);
                yield return new genotype(6, "A", "B", 55);
                yield return new genotype(7, "A", "B", 42);
                yield return new genotype(8, "A", "B", 60.2);
                yield return new genotype(9, "A", "I", 52.5);
                yield return new genotype(10, "A", "I", 61.8);
                yield return new genotype(11, "A", "I", 49.5);
                yield return new genotype(12, "A", "I", 52.7);
                yield return new genotype(13, "A", "J", 42);
                yield return new genotype(14, "A", "J", 54);
                yield return new genotype(15, "A", "J", 61);
                yield return new genotype(16, "A", "J", 48.2);
                yield return new genotype(17, "A", "J", 39.6);
                yield return new genotype(18, "B", "A", 60.3);
                yield return new genotype(19, "B", "A", 51.7);
                yield return new genotype(20, "B", "A", 49.3);
                yield return new genotype(21, "B", "A", 48);
                yield return new genotype(22, "B", "B", 50.8);
                yield return new genotype(23, "B", "B", 64.7);
                yield return new genotype(24, "B", "B", 61.7);
                yield return new genotype(25, "B", "B", 64);
                yield return new genotype(26, "B", "B", 62);
                yield return new genotype(27, "B", "I", 56.5);
                yield return new genotype(28, "B", "I", 59);
                yield return new genotype(29, "B", "I", 47.2);
                yield return new genotype(30, "B", "I", 53);
                yield return new genotype(31, "B", "J", 51.3);
                yield return new genotype(32, "B", "J", 40.5);
                yield return new genotype(33, "I", "A", 37);
                yield return new genotype(34, "I", "A", 36.3);
                yield return new genotype(35, "I", "A", 68);
                yield return new genotype(36, "I", "B", 56.3);
                yield return new genotype(37, "I", "B", 69.8);
                yield return new genotype(38, "I", "B", 67);
                yield return new genotype(39, "I", "I", 39.7);
                yield return new genotype(40, "I", "I", 46);
                yield return new genotype(41, "I", "I", 61.3);
                yield return new genotype(42, "I", "I", 55.3);
                yield return new genotype(43, "I", "I", 55.7);
                yield return new genotype(44, "I", "J", 50);
                yield return new genotype(45, "I", "J", 43.8);
                yield return new genotype(46, "I", "J", 54.5);
                yield return new genotype(47, "J", "A", 59);
                yield return new genotype(48, "J", "A", 57.4);
                yield return new genotype(49, "J", "A", 54);
                yield return new genotype(50, "J", "A", 47);
                yield return new genotype(51, "J", "B", 59.5);
                yield return new genotype(52, "J", "B", 52.8);
                yield return new genotype(53, "J", "B", 56);
                yield return new genotype(54, "J", "I", 45.2);
                yield return new genotype(55, "J", "I", 57);
                yield return new genotype(56, "J", "I", 61.4);
                yield return new genotype(57, "J", "J", 44.8);
                yield return new genotype(58, "J", "J", 51.5);
                yield return new genotype(59, "J", "J", 53);
                yield return new genotype(60, "J", "J", 42);
                yield return new genotype(61, "J", "J", 54);
            }
        }
    }
}
