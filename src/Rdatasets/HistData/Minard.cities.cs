// ReSharper disable All

namespace Rdatasets.HistData
{
    using System.Collections.Generic;

    /// <summary>
    /// Data from Minard's famous graphic map of Napoleon's march on Moscow
    /// </summary>

    public class Minard_cities
    {
        public readonly double @long;
        public readonly double lat;
        public readonly string city;

        public Minard_cities(double @long, double lat, string city)
        {
            this.@long = @long;
            this.lat = lat;
            this.city = city;
        }

        public static IEnumerable<Minard_cities> Data
        {
            get
            {
                yield return new Minard_cities(24, 55, "Kowno");
                yield return new Minard_cities(25.3, 54.7, "Wilna");
                yield return new Minard_cities(26.4, 54.4, "Smorgoni");
                yield return new Minard_cities(26.8, 54.3, "Moiodexno");
                yield return new Minard_cities(27.7, 55.2, "Gloubokoe");
                yield return new Minard_cities(27.6, 53.9, "Minsk");
                yield return new Minard_cities(28.5, 54.3, "Studienska");
                yield return new Minard_cities(28.7, 55.5, "Polotzk");
                yield return new Minard_cities(29.2, 54.4, "Bobr");
                yield return new Minard_cities(30.2, 55.3, "Witebsk");
                yield return new Minard_cities(30.4, 54.5, "Orscha");
                yield return new Minard_cities(30.4, 53.9, "Mohilow");
                yield return new Minard_cities(32, 54.8, "Smolensk");
                yield return new Minard_cities(33.2, 54.9, "Dorogobouge");
                yield return new Minard_cities(34.3, 55.2, "Wixma");
                yield return new Minard_cities(34.4, 55.5, "Chjat");
                yield return new Minard_cities(36, 55.5, "Mojaisk");
                yield return new Minard_cities(37.6, 55.8, "Moscou");
                yield return new Minard_cities(36.6, 55.3, "Tarantino");
                yield return new Minard_cities(36.5, 55, "Malo-Jarosewii");
            }
        }
    }
}
