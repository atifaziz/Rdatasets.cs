// ReSharper disable All

namespace Rdatasets.vcd
{
    using System.Collections.Generic;

    /// <summary>
    /// UK Soccer Scores
    /// </summary>

    public class UKSoccer
    {
        public readonly int κ;
        public readonly int Home;
        public readonly int Away;
        public readonly int Freq;

        public UKSoccer(int κ, int Home, int Away, int Freq)
        {
            this.κ = κ;
            this.Home = Home;
            this.Away = Away;
            this.Freq = Freq;
        }

        public static IEnumerable<UKSoccer> Data
        {
            get
            {
                yield return new UKSoccer(1, 0, 0, 27);
                yield return new UKSoccer(2, 1, 0, 59);
                yield return new UKSoccer(3, 2, 0, 28);
                yield return new UKSoccer(4, 3, 0, 19);
                yield return new UKSoccer(5, 4, 0, 7);
                yield return new UKSoccer(6, 0, 1, 29);
                yield return new UKSoccer(7, 1, 1, 53);
                yield return new UKSoccer(8, 2, 1, 32);
                yield return new UKSoccer(9, 3, 1, 14);
                yield return new UKSoccer(10, 4, 1, 8);
                yield return new UKSoccer(11, 0, 2, 10);
                yield return new UKSoccer(12, 1, 2, 14);
                yield return new UKSoccer(13, 2, 2, 14);
                yield return new UKSoccer(14, 3, 2, 7);
                yield return new UKSoccer(15, 4, 2, 10);
                yield return new UKSoccer(16, 0, 3, 8);
                yield return new UKSoccer(17, 1, 3, 12);
                yield return new UKSoccer(18, 2, 3, 12);
                yield return new UKSoccer(19, 3, 3, 4);
                yield return new UKSoccer(20, 4, 3, 2);
                yield return new UKSoccer(21, 0, 4, 2);
                yield return new UKSoccer(22, 1, 4, 4);
                yield return new UKSoccer(23, 2, 4, 4);
                yield return new UKSoccer(24, 3, 4, 1);
                yield return new UKSoccer(25, 4, 4, 0);
            }
        }
    }
}
