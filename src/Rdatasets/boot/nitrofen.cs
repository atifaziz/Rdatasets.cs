// ReSharper disable All

namespace Rdatasets.boot
{
    using System.Collections.Generic;

    /// <summary>
    /// Toxicity of Nitrofen in Aquatic Systems
    /// </summary>

    public class nitrofen
    {
        public readonly int κ;
        public readonly int conc;
        public readonly int brood1;
        public readonly int brood2;
        public readonly int brood3;
        public readonly int total;

        public nitrofen(int κ, int conc, int brood1, int brood2, int brood3, int total)
        {
            this.κ = κ;
            this.conc = conc;
            this.brood1 = brood1;
            this.brood2 = brood2;
            this.brood3 = brood3;
            this.total = total;
        }

        public static IEnumerable<nitrofen> Data
        {
            get
            {
                yield return new nitrofen(1, 0, 3, 14, 10, 27);
                yield return new nitrofen(2, 0, 5, 12, 15, 32);
                yield return new nitrofen(3, 0, 6, 11, 17, 34);
                yield return new nitrofen(4, 0, 6, 12, 15, 33);
                yield return new nitrofen(5, 0, 6, 15, 15, 36);
                yield return new nitrofen(6, 0, 5, 14, 15, 34);
                yield return new nitrofen(7, 0, 6, 12, 15, 33);
                yield return new nitrofen(8, 0, 5, 13, 12, 30);
                yield return new nitrofen(9, 0, 3, 10, 11, 24);
                yield return new nitrofen(10, 0, 6, 11, 14, 31);
                yield return new nitrofen(11, 80, 6, 11, 16, 33);
                yield return new nitrofen(12, 80, 5, 12, 16, 33);
                yield return new nitrofen(13, 80, 6, 11, 18, 35);
                yield return new nitrofen(14, 80, 5, 12, 16, 33);
                yield return new nitrofen(15, 80, 8, 13, 15, 36);
                yield return new nitrofen(16, 80, 3, 9, 14, 26);
                yield return new nitrofen(17, 80, 5, 9, 13, 27);
                yield return new nitrofen(18, 80, 7, 12, 12, 31);
                yield return new nitrofen(19, 80, 5, 13, 14, 32);
                yield return new nitrofen(20, 80, 3, 12, 14, 29);
                yield return new nitrofen(21, 160, 6, 12, 11, 29);
                yield return new nitrofen(22, 160, 6, 12, 11, 29);
                yield return new nitrofen(23, 160, 2, 8, 13, 23);
                yield return new nitrofen(24, 160, 6, 10, 11, 27);
                yield return new nitrofen(25, 160, 6, 11, 13, 30);
                yield return new nitrofen(26, 160, 6, 13, 12, 31);
                yield return new nitrofen(27, 160, 6, 12, 12, 30);
                yield return new nitrofen(28, 160, 5, 10, 11, 26);
                yield return new nitrofen(29, 160, 6, 13, 10, 29);
                yield return new nitrofen(30, 160, 6, 12, 11, 29);
                yield return new nitrofen(31, 235, 4, 13, 6, 23);
                yield return new nitrofen(32, 235, 6, 10, 5, 21);
                yield return new nitrofen(33, 235, 2, 5, 0, 7);
                yield return new nitrofen(34, 235, 6, 0, 6, 12);
                yield return new nitrofen(35, 235, 6, 13, 8, 27);
                yield return new nitrofen(36, 235, 6, 0, 10, 16);
                yield return new nitrofen(37, 235, 7, 0, 6, 13);
                yield return new nitrofen(38, 235, 4, 2, 9, 15);
                yield return new nitrofen(39, 235, 6, 8, 7, 21);
                yield return new nitrofen(40, 235, 7, 0, 10, 17);
                yield return new nitrofen(41, 310, 6, 0, 0, 6);
                yield return new nitrofen(42, 310, 6, 0, 0, 6);
                yield return new nitrofen(43, 310, 7, 0, 0, 7);
                yield return new nitrofen(44, 310, 0, 0, 0, 0);
                yield return new nitrofen(45, 310, 5, 10, 0, 15);
                yield return new nitrofen(46, 310, 5, 0, 0, 5);
                yield return new nitrofen(47, 310, 6, 0, 0, 6);
                yield return new nitrofen(48, 310, 4, 0, 0, 4);
                yield return new nitrofen(49, 310, 6, 0, 0, 6);
                yield return new nitrofen(50, 310, 5, 0, 0, 5);
            }
        }
    }
}
