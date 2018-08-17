// ReSharper disable All

namespace Rdatasets.DAAG
{
    using System.Collections.Generic;

    /// <summary>
    /// A Summary of the Cars93 Data set
    /// </summary>

    public class Cars93_summary
    {
        public readonly int Min_passengers;
        public readonly int Max_passengers;
        public readonly int No_of_cars;
        public readonly string abbrev;

        public Cars93_summary(int Min_passengers, int Max_passengers, int No_of_cars, string abbrev)
        {
            this.Min_passengers = Min_passengers;
            this.Max_passengers = Max_passengers;
            this.No_of_cars = No_of_cars;
            this.abbrev = abbrev;
        }

        public static IEnumerable<Cars93_summary> Data
        {
            get
            {
                yield return new Cars93_summary(4, 6, 16, "C");
                yield return new Cars93_summary(6, 6, 11, "L");
                yield return new Cars93_summary(4, 6, 22, "M");
                yield return new Cars93_summary(4, 5, 21, "Sm");
                yield return new Cars93_summary(2, 4, 14, "Sp");
                yield return new Cars93_summary(7, 8, 9, "V");
            }
        }
    }
}
