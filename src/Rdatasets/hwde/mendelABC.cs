// ReSharper disable All

namespace Rdatasets.hwde
{
    using System.Collections.Generic;

    /// <summary>
    /// Mendel's F2 trifactorial data for seed shape (A: round or wrinkled), cotyledon color (B: albumen yellow or green), and seed coat color (C: grey-brown or white)
    /// </summary>

    public class mendelABC
    {
        public readonly string seedshape;
        public readonly string cotylcolor;
        public readonly string coatcolor;
        public readonly int Observed;

        public mendelABC(string seedshape, string cotylcolor, string coatcolor, int Observed)
        {
            this.seedshape = seedshape;
            this.cotylcolor = cotylcolor;
            this.coatcolor = coatcolor;
            this.Observed = Observed;
        }

        public static IEnumerable<mendelABC> Data
        {
            get
            {
                yield return new mendelABC("AA", "BB", "CC", 8);
                yield return new mendelABC("AA", "Bb", "CC", 15);
                yield return new mendelABC("AA", "bb", "CC", 9);
                yield return new mendelABC("AA", "BB", "Cc", 22);
                yield return new mendelABC("AA", "Bb", "Cc", 45);
                yield return new mendelABC("AA", "bb", "Cc", 17);
                yield return new mendelABC("AA", "BB", "cc", 14);
                yield return new mendelABC("AA", "Bb", "cc", 18);
                yield return new mendelABC("AA", "bb", "cc", 11);
                yield return new mendelABC("Aa", "BB", "CC", 14);
                yield return new mendelABC("Aa", "Bb", "CC", 49);
                yield return new mendelABC("Aa", "bb", "CC", 20);
                yield return new mendelABC("Aa", "BB", "Cc", 38);
                yield return new mendelABC("Aa", "Bb", "Cc", 78);
                yield return new mendelABC("Aa", "bb", "Cc", 40);
                yield return new mendelABC("Aa", "BB", "cc", 18);
                yield return new mendelABC("Aa", "Bb", "cc", 48);
                yield return new mendelABC("Aa", "bb", "cc", 16);
                yield return new mendelABC("aa", "BB", "CC", 8);
                yield return new mendelABC("aa", "Bb", "CC", 19);
                yield return new mendelABC("aa", "bb", "CC", 10);
                yield return new mendelABC("aa", "BB", "Cc", 25);
                yield return new mendelABC("aa", "Bb", "Cc", 36);
                yield return new mendelABC("aa", "bb", "Cc", 20);
                yield return new mendelABC("aa", "BB", "cc", 10);
                yield return new mendelABC("aa", "Bb", "cc", 24);
                yield return new mendelABC("aa", "bb", "cc", 7);
            }
        }
    }
}
