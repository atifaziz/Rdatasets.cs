// ReSharper disable All

namespace Rdatasets.HistData
{
    using System.Collections.Generic;

    /// <summary>
    /// W. Stanley Jevons' data on numerical discrimination
    /// </summary>

    public class Jevons
    {
        public readonly int actual;
        public readonly int estimated;
        public readonly int frequency;
        public readonly int error;

        public Jevons(int actual, int estimated, int frequency, int error)
        {
            this.actual = actual;
            this.estimated = estimated;
            this.frequency = frequency;
            this.error = error;
        }

        public static IEnumerable<Jevons> Data
        {
            get
            {
                yield return new Jevons(3, 3, 23, 0);
                yield return new Jevons(4, 4, 65, 0);
                yield return new Jevons(5, 5, 102, 0);
                yield return new Jevons(6, 5, 7, 1);
                yield return new Jevons(5, 6, 4, -1);
                yield return new Jevons(6, 6, 120, 0);
                yield return new Jevons(7, 6, 18, 1);
                yield return new Jevons(5, 7, 1, -2);
                yield return new Jevons(6, 7, 20, -1);
                yield return new Jevons(7, 7, 113, 0);
                yield return new Jevons(8, 7, 30, 1);
                yield return new Jevons(9, 7, 2, 2);
                yield return new Jevons(7, 8, 25, -1);
                yield return new Jevons(8, 8, 76, 0);
                yield return new Jevons(9, 8, 24, 1);
                yield return new Jevons(10, 8, 6, 2);
                yield return new Jevons(11, 8, 1, 3);
                yield return new Jevons(8, 9, 28, -1);
                yield return new Jevons(9, 9, 76, 0);
                yield return new Jevons(10, 9, 37, 1);
                yield return new Jevons(11, 9, 11, 2);
                yield return new Jevons(12, 9, 1, 3);
                yield return new Jevons(8, 10, 1, -2);
                yield return new Jevons(9, 10, 18, -1);
                yield return new Jevons(10, 10, 46, 0);
                yield return new Jevons(11, 10, 19, 1);
                yield return new Jevons(12, 10, 4, 2);
                yield return new Jevons(9, 11, 2, -2);
                yield return new Jevons(10, 11, 16, -1);
                yield return new Jevons(11, 11, 26, 0);
                yield return new Jevons(12, 11, 17, 1);
                yield return new Jevons(13, 11, 7, 2);
                yield return new Jevons(14, 11, 2, 3);
                yield return new Jevons(10, 12, 2, -2);
                yield return new Jevons(11, 12, 12, -1);
                yield return new Jevons(12, 12, 19, 0);
                yield return new Jevons(13, 12, 11, 1);
                yield return new Jevons(14, 12, 3, 2);
                yield return new Jevons(15, 12, 2, 3);
                yield return new Jevons(12, 13, 3, -1);
                yield return new Jevons(13, 13, 6, 0);
                yield return new Jevons(14, 13, 3, 1);
                yield return new Jevons(15, 13, 1, 2);
                yield return new Jevons(12, 14, 1, -2);
                yield return new Jevons(13, 14, 1, -1);
                yield return new Jevons(14, 14, 4, 0);
                yield return new Jevons(15, 14, 6, 1);
                yield return new Jevons(13, 15, 1, -2);
                yield return new Jevons(14, 15, 2, -1);
                yield return new Jevons(15, 15, 2, 0);
            }
        }
    }
}
