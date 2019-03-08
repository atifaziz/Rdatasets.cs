// ReSharper disable All

namespace Rdatasets.drc
{
    using System.Collections.Generic;

    /// <summary>
    /// Effect of technical grade and commercially formulated auxin herbicides
    /// </summary>

    public class auxins
    {
        public readonly int r;
        public readonly int h;
        public readonly int w;
        public readonly double y;
        public readonly double dose;

        public auxins(int r, int h, int w, double y, double dose)
        {
            this.r = r;
            this.h = h;
            this.w = w;
            this.y = y;
            this.dose = dose;
        }

        public static IEnumerable<auxins> Data
        {
            get
            {
                yield return new auxins(1, 0, 0, 1.51, 0);
                yield return new auxins(1, 0, 0, 1.43, 0);
                yield return new auxins(1, 1, 1, 0.05, 1);
                yield return new auxins(1, 1, 2, 0.06, 0.5);
                yield return new auxins(1, 1, 4, 0.15, 0.25);
                yield return new auxins(1, 1, 8, 0.4, 0.125);
                yield return new auxins(1, 1, 16, 0.76, 0.0625);
                yield return new auxins(1, 1, 32, 0.95, 0.03125);
                yield return new auxins(1, 2, 1, 0.04, 1);
                yield return new auxins(1, 2, 2, 0.07, 0.5);
                yield return new auxins(1, 2, 4, 0.13, 0.25);
                yield return new auxins(1, 2, 8, 0.52, 0.125);
                yield return new auxins(1, 2, 16, 0.79, 0.0625);
                yield return new auxins(1, 2, 32, 1.17, 0.03125);
                yield return new auxins(1, 3, 1, 0.05, 1);
                yield return new auxins(1, 3, 2, 0.26, 0.5);
                yield return new auxins(1, 3, 4, 0.28, 0.25);
                yield return new auxins(1, 3, 8, 0.7, 0.125);
                yield return new auxins(1, 3, 16, 1.05, 0.0625);
                yield return new auxins(1, 3, 32, 1.3, 0.03125);
                yield return new auxins(1, 4, 1, 0.11, 1);
                yield return new auxins(1, 4, 2, 0.42, 0.5);
                yield return new auxins(1, 4, 4, 0.59, 0.25);
                yield return new auxins(1, 4, 8, 0.9, 0.125);
                yield return new auxins(1, 4, 16, 1.08, 0.0625);
                yield return new auxins(1, 4, 32, 1.24, 0.03125);
                yield return new auxins(1, 5, 1, 0.04, 1);
                yield return new auxins(1, 5, 2, 0.06, 0.5);
                yield return new auxins(1, 5, 4, 0.19, 0.25);
                yield return new auxins(1, 5, 8, 0.5, 0.125);
                yield return new auxins(1, 5, 16, 0.84, 0.0625);
                yield return new auxins(1, 5, 32, 1.17, 0.03125);
                yield return new auxins(1, 6, 1, 0.04, 1);
                yield return new auxins(1, 6, 2, 0.04, 0.5);
                yield return new auxins(1, 6, 4, 0.24, 0.25);
                yield return new auxins(1, 6, 8, 0.7, 0.125);
                yield return new auxins(1, 6, 16, 1.21, 0.0625);
                yield return new auxins(1, 6, 32, 1.01, 0.03125);
                yield return new auxins(1, 7, 1, 0.05, 1);
                yield return new auxins(1, 7, 2, 0.08, 0.5);
                yield return new auxins(1, 7, 4, 0.14, 0.25);
                yield return new auxins(1, 7, 8, 0.6, 0.125);
                yield return new auxins(1, 7, 16, 1.2, 0.0625);
                yield return new auxins(1, 7, 32, 1.3, 0.03125);
                yield return new auxins(1, 8, 1, 0.38, 1);
                yield return new auxins(1, 8, 2, 0.64, 0.5);
                yield return new auxins(1, 8, 4, 0.88, 0.25);
                yield return new auxins(1, 8, 8, 1.09, 0.125);
                yield return new auxins(1, 8, 16, 1.5, 0.0625);
                yield return new auxins(1, 8, 32, 1.3, 0.03125);
                yield return new auxins(2, 0, 0, 1.01, 0);
                yield return new auxins(2, 0, 0, 1.34, 0);
                yield return new auxins(2, 1, 1, 0.05, 1);
                yield return new auxins(2, 1, 2, 0.07, 0.5);
                yield return new auxins(2, 1, 4, 0.09, 0.25);
                yield return new auxins(2, 1, 8, 0.26, 0.125);
                yield return new auxins(2, 1, 16, 0.55, 0.0625);
                yield return new auxins(2, 1, 32, 1.21, 0.03125);
                yield return new auxins(2, 2, 1, 0.04, 1);
                yield return new auxins(2, 2, 2, 0.06, 0.5);
                yield return new auxins(2, 2, 4, 0.19, 0.25);
                yield return new auxins(2, 2, 8, 1.16, 0.125);
                yield return new auxins(2, 2, 16, 0.96, 0.0625);
                yield return new auxins(2, 2, 32, 1.13, 0.03125);
                yield return new auxins(2, 3, 1, 0.04, 1);
                yield return new auxins(2, 3, 2, 0.17, 0.5);
                yield return new auxins(2, 3, 4, 0.33, 0.25);
                yield return new auxins(2, 3, 8, 0.5, 0.125);
                yield return new auxins(2, 3, 16, 1.11, 0.0625);
                yield return new auxins(2, 3, 32, 1.2, 0.03125);
                yield return new auxins(2, 4, 1, 0.12, 1);
                yield return new auxins(2, 4, 2, 0.3, 0.5);
                yield return new auxins(2, 4, 4, 0.41, 0.25);
                yield return new auxins(2, 4, 8, 1.06, 0.125);
                yield return new auxins(2, 4, 16, 1.29, 0.0625);
                yield return new auxins(2, 4, 32, 1.17, 0.03125);
                yield return new auxins(2, 5, 1, 0.04, 1);
                yield return new auxins(2, 5, 2, 0.07, 0.5);
                yield return new auxins(2, 5, 4, 0.19, 0.25);
                yield return new auxins(2, 5, 8, 0.36, 0.125);
                yield return new auxins(2, 5, 16, 0.88, 0.0625);
                yield return new auxins(2, 5, 32, 1.16, 0.03125);
                yield return new auxins(2, 6, 1, 0.04, 1);
                yield return new auxins(2, 6, 2, 0.05, 0.5);
                yield return new auxins(2, 6, 4, 0.22, 0.25);
                yield return new auxins(2, 6, 8, 0.61, 0.125);
                yield return new auxins(2, 6, 16, 1.15, 0.0625);
                yield return new auxins(2, 6, 32, 1.39, 0.03125);
                yield return new auxins(2, 7, 1, 0.04, 1);
                yield return new auxins(2, 7, 2, 0.18, 0.5);
                yield return new auxins(2, 7, 4, 0.27, 0.25);
                yield return new auxins(2, 7, 8, 0.88, 0.125);
                yield return new auxins(2, 7, 16, 0.97, 0.0625);
                yield return new auxins(2, 7, 32, 1.26, 0.03125);
                yield return new auxins(2, 8, 1, 0.29, 1);
                yield return new auxins(2, 8, 2, 0.98, 0.5);
                yield return new auxins(2, 8, 4, 1.12, 0.25);
                yield return new auxins(2, 8, 8, 1.1, 0.125);
                yield return new auxins(2, 8, 16, 1.13, 0.0625);
                yield return new auxins(2, 8, 32, 1.31, 0.03125);
                yield return new auxins(3, 0, 0, 1.21, 0);
                yield return new auxins(3, 0, 0, 1.1, 0);
                yield return new auxins(3, 1, 1, 0.04, 1);
                yield return new auxins(3, 1, 2, 0.09, 0.5);
                yield return new auxins(3, 1, 4, 0.12, 0.25);
                yield return new auxins(3, 1, 8, 0.25, 0.125);
                yield return new auxins(3, 1, 16, 0.56, 0.0625);
                yield return new auxins(3, 1, 32, 1.04, 0.03125);
                yield return new auxins(3, 2, 1, 0.05, 1);
                yield return new auxins(3, 2, 2, 0.06, 0.5);
                yield return new auxins(3, 2, 4, 0.14, 0.25);
                yield return new auxins(3, 2, 8, 0.35, 0.125);
                yield return new auxins(3, 2, 16, 0.9, 0.0625);
                yield return new auxins(3, 2, 32, 1.12, 0.03125);
                yield return new auxins(3, 3, 1, 0.06, 1);
                yield return new auxins(3, 3, 2, 0.21, 0.5);
                yield return new auxins(3, 3, 4, 0.37, 0.25);
                yield return new auxins(3, 3, 8, 0.6, 0.125);
                yield return new auxins(3, 3, 16, 1.01, 0.0625);
                yield return new auxins(3, 3, 32, 0.7, 0.03125);
                yield return new auxins(3, 4, 1, 0.1, 1);
                yield return new auxins(3, 4, 2, 0.2, 0.5);
                yield return new auxins(3, 4, 4, 0.47, 0.25);
                yield return new auxins(3, 4, 8, 0.95, 0.125);
                yield return new auxins(3, 4, 16, 1.07, 0.0625);
                yield return new auxins(3, 4, 32, 0.93, 0.03125);
                yield return new auxins(3, 5, 1, 0.05, 1);
                yield return new auxins(3, 5, 2, 0.07, 0.5);
                yield return new auxins(3, 5, 4, 0.09, 0.25);
                yield return new auxins(3, 5, 8, 0.29, 0.125);
                yield return new auxins(3, 5, 16, 0.78, 0.0625);
                yield return new auxins(3, 5, 32, 1.05, 0.03125);
                yield return new auxins(3, 6, 1, 0.05, 1);
                yield return new auxins(3, 6, 2, 0.07, 0.5);
                yield return new auxins(3, 6, 4, 0.16, 0.25);
                yield return new auxins(3, 6, 8, 0.39, 0.125);
                yield return new auxins(3, 6, 16, 0.78, 0.0625);
                yield return new auxins(3, 6, 32, 0.97, 0.03125);
                yield return new auxins(3, 7, 1, 0.04, 1);
                yield return new auxins(3, 7, 2, 0.11, 0.5);
                yield return new auxins(3, 7, 4, 0.24, 0.25);
                yield return new auxins(3, 7, 8, 0.48, 0.125);
                yield return new auxins(3, 7, 16, 0.94, 0.0625);
                yield return new auxins(3, 7, 32, 1.3, 0.03125);
                yield return new auxins(3, 8, 1, 0.15, 1);
                yield return new auxins(3, 8, 2, 0.26, 0.5);
                yield return new auxins(3, 8, 4, 0.6, 0.25);
                yield return new auxins(3, 8, 8, 0.87, 0.125);
                yield return new auxins(3, 8, 16, 0.61, 0.0625);
                yield return new auxins(3, 8, 32, 0.98, 0.03125);
            }
        }
    }
}
