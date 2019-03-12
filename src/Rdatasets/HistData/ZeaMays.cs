// ReSharper disable All

namespace Rdatasets.HistData
{
    using System.Collections.Generic;

    /// <summary>
    /// Darwin's Heights of Cross- and Self-fertilized Zea May Pairs
    /// </summary>

    public class ZeaMays
    {
        public readonly int κ;
        public readonly int pair;
        public readonly int pot;
        public readonly double cross;
        public readonly double self;
        public readonly double diff;

        public ZeaMays(int κ, int pair, int pot, double cross, double self, double diff)
        {
            this.κ = κ;
            this.pair = pair;
            this.pot = pot;
            this.cross = cross;
            this.self = self;
            this.diff = diff;
        }

        public static IEnumerable<ZeaMays> Data
        {
            get
            {
                yield return new ZeaMays(1, 1, 1, 23.5, 17.375, 6.125);
                yield return new ZeaMays(2, 2, 1, 12, 20.375, -8.375);
                yield return new ZeaMays(3, 3, 1, 21, 20, 1);
                yield return new ZeaMays(4, 4, 2, 22, 20, 2);
                yield return new ZeaMays(5, 5, 2, 19.125, 18.375, 0.75);
                yield return new ZeaMays(6, 6, 2, 21.5, 18.625, 2.875);
                yield return new ZeaMays(7, 7, 3, 22.125, 18.625, 3.5);
                yield return new ZeaMays(8, 8, 3, 20.375, 15.25, 5.125);
                yield return new ZeaMays(9, 9, 3, 18.25, 16.5, 1.75);
                yield return new ZeaMays(10, 10, 3, 21.625, 18, 3.625);
                yield return new ZeaMays(11, 11, 3, 23.25, 16.25, 7);
                yield return new ZeaMays(12, 12, 4, 21, 18, 3);
                yield return new ZeaMays(13, 13, 4, 22.125, 12.75, 9.375);
                yield return new ZeaMays(14, 14, 4, 23, 15.5, 7.5);
                yield return new ZeaMays(15, 15, 4, 12, 18, -6);
            }
        }
    }
}
