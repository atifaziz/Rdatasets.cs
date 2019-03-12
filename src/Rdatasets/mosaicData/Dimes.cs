// ReSharper disable All

namespace Rdatasets.mosaicData
{
    using System.Collections.Generic;

    /// <summary>
    /// Weight of dimes
    /// </summary>

    public class Dimes
    {
        public readonly int κ;
        public readonly double mass;
        public readonly int year;

        public Dimes(int κ, double mass, int year)
        {
            this.κ = κ;
            this.mass = mass;
            this.year = year;
        }

        public static IEnumerable<Dimes> Data
        {
            get
            {
                yield return new Dimes(1, 2.259, 2004);
                yield return new Dimes(2, 2.247, 2004);
                yield return new Dimes(3, 2.254, 1987);
                yield return new Dimes(4, 2.298, 1988);
                yield return new Dimes(5, 2.287, 1971);
                yield return new Dimes(6, 2.254, 2007);
                yield return new Dimes(7, 2.268, 2007);
                yield return new Dimes(8, 2.214, 1974);
                yield return new Dimes(9, 2.268, 2007);
                yield return new Dimes(10, 2.274, 2004);
                yield return new Dimes(11, 2.271, 1997);
                yield return new Dimes(12, 2.268, 1994);
                yield return new Dimes(13, 2.298, 1974);
                yield return new Dimes(14, 2.292, 1996);
                yield return new Dimes(15, 2.274, 1999);
                yield return new Dimes(16, 2.234, 1993);
                yield return new Dimes(17, 2.238, 1998);
                yield return new Dimes(18, 2.252, 2000);
                yield return new Dimes(19, 2.249, 2007);
                yield return new Dimes(20, 2.234, 2001);
                yield return new Dimes(21, 2.275, 1994);
                yield return new Dimes(22, 2.23, 1972);
                yield return new Dimes(23, 2.236, 1992);
                yield return new Dimes(24, 2.233, 1970);
                yield return new Dimes(25, 2.255, 2001);
                yield return new Dimes(26, 2.277, 2001);
                yield return new Dimes(27, 2.256, 2004);
                yield return new Dimes(28, 2.282, 2001);
                yield return new Dimes(29, 2.235, 2001);
                yield return new Dimes(30, 2.235, 2002);
            }
        }
    }
}
