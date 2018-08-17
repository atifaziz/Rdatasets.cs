// ReSharper disable All

namespace Rdatasets.cluster
{
    using System.Collections.Generic;

    /// <summary>
    /// European Union Agricultural Workforces
    /// </summary>

    public class agriculture
    {
        public readonly double x;
        public readonly double y;

        public agriculture(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        public static IEnumerable<agriculture> Data
        {
            get
            {
                yield return new agriculture(16.8, 2.7);
                yield return new agriculture(21.3, 5.7);
                yield return new agriculture(18.7, 3.5);
                yield return new agriculture(5.9, 22.2);
                yield return new agriculture(11.4, 10.9);
                yield return new agriculture(17.8, 6);
                yield return new agriculture(10.9, 14);
                yield return new agriculture(16.6, 8.5);
                yield return new agriculture(21, 3.5);
                yield return new agriculture(16.4, 4.3);
                yield return new agriculture(7.8, 17.4);
                yield return new agriculture(14, 2.3);
            }
        }
    }
}
