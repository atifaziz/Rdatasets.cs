// ReSharper disable All

namespace Rdatasets.robustbase
{
    using System.Collections.Generic;

    /// <summary>
    /// Pilot-Plant Data
    /// </summary>

    public class pilot
    {
        public readonly int X;
        public readonly int Y;

        public pilot(int X, int Y)
        {
            this.X = X;
            this.Y = Y;
        }

        public static IEnumerable<pilot> Data
        {
            get
            {
                yield return new pilot(123, 76);
                yield return new pilot(109, 70);
                yield return new pilot(62, 55);
                yield return new pilot(104, 71);
                yield return new pilot(57, 55);
                yield return new pilot(37, 48);
                yield return new pilot(44, 50);
                yield return new pilot(100, 66);
                yield return new pilot(16, 41);
                yield return new pilot(28, 43);
                yield return new pilot(138, 82);
                yield return new pilot(105, 68);
                yield return new pilot(159, 88);
                yield return new pilot(75, 58);
                yield return new pilot(88, 64);
                yield return new pilot(164, 88);
                yield return new pilot(169, 89);
                yield return new pilot(167, 88);
                yield return new pilot(149, 84);
                yield return new pilot(167, 88);
            }
        }
    }
}
