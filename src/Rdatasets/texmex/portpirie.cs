// ReSharper disable All

namespace Rdatasets.texmex
{
    using System.Collections.Generic;

    /// <summary>
    /// Rain, wavesurge, portpirie and nidd datasets.
    /// </summary>

    public class portpirie
    {
        public readonly int κ;
        public readonly int Year;
        public readonly double SeaLevel;

        public portpirie(int κ, int Year, double SeaLevel)
        {
            this.κ = κ;
            this.Year = Year;
            this.SeaLevel = SeaLevel;
        }

        public static IEnumerable<portpirie> Data
        {
            get
            {
                yield return new portpirie(1, 1923, 4.03);
                yield return new portpirie(2, 1924, 3.83);
                yield return new portpirie(3, 1925, 3.65);
                yield return new portpirie(4, 1926, 3.88);
                yield return new portpirie(5, 1927, 4.01);
                yield return new portpirie(6, 1928, 4.08);
                yield return new portpirie(7, 1929, 4.18);
                yield return new portpirie(8, 1930, 3.8);
                yield return new portpirie(9, 1931, 4.36);
                yield return new portpirie(10, 1932, 3.96);
                yield return new portpirie(11, 1933, 3.98);
                yield return new portpirie(12, 1934, 4.69);
                yield return new portpirie(13, 1935, 3.85);
                yield return new portpirie(14, 1936, 3.96);
                yield return new portpirie(15, 1937, 3.85);
                yield return new portpirie(16, 1938, 3.93);
                yield return new portpirie(17, 1939, 3.75);
                yield return new portpirie(18, 1940, 3.63);
                yield return new portpirie(19, 1941, 3.57);
                yield return new portpirie(20, 1942, 4.25);
                yield return new portpirie(21, 1943, 3.97);
                yield return new portpirie(22, 1944, 4.05);
                yield return new portpirie(23, 1945, 4.24);
                yield return new portpirie(24, 1946, 4.22);
                yield return new portpirie(25, 1947, 3.73);
                yield return new portpirie(26, 1948, 4.37);
                yield return new portpirie(27, 1949, 4.06);
                yield return new portpirie(28, 1950, 3.71);
                yield return new portpirie(29, 1951, 3.96);
                yield return new portpirie(30, 1952, 4.06);
                yield return new portpirie(31, 1953, 4.55);
                yield return new portpirie(32, 1954, 3.79);
                yield return new portpirie(33, 1955, 3.89);
                yield return new portpirie(34, 1956, 4.11);
                yield return new portpirie(35, 1957, 3.85);
                yield return new portpirie(36, 1958, 3.86);
                yield return new portpirie(37, 1959, 3.86);
                yield return new portpirie(38, 1960, 4.21);
                yield return new portpirie(39, 1961, 4.01);
                yield return new portpirie(40, 1962, 4.11);
                yield return new portpirie(41, 1963, 4.24);
                yield return new portpirie(42, 1964, 3.96);
                yield return new portpirie(43, 1965, 4.21);
                yield return new portpirie(44, 1966, 3.74);
                yield return new portpirie(45, 1967, 3.85);
                yield return new portpirie(46, 1968, 3.88);
                yield return new portpirie(47, 1969, 3.66);
                yield return new portpirie(48, 1970, 4.11);
                yield return new portpirie(49, 1971, 3.71);
                yield return new portpirie(50, 1972, 4.18);
                yield return new portpirie(51, 1973, 3.9);
                yield return new portpirie(52, 1974, 3.78);
                yield return new portpirie(53, 1975, 3.91);
                yield return new portpirie(54, 1976, 3.72);
                yield return new portpirie(55, 1977, 4);
                yield return new portpirie(56, 1978, 3.66);
                yield return new portpirie(57, 1979, 3.62);
                yield return new portpirie(58, 1980, 4.33);
                yield return new portpirie(59, 1981, 4.55);
                yield return new portpirie(60, 1982, 3.75);
                yield return new portpirie(61, 1983, 4.08);
                yield return new portpirie(62, 1984, 3.9);
                yield return new portpirie(63, 1985, 3.88);
                yield return new portpirie(64, 1986, 3.94);
                yield return new portpirie(65, 1987, 4.33);
            }
        }
    }
}
