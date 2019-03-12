// ReSharper disable All

namespace Rdatasets.boot
{
    using System.Collections.Generic;

    /// <summary>
    /// Genetic Links to Left-handedness
    /// </summary>

    public class claridge
    {
        public readonly int κ;
        public readonly int dnan;
        public readonly int hand;

        public claridge(int κ, int dnan, int hand)
        {
            this.κ = κ;
            this.dnan = dnan;
            this.hand = hand;
        }

        public static IEnumerable<claridge> Data
        {
            get
            {
                yield return new claridge(1, 13, 1);
                yield return new claridge(2, 18, 1);
                yield return new claridge(3, 20, 3);
                yield return new claridge(4, 21, 1);
                yield return new claridge(5, 21, 1);
                yield return new claridge(6, 24, 1);
                yield return new claridge(7, 24, 1);
                yield return new claridge(8, 27, 1);
                yield return new claridge(9, 28, 1);
                yield return new claridge(10, 28, 2);
                yield return new claridge(11, 28, 1);
                yield return new claridge(12, 28, 2);
                yield return new claridge(13, 28, 1);
                yield return new claridge(14, 28, 4);
                yield return new claridge(15, 28, 1);
                yield return new claridge(16, 28, 1);
                yield return new claridge(17, 29, 1);
                yield return new claridge(18, 29, 1);
                yield return new claridge(19, 29, 1);
                yield return new claridge(20, 29, 2);
                yield return new claridge(21, 29, 2);
                yield return new claridge(22, 29, 1);
                yield return new claridge(23, 29, 1);
                yield return new claridge(24, 30, 1);
                yield return new claridge(25, 30, 1);
                yield return new claridge(26, 30, 2);
                yield return new claridge(27, 30, 1);
                yield return new claridge(28, 31, 1);
                yield return new claridge(29, 31, 1);
                yield return new claridge(30, 31, 1);
                yield return new claridge(31, 31, 1);
                yield return new claridge(32, 31, 2);
                yield return new claridge(33, 33, 6);
                yield return new claridge(34, 33, 1);
                yield return new claridge(35, 34, 1);
                yield return new claridge(36, 41, 4);
                yield return new claridge(37, 44, 8);
            }
        }
    }
}
