// ReSharper disable All

namespace Rdatasets.datasets
{
    using System.Collections.Generic;

    /// <summary>
    /// Speed and Stopping Distances of Cars
    /// </summary>

    public class cars
    {
        public readonly int speed;
        public readonly int dist;

        public cars(int speed, int dist)
        {
            this.speed = speed;
            this.dist = dist;
        }

        public static IEnumerable<cars> Data
        {
            get
            {
                yield return new cars(4, 2);
                yield return new cars(4, 10);
                yield return new cars(7, 4);
                yield return new cars(7, 22);
                yield return new cars(8, 16);
                yield return new cars(9, 10);
                yield return new cars(10, 18);
                yield return new cars(10, 26);
                yield return new cars(10, 34);
                yield return new cars(11, 17);
                yield return new cars(11, 28);
                yield return new cars(12, 14);
                yield return new cars(12, 20);
                yield return new cars(12, 24);
                yield return new cars(12, 28);
                yield return new cars(13, 26);
                yield return new cars(13, 34);
                yield return new cars(13, 34);
                yield return new cars(13, 46);
                yield return new cars(14, 26);
                yield return new cars(14, 36);
                yield return new cars(14, 60);
                yield return new cars(14, 80);
                yield return new cars(15, 20);
                yield return new cars(15, 26);
                yield return new cars(15, 54);
                yield return new cars(16, 32);
                yield return new cars(16, 40);
                yield return new cars(17, 32);
                yield return new cars(17, 40);
                yield return new cars(17, 50);
                yield return new cars(18, 42);
                yield return new cars(18, 56);
                yield return new cars(18, 76);
                yield return new cars(18, 84);
                yield return new cars(19, 36);
                yield return new cars(19, 46);
                yield return new cars(19, 68);
                yield return new cars(20, 32);
                yield return new cars(20, 48);
                yield return new cars(20, 52);
                yield return new cars(20, 56);
                yield return new cars(20, 64);
                yield return new cars(22, 66);
                yield return new cars(23, 54);
                yield return new cars(24, 70);
                yield return new cars(24, 92);
                yield return new cars(24, 93);
                yield return new cars(24, 120);
                yield return new cars(25, 85);
            }
        }
    }
}
