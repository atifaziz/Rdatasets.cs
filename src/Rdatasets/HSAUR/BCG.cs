// ReSharper disable All

namespace Rdatasets.HSAUR
{
    using System.Collections.Generic;

    /// <summary>
    /// BCG Vaccine Data
    /// </summary>

    public class BCG
    {
        public readonly int Study;
        public readonly int BCGTB;
        public readonly int BCGVacc;
        public readonly int NoVaccTB;
        public readonly int NoVacc;
        public readonly int Latitude;
        public readonly int Year;

        public BCG(int Study, int BCGTB, int BCGVacc, int NoVaccTB, int NoVacc, int Latitude, int Year)
        {
            this.Study = Study;
            this.BCGTB = BCGTB;
            this.BCGVacc = BCGVacc;
            this.NoVaccTB = NoVaccTB;
            this.NoVacc = NoVacc;
            this.Latitude = Latitude;
            this.Year = Year;
        }

        public static IEnumerable<BCG> Data
        {
            get
            {
                yield return new BCG(1, 4, 123, 11, 139, 44, 1948);
                yield return new BCG(2, 6, 306, 29, 303, 55, 1949);
                yield return new BCG(3, 3, 231, 11, 220, 42, 1960);
                yield return new BCG(4, 62, 13598, 248, 12867, 52, 1977);
                yield return new BCG(5, 33, 5069, 47, 5808, 13, 1973);
                yield return new BCG(6, 180, 1541, 372, 1451, 44, 1953);
                yield return new BCG(7, 8, 2545, 10, 629, 19, 1973);
                yield return new BCG(8, 505, 88391, 499, 88391, 13, 1980);
                yield return new BCG(9, 29, 7499, 45, 7277, 27, 1968);
                yield return new BCG(10, 17, 1716, 65, 1665, 42, 1961);
                yield return new BCG(11, 186, 50634, 141, 27338, 18, 1974);
                yield return new BCG(12, 5, 2498, 3, 2341, 33, 1969);
                yield return new BCG(13, 27, 16913, 29, 17854, 33, 1976);
            }
        }
    }
}
