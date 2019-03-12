// ReSharper disable All

namespace Rdatasets.boot
{
    using System.Collections.Generic;

    /// <summary>
    /// Acceleration Due to Gravity
    /// </summary>

    public class grav
    {
        public readonly int κ;
        public readonly int g;
        public readonly int series;

        public grav(int κ, int g, int series)
        {
            this.κ = κ;
            this.g = g;
            this.series = series;
        }

        public static IEnumerable<grav> Data
        {
            get
            {
                yield return new grav(56, 82, 7);
                yield return new grav(57, 79, 7);
                yield return new grav(58, 81, 7);
                yield return new grav(59, 79, 7);
                yield return new grav(60, 77, 7);
                yield return new grav(61, 79, 7);
                yield return new grav(62, 79, 7);
                yield return new grav(63, 78, 7);
                yield return new grav(64, 79, 7);
                yield return new grav(65, 82, 7);
                yield return new grav(66, 76, 7);
                yield return new grav(67, 73, 7);
                yield return new grav(68, 64, 7);
                yield return new grav(69, 84, 8);
                yield return new grav(70, 86, 8);
                yield return new grav(71, 85, 8);
                yield return new grav(72, 82, 8);
                yield return new grav(73, 77, 8);
                yield return new grav(74, 76, 8);
                yield return new grav(75, 77, 8);
                yield return new grav(76, 80, 8);
                yield return new grav(77, 83, 8);
                yield return new grav(78, 81, 8);
                yield return new grav(79, 78, 8);
                yield return new grav(80, 78, 8);
                yield return new grav(81, 78, 8);
            }
        }
    }
}
