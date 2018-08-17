// ReSharper disable All

namespace Rdatasets.vcd
{
    using System.Collections.Generic;

    /// <summary>
    /// 'May' in Federalist Papers
    /// </summary>

    public class Federalist
    {
        public readonly int nMay;
        public readonly int Freq;

        public Federalist(int nMay, int Freq)
        {
            this.nMay = nMay;
            this.Freq = Freq;
        }

        public static IEnumerable<Federalist> Data
        {
            get
            {
                yield return new Federalist(0, 156);
                yield return new Federalist(1, 63);
                yield return new Federalist(2, 29);
                yield return new Federalist(3, 8);
                yield return new Federalist(4, 4);
                yield return new Federalist(5, 1);
                yield return new Federalist(6, 1);
            }
        }
    }
}
