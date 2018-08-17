// ReSharper disable All

namespace Rdatasets.boot
{
    using System.Collections.Generic;

    /// <summary>
    /// Acceleration Due to Gravity
    /// </summary>

    public class grav
    {
        public readonly int g;
        public readonly int series;

        public grav(int g, int series)
        {
            this.g = g;
            this.series = series;
        }

        public static IEnumerable<grav> Data
        {
            get
            {
                yield return new grav(82, 7);
                yield return new grav(79, 7);
                yield return new grav(81, 7);
                yield return new grav(79, 7);
                yield return new grav(77, 7);
                yield return new grav(79, 7);
                yield return new grav(79, 7);
                yield return new grav(78, 7);
                yield return new grav(79, 7);
                yield return new grav(82, 7);
                yield return new grav(76, 7);
                yield return new grav(73, 7);
                yield return new grav(64, 7);
                yield return new grav(84, 8);
                yield return new grav(86, 8);
                yield return new grav(85, 8);
                yield return new grav(82, 8);
                yield return new grav(77, 8);
                yield return new grav(76, 8);
                yield return new grav(77, 8);
                yield return new grav(80, 8);
                yield return new grav(83, 8);
                yield return new grav(81, 8);
                yield return new grav(78, 8);
                yield return new grav(78, 8);
                yield return new grav(78, 8);
            }
        }
    }
}
