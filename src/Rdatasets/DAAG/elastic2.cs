// ReSharper disable All

namespace Rdatasets.DAAG
{
    using System.Collections.Generic;

    /// <summary>
    /// Elastic Band Data Replicated Again
    /// </summary>

    public class elastic2
    {
        public readonly int stretch;
        public readonly int distance;

        public elastic2(int stretch, int distance)
        {
            this.stretch = stretch;
            this.distance = distance;
        }

        public static IEnumerable<elastic2> Data
        {
            get
            {
                yield return new elastic2(30, 71);
                yield return new elastic2(50, 196);
                yield return new elastic2(40, 127);
                yield return new elastic2(45, 187);
                yield return new elastic2(60, 249);
                yield return new elastic2(55, 217);
                yield return new elastic2(35, 114);
                yield return new elastic2(55, 228);
                yield return new elastic2(65, 291);
            }
        }
    }
}
