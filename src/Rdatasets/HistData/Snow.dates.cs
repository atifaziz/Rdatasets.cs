// ReSharper disable All

namespace Rdatasets.HistData
{
    using System.Collections.Generic;

    /// <summary>
    /// John Snow's Map and Data on the 1854 London Cholera Outbreak
    /// </summary>

    public class Snow_dates
    {
        public readonly string date;
        public readonly int attacks;
        public readonly int deaths;

        public Snow_dates(string date, int attacks, int deaths)
        {
            this.date = date;
            this.attacks = attacks;
            this.deaths = deaths;
        }

        public static IEnumerable<Snow_dates> Data
        {
            get
            {
                yield return new Snow_dates("1854-08-19", 1, 1);
                yield return new Snow_dates("1854-08-20", 1, 0);
                yield return new Snow_dates("1854-08-21", 1, 2);
                yield return new Snow_dates("1854-08-22", 0, 0);
                yield return new Snow_dates("1854-08-23", 1, 0);
                yield return new Snow_dates("1854-08-24", 1, 2);
                yield return new Snow_dates("1854-08-25", 0, 0);
                yield return new Snow_dates("1854-08-26", 1, 0);
                yield return new Snow_dates("1854-08-27", 1, 1);
                yield return new Snow_dates("1854-08-28", 1, 0);
                yield return new Snow_dates("1854-08-29", 1, 1);
                yield return new Snow_dates("1854-08-30", 8, 2);
                yield return new Snow_dates("1854-08-31", 56, 3);
                yield return new Snow_dates("1854-09-01", 143, 70);
                yield return new Snow_dates("1854-09-02", 116, 127);
                yield return new Snow_dates("1854-09-03", 54, 76);
                yield return new Snow_dates("1854-09-04", 46, 71);
                yield return new Snow_dates("1854-09-05", 36, 45);
                yield return new Snow_dates("1854-09-06", 20, 37);
                yield return new Snow_dates("1854-09-07", 28, 32);
                yield return new Snow_dates("1854-09-08", 12, 30);
                yield return new Snow_dates("1854-09-09", 11, 24);
                yield return new Snow_dates("1854-09-10", 5, 18);
                yield return new Snow_dates("1854-09-11", 5, 15);
                yield return new Snow_dates("1854-09-12", 1, 6);
                yield return new Snow_dates("1854-09-13", 3, 13);
                yield return new Snow_dates("1854-09-14", 0, 6);
                yield return new Snow_dates("1854-09-15", 1, 8);
                yield return new Snow_dates("1854-09-16", 4, 6);
                yield return new Snow_dates("1854-09-17", 2, 5);
                yield return new Snow_dates("1854-09-18", 3, 2);
                yield return new Snow_dates("1854-09-19", 0, 3);
                yield return new Snow_dates("1854-09-20", 0, 0);
                yield return new Snow_dates("1854-09-21", 2, 0);
                yield return new Snow_dates("1854-09-22", 1, 2);
                yield return new Snow_dates("1854-09-23", 1, 3);
                yield return new Snow_dates("1854-09-24", 1, 0);
                yield return new Snow_dates("1854-09-25", 1, 0);
                yield return new Snow_dates("1854-09-26", 1, 2);
                yield return new Snow_dates("1854-09-27", 1, 0);
                yield return new Snow_dates("1854-09-28", 0, 2);
                yield return new Snow_dates("1854-09-29", 0, 1);
                yield return new Snow_dates("1854-09-30", 0, 0);
                yield return new Snow_dates(null, 45, 0);
            }
        }
    }
}
