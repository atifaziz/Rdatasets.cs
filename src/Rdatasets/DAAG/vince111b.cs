// ReSharper disable All

namespace Rdatasets.DAAG
{
    using System.Collections.Generic;

    /// <summary>
    /// Averages by block of corn yields, for treatment 111 only
    /// </summary>

    public class vince111b
    {
        public readonly int κ;
        public readonly string site;
        public readonly int parcel;
        public readonly int code;
        public readonly int island;
        public readonly double id;
        public readonly double plot;
        public readonly int trt;
        public readonly double harvwt;

        public vince111b(int κ, string site, int parcel, int code, int island, double id, double plot, int trt, double harvwt)
        {
            this.κ = κ;
            this.site = site;
            this.parcel = parcel;
            this.code = code;
            this.island = island;
            this.id = id;
            this.plot = plot;
            this.trt = trt;
            this.harvwt = harvwt;
        }

        public static IEnumerable<vince111b> Data
        {
            get
            {
                yield return new vince111b(1, "AGSV", 1, 58, 2, 79, 7, 111, 13.05);
                yield return new vince111b(2, "CASV", 1, 58, 2, 113, 5, 111, 21.2);
                yield return new vince111b(3, "CPSV", 1, 58, 2, 5, 5, 111, 26.3);
                yield return new vince111b(4, "LPSV", 1, 58, 2, 292.5, 4.5, 111, 7.45);
                yield return new vince111b(5, "MPSV", 1, 58, 2, 39.5, 3.5, 111, 14.65);
                yield return new vince111b(6, "OOSV", 1, 58, 2, 219, 3, 111, 18);
                yield return new vince111b(7, "OTSV", 1, 58, 2, 257.5, 5.5, 111, 19.75);
                yield return new vince111b(8, "SSSV", 1, 58, 2, 151.5, 7.5, 111, 12.3);
                yield return new vince111b(9, "UISV", 1, 58, 2, 186.5, 6.5, 111, 21.6);
                yield return new vince111b(10, "AGSV", 2, 58, 2, 87.5, 15.5, 111, 14.15);
                yield return new vince111b(11, "CASV", 2, 58, 2, 122, 14, 111, 24.15);
                yield return new vince111b(12, "CPSV", 2, 58, 2, 11, 11, 111, 25.1);
                yield return new vince111b(13, "LPSV", 2, 58, 2, 300, 12, 111, 5.85);
                yield return new vince111b(14, "MPSV", 2, 58, 2, 51, 15, 111, 12.65);
                yield return new vince111b(15, "OOSV", 2, 58, 2, 230, 14, 111, 15.05);
                yield return new vince111b(16, "OTSV", 2, 58, 2, 267.5, 15.5, 111, 23.45);
                yield return new vince111b(17, "SSSV", 2, 58, 2, 155.5, 11.5, 111, 13.65);
                yield return new vince111b(18, "UISV", 2, 58, 2, 193, 13, 111, 19.75);
                yield return new vince111b(19, "AGSV", 3, 58, 2, 95, 23, 111, 13);
                yield return new vince111b(20, "CASV", 3, 58, 2, 132.5, 24.5, 111, 18.85);
                yield return new vince111b(21, "CPSV", 3, 58, 2, 20.5, 20.5, 111, 22.55);
                yield return new vince111b(22, "LPSV", 3, 58, 2, 310, 22, 111, 12.65);
                yield return new vince111b(23, "MPSV", 3, 58, 2, 62, 26, 111, 13.15);
                yield return new vince111b(24, "OOSV", 3, 58, 2, 240, 24, 111, 16.05);
                yield return new vince111b(25, "OTSV", 3, 58, 2, 275, 23, 111, 12.45);
                yield return new vince111b(26, "SSSV", 3, 58, 2, 168.5, 24.5, 111, 11.2);
                yield return new vince111b(27, "UISV", 3, 58, 2, 203.5, 23.5, 111, 23.15);
                yield return new vince111b(28, "AGSV", 4, 58, 2, 103.5, 31.5, 111, 12.7);
                yield return new vince111b(29, "CASV", 4, 58, 2, 137.5, 29.5, 111, 23.2);
                yield return new vince111b(30, "CPSV", 4, 58, 2, 33, 33, 111, 22.3);
                yield return new vince111b(31, "LPSV", 4, 58, 2, 317.5, 29.5, 111, 16.2);
                yield return new vince111b(32, "MPSV", 4, 58, 2, 69.5, 33.5, 111, 13.65);
                yield return new vince111b(33, "OOSV", 4, 58, 2, 250.5, 34.5, 111, 17.2);
                yield return new vince111b(34, "OTSV", 4, 58, 2, 287.5, 35.5, 111, 12.55);
                yield return new vince111b(35, "SSSV", 4, 58, 2, 173.5, 29.5, 111, 14.7);
                yield return new vince111b(36, "UISV", 4, 58, 2, 212.5, 32.5, 111, 21.15);
            }
        }
    }
}
