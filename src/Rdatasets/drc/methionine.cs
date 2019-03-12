// ReSharper disable All

namespace Rdatasets.drc
{
    using System.Collections.Generic;

    /// <summary>
    /// Weight gain for different methionine sources
    /// </summary>

    public class methionine
    {
        public readonly int κ;
        public readonly string product;
        public readonly double dose;
        public readonly int gain;

        public methionine(int κ, string product, double dose, int gain)
        {
            this.κ = κ;
            this.product = product;
            this.dose = dose;
            this.gain = gain;
        }

        public static IEnumerable<methionine> Data
        {
            get
            {
                yield return new methionine(1, "control", 0, 1453);
                yield return new methionine(2, "DLM", 0.04, 1593);
                yield return new methionine(3, "DLM", 0.09, 1660);
                yield return new methionine(4, "DLM", 0.15, 1666);
                yield return new methionine(5, "DLM", 0.22, 1698);
                yield return new methionine(7, "MHA", 0.04, 1561);
                yield return new methionine(8, "MHA", 0.09, 1633);
                yield return new methionine(9, "MHA", 0.15, 1704);
                yield return new methionine(10, "MHA", 0.22, 1722);
            }
        }
    }
}
