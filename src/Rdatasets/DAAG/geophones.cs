// ReSharper disable All

namespace Rdatasets.DAAG
{
    using System.Collections.Generic;

    /// <summary>
    /// Seismic Timing Data
    /// </summary>

    public class geophones
    {
        public readonly int κ;
        public readonly double distance;
        public readonly int thickness;

        public geophones(int κ, double distance, int thickness)
        {
            this.κ = κ;
            this.distance = distance;
            this.thickness = thickness;
        }

        public static IEnumerable<geophones> Data
        {
            get
            {
                yield return new geophones(1, 13.75, 279);
                yield return new geophones(2, 15, 278);
                yield return new geophones(3, 16.25, 280);
                yield return new geophones(4, 17.5, 278);
                yield return new geophones(5, 18.75, 275);
                yield return new geophones(6, 20, 274);
                yield return new geophones(7, 21.25, 276);
                yield return new geophones(8, 22.5, 277);
                yield return new geophones(9, 23.75, 276);
                yield return new geophones(10, 25, 275);
                yield return new geophones(11, 26.25, 277);
                yield return new geophones(12, 27.5, 278);
                yield return new geophones(13, 28.75, 276);
                yield return new geophones(14, 30, 276);
                yield return new geophones(15, 31.25, 278);
                yield return new geophones(16, 32.5, 276);
                yield return new geophones(17, 33.75, 275);
                yield return new geophones(18, 35, 273);
                yield return new geophones(19, 36.25, 283);
                yield return new geophones(20, 37.5, 279);
                yield return new geophones(21, 38.75, 279);
                yield return new geophones(22, 40, 278);
                yield return new geophones(23, 41.25, 276);
                yield return new geophones(24, 42.5, 276);
                yield return new geophones(25, 43.75, 275);
                yield return new geophones(26, 45, 273);
                yield return new geophones(27, 46.25, 274);
                yield return new geophones(28, 47.5, 274);
                yield return new geophones(29, 48.75, 275);
                yield return new geophones(30, 50, 276);
                yield return new geophones(31, 51.25, 275);
                yield return new geophones(32, 52.5, 276);
                yield return new geophones(33, 53.75, 276);
                yield return new geophones(34, 55, 271);
                yield return new geophones(35, 56.25, 274);
                yield return new geophones(36, 57.5, 270);
                yield return new geophones(37, 58.75, 270);
                yield return new geophones(38, 61.25, 270);
                yield return new geophones(39, 62.5, 273);
                yield return new geophones(40, 63.75, 270);
                yield return new geophones(41, 65, 260);
                yield return new geophones(42, 66.25, 267);
                yield return new geophones(43, 67.5, 261);
                yield return new geophones(44, 68.75, 260);
                yield return new geophones(45, 70, 256);
                yield return new geophones(46, 71.25, 251);
                yield return new geophones(47, 72.5, 249);
                yield return new geophones(48, 73.75, 248);
                yield return new geophones(49, 75, 248);
                yield return new geophones(50, 76.25, 250);
                yield return new geophones(51, 77.5, 251);
                yield return new geophones(52, 78.75, 253);
                yield return new geophones(53, 80, 251);
                yield return new geophones(55, 81.25, 251);
                yield return new geophones(56, 82.5, 254);
                yield return new geophones(57, 83.75, 257);
            }
        }
    }
}
