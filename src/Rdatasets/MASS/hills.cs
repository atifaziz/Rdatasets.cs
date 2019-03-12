// ReSharper disable All

namespace Rdatasets.MASS
{
    using System.Collections.Generic;

    /// <summary>
    /// Record Times in Scottish Hill Races
    /// </summary>

    public class hills
    {
        public readonly string κ;
        public readonly double dist;
        public readonly int climb;
        public readonly double time;

        public hills(string κ, double dist, int climb, double time)
        {
            this.κ = κ;
            this.dist = dist;
            this.climb = climb;
            this.time = time;
        }

        public static IEnumerable<hills> Data
        {
            get
            {
                yield return new hills("Greenmantle", 2.5, 650, 16.083);
                yield return new hills("Carnethy", 6, 2500, 48.35);
                yield return new hills("Craig Dunain", 6, 900, 33.65);
                yield return new hills("Ben Rha", 7.5, 800, 45.6);
                yield return new hills("Ben Lomond", 8, 3070, 62.267);
                yield return new hills("Goatfell", 8, 2866, 73.217);
                yield return new hills("Bens of Jura", 16, 7500, 204.617);
                yield return new hills("Cairnpapple", 6, 800, 36.367);
                yield return new hills("Scolty", 5, 800, 29.75);
                yield return new hills("Traprain", 6, 650, 39.75);
                yield return new hills("Lairig Ghru", 28, 2100, 192.667);
                yield return new hills("Dollar", 5, 2000, 43.05);
                yield return new hills("Lomonds", 9.5, 2200, 65);
                yield return new hills("Cairn Table", 6, 500, 44.133);
                yield return new hills("Eildon Two", 4.5, 1500, 26.933);
                yield return new hills("Cairngorm", 10, 3000, 72.25);
                yield return new hills("Seven Hills", 14, 2200, 98.417);
                yield return new hills("Knock Hill", 3, 350, 78.65);
                yield return new hills("Black Hill", 4.5, 1000, 17.417);
                yield return new hills("Creag Beag", 5.5, 600, 32.567);
                yield return new hills("Kildcon Hill", 3, 300, 15.95);
                yield return new hills("Meall Ant-Suidhe", 3.5, 1500, 27.9);
                yield return new hills("Half Ben Nevis", 6, 2200, 47.633);
                yield return new hills("Cow Hill", 2, 900, 17.933);
                yield return new hills("N Berwick Law", 3, 600, 18.683);
                yield return new hills("Creag Dubh", 4, 2000, 26.217);
                yield return new hills("Burnswark", 6, 800, 34.433);
                yield return new hills("Largo Law", 5, 950, 28.567);
                yield return new hills("Criffel", 6.5, 1750, 50.5);
                yield return new hills("Acmony", 5, 500, 20.95);
                yield return new hills("Ben Nevis", 10, 4400, 85.583);
                yield return new hills("Knockfarrel", 6, 600, 32.383);
                yield return new hills("Two Breweries", 18, 5200, 170.25);
                yield return new hills("Cockleroi", 4.5, 850, 28.1);
                yield return new hills("Moffat Chase", 20, 5000, 159.833);
            }
        }
    }
}
