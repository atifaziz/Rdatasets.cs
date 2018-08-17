// ReSharper disable All

namespace Rdatasets.vcd
{
    using System.Collections.Generic;

    /// <summary>
    /// UK Soccer Scores
    /// </summary>

    public class UKSoccer
    {
        public readonly int Home;
        public readonly int Away;
        public readonly int Freq;

        public UKSoccer(int Home, int Away, int Freq)
        {
            this.Home = Home;
            this.Away = Away;
            this.Freq = Freq;
        }

        public static IEnumerable<UKSoccer> Data
        {
            get
            {
                yield return new UKSoccer(0, 0, 27);
                yield return new UKSoccer(1, 0, 59);
                yield return new UKSoccer(2, 0, 28);
                yield return new UKSoccer(3, 0, 19);
                yield return new UKSoccer(4, 0, 7);
                yield return new UKSoccer(0, 1, 29);
                yield return new UKSoccer(1, 1, 53);
                yield return new UKSoccer(2, 1, 32);
                yield return new UKSoccer(3, 1, 14);
                yield return new UKSoccer(4, 1, 8);
                yield return new UKSoccer(0, 2, 10);
                yield return new UKSoccer(1, 2, 14);
                yield return new UKSoccer(2, 2, 14);
                yield return new UKSoccer(3, 2, 7);
                yield return new UKSoccer(4, 2, 10);
                yield return new UKSoccer(0, 3, 8);
                yield return new UKSoccer(1, 3, 12);
                yield return new UKSoccer(2, 3, 12);
                yield return new UKSoccer(3, 3, 4);
                yield return new UKSoccer(4, 3, 2);
                yield return new UKSoccer(0, 4, 2);
                yield return new UKSoccer(1, 4, 4);
                yield return new UKSoccer(2, 4, 4);
                yield return new UKSoccer(3, 4, 1);
                yield return new UKSoccer(4, 4, 0);
            }
        }
    }
}
