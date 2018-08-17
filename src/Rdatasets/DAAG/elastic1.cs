// ReSharper disable All

namespace Rdatasets.DAAG
{
    using System.Collections.Generic;

    /// <summary>
    /// Elastic Band Data Replicated
    /// </summary>

    public class elastic1
    {
        public readonly int stretch;
        public readonly int distance;

        public elastic1(int stretch, int distance)
        {
            this.stretch = stretch;
            this.distance = distance;
        }

        public static IEnumerable<elastic1> Data
        {
            get
            {
                yield return new elastic1(46, 183);
                yield return new elastic1(54, 217);
                yield return new elastic1(48, 189);
                yield return new elastic1(50, 208);
                yield return new elastic1(44, 178);
                yield return new elastic1(42, 150);
                yield return new elastic1(52, 249);
            }
        }
    }
}
