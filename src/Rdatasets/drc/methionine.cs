// ReSharper disable All

namespace Rdatasets.drc
{
    using System.Collections.Generic;

    /// <summary>
    /// Weight gain for different methionine sources
    /// </summary>

    public class methionine
    {
        public readonly string product;
        public readonly double dose;
        public readonly int gain;

        public methionine(string product, double dose, int gain)
        {
            this.product = product;
            this.dose = dose;
            this.gain = gain;
        }

        public static IEnumerable<methionine> Data
        {
            get
            {
                yield return new methionine("control", 0, 1453);
                yield return new methionine("DLM", 0.04, 1593);
                yield return new methionine("DLM", 0.09, 1660);
                yield return new methionine("DLM", 0.15, 1666);
                yield return new methionine("DLM", 0.22, 1698);
                yield return new methionine("MHA", 0.04, 1561);
                yield return new methionine("MHA", 0.09, 1633);
                yield return new methionine("MHA", 0.15, 1704);
                yield return new methionine("MHA", 0.22, 1722);
            }
        }
    }
}
