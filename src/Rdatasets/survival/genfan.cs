// ReSharper disable All

namespace Rdatasets.survival
{
    using System.Collections.Generic;

    /// <summary>
    /// Generator fans
    /// </summary>

    public class genfan
    {
        public readonly int κ;
        public readonly double hours;
        public readonly int status;

        public genfan(int κ, double hours, int status)
        {
            this.κ = κ;
            this.hours = hours;
            this.status = status;
        }

        public static IEnumerable<genfan> Data
        {
            get
            {
                yield return new genfan(1, 4.5, 1);
                yield return new genfan(2, 4.6, 0);
                yield return new genfan(3, 11.5, 1);
                yield return new genfan(4, 11.5, 1);
                yield return new genfan(5, 15.6, 0);
                yield return new genfan(6, 16, 1);
                yield return new genfan(7, 16.6, 0);
                yield return new genfan(8, 18.5, 0);
                yield return new genfan(9, 18.5, 0);
                yield return new genfan(10, 18.5, 0);
                yield return new genfan(11, 18.5, 0);
                yield return new genfan(12, 18.5, 0);
                yield return new genfan(13, 20.3, 0);
                yield return new genfan(14, 20.3, 0);
                yield return new genfan(15, 20.3, 0);
                yield return new genfan(16, 20.7, 1);
                yield return new genfan(17, 20.7, 1);
                yield return new genfan(18, 20.8, 1);
                yield return new genfan(19, 22, 0);
                yield return new genfan(20, 30, 0);
                yield return new genfan(21, 30, 0);
                yield return new genfan(22, 30, 0);
                yield return new genfan(23, 30, 0);
                yield return new genfan(24, 31, 1);
                yield return new genfan(25, 32, 0);
                yield return new genfan(26, 34.5, 1);
                yield return new genfan(27, 37.5, 0);
                yield return new genfan(28, 37.5, 0);
                yield return new genfan(29, 41.5, 0);
                yield return new genfan(30, 41.5, 0);
                yield return new genfan(31, 41.5, 0);
                yield return new genfan(32, 41.5, 0);
                yield return new genfan(33, 43, 0);
                yield return new genfan(34, 43, 0);
                yield return new genfan(35, 43, 0);
                yield return new genfan(36, 43, 0);
                yield return new genfan(37, 46, 1);
                yield return new genfan(38, 48.5, 0);
                yield return new genfan(39, 48.5, 0);
                yield return new genfan(40, 48.5, 0);
                yield return new genfan(41, 48.5, 0);
                yield return new genfan(42, 50, 0);
                yield return new genfan(43, 50, 0);
                yield return new genfan(44, 50, 0);
                yield return new genfan(45, 61, 0);
                yield return new genfan(46, 61, 1);
                yield return new genfan(47, 61, 0);
                yield return new genfan(48, 61, 0);
                yield return new genfan(49, 63, 0);
                yield return new genfan(50, 64.5, 0);
                yield return new genfan(51, 64.5, 0);
                yield return new genfan(52, 67, 0);
                yield return new genfan(53, 74.5, 0);
                yield return new genfan(54, 78, 0);
                yield return new genfan(55, 78, 0);
                yield return new genfan(56, 81, 0);
                yield return new genfan(57, 81, 0);
                yield return new genfan(58, 82, 0);
                yield return new genfan(59, 85, 0);
                yield return new genfan(60, 85, 0);
                yield return new genfan(61, 85, 0);
                yield return new genfan(62, 87.5, 0);
                yield return new genfan(63, 87.5, 1);
                yield return new genfan(64, 87.5, 0);
                yield return new genfan(65, 94, 0);
                yield return new genfan(66, 99, 0);
                yield return new genfan(67, 101, 0);
                yield return new genfan(68, 101, 0);
                yield return new genfan(69, 101, 0);
                yield return new genfan(70, 115, 0);
            }
        }
    }
}
