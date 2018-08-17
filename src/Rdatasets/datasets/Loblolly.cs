// ReSharper disable All

namespace Rdatasets.datasets
{
    using System.Collections.Generic;

    /// <summary>
    /// Growth of Loblolly pine trees
    /// </summary>

    public class Loblolly
    {
        public readonly double height;
        public readonly int age;
        public readonly int Seed;

        public Loblolly(double height, int age, int Seed)
        {
            this.height = height;
            this.age = age;
            this.Seed = Seed;
        }

        public static IEnumerable<Loblolly> Data
        {
            get
            {
                yield return new Loblolly(4.51, 3, 301);
                yield return new Loblolly(10.89, 5, 301);
                yield return new Loblolly(28.72, 10, 301);
                yield return new Loblolly(41.74, 15, 301);
                yield return new Loblolly(52.7, 20, 301);
                yield return new Loblolly(60.92, 25, 301);
                yield return new Loblolly(4.55, 3, 303);
                yield return new Loblolly(10.92, 5, 303);
                yield return new Loblolly(29.07, 10, 303);
                yield return new Loblolly(42.83, 15, 303);
                yield return new Loblolly(53.88, 20, 303);
                yield return new Loblolly(63.39, 25, 303);
                yield return new Loblolly(4.79, 3, 305);
                yield return new Loblolly(11.37, 5, 305);
                yield return new Loblolly(30.21, 10, 305);
                yield return new Loblolly(44.4, 15, 305);
                yield return new Loblolly(55.82, 20, 305);
                yield return new Loblolly(64.1, 25, 305);
                yield return new Loblolly(3.91, 3, 307);
                yield return new Loblolly(9.48, 5, 307);
                yield return new Loblolly(25.66, 10, 307);
                yield return new Loblolly(39.07, 15, 307);
                yield return new Loblolly(50.78, 20, 307);
                yield return new Loblolly(59.07, 25, 307);
                yield return new Loblolly(4.81, 3, 309);
                yield return new Loblolly(11.2, 5, 309);
                yield return new Loblolly(28.66, 10, 309);
                yield return new Loblolly(41.66, 15, 309);
                yield return new Loblolly(53.31, 20, 309);
                yield return new Loblolly(63.05, 25, 309);
                yield return new Loblolly(3.88, 3, 311);
                yield return new Loblolly(9.4, 5, 311);
                yield return new Loblolly(25.99, 10, 311);
                yield return new Loblolly(39.55, 15, 311);
                yield return new Loblolly(51.46, 20, 311);
                yield return new Loblolly(59.64, 25, 311);
                yield return new Loblolly(4.32, 3, 315);
                yield return new Loblolly(10.43, 5, 315);
                yield return new Loblolly(27.16, 10, 315);
                yield return new Loblolly(40.85, 15, 315);
                yield return new Loblolly(51.33, 20, 315);
                yield return new Loblolly(60.07, 25, 315);
                yield return new Loblolly(4.57, 3, 319);
                yield return new Loblolly(10.57, 5, 319);
                yield return new Loblolly(27.9, 10, 319);
                yield return new Loblolly(41.13, 15, 319);
                yield return new Loblolly(52.43, 20, 319);
                yield return new Loblolly(60.69, 25, 319);
                yield return new Loblolly(3.77, 3, 321);
                yield return new Loblolly(9.03, 5, 321);
                yield return new Loblolly(25.45, 10, 321);
                yield return new Loblolly(38.98, 15, 321);
                yield return new Loblolly(49.76, 20, 321);
                yield return new Loblolly(60.28, 25, 321);
                yield return new Loblolly(4.33, 3, 323);
                yield return new Loblolly(10.79, 5, 323);
                yield return new Loblolly(28.97, 10, 323);
                yield return new Loblolly(42.44, 15, 323);
                yield return new Loblolly(53.17, 20, 323);
                yield return new Loblolly(61.62, 25, 323);
                yield return new Loblolly(4.38, 3, 325);
                yield return new Loblolly(10.48, 5, 325);
                yield return new Loblolly(27.93, 10, 325);
                yield return new Loblolly(40.2, 15, 325);
                yield return new Loblolly(50.06, 20, 325);
                yield return new Loblolly(58.49, 25, 325);
                yield return new Loblolly(4.12, 3, 327);
                yield return new Loblolly(9.92, 5, 327);
                yield return new Loblolly(26.54, 10, 327);
                yield return new Loblolly(37.82, 15, 327);
                yield return new Loblolly(48.43, 20, 327);
                yield return new Loblolly(56.81, 25, 327);
                yield return new Loblolly(3.93, 3, 329);
                yield return new Loblolly(9.34, 5, 329);
                yield return new Loblolly(26.08, 10, 329);
                yield return new Loblolly(37.79, 15, 329);
                yield return new Loblolly(48.31, 20, 329);
                yield return new Loblolly(56.43, 25, 329);
                yield return new Loblolly(3.46, 3, 331);
                yield return new Loblolly(9.05, 5, 331);
                yield return new Loblolly(25.85, 10, 331);
                yield return new Loblolly(39.15, 15, 331);
                yield return new Loblolly(49.12, 20, 331);
                yield return new Loblolly(59.49, 25, 331);
            }
        }
    }
}
