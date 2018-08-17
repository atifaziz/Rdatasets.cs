// ReSharper disable All

namespace Rdatasets.mosaicData
{
    using System.Collections.Generic;

    /// <summary>
    /// Goose Permit Study
    /// </summary>

    public class GoosePermits
    {
        public readonly int bid;
        public readonly int keep;
        public readonly int sell;

        public GoosePermits(int bid, int keep, int sell)
        {
            this.bid = bid;
            this.keep = keep;
            this.sell = sell;
        }

        public static IEnumerable<GoosePermits> Data
        {
            get
            {
                yield return new GoosePermits(1, 31, 0);
                yield return new GoosePermits(5, 29, 3);
                yield return new GoosePermits(10, 27, 6);
                yield return new GoosePermits(20, 25, 7);
                yield return new GoosePermits(30, 23, 9);
                yield return new GoosePermits(40, 21, 13);
                yield return new GoosePermits(50, 19, 17);
                yield return new GoosePermits(75, 17, 12);
                yield return new GoosePermits(100, 15, 11);
                yield return new GoosePermits(150, 15, 14);
                yield return new GoosePermits(200, 15, 13);
            }
        }
    }
}
