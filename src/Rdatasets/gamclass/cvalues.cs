// ReSharper disable All

namespace Rdatasets.gamclass
{
    using System.Collections.Generic;

    /// <summary>
    /// Historical speed of light measurements
    /// </summary>

    public class cvalues
    {
        public readonly int κ;
        public readonly int Year;
        public readonly double speed;
        public readonly double? error;

        public cvalues(int κ, int Year, double speed, double? error)
        {
            this.κ = κ;
            this.Year = Year;
            this.speed = speed;
            this.error = error;
        }

        public static IEnumerable<cvalues> Data
        {
            get
            {
                yield return new cvalues(1, 1675, 220000, null);
                yield return new cvalues(2, 1729, 301000, null);
                yield return new cvalues(3, 1849, 315000, null);
                yield return new cvalues(4, 1862, 298000, 500);
                yield return new cvalues(5, 1907, 299710, 30);
                yield return new cvalues(6, 1926, 299796, 4);
                yield return new cvalues(7, 1950, 299792.5, 3);
                yield return new cvalues(8, 1958, 299792.5, 0.1);
                yield return new cvalues(9, 1972, 299792.4562, 0.00111);
            }
        }
    }
}
