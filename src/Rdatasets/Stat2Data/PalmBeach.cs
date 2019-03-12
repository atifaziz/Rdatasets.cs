// ReSharper disable All

namespace Rdatasets.Stat2Data
{
    using System.Collections.Generic;

    /// <summary>
    /// PalmBeach
    /// </summary>

    public class PalmBeach
    {
        public readonly int κ;
        public readonly string County;
        public readonly int Buchanan;
        public readonly int Bush;

        public PalmBeach(int κ, string County, int Buchanan, int Bush)
        {
            this.κ = κ;
            this.County = County;
            this.Buchanan = Buchanan;
            this.Bush = Bush;
        }

        public static IEnumerable<PalmBeach> Data
        {
            get
            {
                yield return new PalmBeach(1, "ALACHUA", 262, 34062);
                yield return new PalmBeach(2, "BAKER", 73, 5610);
                yield return new PalmBeach(3, "BAY", 248, 38637);
                yield return new PalmBeach(4, "BRADFORD", 65, 5413);
                yield return new PalmBeach(5, "BREVARD", 570, 115185);
                yield return new PalmBeach(6, "BROWARD", 789, 177279);
                yield return new PalmBeach(7, "CALHOUN", 90, 2873);
                yield return new PalmBeach(8, "CHARLOTTE", 182, 35419);
                yield return new PalmBeach(9, "CITRUS", 270, 29744);
                yield return new PalmBeach(10, "CLAY", 186, 41745);
                yield return new PalmBeach(11, "COLLIER", 122, 60426);
                yield return new PalmBeach(12, "COLUMBIA", 89, 10964);
                yield return new PalmBeach(13, "DADE", 561, 289456);
                yield return new PalmBeach(14, "DE SOTO", 36, 4256);
                yield return new PalmBeach(15, "DIXIE", 29, 2698);
                yield return new PalmBeach(16, "DUVAL", 650, 152082);
                yield return new PalmBeach(17, "ESCAMBIA", 504, 73029);
                yield return new PalmBeach(18, "FLAGLER", 83, 12608);
                yield return new PalmBeach(19, "FRANKLIN", 33, 2448);
                yield return new PalmBeach(20, "GADSDEN", 39, 4750);
                yield return new PalmBeach(21, "GILCHRIST", 29, 3300);
                yield return new PalmBeach(22, "GLADES", 9, 1840);
                yield return new PalmBeach(23, "GULF", 71, 3546);
                yield return new PalmBeach(24, "HAMILTON", 24, 2153);
                yield return new PalmBeach(25, "HARDEE", 30, 3764);
                yield return new PalmBeach(26, "HENDRY", 22, 4743);
                yield return new PalmBeach(27, "HERNANDO", 242, 30646);
                yield return new PalmBeach(28, "HIGHLANDS", 99, 20196);
                yield return new PalmBeach(29, "HILLSBOROUGH", 836, 176967);
                yield return new PalmBeach(30, "HOLMES", 76, 4985);
                yield return new PalmBeach(31, "INDIAN RIVER", 105, 28627);
                yield return new PalmBeach(32, "JACKSON", 102, 9138);
                yield return new PalmBeach(33, "JEFFERSON", 29, 2481);
                yield return new PalmBeach(34, "LAFAYETTE", 10, 1669);
                yield return new PalmBeach(35, "LAKE", 289, 49963);
                yield return new PalmBeach(36, "LEE", 305, 106141);
                yield return new PalmBeach(37, "LEON", 282, 39053);
                yield return new PalmBeach(38, "LEVY", 67, 6860);
                yield return new PalmBeach(39, "LIBERTY", 39, 1316);
                yield return new PalmBeach(40, "MADISON", 29, 3038);
                yield return new PalmBeach(41, "MANATEE", 272, 57948);
                yield return new PalmBeach(42, "MARION", 563, 55135);
                yield return new PalmBeach(43, "MARTIN", 108, 33864);
                yield return new PalmBeach(44, "MONROE", 47, 16059);
                yield return new PalmBeach(45, "NASSAU", 90, 16404);
                yield return new PalmBeach(46, "OKALOOSA", 267, 52043);
                yield return new PalmBeach(47, "OKEECHOBEE", 43, 5058);
                yield return new PalmBeach(48, "ORANGE", 446, 134476);
                yield return new PalmBeach(49, "OSCEOLA", 145, 26216);
                yield return new PalmBeach(50, "PALM BEACH", 3407, 152846);
                yield return new PalmBeach(51, "PASCO", 570, 68581);
                yield return new PalmBeach(52, "PINELLAS", 1010, 184312);
                yield return new PalmBeach(53, "POLK", 538, 90101);
                yield return new PalmBeach(54, "PUTNAM", 147, 13439);
                yield return new PalmBeach(55, "ST. JOHNS", 229, 39497);
                yield return new PalmBeach(56, "ST. LUCIE", 124, 34705);
                yield return new PalmBeach(57, "SANTA ROSA", 311, 36248);
                yield return new PalmBeach(58, "SARASOTA", 305, 83100);
                yield return new PalmBeach(59, "SEMINOLE", 194, 75293);
                yield return new PalmBeach(60, "SUMTER", 114, 12126);
                yield return new PalmBeach(61, "SUWANNEE", 108, 8014);
                yield return new PalmBeach(62, "TAYLOR", 27, 4051);
                yield return new PalmBeach(63, "UNION", 26, 2326);
                yield return new PalmBeach(64, "VOLUSIA", 396, 82214);
                yield return new PalmBeach(65, "WAKULLA", 46, 4511);
                yield return new PalmBeach(66, "WALTON", 120, 12176);
                yield return new PalmBeach(67, "WASHINGTON", 88, 4983);
            }
        }
    }
}
