// ReSharper disable All

namespace Rdatasets.DAAG
{
    using System.Collections.Generic;

    /// <summary>
    /// Wages of Lancashire Cotton Factory Workers in 1833
    /// </summary>

    public class wages1833
    {
        public readonly int κ;
        public readonly int age;
        public readonly int mnum;
        public readonly double mwage;
        public readonly int fnum;
        public readonly int fwage;

        public wages1833(int κ, int age, int mnum, double mwage, int fnum, int fwage)
        {
            this.κ = κ;
            this.age = age;
            this.mnum = mnum;
            this.mwage = mwage;
            this.fnum = fnum;
            this.fwage = fwage;
        }

        public static IEnumerable<wages1833> Data
        {
            get
            {
                yield return new wages1833(1, 10, 204, 30.5, 122, 35);
                yield return new wages1833(2, 11, 195, 37.8, 198, 38);
                yield return new wages1833(3, 12, 245, 43, 241, 44);
                yield return new wages1833(4, 13, 233, 50.5, 233, 46);
                yield return new wages1833(5, 14, 256, 56.5, 236, 59);
                yield return new wages1833(6, 15, 240, 63, 215, 68);
                yield return new wages1833(7, 16, 204, 83.5, 256, 72);
                yield return new wages1833(8, 17, 141, 88.5, 245, 78);
                yield return new wages1833(9, 18, 164, 141, 279, 90);
                yield return new wages1833(10, 19, 135, 138.3, 251, 98);
                yield return new wages1833(11, 20, 92, 161.3, 209, 97);
                yield return new wages1833(12, 21, 180, 157.3, 251, 96);
                yield return new wages1833(13, 22, 145, 201.5, 192, 102);
                yield return new wages1833(14, 23, 104, 224, 138, 100);
                yield return new wages1833(15, 24, 83, 223.5, 100, 101);
                yield return new wages1833(16, 25, 100, 226.8, 99, 106);
                yield return new wages1833(17, 26, 73, 221, 72, 108);
                yield return new wages1833(18, 27, 79, 248, 67, 105);
                yield return new wages1833(19, 28, 75, 257, 54, 97);
                yield return new wages1833(20, 29, 52, 241, 45, 100);
                yield return new wages1833(21, 30, 76, 253.8, 57, 109);
                yield return new wages1833(22, 31, 31, 274.5, 21, 119);
                yield return new wages1833(23, 32, 51, 278, 24, 123);
                yield return new wages1833(24, 33, 46, 282.8, 20, 105);
                yield return new wages1833(25, 34, 41, 248.3, 10, 85);
                yield return new wages1833(26, 35, 46, 279, 25, 96);
                yield return new wages1833(27, 36, 45, 278, 22, 123);
                yield return new wages1833(28, 37, 21, 263.5, 13, 120);
                yield return new wages1833(29, 38, 38, 275, 21, 119);
                yield return new wages1833(30, 39, 26, 236.5, 10, 116);
                yield return new wages1833(31, 40, 38, 243.5, 15, 104);
                yield return new wages1833(32, 41, 17, 233.5, 11, 99);
                yield return new wages1833(33, 42, 34, 265.5, 12, 129);
                yield return new wages1833(34, 43, 12, 262, 6, 113);
                yield return new wages1833(35, 44, 18, 249.5, 4, 109);
                yield return new wages1833(36, 45, 17, 207, 5, 107);
                yield return new wages1833(37, 46, 13, 236.3, 10, 124);
                yield return new wages1833(38, 47, 18, 169, 3, 108);
                yield return new wages1833(39, 48, 21, 223, 4, 117);
                yield return new wages1833(40, 49, 9, 172.5, 4, 94);
                yield return new wages1833(41, 50, 27, 196, 2, 87);
                yield return new wages1833(42, 51, 6, 179, 0, 0);
                yield return new wages1833(43, 52, 7, 292, 0, 0);
                yield return new wages1833(44, 53, 6, 131.3, 0, 0);
                yield return new wages1833(45, 54, 12, 174, 0, 0);
                yield return new wages1833(46, 55, 10, 202.8, 0, 0);
                yield return new wages1833(47, 56, 5, 184, 0, 0);
                yield return new wages1833(48, 57, 3, 142.5, 0, 0);
                yield return new wages1833(49, 58, 3, 139, 0, 0);
                yield return new wages1833(50, 59, 8, 183.3, 0, 0);
                yield return new wages1833(51, 60, 9, 162, 0, 0);
            }
        }
    }
}
