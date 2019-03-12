// ReSharper disable All

namespace Rdatasets.Ecdat
{
    using System.Collections.Generic;

    /// <summary>
    /// The Longley Data
    /// </summary>

    public class Longley
    {
        public readonly int κ;
        public readonly int employ;
        public readonly double price;
        public readonly int gnp;
        public readonly int armed;

        public Longley(int κ, int employ, double price, int gnp, int armed)
        {
            this.κ = κ;
            this.employ = employ;
            this.price = price;
            this.gnp = gnp;
            this.armed = armed;
        }

        public static IEnumerable<Longley> Data
        {
            get
            {
                yield return new Longley(1, 60323, 83, 234289, 1590);
                yield return new Longley(2, 61122, 88.5, 259426, 1456);
                yield return new Longley(3, 60171, 88.2, 258054, 1616);
                yield return new Longley(4, 61187, 89.5, 284599, 1650);
                yield return new Longley(5, 63221, 96.2, 328975, 3099);
                yield return new Longley(6, 63639, 98.1, 346999, 3594);
                yield return new Longley(7, 64989, 99, 365385, 3547);
                yield return new Longley(8, 63761, 100, 363112, 3350);
                yield return new Longley(9, 66019, 101.2, 397469, 3048);
                yield return new Longley(10, 67857, 104.6, 419180, 2857);
                yield return new Longley(11, 68169, 108.4, 442769, 2798);
                yield return new Longley(12, 66513, 110.8, 444546, 2637);
                yield return new Longley(13, 68655, 112.6, 482704, 2552);
                yield return new Longley(14, 69564, 114.2, 502601, 2514);
                yield return new Longley(15, 69331, 115.7, 518173, 2572);
                yield return new Longley(16, 70551, 116.9, 554894, 2827);
            }
        }
    }
}
