// ReSharper disable All

namespace Rdatasets.Stat2Data
{
    using System.Collections.Generic;

    /// <summary>
    /// PorschePrice
    /// </summary>

    public class PorschePrice
    {
        public readonly double Price;
        public readonly int Age;
        public readonly double Mileage;

        public PorschePrice(double Price, int Age, double Mileage)
        {
            this.Price = Price;
            this.Age = Age;
            this.Mileage = Mileage;
        }

        public static IEnumerable<PorschePrice> Data
        {
            get
            {
                yield return new PorschePrice(69.4, 3, 21.5);
                yield return new PorschePrice(56.9, 3, 43);
                yield return new PorschePrice(49.9, 2, 19.9);
                yield return new PorschePrice(47.4, 4, 36);
                yield return new PorschePrice(42.9, 4, 44);
                yield return new PorschePrice(36.9, 6, 49.8);
                yield return new PorschePrice(83, 0, 1.3);
                yield return new PorschePrice(72.9, 0, 0.67);
                yield return new PorschePrice(69.9, 2, 13.4);
                yield return new PorschePrice(67.9, 0, 9.7);
                yield return new PorschePrice(66.5, 2, 15.3);
                yield return new PorschePrice(64.9, 2, 9.5);
                yield return new PorschePrice(58.9, 4, 19.1);
                yield return new PorschePrice(57.9, 3, 12.9);
                yield return new PorschePrice(54.9, 10, 33.9);
                yield return new PorschePrice(54.7, 11, 26);
                yield return new PorschePrice(53.7, 4, 20.4);
                yield return new PorschePrice(51.9, 4, 27.5);
                yield return new PorschePrice(51.9, 10, 51.7);
                yield return new PorschePrice(49.9, 3, 32.4);
                yield return new PorschePrice(44.9, 4, 44.1);
                yield return new PorschePrice(44.8, 13, 49.8);
                yield return new PorschePrice(39.9, 6, 35);
                yield return new PorschePrice(39.7, 6, 20.5);
                yield return new PorschePrice(34.9, 8, 62);
                yield return new PorschePrice(33.9, 7, 50.4);
                yield return new PorschePrice(23.9, 20, 89.6);
                yield return new PorschePrice(22.9, 22, 83.4);
                yield return new PorschePrice(16, 20, 86);
                yield return new PorschePrice(52.9, 3, 37.4);
            }
        }
    }
}
