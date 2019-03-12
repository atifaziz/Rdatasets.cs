// ReSharper disable All

namespace Rdatasets.vcd
{
    using System.Collections.Generic;

    /// <summary>
    /// 'May' in Federalist Papers
    /// </summary>

    public class Federalist
    {
        public readonly int κ;
        public readonly int nMay;
        public readonly int Freq;

        public Federalist(int κ, int nMay, int Freq)
        {
            this.κ = κ;
            this.nMay = nMay;
            this.Freq = Freq;
        }

        public static IEnumerable<Federalist> Data
        {
            get
            {
                yield return new Federalist(1, 0, 156);
                yield return new Federalist(2, 1, 63);
                yield return new Federalist(3, 2, 29);
                yield return new Federalist(4, 3, 8);
                yield return new Federalist(5, 4, 4);
                yield return new Federalist(6, 5, 1);
                yield return new Federalist(7, 6, 1);
            }
        }
    }
}
