// ReSharper disable All

namespace Rdatasets.carData
{
    using System.Collections.Generic;

    /// <summary>
    /// Canadian Population Data
    /// </summary>

    public class CanPop
    {
        public readonly int κ;
        public readonly int year;
        public readonly double population;

        public CanPop(int κ, int year, double population)
        {
            this.κ = κ;
            this.year = year;
            this.population = population;
        }

        public static IEnumerable<CanPop> Data
        {
            get
            {
                yield return new CanPop(1, 1851, 2.436);
                yield return new CanPop(2, 1861, 3.23);
                yield return new CanPop(3, 1871, 3.689);
                yield return new CanPop(4, 1881, 4.325);
                yield return new CanPop(5, 1891, 4.833);
                yield return new CanPop(6, 1901, 5.371);
                yield return new CanPop(7, 1911, 7.207);
                yield return new CanPop(8, 1921, 8.788);
                yield return new CanPop(9, 1931, 10.377);
                yield return new CanPop(10, 1941, 11.507);
                yield return new CanPop(11, 1951, 13.648);
                yield return new CanPop(12, 1961, 17.78);
                yield return new CanPop(13, 1971, 21.046);
                yield return new CanPop(14, 1981, 23.774);
                yield return new CanPop(15, 1991, 26.429);
                yield return new CanPop(16, 2001, 30.007);
            }
        }
    }
}
