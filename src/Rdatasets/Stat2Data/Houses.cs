// ReSharper disable All

namespace Rdatasets.Stat2Data
{
    using System.Collections.Generic;

    /// <summary>
    /// Houses
    /// </summary>

    public class Houses
    {
        public readonly int κ;
        public readonly int Price;
        public readonly int Size;
        public readonly int Lot;

        public Houses(int κ, int Price, int Size, int Lot)
        {
            this.κ = κ;
            this.Price = Price;
            this.Size = Size;
            this.Lot = Lot;
        }

        public static IEnumerable<Houses> Data
        {
            get
            {
                yield return new Houses(1, 212000, 4148, 25264);
                yield return new Houses(2, 230000, 2501, 11891);
                yield return new Houses(3, 339000, 4374, 25351);
                yield return new Houses(4, 289000, 2398, 22215);
                yield return new Houses(5, 160000, 2536, 9234);
                yield return new Houses(6, 85000, 2368, 13329);
                yield return new Houses(7, 85000, 1264, 8407);
                yield return new Houses(8, 145000, 1572, 12588);
                yield return new Houses(9, 164000, 2375, 16204);
                yield return new Houses(10, 123500, 1161, 9626);
                yield return new Houses(11, 180000, 1542, 8755);
                yield return new Houses(12, 159500, 1464, 14636);
                yield return new Houses(13, 156000, 2240, 21780);
                yield return new Houses(14, 146500, 1269, 11250);
                yield return new Houses(15, 101500, 924, 7361);
                yield return new Houses(16, 109800, 768, 10497);
                yield return new Houses(17, 182000, 1320, 15768);
                yield return new Houses(18, 110000, 1845, 12153);
                yield return new Houses(19, 125000, 1274, 13634);
                yield return new Houses(20, 80000, 1905, 10890);
            }
        }
    }
}
