// ReSharper disable All

namespace Rdatasets.texmex
{
    using System.Collections.Generic;

    /// <summary>
    /// Rain, wavesurge, portpirie and nidd datasets.
    /// </summary>

    public class portpirie
    {
        public readonly int Year;
        public readonly double SeaLevel;

        public portpirie(int Year, double SeaLevel)
        {
            this.Year = Year;
            this.SeaLevel = SeaLevel;
        }

        public static IEnumerable<portpirie> Data
        {
            get
            {
                yield return new portpirie(1923, 4.03);
                yield return new portpirie(1924, 3.83);
                yield return new portpirie(1925, 3.65);
                yield return new portpirie(1926, 3.88);
                yield return new portpirie(1927, 4.01);
                yield return new portpirie(1928, 4.08);
                yield return new portpirie(1929, 4.18);
                yield return new portpirie(1930, 3.8);
                yield return new portpirie(1931, 4.36);
                yield return new portpirie(1932, 3.96);
                yield return new portpirie(1933, 3.98);
                yield return new portpirie(1934, 4.69);
                yield return new portpirie(1935, 3.85);
                yield return new portpirie(1936, 3.96);
                yield return new portpirie(1937, 3.85);
                yield return new portpirie(1938, 3.93);
                yield return new portpirie(1939, 3.75);
                yield return new portpirie(1940, 3.63);
                yield return new portpirie(1941, 3.57);
                yield return new portpirie(1942, 4.25);
                yield return new portpirie(1943, 3.97);
                yield return new portpirie(1944, 4.05);
                yield return new portpirie(1945, 4.24);
                yield return new portpirie(1946, 4.22);
                yield return new portpirie(1947, 3.73);
                yield return new portpirie(1948, 4.37);
                yield return new portpirie(1949, 4.06);
                yield return new portpirie(1950, 3.71);
                yield return new portpirie(1951, 3.96);
                yield return new portpirie(1952, 4.06);
                yield return new portpirie(1953, 4.55);
                yield return new portpirie(1954, 3.79);
                yield return new portpirie(1955, 3.89);
                yield return new portpirie(1956, 4.11);
                yield return new portpirie(1957, 3.85);
                yield return new portpirie(1958, 3.86);
                yield return new portpirie(1959, 3.86);
                yield return new portpirie(1960, 4.21);
                yield return new portpirie(1961, 4.01);
                yield return new portpirie(1962, 4.11);
                yield return new portpirie(1963, 4.24);
                yield return new portpirie(1964, 3.96);
                yield return new portpirie(1965, 4.21);
                yield return new portpirie(1966, 3.74);
                yield return new portpirie(1967, 3.85);
                yield return new portpirie(1968, 3.88);
                yield return new portpirie(1969, 3.66);
                yield return new portpirie(1970, 4.11);
                yield return new portpirie(1971, 3.71);
                yield return new portpirie(1972, 4.18);
                yield return new portpirie(1973, 3.9);
                yield return new portpirie(1974, 3.78);
                yield return new portpirie(1975, 3.91);
                yield return new portpirie(1976, 3.72);
                yield return new portpirie(1977, 4);
                yield return new portpirie(1978, 3.66);
                yield return new portpirie(1979, 3.62);
                yield return new portpirie(1980, 4.33);
                yield return new portpirie(1981, 4.55);
                yield return new portpirie(1982, 3.75);
                yield return new portpirie(1983, 4.08);
                yield return new portpirie(1984, 3.9);
                yield return new portpirie(1985, 3.88);
                yield return new portpirie(1986, 3.94);
                yield return new portpirie(1987, 4.33);
            }
        }
    }
}
