// ReSharper disable All

namespace Rdatasets.boot
{
    using System.Collections.Generic;

    /// <summary>
    /// Darwin's Plant Height Differences
    /// </summary>

    public class darwin
    {
        public readonly int κ;
        public readonly int y;

        public darwin(int κ, int y)
        {
            this.κ = κ;
            this.y = y;
        }

        public static IEnumerable<darwin> Data
        {
            get
            {
                yield return new darwin(1, 49);
                yield return new darwin(2, -67);
                yield return new darwin(3, 8);
                yield return new darwin(4, 16);
                yield return new darwin(5, 6);
                yield return new darwin(6, 23);
                yield return new darwin(7, 28);
                yield return new darwin(8, 41);
                yield return new darwin(9, 14);
                yield return new darwin(10, 29);
                yield return new darwin(11, 56);
                yield return new darwin(12, 24);
                yield return new darwin(13, 75);
                yield return new darwin(14, 60);
                yield return new darwin(15, -48);
            }
        }
    }
}
