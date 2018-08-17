// ReSharper disable All

namespace Rdatasets.Ecdat
{
    using System.Collections.Generic;

    /// <summary>
    /// Production for SIC 33
    /// </summary>

    public class Metal
    {
        public readonly double va;
        public readonly double labor;
        public readonly double capital;

        public Metal(double va, double labor, double capital)
        {
            this.va = va;
            this.labor = labor;
            this.capital = capital;
        }

        public static IEnumerable<Metal> Data
        {
            get
            {
                yield return new Metal(657.29, 162.31, 279.99);
                yield return new Metal(935.93, 214.43, 542.5);
                yield return new Metal(1110.65, 186.44, 721.51);
                yield return new Metal(1200.89, 245.83, 1167.68);
                yield return new Metal(1052.68, 211.4, 811.77);
                yield return new Metal(3406.02, 690.61, 4558.02);
                yield return new Metal(2427.89, 452.79, 3069.91);
                yield return new Metal(4257.46, 714.2, 5585.01);
                yield return new Metal(1625.19, 320.54, 1618.75);
                yield return new Metal(1272.05, 253.17, 1562.08);
                yield return new Metal(1004.45, 236.44, 662.04);
                yield return new Metal(598.87, 140.73, 875.37);
                yield return new Metal(853.1, 145.04, 1696.98);
                yield return new Metal(1165.63, 240.27, 1078.79);
                yield return new Metal(1917.55, 536.73, 2109.34);
                yield return new Metal(9849.17, 1564.83, 13989.55);
                yield return new Metal(1088.27, 214.62, 884.24);
                yield return new Metal(8095.63, 1083.1, 9119.7);
                yield return new Metal(3175.39, 521.74, 5686.99);
                yield return new Metal(1653.38, 304.85, 1701.06);
                yield return new Metal(5159.31, 835.69, 5206.36);
                yield return new Metal(3378.4, 284, 3288.72);
                yield return new Metal(592.85, 150.77, 357.32);
                yield return new Metal(1601.98, 259.91, 2031.93);
                yield return new Metal(2065.85, 497.6, 2492.98);
                yield return new Metal(2293.87, 275.2, 1711.74);
                yield return new Metal(745.67, 137, 768.59);
            }
        }
    }
}
