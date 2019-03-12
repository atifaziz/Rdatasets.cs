// ReSharper disable All

namespace Rdatasets.gap
{
    using System.Collections.Generic;

    /// <summary>
    /// An example pedigree data
    /// </summary>

    public class l51
    {
        public readonly int κ;
        public readonly int id;
        public readonly int fid;
        public readonly int mid;
        public readonly int sex;
        public readonly int aff;
        public readonly double? qt;

        public l51(int κ, int id, int fid, int mid, int sex, int aff, double? qt)
        {
            this.κ = κ;
            this.id = id;
            this.fid = fid;
            this.mid = mid;
            this.sex = sex;
            this.aff = aff;
            this.qt = qt;
        }

        public static IEnumerable<l51> Data
        {
            get
            {
                yield return new l51(1, 1, 0, 0, 1, 1, -0.9642);
                yield return new l51(2, 2, 0, 0, 2, 1, 1.0865);
                yield return new l51(3, 3, 0, 0, 1, 1, -0.5363);
                yield return new l51(4, 4, 0, 0, 2, 1, 0.4514);
                yield return new l51(5, 5, 1, 2, 1, 1, 0.0538);
                yield return new l51(6, 6, 1, 2, 1, 1, -1.2667);
                yield return new l51(7, 7, 3, 4, 2, 1, null);
                yield return new l51(8, 8, 3, 4, 2, 1, 0.1743);
                yield return new l51(9, 9, 0, 0, 2, 1, 0.2923);
                yield return new l51(10, 10, 0, 0, 1, 1, null);
                yield return new l51(11, 11, 5, 9, 2, 2, -1.5195);
                yield return new l51(12, 12, 5, 9, 2, 2, -1.3278);
                yield return new l51(13, 13, 5, 9, 1, 2, 0.1136);
                yield return new l51(14, 14, 6, 7, 2, 2, -0.6259);
                yield return new l51(15, 15, 6, 7, 2, 2, -1.3347);
                yield return new l51(16, 16, 6, 7, 1, 2, 1.6801);
                yield return new l51(17, 17, 6, 7, 2, 2, 0.3058);
                yield return new l51(18, 18, 6, 7, 1, 2, null);
                yield return new l51(19, 19, 0, 0, 1, 1, null);
                yield return new l51(20, 20, 0, 0, 1, 1, null);
                yield return new l51(21, 21, 0, 0, 1, 1, 1.646);
                yield return new l51(22, 22, 10, 8, 2, 2, 1.5252);
                yield return new l51(23, 23, 19, 8, 2, 2, 0.4345);
                yield return new l51(24, 24, 20, 8, 1, 2, 1.567);
                yield return new l51(25, 25, 21, 8, 1, 2, -0.7109);
                yield return new l51(26, 26, 0, 0, 1, 2, null);
                yield return new l51(27, 27, 0, 0, 1, 2, null);
                yield return new l51(28, 28, 0, 0, 1, 2, null);
                yield return new l51(29, 29, 0, 0, 1, 2, 0.8935);
                yield return new l51(30, 30, 0, 0, 2, 2, 0.5551);
                yield return new l51(31, 31, 0, 0, 2, 2, 1.0955);
                yield return new l51(32, 32, 26, 11, 1, 3, 0.5568);
                yield return new l51(33, 33, 27, 11, 1, 3, -0.1261);
                yield return new l51(34, 34, 28, 11, 2, 3, -0.3218);
                yield return new l51(35, 35, 29, 14, 2, 3, 0.4226);
                yield return new l51(36, 36, 29, 14, 1, 3, -0.1976);
                yield return new l51(37, 37, 29, 14, 1, 3, 0.9757);
                yield return new l51(38, 38, 29, 14, 2, 3, -0.0665);
                yield return new l51(39, 39, 18, 30, 1, 3, 0.9576);
                yield return new l51(40, 40, 18, 30, 1, 3, 0.8279);
                yield return new l51(41, 41, 18, 30, 1, 3, 1.2006);
                yield return new l51(42, 42, 25, 31, 2, 3, 0.6248);
                yield return new l51(43, 43, 25, 31, 1, 3, 1.4515);
                yield return new l51(44, 44, 25, 31, 2, 3, 0.9316);
                yield return new l51(45, 45, 25, 31, 2, 3, 0.0539);
                yield return new l51(46, 46, 41, 42, 1, 4, 0.1254);
                yield return new l51(47, 47, 39, 38, 2, 4, -0.0021);
                yield return new l51(48, 48, 32, 35, 1, 4, 0.7343);
                yield return new l51(49, 49, 48, 47, 1, 4, 0.2323);
                yield return new l51(50, 50, 46, 47, 2, 4, 0.5342);
                yield return new l51(51, 51, 49, 50, 1, 4, 0.7723);
            }
        }
    }
}
