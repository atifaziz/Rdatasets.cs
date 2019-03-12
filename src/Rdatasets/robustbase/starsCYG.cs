// ReSharper disable All

namespace Rdatasets.robustbase
{
    using System.Collections.Generic;

    /// <summary>
    /// Hertzsprung-Russell Diagram Data of Star Cluster CYG OB1
    /// </summary>

    public class starsCYG
    {
        public readonly int κ;
        public readonly double log_Te;
        public readonly double log_light;

        public starsCYG(int κ, double log_Te, double log_light)
        {
            this.κ = κ;
            this.log_Te = log_Te;
            this.log_light = log_light;
        }

        public static IEnumerable<starsCYG> Data
        {
            get
            {
                yield return new starsCYG(1, 4.37, 5.23);
                yield return new starsCYG(2, 4.56, 5.74);
                yield return new starsCYG(3, 4.26, 4.93);
                yield return new starsCYG(4, 4.56, 5.74);
                yield return new starsCYG(5, 4.3, 5.19);
                yield return new starsCYG(6, 4.46, 5.46);
                yield return new starsCYG(7, 3.84, 4.65);
                yield return new starsCYG(8, 4.57, 5.27);
                yield return new starsCYG(9, 4.26, 5.57);
                yield return new starsCYG(10, 4.37, 5.12);
                yield return new starsCYG(11, 3.49, 5.73);
                yield return new starsCYG(12, 4.43, 5.45);
                yield return new starsCYG(13, 4.48, 5.42);
                yield return new starsCYG(14, 4.01, 4.05);
                yield return new starsCYG(15, 4.29, 4.26);
                yield return new starsCYG(16, 4.42, 4.58);
                yield return new starsCYG(17, 4.23, 3.94);
                yield return new starsCYG(18, 4.42, 4.18);
                yield return new starsCYG(19, 4.23, 4.18);
                yield return new starsCYG(20, 3.49, 5.89);
                yield return new starsCYG(21, 4.29, 4.38);
                yield return new starsCYG(22, 4.29, 4.22);
                yield return new starsCYG(23, 4.42, 4.42);
                yield return new starsCYG(24, 4.49, 4.85);
                yield return new starsCYG(25, 4.38, 5.02);
                yield return new starsCYG(26, 4.42, 4.66);
                yield return new starsCYG(27, 4.29, 4.66);
                yield return new starsCYG(28, 4.38, 4.9);
                yield return new starsCYG(29, 4.22, 4.39);
                yield return new starsCYG(30, 3.48, 6.05);
                yield return new starsCYG(31, 4.38, 4.42);
                yield return new starsCYG(32, 4.56, 5.1);
                yield return new starsCYG(33, 4.45, 5.22);
                yield return new starsCYG(34, 3.49, 6.29);
                yield return new starsCYG(35, 4.23, 4.34);
                yield return new starsCYG(36, 4.62, 5.62);
                yield return new starsCYG(37, 4.53, 5.1);
                yield return new starsCYG(38, 4.45, 5.22);
                yield return new starsCYG(39, 4.53, 5.18);
                yield return new starsCYG(40, 4.43, 5.57);
                yield return new starsCYG(41, 4.38, 4.62);
                yield return new starsCYG(42, 4.45, 5.06);
                yield return new starsCYG(43, 4.5, 5.34);
                yield return new starsCYG(44, 4.45, 5.34);
                yield return new starsCYG(45, 4.55, 5.54);
                yield return new starsCYG(46, 4.45, 4.98);
                yield return new starsCYG(47, 4.42, 4.5);
            }
        }
    }
}
