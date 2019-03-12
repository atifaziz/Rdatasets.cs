// ReSharper disable All

namespace Rdatasets.DAAG
{
    using System.Collections.Generic;

    /// <summary>
    /// Lawn Roller Data
    /// </summary>

    public class roller
    {
        public readonly int κ;
        public readonly double weight;
        public readonly int depression;

        public roller(int κ, double weight, int depression)
        {
            this.κ = κ;
            this.weight = weight;
            this.depression = depression;
        }

        public static IEnumerable<roller> Data
        {
            get
            {
                yield return new roller(1, 1.9, 2);
                yield return new roller(2, 3.1, 1);
                yield return new roller(3, 3.3, 5);
                yield return new roller(4, 4.8, 5);
                yield return new roller(5, 5.3, 20);
                yield return new roller(6, 6.1, 20);
                yield return new roller(7, 6.4, 23);
                yield return new roller(8, 7.6, 10);
                yield return new roller(9, 9.8, 30);
                yield return new roller(10, 12.4, 25);
            }
        }
    }
}
