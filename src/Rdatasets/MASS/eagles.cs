// ReSharper disable All

namespace Rdatasets.MASS
{
    using System.Collections.Generic;

    /// <summary>
    /// Foraging Ecology of Bald Eagles
    /// </summary>

    public class eagles
    {
        public readonly int y;
        public readonly int n;
        public readonly string P;
        public readonly string A;
        public readonly string V;

        public eagles(int y, int n, string P, string A, string V)
        {
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
                yield return new eagles(17, 24, "L", "A", "L");
                yield return new eagles(29, 29, "L", "A", "S");
                yield return new eagles(17, 27, "L", "I", "L");
                yield return new eagles(20, 20, "L", "I", "S");
                yield return new eagles(1, 12, "S", "A", "L");
                yield return new eagles(15, 16, "S", "A", "S");
                yield return new eagles(0, 28, "S", "I", "L");
                yield return new eagles(1, 4, "S", "I", "S");
            }
        }
    }
}
