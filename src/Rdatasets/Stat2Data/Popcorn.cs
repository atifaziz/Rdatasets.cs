// ReSharper disable All

namespace Rdatasets.Stat2Data
{
    using System.Collections.Generic;

    /// <summary>
    /// Popcorn
    /// </summary>

    public class Popcorn
    {
        public readonly int Unpopped;
        public readonly string Brand;
        public readonly int Trial;

        public Popcorn(int Unpopped, string Brand, int Trial)
        {
            this.Unpopped = Unpopped;
            this.Brand = Brand;
            this.Trial = Trial;
        }

        public static IEnumerable<Popcorn> Data
        {
            get
            {
                yield return new Popcorn(26, "Orville", 1);
                yield return new Popcorn(35, "Orville", 2);
                yield return new Popcorn(18, "Orville", 3);
                yield return new Popcorn(14, "Orville", 4);
                yield return new Popcorn(8, "Orville", 5);
                yield return new Popcorn(6, "Orville", 6);
                yield return new Popcorn(47, "Seaway", 1);
                yield return new Popcorn(47, "Seaway", 2);
                yield return new Popcorn(14, "Seaway", 3);
                yield return new Popcorn(34, "Seaway", 4);
                yield return new Popcorn(21, "Seaway", 5);
                yield return new Popcorn(37, "Seaway", 6);
            }
        }
    }
}
