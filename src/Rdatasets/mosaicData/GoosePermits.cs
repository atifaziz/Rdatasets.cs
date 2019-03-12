// ReSharper disable All

namespace Rdatasets.mosaicData
{
    using System.Collections.Generic;

    /// <summary>
    /// Goose Permit Study
    /// </summary>

    public class GoosePermits
    {
        public readonly int κ;
        public readonly int bid;
        public readonly int keep;
        public readonly int sell;

        public GoosePermits(int κ, int bid, int keep, int sell)
        {
            this.κ = κ;
            this.bid = bid;
            this.keep = keep;
            this.sell = sell;
        }

        public static IEnumerable<GoosePermits> Data
        {
            get
            {
                yield return new GoosePermits(1, 1, 31, 0);
                yield return new GoosePermits(2, 5, 29, 3);
                yield return new GoosePermits(3, 10, 27, 6);
                yield return new GoosePermits(4, 20, 25, 7);
                yield return new GoosePermits(5, 30, 23, 9);
                yield return new GoosePermits(6, 40, 21, 13);
                yield return new GoosePermits(7, 50, 19, 17);
                yield return new GoosePermits(8, 75, 17, 12);
                yield return new GoosePermits(9, 100, 15, 11);
                yield return new GoosePermits(10, 150, 15, 14);
                yield return new GoosePermits(11, 200, 15, 13);
            }
        }
    }
}
