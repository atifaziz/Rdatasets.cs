// ReSharper disable All

namespace Rdatasets.robustbase
{
    using System.Collections.Generic;

    /// <summary>
    /// Pilot-Plant Data
    /// </summary>

    public class pilot
    {
        public readonly int κ;
        public readonly int X;
        public readonly int Y;

        public pilot(int κ, int X, int Y)
        {
            this.κ = κ;
            this.X = X;
            this.Y = Y;
        }

        public static IEnumerable<pilot> Data
        {
            get
            {
                yield return new pilot(1, 123, 76);
                yield return new pilot(2, 109, 70);
                yield return new pilot(3, 62, 55);
                yield return new pilot(4, 104, 71);
                yield return new pilot(5, 57, 55);
                yield return new pilot(6, 37, 48);
                yield return new pilot(7, 44, 50);
                yield return new pilot(8, 100, 66);
                yield return new pilot(9, 16, 41);
                yield return new pilot(10, 28, 43);
                yield return new pilot(11, 138, 82);
                yield return new pilot(12, 105, 68);
                yield return new pilot(13, 159, 88);
                yield return new pilot(14, 75, 58);
                yield return new pilot(15, 88, 64);
                yield return new pilot(16, 164, 88);
                yield return new pilot(17, 169, 89);
                yield return new pilot(18, 167, 88);
                yield return new pilot(19, 149, 84);
                yield return new pilot(20, 167, 88);
            }
        }
    }
}
