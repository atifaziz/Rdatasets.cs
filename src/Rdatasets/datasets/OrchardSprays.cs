// ReSharper disable All

namespace Rdatasets.datasets
{
    using System.Collections.Generic;

    /// <summary>
    /// Potency of Orchard Sprays
    /// </summary>

    public class OrchardSprays
    {
        public readonly int κ;
        public readonly int decrease;
        public readonly int rowpos;
        public readonly int colpos;
        public readonly string treatment;

        public OrchardSprays(int κ, int decrease, int rowpos, int colpos, string treatment)
        {
            this.κ = κ;
            this.decrease = decrease;
            this.rowpos = rowpos;
            this.colpos = colpos;
            this.treatment = treatment;
        }

        public static IEnumerable<OrchardSprays> Data
        {
            get
            {
                yield return new OrchardSprays(1, 57, 1, 1, "D");
                yield return new OrchardSprays(2, 95, 2, 1, "E");
                yield return new OrchardSprays(3, 8, 3, 1, "B");
                yield return new OrchardSprays(4, 69, 4, 1, "H");
                yield return new OrchardSprays(5, 92, 5, 1, "G");
                yield return new OrchardSprays(6, 90, 6, 1, "F");
                yield return new OrchardSprays(7, 15, 7, 1, "C");
                yield return new OrchardSprays(8, 2, 8, 1, "A");
                yield return new OrchardSprays(9, 84, 1, 2, "C");
                yield return new OrchardSprays(10, 6, 2, 2, "B");
                yield return new OrchardSprays(11, 127, 3, 2, "H");
                yield return new OrchardSprays(12, 36, 4, 2, "D");
                yield return new OrchardSprays(13, 51, 5, 2, "E");
                yield return new OrchardSprays(14, 2, 6, 2, "A");
                yield return new OrchardSprays(15, 69, 7, 2, "F");
                yield return new OrchardSprays(16, 71, 8, 2, "G");
                yield return new OrchardSprays(17, 87, 1, 3, "F");
                yield return new OrchardSprays(18, 72, 2, 3, "H");
                yield return new OrchardSprays(19, 5, 3, 3, "A");
                yield return new OrchardSprays(20, 39, 4, 3, "E");
                yield return new OrchardSprays(21, 22, 5, 3, "D");
                yield return new OrchardSprays(22, 16, 6, 3, "C");
                yield return new OrchardSprays(23, 72, 7, 3, "G");
                yield return new OrchardSprays(24, 4, 8, 3, "B");
                yield return new OrchardSprays(25, 130, 1, 4, "H");
                yield return new OrchardSprays(26, 4, 2, 4, "A");
                yield return new OrchardSprays(27, 114, 3, 4, "E");
                yield return new OrchardSprays(28, 9, 4, 4, "C");
                yield return new OrchardSprays(29, 20, 5, 4, "F");
                yield return new OrchardSprays(30, 24, 6, 4, "G");
                yield return new OrchardSprays(31, 10, 7, 4, "B");
                yield return new OrchardSprays(32, 51, 8, 4, "D");
                yield return new OrchardSprays(33, 43, 1, 5, "E");
                yield return new OrchardSprays(34, 28, 2, 5, "D");
                yield return new OrchardSprays(35, 60, 3, 5, "G");
                yield return new OrchardSprays(36, 5, 4, 5, "A");
                yield return new OrchardSprays(37, 17, 5, 5, "C");
                yield return new OrchardSprays(38, 7, 6, 5, "B");
                yield return new OrchardSprays(39, 81, 7, 5, "H");
                yield return new OrchardSprays(40, 71, 8, 5, "F");
                yield return new OrchardSprays(41, 12, 1, 6, "A");
                yield return new OrchardSprays(42, 29, 2, 6, "C");
                yield return new OrchardSprays(43, 44, 3, 6, "F");
                yield return new OrchardSprays(44, 77, 4, 6, "G");
                yield return new OrchardSprays(45, 4, 5, 6, "B");
                yield return new OrchardSprays(46, 27, 6, 6, "D");
                yield return new OrchardSprays(47, 47, 7, 6, "E");
                yield return new OrchardSprays(48, 76, 8, 6, "H");
                yield return new OrchardSprays(49, 8, 1, 7, "B");
                yield return new OrchardSprays(50, 72, 2, 7, "G");
                yield return new OrchardSprays(51, 13, 3, 7, "C");
                yield return new OrchardSprays(52, 57, 4, 7, "F");
                yield return new OrchardSprays(53, 4, 5, 7, "A");
                yield return new OrchardSprays(54, 81, 6, 7, "H");
                yield return new OrchardSprays(55, 20, 7, 7, "D");
                yield return new OrchardSprays(56, 61, 8, 7, "E");
                yield return new OrchardSprays(57, 80, 1, 8, "G");
                yield return new OrchardSprays(58, 114, 2, 8, "F");
                yield return new OrchardSprays(59, 39, 3, 8, "D");
                yield return new OrchardSprays(60, 14, 4, 8, "B");
                yield return new OrchardSprays(61, 86, 5, 8, "H");
                yield return new OrchardSprays(62, 55, 6, 8, "E");
                yield return new OrchardSprays(63, 3, 7, 8, "A");
                yield return new OrchardSprays(64, 19, 8, 8, "C");
            }
        }
    }
}
