// ReSharper disable All

namespace Rdatasets.drc
{
    using System.Collections.Generic;

    /// <summary>
    /// Heart rate baroreflexes for rabbits
    /// </summary>

    public class heartrate
    {
        public readonly double pressure;
        public readonly double rate;

        public heartrate(double pressure, double rate)
        {
            this.pressure = pressure;
            this.rate = rate;
        }

        public static IEnumerable<heartrate> Data
        {
            get
            {
                yield return new heartrate(50.85, 348.76);
                yield return new heartrate(54.92, 344.45);
                yield return new heartrate(59.23, 343.05);
                yield return new heartrate(61.91, 332.92);
                yield return new heartrate(65.22, 315.31);
                yield return new heartrate(67.79, 313.5);
                yield return new heartrate(68.65, 301.4);
                yield return new heartrate(71.86, 295.29);
                yield return new heartrate(71.91, 292.66);
                yield return new heartrate(71.82, 292.16);
                yield return new heartrate(73.35, 271.72);
                yield return new heartrate(74.51, 268.07);
                yield return new heartrate(78.02, 211.26);
                yield return new heartrate(78.67, 169.93);
                yield return new heartrate(85.1, 158.21);
                yield return new heartrate(86.6, 148.53);
                yield return new heartrate(88.75, 149.07);
                yield return new heartrate(90.03, 149.68);
            }
        }
    }
}
