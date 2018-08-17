// ReSharper disable All

namespace Rdatasets.datasets
{
    using System.Collections.Generic;

    /// <summary>
    /// Personal Expenditure Data
    /// </summary>

    public class USPersonalExpenditure
    {
        public readonly double _1940;
        public readonly double _1945;
        public readonly double _1950;
        public readonly double _1955;
        public readonly double _1960;

        public USPersonalExpenditure(double _1940, double _1945, double _1950, double _1955, double _1960)
        {
            this._1940 = _1940;
            this._1945 = _1945;
            this._1950 = _1950;
            this._1955 = _1955;
            this._1960 = _1960;
        }

        public static IEnumerable<USPersonalExpenditure> Data
        {
            get
            {
                yield return new USPersonalExpenditure(22.2, 44.5, 59.6, 73.2, 86.8);
                yield return new USPersonalExpenditure(10.5, 15.5, 29, 36.5, 46.2);
                yield return new USPersonalExpenditure(3.53, 5.76, 9.71, 14, 21.1);
                yield return new USPersonalExpenditure(1.04, 1.98, 2.45, 3.4, 5.4);
                yield return new USPersonalExpenditure(0.341, 0.974, 1.8, 2.6, 3.64);
            }
        }
    }
}
