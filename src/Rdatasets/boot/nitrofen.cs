// ReSharper disable All

namespace Rdatasets.boot
{
    using System.Collections.Generic;

    /// <summary>
    /// Toxicity of Nitrofen in Aquatic Systems
    /// </summary>

    public class nitrofen
    {
        public readonly int conc;
        public readonly int brood1;
        public readonly int brood2;
        public readonly int brood3;
        public readonly int total;

        public nitrofen(int conc, int brood1, int brood2, int brood3, int total)
        {
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
                yield return new nitrofen(0, 3, 14, 10, 27);
                yield return new nitrofen(0, 5, 12, 15, 32);
                yield return new nitrofen(0, 6, 11, 17, 34);
                yield return new nitrofen(0, 6, 12, 15, 33);
                yield return new nitrofen(0, 6, 15, 15, 36);
                yield return new nitrofen(0, 5, 14, 15, 34);
                yield return new nitrofen(0, 6, 12, 15, 33);
                yield return new nitrofen(0, 5, 13, 12, 30);
                yield return new nitrofen(0, 3, 10, 11, 24);
                yield return new nitrofen(0, 6, 11, 14, 31);
                yield return new nitrofen(80, 6, 11, 16, 33);
                yield return new nitrofen(80, 5, 12, 16, 33);
                yield return new nitrofen(80, 6, 11, 18, 35);
                yield return new nitrofen(80, 5, 12, 16, 33);
                yield return new nitrofen(80, 8, 13, 15, 36);
                yield return new nitrofen(80, 3, 9, 14, 26);
                yield return new nitrofen(80, 5, 9, 13, 27);
                yield return new nitrofen(80, 7, 12, 12, 31);
                yield return new nitrofen(80, 5, 13, 14, 32);
                yield return new nitrofen(80, 3, 12, 14, 29);
                yield return new nitrofen(160, 6, 12, 11, 29);
                yield return new nitrofen(160, 6, 12, 11, 29);
                yield return new nitrofen(160, 2, 8, 13, 23);
                yield return new nitrofen(160, 6, 10, 11, 27);
                yield return new nitrofen(160, 6, 11, 13, 30);
                yield return new nitrofen(160, 6, 13, 12, 31);
                yield return new nitrofen(160, 6, 12, 12, 30);
                yield return new nitrofen(160, 5, 10, 11, 26);
                yield return new nitrofen(160, 6, 13, 10, 29);
                yield return new nitrofen(160, 6, 12, 11, 29);
                yield return new nitrofen(235, 4, 13, 6, 23);
                yield return new nitrofen(235, 6, 10, 5, 21);
                yield return new nitrofen(235, 2, 5, 0, 7);
                yield return new nitrofen(235, 6, 0, 6, 12);
                yield return new nitrofen(235, 6, 13, 8, 27);
                yield return new nitrofen(235, 6, 0, 10, 16);
                yield return new nitrofen(235, 7, 0, 6, 13);
                yield return new nitrofen(235, 4, 2, 9, 15);
                yield return new nitrofen(235, 6, 8, 7, 21);
                yield return new nitrofen(235, 7, 0, 10, 17);
                yield return new nitrofen(310, 6, 0, 0, 6);
                yield return new nitrofen(310, 6, 0, 0, 6);
                yield return new nitrofen(310, 7, 0, 0, 7);
                yield return new nitrofen(310, 0, 0, 0, 0);
                yield return new nitrofen(310, 5, 10, 0, 15);
                yield return new nitrofen(310, 5, 0, 0, 5);
                yield return new nitrofen(310, 6, 0, 0, 6);
                yield return new nitrofen(310, 4, 0, 0, 4);
                yield return new nitrofen(310, 6, 0, 0, 6);
                yield return new nitrofen(310, 5, 0, 0, 5);
            }
        }
    }
}
