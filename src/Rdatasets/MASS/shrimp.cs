// ReSharper disable All

namespace Rdatasets.MASS
{
    using System.Collections.Generic;

    /// <summary>
    /// Percentage of Shrimp in Shrimp Cocktail
    /// </summary>

    public class shrimp
    {
        public readonly double dat;

        public shrimp(double dat)
        {
            this.dat = dat;
        }

        public static IEnumerable<shrimp> Data
        {
            get
            {
                yield return new shrimp(32.2);
                yield return new shrimp(33);
                yield return new shrimp(30.8);
                yield return new shrimp(33.8);
                yield return new shrimp(32.2);
                yield return new shrimp(33.3);
                yield return new shrimp(31.7);
                yield return new shrimp(35.7);
                yield return new shrimp(32.4);
                yield return new shrimp(31.2);
                yield return new shrimp(26.6);
                yield return new shrimp(30.7);
                yield return new shrimp(32.5);
                yield return new shrimp(30.7);
                yield return new shrimp(31.2);
                yield return new shrimp(30.3);
                yield return new shrimp(32.3);
                yield return new shrimp(31.7);
            }
        }
    }
}
