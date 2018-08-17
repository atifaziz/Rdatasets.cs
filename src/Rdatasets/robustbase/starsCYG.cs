// ReSharper disable All

namespace Rdatasets.robustbase
{
    using System.Collections.Generic;

    /// <summary>
    /// Hertzsprung-Russell Diagram Data of Star Cluster CYG OB1
    /// </summary>

    public class starsCYG
    {
        public readonly double log_Te;
        public readonly double log_light;

        public starsCYG(double log_Te, double log_light)
        {
            this.log_Te = log_Te;
            this.log_light = log_light;
        }

        public static IEnumerable<starsCYG> Data
        {
            get
            {
                yield return new starsCYG(4.37, 5.23);
                yield return new starsCYG(4.56, 5.74);
                yield return new starsCYG(4.26, 4.93);
                yield return new starsCYG(4.56, 5.74);
                yield return new starsCYG(4.3, 5.19);
                yield return new starsCYG(4.46, 5.46);
                yield return new starsCYG(3.84, 4.65);
                yield return new starsCYG(4.57, 5.27);
                yield return new starsCYG(4.26, 5.57);
                yield return new starsCYG(4.37, 5.12);
                yield return new starsCYG(3.49, 5.73);
                yield return new starsCYG(4.43, 5.45);
                yield return new starsCYG(4.48, 5.42);
                yield return new starsCYG(4.01, 4.05);
                yield return new starsCYG(4.29, 4.26);
                yield return new starsCYG(4.42, 4.58);
                yield return new starsCYG(4.23, 3.94);
                yield return new starsCYG(4.42, 4.18);
                yield return new starsCYG(4.23, 4.18);
                yield return new starsCYG(3.49, 5.89);
                yield return new starsCYG(4.29, 4.38);
                yield return new starsCYG(4.29, 4.22);
                yield return new starsCYG(4.42, 4.42);
                yield return new starsCYG(4.49, 4.85);
                yield return new starsCYG(4.38, 5.02);
                yield return new starsCYG(4.42, 4.66);
                yield return new starsCYG(4.29, 4.66);
                yield return new starsCYG(4.38, 4.9);
                yield return new starsCYG(4.22, 4.39);
                yield return new starsCYG(3.48, 6.05);
                yield return new starsCYG(4.38, 4.42);
                yield return new starsCYG(4.56, 5.1);
                yield return new starsCYG(4.45, 5.22);
                yield return new starsCYG(3.49, 6.29);
                yield return new starsCYG(4.23, 4.34);
                yield return new starsCYG(4.62, 5.62);
                yield return new starsCYG(4.53, 5.1);
                yield return new starsCYG(4.45, 5.22);
                yield return new starsCYG(4.53, 5.18);
                yield return new starsCYG(4.43, 5.57);
                yield return new starsCYG(4.38, 4.62);
                yield return new starsCYG(4.45, 5.06);
                yield return new starsCYG(4.5, 5.34);
                yield return new starsCYG(4.45, 5.34);
                yield return new starsCYG(4.55, 5.54);
                yield return new starsCYG(4.45, 4.98);
                yield return new starsCYG(4.42, 4.5);
            }
        }
    }
}
