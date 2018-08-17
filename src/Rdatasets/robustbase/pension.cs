// ReSharper disable All

namespace Rdatasets.robustbase
{
    using System.Collections.Generic;

    /// <summary>
    /// Pension Funds Data
    /// </summary>

    public class pension
    {
        public readonly double Income;
        public readonly double Reserves;

        public pension(double Income, double Reserves)
        {
            this.Income = Income;
            this.Reserves = Reserves;
        }

        public static IEnumerable<pension> Data
        {
            get
            {
                yield return new pension(10.4, 272.2);
                yield return new pension(15.6, 212.9);
                yield return new pension(16.2, 120.7);
                yield return new pension(17.9, 163.6);
                yield return new pension(37.8, 226.1);
                yield return new pension(46.9, 622.9);
                yield return new pension(52.4, 1353.2);
                yield return new pension(52.9, 363.6);
                yield return new pension(71, 951.7);
                yield return new pension(73.9, 307.2);
                yield return new pension(76.3, 588.4);
                yield return new pension(77, 952.5);
                yield return new pension(131.2, 1157.3);
                yield return new pension(151.7, 2105.6);
                yield return new pension(206.1, 3581.4);
                yield return new pension(314.7, 3404.7);
                yield return new pension(470.8, 4095.3);
                yield return new pension(1406.3, 6802.7);
            }
        }
    }
}
