// ReSharper disable All

namespace Rdatasets.DAAG
{
    using System.Collections.Generic;

    /// <summary>
    /// Population figures for Australian States and Territories
    /// </summary>

    public class austpop
    {
        public readonly int year;
        public readonly int NSW;
        public readonly int Vic;
        public readonly int Qld;
        public readonly int SA;
        public readonly int WA;
        public readonly int Tas;
        public readonly int NT;
        public readonly int ACT;
        public readonly int Aust;

        public austpop(int year, int NSW, int Vic, int Qld, int SA, int WA, int Tas, int NT, int ACT, int Aust)
        {
            this.year = year;
            this.NSW = NSW;
            this.Vic = Vic;
            this.Qld = Qld;
            this.SA = SA;
            this.WA = WA;
            this.Tas = Tas;
            this.NT = NT;
            this.ACT = ACT;
            this.Aust = Aust;
        }

        public static IEnumerable<austpop> Data
        {
            get
            {
                yield return new austpop(1917, 1904, 1409, 683, 440, 306, 193, 5, 3, 4941);
                yield return new austpop(1927, 2402, 1727, 873, 565, 392, 211, 4, 8, 6182);
                yield return new austpop(1937, 2693, 1853, 993, 589, 457, 233, 6, 11, 6836);
                yield return new austpop(1947, 2985, 2055, 1106, 646, 502, 257, 11, 17, 7579);
                yield return new austpop(1957, 3625, 2656, 1413, 873, 688, 326, 21, 38, 9640);
                yield return new austpop(1967, 4295, 3274, 1700, 1110, 879, 375, 62, 103, 11799);
                yield return new austpop(1977, 5002, 3837, 2130, 1286, 1204, 415, 104, 214, 14192);
                yield return new austpop(1987, 5617, 4210, 2675, 1393, 1496, 449, 158, 265, 16264);
                yield return new austpop(1997, 6274, 4605, 3401, 1480, 1798, 474, 187, 310, 18532);
            }
        }
    }
}
