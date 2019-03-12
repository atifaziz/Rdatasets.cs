// ReSharper disable All

namespace Rdatasets.DAAG
{
    using System.Collections.Generic;

    /// <summary>
    /// Elastic Band Data Replicated
    /// </summary>

    public class elastic1
    {
        public readonly int κ;
        public readonly int stretch;
        public readonly int distance;

        public elastic1(int κ, int stretch, int distance)
        {
            this.κ = κ;
            this.stretch = stretch;
            this.distance = distance;
        }

        public static IEnumerable<elastic1> Data
        {
            get
            {
                yield return new elastic1(1, 46, 183);
                yield return new elastic1(2, 54, 217);
                yield return new elastic1(3, 48, 189);
                yield return new elastic1(4, 50, 208);
                yield return new elastic1(5, 44, 178);
                yield return new elastic1(6, 42, 150);
                yield return new elastic1(7, 52, 249);
            }
        }
    }
}
