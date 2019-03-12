// ReSharper disable All

namespace Rdatasets.Stat2Data
{
    using System.Collections.Generic;

    /// <summary>
    /// Three Cars
    /// </summary>

    public class ThreeCars
    {
        public readonly int κ;
        public readonly string CarType;
        public readonly double Price;
        public readonly int Age;
        public readonly double Mileage;
        public readonly int Car;
        public readonly int Porsche;
        public readonly int Jaguar;
        public readonly int BMW;

        public ThreeCars(int κ, string CarType, double Price, int Age, double Mileage, int Car, int Porsche, int Jaguar, int BMW)
        {
            this.κ = κ;
            this.CarType = CarType;
            this.Price = Price;
            this.Age = Age;
            this.Mileage = Mileage;
            this.Car = Car;
            this.Porsche = Porsche;
            this.Jaguar = Jaguar;
            this.BMW = BMW;
        }

        public static IEnumerable<ThreeCars> Data
        {
            get
            {
                yield return new ThreeCars(1, "Porsche", 69.4, 3, 21.5, 0, 1, 0, 0);
                yield return new ThreeCars(2, "Porsche", 56.9, 3, 43, 0, 1, 0, 0);
                yield return new ThreeCars(3, "Porsche", 49.9, 2, 19.9, 0, 1, 0, 0);
                yield return new ThreeCars(4, "Porsche", 47.4, 4, 36, 0, 1, 0, 0);
                yield return new ThreeCars(5, "Porsche", 42.9, 4, 44, 0, 1, 0, 0);
                yield return new ThreeCars(6, "Porsche", 36.9, 6, 49.8, 0, 1, 0, 0);
                yield return new ThreeCars(7, "Porsche", 83, 0, 1.3, 0, 1, 0, 0);
                yield return new ThreeCars(8, "Porsche", 72.9, 0, 0.67, 0, 1, 0, 0);
                yield return new ThreeCars(9, "Porsche", 69.9, 2, 13.4, 0, 1, 0, 0);
                yield return new ThreeCars(10, "Porsche", 67.9, 0, 9.7, 0, 1, 0, 0);
                yield return new ThreeCars(11, "Porsche", 66.5, 2, 15.3, 0, 1, 0, 0);
                yield return new ThreeCars(12, "Porsche", 64.9, 2, 9.5, 0, 1, 0, 0);
                yield return new ThreeCars(13, "Porsche", 58.9, 4, 19.1, 0, 1, 0, 0);
                yield return new ThreeCars(14, "Porsche", 57.9, 3, 12.9, 0, 1, 0, 0);
                yield return new ThreeCars(15, "Porsche", 54.9, 10, 33.9, 0, 1, 0, 0);
                yield return new ThreeCars(16, "Porsche", 54.7, 11, 26, 0, 1, 0, 0);
                yield return new ThreeCars(17, "Porsche", 53.7, 4, 20.4, 0, 1, 0, 0);
                yield return new ThreeCars(18, "Porsche", 51.9, 4, 27.5, 0, 1, 0, 0);
                yield return new ThreeCars(19, "Porsche", 51.9, 10, 51.7, 0, 1, 0, 0);
                yield return new ThreeCars(20, "Porsche", 49.9, 3, 32.4, 0, 1, 0, 0);
                yield return new ThreeCars(21, "Porsche", 44.9, 4, 44.1, 0, 1, 0, 0);
                yield return new ThreeCars(22, "Porsche", 44.8, 13, 49.8, 0, 1, 0, 0);
                yield return new ThreeCars(23, "Porsche", 39.9, 6, 35, 0, 1, 0, 0);
                yield return new ThreeCars(24, "Porsche", 39.7, 6, 20.5, 0, 1, 0, 0);
                yield return new ThreeCars(25, "Porsche", 34.9, 8, 62, 0, 1, 0, 0);
                yield return new ThreeCars(26, "Porsche", 33.9, 7, 50.4, 0, 1, 0, 0);
                yield return new ThreeCars(27, "Porsche", 23.9, 20, 89.6, 0, 1, 0, 0);
                yield return new ThreeCars(28, "Porsche", 22.9, 22, 83.4, 0, 1, 0, 0);
                yield return new ThreeCars(29, "Porsche", 16, 20, 86, 0, 1, 0, 0);
                yield return new ThreeCars(30, "Porsche", 52.9, 3, 37.4, 0, 1, 0, 0);
                yield return new ThreeCars(31, "Jaguar", 13.9, 5, 47.7, 1, 0, 1, 0);
                yield return new ThreeCars(32, "Jaguar", 19.9, 6, 44.6, 1, 0, 1, 0);
                yield return new ThreeCars(33, "Jaguar", 25.9, 4, 35.3, 1, 0, 1, 0);
                yield return new ThreeCars(34, "Jaguar", 46.9, 2, 19.6, 1, 0, 1, 0);
                yield return new ThreeCars(35, "Jaguar", 12.9, 7, 71, 1, 0, 1, 0);
                yield return new ThreeCars(36, "Jaguar", 39.9, 3, 41, 1, 0, 1, 0);
                yield return new ThreeCars(37, "Jaguar", 14.9, 7, 69.4, 1, 0, 1, 0);
                yield return new ThreeCars(38, "Jaguar", 13.9, 8, 44.1, 1, 0, 1, 0);
                yield return new ThreeCars(39, "Jaguar", 25, 5, 7.9, 1, 0, 1, 0);
                yield return new ThreeCars(40, "Jaguar", 64.9, 1, 10.7, 1, 0, 1, 0);
                yield return new ThreeCars(41, "Jaguar", 24.9, 3, 17, 1, 0, 1, 0);
                yield return new ThreeCars(42, "Jaguar", 22.9, 4, 43.4, 1, 0, 1, 0);
                yield return new ThreeCars(43, "Jaguar", 12.9, 6, 61.3, 1, 0, 1, 0);
                yield return new ThreeCars(44, "Jaguar", 19.9, 10, 53.3, 1, 0, 1, 0);
                yield return new ThreeCars(45, "Jaguar", 22.9, 8, 70, 1, 0, 1, 0);
                yield return new ThreeCars(46, "Jaguar", 35.9, 4, 33.3, 1, 0, 1, 0);
                yield return new ThreeCars(47, "Jaguar", 19.9, 10, 53.3, 1, 0, 1, 0);
                yield return new ThreeCars(48, "Jaguar", 26.9, 6, 32.6, 1, 0, 1, 0);
                yield return new ThreeCars(49, "Jaguar", 16.9, 5, 43.8, 1, 0, 1, 0);
                yield return new ThreeCars(50, "Jaguar", 32.6, 2, 17.7, 1, 0, 1, 0);
                yield return new ThreeCars(51, "Jaguar", 19.9, 8, 73, 1, 0, 1, 0);
                yield return new ThreeCars(52, "Jaguar", 19.9, 6, 45.4, 1, 0, 1, 0);
                yield return new ThreeCars(53, "Jaguar", 70, 2, 4.9, 1, 0, 1, 0);
                yield return new ThreeCars(54, "Jaguar", 64.9, 2, 7.3, 1, 0, 1, 0);
                yield return new ThreeCars(55, "Jaguar", 50, 5, 30.3, 1, 0, 1, 0);
                yield return new ThreeCars(56, "Jaguar", 49.9, 4, 8.6, 1, 0, 1, 0);
                yield return new ThreeCars(57, "Jaguar", 47.9, 2, 9.6, 1, 0, 1, 0);
                yield return new ThreeCars(58, "Jaguar", 29.9, 5, 30, 1, 0, 1, 0);
                yield return new ThreeCars(59, "Jaguar", 46.9, 4, 27.2, 1, 0, 1, 0);
                yield return new ThreeCars(60, "Jaguar", 45.6, 5, 23.8, 1, 0, 1, 0);
                yield return new ThreeCars(61, "BMW", 12.9, 11, 55, 2, 0, 0, 1);
                yield return new ThreeCars(62, "BMW", 25, 7, 40.9, 2, 0, 0, 1);
                yield return new ThreeCars(63, "BMW", 12, 12, 100.7, 2, 0, 0, 1);
                yield return new ThreeCars(64, "BMW", 21.9, 7, 68.2, 2, 0, 0, 1);
                yield return new ThreeCars(65, "BMW", 21.9, 8, 68.7, 2, 0, 0, 1);
                yield return new ThreeCars(66, "BMW", 22.9, 8, 68.5, 2, 0, 0, 1);
                yield return new ThreeCars(67, "BMW", 23.9, 6, 60.2, 2, 0, 0, 1);
                yield return new ThreeCars(68, "BMW", 25.9, 6, 50, 2, 0, 0, 1);
                yield return new ThreeCars(69, "BMW", 26.5, 7, 71.2, 2, 0, 0, 1);
                yield return new ThreeCars(70, "BMW", 26.9, 7, 69, 2, 0, 0, 1);
                yield return new ThreeCars(71, "BMW", 27.9, 5, 66.8, 2, 0, 0, 1);
                yield return new ThreeCars(72, "BMW", 27.9, 6, 39.5, 2, 0, 0, 1);
                yield return new ThreeCars(73, "BMW", 64.9, 1, 6.9, 2, 0, 0, 1);
                yield return new ThreeCars(74, "BMW", 35.9, 4, 31.8, 2, 0, 0, 1);
                yield return new ThreeCars(75, "BMW", 33.5, 4, 51.2, 2, 0, 0, 1);
                yield return new ThreeCars(76, "BMW", 28.5, 6, 60.1, 2, 0, 0, 1);
                yield return new ThreeCars(77, "BMW", 26.9, 7, 69, 2, 0, 0, 1);
                yield return new ThreeCars(78, "BMW", 29.9, 5, 69.3, 2, 0, 0, 1);
                yield return new ThreeCars(79, "BMW", 27.9, 6, 61.7, 2, 0, 0, 1);
                yield return new ThreeCars(80, "BMW", 30.9, 5, 42.7, 2, 0, 0, 1);
                yield return new ThreeCars(81, "BMW", 52.9, 2, 6.9, 2, 0, 0, 1);
                yield return new ThreeCars(82, "BMW", 36, 4, 31.8, 2, 0, 0, 1);
                yield return new ThreeCars(83, "BMW", 30.9, 4, 50.9, 2, 0, 0, 1);
                yield return new ThreeCars(84, "BMW", 70.5, 1, 6.8, 2, 0, 0, 1);
                yield return new ThreeCars(85, "BMW", 18, 7, 91.1, 2, 0, 0, 1);
                yield return new ThreeCars(86, "BMW", 26.9, 6, 68.1, 2, 0, 0, 1);
                yield return new ThreeCars(87, "BMW", 30, 6, 46.8, 2, 0, 0, 1);
                yield return new ThreeCars(88, "BMW", 36, 5, 46.8, 2, 0, 0, 1);
                yield return new ThreeCars(89, "BMW", 38, 4, 36.1, 2, 0, 0, 1);
                yield return new ThreeCars(90, "BMW", 13.8, 7, 59, 2, 0, 0, 1);
            }
        }
    }
}
