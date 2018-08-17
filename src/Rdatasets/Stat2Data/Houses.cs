// ReSharper disable All

namespace Rdatasets.Stat2Data
{
    using System.Collections.Generic;

    /// <summary>
    /// Houses
    /// </summary>

    public class Houses
    {
        public readonly int Price;
        public readonly int Size;
        public readonly int Lot;

        public Houses(int Price, int Size, int Lot)
        {
            this.Price = Price;
            this.Size = Size;
            this.Lot = Lot;
        }

        public static IEnumerable<Houses> Data
        {
            get
            {
                yield return new Houses(212000, 4148, 25264);
                yield return new Houses(230000, 2501, 11891);
                yield return new Houses(339000, 4374, 25351);
                yield return new Houses(289000, 2398, 22215);
                yield return new Houses(160000, 2536, 9234);
                yield return new Houses(85000, 2368, 13329);
                yield return new Houses(85000, 1264, 8407);
                yield return new Houses(145000, 1572, 12588);
                yield return new Houses(164000, 2375, 16204);
                yield return new Houses(123500, 1161, 9626);
                yield return new Houses(180000, 1542, 8755);
                yield return new Houses(159500, 1464, 14636);
                yield return new Houses(156000, 2240, 21780);
                yield return new Houses(146500, 1269, 11250);
                yield return new Houses(101500, 924, 7361);
                yield return new Houses(109800, 768, 10497);
                yield return new Houses(182000, 1320, 15768);
                yield return new Houses(110000, 1845, 12153);
                yield return new Houses(125000, 1274, 13634);
                yield return new Houses(80000, 1905, 10890);
            }
        }
    }
}
