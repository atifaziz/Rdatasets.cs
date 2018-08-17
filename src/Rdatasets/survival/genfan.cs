// ReSharper disable All

namespace Rdatasets.survival
{
    using System.Collections.Generic;

    /// <summary>
    /// Generator fans
    /// </summary>

    public class genfan
    {
        public readonly double hours;
        public readonly int status;

        public genfan(double hours, int status)
        {
            this.hours = hours;
            this.status = status;
        }

        public static IEnumerable<genfan> Data
        {
            get
            {
                yield return new genfan(4.5, 1);
                yield return new genfan(4.6, 0);
                yield return new genfan(11.5, 1);
                yield return new genfan(11.5, 1);
                yield return new genfan(15.6, 0);
                yield return new genfan(16, 1);
                yield return new genfan(16.6, 0);
                yield return new genfan(18.5, 0);
                yield return new genfan(18.5, 0);
                yield return new genfan(18.5, 0);
                yield return new genfan(18.5, 0);
                yield return new genfan(18.5, 0);
                yield return new genfan(20.3, 0);
                yield return new genfan(20.3, 0);
                yield return new genfan(20.3, 0);
                yield return new genfan(20.7, 1);
                yield return new genfan(20.7, 1);
                yield return new genfan(20.8, 1);
                yield return new genfan(22, 0);
                yield return new genfan(30, 0);
                yield return new genfan(30, 0);
                yield return new genfan(30, 0);
                yield return new genfan(30, 0);
                yield return new genfan(31, 1);
                yield return new genfan(32, 0);
                yield return new genfan(34.5, 1);
                yield return new genfan(37.5, 0);
                yield return new genfan(37.5, 0);
                yield return new genfan(41.5, 0);
                yield return new genfan(41.5, 0);
                yield return new genfan(41.5, 0);
                yield return new genfan(41.5, 0);
                yield return new genfan(43, 0);
                yield return new genfan(43, 0);
                yield return new genfan(43, 0);
                yield return new genfan(43, 0);
                yield return new genfan(46, 1);
                yield return new genfan(48.5, 0);
                yield return new genfan(48.5, 0);
                yield return new genfan(48.5, 0);
                yield return new genfan(48.5, 0);
                yield return new genfan(50, 0);
                yield return new genfan(50, 0);
                yield return new genfan(50, 0);
                yield return new genfan(61, 0);
                yield return new genfan(61, 1);
                yield return new genfan(61, 0);
                yield return new genfan(61, 0);
                yield return new genfan(63, 0);
                yield return new genfan(64.5, 0);
                yield return new genfan(64.5, 0);
                yield return new genfan(67, 0);
                yield return new genfan(74.5, 0);
                yield return new genfan(78, 0);
                yield return new genfan(78, 0);
                yield return new genfan(81, 0);
                yield return new genfan(81, 0);
                yield return new genfan(82, 0);
                yield return new genfan(85, 0);
                yield return new genfan(85, 0);
                yield return new genfan(85, 0);
                yield return new genfan(87.5, 0);
                yield return new genfan(87.5, 1);
                yield return new genfan(87.5, 0);
                yield return new genfan(94, 0);
                yield return new genfan(99, 0);
                yield return new genfan(101, 0);
                yield return new genfan(101, 0);
                yield return new genfan(101, 0);
                yield return new genfan(115, 0);
            }
        }
    }
}
