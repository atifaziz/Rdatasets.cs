// ReSharper disable All

namespace Rdatasets.carData
{
    using System.Collections.Generic;

    /// <summary>
    /// Fraudulent Data on IQs of Twins Raised Apart
    /// </summary>

    public class Burt
    {
        public readonly int κ;
        public readonly int IQbio;
        public readonly int IQfoster;
        public readonly string @class;

        public Burt(int κ, int IQbio, int IQfoster, string @class)
        {
            this.κ = κ;
            this.IQbio = IQbio;
            this.IQfoster = IQfoster;
            this.@class = @class;
        }

        public static IEnumerable<Burt> Data
        {
            get
            {
                yield return new Burt(1, 82, 82, "high");
                yield return new Burt(2, 80, 90, "high");
                yield return new Burt(3, 88, 91, "high");
                yield return new Burt(4, 108, 115, "high");
                yield return new Burt(5, 116, 115, "high");
                yield return new Burt(6, 117, 129, "high");
                yield return new Burt(7, 132, 131, "high");
                yield return new Burt(8, 71, 78, "medium");
                yield return new Burt(9, 75, 79, "medium");
                yield return new Burt(10, 93, 82, "medium");
                yield return new Burt(11, 95, 97, "medium");
                yield return new Burt(12, 88, 100, "medium");
                yield return new Burt(13, 111, 107, "medium");
                yield return new Burt(14, 63, 68, "low");
                yield return new Burt(15, 77, 73, "low");
                yield return new Burt(16, 86, 81, "low");
                yield return new Burt(17, 83, 85, "low");
                yield return new Burt(18, 93, 87, "low");
                yield return new Burt(19, 97, 87, "low");
                yield return new Burt(20, 87, 93, "low");
                yield return new Burt(21, 94, 94, "low");
                yield return new Burt(22, 96, 95, "low");
                yield return new Burt(23, 112, 97, "low");
                yield return new Burt(24, 113, 97, "low");
                yield return new Burt(25, 106, 103, "low");
                yield return new Burt(26, 107, 106, "low");
                yield return new Burt(27, 98, 111, "low");
            }
        }
    }
}
