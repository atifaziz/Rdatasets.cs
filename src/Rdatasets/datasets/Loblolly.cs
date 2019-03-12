// ReSharper disable All

namespace Rdatasets.datasets
{
    using System.Collections.Generic;

    /// <summary>
    /// Growth of Loblolly pine trees
    /// </summary>

    public class Loblolly
    {
        public readonly int κ;
        public readonly double height;
        public readonly int age;
        public readonly int Seed;

        public Loblolly(int κ, double height, int age, int Seed)
        {
            this.κ = κ;
            this.height = height;
            this.age = age;
            this.Seed = Seed;
        }

        public static IEnumerable<Loblolly> Data
        {
            get
            {
                yield return new Loblolly(1, 4.51, 3, 301);
                yield return new Loblolly(15, 10.89, 5, 301);
                yield return new Loblolly(29, 28.72, 10, 301);
                yield return new Loblolly(43, 41.74, 15, 301);
                yield return new Loblolly(57, 52.7, 20, 301);
                yield return new Loblolly(71, 60.92, 25, 301);
                yield return new Loblolly(2, 4.55, 3, 303);
                yield return new Loblolly(16, 10.92, 5, 303);
                yield return new Loblolly(30, 29.07, 10, 303);
                yield return new Loblolly(44, 42.83, 15, 303);
                yield return new Loblolly(58, 53.88, 20, 303);
                yield return new Loblolly(72, 63.39, 25, 303);
                yield return new Loblolly(3, 4.79, 3, 305);
                yield return new Loblolly(17, 11.37, 5, 305);
                yield return new Loblolly(31, 30.21, 10, 305);
                yield return new Loblolly(45, 44.4, 15, 305);
                yield return new Loblolly(59, 55.82, 20, 305);
                yield return new Loblolly(73, 64.1, 25, 305);
                yield return new Loblolly(4, 3.91, 3, 307);
                yield return new Loblolly(18, 9.48, 5, 307);
                yield return new Loblolly(32, 25.66, 10, 307);
                yield return new Loblolly(46, 39.07, 15, 307);
                yield return new Loblolly(60, 50.78, 20, 307);
                yield return new Loblolly(74, 59.07, 25, 307);
                yield return new Loblolly(5, 4.81, 3, 309);
                yield return new Loblolly(19, 11.2, 5, 309);
                yield return new Loblolly(33, 28.66, 10, 309);
                yield return new Loblolly(47, 41.66, 15, 309);
                yield return new Loblolly(61, 53.31, 20, 309);
                yield return new Loblolly(75, 63.05, 25, 309);
                yield return new Loblolly(6, 3.88, 3, 311);
                yield return new Loblolly(20, 9.4, 5, 311);
                yield return new Loblolly(34, 25.99, 10, 311);
                yield return new Loblolly(48, 39.55, 15, 311);
                yield return new Loblolly(62, 51.46, 20, 311);
                yield return new Loblolly(76, 59.64, 25, 311);
                yield return new Loblolly(7, 4.32, 3, 315);
                yield return new Loblolly(21, 10.43, 5, 315);
                yield return new Loblolly(35, 27.16, 10, 315);
                yield return new Loblolly(49, 40.85, 15, 315);
                yield return new Loblolly(63, 51.33, 20, 315);
                yield return new Loblolly(77, 60.07, 25, 315);
                yield return new Loblolly(8, 4.57, 3, 319);
                yield return new Loblolly(22, 10.57, 5, 319);
                yield return new Loblolly(36, 27.9, 10, 319);
                yield return new Loblolly(50, 41.13, 15, 319);
                yield return new Loblolly(64, 52.43, 20, 319);
                yield return new Loblolly(78, 60.69, 25, 319);
                yield return new Loblolly(9, 3.77, 3, 321);
                yield return new Loblolly(23, 9.03, 5, 321);
                yield return new Loblolly(37, 25.45, 10, 321);
                yield return new Loblolly(51, 38.98, 15, 321);
                yield return new Loblolly(65, 49.76, 20, 321);
                yield return new Loblolly(79, 60.28, 25, 321);
                yield return new Loblolly(10, 4.33, 3, 323);
                yield return new Loblolly(24, 10.79, 5, 323);
                yield return new Loblolly(38, 28.97, 10, 323);
                yield return new Loblolly(52, 42.44, 15, 323);
                yield return new Loblolly(66, 53.17, 20, 323);
                yield return new Loblolly(80, 61.62, 25, 323);
                yield return new Loblolly(11, 4.38, 3, 325);
                yield return new Loblolly(25, 10.48, 5, 325);
                yield return new Loblolly(39, 27.93, 10, 325);
                yield return new Loblolly(53, 40.2, 15, 325);
                yield return new Loblolly(67, 50.06, 20, 325);
                yield return new Loblolly(81, 58.49, 25, 325);
                yield return new Loblolly(12, 4.12, 3, 327);
                yield return new Loblolly(26, 9.92, 5, 327);
                yield return new Loblolly(40, 26.54, 10, 327);
                yield return new Loblolly(54, 37.82, 15, 327);
                yield return new Loblolly(68, 48.43, 20, 327);
                yield return new Loblolly(82, 56.81, 25, 327);
                yield return new Loblolly(13, 3.93, 3, 329);
                yield return new Loblolly(27, 9.34, 5, 329);
                yield return new Loblolly(41, 26.08, 10, 329);
                yield return new Loblolly(55, 37.79, 15, 329);
                yield return new Loblolly(69, 48.31, 20, 329);
                yield return new Loblolly(83, 56.43, 25, 329);
                yield return new Loblolly(14, 3.46, 3, 331);
                yield return new Loblolly(28, 9.05, 5, 331);
                yield return new Loblolly(42, 25.85, 10, 331);
                yield return new Loblolly(56, 39.15, 15, 331);
                yield return new Loblolly(70, 49.12, 20, 331);
                yield return new Loblolly(84, 59.49, 25, 331);
            }
        }
    }
}
