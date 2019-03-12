// ReSharper disable All

namespace Rdatasets.quantreg
{
    using System.Collections.Generic;

    /// <summary>
    /// Boscovich Data
    /// </summary>

    public class Bosco
    {
        public readonly string κ;
        public readonly double x;
        public readonly int y;

        public Bosco(string κ, double x, int y)
        {
            this.κ = κ;
            this.x = x;
            this.y = y;
        }

        public static IEnumerable<Bosco> Data
        {
            get
            {
                yield return new Bosco("Quito", 0, 51);
                yield return new Bosco("Capehope", 0.2987, 337);
                yield return new Bosco("Rome", 0.4648, 279);
                yield return new Bosco("Paris", 0.5762, 374);
                yield return new Bosco("Lapland", 0.8386, 722);
            }
        }
    }
}
