// ReSharper disable All

namespace Rdatasets.mosaicData
{
    using System.Collections.Generic;

    /// <summary>
    /// 100 m Swimming World Records
    /// </summary>

    public class SwimRecords
    {
        public readonly int year;
        public readonly double time;
        public readonly string sex;

        public SwimRecords(int year, double time, string sex)
        {
            this.year = year;
            this.time = time;
            this.sex = sex;
        }

        public static IEnumerable<SwimRecords> Data
        {
            get
            {
                yield return new SwimRecords(1905, 65.8, "M");
                yield return new SwimRecords(1908, 65.6, "M");
                yield return new SwimRecords(1910, 62.8, "M");
                yield return new SwimRecords(1912, 61.6, "M");
                yield return new SwimRecords(1918, 61.4, "M");
                yield return new SwimRecords(1920, 60.4, "M");
                yield return new SwimRecords(1922, 58.6, "M");
                yield return new SwimRecords(1924, 57.4, "M");
                yield return new SwimRecords(1934, 56.8, "M");
                yield return new SwimRecords(1935, 56.6, "M");
                yield return new SwimRecords(1936, 56.4, "M");
                yield return new SwimRecords(1944, 55.9, "M");
                yield return new SwimRecords(1947, 55.8, "M");
                yield return new SwimRecords(1948, 55.4, "M");
                yield return new SwimRecords(1955, 54.8, "M");
                yield return new SwimRecords(1957, 54.6, "M");
                yield return new SwimRecords(1961, 53.6, "M");
                yield return new SwimRecords(1964, 52.9, "M");
                yield return new SwimRecords(1967, 52.6, "M");
                yield return new SwimRecords(1968, 52.2, "M");
                yield return new SwimRecords(1970, 51.9, "M");
                yield return new SwimRecords(1972, 51.22, "M");
                yield return new SwimRecords(1975, 50.59, "M");
                yield return new SwimRecords(1976, 49.44, "M");
                yield return new SwimRecords(1981, 49.36, "M");
                yield return new SwimRecords(1985, 49.24, "M");
                yield return new SwimRecords(1986, 48.74, "M");
                yield return new SwimRecords(1988, 48.42, "M");
                yield return new SwimRecords(1994, 48.21, "M");
                yield return new SwimRecords(2000, 48.18, "M");
                yield return new SwimRecords(2000, 47.84, "M");
                yield return new SwimRecords(1908, 95, "F");
                yield return new SwimRecords(1910, 86.6, "F");
                yield return new SwimRecords(1911, 84.6, "F");
                yield return new SwimRecords(1912, 78.8, "F");
                yield return new SwimRecords(1915, 76.2, "F");
                yield return new SwimRecords(1920, 73.6, "F");
                yield return new SwimRecords(1923, 72.8, "F");
                yield return new SwimRecords(1924, 72.2, "F");
                yield return new SwimRecords(1926, 70, "F");
                yield return new SwimRecords(1929, 69.4, "F");
                yield return new SwimRecords(1930, 68, "F");
                yield return new SwimRecords(1931, 66.6, "F");
                yield return new SwimRecords(1933, 66, "F");
                yield return new SwimRecords(1934, 65.4, "F");
                yield return new SwimRecords(1936, 64.6, "F");
                yield return new SwimRecords(1956, 62, "F");
                yield return new SwimRecords(1958, 61.2, "F");
                yield return new SwimRecords(1960, 60.2, "F");
                yield return new SwimRecords(1962, 59.5, "F");
                yield return new SwimRecords(1964, 58.9, "F");
                yield return new SwimRecords(1972, 58.5, "F");
                yield return new SwimRecords(1973, 57.54, "F");
                yield return new SwimRecords(1974, 56.96, "F");
                yield return new SwimRecords(1976, 55.65, "F");
                yield return new SwimRecords(1978, 55.41, "F");
                yield return new SwimRecords(1980, 54.79, "F");
                yield return new SwimRecords(1986, 54.73, "F");
                yield return new SwimRecords(1992, 54.48, "F");
                yield return new SwimRecords(1994, 54.01, "F");
                yield return new SwimRecords(2000, 53.77, "F");
                yield return new SwimRecords(2004, 53.52, "F");
            }
        }
    }
}
