// ReSharper disable All

namespace Rdatasets.DAAG
{
    using System.Collections.Generic;

    /// <summary>
    /// Tasting experiment that compared four apple varieties
    /// </summary>

    public class appletaste
    {
        public readonly int κ;
        public readonly int aftertaste;
        public readonly string panelist;
        public readonly int product;

        public appletaste(int κ, int aftertaste, string panelist, int product)
        {
            this.κ = κ;
            this.aftertaste = aftertaste;
            this.panelist = panelist;
            this.product = product;
        }

        public static IEnumerable<appletaste> Data
        {
            get
            {
                yield return new appletaste(1, 89, "a", 937);
                yield return new appletaste(2, 98, "a", 298);
                yield return new appletaste(3, 108, "a", 493);
                yield return new appletaste(4, 13, "b", 937);
                yield return new appletaste(5, 55, "b", 298);
                yield return new appletaste(6, 104, "b", 493);
                yield return new appletaste(7, 40, "c", 937);
                yield return new appletaste(8, 122, "c", 298);
                yield return new appletaste(9, 148, "c", 493);
                yield return new appletaste(10, 6, "d", 937);
                yield return new appletaste(11, 77, "d", 298);
                yield return new appletaste(12, 137, "d", 493);
                yield return new appletaste(13, 30, "e", 937);
                yield return new appletaste(14, 88, "e", 298);
                yield return new appletaste(15, 98, "e", 493);
                yield return new appletaste(16, 16, "f", 937);
                yield return new appletaste(17, 46, "f", 649);
                yield return new appletaste(18, 129, "f", 493);
                yield return new appletaste(19, 6, "g", 937);
                yield return new appletaste(20, 28, "g", 649);
                yield return new appletaste(21, 80, "g", 493);
                yield return new appletaste(22, 18, "h", 937);
                yield return new appletaste(23, 63, "h", 649);
                yield return new appletaste(24, 85, "h", 493);
                yield return new appletaste(25, 29, "i", 937);
                yield return new appletaste(26, 106, "i", 649);
                yield return new appletaste(27, 124, "i", 493);
                yield return new appletaste(28, 14, "j", 937);
                yield return new appletaste(29, 122, "j", 649);
                yield return new appletaste(30, 138, "j", 493);
                yield return new appletaste(31, 18, "k", 937);
                yield return new appletaste(32, 21, "k", 649);
                yield return new appletaste(33, 24, "k", 298);
                yield return new appletaste(34, 76, "l", 937);
                yield return new appletaste(35, 17, "l", 649);
                yield return new appletaste(36, 24, "l", 298);
                yield return new appletaste(37, 45, "m", 937);
                yield return new appletaste(38, 98, "m", 649);
                yield return new appletaste(39, 60, "m", 298);
                yield return new appletaste(40, 46, "n", 937);
                yield return new appletaste(41, 58, "n", 649);
                yield return new appletaste(42, 71, "n", 298);
                yield return new appletaste(43, 4, "o", 937);
                yield return new appletaste(44, 35, "o", 649);
                yield return new appletaste(45, 72, "o", 298);
                yield return new appletaste(46, 39, "p", 649);
                yield return new appletaste(47, 94, "p", 493);
                yield return new appletaste(48, 65, "p", 298);
                yield return new appletaste(49, 25, "q", 649);
                yield return new appletaste(50, 58, "q", 493);
                yield return new appletaste(51, 69, "q", 298);
                yield return new appletaste(52, 57, "r", 649);
                yield return new appletaste(53, 79, "r", 493);
                yield return new appletaste(54, 68, "r", 298);
                yield return new appletaste(55, 41, "s", 649);
                yield return new appletaste(56, 20, "s", 493);
                yield return new appletaste(57, 99, "s", 298);
                yield return new appletaste(58, 21, "t", 649);
                yield return new appletaste(59, 9, "t", 493);
                yield return new appletaste(60, 33, "t", 298);
            }
        }
    }
}
