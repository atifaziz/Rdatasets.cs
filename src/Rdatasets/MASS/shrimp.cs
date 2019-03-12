// ReSharper disable All

namespace Rdatasets.MASS
{
    using System.Collections.Generic;

    /// <summary>
    /// Percentage of Shrimp in Shrimp Cocktail
    /// </summary>

    public class shrimp
    {
        public readonly int κ;
        public readonly double dat;

        public shrimp(int κ, double dat)
        {
            this.κ = κ;
            this.dat = dat;
        }

        public static IEnumerable<shrimp> Data
        {
            get
            {
                yield return new shrimp(1, 32.2);
                yield return new shrimp(2, 33);
                yield return new shrimp(3, 30.8);
                yield return new shrimp(4, 33.8);
                yield return new shrimp(5, 32.2);
                yield return new shrimp(6, 33.3);
                yield return new shrimp(7, 31.7);
                yield return new shrimp(8, 35.7);
                yield return new shrimp(9, 32.4);
                yield return new shrimp(10, 31.2);
                yield return new shrimp(11, 26.6);
                yield return new shrimp(12, 30.7);
                yield return new shrimp(13, 32.5);
                yield return new shrimp(14, 30.7);
                yield return new shrimp(15, 31.2);
                yield return new shrimp(16, 30.3);
                yield return new shrimp(17, 32.3);
                yield return new shrimp(18, 31.7);
            }
        }
    }
}
