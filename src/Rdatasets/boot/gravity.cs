// ReSharper disable All

namespace Rdatasets.boot
{
    using System.Collections.Generic;

    /// <summary>
    /// Acceleration Due to Gravity
    /// </summary>

    public class gravity
    {
        public readonly int g;
        public readonly int series;

        public gravity(int g, int series)
        {
            this.g = g;
            this.series = series;
        }

        public static IEnumerable<gravity> Data
        {
            get
            {
                yield return new gravity(76, 1);
                yield return new gravity(82, 1);
                yield return new gravity(83, 1);
                yield return new gravity(54, 1);
                yield return new gravity(35, 1);
                yield return new gravity(46, 1);
                yield return new gravity(87, 1);
                yield return new gravity(68, 1);
                yield return new gravity(87, 2);
                yield return new gravity(95, 2);
                yield return new gravity(98, 2);
                yield return new gravity(100, 2);
                yield return new gravity(109, 2);
                yield return new gravity(109, 2);
                yield return new gravity(100, 2);
                yield return new gravity(81, 2);
                yield return new gravity(75, 2);
                yield return new gravity(68, 2);
                yield return new gravity(67, 2);
                yield return new gravity(105, 3);
                yield return new gravity(83, 3);
                yield return new gravity(76, 3);
                yield return new gravity(75, 3);
                yield return new gravity(51, 3);
                yield return new gravity(76, 3);
                yield return new gravity(93, 3);
                yield return new gravity(75, 3);
                yield return new gravity(62, 3);
                yield return new gravity(95, 4);
                yield return new gravity(90, 4);
                yield return new gravity(76, 4);
                yield return new gravity(76, 4);
                yield return new gravity(87, 4);
                yield return new gravity(79, 4);
                yield return new gravity(77, 4);
                yield return new gravity(71, 4);
                yield return new gravity(76, 5);
                yield return new gravity(76, 5);
                yield return new gravity(78, 5);
                yield return new gravity(79, 5);
                yield return new gravity(72, 5);
                yield return new gravity(68, 5);
                yield return new gravity(75, 5);
                yield return new gravity(78, 5);
                yield return new gravity(78, 6);
                yield return new gravity(78, 6);
                yield return new gravity(78, 6);
                yield return new gravity(86, 6);
                yield return new gravity(87, 6);
                yield return new gravity(81, 6);
                yield return new gravity(73, 6);
                yield return new gravity(67, 6);
                yield return new gravity(75, 6);
                yield return new gravity(82, 6);
                yield return new gravity(83, 6);
                yield return new gravity(82, 7);
                yield return new gravity(79, 7);
                yield return new gravity(81, 7);
                yield return new gravity(79, 7);
                yield return new gravity(77, 7);
                yield return new gravity(79, 7);
                yield return new gravity(79, 7);
                yield return new gravity(78, 7);
                yield return new gravity(79, 7);
                yield return new gravity(82, 7);
                yield return new gravity(76, 7);
                yield return new gravity(73, 7);
                yield return new gravity(64, 7);
                yield return new gravity(84, 8);
                yield return new gravity(86, 8);
                yield return new gravity(85, 8);
                yield return new gravity(82, 8);
                yield return new gravity(77, 8);
                yield return new gravity(76, 8);
                yield return new gravity(77, 8);
                yield return new gravity(80, 8);
                yield return new gravity(83, 8);
                yield return new gravity(81, 8);
                yield return new gravity(78, 8);
                yield return new gravity(78, 8);
                yield return new gravity(78, 8);
            }
        }
    }
}
