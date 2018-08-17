// ReSharper disable All

namespace Rdatasets.cluster
{
    using System.Collections.Generic;

    /// <summary>
    /// Subset of C-horizon of Kola Data
    /// </summary>

    public class chorSub
    {
        public readonly int Al;
        public readonly int Ca;
        public readonly int Fe;
        public readonly int K;
        public readonly int Mg;
        public readonly int Mn;
        public readonly int Na;
        public readonly int P;
        public readonly int Si;
        public readonly int Ti;

        public chorSub(int Al, int Ca, int Fe, int K, int Mg, int Mn, int Na, int P, int Si, int Ti)
        {
            this.Al = Al;
            this.Ca = Ca;
            this.Fe = Fe;
            this.K = K;
            this.Mg = Mg;
            this.Mn = Mn;
            this.Na = Na;
            this.P = P;
            this.Si = Si;
            this.Ti = Ti;
        }

        public static IEnumerable<chorSub> Data
        {
            get
            {
                yield return new chorSub(101, 11, -22, -17, -34, -41, 27, -36, -58, -28);
                yield return new chorSub(50, 129, 23, -82, 47, 33, 61, 90, -24, 9);
                yield return new chorSub(5, 65, -22, -96, -33, 7, 47, 49, 30, -39);
                yield return new chorSub(-40, -16, -158, -70, -104, -114, 53, -61, 103, -160);
                yield return new chorSub(-13, 30, -82, -113, 26, -41, 65, -90, 43, -130);
                yield return new chorSub(-49, -43, 31, -74, -2, 33, -72, -36, 78, -51);
                yield return new chorSub(44, -109, -40, 118, -98, 33, -100, 103, 10, 9);
                yield return new chorSub(285, 183, 133, -6, 31, -15, 121, -49, -223, 115);
                yield return new chorSub(4, -83, -66, 24, -44, -66, -3, -90, 22, -47);
                yield return new chorSub(-48, 102, 105, -92, 146, 83, 30, -36, -61, 118);
                yield return new chorSub(-49, -178, 23, 79, -47, 106, -134, -20, 51, 58);
                yield return new chorSub(157, -173, 155, 100, 35, -15, -239, -61, -42, 77);
                yield return new chorSub(-53, -122, -58, 51, -64, -66, -63, -90, 69, -28);
                yield return new chorSub(79, -13, -44, 204, -92, 83, 115, 75, -73, 133);
                yield return new chorSub(-17, -112, -97, 83, -115, -92, 15, -36, 38, -103);
                yield return new chorSub(-126, -106, -37, 58, -101, 131, -97, 8, 92, 70);
                yield return new chorSub(-51, -85, 75, 0, -25, 7, -41, -36, -11, 70);
                yield return new chorSub(36, 35, -90, -87, -77, -66, 111, 8, 41, -96);
                yield return new chorSub(12, 211, 152, -106, 254, 83, -15, 62, -165, 58);
                yield return new chorSub(30, 27, -87, -65, -77, -66, 112, -7, 50, -100);
                yield return new chorSub(-93, 15, -101, 9, -43, -66, 65, -36, 88, -66);
                yield return new chorSub(78, -37, 162, 15, 121, 58, -122, -7, -78, 96);
                yield return new chorSub(35, 2, 60, 186, -75, 354, 148, 49, -118, 351);
                yield return new chorSub(-120, 45, 43, -133, 115, -15, 84, -36, 11, 51);
                yield return new chorSub(-30, -37, -34, -103, 4, -15, -31, -77, 60, -9);
                yield return new chorSub(29, 85, -65, -99, -44, -15, 62, -7, 32, -92);
                yield return new chorSub(-33, 62, 94, -49, 198, 7, 25, 49, -81, 55);
                yield return new chorSub(7, 45, -95, -28, -50, -66, 97, 21, 44, -88);
                yield return new chorSub(-19, -18, -68, 98, -74, -15, 89, -36, 6, -2);
                yield return new chorSub(-1, -90, 16, 26, 152, -15, 56, -20, -42, -24);
                yield return new chorSub(116, -169, 123, 88, 9, -41, -242, -61, -33, 100);
                yield return new chorSub(-53, -41, 69, -8, -16, 58, -25, -36, -14, 92);
                yield return new chorSub(-9, 3, -111, 32, -87, -66, 77, -61, 62, -115);
                yield return new chorSub(47, -31, 13, 248, -92, -41, 92, 406, -59, 96);
                yield return new chorSub(-87, -27, -108, -3, -95, -66, 31, -61, 115, -111);
                yield return new chorSub(73, 111, -35, -5, 41, -15, 99, 160, -64, -43);
                yield return new chorSub(-99, 14, -68, -30, 46, -66, 55, -61, 48, -107);
                yield return new chorSub(35, 108, 24, -50, 32, 7, 81, 103, -61, 9);
                yield return new chorSub(90, 113, -29, -65, 29, -15, 80, 8, -40, -47);
                yield return new chorSub(27, 34, 1, -35, -12, -15, 47, -61, -15, 21);
                yield return new chorSub(-77, -51, -200, -76, -155, -139, 94, -102, 169, -190);
                yield return new chorSub(14, -10, -185, -89, -132, -114, 187, -77, 116, -171);
                yield return new chorSub(-18, -51, -61, 110, -70, -92, 53, -7, 32, -43);
                yield return new chorSub(18, 52, -75, -12, -30, -41, 86, -36, 29, -92);
                yield return new chorSub(-69, -19, -97, 9, -75, -66, 49, -77, 116, -107);
                yield return new chorSub(-109, -11, -10, -40, 31, -41, -18, -90, 50, 28);
                yield return new chorSub(84, 60, -52, -52, -25, -41, 81, -36, -18, -62);
                yield return new chorSub(-5, 59, -82, -44, -52, -41, 84, -7, 62, -73);
                yield return new chorSub(-59, -91, -128, 142, -114, -114, 28, -20, 111, -81);
                yield return new chorSub(180, -168, 141, 135, 25, -41, -202, -61, -49, 47);
                yield return new chorSub(129, 123, 66, -57, 50, 33, 28, 185, -105, 58);
                yield return new chorSub(77, 86, -39, -57, -25, -41, 44, 90, 3, -51);
                yield return new chorSub(94, -88, 84, 86, 22, 7, -128, -36, -46, 43);
                yield return new chorSub(-21, 32, -53, -91, -52, -41, 47, -7, 55, -9);
                yield return new chorSub(-16, 4, -62, 32, -49, -41, 75, 8, 48, -36);
                yield return new chorSub(-42, 143, 100, -79, 161, 106, 30, -7, -128, 220);
                yield return new chorSub(13, 116, 148, -114, 97, 106, -12, 8, -93, 17);
                yield return new chorSub(-166, -126, -57, 58, -93, -66, -109, -36, 80, -28);
                yield return new chorSub(-201, -59, -47, -74, -22, -66, -3, -77, 99, -24);
                yield return new chorSub(49, 30, 48, -67, 35, 7, -52, 34, -31, 39);
                yield return new chorSub(-192, -97, -117, 15, -108, -92, -27, -36, 177, -36);
            }
        }
    }
}
