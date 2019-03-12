// ReSharper disable All

namespace Rdatasets.DAAG
{
    using System.Collections.Generic;

    /// <summary>
    /// Measurements on a Selection of Books
    /// </summary>

    public class allbacks
    {
        public readonly int κ;
        public readonly int volume;
        public readonly int area;
        public readonly int weight;
        public readonly string cover;

        public allbacks(int κ, int volume, int area, int weight, string cover)
        {
            this.κ = κ;
            this.volume = volume;
            this.area = area;
            this.weight = weight;
            this.cover = cover;
        }

        public static IEnumerable<allbacks> Data
        {
            get
            {
                yield return new allbacks(1, 885, 382, 800, "hb");
                yield return new allbacks(2, 1016, 468, 950, "hb");
                yield return new allbacks(3, 1125, 387, 1050, "hb");
                yield return new allbacks(4, 239, 371, 350, "hb");
                yield return new allbacks(5, 701, 371, 750, "hb");
                yield return new allbacks(6, 641, 367, 600, "hb");
                yield return new allbacks(7, 1228, 396, 1075, "hb");
                yield return new allbacks(8, 412, 0, 250, "pb");
                yield return new allbacks(9, 953, 0, 700, "pb");
                yield return new allbacks(10, 929, 0, 650, "pb");
                yield return new allbacks(11, 1492, 0, 975, "pb");
                yield return new allbacks(12, 419, 0, 350, "pb");
                yield return new allbacks(13, 1010, 0, 950, "pb");
                yield return new allbacks(14, 595, 0, 425, "pb");
                yield return new allbacks(15, 1034, 0, 725, "pb");
            }
        }
    }
}
