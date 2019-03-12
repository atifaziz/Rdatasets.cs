// ReSharper disable All

namespace Rdatasets.boot
{
    using System.Collections.Generic;

    /// <summary>
    /// Counts of Balsam-fir Seedlings
    /// </summary>

    public class fir
    {
        public readonly int κ;
        public readonly int count;
        public readonly int row;
        public readonly int col;

        public fir(int κ, int count, int row, int col)
        {
            this.κ = κ;
            this.count = count;
            this.row = row;
            this.col = col;
        }

        public static IEnumerable<fir> Data
        {
            get
            {
                yield return new fir(1, 0, 1, 1);
                yield return new fir(2, 1, 1, 2);
                yield return new fir(3, 2, 1, 3);
                yield return new fir(4, 3, 1, 4);
                yield return new fir(5, 4, 1, 5);
                yield return new fir(6, 3, 1, 6);
                yield return new fir(7, 4, 1, 7);
                yield return new fir(8, 2, 1, 8);
                yield return new fir(9, 2, 1, 9);
                yield return new fir(10, 1, 1, 10);
                yield return new fir(11, 0, 2, 1);
                yield return new fir(12, 2, 2, 2);
                yield return new fir(13, 0, 2, 3);
                yield return new fir(14, 2, 2, 4);
                yield return new fir(15, 4, 2, 5);
                yield return new fir(16, 2, 2, 6);
                yield return new fir(17, 3, 2, 7);
                yield return new fir(18, 3, 2, 8);
                yield return new fir(19, 4, 2, 9);
                yield return new fir(20, 2, 2, 10);
                yield return new fir(21, 1, 3, 1);
                yield return new fir(22, 1, 3, 2);
                yield return new fir(23, 1, 3, 3);
                yield return new fir(24, 1, 3, 4);
                yield return new fir(25, 4, 3, 5);
                yield return new fir(26, 1, 3, 6);
                yield return new fir(27, 5, 3, 7);
                yield return new fir(28, 2, 3, 8);
                yield return new fir(29, 2, 3, 9);
                yield return new fir(30, 3, 3, 10);
                yield return new fir(31, 4, 4, 1);
                yield return new fir(32, 1, 4, 2);
                yield return new fir(33, 2, 4, 3);
                yield return new fir(34, 5, 4, 4);
                yield return new fir(35, 2, 4, 5);
                yield return new fir(36, 0, 4, 6);
                yield return new fir(37, 3, 4, 7);
                yield return new fir(38, 2, 4, 8);
                yield return new fir(39, 1, 4, 9);
                yield return new fir(40, 1, 4, 10);
                yield return new fir(41, 3, 5, 1);
                yield return new fir(42, 1, 5, 2);
                yield return new fir(43, 4, 5, 3);
                yield return new fir(44, 3, 5, 4);
                yield return new fir(45, 1, 5, 5);
                yield return new fir(46, 0, 5, 6);
                yield return new fir(47, 0, 5, 7);
                yield return new fir(48, 2, 5, 8);
                yield return new fir(49, 7, 5, 9);
                yield return new fir(50, 0, 5, 10);
            }
        }
    }
}
