// ReSharper disable All

namespace Rdatasets.DAAG
{
    using System.Collections.Generic;

    /// <summary>
    /// Barley Seeding Rate Data
    /// </summary>

    public class seedrates
    {
        public readonly int κ;
        public readonly int rate;
        public readonly double grain;

        public seedrates(int κ, int rate, double grain)
        {
            this.κ = κ;
            this.rate = rate;
            this.grain = grain;
        }

        public static IEnumerable<seedrates> Data
        {
            get
            {
                yield return new seedrates(1, 50, 21.2);
                yield return new seedrates(2, 75, 19.9);
                yield return new seedrates(3, 100, 19.2);
                yield return new seedrates(4, 125, 18.4);
                yield return new seedrates(5, 150, 17.9);
            }
        }
    }
}
