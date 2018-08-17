// ReSharper disable All

namespace Rdatasets.psych
{
    using System.Collections.Generic;

    /// <summary>
    /// Distances between 11 US cities
    /// </summary>

    public class cities
    {
        public readonly int ATL;
        public readonly int BOS;
        public readonly int ORD;
        public readonly int DCA;
        public readonly int DEN;
        public readonly int LAX;
        public readonly int MIA;
        public readonly int JFK;
        public readonly int SEA;
        public readonly int SFO;
        public readonly int MSY;

        public cities(int ATL, int BOS, int ORD, int DCA, int DEN, int LAX, int MIA, int JFK, int SEA, int SFO, int MSY)
        {
            this.ATL = ATL;
            this.BOS = BOS;
            this.ORD = ORD;
            this.DCA = DCA;
            this.DEN = DEN;
            this.LAX = LAX;
            this.MIA = MIA;
            this.JFK = JFK;
            this.SEA = SEA;
            this.SFO = SFO;
            this.MSY = MSY;
        }

        public static IEnumerable<cities> Data
        {
            get
            {
                yield return new cities(0, 934, 585, 542, 1209, 1942, 605, 751, 2181, 2139, 424);
                yield return new cities(934, 0, 853, 392, 1769, 2601, 1252, 183, 2492, 2700, 1356);
                yield return new cities(585, 853, 0, 598, 918, 1748, 1187, 720, 1736, 1857, 830);
                yield return new cities(542, 392, 598, 0, 1493, 2305, 922, 209, 2328, 2442, 964);
                yield return new cities(1209, 1769, 918, 1493, 0, 836, 1723, 1636, 1023, 951, 1079);
                yield return new cities(1942, 2601, 1748, 2305, 836, 0, 2345, 2461, 957, 341, 1679);
                yield return new cities(605, 1252, 1187, 922, 1723, 2345, 0, 1092, 2733, 2594, 669);
                yield return new cities(751, 183, 720, 209, 1636, 2461, 1092, 0, 2412, 2577, 1173);
                yield return new cities(2181, 2492, 1736, 2328, 1023, 957, 2733, 2412, 0, 681, 2101);
                yield return new cities(2139, 2700, 1857, 2442, 951, 341, 2594, 2577, 681, 0, 1925);
                yield return new cities(424, 1356, 830, 964, 1079, 1679, 669, 1173, 2101, 1925, 0);
            }
        }
    }
}
