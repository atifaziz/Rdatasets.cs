// ReSharper disable All

namespace Rdatasets.HistData
{
    using System.Collections.Generic;

    /// <summary>
    /// Playfair's Data on Wages and the Price of Wheat
    /// </summary>

    public class Wheat_monarchs
    {
        public readonly int κ;
        public readonly string name;
        public readonly int start;
        public readonly int end;
        public readonly int commonwealth;

        public Wheat_monarchs(int κ, string name, int start, int end, int commonwealth)
        {
            this.κ = κ;
            this.name = name;
            this.start = start;
            this.end = end;
            this.commonwealth = commonwealth;
        }

        public static IEnumerable<Wheat_monarchs> Data
        {
            get
            {
                yield return new Wheat_monarchs(1, "Elizabeth", 1565, 1603, 0);
                yield return new Wheat_monarchs(2, "James I", 1603, 1625, 0);
                yield return new Wheat_monarchs(3, "Charles I", 1625, 1649, 0);
                yield return new Wheat_monarchs(4, "Cromwell", 1649, 1660, 1);
                yield return new Wheat_monarchs(5, "Charles II", 1660, 1685, 0);
                yield return new Wheat_monarchs(6, "James II", 1685, 1689, 0);
                yield return new Wheat_monarchs(7, "W&M", 1689, 1702, 0);
                yield return new Wheat_monarchs(8, "Anne", 1702, 1714, 0);
                yield return new Wheat_monarchs(9, "George I", 1714, 1727, 0);
                yield return new Wheat_monarchs(10, "George II", 1727, 1760, 0);
                yield return new Wheat_monarchs(11, "George III", 1760, 1820, 0);
                yield return new Wheat_monarchs(12, "George IV", 1820, 1821, 0);
            }
        }
    }
}
