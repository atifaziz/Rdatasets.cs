// ReSharper disable All

namespace Rdatasets.gamclass
{
    using System.Collections.Generic;

    /// <summary>
    /// Historical speed of light measurements
    /// </summary>

    public class cvalues
    {
        public readonly int Year;
        public readonly double speed;
        public readonly string error;

        public cvalues(int Year, double speed, string error)
        {
            this.Year = Year;
            this.speed = speed;
            this.error = error;
        }

        public static IEnumerable<cvalues> Data
        {
            get
            {
                yield return new cvalues(1675, 220000, null);
                yield return new cvalues(1729, 301000, null);
                yield return new cvalues(1849, 315000, null);
                yield return new cvalues(1862, 298000, "500");
                yield return new cvalues(1907, 299710, "30");
                yield return new cvalues(1926, 299796, "4");
                yield return new cvalues(1950, 299792.5, "3");
                yield return new cvalues(1958, 299792.5, "0.1");
                yield return new cvalues(1972, 299792.4562, "0.00111");
            }
        }
    }
}
