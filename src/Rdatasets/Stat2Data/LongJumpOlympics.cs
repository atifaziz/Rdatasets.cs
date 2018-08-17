// ReSharper disable All

namespace Rdatasets.Stat2Data
{
    using System.Collections.Generic;

    /// <summary>
    /// LongJumpOlympics
    /// </summary>

    public class LongJumpOlympics
    {
        public readonly int Year;
        public readonly double Gold;

        public LongJumpOlympics(int Year, double Gold)
        {
            this.Year = Year;
            this.Gold = Gold;
        }

        public static IEnumerable<LongJumpOlympics> Data
        {
            get
            {
                yield return new LongJumpOlympics(1900, 7.185);
                yield return new LongJumpOlympics(1904, 7.34);
                yield return new LongJumpOlympics(1906, 7.2);
                yield return new LongJumpOlympics(1908, 7.48);
                yield return new LongJumpOlympics(1912, 7.6);
                yield return new LongJumpOlympics(1920, 7.15);
                yield return new LongJumpOlympics(1924, 7.445);
                yield return new LongJumpOlympics(1928, 7.73);
                yield return new LongJumpOlympics(1932, 7.64);
                yield return new LongJumpOlympics(1936, 8.06);
                yield return new LongJumpOlympics(1948, 7.825);
                yield return new LongJumpOlympics(1952, 7.57);
                yield return new LongJumpOlympics(1956, 7.83);
                yield return new LongJumpOlympics(1960, 8.12);
                yield return new LongJumpOlympics(1964, 8.07);
                yield return new LongJumpOlympics(1968, 8.9);
                yield return new LongJumpOlympics(1972, 8.24);
                yield return new LongJumpOlympics(1976, 8.35);
                yield return new LongJumpOlympics(1980, 8.54);
                yield return new LongJumpOlympics(1984, 8.54);
                yield return new LongJumpOlympics(1988, 8.72);
                yield return new LongJumpOlympics(1992, 8.67);
                yield return new LongJumpOlympics(1996, 8.5);
                yield return new LongJumpOlympics(2000, 8.55);
                yield return new LongJumpOlympics(2004, 8.59);
                yield return new LongJumpOlympics(2008, 8.37);
            }
        }
    }
}
