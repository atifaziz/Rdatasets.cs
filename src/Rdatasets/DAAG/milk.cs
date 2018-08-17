// ReSharper disable All

namespace Rdatasets.DAAG
{
    using System.Collections.Generic;

    /// <summary>
    /// Milk Sweetness Study
    /// </summary>

    public class milk
    {
        public readonly double four;
        public readonly double one;

        public milk(double four, double one)
        {
            this.four = four;
            this.one = one;
        }

        public static IEnumerable<milk> Data
        {
            get
            {
                yield return new milk(7.2, 5.8);
                yield return new milk(7.4, 6.9);
                yield return new milk(7, 6);
                yield return new milk(7.2, 6);
                yield return new milk(4.6, 5.4);
                yield return new milk(6, 5.7);
                yield return new milk(5, 6.1);
                yield return new milk(4.2, 3.7);
                yield return new milk(3.8, 3.8);
                yield return new milk(6.1, 4.3);
                yield return new milk(3.7, 3.4);
                yield return new milk(3.9, 1.4);
                yield return new milk(2.5, 1.7);
                yield return new milk(4.4, 5.4);
                yield return new milk(4.2, 3.2);
                yield return new milk(4.6, 2.2);
                yield return new milk(5.6, 3.6);
            }
        }
    }
}
