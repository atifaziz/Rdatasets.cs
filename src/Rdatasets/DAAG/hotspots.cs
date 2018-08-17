// ReSharper disable All

namespace Rdatasets.DAAG
{
    using System.Collections.Generic;

    /// <summary>
    /// Hawaian island chain hotspot Potassium-Argon ages
    /// </summary>

    public class hotspots
    {
        public readonly string ID;
        public readonly string name;
        public readonly int distance;
        public readonly double age;
        public readonly double error;
        public readonly string source;

        public hotspots(string ID, string name, int distance, double age, double error, string source)
        {
            this.ID = ID;
            this.name = name;
            this.distance = distance;
            this.age = age;
            this.error = error;
            this.source = source;
        }

        public static IEnumerable<hotspots> Data
        {
            get
            {
                yield return new hotspots("3", "Mauna Kea", 54, 0.375, 0.05, "1");
                yield return new hotspots("5", "Kohala", 100, 0.43, 0.02, "2");
                yield return new hotspots("6", "Haleakala", 182, 0.75, 0.04, "3");
                yield return new hotspots("8", "West Maui", 221, 1.32, 0.04, "4");
                yield return new hotspots("9", "Lanai", 226, 1.28, 0.04, "5");
                yield return new hotspots("10", "East Molokai", 256, 1.76, 0.04, "3");
                yield return new hotspots("11", "West Molokai", 280, 1.9, 0.06, "3");
                yield return new hotspots("12", "Koolau", 339, 2.6, 0.1, "4,6");
                yield return new hotspots("13", "Waianae", 374, 3.7, 0.1, "6");
                yield return new hotspots("14", "Kauai", 519, 5.1, 0.2, "7");
                yield return new hotspots("15", "Niihau", 565, 4.89, 0.11, "8");
                yield return new hotspots("15A", "Kaula", 600, 4, 0.2, "21");
                yield return new hotspots("17", "Nihoa", 780, 7.2, 0.3, "9");
                yield return new hotspots("20", "Unnamed", 921, 9.4, 0.8, "20,22");
                yield return new hotspots("23", "Necker", 1058, 10.3, 0.4, "9");
                yield return new hotspots("26", "La Perouse Pinnacles", 1209, 12, 0.4, "9");
                yield return new hotspots("27", "Brooks Bank", 1278, 13, 0.6, "20,22");
                yield return new hotspots("30", "Gardner Pinnacles", 1447, 12.3, 1, "20,22");
                yield return new hotspots("36", "Laysan", 1818, 19.9, 0.3, "10");
                yield return new hotspots("37", "Northampton Bank", 1841, 26.6, 2.7, "10");
                yield return new hotspots("50", "Pearl and Hermes Reef", 2281, 20.6, 2.7, "11");
                yield return new hotspots("52", "Midway", 2432, 27.7, 0.6, "12");
                yield return new hotspots("57", "Unnamed", 2600, 28, 0.4, "11");
                yield return new hotspots("63", "Unnamed", 2825, 27.4, 0.5, "11");
                yield return new hotspots("65", "Colohan", 3128, 38.6, 0.3, "13");
                yield return new hotspots("65A", "Abbott", 3280, 38.7, 0.9, "13");
                yield return new hotspots("67", "Daikakuji", 3493, 42.4, 2.3, "14");
                yield return new hotspots("69", "Yuryaku", 3520, 43.4, 1.6, "11");
                yield return new hotspots("72", "Kimmei", 3668, 39.9, 1.2, "14");
                yield return new hotspots("74", "Koko (southern)", 3758, 48.1, 0.8, "14,15");
                yield return new hotspots("81", "Ojin", 4102, 55.2, 0.7, "16");
                yield return new hotspots("83", "Jingu", 4175, 55.4, 0.9, "17");
                yield return new hotspots("86", "Nintoku", 4452, 56.2, 0.6, "16");
                yield return new hotspots("90", "Suiko (southern)", 4794, 59.6, 0.6, "18,19");
                yield return new hotspots("91", "Suiko (central)", 4860, 64.7, 1.1, "16");
            }
        }
    }
}
