// ReSharper disable All

namespace Rdatasets.HistData
{
    using System.Collections.Generic;

    /// <summary>
    /// John F. W. Herschel's Data on the Orbit of the Twin Stars gamma _Virginis_
    /// </summary>

    public class Virginis_interp
    {
        public readonly int year;
        public readonly double posangle;
        public readonly double distance;
        public readonly double velocity;

        public Virginis_interp(int year, double posangle, double distance, double velocity)
        {
            this.year = year;
            this.posangle = posangle;
            this.distance = distance;
            this.velocity = velocity;
        }

        public static IEnumerable<Virginis_interp> Data
        {
            get
            {
                yield return new Virginis_interp(1720, 160, 17.2, -0.32);
                yield return new Virginis_interp(1730, 156.6666667, 16.81, -0.354);
                yield return new Virginis_interp(1740, 153, 16.31, -0.376);
                yield return new Virginis_interp(1750, 148.9166667, 15.5, -0.416);
                yield return new Virginis_interp(1760, 144.4166667, 14.46, -0.478);
                yield return new Virginis_interp(1770, 139.75, 13.7, -0.533);
                yield return new Virginis_interp(1780, 134.5, 13.52, -0.547);
                yield return new Virginis_interp(1790, 128.5833333, 12.94, -0.597);
                yield return new Virginis_interp(1800, 122.4166667, 12.58, -0.632);
                yield return new Virginis_interp(1810, 115.5, 11.18, -0.8);
                yield return new Virginis_interp(1815, 111.3333333, 10.37, -0.929);
                yield return new Virginis_interp(1820, 106.25, 9.57, -1.092);
                yield return new Virginis_interp(1825, 98.33333333, 7.09, -1.987);
                yield return new Virginis_interp(1830, 84.33333333, 4.9, -4.165);
            }
        }
    }
}
