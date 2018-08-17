// ReSharper disable All

namespace Rdatasets.DAAG
{
    using System.Collections.Generic;

    /// <summary>
    /// Frosted Flakes data
    /// </summary>

    public class frostedflakes
    {
        public readonly double Lab;
        public readonly double IA400;

        public frostedflakes(double Lab, double IA400)
        {
            this.Lab = Lab;
            this.IA400 = IA400;
        }

        public static IEnumerable<frostedflakes> Data
        {
            get
            {
                yield return new frostedflakes(36.3, 35.1);
                yield return new frostedflakes(33.2, 35.9);
                yield return new frostedflakes(39, 40.1);
                yield return new frostedflakes(37.3, 35.5);
                yield return new frostedflakes(40.7, 37.9);
                yield return new frostedflakes(38.4, 39.5);
                yield return new frostedflakes(35.8, 38.5);
                yield return new frostedflakes(36, 37.9);
                yield return new frostedflakes(37.9, 41.2);
                yield return new frostedflakes(42.6, 45.7);
                yield return new frostedflakes(40, 38.3);
                yield return new frostedflakes(43.5, 42.3);
                yield return new frostedflakes(36.6, 39);
                yield return new frostedflakes(33.7, 30.8);
                yield return new frostedflakes(40.5, 37.3);
                yield return new frostedflakes(38.7, 39.5);
                yield return new frostedflakes(36.2, 40.3);
                yield return new frostedflakes(41.6, 42);
                yield return new frostedflakes(37.8, 36.9);
                yield return new frostedflakes(40.5, 41.2);
                yield return new frostedflakes(38.9, 39.3);
                yield return new frostedflakes(36, 35.6);
                yield return new frostedflakes(41.1, 40.9);
                yield return new frostedflakes(40, 37.6);
                yield return new frostedflakes(35.5, 35.5);
                yield return new frostedflakes(34.3, 35.5);
                yield return new frostedflakes(33, 32.4);
                yield return new frostedflakes(36.9, 36.1);
                yield return new frostedflakes(36.3, 36.1);
                yield return new frostedflakes(38.5, 39);
                yield return new frostedflakes(35.1, 38.5);
                yield return new frostedflakes(38.7, 40);
                yield return new frostedflakes(34, 35.4);
                yield return new frostedflakes(42.3, 40.9);
                yield return new frostedflakes(41.4, 39.4);
                yield return new frostedflakes(38.2, 38.6);
                yield return new frostedflakes(38.3, 39.6);
                yield return new frostedflakes(37.4, 39.2);
                yield return new frostedflakes(37.5, 36.4);
                yield return new frostedflakes(36.5, 36.1);
                yield return new frostedflakes(34.8, 38.1);
                yield return new frostedflakes(38.1, 39.6);
                yield return new frostedflakes(41, 40.8);
                yield return new frostedflakes(35.4, 37.4);
                yield return new frostedflakes(35, 37.6);
                yield return new frostedflakes(37.9, 36);
                yield return new frostedflakes(39.1, 37.2);
                yield return new frostedflakes(33.3, 33);
                yield return new frostedflakes(40.4, 41.9);
                yield return new frostedflakes(34.9, 37.9);
                yield return new frostedflakes(33.5, 38.1);
                yield return new frostedflakes(35.8, 37.4);
                yield return new frostedflakes(36.6, 40.1);
                yield return new frostedflakes(38.3, 40.7);
                yield return new frostedflakes(33.1, 35.4);
                yield return new frostedflakes(37.4, 41.4);
                yield return new frostedflakes(39.9, 40.2);
                yield return new frostedflakes(38.4, 39.1);
                yield return new frostedflakes(36.1, 34.7);
                yield return new frostedflakes(33.6, 33.9);
                yield return new frostedflakes(35.1, 36.7);
                yield return new frostedflakes(37.4, 36.3);
                yield return new frostedflakes(38.2, 38.8);
                yield return new frostedflakes(39, 43);
                yield return new frostedflakes(31.6, 33.9);
                yield return new frostedflakes(36.1, 35.6);
                yield return new frostedflakes(36.6, 34.8);
                yield return new frostedflakes(36.4, 35.8);
                yield return new frostedflakes(39.9, 41.4);
                yield return new frostedflakes(38.8, 39.2);
                yield return new frostedflakes(39.1, 36.9);
                yield return new frostedflakes(34.7, 33.7);
                yield return new frostedflakes(37.3, 36.1);
                yield return new frostedflakes(39.1, 40.2);
                yield return new frostedflakes(38.8, 39.9);
                yield return new frostedflakes(38.7, 36.6);
                yield return new frostedflakes(36.5, 35.8);
                yield return new frostedflakes(37.3, 38.6);
                yield return new frostedflakes(39.9, 37.5);
                yield return new frostedflakes(34, 33.7);
                yield return new frostedflakes(39.4, 39.9);
                yield return new frostedflakes(36.4, 35.5);
                yield return new frostedflakes(34.8, 34.9);
                yield return new frostedflakes(41.1, 40.7);
                yield return new frostedflakes(33.8, 31.3);
                yield return new frostedflakes(41.4, 39.5);
                yield return new frostedflakes(39.1, 37.9);
                yield return new frostedflakes(38.3, 38.7);
                yield return new frostedflakes(37.7, 36.1);
                yield return new frostedflakes(38.4, 42.8);
                yield return new frostedflakes(40.9, 42.7);
                yield return new frostedflakes(36.5, 40.9);
                yield return new frostedflakes(40.5, 40);
                yield return new frostedflakes(39.7, 41.2);
                yield return new frostedflakes(40.6, 41.5);
                yield return new frostedflakes(38.9, 42);
                yield return new frostedflakes(39.3, 42.6);
                yield return new frostedflakes(37.1, 40.8);
                yield return new frostedflakes(35.6, 40.2);
                yield return new frostedflakes(36.8, 40.6);
            }
        }
    }
}
