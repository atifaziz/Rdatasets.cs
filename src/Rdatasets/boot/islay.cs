// ReSharper disable All

namespace Rdatasets.boot
{
    using System.Collections.Generic;

    /// <summary>
    /// Jura Quartzite Azimuths on Islay
    /// </summary>

    public class islay
    {
        public readonly int theta;

        public islay(int theta)
        {
            this.theta = theta;
        }

        public static IEnumerable<islay> Data
        {
            get
            {
                yield return new islay(12);
                yield return new islay(353);
                yield return new islay(359);
                yield return new islay(332);
                yield return new islay(341);
                yield return new islay(299);
                yield return new islay(30);
                yield return new islay(24);
                yield return new islay(53);
                yield return new islay(284);
                yield return new islay(99);
                yield return new islay(72);
                yield return new islay(28);
                yield return new islay(93);
                yield return new islay(125);
                yield return new islay(318);
                yield return new islay(3);
                yield return new islay(45);
            }
        }
    }
}
