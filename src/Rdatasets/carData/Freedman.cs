// ReSharper disable All

namespace Rdatasets.carData
{
    using System.Collections.Generic;

    /// <summary>
    /// Crowding and Crime in U. S. Metropolitan Areas
    /// </summary>

    public class Freedman
    {
        public readonly string population;
        public readonly double nonwhite;
        public readonly string density;
        public readonly int crime;

        public Freedman(string population, double nonwhite, string density, int crime)
        {
            this.population = population;
            this.nonwhite = nonwhite;
            this.density = density;
            this.crime = crime;
        }

        public static IEnumerable<Freedman> Data
        {
            get
            {
                yield return new Freedman("675", 7.3, "746", 2602);
                yield return new Freedman("713", 2.6, "322", 1388);
                yield return new Freedman(null, 3.3, null, 5018);
                yield return new Freedman("534", 0.8, "491", 1182);
                yield return new Freedman("1261", 1.4, "1612", 3341);
                yield return new Freedman("1330", 22.8, "770", 2805);
                yield return new Freedman("331", 7, "41", 3306);
                yield return new Freedman("1981", 21.6, "877", 4256);
                yield return new Freedman("315", 20.7, "240", 2117);
                yield return new Freedman("305", 0.6, "147", 1063);
                yield return new Freedman("739", 32.1, "272", 2285);
                yield return new Freedman("3239", 3.4, "1831", 2835);
                yield return new Freedman("785", 5.3, "1252", 2630);
                yield return new Freedman("1324", 6.8, "832", 2171);
                yield return new Freedman("363", 5.4, "630", 1764);
                yield return new Freedman(null, 38.5, null, 2482);
                yield return new Freedman(null, 5.8, null, 1434);
                yield return new Freedman("388", 24.2, "328", 3447);
                yield return new Freedman("306", 17.6, "308", 2643);
                yield return new Freedman("6815", 14.8, "1832", 2680);
                yield return new Freedman("1376", 10.4, "640", 1780);
                yield return new Freedman("2068", 13.7, "1361", 3162);
                yield return new Freedman(null, 29, null, 2884);
                yield return new Freedman("870", 11, "583", 3037);
                yield return new Freedman("297", 4.2, "194", 3077);
                yield return new Freedman("1459", 15, "320", 3701);
                yield return new Freedman("366", 2.1, "215", 1877);
                yield return new Freedman("836", 9.7, "489", 2392);
                yield return new Freedman("1129", 4.2, "308", 4095);
                yield return new Freedman(null, 4.1, null, 2415);
                yield return new Freedman("4127", 13.1, "2114", 4283);
                yield return new Freedman("271", 0.8, "37", 1736);
                yield return new Freedman("351", 3.3, "332", 2430);
                yield return new Freedman(null, 2.8, null, 1181);
                yield return new Freedman("487", 9, "374", 3164);
                yield return new Freedman("526", 16.6, "431", 3688);
                yield return new Freedman("680", 10.7, "423", 2927);
                yield return new Freedman("415", 7.5, "70", 3863);
                yield return new Freedman("608", 15.3, "649", 3310);
                yield return new Freedman("514", 3.4, "362", 2188);
                yield return new Freedman("592", 19.9, "268", 1987);
                yield return new Freedman(null, 16.3, null, 2602);
                yield return new Freedman("398", 6.3, "245", 1339);
                yield return new Freedman("802", 5.4, "1085", 2390);
                yield return new Freedman("628", 64.3, "1053", 3283);
                yield return new Freedman("1867", 19.8, "297", 3511);
                yield return new Freedman(null, 3, null, 1413);
                yield return new Freedman("1062", 10.8, "345", 2798);
                yield return new Freedman("513", 23.4, "670", 4035);
                yield return new Freedman("615", 6.9, "13087", 2301);
                yield return new Freedman("270", 1.3, "151", 458);
                yield return new Freedman("1231", 10.9, "445", 3748);
                yield return new Freedman("399", 7.5, "281", 1597);
                yield return new Freedman("302", 1.3, "319", 627);
                yield return new Freedman("361", 2.8, "212", 2991);
                yield return new Freedman("323", 19.9, "217", 3420);
                yield return new Freedman("6860", 9.7, "1686", 4852);
                yield return new Freedman("802", 11.6, "883", 3758);
                yield return new Freedman("770", 38, "565", 2691);
                yield return new Freedman("1150", 14.9, "563", 4460);
                yield return new Freedman("1344", 5.3, "923", 1929);
                yield return new Freedman("1677", 1.8, "796", 3231);
                yield return new Freedman("382", 30.8, "135", 2433);
                yield return new Freedman("536", 18.4, "329", 3185);
                yield return new Freedman("726", 7.7, "1200", 2726);
                yield return new Freedman("1064", 30.9, "539", 3467);
                yield return new Freedman("11551", 12, "5408", 4732);
                yield return new Freedman("1881", 13.4, "2683", 3261);
                yield return new Freedman("653", 26.4, "963", 3160);
                yield return new Freedman("605", 9.4, "283", 2343);
                yield return new Freedman("525", 6, "342", 2663);
                yield return new Freedman("390", 16.6, "321", 2560);
                yield return new Freedman("1353", 3.8, "3170", 1922);
                yield return new Freedman("336", 3.3, "186", 2125);
                yield return new Freedman("4829", 15.7, "1359", 1753);
                yield return new Freedman("872", 5.5, "94", 3962);
                yield return new Freedman("2387", 6.8, "783", 2127);
                yield return new Freedman("957", 3, "262", 3627);
                yield return new Freedman("749", 1.9, "1221", 2903);
                yield return new Freedman("292", 1.8, "338", 1052);
                yield return new Freedman("515", 26.3, "430", 3183);
                yield return new Freedman("853", 4, "368", 1820);
                yield return new Freedman("765", 6.8, "222", 3793);
                yield return new Freedman("2327", 14.2, "565", 3302);
                yield return new Freedman("534", 1.4, "504", 2977);
                yield return new Freedman("850", 7.1, "434", 3459);
                yield return new Freedman("1086", 4.7, "40", 3743);
                yield return new Freedman("1221", 5.5, "286", 2587);
                yield return new Freedman("2999", 12.5, "1210", 5441);
                yield return new Freedman("985", 3.2, "758", 3000);
                yield return new Freedman("1340", 4.8, "317", 4329);
                yield return new Freedman("299", 34.1, "171", 1864);
                yield return new Freedman("275", 5.3, "302", 1973);
                yield return new Freedman("273", 2, "155", 2130);
                yield return new Freedman("554", 3.1, "481", 2467);
                yield return new Freedman("625", 2.6, "259", 1577);
                yield return new Freedman("401", 5.1, "239", 2843);
                yield return new Freedman("924", 11.5, "709", 3247);
                yield return new Freedman("678", 7.3, "446", 2050);
                yield return new Freedman(null, 12.9, null, 3098);
                yield return new Freedman(null, 6.3, null, 2705);
                yield return new Freedman("466", 9.2, "123", 2840);
                yield return new Freedman("350", 1.6, "132", 869);
                yield return new Freedman("2751", 24.5, "1170", 4019);
                yield return new Freedman("406", 5.8, "166", 2532);
                yield return new Freedman("340", 0.3, "383", 613);
                yield return new Freedman("488", 11.7, "419", 2393);
                yield return new Freedman("612", 0.9, "405", 2874);
                yield return new Freedman("316", 2, "220", 1062);
                yield return new Freedman("528", 9.2, "513", 1698);
            }
        }
    }
}
