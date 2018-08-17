// ReSharper disable All

namespace Rdatasets.boot
{
    using System.Collections.Generic;

    /// <summary>
    /// Counts of Balsam-fir Seedlings
    /// </summary>

    public class fir
    {
        public readonly int count;
        public readonly int row;
        public readonly int col;

        public fir(int count, int row, int col)
        {
            this.count = count;
            this.row = row;
            this.col = col;
        }

        public static IEnumerable<fir> Data
        {
            get
            {
                yield return new fir(0, 1, 1);
                yield return new fir(1, 1, 2);
                yield return new fir(2, 1, 3);
                yield return new fir(3, 1, 4);
                yield return new fir(4, 1, 5);
                yield return new fir(3, 1, 6);
                yield return new fir(4, 1, 7);
                yield return new fir(2, 1, 8);
                yield return new fir(2, 1, 9);
                yield return new fir(1, 1, 10);
                yield return new fir(0, 2, 1);
                yield return new fir(2, 2, 2);
                yield return new fir(0, 2, 3);
                yield return new fir(2, 2, 4);
                yield return new fir(4, 2, 5);
                yield return new fir(2, 2, 6);
                yield return new fir(3, 2, 7);
                yield return new fir(3, 2, 8);
                yield return new fir(4, 2, 9);
                yield return new fir(2, 2, 10);
                yield return new fir(1, 3, 1);
                yield return new fir(1, 3, 2);
                yield return new fir(1, 3, 3);
                yield return new fir(1, 3, 4);
                yield return new fir(4, 3, 5);
                yield return new fir(1, 3, 6);
                yield return new fir(5, 3, 7);
                yield return new fir(2, 3, 8);
                yield return new fir(2, 3, 9);
                yield return new fir(3, 3, 10);
                yield return new fir(4, 4, 1);
                yield return new fir(1, 4, 2);
                yield return new fir(2, 4, 3);
                yield return new fir(5, 4, 4);
                yield return new fir(2, 4, 5);
                yield return new fir(0, 4, 6);
                yield return new fir(3, 4, 7);
                yield return new fir(2, 4, 8);
                yield return new fir(1, 4, 9);
                yield return new fir(1, 4, 10);
                yield return new fir(3, 5, 1);
                yield return new fir(1, 5, 2);
                yield return new fir(4, 5, 3);
                yield return new fir(3, 5, 4);
                yield return new fir(1, 5, 5);
                yield return new fir(0, 5, 6);
                yield return new fir(0, 5, 7);
                yield return new fir(2, 5, 8);
                yield return new fir(7, 5, 9);
                yield return new fir(0, 5, 10);
            }
        }
    }
}
