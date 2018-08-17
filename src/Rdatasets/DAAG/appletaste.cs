// ReSharper disable All

namespace Rdatasets.DAAG
{
    using System.Collections.Generic;

    /// <summary>
    /// Tasting experiment that compared four apple varieties
    /// </summary>

    public class appletaste
    {
        public readonly int aftertaste;
        public readonly string panelist;
        public readonly int product;

        public appletaste(int aftertaste, string panelist, int product)
        {
            this.aftertaste = aftertaste;
            this.panelist = panelist;
            this.product = product;
        }

        public static IEnumerable<appletaste> Data
        {
            get
            {
                yield return new appletaste(89, "a", 937);
                yield return new appletaste(98, "a", 298);
                yield return new appletaste(108, "a", 493);
                yield return new appletaste(13, "b", 937);
                yield return new appletaste(55, "b", 298);
                yield return new appletaste(104, "b", 493);
                yield return new appletaste(40, "c", 937);
                yield return new appletaste(122, "c", 298);
                yield return new appletaste(148, "c", 493);
                yield return new appletaste(6, "d", 937);
                yield return new appletaste(77, "d", 298);
                yield return new appletaste(137, "d", 493);
                yield return new appletaste(30, "e", 937);
                yield return new appletaste(88, "e", 298);
                yield return new appletaste(98, "e", 493);
                yield return new appletaste(16, "f", 937);
                yield return new appletaste(46, "f", 649);
                yield return new appletaste(129, "f", 493);
                yield return new appletaste(6, "g", 937);
                yield return new appletaste(28, "g", 649);
                yield return new appletaste(80, "g", 493);
                yield return new appletaste(18, "h", 937);
                yield return new appletaste(63, "h", 649);
                yield return new appletaste(85, "h", 493);
                yield return new appletaste(29, "i", 937);
                yield return new appletaste(106, "i", 649);
                yield return new appletaste(124, "i", 493);
                yield return new appletaste(14, "j", 937);
                yield return new appletaste(122, "j", 649);
                yield return new appletaste(138, "j", 493);
                yield return new appletaste(18, "k", 937);
                yield return new appletaste(21, "k", 649);
                yield return new appletaste(24, "k", 298);
                yield return new appletaste(76, "l", 937);
                yield return new appletaste(17, "l", 649);
                yield return new appletaste(24, "l", 298);
                yield return new appletaste(45, "m", 937);
                yield return new appletaste(98, "m", 649);
                yield return new appletaste(60, "m", 298);
                yield return new appletaste(46, "n", 937);
                yield return new appletaste(58, "n", 649);
                yield return new appletaste(71, "n", 298);
                yield return new appletaste(4, "o", 937);
                yield return new appletaste(35, "o", 649);
                yield return new appletaste(72, "o", 298);
                yield return new appletaste(39, "p", 649);
                yield return new appletaste(94, "p", 493);
                yield return new appletaste(65, "p", 298);
                yield return new appletaste(25, "q", 649);
                yield return new appletaste(58, "q", 493);
                yield return new appletaste(69, "q", 298);
                yield return new appletaste(57, "r", 649);
                yield return new appletaste(79, "r", 493);
                yield return new appletaste(68, "r", 298);
                yield return new appletaste(41, "s", 649);
                yield return new appletaste(20, "s", 493);
                yield return new appletaste(99, "s", 298);
                yield return new appletaste(21, "t", 649);
                yield return new appletaste(9, "t", 493);
                yield return new appletaste(33, "t", 298);
            }
        }
    }
}
