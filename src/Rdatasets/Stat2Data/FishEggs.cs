// ReSharper disable All

namespace Rdatasets.Stat2Data
{
    using System.Collections.Generic;

    /// <summary>
    /// FishEggs
    /// </summary>

    public class FishEggs
    {
        public readonly int Age;
        public readonly double PctDM;
        public readonly string Month;
        public readonly int Sept;

        public FishEggs(int Age, double PctDM, string Month, int Sept)
        {
            this.Age = Age;
            this.PctDM = PctDM;
            this.Month = Month;
            this.Sept = Sept;
        }

        public static IEnumerable<FishEggs> Data
        {
            get
            {
                yield return new FishEggs(7, 37.35, "Nov", 0);
                yield return new FishEggs(8, 38.05, "Nov", 0);
                yield return new FishEggs(8, 37.45, "Nov", 0);
                yield return new FishEggs(9, 38.95, "Nov", 0);
                yield return new FishEggs(9, 37.9, "Nov", 0);
                yield return new FishEggs(9, 36.45, "Nov", 0);
                yield return new FishEggs(9, 36.15, "Nov", 0);
                yield return new FishEggs(10, 38.35, "Nov", 0);
                yield return new FishEggs(10, 37.15, "Nov", 0);
                yield return new FishEggs(11, 36.5, "Nov", 0);
                yield return new FishEggs(11, 35.1, "Nov", 0);
                yield return new FishEggs(12, 37.7, "Nov", 0);
                yield return new FishEggs(12, 37.1, "Nov", 0);
                yield return new FishEggs(13, 37.4, "Nov", 0);
                yield return new FishEggs(13, 37.55, "Nov", 0);
                yield return new FishEggs(13, 36.35, "Nov", 0);
                yield return new FishEggs(14, 36.75, "Nov", 0);
                yield return new FishEggs(15, 37.05, "Nov", 0);
                yield return new FishEggs(16, 32.95, "Nov", 0);
                yield return new FishEggs(17, 36.15, "Nov", 0);
                yield return new FishEggs(18, 35.7, "Nov", 0);
                yield return new FishEggs(7, 34.9, "Sep", 1);
                yield return new FishEggs(7, 37, "Sep", 1);
                yield return new FishEggs(7, 37.9, "Sep", 1);
                yield return new FishEggs(7, 38.15, "Sep", 1);
                yield return new FishEggs(9, 33.9, "Sep", 1);
                yield return new FishEggs(9, 36.45, "Sep", 1);
                yield return new FishEggs(11, 35, "Sep", 1);
                yield return new FishEggs(11, 36.15, "Sep", 1);
                yield return new FishEggs(12, 34.05, "Sep", 1);
                yield return new FishEggs(12, 34.65, "Sep", 1);
                yield return new FishEggs(12, 35.4, "Sep", 1);
                yield return new FishEggs(16, 32.45, "Sep", 1);
                yield return new FishEggs(17, 36.55, "Sep", 1);
                yield return new FishEggs(18, 34, "Sep", 1);
            }
        }
    }
}
