// ReSharper disable All

namespace Rdatasets.fpp2
{
    using System.Collections.Generic;

    /// <summary>
    /// Winning times in Olympic men's 400m track final. 1896-2016.
    /// </summary>

    public class mens400
    {
        public readonly int κ;
        public readonly int time;
        public readonly double? value;

        public mens400(int κ, int time, double? value)
        {
            this.κ = κ;
            this.time = time;
            this.value = value;
        }

        public static IEnumerable<mens400> Data
        {
            get
            {
                yield return new mens400(1, 1896, 54.2);
                yield return new mens400(2, 1900, 49.4);
                yield return new mens400(3, 1904, 49.2);
                yield return new mens400(4, 1908, 50);
                yield return new mens400(5, 1912, 48.2);
                yield return new mens400(6, 1916, null);
                yield return new mens400(7, 1920, 49.6);
                yield return new mens400(8, 1924, 47.6);
                yield return new mens400(9, 1928, 47.8);
                yield return new mens400(10, 1932, 46.2);
                yield return new mens400(11, 1936, 46.5);
                yield return new mens400(12, 1940, null);
                yield return new mens400(13, 1944, null);
                yield return new mens400(14, 1948, 46.2);
                yield return new mens400(15, 1952, 45.9);
                yield return new mens400(16, 1956, 46.7);
                yield return new mens400(17, 1960, 44.9);
                yield return new mens400(18, 1964, 45.1);
                yield return new mens400(19, 1968, 43.8);
                yield return new mens400(20, 1972, 44.66);
                yield return new mens400(21, 1976, 44.26);
                yield return new mens400(22, 1980, 44.6);
                yield return new mens400(23, 1984, 44.27);
                yield return new mens400(24, 1988, 43.87);
                yield return new mens400(25, 1992, 43.5);
                yield return new mens400(26, 1996, 43.49);
                yield return new mens400(27, 2000, 43.84);
                yield return new mens400(28, 2004, 44);
                yield return new mens400(29, 2008, 43.75);
                yield return new mens400(30, 2012, 43.94);
                yield return new mens400(31, 2016, 43.03);
            }
        }
    }
}
