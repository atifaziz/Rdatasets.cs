// ReSharper disable All

namespace Rdatasets.boot
{
    using System.Collections.Generic;

    /// <summary>
    /// Population of U.S. Cities
    /// </summary>

    public class city
    {
        public readonly int κ;
        public readonly int u;
        public readonly int x;

        public city(int κ, int u, int x)
        {
            this.κ = κ;
            this.u = u;
            this.x = x;
        }

        public static IEnumerable<city> Data
        {
            get
            {
                yield return new city(1, 138, 143);
                yield return new city(2, 93, 104);
                yield return new city(3, 61, 69);
                yield return new city(4, 179, 260);
                yield return new city(5, 48, 75);
                yield return new city(6, 37, 63);
                yield return new city(7, 29, 50);
                yield return new city(8, 23, 48);
                yield return new city(9, 30, 111);
                yield return new city(10, 2, 50);
            }
        }
    }
}
