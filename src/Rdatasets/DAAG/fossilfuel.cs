// ReSharper disable All

namespace Rdatasets.DAAG
{
    using System.Collections.Generic;

    /// <summary>
    /// Fossil Fuel Data
    /// </summary>

    public class fossilfuel
    {
        public readonly int year;
        public readonly int carbon;

        public fossilfuel(int year, int carbon)
        {
            this.year = year;
            this.carbon = carbon;
        }

        public static IEnumerable<fossilfuel> Data
        {
            get
            {
                yield return new fossilfuel(1800, 8);
                yield return new fossilfuel(1850, 54);
                yield return new fossilfuel(1900, 534);
                yield return new fossilfuel(1950, 1630);
                yield return new fossilfuel(2000, 6611);
            }
        }
    }
}
