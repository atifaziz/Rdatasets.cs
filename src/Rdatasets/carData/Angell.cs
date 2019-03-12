// ReSharper disable All

namespace Rdatasets.carData
{
    using System.Collections.Generic;

    /// <summary>
    /// Moral Integration of American Cities
    /// </summary>

    public class Angell
    {
        public readonly string κ;
        public readonly double moral;
        public readonly double hetero;
        public readonly double mobility;
        public readonly string region;

        public Angell(string κ, double moral, double hetero, double mobility, string region)
        {
            this.κ = κ;
            this.moral = moral;
            this.hetero = hetero;
            this.mobility = mobility;
            this.region = region;
        }

        public static IEnumerable<Angell> Data
        {
            get
            {
                yield return new Angell("Rochester", 19, 20.6, 15, "E");
                yield return new Angell("Syracuse", 17, 15.6, 20.2, "E");
                yield return new Angell("Worcester", 16.4, 22.1, 13.6, "E");
                yield return new Angell("Erie", 16.2, 14, 14.8, "E");
                yield return new Angell("Milwaukee", 15.8, 17.4, 17.6, "MW");
                yield return new Angell("Bridgeport", 15.3, 27.9, 17.5, "E");
                yield return new Angell("Buffalo", 15.2, 22.3, 14.7, "E");
                yield return new Angell("Dayton", 14.3, 23.7, 23.8, "MW");
                yield return new Angell("Reading", 14.2, 10.6, 19.4, "E");
                yield return new Angell("Des_Moines", 14.1, 12.7, 31.9, "MW");
                yield return new Angell("Cleveland", 14, 39.7, 18.6, "MW");
                yield return new Angell("Denver", 13.9, 13, 34.5, "W");
                yield return new Angell("Peoria", 13.8, 10.7, 35.1, "MW");
                yield return new Angell("Wichita", 13.6, 11.9, 42.7, "MW");
                yield return new Angell("Trenton", 13, 32.5, 15.8, "E");
                yield return new Angell("Grand_Rapids", 12.8, 15.7, 24.2, "MW");
                yield return new Angell("Toledo", 12.7, 19.2, 21.6, "MW");
                yield return new Angell("San_Diego", 12.5, 15.9, 49.8, "W");
                yield return new Angell("Baltimore", 12, 45.8, 12.1, "E");
                yield return new Angell("South_Bend", 11.8, 17.9, 27.4, "MW");
                yield return new Angell("Akron", 11.3, 20.4, 22.1, "MW");
                yield return new Angell("Detroit", 11.1, 38.3, 19.5, "MW");
                yield return new Angell("Tacoma", 10.9, 17.8, 31.2, "W");
                yield return new Angell("Flint", 9.8, 19.3, 32.2, "MW");
                yield return new Angell("Spokane", 9.6, 12.3, 38.9, "W");
                yield return new Angell("Seattle", 9, 23.9, 34.2, "W");
                yield return new Angell("Indianapolis", 8.8, 29.2, 23.1, "MW");
                yield return new Angell("Columbus", 8, 27.4, 25, "MW");
                yield return new Angell("Portland_Oregon", 7.2, 16.4, 35.8, "W");
                yield return new Angell("Richmond", 10.4, 65.3, 24.9, "S");
                yield return new Angell("Houston", 10.2, 49, 36.1, "S");
                yield return new Angell("Fort_Worth", 10.2, 30.5, 36.8, "S");
                yield return new Angell("Oklahoma_City", 9.7, 20.7, 47.2, "S");
                yield return new Angell("Chattanooga", 9.3, 57.7, 27.2, "S");
                yield return new Angell("Nashville", 8.6, 57.4, 25.4, "S");
                yield return new Angell("Birmingham", 8.2, 83.1, 25.9, "S");
                yield return new Angell("Dallas", 8, 36.8, 37.8, "S");
                yield return new Angell("Louisville", 7.7, 31.5, 19.4, "S");
                yield return new Angell("Jacksonville", 6, 73.7, 27.7, "S");
                yield return new Angell("Memphis", 5.4, 84.5, 26.7, "S");
                yield return new Angell("Tulsa", 5.3, 23.8, 44.9, "S");
                yield return new Angell("Miami", 5.1, 50.2, 41.8, "S");
                yield return new Angell("Atlanta", 4.2, 70.6, 32.6, "S");
            }
        }
    }
}
