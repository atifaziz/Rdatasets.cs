// ReSharper disable All

namespace Rdatasets.robustbase
{
    using System.Collections.Generic;

    /// <summary>
    /// Pension Funds Data
    /// </summary>

    public class pension
    {
        public readonly int κ;
        public readonly double Income;
        public readonly double Reserves;

        public pension(int κ, double Income, double Reserves)
        {
            this.κ = κ;
            this.Income = Income;
            this.Reserves = Reserves;
        }

        public static IEnumerable<pension> Data
        {
            get
            {
                yield return new pension(1, 10.4, 272.2);
                yield return new pension(2, 15.6, 212.9);
                yield return new pension(3, 16.2, 120.7);
                yield return new pension(4, 17.9, 163.6);
                yield return new pension(5, 37.8, 226.1);
                yield return new pension(6, 46.9, 622.9);
                yield return new pension(7, 52.4, 1353.2);
                yield return new pension(8, 52.9, 363.6);
                yield return new pension(9, 71, 951.7);
                yield return new pension(10, 73.9, 307.2);
                yield return new pension(11, 76.3, 588.4);
                yield return new pension(12, 77, 952.5);
                yield return new pension(13, 131.2, 1157.3);
                yield return new pension(14, 151.7, 2105.6);
                yield return new pension(15, 206.1, 3581.4);
                yield return new pension(16, 314.7, 3404.7);
                yield return new pension(17, 470.8, 4095.3);
                yield return new pension(18, 1406.3, 6802.7);
            }
        }
    }
}
