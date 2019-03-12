// ReSharper disable All

namespace Rdatasets.robustbase
{
    using System.Collections.Generic;

    /// <summary>
    /// Salinity Data
    /// </summary>

    public class salinity
    {
        public readonly int κ;
        public readonly double X1;
        public readonly int X2;
        public readonly double X3;
        public readonly double Y;

        public salinity(int κ, double X1, int X2, double X3, double Y)
        {
            this.κ = κ;
            this.X1 = X1;
            this.X2 = X2;
            this.X3 = X3;
            this.Y = Y;
        }

        public static IEnumerable<salinity> Data
        {
            get
            {
                yield return new salinity(1, 8.2, 4, 23.005, 7.6);
                yield return new salinity(2, 7.6, 5, 23.873, 7.7);
                yield return new salinity(3, 4.6, 0, 26.417, 4.3);
                yield return new salinity(4, 4.3, 1, 24.868, 5.9);
                yield return new salinity(5, 5.9, 2, 29.895, 5);
                yield return new salinity(6, 5, 3, 24.2, 6.5);
                yield return new salinity(7, 6.5, 4, 23.215, 8.3);
                yield return new salinity(8, 8.3, 5, 21.862, 8.2);
                yield return new salinity(9, 10.1, 0, 22.274, 13.2);
                yield return new salinity(10, 13.2, 1, 23.83, 12.6);
                yield return new salinity(11, 12.6, 2, 25.144, 10.4);
                yield return new salinity(12, 10.4, 3, 22.43, 10.8);
                yield return new salinity(13, 10.8, 4, 21.785, 13.1);
                yield return new salinity(14, 13.1, 5, 22.38, 12.3);
                yield return new salinity(15, 13.3, 0, 23.927, 10.4);
                yield return new salinity(16, 10.4, 1, 33.443, 10.5);
                yield return new salinity(17, 10.5, 2, 24.859, 7.7);
                yield return new salinity(18, 7.7, 3, 22.686, 9.5);
                yield return new salinity(19, 10, 0, 21.789, 12);
                yield return new salinity(20, 12, 1, 22.041, 12.6);
                yield return new salinity(21, 12.1, 4, 21.033, 13.6);
                yield return new salinity(22, 13.6, 5, 21.005, 14.1);
                yield return new salinity(23, 15, 0, 25.865, 13.5);
                yield return new salinity(24, 13.5, 1, 26.29, 11.5);
                yield return new salinity(25, 11.5, 2, 22.932, 12);
                yield return new salinity(26, 12, 3, 21.313, 13);
                yield return new salinity(27, 13, 4, 20.769, 14.1);
                yield return new salinity(28, 14.1, 5, 21.393, 15.1);
            }
        }
    }
}
