// ReSharper disable All

namespace Rdatasets.Stat2Data
{
    using System.Collections.Generic;

    /// <summary>
    /// Alfalfa
    /// </summary>

    public class Alfalfa
    {
        public readonly int κ;
        public readonly double Ht4;
        public readonly string Acid;
        public readonly string Row;

        public Alfalfa(int κ, double Ht4, string Acid, string Row)
        {
            this.κ = κ;
            this.Ht4 = Ht4;
            this.Acid = Acid;
            this.Row = Row;
        }

        public static IEnumerable<Alfalfa> Data
        {
            get
            {
                yield return new Alfalfa(1, 1.45, "water", "a");
                yield return new Alfalfa(2, 2.79, "water", "b");
                yield return new Alfalfa(3, 1.93, "water", "c");
                yield return new Alfalfa(4, 2.33, "water", "d");
                yield return new Alfalfa(5, 4.85, "water", "e");
                yield return new Alfalfa(6, 1, "1.5HCl", "a");
                yield return new Alfalfa(7, 0.7, "1.5HCl", "b");
                yield return new Alfalfa(8, 1.37, "1.5HCl", "c");
                yield return new Alfalfa(9, 2.8, "1.5HCl", "d");
                yield return new Alfalfa(10, 1.46, "1.5HCl", "e");
                yield return new Alfalfa(11, 1.03, "3.0HCl", "a");
                yield return new Alfalfa(12, 1.22, "3.0HCl", "b");
                yield return new Alfalfa(13, 0.45, "3.0HCl", "c");
                yield return new Alfalfa(14, 1.65, "3.0HCl", "d");
                yield return new Alfalfa(15, 1.07, "3.0HCl", "e");
            }
        }
    }
}
