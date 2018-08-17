// ReSharper disable All

namespace Rdatasets.boot
{
    using System.Collections.Generic;

    /// <summary>
    /// Population of U.S. Cities
    /// </summary>

    public class city
    {
        public readonly int u;
        public readonly int x;

        public city(int u, int x)
        {
            this.u = u;
            this.x = x;
        }

        public static IEnumerable<city> Data
        {
            get
            {
                yield return new city(138, 143);
                yield return new city(93, 104);
                yield return new city(61, 69);
                yield return new city(179, 260);
                yield return new city(48, 75);
                yield return new city(37, 63);
                yield return new city(29, 50);
                yield return new city(23, 48);
                yield return new city(30, 111);
                yield return new city(2, 50);
            }
        }
    }
}
