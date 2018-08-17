// ReSharper disable All

namespace Rdatasets.vcd
{
    using System.Collections.Generic;

    /// <summary>
    /// Families in Saxony
    /// </summary>

    public class Saxony
    {
        public readonly int nMales;
        public readonly int Freq;

        public Saxony(int nMales, int Freq)
        {
            this.nMales = nMales;
            this.Freq = Freq;
        }

        public static IEnumerable<Saxony> Data
        {
            get
            {
                yield return new Saxony(0, 3);
                yield return new Saxony(1, 24);
                yield return new Saxony(2, 104);
                yield return new Saxony(3, 286);
                yield return new Saxony(4, 670);
                yield return new Saxony(5, 1033);
                yield return new Saxony(6, 1343);
                yield return new Saxony(7, 1112);
                yield return new Saxony(8, 829);
                yield return new Saxony(9, 478);
                yield return new Saxony(10, 181);
                yield return new Saxony(11, 45);
                yield return new Saxony(12, 7);
            }
        }
    }
}
