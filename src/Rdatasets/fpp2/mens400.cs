// ReSharper disable All

namespace Rdatasets.fpp2
{
    using System.Collections.Generic;

    /// <summary>
    /// Winning times in Olympic men's 400m track final. 1896-2016.
    /// </summary>

    public class mens400
    {
        public readonly int time;
        public readonly double? value;

        public mens400(int time, double? value)
        {
            this.time = time;
            this.value = value;
        }

        public static IEnumerable<mens400> Data
        {
            get
            {
                yield return new mens400(1896, 54.2);
                yield return new mens400(1900, 49.4);
                yield return new mens400(1904, 49.2);
                yield return new mens400(1908, 50);
                yield return new mens400(1912, 48.2);
                yield return new mens400(1916, null);
                yield return new mens400(1920, 49.6);
                yield return new mens400(1924, 47.6);
                yield return new mens400(1928, 47.8);
                yield return new mens400(1932, 46.2);
                yield return new mens400(1936, 46.5);
                yield return new mens400(1940, null);
                yield return new mens400(1944, null);
                yield return new mens400(1948, 46.2);
                yield return new mens400(1952, 45.9);
                yield return new mens400(1956, 46.7);
                yield return new mens400(1960, 44.9);
                yield return new mens400(1964, 45.1);
                yield return new mens400(1968, 43.8);
                yield return new mens400(1972, 44.66);
                yield return new mens400(1976, 44.26);
                yield return new mens400(1980, 44.6);
                yield return new mens400(1984, 44.27);
                yield return new mens400(1988, 43.87);
                yield return new mens400(1992, 43.5);
                yield return new mens400(1996, 43.49);
                yield return new mens400(2000, 43.84);
                yield return new mens400(2004, 44);
                yield return new mens400(2008, 43.75);
                yield return new mens400(2012, 43.94);
                yield return new mens400(2016, 43.03);
            }
        }
    }
}
