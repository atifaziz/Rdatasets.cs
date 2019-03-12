// ReSharper disable All

namespace Rdatasets.HistData
{
    using System.Collections.Generic;

    /// <summary>
    /// W. Stanley Jevons' data on numerical discrimination
    /// </summary>

    public class Jevons
    {
        public readonly int κ;
        public readonly int actual;
        public readonly int estimated;
        public readonly int frequency;
        public readonly int error;

        public Jevons(int κ, int actual, int estimated, int frequency, int error)
        {
            this.κ = κ;
            this.actual = actual;
            this.estimated = estimated;
            this.frequency = frequency;
            this.error = error;
        }

        public static IEnumerable<Jevons> Data
        {
            get
            {
                yield return new Jevons(1, 3, 3, 23, 0);
                yield return new Jevons(2, 4, 4, 65, 0);
                yield return new Jevons(3, 5, 5, 102, 0);
                yield return new Jevons(4, 6, 5, 7, 1);
                yield return new Jevons(5, 5, 6, 4, -1);
                yield return new Jevons(6, 6, 6, 120, 0);
                yield return new Jevons(7, 7, 6, 18, 1);
                yield return new Jevons(8, 5, 7, 1, -2);
                yield return new Jevons(9, 6, 7, 20, -1);
                yield return new Jevons(10, 7, 7, 113, 0);
                yield return new Jevons(11, 8, 7, 30, 1);
                yield return new Jevons(12, 9, 7, 2, 2);
                yield return new Jevons(13, 7, 8, 25, -1);
                yield return new Jevons(14, 8, 8, 76, 0);
                yield return new Jevons(15, 9, 8, 24, 1);
                yield return new Jevons(16, 10, 8, 6, 2);
                yield return new Jevons(17, 11, 8, 1, 3);
                yield return new Jevons(18, 8, 9, 28, -1);
                yield return new Jevons(19, 9, 9, 76, 0);
                yield return new Jevons(20, 10, 9, 37, 1);
                yield return new Jevons(21, 11, 9, 11, 2);
                yield return new Jevons(22, 12, 9, 1, 3);
                yield return new Jevons(23, 8, 10, 1, -2);
                yield return new Jevons(24, 9, 10, 18, -1);
                yield return new Jevons(25, 10, 10, 46, 0);
                yield return new Jevons(26, 11, 10, 19, 1);
                yield return new Jevons(27, 12, 10, 4, 2);
                yield return new Jevons(28, 9, 11, 2, -2);
                yield return new Jevons(29, 10, 11, 16, -1);
                yield return new Jevons(30, 11, 11, 26, 0);
                yield return new Jevons(31, 12, 11, 17, 1);
                yield return new Jevons(32, 13, 11, 7, 2);
                yield return new Jevons(33, 14, 11, 2, 3);
                yield return new Jevons(34, 10, 12, 2, -2);
                yield return new Jevons(35, 11, 12, 12, -1);
                yield return new Jevons(36, 12, 12, 19, 0);
                yield return new Jevons(37, 13, 12, 11, 1);
                yield return new Jevons(38, 14, 12, 3, 2);
                yield return new Jevons(39, 15, 12, 2, 3);
                yield return new Jevons(40, 12, 13, 3, -1);
                yield return new Jevons(41, 13, 13, 6, 0);
                yield return new Jevons(42, 14, 13, 3, 1);
                yield return new Jevons(43, 15, 13, 1, 2);
                yield return new Jevons(44, 12, 14, 1, -2);
                yield return new Jevons(45, 13, 14, 1, -1);
                yield return new Jevons(46, 14, 14, 4, 0);
                yield return new Jevons(47, 15, 14, 6, 1);
                yield return new Jevons(48, 13, 15, 1, -2);
                yield return new Jevons(49, 14, 15, 2, -1);
                yield return new Jevons(50, 15, 15, 2, 0);
            }
        }
    }
}
