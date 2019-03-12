// ReSharper disable All

namespace Rdatasets.carData
{
    using System.Collections.Generic;

    /// <summary>
    /// Crowding and Crime in U. S. Metropolitan Areas
    /// </summary>

    public class Freedman
    {
        public readonly string κ;
        public readonly int? population;
        public readonly double nonwhite;
        public readonly int? density;
        public readonly int crime;

        public Freedman(string κ, int? population, double nonwhite, int? density, int crime)
        {
            this.κ = κ;
            this.population = population;
            this.nonwhite = nonwhite;
            this.density = density;
            this.crime = crime;
        }

        public static IEnumerable<Freedman> Data
        {
            get
            {
                yield return new Freedman("Akron", 675, 7.3, 746, 2602);
                yield return new Freedman("Albany", 713, 2.6, 322, 1388);
                yield return new Freedman("Albuquerque", null, 3.3, null, 5018);
                yield return new Freedman("Allentown", 534, 0.8, 491, 1182);
                yield return new Freedman("Anaheim", 1261, 1.4, 1612, 3341);
                yield return new Freedman("Atlanta", 1330, 22.8, 770, 2805);
                yield return new Freedman("Bakersfield", 331, 7, 41, 3306);
                yield return new Freedman("Baltimore", 1981, 21.6, 877, 4256);
                yield return new Freedman("Beaumont", 315, 20.7, 240, 2117);
                yield return new Freedman("Binghamton", 305, 0.6, 147, 1063);
                yield return new Freedman("Birmingham", 739, 32.1, 272, 2285);
                yield return new Freedman("Boston", 3239, 3.4, 1831, 2835);
                yield return new Freedman("Bridgeport", 785, 5.3, 1252, 2630);
                yield return new Freedman("Buffalo", 1324, 6.8, 832, 2171);
                yield return new Freedman("Canton", 363, 5.4, 630, 1764);
                yield return new Freedman("Charleston.SC", null, 38.5, null, 2482);
                yield return new Freedman("Charleston.W.VA", null, 5.8, null, 1434);
                yield return new Freedman("Charlotte", 388, 24.2, 328, 3447);
                yield return new Freedman("Chattanooga", 306, 17.6, 308, 2643);
                yield return new Freedman("Chicago", 6815, 14.8, 1832, 2680);
                yield return new Freedman("Cincinnati", 1376, 10.4, 640, 1780);
                yield return new Freedman("Cleveland", 2068, 13.7, 1361, 3162);
                yield return new Freedman("Columbia", null, 29, null, 2884);
                yield return new Freedman("Columbus", 870, 11, 583, 3037);
                yield return new Freedman("Corpus.Christi", 297, 4.2, 194, 3077);
                yield return new Freedman("Dallas", 1459, 15, 320, 3701);
                yield return new Freedman("Davenport", 366, 2.1, 215, 1877);
                yield return new Freedman("Dayton", 836, 9.7, 489, 2392);
                yield return new Freedman("Denver", 1129, 4.2, 308, 4095);
                yield return new Freedman("Des.Moines", null, 4.1, null, 2415);
                yield return new Freedman("Detroit", 4127, 13.1, 2114, 4283);
                yield return new Freedman("Duluth", 271, 0.8, 37, 1736);
                yield return new Freedman("El.Paso", 351, 3.3, 332, 2430);
                yield return new Freedman("Erie", null, 2.8, null, 1181);
                yield return new Freedman("Flint", 487, 9, 374, 3164);
                yield return new Freedman("Fort.Lauderdale", 526, 16.6, 431, 3688);
                yield return new Freedman("Fort.Worth", 680, 10.7, 423, 2927);
                yield return new Freedman("Fresno", 415, 7.5, 70, 3863);
                yield return new Freedman("Gary", 608, 15.3, 649, 3310);
                yield return new Freedman("Grand.Rapids", 514, 3.4, 362, 2188);
                yield return new Freedman("Greensboro", 592, 19.9, 268, 1987);
                yield return new Freedman("Greenville", null, 16.3, null, 2602);
                yield return new Freedman("Harrisburg", 398, 6.3, 245, 1339);
                yield return new Freedman("Hartford", 802, 5.4, 1085, 2390);
                yield return new Freedman("Honolulu", 628, 64.3, 1053, 3283);
                yield return new Freedman("Houston", 1867, 19.8, 297, 3511);
                yield return new Freedman("Huntington", null, 3, null, 1413);
                yield return new Freedman("Indianapolis", 1062, 10.8, 345, 2798);
                yield return new Freedman("Jacksonville", 513, 23.4, 670, 4035);
                yield return new Freedman("Jersey.City", 615, 6.9, 13087, 2301);
                yield return new Freedman("Johnstown", 270, 1.3, 151, 458);
                yield return new Freedman("Kansas.City", 1231, 10.9, 445, 3748);
                yield return new Freedman("Knoxville", 399, 7.5, 281, 1597);
                yield return new Freedman("Lancaster", 302, 1.3, 319, 627);
                yield return new Freedman("Lansing", 361, 2.8, 212, 2991);
                yield return new Freedman("Little.Rock", 323, 19.9, 217, 3420);
                yield return new Freedman("Los.Angeles", 6860, 9.7, 1686, 4852);
                yield return new Freedman("Louisville", 802, 11.6, 883, 3758);
                yield return new Freedman("Memphis", 770, 38, 565, 2691);
                yield return new Freedman("Miami", 1150, 14.9, 563, 4460);
                yield return new Freedman("Milwaukee", 1344, 5.3, 923, 1929);
                yield return new Freedman("Minneapolis", 1677, 1.8, 796, 3231);
                yield return new Freedman("Mobile", 382, 30.8, 135, 2433);
                yield return new Freedman("Nashville", 536, 18.4, 329, 3185);
                yield return new Freedman("New.Haven", 726, 7.7, 1200, 2726);
                yield return new Freedman("New.Orleans", 1064, 30.9, 539, 3467);
                yield return new Freedman("New.York", 11551, 12, 5408, 4732);
                yield return new Freedman("Newark", 1881, 13.4, 2683, 3261);
                yield return new Freedman("Norfolk", 653, 26.4, 963, 3160);
                yield return new Freedman("Oklahoma.City", 605, 9.4, 283, 2343);
                yield return new Freedman("Omaha", 525, 6, 342, 2663);
                yield return new Freedman("Orlando", 390, 16.6, 321, 2560);
                yield return new Freedman("Paterson", 1353, 3.8, 3170, 1922);
                yield return new Freedman("peoria", 336, 3.3, 186, 2125);
                yield return new Freedman("philadelphia", 4829, 15.7, 1359, 1753);
                yield return new Freedman("phoenix", 872, 5.5, 94, 3962);
                yield return new Freedman("pittsburgh", 2387, 6.8, 783, 2127);
                yield return new Freedman("Portland", 957, 3, 262, 3627);
                yield return new Freedman("Providence", 749, 1.9, 1221, 2903);
                yield return new Freedman("Reading", 292, 1.8, 338, 1052);
                yield return new Freedman("Richmond", 515, 26.3, 430, 3183);
                yield return new Freedman("Rochester", 853, 4, 368, 1820);
                yield return new Freedman("Sacramento", 765, 6.8, 222, 3793);
                yield return new Freedman("St.Louis", 2327, 14.2, 565, 3302);
                yield return new Freedman("Salt.Lake", 534, 1.4, 504, 2977);
                yield return new Freedman("San.Antonio", 850, 7.1, 434, 3459);
                yield return new Freedman("San.Bernardino", 1086, 4.7, 40, 3743);
                yield return new Freedman("San.Diego", 1221, 5.5, 286, 2587);
                yield return new Freedman("San.Francisco", 2999, 12.5, 1210, 5441);
                yield return new Freedman("San.Jose", 985, 3.2, 758, 3000);
                yield return new Freedman("Seattle", 1340, 4.8, 317, 4329);
                yield return new Freedman("Shreveport", 299, 34.1, 171, 1864);
                yield return new Freedman("South.Bend", 275, 5.3, 302, 1973);
                yield return new Freedman("Spokane", 273, 2, 155, 2130);
                yield return new Freedman("Springfield", 554, 3.1, 481, 2467);
                yield return new Freedman("Syracuse", 625, 2.6, 259, 1577);
                yield return new Freedman("Tacoma", 401, 5.1, 239, 2843);
                yield return new Freedman("Tampa", 924, 11.5, 709, 3247);
                yield return new Freedman("Toledo", 678, 7.3, 446, 2050);
                yield return new Freedman("trenton", null, 12.9, null, 3098);
                yield return new Freedman("Tucson", null, 6.3, null, 2705);
                yield return new Freedman("Tulsa", 466, 9.2, 123, 2840);
                yield return new Freedman("Utica", 350, 1.6, 132, 869);
                yield return new Freedman("Washington", 2751, 24.5, 1170, 4019);
                yield return new Freedman("Wichita", 406, 5.8, 166, 2532);
                yield return new Freedman("Wilkes", 340, 0.3, 383, 613);
                yield return new Freedman("Wilmington", 488, 11.7, 419, 2393);
                yield return new Freedman("Worcester", 612, 0.9, 405, 2874);
                yield return new Freedman("York", 316, 2, 220, 1062);
                yield return new Freedman("Youngstown", 528, 9.2, 513, 1698);
            }
        }
    }
}
