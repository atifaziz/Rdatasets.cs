// ReSharper disable All

namespace Rdatasets.Stat2Data
{
    using System.Collections.Generic;

    /// <summary>
    /// Popcorn
    /// </summary>

    public class Popcorn
    {
        public readonly int κ;
        public readonly int Unpopped;
        public readonly string Brand;
        public readonly int Trial;

        public Popcorn(int κ, int Unpopped, string Brand, int Trial)
        {
            this.κ = κ;
            this.Unpopped = Unpopped;
            this.Brand = Brand;
            this.Trial = Trial;
        }

        public static IEnumerable<Popcorn> Data
        {
            get
            {
                yield return new Popcorn(1, 26, "Orville", 1);
                yield return new Popcorn(2, 35, "Orville", 2);
                yield return new Popcorn(3, 18, "Orville", 3);
                yield return new Popcorn(4, 14, "Orville", 4);
                yield return new Popcorn(5, 8, "Orville", 5);
                yield return new Popcorn(6, 6, "Orville", 6);
                yield return new Popcorn(7, 47, "Seaway", 1);
                yield return new Popcorn(8, 47, "Seaway", 2);
                yield return new Popcorn(9, 14, "Seaway", 3);
                yield return new Popcorn(10, 34, "Seaway", 4);
                yield return new Popcorn(11, 21, "Seaway", 5);
                yield return new Popcorn(12, 37, "Seaway", 6);
            }
        }
    }
}
