// ReSharper disable All

namespace Rdatasets.DAAG
{
    using System.Collections.Generic;

    /// <summary>
    /// Measurements on a Selection of Books
    /// </summary>

    public class allbacks
    {
        public readonly int volume;
        public readonly int area;
        public readonly int weight;
        public readonly string cover;

        public allbacks(int volume, int area, int weight, string cover)
        {
            this.volume = volume;
            this.area = area;
            this.weight = weight;
            this.cover = cover;
        }

        public static IEnumerable<allbacks> Data
        {
            get
            {
                yield return new allbacks(885, 382, 800, "hb");
                yield return new allbacks(1016, 468, 950, "hb");
                yield return new allbacks(1125, 387, 1050, "hb");
                yield return new allbacks(239, 371, 350, "hb");
                yield return new allbacks(701, 371, 750, "hb");
                yield return new allbacks(641, 367, 600, "hb");
                yield return new allbacks(1228, 396, 1075, "hb");
                yield return new allbacks(412, 0, 250, "pb");
                yield return new allbacks(953, 0, 700, "pb");
                yield return new allbacks(929, 0, 650, "pb");
                yield return new allbacks(1492, 0, 975, "pb");
                yield return new allbacks(419, 0, 350, "pb");
                yield return new allbacks(1010, 0, 950, "pb");
                yield return new allbacks(595, 0, 425, "pb");
                yield return new allbacks(1034, 0, 725, "pb");
            }
        }
    }
}
