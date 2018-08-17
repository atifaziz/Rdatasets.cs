// ReSharper disable All

namespace Rdatasets.vcd
{
    using System.Collections.Generic;

    /// <summary>
    /// Women in Queues
    /// </summary>

    public class WomenQueue
    {
        public readonly int nWomen;
        public readonly int Freq;

        public WomenQueue(int nWomen, int Freq)
        {
            this.nWomen = nWomen;
            this.Freq = Freq;
        }

        public static IEnumerable<WomenQueue> Data
        {
            get
            {
                yield return new WomenQueue(0, 1);
                yield return new WomenQueue(1, 3);
                yield return new WomenQueue(2, 4);
                yield return new WomenQueue(3, 23);
                yield return new WomenQueue(4, 25);
                yield return new WomenQueue(5, 19);
                yield return new WomenQueue(6, 18);
                yield return new WomenQueue(7, 5);
                yield return new WomenQueue(8, 1);
                yield return new WomenQueue(9, 1);
                yield return new WomenQueue(10, 0);
            }
        }
    }
}
