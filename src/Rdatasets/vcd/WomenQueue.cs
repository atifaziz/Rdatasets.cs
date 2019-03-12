// ReSharper disable All

namespace Rdatasets.vcd
{
    using System.Collections.Generic;

    /// <summary>
    /// Women in Queues
    /// </summary>

    public class WomenQueue
    {
        public readonly int κ;
        public readonly int nWomen;
        public readonly int Freq;

        public WomenQueue(int κ, int nWomen, int Freq)
        {
            this.κ = κ;
            this.nWomen = nWomen;
            this.Freq = Freq;
        }

        public static IEnumerable<WomenQueue> Data
        {
            get
            {
                yield return new WomenQueue(1, 0, 1);
                yield return new WomenQueue(2, 1, 3);
                yield return new WomenQueue(3, 2, 4);
                yield return new WomenQueue(4, 3, 23);
                yield return new WomenQueue(5, 4, 25);
                yield return new WomenQueue(6, 5, 19);
                yield return new WomenQueue(7, 6, 18);
                yield return new WomenQueue(8, 7, 5);
                yield return new WomenQueue(9, 8, 1);
                yield return new WomenQueue(10, 9, 1);
                yield return new WomenQueue(11, 10, 0);
            }
        }
    }
}
