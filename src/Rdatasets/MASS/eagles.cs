// ReSharper disable All

namespace Rdatasets.MASS
{
    using System.Collections.Generic;

    /// <summary>
    /// Foraging Ecology of Bald Eagles
    /// </summary>

    public class eagles
    {
        public readonly int κ;
        public readonly int y;
        public readonly int n;
        public readonly string P;
        public readonly string A;
        public readonly string V;

        public eagles(int κ, int y, int n, string P, string A, string V)
        {
            this.κ = κ;
            this.y = y;
            this.n = n;
            this.P = P;
            this.A = A;
            this.V = V;
        }

        public static IEnumerable<eagles> Data
        {
            get
            {
                yield return new eagles(1, 17, 24, "L", "A", "L");
                yield return new eagles(2, 29, 29, "L", "A", "S");
                yield return new eagles(3, 17, 27, "L", "I", "L");
                yield return new eagles(4, 20, 20, "L", "I", "S");
                yield return new eagles(5, 1, 12, "S", "A", "L");
                yield return new eagles(6, 15, 16, "S", "A", "S");
                yield return new eagles(7, 0, 28, "S", "I", "L");
                yield return new eagles(8, 1, 4, "S", "I", "S");
            }
        }
    }
}
