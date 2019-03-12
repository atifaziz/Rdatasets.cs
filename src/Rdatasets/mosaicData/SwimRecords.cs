// ReSharper disable All

namespace Rdatasets.mosaicData
{
    using System.Collections.Generic;

    /// <summary>
    /// 100 m Swimming World Records
    /// </summary>

    public class SwimRecords
    {
        public readonly int κ;
        public readonly int year;
        public readonly double time;
        public readonly string sex;

        public SwimRecords(int κ, int year, double time, string sex)
        {
            this.κ = κ;
            this.year = year;
            this.time = time;
            this.sex = sex;
        }

        public static IEnumerable<SwimRecords> Data
        {
            get
            {
                yield return new SwimRecords(1, 1905, 65.8, "M");
                yield return new SwimRecords(2, 1908, 65.6, "M");
                yield return new SwimRecords(3, 1910, 62.8, "M");
                yield return new SwimRecords(4, 1912, 61.6, "M");
                yield return new SwimRecords(5, 1918, 61.4, "M");
                yield return new SwimRecords(6, 1920, 60.4, "M");
                yield return new SwimRecords(7, 1922, 58.6, "M");
                yield return new SwimRecords(8, 1924, 57.4, "M");
                yield return new SwimRecords(9, 1934, 56.8, "M");
                yield return new SwimRecords(10, 1935, 56.6, "M");
                yield return new SwimRecords(11, 1936, 56.4, "M");
                yield return new SwimRecords(12, 1944, 55.9, "M");
                yield return new SwimRecords(13, 1947, 55.8, "M");
                yield return new SwimRecords(14, 1948, 55.4, "M");
                yield return new SwimRecords(15, 1955, 54.8, "M");
                yield return new SwimRecords(16, 1957, 54.6, "M");
                yield return new SwimRecords(17, 1961, 53.6, "M");
                yield return new SwimRecords(18, 1964, 52.9, "M");
                yield return new SwimRecords(19, 1967, 52.6, "M");
                yield return new SwimRecords(20, 1968, 52.2, "M");
                yield return new SwimRecords(21, 1970, 51.9, "M");
                yield return new SwimRecords(22, 1972, 51.22, "M");
                yield return new SwimRecords(23, 1975, 50.59, "M");
                yield return new SwimRecords(24, 1976, 49.44, "M");
                yield return new SwimRecords(25, 1981, 49.36, "M");
                yield return new SwimRecords(26, 1985, 49.24, "M");
                yield return new SwimRecords(27, 1986, 48.74, "M");
                yield return new SwimRecords(28, 1988, 48.42, "M");
                yield return new SwimRecords(29, 1994, 48.21, "M");
                yield return new SwimRecords(30, 2000, 48.18, "M");
                yield return new SwimRecords(31, 2000, 47.84, "M");
                yield return new SwimRecords(32, 1908, 95, "F");
                yield return new SwimRecords(33, 1910, 86.6, "F");
                yield return new SwimRecords(34, 1911, 84.6, "F");
                yield return new SwimRecords(35, 1912, 78.8, "F");
                yield return new SwimRecords(36, 1915, 76.2, "F");
                yield return new SwimRecords(37, 1920, 73.6, "F");
                yield return new SwimRecords(38, 1923, 72.8, "F");
                yield return new SwimRecords(39, 1924, 72.2, "F");
                yield return new SwimRecords(40, 1926, 70, "F");
                yield return new SwimRecords(41, 1929, 69.4, "F");
                yield return new SwimRecords(42, 1930, 68, "F");
                yield return new SwimRecords(43, 1931, 66.6, "F");
                yield return new SwimRecords(44, 1933, 66, "F");
                yield return new SwimRecords(45, 1934, 65.4, "F");
                yield return new SwimRecords(46, 1936, 64.6, "F");
                yield return new SwimRecords(47, 1956, 62, "F");
                yield return new SwimRecords(48, 1958, 61.2, "F");
                yield return new SwimRecords(49, 1960, 60.2, "F");
                yield return new SwimRecords(50, 1962, 59.5, "F");
                yield return new SwimRecords(51, 1964, 58.9, "F");
                yield return new SwimRecords(52, 1972, 58.5, "F");
                yield return new SwimRecords(53, 1973, 57.54, "F");
                yield return new SwimRecords(54, 1974, 56.96, "F");
                yield return new SwimRecords(55, 1976, 55.65, "F");
                yield return new SwimRecords(56, 1978, 55.41, "F");
                yield return new SwimRecords(57, 1980, 54.79, "F");
                yield return new SwimRecords(58, 1986, 54.73, "F");
                yield return new SwimRecords(59, 1992, 54.48, "F");
                yield return new SwimRecords(60, 1994, 54.01, "F");
                yield return new SwimRecords(61, 2000, 53.77, "F");
                yield return new SwimRecords(62, 2004, 53.52, "F");
            }
        }
    }
}
