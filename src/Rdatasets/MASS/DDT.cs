// ReSharper disable All

namespace Rdatasets.MASS
{
    using System.Collections.Generic;

    /// <summary>
    /// DDT in Kale
    /// </summary>

    public class DDT
    {
        public readonly int κ;
        public readonly double dat;

        public DDT(int κ, double dat)
        {
            this.κ = κ;
            this.dat = dat;
        }

        public static IEnumerable<DDT> Data
        {
            get
            {
                yield return new DDT(1, 2.79);
                yield return new DDT(2, 2.93);
                yield return new DDT(3, 3.22);
                yield return new DDT(4, 3.78);
                yield return new DDT(5, 3.22);
                yield return new DDT(6, 3.38);
                yield return new DDT(7, 3.18);
                yield return new DDT(8, 3.33);
                yield return new DDT(9, 3.34);
                yield return new DDT(10, 3.06);
                yield return new DDT(11, 3.07);
                yield return new DDT(12, 3.56);
                yield return new DDT(13, 3.08);
                yield return new DDT(14, 4.64);
                yield return new DDT(15, 3.34);
            }
        }
    }
}
