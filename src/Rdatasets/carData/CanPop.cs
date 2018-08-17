// ReSharper disable All

namespace Rdatasets.carData
{
    using System.Collections.Generic;

    /// <summary>
    /// Canadian Population Data
    /// </summary>

    public class CanPop
    {
        public readonly int year;
        public readonly double population;

        public CanPop(int year, double population)
        {
            this.year = year;
            this.population = population;
        }

        public static IEnumerable<CanPop> Data
        {
            get
            {
                yield return new CanPop(1851, 2.436);
                yield return new CanPop(1861, 3.23);
                yield return new CanPop(1871, 3.689);
                yield return new CanPop(1881, 4.325);
                yield return new CanPop(1891, 4.833);
                yield return new CanPop(1901, 5.371);
                yield return new CanPop(1911, 7.207);
                yield return new CanPop(1921, 8.788);
                yield return new CanPop(1931, 10.377);
                yield return new CanPop(1941, 11.507);
                yield return new CanPop(1951, 13.648);
                yield return new CanPop(1961, 17.78);
                yield return new CanPop(1971, 21.046);
                yield return new CanPop(1981, 23.774);
                yield return new CanPop(1991, 26.429);
                yield return new CanPop(2001, 30.007);
            }
        }
    }
}
