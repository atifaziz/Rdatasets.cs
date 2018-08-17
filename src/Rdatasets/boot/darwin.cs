// ReSharper disable All

namespace Rdatasets.boot
{
    using System.Collections.Generic;

    /// <summary>
    /// Darwin's Plant Height Differences
    /// </summary>

    public class darwin
    {
        public readonly int y;

        public darwin(int y)
        {
            this.y = y;
        }

        public static IEnumerable<darwin> Data
        {
            get
            {
                yield return new darwin(49);
                yield return new darwin(-67);
                yield return new darwin(8);
                yield return new darwin(16);
                yield return new darwin(6);
                yield return new darwin(23);
                yield return new darwin(28);
                yield return new darwin(41);
                yield return new darwin(14);
                yield return new darwin(29);
                yield return new darwin(56);
                yield return new darwin(24);
                yield return new darwin(75);
                yield return new darwin(60);
                yield return new darwin(-48);
            }
        }
    }
}
