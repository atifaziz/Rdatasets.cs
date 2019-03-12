// ReSharper disable All

namespace Rdatasets.HistData
{
    using System.Collections.Generic;

    /// <summary>
    /// Data from Minard's famous graphic map of Napoleon's march on Moscow
    /// </summary>

    public class Minard_cities
    {
        public readonly int κ;
        public readonly double @long;
        public readonly double lat;
        public readonly string city;

        public Minard_cities(int κ, double @long, double lat, string city)
        {
            this.κ = κ;
            this.@long = @long;
            this.lat = lat;
            this.city = city;
        }

        public static IEnumerable<Minard_cities> Data
        {
            get
            {
                yield return new Minard_cities(1, 24, 55, "Kowno");
                yield return new Minard_cities(2, 25.3, 54.7, "Wilna");
                yield return new Minard_cities(3, 26.4, 54.4, "Smorgoni");
                yield return new Minard_cities(4, 26.8, 54.3, "Moiodexno");
                yield return new Minard_cities(5, 27.7, 55.2, "Gloubokoe");
                yield return new Minard_cities(6, 27.6, 53.9, "Minsk");
                yield return new Minard_cities(7, 28.5, 54.3, "Studienska");
                yield return new Minard_cities(8, 28.7, 55.5, "Polotzk");
                yield return new Minard_cities(9, 29.2, 54.4, "Bobr");
                yield return new Minard_cities(10, 30.2, 55.3, "Witebsk");
                yield return new Minard_cities(11, 30.4, 54.5, "Orscha");
                yield return new Minard_cities(12, 30.4, 53.9, "Mohilow");
                yield return new Minard_cities(13, 32, 54.8, "Smolensk");
                yield return new Minard_cities(14, 33.2, 54.9, "Dorogobouge");
                yield return new Minard_cities(15, 34.3, 55.2, "Wixma");
                yield return new Minard_cities(16, 34.4, 55.5, "Chjat");
                yield return new Minard_cities(17, 36, 55.5, "Mojaisk");
                yield return new Minard_cities(18, 37.6, 55.8, "Moscou");
                yield return new Minard_cities(19, 36.6, 55.3, "Tarantino");
                yield return new Minard_cities(20, 36.5, 55, "Malo-Jarosewii");
            }
        }
    }
}
