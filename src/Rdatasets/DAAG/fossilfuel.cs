// ReSharper disable All

namespace Rdatasets.DAAG
{
    using System.Collections.Generic;

    /// <summary>
    /// Fossil Fuel Data
    /// </summary>

    public class fossilfuel
    {
        public readonly int κ;
        public readonly int year;
        public readonly int carbon;

        public fossilfuel(int κ, int year, int carbon)
        {
            this.κ = κ;
            this.year = year;
            this.carbon = carbon;
        }

        public static IEnumerable<fossilfuel> Data
        {
            get
            {
                yield return new fossilfuel(1, 1800, 8);
                yield return new fossilfuel(2, 1850, 54);
                yield return new fossilfuel(3, 1900, 534);
                yield return new fossilfuel(4, 1950, 1630);
                yield return new fossilfuel(5, 2000, 6611);
            }
        }
    }
}
