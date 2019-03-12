// ReSharper disable All

namespace Rdatasets.datasets
{
    using System.Collections.Generic;

    /// <summary>
    /// Biochemical Oxygen Demand
    /// </summary>

    public class BOD
    {
        public readonly int κ;
        public readonly int Time;
        public readonly double demand;

        public BOD(int κ, int Time, double demand)
        {
            this.κ = κ;
            this.Time = Time;
            this.demand = demand;
        }

        public static IEnumerable<BOD> Data
        {
            get
            {
                yield return new BOD(1, 1, 8.3);
                yield return new BOD(2, 2, 10.3);
                yield return new BOD(3, 3, 19);
                yield return new BOD(4, 4, 16);
                yield return new BOD(5, 5, 15.6);
                yield return new BOD(6, 7, 19.8);
            }
        }
    }
}
