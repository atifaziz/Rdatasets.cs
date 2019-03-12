// ReSharper disable All

namespace Rdatasets.Stat2Data
{
    using System.Collections.Generic;

    /// <summary>
    /// PorscheJaguar
    /// </summary>

    public class PorscheJaguar
    {
        public readonly int κ;
        public readonly string Car;
        public readonly double Price;
        public readonly int Age;
        public readonly double Mileage;
        public readonly int Porsche;

        public PorscheJaguar(int κ, string Car, double Price, int Age, double Mileage, int Porsche)
        {
            this.κ = κ;
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
                yield return new PorscheJaguar(1, "Porsche", 69.4, 3, 21.5, 1);
                yield return new PorscheJaguar(2, "Porsche", 56.9, 3, 43, 1);
                yield return new PorscheJaguar(3, "Porsche", 49.9, 2, 19.9, 1);
                yield return new PorscheJaguar(4, "Porsche", 47.4, 4, 36, 1);
                yield return new PorscheJaguar(5, "Porsche", 42.9, 4, 44, 1);
                yield return new PorscheJaguar(6, "Porsche", 36.9, 6, 49.8, 1);
                yield return new PorscheJaguar(7, "Porsche", 83, 0, 1.3, 1);
                yield return new PorscheJaguar(8, "Porsche", 72.9, 0, 0.67, 1);
                yield return new PorscheJaguar(9, "Porsche", 69.9, 2, 13.4, 1);
                yield return new PorscheJaguar(10, "Porsche", 67.9, 0, 9.7, 1);
                yield return new PorscheJaguar(11, "Porsche", 66.5, 2, 15.3, 1);
                yield return new PorscheJaguar(12, "Porsche", 64.9, 2, 9.5, 1);
                yield return new PorscheJaguar(13, "Porsche", 58.9, 4, 19.1, 1);
                yield return new PorscheJaguar(14, "Porsche", 57.9, 3, 12.9, 1);
                yield return new PorscheJaguar(15, "Porsche", 54.9, 10, 33.9, 1);
                yield return new PorscheJaguar(16, "Porsche", 54.7, 11, 26, 1);
                yield return new PorscheJaguar(17, "Porsche", 53.7, 4, 20.4, 1);
                yield return new PorscheJaguar(18, "Porsche", 51.9, 4, 27.5, 1);
                yield return new PorscheJaguar(19, "Porsche", 51.9, 10, 51.7, 1);
                yield return new PorscheJaguar(20, "Porsche", 49.9, 3, 32.4, 1);
                yield return new PorscheJaguar(21, "Porsche", 44.9, 4, 44.1, 1);
                yield return new PorscheJaguar(22, "Porsche", 44.8, 13, 49.8, 1);
                yield return new PorscheJaguar(23, "Porsche", 39.9, 6, 35, 1);
                yield return new PorscheJaguar(24, "Porsche", 39.7, 6, 20.5, 1);
                yield return new PorscheJaguar(25, "Porsche", 34.9, 8, 62, 1);
                yield return new PorscheJaguar(26, "Porsche", 33.9, 7, 50.4, 1);
                yield return new PorscheJaguar(27, "Porsche", 23.9, 20, 89.6, 1);
                yield return new PorscheJaguar(28, "Porsche", 22.9, 22, 83.4, 1);
                yield return new PorscheJaguar(29, "Porsche", 16, 20, 86, 1);
                yield return new PorscheJaguar(30, "Porsche", 52.9, 3, 37.4, 1);
                yield return new PorscheJaguar(31, "Jaguar", 13.9, 5, 47.7, 0);
                yield return new PorscheJaguar(32, "Jaguar", 19.9, 6, 44.6, 0);
                yield return new PorscheJaguar(33, "Jaguar", 25.9, 4, 35.3, 0);
                yield return new PorscheJaguar(34, "Jaguar", 46.9, 2, 19.6, 0);
                yield return new PorscheJaguar(35, "Jaguar", 12.9, 7, 71, 0);
                yield return new PorscheJaguar(36, "Jaguar", 39.9, 3, 41, 0);
                yield return new PorscheJaguar(37, "Jaguar", 14.9, 7, 69.4, 0);
                yield return new PorscheJaguar(38, "Jaguar", 13.9, 8, 44.1, 0);
                yield return new PorscheJaguar(39, "Jaguar", 25, 5, 7.9, 0);
                yield return new PorscheJaguar(40, "Jaguar", 64.9, 1, 10.7, 0);
                yield return new PorscheJaguar(41, "Jaguar", 24.9, 3, 17, 0);
                yield return new PorscheJaguar(42, "Jaguar", 22.9, 4, 43.4, 0);
                yield return new PorscheJaguar(43, "Jaguar", 12.9, 6, 61.3, 0);
                yield return new PorscheJaguar(44, "Jaguar", 19.9, 10, 53.3, 0);
                yield return new PorscheJaguar(45, "Jaguar", 22.9, 8, 70, 0);
                yield return new PorscheJaguar(46, "Jaguar", 35.9, 4, 33.3, 0);
                yield return new PorscheJaguar(47, "Jaguar", 19.9, 10, 53.3, 0);
                yield return new PorscheJaguar(48, "Jaguar", 26.9, 6, 32.6, 0);
                yield return new PorscheJaguar(49, "Jaguar", 16.9, 5, 43.8, 0);
                yield return new PorscheJaguar(50, "Jaguar", 32.6, 2, 17.7, 0);
                yield return new PorscheJaguar(51, "Jaguar", 19.9, 8, 73, 0);
                yield return new PorscheJaguar(52, "Jaguar", 19.9, 6, 45.4, 0);
                yield return new PorscheJaguar(53, "Jaguar", 70, 2, 4.9, 0);
                yield return new PorscheJaguar(54, "Jaguar", 64.9, 2, 7.3, 0);
                yield return new PorscheJaguar(55, "Jaguar", 50, 5, 30.3, 0);
                yield return new PorscheJaguar(56, "Jaguar", 49.9, 4, 8.6, 0);
                yield return new PorscheJaguar(57, "Jaguar", 47.9, 2, 9.6, 0);
                yield return new PorscheJaguar(58, "Jaguar", 29.9, 5, 30, 0);
                yield return new PorscheJaguar(59, "Jaguar", 46.9, 4, 27.2, 0);
                yield return new PorscheJaguar(60, "Jaguar", 45.6, 5, 23.8, 0);
            }
        }
    }
}
