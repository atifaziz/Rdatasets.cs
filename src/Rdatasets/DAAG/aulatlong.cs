// ReSharper disable All

namespace Rdatasets.DAAG
{
    using System.Collections.Generic;

    /// <summary>
    /// Latitudes and longitudes for ten Australian cities
    /// </summary>

    public class aulatlong
    {
        public readonly string κ;
        public readonly double latitude;
        public readonly double longitude;

        public aulatlong(string κ, double latitude, double longitude)
        {
            this.κ = κ;
            this.latitude = latitude;
            this.longitude = longitude;
        }

        public static IEnumerable<aulatlong> Data
        {
            get
            {
                yield return new aulatlong("Adelaide", 138.6, -34.93);
                yield return new aulatlong("Alice", 133.87, -23.7);
                yield return new aulatlong("Brisbane", 153.02, -27.46);
                yield return new aulatlong("Broome", 122.25, -18);
                yield return new aulatlong("Cairns", 145.75, -16.92);
                yield return new aulatlong("Canberra", 149.13, -35.31);
                yield return new aulatlong("Darwin", 130.85, -12.43);
                yield return new aulatlong("Melbourne", 144.96, -37.81);
                yield return new aulatlong("Perth", 115.84, -31.96);
                yield return new aulatlong("Sydney", 151.21, -33.87);
            }
        }
    }
}
