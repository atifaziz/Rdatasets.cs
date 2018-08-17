// ReSharper disable All

namespace Rdatasets.MASS
{
    using System.Collections.Generic;

    /// <summary>
    /// DDT in Kale
    /// </summary>

    public class DDT
    {
        public readonly double dat;

        public DDT(double dat)
        {
            this.dat = dat;
        }

        public static IEnumerable<DDT> Data
        {
            get
            {
                yield return new DDT(2.79);
                yield return new DDT(2.93);
                yield return new DDT(3.22);
                yield return new DDT(3.78);
                yield return new DDT(3.22);
                yield return new DDT(3.38);
                yield return new DDT(3.18);
                yield return new DDT(3.33);
                yield return new DDT(3.34);
                yield return new DDT(3.06);
                yield return new DDT(3.07);
                yield return new DDT(3.56);
                yield return new DDT(3.08);
                yield return new DDT(4.64);
                yield return new DDT(3.34);
            }
        }
    }
}
