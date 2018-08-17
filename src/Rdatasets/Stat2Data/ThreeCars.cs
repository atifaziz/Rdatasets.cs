// ReSharper disable All

namespace Rdatasets.Stat2Data
{
    using System.Collections.Generic;

    /// <summary>
    /// Three Cars
    /// </summary>

    public class ThreeCars
    {
        public readonly string CarType;
        public readonly double Price;
        public readonly int Age;
        public readonly double Mileage;
        public readonly int Car;
        public readonly int Porsche;
        public readonly int Jaguar;
        public readonly int BMW;

        public ThreeCars(string CarType, double Price, int Age, double Mileage, int Car, int Porsche, int Jaguar, int BMW)
        {
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
                yield return new ThreeCars("Porsche", 69.4, 3, 21.5, 0, 1, 0, 0);
                yield return new ThreeCars("Porsche", 56.9, 3, 43, 0, 1, 0, 0);
                yield return new ThreeCars("Porsche", 49.9, 2, 19.9, 0, 1, 0, 0);
                yield return new ThreeCars("Porsche", 47.4, 4, 36, 0, 1, 0, 0);
                yield return new ThreeCars("Porsche", 42.9, 4, 44, 0, 1, 0, 0);
                yield return new ThreeCars("Porsche", 36.9, 6, 49.8, 0, 1, 0, 0);
                yield return new ThreeCars("Porsche", 83, 0, 1.3, 0, 1, 0, 0);
                yield return new ThreeCars("Porsche", 72.9, 0, 0.67, 0, 1, 0, 0);
                yield return new ThreeCars("Porsche", 69.9, 2, 13.4, 0, 1, 0, 0);
                yield return new ThreeCars("Porsche", 67.9, 0, 9.7, 0, 1, 0, 0);
                yield return new ThreeCars("Porsche", 66.5, 2, 15.3, 0, 1, 0, 0);
                yield return new ThreeCars("Porsche", 64.9, 2, 9.5, 0, 1, 0, 0);
                yield return new ThreeCars("Porsche", 58.9, 4, 19.1, 0, 1, 0, 0);
                yield return new ThreeCars("Porsche", 57.9, 3, 12.9, 0, 1, 0, 0);
                yield return new ThreeCars("Porsche", 54.9, 10, 33.9, 0, 1, 0, 0);
                yield return new ThreeCars("Porsche", 54.7, 11, 26, 0, 1, 0, 0);
                yield return new ThreeCars("Porsche", 53.7, 4, 20.4, 0, 1, 0, 0);
                yield return new ThreeCars("Porsche", 51.9, 4, 27.5, 0, 1, 0, 0);
                yield return new ThreeCars("Porsche", 51.9, 10, 51.7, 0, 1, 0, 0);
                yield return new ThreeCars("Porsche", 49.9, 3, 32.4, 0, 1, 0, 0);
                yield return new ThreeCars("Porsche", 44.9, 4, 44.1, 0, 1, 0, 0);
                yield return new ThreeCars("Porsche", 44.8, 13, 49.8, 0, 1, 0, 0);
                yield return new ThreeCars("Porsche", 39.9, 6, 35, 0, 1, 0, 0);
                yield return new ThreeCars("Porsche", 39.7, 6, 20.5, 0, 1, 0, 0);
                yield return new ThreeCars("Porsche", 34.9, 8, 62, 0, 1, 0, 0);
                yield return new ThreeCars("Porsche", 33.9, 7, 50.4, 0, 1, 0, 0);
                yield return new ThreeCars("Porsche", 23.9, 20, 89.6, 0, 1, 0, 0);
                yield return new ThreeCars("Porsche", 22.9, 22, 83.4, 0, 1, 0, 0);
                yield return new ThreeCars("Porsche", 16, 20, 86, 0, 1, 0, 0);
                yield return new ThreeCars("Porsche", 52.9, 3, 37.4, 0, 1, 0, 0);
                yield return new ThreeCars("Jaguar", 13.9, 5, 47.7, 1, 0, 1, 0);
                yield return new ThreeCars("Jaguar", 19.9, 6, 44.6, 1, 0, 1, 0);
                yield return new ThreeCars("Jaguar", 25.9, 4, 35.3, 1, 0, 1, 0);
                yield return new ThreeCars("Jaguar", 46.9, 2, 19.6, 1, 0, 1, 0);
                yield return new ThreeCars("Jaguar", 12.9, 7, 71, 1, 0, 1, 0);
                yield return new ThreeCars("Jaguar", 39.9, 3, 41, 1, 0, 1, 0);
                yield return new ThreeCars("Jaguar", 14.9, 7, 69.4, 1, 0, 1, 0);
                yield return new ThreeCars("Jaguar", 13.9, 8, 44.1, 1, 0, 1, 0);
                yield return new ThreeCars("Jaguar", 25, 5, 7.9, 1, 0, 1, 0);
                yield return new ThreeCars("Jaguar", 64.9, 1, 10.7, 1, 0, 1, 0);
                yield return new ThreeCars("Jaguar", 24.9, 3, 17, 1, 0, 1, 0);
                yield return new ThreeCars("Jaguar", 22.9, 4, 43.4, 1, 0, 1, 0);
                yield return new ThreeCars("Jaguar", 12.9, 6, 61.3, 1, 0, 1, 0);
                yield return new ThreeCars("Jaguar", 19.9, 10, 53.3, 1, 0, 1, 0);
                yield return new ThreeCars("Jaguar", 22.9, 8, 70, 1, 0, 1, 0);
                yield return new ThreeCars("Jaguar", 35.9, 4, 33.3, 1, 0, 1, 0);
                yield return new ThreeCars("Jaguar", 19.9, 10, 53.3, 1, 0, 1, 0);
                yield return new ThreeCars("Jaguar", 26.9, 6, 32.6, 1, 0, 1, 0);
                yield return new ThreeCars("Jaguar", 16.9, 5, 43.8, 1, 0, 1, 0);
                yield return new ThreeCars("Jaguar", 32.6, 2, 17.7, 1, 0, 1, 0);
                yield return new ThreeCars("Jaguar", 19.9, 8, 73, 1, 0, 1, 0);
                yield return new ThreeCars("Jaguar", 19.9, 6, 45.4, 1, 0, 1, 0);
                yield return new ThreeCars("Jaguar", 70, 2, 4.9, 1, 0, 1, 0);
                yield return new ThreeCars("Jaguar", 64.9, 2, 7.3, 1, 0, 1, 0);
                yield return new ThreeCars("Jaguar", 50, 5, 30.3, 1, 0, 1, 0);
                yield return new ThreeCars("Jaguar", 49.9, 4, 8.6, 1, 0, 1, 0);
                yield return new ThreeCars("Jaguar", 47.9, 2, 9.6, 1, 0, 1, 0);
                yield return new ThreeCars("Jaguar", 29.9, 5, 30, 1, 0, 1, 0);
                yield return new ThreeCars("Jaguar", 46.9, 4, 27.2, 1, 0, 1, 0);
                yield return new ThreeCars("Jaguar", 45.6, 5, 23.8, 1, 0, 1, 0);
                yield return new ThreeCars("BMW", 12.9, 11, 55, 2, 0, 0, 1);
                yield return new ThreeCars("BMW", 25, 7, 40.9, 2, 0, 0, 1);
                yield return new ThreeCars("BMW", 12, 12, 100.7, 2, 0, 0, 1);
                yield return new ThreeCars("BMW", 21.9, 7, 68.2, 2, 0, 0, 1);
                yield return new ThreeCars("BMW", 21.9, 8, 68.7, 2, 0, 0, 1);
                yield return new ThreeCars("BMW", 22.9, 8, 68.5, 2, 0, 0, 1);
                yield return new ThreeCars("BMW", 23.9, 6, 60.2, 2, 0, 0, 1);
                yield return new ThreeCars("BMW", 25.9, 6, 50, 2, 0, 0, 1);
                yield return new ThreeCars("BMW", 26.5, 7, 71.2, 2, 0, 0, 1);
                yield return new ThreeCars("BMW", 26.9, 7, 69, 2, 0, 0, 1);
                yield return new ThreeCars("BMW", 27.9, 5, 66.8, 2, 0, 0, 1);
                yield return new ThreeCars("BMW", 27.9, 6, 39.5, 2, 0, 0, 1);
                yield return new ThreeCars("BMW", 64.9, 1, 6.9, 2, 0, 0, 1);
                yield return new ThreeCars("BMW", 35.9, 4, 31.8, 2, 0, 0, 1);
                yield return new ThreeCars("BMW", 33.5, 4, 51.2, 2, 0, 0, 1);
                yield return new ThreeCars("BMW", 28.5, 6, 60.1, 2, 0, 0, 1);
                yield return new ThreeCars("BMW", 26.9, 7, 69, 2, 0, 0, 1);
                yield return new ThreeCars("BMW", 29.9, 5, 69.3, 2, 0, 0, 1);
                yield return new ThreeCars("BMW", 27.9, 6, 61.7, 2, 0, 0, 1);
                yield return new ThreeCars("BMW", 30.9, 5, 42.7, 2, 0, 0, 1);
                yield return new ThreeCars("BMW", 52.9, 2, 6.9, 2, 0, 0, 1);
                yield return new ThreeCars("BMW", 36, 4, 31.8, 2, 0, 0, 1);
                yield return new ThreeCars("BMW", 30.9, 4, 50.9, 2, 0, 0, 1);
                yield return new ThreeCars("BMW", 70.5, 1, 6.8, 2, 0, 0, 1);
                yield return new ThreeCars("BMW", 18, 7, 91.1, 2, 0, 0, 1);
                yield return new ThreeCars("BMW", 26.9, 6, 68.1, 2, 0, 0, 1);
                yield return new ThreeCars("BMW", 30, 6, 46.8, 2, 0, 0, 1);
                yield return new ThreeCars("BMW", 36, 5, 46.8, 2, 0, 0, 1);
                yield return new ThreeCars("BMW", 38, 4, 36.1, 2, 0, 0, 1);
                yield return new ThreeCars("BMW", 13.8, 7, 59, 2, 0, 0, 1);
            }
        }
    }
}
