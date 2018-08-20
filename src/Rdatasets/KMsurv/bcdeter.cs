// ReSharper disable All

namespace Rdatasets.KMsurv
{
    using System.Collections.Generic;

    /// <summary>
    /// data from Section 1.18
    /// </summary>

    public class bcdeter
    {
        public readonly int lower;
        public readonly int? upper;
        public readonly int treat;

        public bcdeter(int lower, int? upper, int treat)
        {
            this.lower = lower;
            this.upper = upper;
            this.treat = treat;
        }

        public static IEnumerable<bcdeter> Data
        {
            get
            {
                yield return new bcdeter(0, 5, 1);
                yield return new bcdeter(0, 7, 1);
                yield return new bcdeter(0, 8, 1);
                yield return new bcdeter(4, 11, 1);
                yield return new bcdeter(5, 11, 1);
                yield return new bcdeter(5, 12, 1);
                yield return new bcdeter(6, 10, 1);
                yield return new bcdeter(7, 14, 1);
                yield return new bcdeter(7, 16, 1);
                yield return new bcdeter(11, 15, 1);
                yield return new bcdeter(11, 18, 1);
                yield return new bcdeter(17, 25, 1);
                yield return new bcdeter(17, 25, 1);
                yield return new bcdeter(18, 26, 1);
                yield return new bcdeter(19, 35, 1);
                yield return new bcdeter(25, 37, 1);
                yield return new bcdeter(26, 40, 1);
                yield return new bcdeter(27, 34, 1);
                yield return new bcdeter(36, 44, 1);
                yield return new bcdeter(36, 48, 1);
                yield return new bcdeter(37, 44, 1);
                yield return new bcdeter(0, 5, 2);
                yield return new bcdeter(0, 22, 2);
                yield return new bcdeter(4, 8, 2);
                yield return new bcdeter(4, 9, 2);
                yield return new bcdeter(5, 8, 2);
                yield return new bcdeter(8, 12, 2);
                yield return new bcdeter(8, 21, 2);
                yield return new bcdeter(10, 17, 2);
                yield return new bcdeter(10, 35, 2);
                yield return new bcdeter(11, 13, 2);
                yield return new bcdeter(11, 17, 2);
                yield return new bcdeter(11, 20, 2);
                yield return new bcdeter(12, 20, 2);
                yield return new bcdeter(13, 39, 2);
                yield return new bcdeter(14, 17, 2);
                yield return new bcdeter(14, 19, 2);
                yield return new bcdeter(15, 22, 2);
                yield return new bcdeter(16, 20, 2);
                yield return new bcdeter(16, 24, 2);
                yield return new bcdeter(16, 24, 2);
                yield return new bcdeter(16, 60, 2);
                yield return new bcdeter(17, 23, 2);
                yield return new bcdeter(17, 26, 2);
                yield return new bcdeter(17, 27, 2);
                yield return new bcdeter(18, 24, 2);
                yield return new bcdeter(18, 25, 2);
                yield return new bcdeter(19, 32, 2);
                yield return new bcdeter(22, 32, 2);
                yield return new bcdeter(24, 30, 2);
                yield return new bcdeter(24, 31, 2);
                yield return new bcdeter(30, 34, 2);
                yield return new bcdeter(30, 36, 2);
                yield return new bcdeter(33, 40, 2);
                yield return new bcdeter(34, 34, 2);
                yield return new bcdeter(35, 39, 2);
                yield return new bcdeter(44, 48, 2);
                yield return new bcdeter(48, 48, 2);
                yield return new bcdeter(15, null, 1);
                yield return new bcdeter(17, null, 1);
                yield return new bcdeter(18, null, 1);
                yield return new bcdeter(22, null, 1);
                yield return new bcdeter(24, null, 1);
                yield return new bcdeter(24, null, 1);
                yield return new bcdeter(32, null, 1);
                yield return new bcdeter(33, null, 1);
                yield return new bcdeter(34, null, 1);
                yield return new bcdeter(36, null, 1);
                yield return new bcdeter(36, null, 1);
                yield return new bcdeter(37, null, 1);
                yield return new bcdeter(37, null, 1);
                yield return new bcdeter(37, null, 1);
                yield return new bcdeter(38, null, 1);
                yield return new bcdeter(40, null, 1);
                yield return new bcdeter(45, null, 1);
                yield return new bcdeter(46, null, 1);
                yield return new bcdeter(46, null, 1);
                yield return new bcdeter(46, null, 1);
                yield return new bcdeter(46, null, 1);
                yield return new bcdeter(46, null, 1);
                yield return new bcdeter(46, null, 1);
                yield return new bcdeter(46, null, 1);
                yield return new bcdeter(46, null, 1);
                yield return new bcdeter(11, null, 2);
                yield return new bcdeter(11, null, 2);
                yield return new bcdeter(13, null, 2);
                yield return new bcdeter(13, null, 2);
                yield return new bcdeter(13, null, 2);
                yield return new bcdeter(21, null, 2);
                yield return new bcdeter(23, null, 2);
                yield return new bcdeter(31, null, 2);
                yield return new bcdeter(32, null, 2);
                yield return new bcdeter(34, null, 2);
                yield return new bcdeter(34, null, 2);
                yield return new bcdeter(35, null, 2);
            }
        }
    }
}
