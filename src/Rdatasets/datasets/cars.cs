// ReSharper disable All

namespace Rdatasets.datasets
{
    using System.Collections.Generic;

    /// <summary>
    /// Speed and Stopping Distances of Cars
    /// </summary>

    public class cars
    {
        public readonly int κ;
        public readonly int speed;
        public readonly int dist;

        public cars(int κ, int speed, int dist)
        {
            this.κ = κ;
            this.speed = speed;
            this.dist = dist;
        }

        public static IEnumerable<cars> Data
        {
            get
            {
                yield return new cars(1, 4, 2);
                yield return new cars(2, 4, 10);
                yield return new cars(3, 7, 4);
                yield return new cars(4, 7, 22);
                yield return new cars(5, 8, 16);
                yield return new cars(6, 9, 10);
                yield return new cars(7, 10, 18);
                yield return new cars(8, 10, 26);
                yield return new cars(9, 10, 34);
                yield return new cars(10, 11, 17);
                yield return new cars(11, 11, 28);
                yield return new cars(12, 12, 14);
                yield return new cars(13, 12, 20);
                yield return new cars(14, 12, 24);
                yield return new cars(15, 12, 28);
                yield return new cars(16, 13, 26);
                yield return new cars(17, 13, 34);
                yield return new cars(18, 13, 34);
                yield return new cars(19, 13, 46);
                yield return new cars(20, 14, 26);
                yield return new cars(21, 14, 36);
                yield return new cars(22, 14, 60);
                yield return new cars(23, 14, 80);
                yield return new cars(24, 15, 20);
                yield return new cars(25, 15, 26);
                yield return new cars(26, 15, 54);
                yield return new cars(27, 16, 32);
                yield return new cars(28, 16, 40);
                yield return new cars(29, 17, 32);
                yield return new cars(30, 17, 40);
                yield return new cars(31, 17, 50);
                yield return new cars(32, 18, 42);
                yield return new cars(33, 18, 56);
                yield return new cars(34, 18, 76);
                yield return new cars(35, 18, 84);
                yield return new cars(36, 19, 36);
                yield return new cars(37, 19, 46);
                yield return new cars(38, 19, 68);
                yield return new cars(39, 20, 32);
                yield return new cars(40, 20, 48);
                yield return new cars(41, 20, 52);
                yield return new cars(42, 20, 56);
                yield return new cars(43, 20, 64);
                yield return new cars(44, 22, 66);
                yield return new cars(45, 23, 54);
                yield return new cars(46, 24, 70);
                yield return new cars(47, 24, 92);
                yield return new cars(48, 24, 93);
                yield return new cars(49, 24, 120);
                yield return new cars(50, 25, 85);
            }
        }
    }
}
