// ReSharper disable All

namespace Rdatasets.boot
{
    using System.Collections.Generic;

    /// <summary>
    /// Pole Positions of New Caledonian Laterites
    /// </summary>

    public class polar
    {
        public readonly int κ;
        public readonly double lat;
        public readonly double @long;

        public polar(int κ, double lat, double @long)
        {
            this.κ = κ;
            this.lat = lat;
            this.@long = @long;
        }

        public static IEnumerable<polar> Data
        {
            get
            {
                yield return new polar(1, -26.4, 324);
                yield return new polar(2, -32.2, 163.7);
                yield return new polar(3, -73.1, 51.9);
                yield return new polar(4, -80.2, 140.5);
                yield return new polar(5, -71.1, 267.2);
                yield return new polar(6, -58.7, 32);
                yield return new polar(7, -40.8, 28.1);
                yield return new polar(8, -14.9, 266.3);
                yield return new polar(9, -66.1, 144.3);
                yield return new polar(10, -1.8, 256.2);
                yield return new polar(11, -52.1, 83.2);
                yield return new polar(12, -77.3, 182.1);
                yield return new polar(13, -68.8, 110.4);
                yield return new polar(14, -68.4, 142.2);
                yield return new polar(15, -29.2, 246.3);
                yield return new polar(16, -78.5, 222.6);
                yield return new polar(17, -65.4, 247.7);
                yield return new polar(18, -49, 65.6);
                yield return new polar(19, -67, 282.6);
                yield return new polar(20, -56.7, 56.2);
                yield return new polar(21, -80.5, 108.4);
                yield return new polar(22, -77.7, 266);
                yield return new polar(23, -6.9, 19.1);
                yield return new polar(24, -59.4, 281.7);
                yield return new polar(25, -5.6, 107.4);
                yield return new polar(26, -62.6, 105.3);
                yield return new polar(27, -74.7, 120.2);
                yield return new polar(28, -65.3, 286.6);
                yield return new polar(29, -71.6, 106.4);
                yield return new polar(30, -23.3, 96.5);
                yield return new polar(31, -74.3, 90.2);
                yield return new polar(32, -81, 170.9);
                yield return new polar(33, -12.7, 199.4);
                yield return new polar(34, -75.4, 118.6);
                yield return new polar(35, -85.9, 63.7);
                yield return new polar(36, -84.8, 74.9);
                yield return new polar(37, -7.4, 93.8);
                yield return new polar(38, -29.8, 72.8);
                yield return new polar(39, -85.2, 113.2);
                yield return new polar(40, -53.1, 51.5);
                yield return new polar(41, -38.3, 146.8);
                yield return new polar(42, -72.7, 103.1);
                yield return new polar(43, -60.2, 33.2);
                yield return new polar(44, -63.4, 154.8);
                yield return new polar(45, -17.2, 89.9);
                yield return new polar(46, -81.6, 295.6);
                yield return new polar(47, -40.4, 41);
                yield return new polar(48, -53.6, 59.1);
                yield return new polar(49, -56.2, 35.6);
                yield return new polar(50, -75.1, 70.7);
            }
        }
    }
}
