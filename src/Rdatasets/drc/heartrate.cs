// ReSharper disable All

namespace Rdatasets.drc
{
    using System.Collections.Generic;

    /// <summary>
    /// Heart rate baroreflexes for rabbits
    /// </summary>

    public class heartrate
    {
        public readonly int κ;
        public readonly double pressure;
        public readonly double rate;

        public heartrate(int κ, double pressure, double rate)
        {
            this.κ = κ;
            this.pressure = pressure;
            this.rate = rate;
        }

        public static IEnumerable<heartrate> Data
        {
            get
            {
                yield return new heartrate(1, 50.85, 348.76);
                yield return new heartrate(2, 54.92, 344.45);
                yield return new heartrate(3, 59.23, 343.05);
                yield return new heartrate(4, 61.91, 332.92);
                yield return new heartrate(5, 65.22, 315.31);
                yield return new heartrate(6, 67.79, 313.5);
                yield return new heartrate(7, 68.65, 301.4);
                yield return new heartrate(8, 71.86, 295.29);
                yield return new heartrate(9, 71.91, 292.66);
                yield return new heartrate(10, 71.82, 292.16);
                yield return new heartrate(11, 73.35, 271.72);
                yield return new heartrate(12, 74.51, 268.07);
                yield return new heartrate(13, 78.02, 211.26);
                yield return new heartrate(14, 78.67, 169.93);
                yield return new heartrate(15, 85.1, 158.21);
                yield return new heartrate(16, 86.6, 148.53);
                yield return new heartrate(17, 88.75, 149.07);
                yield return new heartrate(18, 90.03, 149.68);
            }
        }
    }
}
