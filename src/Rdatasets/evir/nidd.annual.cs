// ReSharper disable All

namespace Rdatasets.evir
{
    using System.Collections.Generic;

    /// <summary>
    /// The River Nidd Data
    /// </summary>

    public class nidd_annual
    {
        public readonly double dat;

        public nidd_annual(double dat)
        {
            this.dat = dat;
        }

        public static IEnumerable<nidd_annual> Data
        {
            get
            {
                yield return new nidd_annual(65.08);
                yield return new nidd_annual(65.6);
                yield return new nidd_annual(75.06);
                yield return new nidd_annual(76.22);
                yield return new nidd_annual(78.55);
                yield return new nidd_annual(81.27);
                yield return new nidd_annual(86.93);
                yield return new nidd_annual(87.76);
                yield return new nidd_annual(88.89);
                yield return new nidd_annual(90.28);
                yield return new nidd_annual(91.8);
                yield return new nidd_annual(91.8);
                yield return new nidd_annual(92.82);
                yield return new nidd_annual(95.47);
                yield return new nidd_annual(100.4);
                yield return new nidd_annual(111.54);
                yield return new nidd_annual(111.74);
                yield return new nidd_annual(115.52);
                yield return new nidd_annual(131.82);
                yield return new nidd_annual(138.72);
                yield return new nidd_annual(148.63);
                yield return new nidd_annual(149.3);
                yield return new nidd_annual(151.79);
                yield return new nidd_annual(153.04);
                yield return new nidd_annual(158.01);
                yield return new nidd_annual(162.99);
                yield return new nidd_annual(172.92);
                yield return new nidd_annual(179.12);
                yield return new nidd_annual(181.59);
                yield return new nidd_annual(189.04);
                yield return new nidd_annual(213.7);
                yield return new nidd_annual(226.48);
                yield return new nidd_annual(251.96);
                yield return new nidd_annual(261.82);
                yield return new nidd_annual(305.75);
            }
        }
    }
}
