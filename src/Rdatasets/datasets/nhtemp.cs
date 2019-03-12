// ReSharper disable All

namespace Rdatasets.datasets
{
    using System.Collections.Generic;

    /// <summary>
    /// Average Yearly Temperatures in New Haven
    /// </summary>

    public class nhtemp
    {
        public readonly int κ;
        public readonly int time;
        public readonly double value;

        public nhtemp(int κ, int time, double value)
        {
            this.κ = κ;
            this.time = time;
            this.value = value;
        }

        public static IEnumerable<nhtemp> Data
        {
            get
            {
                yield return new nhtemp(1, 1912, 49.9);
                yield return new nhtemp(2, 1913, 52.3);
                yield return new nhtemp(3, 1914, 49.4);
                yield return new nhtemp(4, 1915, 51.1);
                yield return new nhtemp(5, 1916, 49.4);
                yield return new nhtemp(6, 1917, 47.9);
                yield return new nhtemp(7, 1918, 49.8);
                yield return new nhtemp(8, 1919, 50.9);
                yield return new nhtemp(9, 1920, 49.3);
                yield return new nhtemp(10, 1921, 51.9);
                yield return new nhtemp(11, 1922, 50.8);
                yield return new nhtemp(12, 1923, 49.6);
                yield return new nhtemp(13, 1924, 49.3);
                yield return new nhtemp(14, 1925, 50.6);
                yield return new nhtemp(15, 1926, 48.4);
                yield return new nhtemp(16, 1927, 50.7);
                yield return new nhtemp(17, 1928, 50.9);
                yield return new nhtemp(18, 1929, 50.6);
                yield return new nhtemp(19, 1930, 51.5);
                yield return new nhtemp(20, 1931, 52.8);
                yield return new nhtemp(21, 1932, 51.8);
                yield return new nhtemp(22, 1933, 51.1);
                yield return new nhtemp(23, 1934, 49.8);
                yield return new nhtemp(24, 1935, 50.2);
                yield return new nhtemp(25, 1936, 50.4);
                yield return new nhtemp(26, 1937, 51.6);
                yield return new nhtemp(27, 1938, 51.8);
                yield return new nhtemp(28, 1939, 50.9);
                yield return new nhtemp(29, 1940, 48.8);
                yield return new nhtemp(30, 1941, 51.7);
                yield return new nhtemp(31, 1942, 51);
                yield return new nhtemp(32, 1943, 50.6);
                yield return new nhtemp(33, 1944, 51.7);
                yield return new nhtemp(34, 1945, 51.5);
                yield return new nhtemp(35, 1946, 52.1);
                yield return new nhtemp(36, 1947, 51.3);
                yield return new nhtemp(37, 1948, 51);
                yield return new nhtemp(38, 1949, 54);
                yield return new nhtemp(39, 1950, 51.4);
                yield return new nhtemp(40, 1951, 52.7);
                yield return new nhtemp(41, 1952, 53.1);
                yield return new nhtemp(42, 1953, 54.6);
                yield return new nhtemp(43, 1954, 52);
                yield return new nhtemp(44, 1955, 52);
                yield return new nhtemp(45, 1956, 50.9);
                yield return new nhtemp(46, 1957, 52.6);
                yield return new nhtemp(47, 1958, 50.2);
                yield return new nhtemp(48, 1959, 52.6);
                yield return new nhtemp(49, 1960, 51.6);
                yield return new nhtemp(50, 1961, 51.9);
                yield return new nhtemp(51, 1962, 50.5);
                yield return new nhtemp(52, 1963, 50.9);
                yield return new nhtemp(53, 1964, 51.7);
                yield return new nhtemp(54, 1965, 51.4);
                yield return new nhtemp(55, 1966, 51.7);
                yield return new nhtemp(56, 1967, 50.8);
                yield return new nhtemp(57, 1968, 51.9);
                yield return new nhtemp(58, 1969, 51.8);
                yield return new nhtemp(59, 1970, 51.9);
                yield return new nhtemp(60, 1971, 53);
            }
        }
    }
}
