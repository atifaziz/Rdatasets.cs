// ReSharper disable All

namespace Rdatasets.mosaicData
{
    using System.Collections.Generic;

    /// <summary>
    /// Weight of dimes
    /// </summary>

    public class Dimes
    {
        public readonly double mass;
        public readonly int year;

        public Dimes(double mass, int year)
        {
            this.mass = mass;
            this.year = year;
        }

        public static IEnumerable<Dimes> Data
        {
            get
            {
                yield return new Dimes(2.259, 2004);
                yield return new Dimes(2.247, 2004);
                yield return new Dimes(2.254, 1987);
                yield return new Dimes(2.298, 1988);
                yield return new Dimes(2.287, 1971);
                yield return new Dimes(2.254, 2007);
                yield return new Dimes(2.268, 2007);
                yield return new Dimes(2.214, 1974);
                yield return new Dimes(2.268, 2007);
                yield return new Dimes(2.274, 2004);
                yield return new Dimes(2.271, 1997);
                yield return new Dimes(2.268, 1994);
                yield return new Dimes(2.298, 1974);
                yield return new Dimes(2.292, 1996);
                yield return new Dimes(2.274, 1999);
                yield return new Dimes(2.234, 1993);
                yield return new Dimes(2.238, 1998);
                yield return new Dimes(2.252, 2000);
                yield return new Dimes(2.249, 2007);
                yield return new Dimes(2.234, 2001);
                yield return new Dimes(2.275, 1994);
                yield return new Dimes(2.23, 1972);
                yield return new Dimes(2.236, 1992);
                yield return new Dimes(2.233, 1970);
                yield return new Dimes(2.255, 2001);
                yield return new Dimes(2.277, 2001);
                yield return new Dimes(2.256, 2004);
                yield return new Dimes(2.282, 2001);
                yield return new Dimes(2.235, 2001);
                yield return new Dimes(2.235, 2002);
            }
        }
    }
}
