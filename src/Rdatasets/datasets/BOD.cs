// ReSharper disable All

namespace Rdatasets.datasets
{
    using System.Collections.Generic;

    /// <summary>
    /// Biochemical Oxygen Demand
    /// </summary>

    public class BOD
    {
        public readonly int Time;
        public readonly double demand;

        public BOD(int Time, double demand)
        {
            this.Time = Time;
            this.demand = demand;
        }

        public static IEnumerable<BOD> Data
        {
            get
            {
                yield return new BOD(1, 8.3);
                yield return new BOD(2, 10.3);
                yield return new BOD(3, 19);
                yield return new BOD(4, 16);
                yield return new BOD(5, 15.6);
                yield return new BOD(7, 19.8);
            }
        }
    }
}
