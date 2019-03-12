// ReSharper disable All

namespace Rdatasets.boot
{
    using System.Collections.Generic;

    /// <summary>
    /// Jura Quartzite Azimuths on Islay
    /// </summary>

    public class islay
    {
        public readonly int κ;
        public readonly int theta;

        public islay(int κ, int theta)
        {
            this.κ = κ;
            this.theta = theta;
        }

        public static IEnumerable<islay> Data
        {
            get
            {
                yield return new islay(1, 12);
                yield return new islay(2, 353);
                yield return new islay(3, 359);
                yield return new islay(4, 332);
                yield return new islay(5, 341);
                yield return new islay(6, 299);
                yield return new islay(7, 30);
                yield return new islay(8, 24);
                yield return new islay(9, 53);
                yield return new islay(10, 284);
                yield return new islay(11, 99);
                yield return new islay(12, 72);
                yield return new islay(13, 28);
                yield return new islay(14, 93);
                yield return new islay(15, 125);
                yield return new islay(16, 318);
                yield return new islay(17, 3);
                yield return new islay(18, 45);
            }
        }
    }
}
