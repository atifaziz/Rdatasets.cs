// ReSharper disable All

namespace Rdatasets.DAAG
{
    using System.Collections.Generic;

    /// <summary>
    /// Elastic Band Data
    /// </summary>

    public class elasticband
    {
        public readonly int κ;
        public readonly int stretch;
        public readonly int distance;

        public elasticband(int κ, int stretch, int distance)
        {
            this.κ = κ;
            this.stretch = stretch;
            this.distance = distance;
        }

        public static IEnumerable<elasticband> Data
        {
            get
            {
                yield return new elasticband(1, 46, 148);
                yield return new elasticband(2, 54, 182);
                yield return new elasticband(3, 48, 173);
                yield return new elasticband(4, 50, 166);
                yield return new elasticband(5, 44, 109);
                yield return new elasticband(6, 42, 141);
                yield return new elasticband(7, 52, 166);
            }
        }
    }
}
