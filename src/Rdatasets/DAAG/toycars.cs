// ReSharper disable All

namespace Rdatasets.DAAG
{
    using System.Collections.Generic;

    /// <summary>
    /// Toy Cars Data
    /// </summary>

    public class toycars
    {
        public readonly int κ;
        public readonly double angle;
        public readonly double distance;
        public readonly int car;

        public toycars(int κ, double angle, double distance, int car)
        {
            this.κ = κ;
            this.angle = angle;
            this.distance = distance;
            this.car = car;
        }

        public static IEnumerable<toycars> Data
        {
            get
            {
                yield return new toycars(1, 1.3, 0.43, 1);
                yield return new toycars(2, 1.3, 0.37, 2);
                yield return new toycars(3, 1.3, 0.27, 3);
                yield return new toycars(4, 4, 0.84, 1);
                yield return new toycars(5, 4, 0.92, 2);
                yield return new toycars(6, 4, 0.69, 3);
                yield return new toycars(7, 2.7, 0.58, 1);
                yield return new toycars(8, 2.7, 0.64, 2);
                yield return new toycars(9, 2.7, 0.55, 3);
                yield return new toycars(10, 2.2, 0.58, 1);
                yield return new toycars(11, 2.2, 0.7, 2);
                yield return new toycars(12, 2.2, 0.54, 3);
                yield return new toycars(13, 3.6, 0.7, 1);
                yield return new toycars(14, 3.6, 0.89, 2);
                yield return new toycars(15, 3.6, 0.66, 3);
                yield return new toycars(16, 4.9, 1, 1);
                yield return new toycars(17, 4.9, 1.3, 2);
                yield return new toycars(18, 4.9, 0.95, 3);
                yield return new toycars(19, 0.9, 0.27, 1);
                yield return new toycars(20, 0.9, 0.38, 2);
                yield return new toycars(21, 0.9, 0.15, 3);
                yield return new toycars(22, 1.1, 0.29, 1);
                yield return new toycars(23, 1.1, 0.43, 2);
                yield return new toycars(24, 1.1, 0.17, 3);
                yield return new toycars(25, 3.1, 0.63, 1);
                yield return new toycars(26, 3.1, 0.69, 2);
                yield return new toycars(27, 3.1, 0.6, 3);
            }
        }
    }
}
