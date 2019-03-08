// ReSharper disable All

namespace Rdatasets.fpp2
{
    using System.Collections.Generic;

    /// <summary>
    /// Annual average sunspot area (1875-2015)
    /// </summary>

    public class sunspotarea
    {
        public readonly int time;
        public readonly double value;

        public sunspotarea(int time, double value)
        {
            this.time = time;
            this.value = value;
        }

        public static IEnumerable<sunspotarea> Data
        {
            get
            {
                yield return new sunspotarea(1875, 213.133333333333);
                yield return new sunspotarea(1876, 109.283333333333);
                yield return new sunspotarea(1877, 92.8583333333333);
                yield return new sunspotarea(1878, 22.2166666666667);
                yield return new sunspotarea(1879, 36.3333333333333);
                yield return new sunspotarea(1880, 446.75);
                yield return new sunspotarea(1881, 679.491666666667);
                yield return new sunspotarea(1882, 968.025);
                yield return new sunspotarea(1883, 1148.90833333333);
                yield return new sunspotarea(1884, 1034.125);
                yield return new sunspotarea(1885, 810.208333333333);
                yield return new sunspotarea(1886, 379.408333333333);
                yield return new sunspotarea(1887, 177.258333333333);
                yield return new sunspotarea(1888, 87.925);
                yield return new sunspotarea(1889, 76.6916666666667);
                yield return new sunspotarea(1890, 98.7666666666667);
                yield return new sunspotarea(1891, 566.441666666667);
                yield return new sunspotarea(1892, 1211.275);
                yield return new sunspotarea(1893, 1460.625);
                yield return new sunspotarea(1894, 1281.54166666667);
                yield return new sunspotarea(1895, 973.433333333333);
                yield return new sunspotarea(1896, 547.391666666667);
                yield return new sunspotarea(1897, 511.65);
                yield return new sunspotarea(1898, 374.658333333333);
                yield return new sunspotarea(1899, 109.983333333333);
                yield return new sunspotarea(1900, 74.3083333333333);
                yield return new sunspotarea(1901, 27.8583333333333);
                yield return new sunspotarea(1902, 59.475);
                yield return new sunspotarea(1903, 338.6);
                yield return new sunspotarea(1904, 488.175);
                yield return new sunspotarea(1905, 1195.88333333333);
                yield return new sunspotarea(1906, 774.983333333333);
                yield return new sunspotarea(1907, 1092.10833333333);
                yield return new sunspotarea(1908, 697.483333333333);
                yield return new sunspotarea(1909, 691.525);
                yield return new sunspotarea(1910, 266.008333333333);
                yield return new sunspotarea(1911, 64.4083333333333);
                yield return new sunspotarea(1912, 37.3333333333333);
                yield return new sunspotarea(1913, 7.525);
                yield return new sunspotarea(1914, 152.383333333333);
                yield return new sunspotarea(1915, 697.766666666667);
                yield return new sunspotarea(1916, 725.458333333333);
                yield return new sunspotarea(1917, 1533.925);
                yield return new sunspotarea(1918, 1112.56666666667);
                yield return new sunspotarea(1919, 1054.68333333333);
                yield return new sunspotarea(1920, 617.258333333333);
                yield return new sunspotarea(1921, 419.616666666667);
                yield return new sunspotarea(1922, 251.958333333333);
                yield return new sunspotarea(1923, 54.6583333333333);
                yield return new sunspotarea(1924, 278.008333333333);
                yield return new sunspotarea(1925, 825.075);
                yield return new sunspotarea(1926, 1263.15);
                yield return new sunspotarea(1927, 1060.8);
                yield return new sunspotarea(1928, 1388.91666666667);
                yield return new sunspotarea(1929, 1238.91666666667);
                yield return new sunspotarea(1930, 516.608333333333);
                yield return new sunspotarea(1931, 279.066666666667);
                yield return new sunspotarea(1932, 163.15);
                yield return new sunspotarea(1933, 91.25);
                yield return new sunspotarea(1934, 118.225);
                yield return new sunspotarea(1935, 622.075);
                yield return new sunspotarea(1936, 1140.84166666667);
                yield return new sunspotarea(1937, 2072.775);
                yield return new sunspotarea(1938, 2015.23333333333);
                yield return new sunspotarea(1939, 1576.83333333333);
                yield return new sunspotarea(1940, 1037.16666666667);
                yield return new sunspotarea(1941, 658.125);
                yield return new sunspotarea(1942, 427.333333333333);
                yield return new sunspotarea(1943, 296.766666666667);
                yield return new sunspotarea(1944, 124.65);
                yield return new sunspotarea(1945, 426.5);
                yield return new sunspotarea(1946, 1823.9);
                yield return new sunspotarea(1947, 2634.05);
                yield return new sunspotarea(1948, 1974.6);
                yield return new sunspotarea(1949, 2139.99166666667);
                yield return new sunspotarea(1950, 1227.34166666667);
                yield return new sunspotarea(1951, 1135.25833333333);
                yield return new sunspotarea(1952, 402.85);
                yield return new sunspotarea(1953, 145.1);
                yield return new sunspotarea(1954, 34.6416666666667);
                yield return new sunspotarea(1955, 552.35);
                yield return new sunspotarea(1956, 2394.69166666667);
                yield return new sunspotarea(1957, 3048.475);
                yield return new sunspotarea(1958, 3011.26666666667);
                yield return new sunspotarea(1959, 2872.94166666667);
                yield return new sunspotarea(1960, 1641.21666666667);
                yield return new sunspotarea(1961, 613.5);
                yield return new sunspotarea(1962, 463.516666666667);
                yield return new sunspotarea(1963, 287.833333333333);
                yield return new sunspotarea(1964, 53.9083333333333);
                yield return new sunspotarea(1965, 113.308333333333);
                yield return new sunspotarea(1966, 592.558333333333);
                yield return new sunspotarea(1967, 1519.14166666667);
                yield return new sunspotarea(1968, 1569.75833333333);
                yield return new sunspotarea(1969, 1450.13333333333);
                yield return new sunspotarea(1970, 1601.25833333333);
                yield return new sunspotarea(1971, 990.2);
                yield return new sunspotarea(1972, 916.7);
                yield return new sunspotarea(1973, 457.55);
                yield return new sunspotarea(1974, 398.858333333333);
                yield return new sunspotarea(1975, 166.408333333333);
                yield return new sunspotarea(1976, 169.775);
                yield return new sunspotarea(1977, 347.041666666667);
                yield return new sunspotarea(1978, 1368.51666666667);
                yield return new sunspotarea(1979, 2194.525);
                yield return new sunspotarea(1980, 2160.71666666667);
                yield return new sunspotarea(1981, 2270.24166666667);
                yield return new sunspotarea(1982, 2283.3);
                yield return new sunspotarea(1983, 944);
                yield return new sunspotarea(1984, 811.316666666667);
                yield return new sunspotarea(1985, 180.15);
                yield return new sunspotarea(1986, 124.7);
                yield return new sunspotarea(1987, 296.816666666667);
                yield return new sunspotarea(1988, 1345.26666666667);
                yield return new sunspotarea(1989, 2579.225);
                yield return new sunspotarea(1990, 2048.68333333333);
                yield return new sunspotarea(1991, 2470.18333333333);
                yield return new sunspotarea(1992, 1349.20833333333);
                yield return new sunspotarea(1993, 696.2);
                yield return new sunspotarea(1994, 340.391666666667);
                yield return new sunspotarea(1995, 159.633333333333);
                yield return new sunspotarea(1996, 81.9);
                yield return new sunspotarea(1997, 210.241666666667);
                yield return new sunspotarea(1998, 763.075);
                yield return new sunspotarea(1999, 1162.00833333333);
                yield return new sunspotarea(2000, 1614.21666666667);
                yield return new sunspotarea(2001, 1704.09166666667);
                yield return new sunspotarea(2002, 1828.73333333333);
                yield return new sunspotarea(2003, 1099.24166666667);
                yield return new sunspotarea(2004, 683.775);
                yield return new sunspotarea(2005, 542.575);
                yield return new sunspotarea(2006, 245.108333333333);
                yield return new sunspotarea(2007, 133.341666666667);
                yield return new sunspotarea(2008, 22.8083333333333);
                yield return new sunspotarea(2009, 26.5583333333333);
                yield return new sunspotarea(2010, 214.291666666667);
                yield return new sunspotarea(2011, 749.566666666667);
                yield return new sunspotarea(2012, 796.883333333333);
                yield return new sunspotarea(2013, 860.775);
                yield return new sunspotarea(2014, 1252.15);
                yield return new sunspotarea(2015, 618.808333333333);
            }
        }
    }
}
