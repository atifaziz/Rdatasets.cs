// ReSharper disable All

namespace Rdatasets.boot
{
    using System.Collections.Generic;

    /// <summary>
    /// Genetic Links to Left-handedness
    /// </summary>

    public class claridge
    {
        public readonly int dnan;
        public readonly int hand;

        public claridge(int dnan, int hand)
        {
            this.dnan = dnan;
            this.hand = hand;
        }

        public static IEnumerable<claridge> Data
        {
            get
            {
                yield return new claridge(13, 1);
                yield return new claridge(18, 1);
                yield return new claridge(20, 3);
                yield return new claridge(21, 1);
                yield return new claridge(21, 1);
                yield return new claridge(24, 1);
                yield return new claridge(24, 1);
                yield return new claridge(27, 1);
                yield return new claridge(28, 1);
                yield return new claridge(28, 2);
                yield return new claridge(28, 1);
                yield return new claridge(28, 2);
                yield return new claridge(28, 1);
                yield return new claridge(28, 4);
                yield return new claridge(28, 1);
                yield return new claridge(28, 1);
                yield return new claridge(29, 1);
                yield return new claridge(29, 1);
                yield return new claridge(29, 1);
                yield return new claridge(29, 2);
                yield return new claridge(29, 2);
                yield return new claridge(29, 1);
                yield return new claridge(29, 1);
                yield return new claridge(30, 1);
                yield return new claridge(30, 1);
                yield return new claridge(30, 2);
                yield return new claridge(30, 1);
                yield return new claridge(31, 1);
                yield return new claridge(31, 1);
                yield return new claridge(31, 1);
                yield return new claridge(31, 1);
                yield return new claridge(31, 2);
                yield return new claridge(33, 6);
                yield return new claridge(33, 1);
                yield return new claridge(34, 1);
                yield return new claridge(41, 4);
                yield return new claridge(44, 8);
            }
        }
    }
}
