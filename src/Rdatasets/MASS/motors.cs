// ReSharper disable All

namespace Rdatasets.MASS
{
    using System.Collections.Generic;

    /// <summary>
    /// Accelerated Life Testing of Motorettes
    /// </summary>

    public class motors
    {
        public readonly int κ;
        public readonly int temp;
        public readonly int time;
        public readonly int cens;

        public motors(int κ, int temp, int time, int cens)
        {
            this.κ = κ;
            this.temp = temp;
            this.time = time;
            this.cens = cens;
        }

        public static IEnumerable<motors> Data
        {
            get
            {
                yield return new motors(1, 150, 8064, 0);
                yield return new motors(2, 150, 8064, 0);
                yield return new motors(3, 150, 8064, 0);
                yield return new motors(4, 150, 8064, 0);
                yield return new motors(5, 150, 8064, 0);
                yield return new motors(6, 150, 8064, 0);
                yield return new motors(7, 150, 8064, 0);
                yield return new motors(8, 150, 8064, 0);
                yield return new motors(9, 150, 8064, 0);
                yield return new motors(10, 150, 8064, 0);
                yield return new motors(11, 170, 1764, 1);
                yield return new motors(12, 170, 2772, 1);
                yield return new motors(13, 170, 3444, 1);
                yield return new motors(14, 170, 3542, 1);
                yield return new motors(15, 170, 3780, 1);
                yield return new motors(16, 170, 4860, 1);
                yield return new motors(17, 170, 5196, 1);
                yield return new motors(18, 170, 5448, 0);
                yield return new motors(19, 170, 5448, 0);
                yield return new motors(20, 170, 5448, 0);
                yield return new motors(21, 190, 408, 1);
                yield return new motors(22, 190, 408, 1);
                yield return new motors(23, 190, 1344, 1);
                yield return new motors(24, 190, 1344, 1);
                yield return new motors(25, 190, 1440, 1);
                yield return new motors(26, 190, 1680, 0);
                yield return new motors(27, 190, 1680, 0);
                yield return new motors(28, 190, 1680, 0);
                yield return new motors(29, 190, 1680, 0);
                yield return new motors(30, 190, 1680, 0);
                yield return new motors(31, 220, 408, 1);
                yield return new motors(32, 220, 408, 1);
                yield return new motors(33, 220, 504, 1);
                yield return new motors(34, 220, 504, 1);
                yield return new motors(35, 220, 504, 1);
                yield return new motors(36, 220, 528, 0);
                yield return new motors(37, 220, 528, 0);
                yield return new motors(38, 220, 528, 0);
                yield return new motors(39, 220, 528, 0);
                yield return new motors(40, 220, 528, 0);
            }
        }
    }
}
