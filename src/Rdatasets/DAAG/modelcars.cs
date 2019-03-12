// ReSharper disable All

namespace Rdatasets.DAAG
{
    using System.Collections.Generic;

    /// <summary>
    /// Model Car Data
    /// </summary>

    public class modelcars
    {
        public readonly int κ;
        public readonly double distance_traveled;
        public readonly int starting_point;

        public modelcars(int κ, double distance_traveled, int starting_point)
        {
            this.κ = κ;
            this.distance_traveled = distance_traveled;
            this.starting_point = starting_point;
        }

        public static IEnumerable<modelcars> Data
        {
            get
            {
                yield return new modelcars(241, 31.375, 12);
                yield return new modelcars(242, 30.375, 12);
                yield return new modelcars(243, 33.625, 12);
                yield return new modelcars(244, 26.625, 9);
                yield return new modelcars(245, 25.75, 9);
                yield return new modelcars(246, 27.125, 9);
                yield return new modelcars(247, 18.75, 6);
                yield return new modelcars(248, 22.5, 6);
                yield return new modelcars(249, 21.625, 6);
                yield return new modelcars(250, 13.875, 3);
                yield return new modelcars(251, 11.75, 3);
                yield return new modelcars(252, 14.875, 3);
            }
        }
    }
}
