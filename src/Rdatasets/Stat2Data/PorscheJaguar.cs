// ReSharper disable All

namespace Rdatasets.Stat2Data
{
    using System.Collections.Generic;

    /// <summary>
    /// PorscheJaguar
    /// </summary>

    public class PorscheJaguar
    {
        public readonly string Car;
        public readonly double Price;
        public readonly int Age;
        public readonly double Mileage;
        public readonly int Porsche;

        public PorscheJaguar(string Car, double Price, int Age, double Mileage, int Porsche)
        {
            this.Car = Car;
            this.Price = Price;
            this.Age = Age;
            this.Mileage = Mileage;
            this.Porsche = Porsche;
        }

        public static IEnumerable<PorscheJaguar> Data
        {
            get
            {
                yield return new PorscheJaguar("Porsche", 69.4, 3, 21.5, 1);
                yield return new PorscheJaguar("Porsche", 56.9, 3, 43, 1);
                yield return new PorscheJaguar("Porsche", 49.9, 2, 19.9, 1);
                yield return new PorscheJaguar("Porsche", 47.4, 4, 36, 1);
                yield return new PorscheJaguar("Porsche", 42.9, 4, 44, 1);
                yield return new PorscheJaguar("Porsche", 36.9, 6, 49.8, 1);
                yield return new PorscheJaguar("Porsche", 83, 0, 1.3, 1);
                yield return new PorscheJaguar("Porsche", 72.9, 0, 0.67, 1);
                yield return new PorscheJaguar("Porsche", 69.9, 2, 13.4, 1);
                yield return new PorscheJaguar("Porsche", 67.9, 0, 9.7, 1);
                yield return new PorscheJaguar("Porsche", 66.5, 2, 15.3, 1);
                yield return new PorscheJaguar("Porsche", 64.9, 2, 9.5, 1);
                yield return new PorscheJaguar("Porsche", 58.9, 4, 19.1, 1);
                yield return new PorscheJaguar("Porsche", 57.9, 3, 12.9, 1);
                yield return new PorscheJaguar("Porsche", 54.9, 10, 33.9, 1);
                yield return new PorscheJaguar("Porsche", 54.7, 11, 26, 1);
                yield return new PorscheJaguar("Porsche", 53.7, 4, 20.4, 1);
                yield return new PorscheJaguar("Porsche", 51.9, 4, 27.5, 1);
                yield return new PorscheJaguar("Porsche", 51.9, 10, 51.7, 1);
                yield return new PorscheJaguar("Porsche", 49.9, 3, 32.4, 1);
                yield return new PorscheJaguar("Porsche", 44.9, 4, 44.1, 1);
                yield return new PorscheJaguar("Porsche", 44.8, 13, 49.8, 1);
                yield return new PorscheJaguar("Porsche", 39.9, 6, 35, 1);
                yield return new PorscheJaguar("Porsche", 39.7, 6, 20.5, 1);
                yield return new PorscheJaguar("Porsche", 34.9, 8, 62, 1);
                yield return new PorscheJaguar("Porsche", 33.9, 7, 50.4, 1);
                yield return new PorscheJaguar("Porsche", 23.9, 20, 89.6, 1);
                yield return new PorscheJaguar("Porsche", 22.9, 22, 83.4, 1);
                yield return new PorscheJaguar("Porsche", 16, 20, 86, 1);
                yield return new PorscheJaguar("Porsche", 52.9, 3, 37.4, 1);
                yield return new PorscheJaguar("Jaguar", 13.9, 5, 47.7, 0);
                yield return new PorscheJaguar("Jaguar", 19.9, 6, 44.6, 0);
                yield return new PorscheJaguar("Jaguar", 25.9, 4, 35.3, 0);
                yield return new PorscheJaguar("Jaguar", 46.9, 2, 19.6, 0);
                yield return new PorscheJaguar("Jaguar", 12.9, 7, 71, 0);
                yield return new PorscheJaguar("Jaguar", 39.9, 3, 41, 0);
                yield return new PorscheJaguar("Jaguar", 14.9, 7, 69.4, 0);
                yield return new PorscheJaguar("Jaguar", 13.9, 8, 44.1, 0);
                yield return new PorscheJaguar("Jaguar", 25, 5, 7.9, 0);
                yield return new PorscheJaguar("Jaguar", 64.9, 1, 10.7, 0);
                yield return new PorscheJaguar("Jaguar", 24.9, 3, 17, 0);
                yield return new PorscheJaguar("Jaguar", 22.9, 4, 43.4, 0);
                yield return new PorscheJaguar("Jaguar", 12.9, 6, 61.3, 0);
                yield return new PorscheJaguar("Jaguar", 19.9, 10, 53.3, 0);
                yield return new PorscheJaguar("Jaguar", 22.9, 8, 70, 0);
                yield return new PorscheJaguar("Jaguar", 35.9, 4, 33.3, 0);
                yield return new PorscheJaguar("Jaguar", 19.9, 10, 53.3, 0);
                yield return new PorscheJaguar("Jaguar", 26.9, 6, 32.6, 0);
                yield return new PorscheJaguar("Jaguar", 16.9, 5, 43.8, 0);
                yield return new PorscheJaguar("Jaguar", 32.6, 2, 17.7, 0);
                yield return new PorscheJaguar("Jaguar", 19.9, 8, 73, 0);
                yield return new PorscheJaguar("Jaguar", 19.9, 6, 45.4, 0);
                yield return new PorscheJaguar("Jaguar", 70, 2, 4.9, 0);
                yield return new PorscheJaguar("Jaguar", 64.9, 2, 7.3, 0);
                yield return new PorscheJaguar("Jaguar", 50, 5, 30.3, 0);
                yield return new PorscheJaguar("Jaguar", 49.9, 4, 8.6, 0);
                yield return new PorscheJaguar("Jaguar", 47.9, 2, 9.6, 0);
                yield return new PorscheJaguar("Jaguar", 29.9, 5, 30, 0);
                yield return new PorscheJaguar("Jaguar", 46.9, 4, 27.2, 0);
                yield return new PorscheJaguar("Jaguar", 45.6, 5, 23.8, 0);
            }
        }
    }
}
