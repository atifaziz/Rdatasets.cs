// ReSharper disable All

namespace Rdatasets.DAAG
{
    using System.Collections.Generic;

    /// <summary>
    /// Elastic Band Data
    /// </summary>

    public class elasticband
    {
        public readonly int stretch;
        public readonly int distance;

        public elasticband(int stretch, int distance)
        {
            this.stretch = stretch;
            this.distance = distance;
        }

        public static IEnumerable<elasticband> Data
        {
            get
            {
                yield return new elasticband(46, 148);
                yield return new elasticband(54, 182);
                yield return new elasticband(48, 173);
                yield return new elasticband(50, 166);
                yield return new elasticband(44, 109);
                yield return new elasticband(42, 141);
                yield return new elasticband(52, 166);
            }
        }
    }
}
