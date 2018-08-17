// ReSharper disable All

namespace Rdatasets.robustbase
{
    using System.Collections.Generic;

    /// <summary>
    /// Coleman Data Set
    /// </summary>

    public class coleman
    {
        public readonly double salaryP;
        public readonly double fatherWc;
        public readonly double sstatus;
        public readonly double teacherSc;
        public readonly double motherLev;
        public readonly double Y;

        public coleman(double salaryP, double fatherWc, double sstatus, double teacherSc, double motherLev, double Y)
        {
            this.salaryP = salaryP;
            this.fatherWc = fatherWc;
            this.sstatus = sstatus;
            this.teacherSc = teacherSc;
            this.motherLev = motherLev;
            this.Y = Y;
        }

        public static IEnumerable<coleman> Data
        {
            get
            {
                yield return new coleman(3.83, 28.87, 7.2, 26.6, 6.19, 37.01);
                yield return new coleman(2.89, 20.1, -11.71, 24.4, 5.17, 26.51);
                yield return new coleman(2.86, 69.05, 12.32, 25.7, 7.04, 36.51);
                yield return new coleman(2.92, 65.4, 14.28, 25.7, 7.1, 40.7);
                yield return new coleman(3.06, 29.59, 6.31, 25.4, 6.15, 37.1);
                yield return new coleman(2.07, 44.82, 6.16, 21.6, 6.41, 33.9);
                yield return new coleman(2.52, 77.37, 12.7, 24.9, 6.86, 41.8);
                yield return new coleman(2.45, 24.67, -0.17, 25.01, 5.78, 33.4);
                yield return new coleman(3.13, 65.01, 9.85, 26.6, 6.51, 41.01);
                yield return new coleman(2.44, 9.99, -0.05, 28.01, 5.57, 37.2);
                yield return new coleman(2.09, 12.2, -12.86, 23.51, 5.62, 23.3);
                yield return new coleman(2.52, 22.55, 0.92, 23.6, 5.34, 35.2);
                yield return new coleman(2.22, 14.3, 4.77, 24.51, 5.8, 34.9);
                yield return new coleman(2.67, 31.79, -0.96, 25.8, 6.19, 33.1);
                yield return new coleman(2.71, 11.6, -16.04, 25.2, 5.62, 22.7);
                yield return new coleman(3.14, 68.47, 10.62, 25.01, 6.94, 39.7);
                yield return new coleman(3.54, 42.64, 2.66, 25.01, 6.33, 31.8);
                yield return new coleman(2.52, 16.7, -10.99, 24.8, 6.01, 31.7);
                yield return new coleman(2.68, 86.27, 15.03, 25.51, 7.51, 43.1);
                yield return new coleman(2.37, 76.73, 12.77, 24.51, 6.96, 41.01);
            }
        }
    }
}
