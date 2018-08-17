// ReSharper disable All

namespace Rdatasets.DAAG
{
    using System.Collections.Generic;

    /// <summary>
    /// Seismic Timing Data
    /// </summary>

    public class geophones
    {
        public readonly double distance;
        public readonly int thickness;

        public geophones(double distance, int thickness)
        {
            this.distance = distance;
            this.thickness = thickness;
        }

        public static IEnumerable<geophones> Data
        {
            get
            {
                yield return new geophones(13.75, 279);
                yield return new geophones(15, 278);
                yield return new geophones(16.25, 280);
                yield return new geophones(17.5, 278);
                yield return new geophones(18.75, 275);
                yield return new geophones(20, 274);
                yield return new geophones(21.25, 276);
                yield return new geophones(22.5, 277);
                yield return new geophones(23.75, 276);
                yield return new geophones(25, 275);
                yield return new geophones(26.25, 277);
                yield return new geophones(27.5, 278);
                yield return new geophones(28.75, 276);
                yield return new geophones(30, 276);
                yield return new geophones(31.25, 278);
                yield return new geophones(32.5, 276);
                yield return new geophones(33.75, 275);
                yield return new geophones(35, 273);
                yield return new geophones(36.25, 283);
                yield return new geophones(37.5, 279);
                yield return new geophones(38.75, 279);
                yield return new geophones(40, 278);
                yield return new geophones(41.25, 276);
                yield return new geophones(42.5, 276);
                yield return new geophones(43.75, 275);
                yield return new geophones(45, 273);
                yield return new geophones(46.25, 274);
                yield return new geophones(47.5, 274);
                yield return new geophones(48.75, 275);
                yield return new geophones(50, 276);
                yield return new geophones(51.25, 275);
                yield return new geophones(52.5, 276);
                yield return new geophones(53.75, 276);
                yield return new geophones(55, 271);
                yield return new geophones(56.25, 274);
                yield return new geophones(57.5, 270);
                yield return new geophones(58.75, 270);
                yield return new geophones(61.25, 270);
                yield return new geophones(62.5, 273);
                yield return new geophones(63.75, 270);
                yield return new geophones(65, 260);
                yield return new geophones(66.25, 267);
                yield return new geophones(67.5, 261);
                yield return new geophones(68.75, 260);
                yield return new geophones(70, 256);
                yield return new geophones(71.25, 251);
                yield return new geophones(72.5, 249);
                yield return new geophones(73.75, 248);
                yield return new geophones(75, 248);
                yield return new geophones(76.25, 250);
                yield return new geophones(77.5, 251);
                yield return new geophones(78.75, 253);
                yield return new geophones(80, 251);
                yield return new geophones(81.25, 251);
                yield return new geophones(82.5, 254);
                yield return new geophones(83.75, 257);
            }
        }
    }
}
