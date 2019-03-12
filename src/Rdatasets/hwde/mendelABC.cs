// ReSharper disable All

namespace Rdatasets.hwde
{
    using System.Collections.Generic;

    /// <summary>
    /// Mendel's F2 trifactorial data for seed shape (A: round or wrinkled), cotyledon color (B: albumen yellow or green), and seed coat color (C: grey-brown or white)
    /// </summary>

    public class mendelABC
    {
        public readonly int κ;
        public readonly string seedshape;
        public readonly string cotylcolor;
        public readonly string coatcolor;
        public readonly int Observed;

        public mendelABC(int κ, string seedshape, string cotylcolor, string coatcolor, int Observed)
        {
            this.κ = κ;
            this.seedshape = seedshape;
            this.cotylcolor = cotylcolor;
            this.coatcolor = coatcolor;
            this.Observed = Observed;
        }

        public static IEnumerable<mendelABC> Data
        {
            get
            {
                yield return new mendelABC(1, "AA", "BB", "CC", 8);
                yield return new mendelABC(2, "AA", "Bb", "CC", 15);
                yield return new mendelABC(3, "AA", "bb", "CC", 9);
                yield return new mendelABC(4, "AA", "BB", "Cc", 22);
                yield return new mendelABC(5, "AA", "Bb", "Cc", 45);
                yield return new mendelABC(6, "AA", "bb", "Cc", 17);
                yield return new mendelABC(7, "AA", "BB", "cc", 14);
                yield return new mendelABC(8, "AA", "Bb", "cc", 18);
                yield return new mendelABC(9, "AA", "bb", "cc", 11);
                yield return new mendelABC(10, "Aa", "BB", "CC", 14);
                yield return new mendelABC(11, "Aa", "Bb", "CC", 49);
                yield return new mendelABC(12, "Aa", "bb", "CC", 20);
                yield return new mendelABC(13, "Aa", "BB", "Cc", 38);
                yield return new mendelABC(14, "Aa", "Bb", "Cc", 78);
                yield return new mendelABC(15, "Aa", "bb", "Cc", 40);
                yield return new mendelABC(16, "Aa", "BB", "cc", 18);
                yield return new mendelABC(17, "Aa", "Bb", "cc", 48);
                yield return new mendelABC(18, "Aa", "bb", "cc", 16);
                yield return new mendelABC(19, "aa", "BB", "CC", 8);
                yield return new mendelABC(20, "aa", "Bb", "CC", 19);
                yield return new mendelABC(21, "aa", "bb", "CC", 10);
                yield return new mendelABC(22, "aa", "BB", "Cc", 25);
                yield return new mendelABC(23, "aa", "Bb", "Cc", 36);
                yield return new mendelABC(24, "aa", "bb", "Cc", 20);
                yield return new mendelABC(25, "aa", "BB", "cc", 10);
                yield return new mendelABC(26, "aa", "Bb", "cc", 24);
                yield return new mendelABC(27, "aa", "bb", "cc", 7);
            }
        }
    }
}
