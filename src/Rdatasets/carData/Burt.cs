// ReSharper disable All

namespace Rdatasets.carData
{
    using System.Collections.Generic;

    /// <summary>
    /// Fraudulent Data on IQs of Twins Raised Apart
    /// </summary>

    public class Burt
    {
        public readonly int IQbio;
        public readonly int IQfoster;
        public readonly string @class;

        public Burt(int IQbio, int IQfoster, string @class)
        {
            this.IQbio = IQbio;
            this.IQfoster = IQfoster;
            this.@class = @class;
        }

        public static IEnumerable<Burt> Data
        {
            get
            {
                yield return new Burt(82, 82, "high");
                yield return new Burt(80, 90, "high");
                yield return new Burt(88, 91, "high");
                yield return new Burt(108, 115, "high");
                yield return new Burt(116, 115, "high");
                yield return new Burt(117, 129, "high");
                yield return new Burt(132, 131, "high");
                yield return new Burt(71, 78, "medium");
                yield return new Burt(75, 79, "medium");
                yield return new Burt(93, 82, "medium");
                yield return new Burt(95, 97, "medium");
                yield return new Burt(88, 100, "medium");
                yield return new Burt(111, 107, "medium");
                yield return new Burt(63, 68, "low");
                yield return new Burt(77, 73, "low");
                yield return new Burt(86, 81, "low");
                yield return new Burt(83, 85, "low");
                yield return new Burt(93, 87, "low");
                yield return new Burt(97, 87, "low");
                yield return new Burt(87, 93, "low");
                yield return new Burt(94, 94, "low");
                yield return new Burt(96, 95, "low");
                yield return new Burt(112, 97, "low");
                yield return new Burt(113, 97, "low");
                yield return new Burt(106, 103, "low");
                yield return new Burt(107, 106, "low");
                yield return new Burt(98, 111, "low");
            }
        }
    }
}
