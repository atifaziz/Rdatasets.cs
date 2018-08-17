// ReSharper disable All

namespace Rdatasets.MASS
{
    using System.Collections.Generic;

    /// <summary>
    /// Accelerated Life Testing of Motorettes
    /// </summary>

    public class motors
    {
        public readonly int temp;
        public readonly int time;
        public readonly int cens;

        public motors(int temp, int time, int cens)
        {
            this.temp = temp;
            this.time = time;
            this.cens = cens;
        }

        public static IEnumerable<motors> Data
        {
            get
            {
                yield return new motors(150, 8064, 0);
                yield return new motors(150, 8064, 0);
                yield return new motors(150, 8064, 0);
                yield return new motors(150, 8064, 0);
                yield return new motors(150, 8064, 0);
                yield return new motors(150, 8064, 0);
                yield return new motors(150, 8064, 0);
                yield return new motors(150, 8064, 0);
                yield return new motors(150, 8064, 0);
                yield return new motors(150, 8064, 0);
                yield return new motors(170, 1764, 1);
                yield return new motors(170, 2772, 1);
                yield return new motors(170, 3444, 1);
                yield return new motors(170, 3542, 1);
                yield return new motors(170, 3780, 1);
                yield return new motors(170, 4860, 1);
                yield return new motors(170, 5196, 1);
                yield return new motors(170, 5448, 0);
                yield return new motors(170, 5448, 0);
                yield return new motors(170, 5448, 0);
                yield return new motors(190, 408, 1);
                yield return new motors(190, 408, 1);
                yield return new motors(190, 1344, 1);
                yield return new motors(190, 1344, 1);
                yield return new motors(190, 1440, 1);
                yield return new motors(190, 1680, 0);
                yield return new motors(190, 1680, 0);
                yield return new motors(190, 1680, 0);
                yield return new motors(190, 1680, 0);
                yield return new motors(190, 1680, 0);
                yield return new motors(220, 408, 1);
                yield return new motors(220, 408, 1);
                yield return new motors(220, 504, 1);
                yield return new motors(220, 504, 1);
                yield return new motors(220, 504, 1);
                yield return new motors(220, 528, 0);
                yield return new motors(220, 528, 0);
                yield return new motors(220, 528, 0);
                yield return new motors(220, 528, 0);
                yield return new motors(220, 528, 0);
            }
        }
    }
}
