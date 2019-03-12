// ReSharper disable All

namespace Rdatasets.fpp2
{
    using System.Collections.Generic;

    /// <summary>
    /// Boston marathon winning times since 1897
    /// </summary>

    public class marathon
    {
        public readonly int κ;
        public readonly int time;
        public readonly double value;

        public marathon(int κ, int time, double value)
        {
            this.κ = κ;
            this.time = time;
            this.value = value;
        }

        public static IEnumerable<marathon> Data
        {
            get
            {
                yield return new marathon(1, 1897, 175.1666667);
                yield return new marathon(2, 1898, 162);
                yield return new marathon(3, 1899, 174.6333333);
                yield return new marathon(4, 1900, 159.7333333);
                yield return new marathon(5, 1901, 149.3833333);
                yield return new marathon(6, 1902, 163.2);
                yield return new marathon(7, 1903, 161.4833333);
                yield return new marathon(8, 1904, 158.0666667);
                yield return new marathon(9, 1905, 158.4166667);
                yield return new marathon(10, 1906, 165.75);
                yield return new marathon(11, 1907, 144.4);
                yield return new marathon(12, 1908, 145.7166667);
                yield return new marathon(13, 1909, 173.6);
                yield return new marathon(14, 1910, 148.8666667);
                yield return new marathon(15, 1911, 141.65);
                yield return new marathon(16, 1912, 141.3);
                yield return new marathon(17, 1913, 145.2333333);
                yield return new marathon(18, 1914, 145.2333333);
                yield return new marathon(19, 1915, 151.6833333);
                yield return new marathon(20, 1916, 147.2666667);
                yield return new marathon(21, 1917, 148.6166667);
                yield return new marathon(22, 1918, 149.8833333);
                yield return new marathon(23, 1919, 149.2166667);
                yield return new marathon(24, 1920, 149.5166667);
                yield return new marathon(25, 1921, 138.95);
                yield return new marathon(26, 1922, 138.1666667);
                yield return new marathon(27, 1923, 143.7833333);
                yield return new marathon(28, 1924, 149.6666667);
                yield return new marathon(29, 1925, 153);
                yield return new marathon(30, 1926, 145.6666667);
                yield return new marathon(31, 1927, 160.3666667);
                yield return new marathon(32, 1928, 157.1166667);
                yield return new marathon(33, 1929, 153.1333333);
                yield return new marathon(34, 1930, 154.8);
                yield return new marathon(35, 1931, 166.75);
                yield return new marathon(36, 1932, 153.6);
                yield return new marathon(37, 1933, 151.0166667);
                yield return new marathon(38, 1934, 152.8833333);
                yield return new marathon(39, 1935, 152.1166667);
                yield return new marathon(40, 1936, 153.6666667);
                yield return new marathon(41, 1937, 153.3333333);
                yield return new marathon(42, 1938, 155.5666667);
                yield return new marathon(43, 1939, 148.85);
                yield return new marathon(44, 1940, 148.4666667);
                yield return new marathon(45, 1941, 150.6333333);
                yield return new marathon(46, 1942, 146.85);
                yield return new marathon(47, 1943, 148.4166667);
                yield return new marathon(48, 1944, 151.8333333);
                yield return new marathon(49, 1945, 150.6666667);
                yield return new marathon(50, 1946, 149.45);
                yield return new marathon(51, 1947, 145.65);
                yield return new marathon(52, 1948, 151.0333333);
                yield return new marathon(53, 1949, 151.8333333);
                yield return new marathon(54, 1950, 152.65);
                yield return new marathon(55, 1951, 147.75);
                yield return new marathon(56, 1952, 151.8833333);
                yield return new marathon(57, 1953, 138.85);
                yield return new marathon(58, 1954, 140.65);
                yield return new marathon(59, 1955, 138.3666667);
                yield return new marathon(60, 1956, 134.2333333);
                yield return new marathon(61, 1957, 140.0833333);
                yield return new marathon(62, 1958, 145.9);
                yield return new marathon(63, 1959, 142.7);
                yield return new marathon(64, 1960, 140.9);
                yield return new marathon(65, 1961, 143.65);
                yield return new marathon(66, 1962, 143.8);
                yield return new marathon(67, 1963, 138.9666667);
                yield return new marathon(68, 1964, 139.9833333);
                yield return new marathon(69, 1965, 136.55);
                yield return new marathon(70, 1966, 137.1833333);
                yield return new marathon(71, 1967, 135.75);
                yield return new marathon(72, 1968, 142.2833333);
                yield return new marathon(73, 1969, 133.8166667);
                yield return new marathon(74, 1970, 130.5);
                yield return new marathon(75, 1971, 138.75);
                yield return new marathon(76, 1972, 135.65);
                yield return new marathon(77, 1973, 136.05);
                yield return new marathon(78, 1974, 133.65);
                yield return new marathon(79, 1975, 129.9166667);
                yield return new marathon(80, 1976, 140.3166667);
                yield return new marathon(81, 1977, 134.7666667);
                yield return new marathon(82, 1978, 130.2166667);
                yield return new marathon(83, 1979, 129.45);
                yield return new marathon(84, 1980, 132.1833333);
                yield return new marathon(85, 1981, 129.4333333);
                yield return new marathon(86, 1982, 128.8666667);
                yield return new marathon(87, 1983, 129);
                yield return new marathon(88, 1984, 130.5666667);
                yield return new marathon(89, 1985, 134.0833333);
                yield return new marathon(90, 1986, 127.85);
                yield return new marathon(91, 1987, 131.8333333);
                yield return new marathon(92, 1988, 128.7166667);
                yield return new marathon(93, 1989, 129.1);
                yield return new marathon(94, 1990, 128.3166667);
                yield return new marathon(95, 1991, 131.1);
                yield return new marathon(96, 1992, 128.2333333);
                yield return new marathon(97, 1993, 129.55);
                yield return new marathon(98, 1994, 127.25);
                yield return new marathon(99, 1995, 129.3666667);
                yield return new marathon(100, 1996, 129.25);
                yield return new marathon(101, 1997, 130.5666667);
                yield return new marathon(102, 1998, 127.5666667);
                yield return new marathon(103, 1999, 129.8666667);
                yield return new marathon(104, 2000, 129.7833333);
                yield return new marathon(105, 2001, 129.7166667);
                yield return new marathon(106, 2002, 129.0333333);
                yield return new marathon(107, 2003, 130.1833333);
                yield return new marathon(108, 2004, 130.6166667);
                yield return new marathon(109, 2005, 131.7333333);
                yield return new marathon(110, 2006, 127.2333333);
                yield return new marathon(111, 2007, 134.2166667);
                yield return new marathon(112, 2008, 127.75);
                yield return new marathon(113, 2009, 128.7);
                yield return new marathon(114, 2010, 125.8666667);
                yield return new marathon(115, 2011, 123.0333333);
                yield return new marathon(116, 2012, 132.6666667);
                yield return new marathon(117, 2013, 130.3666667);
                yield return new marathon(118, 2014, 128.6166667);
                yield return new marathon(119, 2015, 129.2833333);
                yield return new marathon(120, 2016, 132.7333333);
            }
        }
    }
}
