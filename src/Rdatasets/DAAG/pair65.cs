// ReSharper disable All

namespace Rdatasets.DAAG
{
    using System.Collections.Generic;

    /// <summary>
    /// Heated Elastic Bands
    /// </summary>

    public class pair65
    {
        public readonly int κ;
        public readonly int heated;
        public readonly int ambient;

        public pair65(int κ, int heated, int ambient)
        {
            this.κ = κ;
            this.heated = heated;
            this.ambient = ambient;
        }

        public static IEnumerable<pair65> Data
        {
            get
            {
                yield return new pair65(1, 244, 225);
                yield return new pair65(2, 255, 247);
                yield return new pair65(3, 253, 249);
                yield return new pair65(4, 254, 253);
                yield return new pair65(5, 251, 245);
                yield return new pair65(6, 269, 259);
                yield return new pair65(7, 248, 242);
                yield return new pair65(8, 252, 255);
                yield return new pair65(9, 292, 286);
            }
        }
    }
}
