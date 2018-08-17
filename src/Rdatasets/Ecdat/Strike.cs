// ReSharper disable All

namespace Rdatasets.Ecdat
{
    using System.Collections.Generic;

    /// <summary>
    /// Strike Duration Data
    /// </summary>

    public class Strike
    {
        public readonly int duration;
        public readonly double prod;

        public Strike(int duration, double prod)
        {
            this.duration = duration;
            this.prod = prod;
        }

        public static IEnumerable<Strike> Data
        {
            get
            {
                yield return new Strike(7, 0.01138);
                yield return new Strike(9, 0.01138);
                yield return new Strike(13, 0.01138);
                yield return new Strike(14, 0.01138);
                yield return new Strike(26, 0.01138);
                yield return new Strike(29, 0.01138);
                yield return new Strike(52, 0.01138);
                yield return new Strike(130, 0.01138);
                yield return new Strike(9, 0.02299);
                yield return new Strike(37, 0.02299);
                yield return new Strike(41, 0.02299);
                yield return new Strike(49, 0.02299);
                yield return new Strike(52, 0.02299);
                yield return new Strike(119, 0.02299);
                yield return new Strike(3, -0.03957);
                yield return new Strike(17, -0.03957);
                yield return new Strike(19, -0.03957);
                yield return new Strike(28, -0.03957);
                yield return new Strike(72, -0.03957);
                yield return new Strike(99, -0.03957);
                yield return new Strike(104, -0.03957);
                yield return new Strike(114, -0.03957);
                yield return new Strike(152, -0.03957);
                yield return new Strike(153, -0.03957);
                yield return new Strike(216, -0.03957);
                yield return new Strike(15, -0.05467);
                yield return new Strike(61, -0.05467);
                yield return new Strike(98, -0.05467);
                yield return new Strike(2, 0.00535);
                yield return new Strike(25, 0.00535);
                yield return new Strike(85, 0.00535);
                yield return new Strike(3, 0.07427);
                yield return new Strike(10, 0.07427);
                yield return new Strike(1, 0.0645);
                yield return new Strike(2, 0.0645);
                yield return new Strike(3, 0.0645);
                yield return new Strike(3, 0.0645);
                yield return new Strike(3, 0.0645);
                yield return new Strike(4, 0.0645);
                yield return new Strike(8, 0.0645);
                yield return new Strike(11, 0.0645);
                yield return new Strike(22, 0.0645);
                yield return new Strike(23, 0.0645);
                yield return new Strike(27, 0.0645);
                yield return new Strike(32, 0.0645);
                yield return new Strike(33, 0.0645);
                yield return new Strike(35, 0.0645);
                yield return new Strike(43, 0.0645);
                yield return new Strike(43, 0.0645);
                yield return new Strike(44, 0.0645);
                yield return new Strike(100, 0.0645);
                yield return new Strike(5, -0.10443);
                yield return new Strike(49, -0.10443);
                yield return new Strike(2, -0.007);
                yield return new Strike(12, -0.007);
                yield return new Strike(12, -0.007);
                yield return new Strike(21, -0.007);
                yield return new Strike(21, -0.007);
                yield return new Strike(27, -0.007);
                yield return new Strike(38, -0.007);
                yield return new Strike(42, -0.007);
                yield return new Strike(117, -0.007);
            }
        }
    }
}
