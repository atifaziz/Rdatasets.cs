// ReSharper disable All

namespace Rdatasets.DAAG
{
    using System.Collections.Generic;

    /// <summary>
    /// Record times for Northern Ireland mountain running events
    /// </summary>

    public class nihills
    {
        public readonly string κ;
        public readonly double dist;
        public readonly int climb;
        public readonly double time;
        public readonly double timef;

        public nihills(string κ, double dist, int climb, double time, double timef)
        {
            this.κ = κ;
            this.dist = dist;
            this.climb = climb;
            this.time = time;
            this.timef = timef;
        }

        public static IEnumerable<nihills> Data
        {
            get
            {
                yield return new nihills("Binevenagh", 7.5, 1740, 0.858333333333333, 1.06444444444444);
                yield return new nihills("Slieve Gullion", 4.2, 1110, 0.466666666666667, 0.623055555555556);
                yield return new nihills("Glenariff Mountain", 5.9, 1210, 0.703055555555556, 0.886944444444444);
                yield return new nihills("Donard & Commedagh", 6.8, 3300, 1.03861111111111, 1.21416666666667);
                yield return new nihills("McVeigh Classic", 5, 1200, 0.541111111111111, 0.6375);
                yield return new nihills("Tollymore Mountain", 4.8, 950, 0.483333333333333, 0.588611111111111);
                yield return new nihills("Slieve Martin", 4.3, 1600, 0.550555555555556, 0.701666666666667);
                yield return new nihills("Moughanmore", 3, 1500, 0.463611111111111, 0.6475);
                yield return new nihills("Hen & Cock", 2.5, 1500, 0.449722222222222, 0.6075);
                yield return new nihills("Annalong Horseshoe", 12, 5080, 1.94916666666667, 2.48055555555556);
                yield return new nihills("Monument Race", 4, 1000, 0.471666666666667, 0.594722222222222);
                yield return new nihills("Loughshannagh Horseshoe", 4.3, 1700, 0.646944444444444, 0.882222222222222);
                yield return new nihills("Rocky", 4, 1300, 0.523055555555556, 0.665277777777778);
                yield return new nihills("Meelbeg Meelmore", 3.5, 1800, 0.454444444444444, 0.608611111111111);
                yield return new nihills("Donard Forest", 4.5, 1400, 0.518611111111111, 0.643333333333333);
                yield return new nihills("Slieve Donard", 5.5, 2790, 0.948333333333333, 1.20861111111111);
                yield return new nihills("Flagstaff to Carling", 11, 3000, 1.45694444444444, 2.03444444444444);
                yield return new nihills("Slieve Bearnagh", 4, 2690, 0.687777777777778, 0.799166666666667);
                yield return new nihills("Seven Sevens", 18.9, 8775, 3.90277777777778, 5.98555555555556);
                yield return new nihills("Lurig Challenge", 4, 1000, 0.434722222222222, 0.575555555555556);
                yield return new nihills("Scrabo Hill Race", 2.9, 750, 0.324722222222222, 0.409166666666667);
                yield return new nihills("Slieve Gallion", 4.6, 1440, 0.636111111111111, 0.749444444444444);
                yield return new nihills("BARF Turkey Trot", 5.7, 1430, 0.713055555555556, 0.938333333333333);
            }
        }
    }
}
