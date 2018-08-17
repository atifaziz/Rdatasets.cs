// ReSharper disable All

namespace Rdatasets.gap
{
    using System.Collections.Generic;

    /// <summary>
    /// Friedreich Ataxia data
    /// </summary>

    public class fa
    {
        public readonly int y;
        public readonly int loci1;
        public readonly int loci2;
        public readonly int loci3;
        public readonly int loci4;
        public readonly int loci5;
        public readonly int loci6;
        public readonly int loci7;
        public readonly int loci8;
        public readonly int loci9;
        public readonly int loci10;
        public readonly int loci11;
        public readonly int loci12;

        public fa(int y, int loci1, int loci2, int loci3, int loci4, int loci5, int loci6, int loci7, int loci8, int loci9, int loci10, int loci11, int loci12)
        {
            this.y = y;
            this.loci1 = loci1;
            this.loci2 = loci2;
            this.loci3 = loci3;
            this.loci4 = loci4;
            this.loci5 = loci5;
            this.loci6 = loci6;
            this.loci7 = loci7;
            this.loci8 = loci8;
            this.loci9 = loci9;
            this.loci10 = loci10;
            this.loci11 = loci11;
            this.loci12 = loci12;
        }

        public static IEnumerable<fa> Data
        {
            get
            {
                yield return new fa(1, 2, 7, 8, 2, 5, 9, 2, 2, 2, 2, 6, 3);
                yield return new fa(1, 3, 7, 8, 2, 5, 9, 2, 2, 2, 2, 6, 3);
                yield return new fa(1, 3, 1, 8, 2, 5, 9, 2, 2, 2, 2, 14, 5);
                yield return new fa(1, 2, 5, 7, 2, 5, 9, 2, 2, 2, 2, 14, 3);
                yield return new fa(1, 14, 7, 8, 5, 6, 2, 3, 2, 2, 2, 14, 9);
                yield return new fa(1, 8, 4, 7, 7, 3, 2, 3, 4, 2, 2, 14, 9);
                yield return new fa(1, 8, 4, 8, 2, 5, 9, 2, 1, 3, 1, 14, 11);
                yield return new fa(1, 8, 4, 8, 2, 5, 9, 2, 1, 3, 1, 14, 11);
                yield return new fa(1, 3, 2, 8, 2, 5, 9, 2, 2, 2, 2, 6, 3);
                yield return new fa(1, 8, 4, 8, 2, 5, 9, 2, 2, 2, 2, 10, 6);
                yield return new fa(1, 1, 7, 8, 2, 14, 9, 2, 2, 2, 2, 14, 3);
                yield return new fa(1, 3, 5, 8, 5, 14, 2, 3, 2, 2, 2, 14, 9);
                yield return new fa(1, 8, 7, 8, 2, 5, 9, 2, 2, 2, 2, 6, 3);
                yield return new fa(1, 2, 7, 8, 2, 5, 9, 2, 2, 2, 2, 6, 14);
                yield return new fa(1, 3, 5, 8, 2, 5, 9, 2, 2, 2, 2, 6, 3);
                yield return new fa(1, 2, 7, 8, 8, 1, 3, 3, 2, 4, 5, 9, 10);
                yield return new fa(1, 3, 5, 8, 5, 6, 2, 2, 1, 4, 2, 14, 5);
                yield return new fa(1, 8, 5, 8, 5, 6, 2, 3, 2, 2, 5, 14, 5);
                yield return new fa(1, 8, 4, 7, 7, 3, 3, 3, 4, 2, 2, 7, 5);
                yield return new fa(1, 7, 7, 7, 7, 3, 3, 3, 4, 2, 2, 7, 5);
                yield return new fa(1, 9, 2, 8, 14, 5, 9, 3, 4, 14, 14, 14, 5);
                yield return new fa(1, 3, 7, 8, 7, 6, 2, 3, 4, 14, 14, 14, 11);
                yield return new fa(1, 4, 14, 8, 3, 14, 9, 2, 4, 4, 5, 14, 14);
                yield return new fa(1, 14, 7, 8, 3, 5, 2, 2, 2, 2, 5, 14, 5);
                yield return new fa(1, 14, 7, 8, 7, 6, 9, 3, 4, 4, 5, 14, 5);
                yield return new fa(1, 2, 14, 8, 2, 14, 9, 2, 2, 2, 2, 6, 14);
                yield return new fa(1, 2, 7, 8, 2, 5, 9, 2, 2, 2, 2, 6, 3);
                yield return new fa(1, 1, 7, 8, 2, 5, 9, 2, 2, 2, 2, 6, 3);
                yield return new fa(1, 2, 7, 8, 2, 5, 9, 2, 2, 2, 2, 6, 3);
                yield return new fa(1, 2, 7, 8, 2, 5, 9, 2, 2, 2, 2, 6, 14);
                yield return new fa(1, 14, 7, 8, 6, 2, 2, 3, 2, 3, 2, 6, 11);
                yield return new fa(1, 14, 7, 8, 7, 6, 2, 3, 2, 3, 3, 5, 5);
                yield return new fa(1, 4, 5, 5, 10, 3, 8, 3, 4, 2, 5, 14, 5);
                yield return new fa(1, 7, 7, 8, 2, 5, 9, 2, 2, 2, 2, 14, 3);
                yield return new fa(1, 2, 1, 8, 2, 5, 9, 2, 2, 2, 2, 14, 5);
                yield return new fa(1, 8, 5, 8, 2, 5, 9, 2, 2, 2, 2, 14, 3);
                yield return new fa(1, 1, 7, 8, 2, 5, 9, 2, 2, 2, 2, 14, 3);
                yield return new fa(1, 2, 7, 8, 2, 5, 9, 2, 2, 2, 2, 14, 1);
                yield return new fa(1, 3, 2, 8, 2, 5, 9, 2, 2, 2, 2, 6, 3);
                yield return new fa(1, 1, 5, 8, 5, 6, 3, 3, 2, 2, 2, 1, 5);
                yield return new fa(1, 1, 6, 8, 5, 6, 3, 3, 2, 2, 2, 1, 9);
                yield return new fa(1, 8, 3, 8, 4, 5, 9, 3, 2, 2, 2, 9, 10);
                yield return new fa(1, 2, 7, 8, 7, 6, 3, 3, 2, 3, 3, 5, 14);
                yield return new fa(1, 8, 5, 8, 2, 5, 9, 2, 2, 2, 2, 6, 14);
                yield return new fa(1, 2, 1, 8, 2, 5, 14, 2, 2, 2, 2, 14, 5);
                yield return new fa(1, 3, 5, 8, 2, 5, 14, 2, 2, 2, 2, 14, 3);
                yield return new fa(1, 14, 7, 8, 2, 5, 9, 2, 2, 2, 14, 6, 10);
                yield return new fa(1, 14, 4, 7, 7, 3, 3, 3, 4, 4, 2, 7, 5);
                yield return new fa(1, 14, 8, 7, 7, 3, 3, 3, 4, 4, 2, 7, 9);
                yield return new fa(1, 8, 7, 3, 6, 3, 14, 2, 2, 3, 2, 13, 3);
                yield return new fa(1, 2, 7, 8, 2, 5, 14, 2, 2, 2, 2, 9, 5);
                yield return new fa(1, 2, 7, 8, 2, 5, 9, 2, 2, 2, 2, 6, 3);
                yield return new fa(1, 2, 7, 8, 2, 5, 9, 2, 2, 2, 2, 6, 5);
                yield return new fa(1, 8, 7, 8, 7, 6, 3, 3, 2, 3, 2, 14, 9);
                yield return new fa(1, 2, 7, 8, 2, 5, 9, 2, 2, 2, 2, 14, 3);
                yield return new fa(1, 2, 7, 8, 7, 6, 9, 3, 4, 5, 4, 14, 14);
                yield return new fa(1, 14, 5, 8, 2, 5, 9, 14, 2, 2, 2, 14, 11);
                yield return new fa(1, 14, 6, 8, 5, 6, 3, 14, 2, 2, 2, 14, 5);
                yield return new fa(0, 2, 7, 5, 3, 5, 9, 2, 2, 5, 3, 7, 6);
                yield return new fa(0, 3, 4, 7, 7, 6, 3, 2, 4, 3, 2, 13, 9);
                yield return new fa(0, 4, 7, 6, 3, 5, 3, 2, 2, 4, 5, 14, 10);
                yield return new fa(0, 3, 7, 6, 6, 6, 9, 3, 2, 4, 2, 14, 14);
                yield return new fa(0, 8, 14, 9, 5, 14, 9, 3, 4, 2, 2, 14, 14);
                yield return new fa(0, 8, 14, 7, 7, 14, 2, 3, 4, 2, 2, 14, 14);
                yield return new fa(0, 8, 14, 7, 5, 14, 3, 3, 2, 4, 5, 14, 14);
                yield return new fa(0, 2, 7, 8, 7, 8, 2, 3, 4, 4, 5, 14, 11);
                yield return new fa(0, 8, 6, 3, 6, 5, 12, 3, 2, 2, 2, 14, 11);
                yield return new fa(0, 2, 6, 8, 3, 5, 4, 3, 2, 4, 5, 13, 9);
                yield return new fa(0, 8, 4, 8, 7, 6, 9, 3, 4, 5, 4, 13, 11);
                yield return new fa(0, 14, 14, 8, 8, 14, 12, 2, 1, 4, 2, 6, 14);
                yield return new fa(0, 8, 7, 9, 7, 5, 9, 1, 2, 2, 2, 14, 10);
                yield return new fa(0, 2, 7, 8, 3, 6, 9, 2, 2, 2, 2, 14, 9);
                yield return new fa(0, 8, 8, 8, 2, 5, 10, 2, 4, 4, 4, 9, 11);
                yield return new fa(0, 2, 7, 8, 3, 6, 9, 2, 2, 2, 2, 14, 9);
                yield return new fa(0, 8, 8, 8, 2, 5, 10, 2, 4, 4, 4, 9, 11);
                yield return new fa(0, 2, 7, 8, 2, 5, 3, 3, 1, 2, 2, 7, 9);
                yield return new fa(0, 8, 7, 8, 1, 5, 7, 2, 4, 2, 4, 7, 10);
                yield return new fa(0, 1, 7, 4, 9, 2, 3, 3, 1, 3, 1, 9, 4);
                yield return new fa(0, 3, 5, 7, 7, 2, 0, 3, 1, 3, 6, 14, 10);
                yield return new fa(0, 3, 6, 2, 5, 4, 4, 3, 1, 3, 0, 14, 5);
                yield return new fa(0, 3, 4, 8, 4, 5, 6, 2, 2, 4, 4, 9, 11);
                yield return new fa(0, 8, 7, 3, 6, 3, 5, 2, 4, 4, 4, 5, 9);
                yield return new fa(0, 3, 14, 8, 1, 14, 2, 2, 14, 14, 14, 14, 14);
                yield return new fa(0, 4, 14, 3, 4, 6, 2, 4, 2, 14, 2, 14, 14);
                yield return new fa(0, 2, 14, 7, 7, 14, 3, 1, 5, 4, 14, 14, 14);
                yield return new fa(0, 8, 4, 5, 6, 3, 6, 2, 2, 4, 2, 14, 9);
                yield return new fa(0, 9, 4, 5, 8, 2, 8, 3, 4, 3, 5, 14, 5);
                yield return new fa(0, 14, 7, 9, 8, 1, 9, 3, 2, 4, 5, 9, 4);
                yield return new fa(0, 14, 7, 2, 6, 4, 3, 3, 1, 2, 2, 13, 5);
                yield return new fa(0, 14, 8, 7, 8, 1, 3, 2, 4, 4, 5, 14, 9);
                yield return new fa(0, 14, 7, 6, 3, 5, 2, 3, 2, 3, 2, 14, 5);
                yield return new fa(0, 7, 5, 6, 5, 5, 9, 2, 1, 3, 3, 13, 10);
                yield return new fa(0, 2, 7, 7, 6, 4, 9, 3, 2, 3, 2, 13, 3);
                yield return new fa(0, 8, 14, 7, 9, 14, 3, 3, 4, 4, 5, 9, 14);
                yield return new fa(0, 3, 14, 9, 14, 14, 6, 2, 4, 4, 2, 8, 14);
                yield return new fa(0, 2, 14, 8, 3, 14, 4, 3, 2, 3, 6, 14, 14);
                yield return new fa(0, 14, 14, 8, 3, 14, 9, 3, 2, 4, 5, 10, 14);
                yield return new fa(0, 14, 14, 5, 7, 14, 9, 3, 1, 3, 2, 13, 14);
                yield return new fa(0, 14, 14, 4, 4, 14, 14, 2, 2, 4, 2, 14, 5);
                yield return new fa(0, 14, 7, 8, 3, 5, 9, 3, 2, 4, 2, 9, 5);
                yield return new fa(0, 3, 14, 9, 6, 2, 14, 14, 14, 3, 2, 14, 9);
                yield return new fa(0, 8, 1, 9, 7, 4, 3, 1, 2, 2, 2, 14, 10);
                yield return new fa(0, 2, 7, 8, 3, 5, 9, 3, 4, 5, 4, 14, 11);
                yield return new fa(0, 3, 7, 6, 5, 4, 6, 2, 1, 3, 2, 14, 5);
                yield return new fa(0, 2, 7, 8, 2, 4, 3, 3, 4, 3, 2, 13, 3);
                yield return new fa(0, 7, 7, 5, 6, 3, 8, 3, 2, 3, 6, 8, 5);
                yield return new fa(0, 3, 6, 8, 3, 5, 12, 3, 4, 2, 2, 13, 3);
                yield return new fa(0, 3, 5, 8, 3, 5, 12, 3, 1, 4, 5, 14, 14);
                yield return new fa(0, 2, 7, 5, 6, 2, 4, 2, 4, 4, 5, 14, 14);
                yield return new fa(0, 14, 7, 7, 7, 6, 4, 2, 2, 2, 5, 13, 14);
                yield return new fa(0, 14, 3, 7, 7, 7, 4, 3, 4, 2, 3, 7, 14);
                yield return new fa(0, 4, 7, 6, 4, 4, 9, 2, 2, 4, 4, 5, 14);
                yield return new fa(0, 2, 4, 7, 8, 6, 4, 3, 2, 4, 5, 9, 14);
                yield return new fa(0, 3, 14, 6, 7, 14, 4, 2, 2, 4, 5, 8, 14);
                yield return new fa(0, 8, 14, 14, 5, 14, 9, 2, 1, 3, 3, 13, 14);
                yield return new fa(0, 4, 14, 6, 4, 14, 9, 3, 2, 2, 1, 5, 14);
                yield return new fa(0, 14, 14, 8, 7, 14, 9, 2, 2, 4, 4, 8, 14);
                yield return new fa(0, 2, 14, 6, 9, 14, 3, 3, 1, 4, 5, 10, 14);
                yield return new fa(0, 5, 14, 5, 6, 14, 3, 3, 2, 3, 6, 11, 14);
                yield return new fa(0, 7, 0, 8, 1, 5, 14, 1, 2, 4, 2, 13, 9);
                yield return new fa(0, 3, 6, 1, 6, 2, 14, 3, 4, 2, 2, 6, 9);
                yield return new fa(0, 3, 14, 4, 7, 14, 7, 3, 2, 2, 2, 5, 14);
                yield return new fa(0, 3, 14, 8, 5, 14, 9, 3, 4, 4, 5, 8, 14);
                yield return new fa(0, 14, 14, 8, 3, 14, 14, 3, 4, 4, 4, 14, 14);
                yield return new fa(0, 14, 14, 3, 6, 14, 3, 2, 2, 4, 4, 14, 14);
                yield return new fa(0, 8, 5, 4, 6, 3, 3, 14, 2, 4, 5, 14, 9);
                yield return new fa(0, 14, 14, 8, 3, 14, 14, 14, 2, 14, 14, 14, 14);
            }
        }
    }
}
