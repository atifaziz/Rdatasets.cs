// ReSharper disable All

namespace Rdatasets.MASS
{
    using System.Collections.Generic;

    /// <summary>
    /// Snail Mortality Data
    /// </summary>

    public class snails
    {
        public readonly string Species;
        public readonly int Exposure;
        public readonly double Rel_Hum;
        public readonly int Temp;
        public readonly int Deaths;
        public readonly int N;

        public snails(string Species, int Exposure, double Rel_Hum, int Temp, int Deaths, int N)
        {
            this.Species = Species;
            this.Exposure = Exposure;
            this.Rel_Hum = Rel_Hum;
            this.Temp = Temp;
            this.Deaths = Deaths;
            this.N = N;
        }

        public static IEnumerable<snails> Data
        {
            get
            {
                yield return new snails("A", 1, 60, 10, 0, 20);
                yield return new snails("A", 1, 60, 15, 0, 20);
                yield return new snails("A", 1, 60, 20, 0, 20);
                yield return new snails("A", 1, 65.8, 10, 0, 20);
                yield return new snails("A", 1, 65.8, 15, 0, 20);
                yield return new snails("A", 1, 65.8, 20, 0, 20);
                yield return new snails("A", 1, 70.5, 10, 0, 20);
                yield return new snails("A", 1, 70.5, 15, 0, 20);
                yield return new snails("A", 1, 70.5, 20, 0, 20);
                yield return new snails("A", 1, 75.8, 10, 0, 20);
                yield return new snails("A", 1, 75.8, 15, 0, 20);
                yield return new snails("A", 1, 75.8, 20, 0, 20);
                yield return new snails("A", 2, 60, 10, 0, 20);
                yield return new snails("A", 2, 60, 15, 1, 20);
                yield return new snails("A", 2, 60, 20, 1, 20);
                yield return new snails("A", 2, 65.8, 10, 0, 20);
                yield return new snails("A", 2, 65.8, 15, 1, 20);
                yield return new snails("A", 2, 65.8, 20, 0, 20);
                yield return new snails("A", 2, 70.5, 10, 0, 20);
                yield return new snails("A", 2, 70.5, 15, 0, 20);
                yield return new snails("A", 2, 70.5, 20, 0, 20);
                yield return new snails("A", 2, 75.8, 10, 0, 20);
                yield return new snails("A", 2, 75.8, 15, 0, 20);
                yield return new snails("A", 2, 75.8, 20, 0, 20);
                yield return new snails("A", 3, 60, 10, 1, 20);
                yield return new snails("A", 3, 60, 15, 4, 20);
                yield return new snails("A", 3, 60, 20, 5, 20);
                yield return new snails("A", 3, 65.8, 10, 0, 20);
                yield return new snails("A", 3, 65.8, 15, 2, 20);
                yield return new snails("A", 3, 65.8, 20, 4, 20);
                yield return new snails("A", 3, 70.5, 10, 0, 20);
                yield return new snails("A", 3, 70.5, 15, 2, 20);
                yield return new snails("A", 3, 70.5, 20, 3, 20);
                yield return new snails("A", 3, 75.8, 10, 0, 20);
                yield return new snails("A", 3, 75.8, 15, 1, 20);
                yield return new snails("A", 3, 75.8, 20, 2, 20);
                yield return new snails("A", 4, 60, 10, 7, 20);
                yield return new snails("A", 4, 60, 15, 7, 20);
                yield return new snails("A", 4, 60, 20, 7, 20);
                yield return new snails("A", 4, 65.8, 10, 4, 20);
                yield return new snails("A", 4, 65.8, 15, 4, 20);
                yield return new snails("A", 4, 65.8, 20, 7, 20);
                yield return new snails("A", 4, 70.5, 10, 3, 20);
                yield return new snails("A", 4, 70.5, 15, 3, 20);
                yield return new snails("A", 4, 70.5, 20, 5, 20);
                yield return new snails("A", 4, 75.8, 10, 2, 20);
                yield return new snails("A", 4, 75.8, 15, 3, 20);
                yield return new snails("A", 4, 75.8, 20, 3, 20);
                yield return new snails("B", 1, 60, 10, 0, 20);
                yield return new snails("B", 1, 60, 15, 0, 20);
                yield return new snails("B", 1, 60, 20, 0, 20);
                yield return new snails("B", 1, 65.8, 10, 0, 20);
                yield return new snails("B", 1, 65.8, 15, 0, 20);
                yield return new snails("B", 1, 65.8, 20, 0, 20);
                yield return new snails("B", 1, 70.5, 10, 0, 20);
                yield return new snails("B", 1, 70.5, 15, 0, 20);
                yield return new snails("B", 1, 70.5, 20, 0, 20);
                yield return new snails("B", 1, 75.8, 10, 0, 20);
                yield return new snails("B", 1, 75.8, 15, 0, 20);
                yield return new snails("B", 1, 75.8, 20, 0, 20);
                yield return new snails("B", 2, 60, 10, 0, 20);
                yield return new snails("B", 2, 60, 15, 3, 20);
                yield return new snails("B", 2, 60, 20, 2, 20);
                yield return new snails("B", 2, 65.8, 10, 0, 20);
                yield return new snails("B", 2, 65.8, 15, 2, 20);
                yield return new snails("B", 2, 65.8, 20, 1, 20);
                yield return new snails("B", 2, 70.5, 10, 0, 20);
                yield return new snails("B", 2, 70.5, 15, 0, 20);
                yield return new snails("B", 2, 70.5, 20, 1, 20);
                yield return new snails("B", 2, 75.8, 10, 1, 20);
                yield return new snails("B", 2, 75.8, 15, 0, 20);
                yield return new snails("B", 2, 75.8, 20, 1, 20);
                yield return new snails("B", 3, 60, 10, 7, 20);
                yield return new snails("B", 3, 60, 15, 11, 20);
                yield return new snails("B", 3, 60, 20, 11, 20);
                yield return new snails("B", 3, 65.8, 10, 4, 20);
                yield return new snails("B", 3, 65.8, 15, 5, 20);
                yield return new snails("B", 3, 65.8, 20, 9, 20);
                yield return new snails("B", 3, 70.5, 10, 2, 20);
                yield return new snails("B", 3, 70.5, 15, 4, 20);
                yield return new snails("B", 3, 70.5, 20, 6, 20);
                yield return new snails("B", 3, 75.8, 10, 2, 20);
                yield return new snails("B", 3, 75.8, 15, 3, 20);
                yield return new snails("B", 3, 75.8, 20, 5, 20);
                yield return new snails("B", 4, 60, 10, 12, 20);
                yield return new snails("B", 4, 60, 15, 14, 20);
                yield return new snails("B", 4, 60, 20, 16, 20);
                yield return new snails("B", 4, 65.8, 10, 10, 20);
                yield return new snails("B", 4, 65.8, 15, 12, 20);
                yield return new snails("B", 4, 65.8, 20, 12, 20);
                yield return new snails("B", 4, 70.5, 10, 5, 20);
                yield return new snails("B", 4, 70.5, 15, 7, 20);
                yield return new snails("B", 4, 70.5, 20, 9, 20);
                yield return new snails("B", 4, 75.8, 10, 4, 20);
                yield return new snails("B", 4, 75.8, 15, 5, 20);
                yield return new snails("B", 4, 75.8, 20, 7, 20);
            }
        }
    }
}
