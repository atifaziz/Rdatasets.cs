// ReSharper disable All

namespace Rdatasets.DAAG
{
    using System.Collections.Generic;

    /// <summary>
    /// Latitudes and longitudes for ten Australian cities
    /// </summary>

    public class aulatlong
    {
        public readonly double latitude;
        public readonly double longitude;

        public aulatlong(double latitude, double longitude)
        {
            this.latitude = latitude;
            this.longitude = longitude;
        }

        public static IEnumerable<aulatlong> Data
        {
            get
            {
                yield return new aulatlong(138.6, -34.93);
                yield return new aulatlong(133.87, -23.7);
                yield return new aulatlong(153.02, -27.46);
                yield return new aulatlong(122.25, -18);
                yield return new aulatlong(145.75, -16.92);
                yield return new aulatlong(149.13, -35.31);
                yield return new aulatlong(130.85, -12.43);
                yield return new aulatlong(144.96, -37.81);
                yield return new aulatlong(115.84, -31.96);
                yield return new aulatlong(151.21, -33.87);
            }
        }
    }
}
