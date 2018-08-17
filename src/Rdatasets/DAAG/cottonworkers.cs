// ReSharper disable All

namespace Rdatasets.DAAG
{
    using System.Collections.Generic;

    /// <summary>
    /// Occupation and wage profiles of British cotton workers
    /// </summary>

    public class cottonworkers
    {
        public readonly int census1886;
        public readonly int survey1889;
        public readonly double avwage;

        public cottonworkers(int census1886, int survey1889, double avwage)
        {
            this.census1886 = census1886;
            this.survey1889 = survey1889;
            this.avwage = avwage;
        }

        public static IEnumerable<cottonworkers> Data
        {
            get
            {
                yield return new cottonworkers(5902, 2, 233.59);
                yield return new cottonworkers(375, 1, 328.98);
                yield return new cottonworkers(909, 12, 388.47);
                yield return new cottonworkers(2883, 37, 466.54);
                yield return new cottonworkers(1983, 17, 399.9);
                yield return new cottonworkers(208, 17, 269.73);
                yield return new cottonworkers(669, 4, 440.82);
                yield return new cottonworkers(2966, 44, 311.64);
                yield return new cottonworkers(597, 6, 469.62);
                yield return new cottonworkers(6951, 156, 408.97);
                yield return new cottonworkers(865, 5, 357.2);
                yield return new cottonworkers(1586, 14, 308.73);
                yield return new cottonworkers(0, 4, 456.23);
                yield return new cottonworkers(8577, 21, 273.97);
            }
        }
    }
}
