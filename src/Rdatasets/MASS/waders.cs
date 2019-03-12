// ReSharper disable All

namespace Rdatasets.MASS
{
    using System.Collections.Generic;

    /// <summary>
    /// Counts of Waders at 15 Sites in South Africa
    /// </summary>

    public class waders
    {
        public readonly string κ;
        public readonly int S1;
        public readonly int S2;
        public readonly int S3;
        public readonly int S4;
        public readonly int S5;
        public readonly int S6;
        public readonly int S7;
        public readonly int S8;
        public readonly int S9;
        public readonly int S10;
        public readonly int S11;
        public readonly int S12;
        public readonly int S13;
        public readonly int S14;
        public readonly int S15;
        public readonly int S16;
        public readonly int S17;
        public readonly int S18;
        public readonly int S19;

        public waders(string κ, int S1, int S2, int S3, int S4, int S5, int S6, int S7, int S8, int S9, int S10, int S11, int S12, int S13, int S14, int S15, int S16, int S17, int S18, int S19)
        {
            this.κ = κ;
            this.S1 = S1;
            this.S2 = S2;
            this.S3 = S3;
            this.S4 = S4;
            this.S5 = S5;
            this.S6 = S6;
            this.S7 = S7;
            this.S8 = S8;
            this.S9 = S9;
            this.S10 = S10;
            this.S11 = S11;
            this.S12 = S12;
            this.S13 = S13;
            this.S14 = S14;
            this.S15 = S15;
            this.S16 = S16;
            this.S17 = S17;
            this.S18 = S18;
            this.S19 = S19;
        }

        public static IEnumerable<waders> Data
        {
            get
            {
                yield return new waders("A", 12, 2027, 0, 0, 2070, 39, 219, 153, 0, 15, 51, 8336, 2031, 14941, 19, 3566, 0, 5, 0);
                yield return new waders("B", 99, 2112, 9, 87, 3481, 470, 2063, 28, 17, 145, 31, 1515, 1917, 17321, 3378, 20164, 177, 1759, 53);
                yield return new waders("C", 197, 160, 0, 4, 126, 17, 1, 32, 0, 2, 9, 477, 1, 548, 13, 273, 0, 0, 0);
                yield return new waders("D", 0, 17, 0, 3, 50, 6, 4, 7, 0, 1, 2, 16, 0, 0, 3, 69, 1, 0, 0);
                yield return new waders("E", 77, 1948, 0, 19, 310, 1, 1, 64, 0, 22, 81, 2792, 221, 7422, 10, 4519, 12, 0, 0);
                yield return new waders("F", 19, 203, 48, 45, 20, 433, 0, 0, 11, 167, 12, 1, 0, 26, 1790, 2916, 473, 658, 55);
                yield return new waders("G", 1023, 2655, 0, 18, 320, 49, 8, 121, 9, 82, 48, 3411, 14, 9101, 43, 3230, 587, 10, 5);
                yield return new waders("H", 87, 745, 1447, 125, 4330, 789, 228, 529, 289, 904, 34, 1710, 7869, 2247, 4558, 40880, 7166, 1632, 498);
                yield return new waders("I", 788, 2174, 0, 19, 224, 178, 1, 423, 0, 195, 162, 2161, 25, 1784, 3, 1254, 0, 0, 0);
                yield return new waders("J", 82, 350, 760, 197, 858, 962, 10, 511, 251, 987, 191, 34, 87, 417, 4496, 15835, 5327, 1312, 1020);
                yield return new waders("K", 474, 930, 0, 10, 316, 161, 0, 90, 0, 39, 48, 1183, 166, 4626, 65, 127, 4, 0, 0);
                yield return new waders("L", 77, 249, 160, 136, 999, 645, 15, 851, 101, 723, 266, 495, 83, 1253, 1864, 4107, 1939, 623, 527);
                yield return new waders("M", 22, 144, 0, 4, 1, 1, 0, 10, 0, 2, 9, 125, 5, 411, 0, 3, 0, 0, 0);
                yield return new waders("N", 0, 791, 0, 0, 4, 38, 1, 56, 1, 30, 54, 95, 0, 1726, 0, 0, 0, 0, 0);
                yield return new waders("O", 0, 360, 128, 43, 364, 1628, 63, 287, 328, 641, 850, 83, 67, 48, 6499, 9094, 5647, 1333, 582);
            }
        }
    }
}
