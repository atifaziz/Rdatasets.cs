// ReSharper disable All

namespace Rdatasets.robustbase
{
    using System.Collections.Generic;

    /// <summary>
    /// Aircraft Data
    /// </summary>

    public class aircraft
    {
        public readonly int κ;
        public readonly double X1;
        public readonly double X2;
        public readonly int X3;
        public readonly int X4;
        public readonly double Y;

        public aircraft(int κ, double X1, double X2, int X3, int X4, double Y)
        {
            this.κ = κ;
            this.X1 = X1;
            this.X2 = X2;
            this.X3 = X3;
            this.X4 = X4;
            this.Y = Y;
        }

        public static IEnumerable<aircraft> Data
        {
            get
            {
                yield return new aircraft(1, 6.3, 1.7, 8176, 4500, 2.76);
                yield return new aircraft(2, 6, 1.9, 6699, 3120, 4.76);
                yield return new aircraft(3, 5.9, 1.5, 9663, 6300, 8.75);
                yield return new aircraft(4, 3, 1.2, 12837, 9800, 7.78);
                yield return new aircraft(5, 5, 1.8, 10205, 4900, 6.18);
                yield return new aircraft(6, 6.3, 2, 14890, 6500, 9.5);
                yield return new aircraft(7, 5.6, 1.6, 13836, 8920, 5.14);
                yield return new aircraft(8, 3.6, 1.2, 11628, 14500, 4.76);
                yield return new aircraft(9, 2, 1.4, 15225, 14800, 16.7);
                yield return new aircraft(10, 2.9, 2.3, 18691, 10900, 27.68);
                yield return new aircraft(11, 2.2, 1.9, 19350, 16000, 26.64);
                yield return new aircraft(12, 3.9, 2.6, 20638, 16000, 13.71);
                yield return new aircraft(13, 4.5, 2, 12843, 7800, 12.31);
                yield return new aircraft(14, 4.3, 9.7, 13384, 17900, 15.73);
                yield return new aircraft(15, 4, 2.9, 13307, 10500, 13.59);
                yield return new aircraft(16, 3.2, 4.3, 29855, 24500, 51.9);
                yield return new aircraft(17, 4.3, 4.3, 29277, 30000, 20.78);
                yield return new aircraft(18, 2.4, 2.6, 24651, 24500, 29.82);
                yield return new aircraft(19, 2.8, 3.7, 28539, 34000, 32.78);
                yield return new aircraft(20, 3.9, 3.3, 8085, 8160, 10.12);
                yield return new aircraft(21, 2.8, 3.9, 30328, 35800, 27.84);
                yield return new aircraft(22, 1.6, 4.1, 46172, 37000, 107.1);
                yield return new aircraft(23, 3.4, 2.5, 17836, 19600, 11.19);
            }
        }
    }
}
