// ReSharper disable All

namespace Rdatasets.cluster
{
    using System.Collections.Generic;

    /// <summary>
    /// European Union Agricultural Workforces
    /// </summary>

    public class agriculture
    {
        public readonly string κ;
        public readonly double x;
        public readonly double y;

        public agriculture(string κ, double x, double y)
        {
            this.κ = κ;
            this.x = x;
            this.y = y;
        }

        public static IEnumerable<agriculture> Data
        {
            get
            {
                yield return new agriculture("B", 16.8, 2.7);
                yield return new agriculture("DK", 21.3, 5.7);
                yield return new agriculture("D", 18.7, 3.5);
                yield return new agriculture("GR", 5.9, 22.2);
                yield return new agriculture("E", 11.4, 10.9);
                yield return new agriculture("F", 17.8, 6);
                yield return new agriculture("IRL", 10.9, 14);
                yield return new agriculture("I", 16.6, 8.5);
                yield return new agriculture("L", 21, 3.5);
                yield return new agriculture("NL", 16.4, 4.3);
                yield return new agriculture("P", 7.8, 17.4);
                yield return new agriculture("UK", 14, 2.3);
            }
        }
    }
}
