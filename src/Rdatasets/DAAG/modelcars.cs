// ReSharper disable All

namespace Rdatasets.DAAG
{
    using System.Collections.Generic;

    /// <summary>
    /// Model Car Data
    /// </summary>

    public class modelcars
    {
        public readonly double distance_traveled;
        public readonly int starting_point;

        public modelcars(double distance_traveled, int starting_point)
        {
            this.distance_traveled = distance_traveled;
            this.starting_point = starting_point;
        }

        public static IEnumerable<modelcars> Data
        {
            get
            {
                yield return new modelcars(31.375, 12);
                yield return new modelcars(30.375, 12);
                yield return new modelcars(33.625, 12);
                yield return new modelcars(26.625, 9);
                yield return new modelcars(25.75, 9);
                yield return new modelcars(27.125, 9);
                yield return new modelcars(18.75, 6);
                yield return new modelcars(22.5, 6);
                yield return new modelcars(21.625, 6);
                yield return new modelcars(13.875, 3);
                yield return new modelcars(11.75, 3);
                yield return new modelcars(14.875, 3);
            }
        }
    }
}
