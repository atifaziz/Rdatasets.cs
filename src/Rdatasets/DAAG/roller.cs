// ReSharper disable All

namespace Rdatasets.DAAG
{
    using System.Collections.Generic;

    /// <summary>
    /// Lawn Roller Data
    /// </summary>

    public class roller
    {
        public readonly double weight;
        public readonly int depression;

        public roller(double weight, int depression)
        {
            this.weight = weight;
            this.depression = depression;
        }

        public static IEnumerable<roller> Data
        {
            get
            {
                yield return new roller(1.9, 2);
                yield return new roller(3.1, 1);
                yield return new roller(3.3, 5);
                yield return new roller(4.8, 5);
                yield return new roller(5.3, 20);
                yield return new roller(6.1, 20);
                yield return new roller(6.4, 23);
                yield return new roller(7.6, 10);
                yield return new roller(9.8, 30);
                yield return new roller(12.4, 25);
            }
        }
    }
}
