// ReSharper disable All

namespace Rdatasets.DAAG
{
    using System.Collections.Generic;

    /// <summary>
    /// Elastic Band Data Replicated Again
    /// </summary>

    public class elastic2
    {
        public readonly int κ;
        public readonly int stretch;
        public readonly int distance;

        public elastic2(int κ, int stretch, int distance)
        {
            this.κ = κ;
            this.stretch = stretch;
            this.distance = distance;
        }

        public static IEnumerable<elastic2> Data
        {
            get
            {
                yield return new elastic2(1, 30, 71);
                yield return new elastic2(2, 50, 196);
                yield return new elastic2(3, 40, 127);
                yield return new elastic2(4, 45, 187);
                yield return new elastic2(5, 60, 249);
                yield return new elastic2(6, 55, 217);
                yield return new elastic2(7, 35, 114);
                yield return new elastic2(8, 55, 228);
                yield return new elastic2(9, 65, 291);
            }
        }
    }
}
