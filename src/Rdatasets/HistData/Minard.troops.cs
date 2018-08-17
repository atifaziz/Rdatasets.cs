// ReSharper disable All

namespace Rdatasets.HistData
{
    using System.Collections.Generic;

    /// <summary>
    /// Data from Minard's famous graphic map of Napoleon's march on Moscow
    /// </summary>

    public class Minard_troops
    {
        public readonly double @long;
        public readonly double lat;
        public readonly int survivors;
        public readonly string direction;
        public readonly int group;

        public Minard_troops(double @long, double lat, int survivors, string direction, int group)
        {
            this.@long = @long;
            this.lat = lat;
            this.survivors = survivors;
            this.direction = direction;
            this.group = group;
        }

        public static IEnumerable<Minard_troops> Data
        {
            get
            {
                yield return new Minard_troops(24, 54.9, 340000, "A", 1);
                yield return new Minard_troops(24.5, 55, 340000, "A", 1);
                yield return new Minard_troops(25.5, 54.5, 340000, "A", 1);
                yield return new Minard_troops(26, 54.7, 320000, "A", 1);
                yield return new Minard_troops(27, 54.8, 300000, "A", 1);
                yield return new Minard_troops(28, 54.9, 280000, "A", 1);
                yield return new Minard_troops(28.5, 55, 240000, "A", 1);
                yield return new Minard_troops(29, 55.1, 210000, "A", 1);
                yield return new Minard_troops(30, 55.2, 180000, "A", 1);
                yield return new Minard_troops(30.3, 55.3, 175000, "A", 1);
                yield return new Minard_troops(32, 54.8, 145000, "A", 1);
                yield return new Minard_troops(33.2, 54.9, 140000, "A", 1);
                yield return new Minard_troops(34.4, 55.5, 127100, "A", 1);
                yield return new Minard_troops(35.5, 55.4, 100000, "A", 1);
                yield return new Minard_troops(36, 55.5, 100000, "A", 1);
                yield return new Minard_troops(37.6, 55.8, 100000, "A", 1);
                yield return new Minard_troops(37.7, 55.7, 100000, "R", 1);
                yield return new Minard_troops(37.5, 55.7, 98000, "R", 1);
                yield return new Minard_troops(37, 55, 97000, "R", 1);
                yield return new Minard_troops(36.8, 55, 96000, "R", 1);
                yield return new Minard_troops(35.4, 55.3, 87000, "R", 1);
                yield return new Minard_troops(34.3, 55.2, 55000, "R", 1);
                yield return new Minard_troops(33.3, 54.8, 37000, "R", 1);
                yield return new Minard_troops(32, 54.6, 24000, "R", 1);
                yield return new Minard_troops(30.4, 54.4, 20000, "R", 1);
                yield return new Minard_troops(29.2, 54.3, 20000, "R", 1);
                yield return new Minard_troops(28.5, 54.2, 20000, "R", 1);
                yield return new Minard_troops(28.3, 54.3, 20000, "R", 1);
                yield return new Minard_troops(27.5, 54.5, 20000, "R", 1);
                yield return new Minard_troops(26.8, 54.3, 12000, "R", 1);
                yield return new Minard_troops(26.4, 54.4, 14000, "R", 1);
                yield return new Minard_troops(25, 54.4, 8000, "R", 1);
                yield return new Minard_troops(24.4, 54.4, 4000, "R", 1);
                yield return new Minard_troops(24.2, 54.4, 4000, "R", 1);
                yield return new Minard_troops(24.1, 54.4, 4000, "R", 1);
                yield return new Minard_troops(24, 55.1, 60000, "A", 2);
                yield return new Minard_troops(24.5, 55.2, 60000, "A", 2);
                yield return new Minard_troops(25.5, 54.7, 60000, "A", 2);
                yield return new Minard_troops(26.6, 55.7, 40000, "A", 2);
                yield return new Minard_troops(27.4, 55.6, 33000, "A", 2);
                yield return new Minard_troops(28.7, 55.5, 33000, "A", 2);
                yield return new Minard_troops(28.7, 55.5, 33000, "R", 2);
                yield return new Minard_troops(29.2, 54.2, 30000, "R", 2);
                yield return new Minard_troops(28.5, 54.1, 30000, "R", 2);
                yield return new Minard_troops(28.3, 54.2, 28000, "R", 2);
                yield return new Minard_troops(24, 55.2, 22000, "A", 3);
                yield return new Minard_troops(24.5, 55.3, 22000, "A", 3);
                yield return new Minard_troops(24.6, 55.8, 6000, "A", 3);
                yield return new Minard_troops(24.6, 55.8, 6000, "R", 3);
                yield return new Minard_troops(24.2, 54.4, 6000, "R", 3);
                yield return new Minard_troops(24.1, 54.4, 6000, "R", 3);
            }
        }
    }
}
