// ReSharper disable All

namespace Rdatasets.Stat2Data
{
    using System.Collections.Generic;

    /// <summary>
    /// PalmBeach
    /// </summary>

    public class PalmBeach
    {
        public readonly string County;
        public readonly int Buchanan;
        public readonly int Bush;

        public PalmBeach(string County, int Buchanan, int Bush)
        {
            this.County = County;
            this.Buchanan = Buchanan;
            this.Bush = Bush;
        }

        public static IEnumerable<PalmBeach> Data
        {
            get
            {
                yield return new PalmBeach("ALACHUA", 262, 34062);
                yield return new PalmBeach("BAKER", 73, 5610);
                yield return new PalmBeach("BAY", 248, 38637);
                yield return new PalmBeach("BRADFORD", 65, 5413);
                yield return new PalmBeach("BREVARD", 570, 115185);
                yield return new PalmBeach("BROWARD", 789, 177279);
                yield return new PalmBeach("CALHOUN", 90, 2873);
                yield return new PalmBeach("CHARLOTTE", 182, 35419);
                yield return new PalmBeach("CITRUS", 270, 29744);
                yield return new PalmBeach("CLAY", 186, 41745);
                yield return new PalmBeach("COLLIER", 122, 60426);
                yield return new PalmBeach("COLUMBIA", 89, 10964);
                yield return new PalmBeach("DADE", 561, 289456);
                yield return new PalmBeach("DE SOTO", 36, 4256);
                yield return new PalmBeach("DIXIE", 29, 2698);
                yield return new PalmBeach("DUVAL", 650, 152082);
                yield return new PalmBeach("ESCAMBIA", 504, 73029);
                yield return new PalmBeach("FLAGLER", 83, 12608);
                yield return new PalmBeach("FRANKLIN", 33, 2448);
                yield return new PalmBeach("GADSDEN", 39, 4750);
                yield return new PalmBeach("GILCHRIST", 29, 3300);
                yield return new PalmBeach("GLADES", 9, 1840);
                yield return new PalmBeach("GULF", 71, 3546);
                yield return new PalmBeach("HAMILTON", 24, 2153);
                yield return new PalmBeach("HARDEE", 30, 3764);
                yield return new PalmBeach("HENDRY", 22, 4743);
                yield return new PalmBeach("HERNANDO", 242, 30646);
                yield return new PalmBeach("HIGHLANDS", 99, 20196);
                yield return new PalmBeach("HILLSBOROUGH", 836, 176967);
                yield return new PalmBeach("HOLMES", 76, 4985);
                yield return new PalmBeach("INDIAN RIVER", 105, 28627);
                yield return new PalmBeach("JACKSON", 102, 9138);
                yield return new PalmBeach("JEFFERSON", 29, 2481);
                yield return new PalmBeach("LAFAYETTE", 10, 1669);
                yield return new PalmBeach("LAKE", 289, 49963);
                yield return new PalmBeach("LEE", 305, 106141);
                yield return new PalmBeach("LEON", 282, 39053);
                yield return new PalmBeach("LEVY", 67, 6860);
                yield return new PalmBeach("LIBERTY", 39, 1316);
                yield return new PalmBeach("MADISON", 29, 3038);
                yield return new PalmBeach("MANATEE", 272, 57948);
                yield return new PalmBeach("MARION", 563, 55135);
                yield return new PalmBeach("MARTIN", 108, 33864);
                yield return new PalmBeach("MONROE", 47, 16059);
                yield return new PalmBeach("NASSAU", 90, 16404);
                yield return new PalmBeach("OKALOOSA", 267, 52043);
                yield return new PalmBeach("OKEECHOBEE", 43, 5058);
                yield return new PalmBeach("ORANGE", 446, 134476);
                yield return new PalmBeach("OSCEOLA", 145, 26216);
                yield return new PalmBeach("PALM BEACH", 3407, 152846);
                yield return new PalmBeach("PASCO", 570, 68581);
                yield return new PalmBeach("PINELLAS", 1010, 184312);
                yield return new PalmBeach("POLK", 538, 90101);
                yield return new PalmBeach("PUTNAM", 147, 13439);
                yield return new PalmBeach("ST. JOHNS", 229, 39497);
                yield return new PalmBeach("ST. LUCIE", 124, 34705);
                yield return new PalmBeach("SANTA ROSA", 311, 36248);
                yield return new PalmBeach("SARASOTA", 305, 83100);
                yield return new PalmBeach("SEMINOLE", 194, 75293);
                yield return new PalmBeach("SUMTER", 114, 12126);
                yield return new PalmBeach("SUWANNEE", 108, 8014);
                yield return new PalmBeach("TAYLOR", 27, 4051);
                yield return new PalmBeach("UNION", 26, 2326);
                yield return new PalmBeach("VOLUSIA", 396, 82214);
                yield return new PalmBeach("WAKULLA", 46, 4511);
                yield return new PalmBeach("WALTON", 120, 12176);
                yield return new PalmBeach("WASHINGTON", 88, 4983);
            }
        }
    }
}
