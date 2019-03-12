// ReSharper disable All

namespace Rdatasets.DAAG
{
    using System.Collections.Generic;

    /// <summary>
    /// Averages by block of corn yields, for treatment 111 only
    /// </summary>

    public class ant111b
    {
        public readonly int κ;
        public readonly string site;
        public readonly string parcel;
        public readonly int code;
        public readonly int island;
        public readonly double id;
        public readonly double plot;
        public readonly int trt;
        public readonly double ears;
        public readonly double harvwt;

        public ant111b(int κ, string site, string parcel, int code, int island, double id, double plot, int trt, double ears, double harvwt)
        {
            this.κ = κ;
            this.site = site;
            this.parcel = parcel;
            this.code = code;
            this.island = island;
            this.id = id;
            this.plot = plot;
            this.trt = trt;
            this.ears = ears;
            this.harvwt = harvwt;
        }

        public static IEnumerable<ant111b> Data
        {
            get
            {
                yield return new ant111b(1, "DBAN", "I", 58, 1, 3, 3, 111, 43.5, 5.16);
                yield return new ant111b(2, "LFAN", "I", 58, 1, 40, 4, 111, 40.5, 2.93);
                yield return new ant111b(3, "NSAN", "I", 58, 1, 185.5, 5.5, 111, 20, 1.73);
                yield return new ant111b(4, "ORAN", "I", 58, 1, 256.5, 4.5, 111, 42.5, 6.79);
                yield return new ant111b(5, "OVAN", "I", 58, 1, 219.5, 3.5, 111, 31.5, 3.255);
                yield return new ant111b(6, "TEAN", "I", 58, 1, 77, 5, 111, 32.5, 2.65);
                yield return new ant111b(7, "WEAN", "I", 58, 1, 115, 7, 111, 43.5, 5.04);
                yield return new ant111b(8, "WLAN", "I", 58, 1, 151, 7, 111, 50, 2.02);
                yield return new ant111b(9, "DBAN", "II", 58, 1, 15.5, 15.5, 111, 46, 4.805);
                yield return new ant111b(10, "LFAN", "II", 58, 1, 51, 15, 111, 46.5, 4.77);
                yield return new ant111b(11, "NSAN", "II", 58, 1, 193.5, 13.5, 111, 34, 3.17);
                yield return new ant111b(12, "ORAN", "II", 58, 1, 268, 16, 111, 44, 7.365);
                yield return new ant111b(13, "OVAN", "II", 58, 1, 229.5, 13.5, 111, 39, 4.275);
                yield return new ant111b(14, "TEAN", "II", 58, 1, 88.5, 16.5, 111, 41.5, 3.19);
                yield return new ant111b(15, "WEAN", "II", 58, 1, 119.5, 11.5, 111, 43.5, 4.6);
                yield return new ant111b(16, "WLAN", "II", 58, 1, 158, 14, 111, 56, 2.665);
                yield return new ant111b(17, "DBAN", "III", 58, 1, 22.5, 22.5, 111, 47, 5.065);
                yield return new ant111b(18, "LFAN", "III", 58, 1, 60, 24, 111, 42.5, 4.33);
                yield return new ant111b(19, "NSAN", "III", 58, 1, 205, 25, 111, 27, 1.49);
                yield return new ant111b(20, "ORAN", "III", 58, 1, 275, 23, 111, 41.5, 6.435);
                yield return new ant111b(21, "OVAN", "III", 58, 1, 238, 22, 111, 41, 5.565);
                yield return new ant111b(22, "TEAN", "III", 58, 1, 93, 21, 111, 36, 2.79);
                yield return new ant111b(23, "WEAN", "III", 58, 1, 129.5, 21.5, 111, 45.5, 6.34);
                yield return new ant111b(24, "WLAN", "III", 58, 1, 166, 22, 111, 50.5, 3.16);
                yield return new ant111b(25, "DBAN", "IV", 58, 1, 29, 29, 111, 41, 4.51);
                yield return new ant111b(26, "LFAN", "IV", 58, 1, 67.5, 31.5, 111, 43.5, 4.8);
                yield return new ant111b(27, "NSAN", "IV", 58, 1, 212.5, 32.5, 111, 25, 1.97);
                yield return new ant111b(28, "ORAN", "IV", 58, 1, 283.5, 31.5, 111, 45, 7.07);
                yield return new ant111b(29, "OVAN", "IV", 58, 1, 249, 33, 111, 46.5, 6.235);
                yield return new ant111b(30, "TEAN", "IV", 58, 1, 103.5, 31.5, 111, 41, 3.515);
                yield return new ant111b(31, "WEAN", "IV", 58, 1, 140.5, 32.5, 111, 46, 6.125);
                yield return new ant111b(32, "WLAN", "IV", 58, 1, 177.5, 33.5, 111, 45.5, 3.52);
            }
        }
    }
}
