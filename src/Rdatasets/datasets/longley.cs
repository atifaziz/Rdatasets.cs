// ReSharper disable All

namespace Rdatasets.datasets
{
    using System.Collections.Generic;

    /// <summary>
    /// Longley's Economic Regression Data
    /// </summary>

    public class longley
    {
        public readonly double GNP_deflator;
        public readonly double GNP;
        public readonly double Unemployed;
        public readonly double Armed_Forces;
        public readonly double Population;
        public readonly int Year;
        public readonly double Employed;

        public longley(double GNP_deflator, double GNP, double Unemployed, double Armed_Forces, double Population, int Year, double Employed)
        {
            this.GNP_deflator = GNP_deflator;
            this.GNP = GNP;
            this.Unemployed = Unemployed;
            this.Armed_Forces = Armed_Forces;
            this.Population = Population;
            this.Year = Year;
            this.Employed = Employed;
        }

        public static IEnumerable<longley> Data
        {
            get
            {
                yield return new longley(83, 234.289, 235.6, 159, 107.608, 1947, 60.323);
                yield return new longley(88.5, 259.426, 232.5, 145.6, 108.632, 1948, 61.122);
                yield return new longley(88.2, 258.054, 368.2, 161.6, 109.773, 1949, 60.171);
                yield return new longley(89.5, 284.599, 335.1, 165, 110.929, 1950, 61.187);
                yield return new longley(96.2, 328.975, 209.9, 309.9, 112.075, 1951, 63.221);
                yield return new longley(98.1, 346.999, 193.2, 359.4, 113.27, 1952, 63.639);
                yield return new longley(99, 365.385, 187, 354.7, 115.094, 1953, 64.989);
                yield return new longley(100, 363.112, 357.8, 335, 116.219, 1954, 63.761);
                yield return new longley(101.2, 397.469, 290.4, 304.8, 117.388, 1955, 66.019);
                yield return new longley(104.6, 419.18, 282.2, 285.7, 118.734, 1956, 67.857);
                yield return new longley(108.4, 442.769, 293.6, 279.8, 120.445, 1957, 68.169);
                yield return new longley(110.8, 444.546, 468.1, 263.7, 121.95, 1958, 66.513);
                yield return new longley(112.6, 482.704, 381.3, 255.2, 123.366, 1959, 68.655);
                yield return new longley(114.2, 502.601, 393.1, 251.4, 125.368, 1960, 69.564);
                yield return new longley(115.7, 518.173, 480.6, 257.2, 127.852, 1961, 69.331);
                yield return new longley(116.9, 554.894, 400.7, 282.7, 130.081, 1962, 70.551);
            }
        }
    }
}
