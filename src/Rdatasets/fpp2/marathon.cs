// ReSharper disable All

namespace Rdatasets.fpp2
{
    using System.Collections.Generic;

    /// <summary>
    /// Boston marathon winning times since 1897
    /// </summary>

    public class marathon
    {
        public readonly int time;
        public readonly double value;

        public marathon(int time, double value)
        {
            this.time = time;
            this.value = value;
        }

        public static IEnumerable<marathon> Data
        {
            get
            {
                yield return new marathon(1897, 175.1666667);
                yield return new marathon(1898, 162);
                yield return new marathon(1899, 174.6333333);
                yield return new marathon(1900, 159.7333333);
                yield return new marathon(1901, 149.3833333);
                yield return new marathon(1902, 163.2);
                yield return new marathon(1903, 161.4833333);
                yield return new marathon(1904, 158.0666667);
                yield return new marathon(1905, 158.4166667);
                yield return new marathon(1906, 165.75);
                yield return new marathon(1907, 144.4);
                yield return new marathon(1908, 145.7166667);
                yield return new marathon(1909, 173.6);
                yield return new marathon(1910, 148.8666667);
                yield return new marathon(1911, 141.65);
                yield return new marathon(1912, 141.3);
                yield return new marathon(1913, 145.2333333);
                yield return new marathon(1914, 145.2333333);
                yield return new marathon(1915, 151.6833333);
                yield return new marathon(1916, 147.2666667);
                yield return new marathon(1917, 148.6166667);
                yield return new marathon(1918, 149.8833333);
                yield return new marathon(1919, 149.2166667);
                yield return new marathon(1920, 149.5166667);
                yield return new marathon(1921, 138.95);
                yield return new marathon(1922, 138.1666667);
                yield return new marathon(1923, 143.7833333);
                yield return new marathon(1924, 149.6666667);
                yield return new marathon(1925, 153);
                yield return new marathon(1926, 145.6666667);
                yield return new marathon(1927, 160.3666667);
                yield return new marathon(1928, 157.1166667);
                yield return new marathon(1929, 153.1333333);
                yield return new marathon(1930, 154.8);
                yield return new marathon(1931, 166.75);
                yield return new marathon(1932, 153.6);
                yield return new marathon(1933, 151.0166667);
                yield return new marathon(1934, 152.8833333);
                yield return new marathon(1935, 152.1166667);
                yield return new marathon(1936, 153.6666667);
                yield return new marathon(1937, 153.3333333);
                yield return new marathon(1938, 155.5666667);
                yield return new marathon(1939, 148.85);
                yield return new marathon(1940, 148.4666667);
                yield return new marathon(1941, 150.6333333);
                yield return new marathon(1942, 146.85);
                yield return new marathon(1943, 148.4166667);
                yield return new marathon(1944, 151.8333333);
                yield return new marathon(1945, 150.6666667);
                yield return new marathon(1946, 149.45);
                yield return new marathon(1947, 145.65);
                yield return new marathon(1948, 151.0333333);
                yield return new marathon(1949, 151.8333333);
                yield return new marathon(1950, 152.65);
                yield return new marathon(1951, 147.75);
                yield return new marathon(1952, 151.8833333);
                yield return new marathon(1953, 138.85);
                yield return new marathon(1954, 140.65);
                yield return new marathon(1955, 138.3666667);
                yield return new marathon(1956, 134.2333333);
                yield return new marathon(1957, 140.0833333);
                yield return new marathon(1958, 145.9);
                yield return new marathon(1959, 142.7);
                yield return new marathon(1960, 140.9);
                yield return new marathon(1961, 143.65);
                yield return new marathon(1962, 143.8);
                yield return new marathon(1963, 138.9666667);
                yield return new marathon(1964, 139.9833333);
                yield return new marathon(1965, 136.55);
                yield return new marathon(1966, 137.1833333);
                yield return new marathon(1967, 135.75);
                yield return new marathon(1968, 142.2833333);
                yield return new marathon(1969, 133.8166667);
                yield return new marathon(1970, 130.5);
                yield return new marathon(1971, 138.75);
                yield return new marathon(1972, 135.65);
                yield return new marathon(1973, 136.05);
                yield return new marathon(1974, 133.65);
                yield return new marathon(1975, 129.9166667);
                yield return new marathon(1976, 140.3166667);
                yield return new marathon(1977, 134.7666667);
                yield return new marathon(1978, 130.2166667);
                yield return new marathon(1979, 129.45);
                yield return new marathon(1980, 132.1833333);
                yield return new marathon(1981, 129.4333333);
                yield return new marathon(1982, 128.8666667);
                yield return new marathon(1983, 129);
                yield return new marathon(1984, 130.5666667);
                yield return new marathon(1985, 134.0833333);
                yield return new marathon(1986, 127.85);
                yield return new marathon(1987, 131.8333333);
                yield return new marathon(1988, 128.7166667);
                yield return new marathon(1989, 129.1);
                yield return new marathon(1990, 128.3166667);
                yield return new marathon(1991, 131.1);
                yield return new marathon(1992, 128.2333333);
                yield return new marathon(1993, 129.55);
                yield return new marathon(1994, 127.25);
                yield return new marathon(1995, 129.3666667);
                yield return new marathon(1996, 129.25);
                yield return new marathon(1997, 130.5666667);
                yield return new marathon(1998, 127.5666667);
                yield return new marathon(1999, 129.8666667);
                yield return new marathon(2000, 129.7833333);
                yield return new marathon(2001, 129.7166667);
                yield return new marathon(2002, 129.0333333);
                yield return new marathon(2003, 130.1833333);
                yield return new marathon(2004, 130.6166667);
                yield return new marathon(2005, 131.7333333);
                yield return new marathon(2006, 127.2333333);
                yield return new marathon(2007, 134.2166667);
                yield return new marathon(2008, 127.75);
                yield return new marathon(2009, 128.7);
                yield return new marathon(2010, 125.8666667);
                yield return new marathon(2011, 123.0333333);
                yield return new marathon(2012, 132.6666667);
                yield return new marathon(2013, 130.3666667);
                yield return new marathon(2014, 128.6166667);
                yield return new marathon(2015, 129.2833333);
                yield return new marathon(2016, 132.7333333);
            }
        }
    }
}
