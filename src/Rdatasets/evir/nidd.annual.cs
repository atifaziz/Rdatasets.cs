// ReSharper disable All

namespace Rdatasets.evir
{
    using System.Collections.Generic;

    /// <summary>
    /// The River Nidd Data
    /// </summary>

    public class nidd_annual
    {
        public readonly int κ;
        public readonly double dat;

        public nidd_annual(int κ, double dat)
        {
            this.κ = κ;
            this.dat = dat;
        }

        public static IEnumerable<nidd_annual> Data
        {
            get
            {
                yield return new nidd_annual(1, 65.08);
                yield return new nidd_annual(2, 65.6);
                yield return new nidd_annual(3, 75.06);
                yield return new nidd_annual(4, 76.22);
                yield return new nidd_annual(5, 78.55);
                yield return new nidd_annual(6, 81.27);
                yield return new nidd_annual(7, 86.93);
                yield return new nidd_annual(8, 87.76);
                yield return new nidd_annual(9, 88.89);
                yield return new nidd_annual(10, 90.28);
                yield return new nidd_annual(11, 91.8);
                yield return new nidd_annual(12, 91.8);
                yield return new nidd_annual(13, 92.82);
                yield return new nidd_annual(14, 95.47);
                yield return new nidd_annual(15, 100.4);
                yield return new nidd_annual(16, 111.54);
                yield return new nidd_annual(17, 111.74);
                yield return new nidd_annual(18, 115.52);
                yield return new nidd_annual(19, 131.82);
                yield return new nidd_annual(20, 138.72);
                yield return new nidd_annual(21, 148.63);
                yield return new nidd_annual(22, 149.3);
                yield return new nidd_annual(23, 151.79);
                yield return new nidd_annual(24, 153.04);
                yield return new nidd_annual(25, 158.01);
                yield return new nidd_annual(26, 162.99);
                yield return new nidd_annual(27, 172.92);
                yield return new nidd_annual(28, 179.12);
                yield return new nidd_annual(29, 181.59);
                yield return new nidd_annual(30, 189.04);
                yield return new nidd_annual(31, 213.7);
                yield return new nidd_annual(32, 226.48);
                yield return new nidd_annual(33, 251.96);
                yield return new nidd_annual(34, 261.82);
                yield return new nidd_annual(35, 305.75);
            }
        }
    }
}
