// ReSharper disable All

namespace Rdatasets.Ecdat
{
    using System.Collections.Generic;

    /// <summary>
    /// Strike Duration Data
    /// </summary>

    public class Strike
    {
        public readonly int κ;
        public readonly int duration;
        public readonly double prod;

        public Strike(int κ, int duration, double prod)
        {
            this.κ = κ;
            this.duration = duration;
            this.prod = prod;
        }

        public static IEnumerable<Strike> Data
        {
            get
            {
                yield return new Strike(1, 7, 0.01138);
                yield return new Strike(2, 9, 0.01138);
                yield return new Strike(3, 13, 0.01138);
                yield return new Strike(4, 14, 0.01138);
                yield return new Strike(5, 26, 0.01138);
                yield return new Strike(6, 29, 0.01138);
                yield return new Strike(7, 52, 0.01138);
                yield return new Strike(8, 130, 0.01138);
                yield return new Strike(9, 9, 0.02299);
                yield return new Strike(10, 37, 0.02299);
                yield return new Strike(11, 41, 0.02299);
                yield return new Strike(12, 49, 0.02299);
                yield return new Strike(13, 52, 0.02299);
                yield return new Strike(14, 119, 0.02299);
                yield return new Strike(15, 3, -0.03957);
                yield return new Strike(16, 17, -0.03957);
                yield return new Strike(17, 19, -0.03957);
                yield return new Strike(18, 28, -0.03957);
                yield return new Strike(19, 72, -0.03957);
                yield return new Strike(20, 99, -0.03957);
                yield return new Strike(21, 104, -0.03957);
                yield return new Strike(22, 114, -0.03957);
                yield return new Strike(23, 152, -0.03957);
                yield return new Strike(24, 153, -0.03957);
                yield return new Strike(25, 216, -0.03957);
                yield return new Strike(26, 15, -0.05467);
                yield return new Strike(27, 61, -0.05467);
                yield return new Strike(28, 98, -0.05467);
                yield return new Strike(29, 2, 0.00535);
                yield return new Strike(30, 25, 0.00535);
                yield return new Strike(31, 85, 0.00535);
                yield return new Strike(32, 3, 0.07427);
                yield return new Strike(33, 10, 0.07427);
                yield return new Strike(34, 1, 0.0645);
                yield return new Strike(35, 2, 0.0645);
                yield return new Strike(36, 3, 0.0645);
                yield return new Strike(37, 3, 0.0645);
                yield return new Strike(38, 3, 0.0645);
                yield return new Strike(39, 4, 0.0645);
                yield return new Strike(40, 8, 0.0645);
                yield return new Strike(41, 11, 0.0645);
                yield return new Strike(42, 22, 0.0645);
                yield return new Strike(43, 23, 0.0645);
                yield return new Strike(44, 27, 0.0645);
                yield return new Strike(45, 32, 0.0645);
                yield return new Strike(46, 33, 0.0645);
                yield return new Strike(47, 35, 0.0645);
                yield return new Strike(48, 43, 0.0645);
                yield return new Strike(49, 43, 0.0645);
                yield return new Strike(50, 44, 0.0645);
                yield return new Strike(51, 100, 0.0645);
                yield return new Strike(52, 5, -0.10443);
                yield return new Strike(53, 49, -0.10443);
                yield return new Strike(54, 2, -0.007);
                yield return new Strike(55, 12, -0.007);
                yield return new Strike(56, 12, -0.007);
                yield return new Strike(57, 21, -0.007);
                yield return new Strike(58, 21, -0.007);
                yield return new Strike(59, 27, -0.007);
                yield return new Strike(60, 38, -0.007);
                yield return new Strike(61, 42, -0.007);
                yield return new Strike(62, 117, -0.007);
            }
        }
    }
}
