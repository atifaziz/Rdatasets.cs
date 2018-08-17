// ReSharper disable All

namespace Rdatasets.DAAG
{
    using System.Collections.Generic;

    /// <summary>
    /// Barley Seeding Rate Data
    /// </summary>

    public class seedrates
    {
        public readonly int rate;
        public readonly double grain;

        public seedrates(int rate, double grain)
        {
            this.rate = rate;
            this.grain = grain;
        }

        public static IEnumerable<seedrates> Data
        {
            get
            {
                yield return new seedrates(50, 21.2);
                yield return new seedrates(75, 19.9);
                yield return new seedrates(100, 19.2);
                yield return new seedrates(125, 18.4);
                yield return new seedrates(150, 17.9);
            }
        }
    }
}
