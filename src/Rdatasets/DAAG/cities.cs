// ReSharper disable All

namespace Rdatasets.DAAG
{
    using System.Collections.Generic;

    /// <summary>
    /// Populations of Major Canadian Cities (1992-96)
    /// </summary>

    public class cities
    {
        public readonly int κ;
        public readonly string CITY;
        public readonly string REGION;
        public readonly double POP1992;
        public readonly double POP1993;
        public readonly double POP1994;
        public readonly double POP1995;
        public readonly double POP1996;

        public cities(int κ, string CITY, string REGION, double POP1992, double POP1993, double POP1994, double POP1995, double POP1996)
        {
            this.κ = κ;
            this.CITY = CITY;
            this.REGION = REGION;
            this.POP1992 = POP1992;
            this.POP1993 = POP1993;
            this.POP1994 = POP1994;
            this.POP1995 = POP1995;
            this.POP1996 = POP1996;
        }

        public static IEnumerable<cities> Data
        {
            get
            {
                yield return new cities(1, "Toronto", "ON", 4116.9, 4198.2, 4256, 4346.3, 4444.7);
                yield return new cities(2, "Montreal", "QC", 3251.1, 3288.9, 3308.4, 3335.6, 3359);
                yield return new cities(3, "Vancouver", "WEST", 1690.8, 1734.3, 1779.8, 1832.9, 1891.4);
                yield return new cities(4, "Ottawa", "ON", 974.6, 997.7, 1010.7, 1023.2, 1030.5);
                yield return new cities(5, "Edmonton", "WEST", 870.7, 880.3, 881.7, 884.7, 891.5);
                yield return new cities(6, "Calgary", "WEST", 785.4, 798.2, 812.8, 831.8, 851.6);
                yield return new cities(7, "Quebec", "QC", 672.3, 682.6, 689.4, 693.4, 697.6);
                yield return new cities(8, "Winnipeg", "PR", 667.9, 671.7, 673.4, 677.3, 676.7);
                yield return new cities(9, "Hamilton", "ON", 626.8, 631.1, 635.8, 643.1, 650.4);
                yield return new cities(10, "London", "ON", 400.5, 404.3, 408.3, 413.2, 416.1);
                yield return new cities(11, "Kitchener", "ON", 376.3, 382.3, 388.5, 395.4, 403.3);
                yield return new cities(12, "StCatharines", "ON", 381.8, 383.7, 384.4, 386.5, 389.7);
                yield return new cities(13, "Halifax", "ATL", 331.4, 335, 338.8, 342.5, 346.8);
                yield return new cities(14, "Victoria", "WEST", 300.9, 304.8, 308.3, 311.4, 313.4);
                yield return new cities(15, "Windsor", "ON", 274.4, 277.7, 281.5, 285.9, 291.7);
                yield return new cities(16, "Oshawa", "ON", 256.7, 263.4, 269.6, 275.6, 280.9);
                yield return new cities(17, "Saskatoon", "PR", 215.6, 216.9, 217.9, 220.5, 222.1);
                yield return new cities(18, "Regina", "PR", 196.1, 197.3, 197.8, 198.6, 199.2);
                yield return new cities(19, "StJohns", "ATL", 177.4, 178.6, 178.5, 178.5, 177.8);
                yield return new cities(20, "Chicoutimi", "QC", 165.7, 166.9, 167.2, 167, 166.6);
                yield return new cities(21, "Sudbury", "ON", 166, 166.9, 166.6, 166.4, 166.2);
                yield return new cities(22, "Sherbrooke", "QC", 144.1, 145.4, 146.8, 148.2, 150);
                yield return new cities(23, "TroisRivieres", "QC", 141.4, 141.9, 142.5, 143.2, 143.6);
                yield return new cities(24, "ThunderBay", "ON", 130.2, 130.6, 130.7, 131, 131.3);
                yield return new cities(25, "SaintJohn", "ATL", 129.4, 129.6, 129.4, 129.3, 129.1);
            }
        }
    }
}
