// ReSharper disable All

namespace Rdatasets.DAAG
{
    using System.Collections.Generic;

    /// <summary>
    /// Scottish Hill Races Data
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
                yield return new hills("Greenmantle", 2.4, 650, 0.268055555555556);
                yield return new hills("Carnethy", 6, 2500, 0.805833333333333);
                yield return new hills("Craig Dunain", 6, 900, 0.560833333333333);
                yield return new hills("Ben Rha", 7.5, 800, 0.76);
                yield return new hills("Ben Lomond", 8, 3070, 1.03777777777778);
                yield return new hills("Goatfell", 8, 2866, 1.22027777777778);
                yield return new hills("Bens of Jura", 16, 7500, 3.41027777777778);
                yield return new hills("Cairnpapple", 6, 800, 0.606111111111111);
                yield return new hills("Scolty", 5, 800, 0.495833333333333);
                yield return new hills("Traprain", 6, 650, 0.6625);
                yield return new hills("Lairig Ghru", 28, 2100, 3.21111111111111);
                yield return new hills("Dollar", 5, 2000, 0.7175);
                yield return new hills("Lomonds", 9.5, 2200, 1.08333333333333);
                yield return new hills("Cairn Table", 6, 500, 0.735555555555556);
                yield return new hills("Eildon Two", 4.5, 1500, 0.448888888888889);
                yield return new hills("Cairngorm", 10, 3000, 1.20416666666667);
                yield return new hills("Seven Hills", 14, 2200, 1.64027777777778);
                yield return new hills("Knock Hill", 3, 350, 1.31083333333333);
                yield return new hills("Black Hill", 4.5, 1000, 0.290277777777778);
                yield return new hills("Creag Beag", 5.5, 600, 0.542777777777778);
                yield return new hills("Kildcon Hill", 3, 300, 0.265833333333333);
                yield return new hills("Meall Ant-Suidhe", 3.5, 1500, 0.465);
                yield return new hills("Half Ben Nevis", 6, 2200, 0.794166666666667);
                yield return new hills("Cow Hill", 2, 900, 0.298888888888889);
                yield return new hills("N Berwick Law", 3, 600, 0.311388888888889);
                yield return new hills("Creag Dubh", 4, 2000, 0.436944444444444);
                yield return new hills("Burnswark", 6, 800, 0.573888888888889);
                yield return new hills("Largo Law", 5, 950, 0.476111111111111);
                yield return new hills("Criffel", 6.5, 1750, 0.841666666666667);
                yield return new hills("Acmony", 5, 500, 0.349166666666667);
                yield return new hills("Ben Nevis", 10, 4400, 1.42638888888889);
                yield return new hills("Knockfarrel", 6, 600, 0.539722222222222);
                yield return new hills("Two Breweries", 18, 5200, 2.8375);
                yield return new hills("Cockleroi", 4.5, 850, 0.468333333333333);
                yield return new hills("Moffat Chase", 20, 5000, 2.66388888888889);
            }
        }
    }
}
