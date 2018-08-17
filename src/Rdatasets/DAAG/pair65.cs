// ReSharper disable All

namespace Rdatasets.DAAG
{
    using System.Collections.Generic;

    /// <summary>
    /// Heated Elastic Bands
    /// </summary>

    public class pair65
    {
        public readonly int heated;
        public readonly int ambient;

        public pair65(int heated, int ambient)
        {
            this.heated = heated;
            this.ambient = ambient;
        }

        public static IEnumerable<pair65> Data
        {
            get
            {
                yield return new pair65(244, 225);
                yield return new pair65(255, 247);
                yield return new pair65(253, 249);
                yield return new pair65(254, 253);
                yield return new pair65(251, 245);
                yield return new pair65(269, 259);
                yield return new pair65(248, 242);
                yield return new pair65(252, 255);
                yield return new pair65(292, 286);
            }
        }
    }
}
