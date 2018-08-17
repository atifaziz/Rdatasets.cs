// ReSharper disable All

namespace Rdatasets.robustbase
{
    using System.Collections.Generic;

    /// <summary>
    /// Wagner's Hannover Employment Growth Data
    /// </summary>

    public class wagnerGrowth
    {
        public readonly int Region;
        public readonly double PA;
        public readonly double GPA;
        public readonly double HS;
        public readonly double GHS;
        public readonly double y;
        public readonly int Period;

        public wagnerGrowth(int Region, double PA, double GPA, double HS, double GHS, double y, int Period)
        {
            this.Region = Region;
            this.PA = PA;
            this.GPA = GPA;
            this.HS = HS;
            this.GHS = GHS;
            this.y = y;
            this.Period = Period;
        }

        public static IEnumerable<wagnerGrowth> Data
        {
            get
            {
                yield return new wagnerGrowth(1, 46.84, -2.6, 1.68, 0.2, 0.97, 1);
                yield return new wagnerGrowth(2, 35.54, -1.42, 1.67, 0.63, 2.14, 1);
                yield return new wagnerGrowth(3, 28.42, -1.48, 1.71, 0.12, 6.13, 1);
                yield return new wagnerGrowth(4, 32.54, -4.51, 1.37, 0.32, 7.36, 1);
                yield return new wagnerGrowth(5, 28.92, -0.88, 2.14, -0.08, 3.63, 1);
                yield return new wagnerGrowth(6, 36.61, -1.39, 3, 0.45, -4.3, 1);
                yield return new wagnerGrowth(7, 34.71, -2.22, 2.94, 0.27, 2.06, 1);
                yield return new wagnerGrowth(8, 24.32, -5.11, 3.57, -0.55, -18.64, 1);
                yield return new wagnerGrowth(9, 35.15, -0.16, 3.27, 0.03, 5.15, 1);
                yield return new wagnerGrowth(10, 34.06, -3.86, 2.74, 0.19, 6.88, 1);
                yield return new wagnerGrowth(11, 37.94, -4.61, 2.07, 0.38, -1.24, 1);
                yield return new wagnerGrowth(12, 35.88, -2.17, 1.57, -0.11, -1.31, 1);
                yield return new wagnerGrowth(13, 31.28, -1.9, 2.74, -0.57, 1.73, 1);
                yield return new wagnerGrowth(14, 33.61, 2.02, 1.92, 0.32, 0.44, 1);
                yield return new wagnerGrowth(15, 33.86, 0.75, 0.86, 0.46, -15.53, 1);
                yield return new wagnerGrowth(16, 43.24, -4.41, 1.82, 0.52, -10.99, 1);
                yield return new wagnerGrowth(17, 42.65, -2.28, 1.52, -0.17, 0.6, 1);
                yield return new wagnerGrowth(18, 37.19, -2.75, 2.39, 0.4, 3.71, 1);
                yield return new wagnerGrowth(19, 49.7, -4.86, 1.16, 0.09, -2.38, 1);
                yield return new wagnerGrowth(20, 41.96, -4.59, 2, -0.12, -1.35, 1);
                yield return new wagnerGrowth(21, 28.86, -2.11, 5.17, 0.46, -1.08, 1);
                yield return new wagnerGrowth(1, 44.24, 3.8, 1.88, 0.13, 8.47, 2);
                yield return new wagnerGrowth(2, 34.12, -3.33, 2.3, 1.04, 2.76, 2);
                yield return new wagnerGrowth(3, 26.94, -1.71, 1.83, 1.28, 24.08, 2);
                yield return new wagnerGrowth(4, 28.03, -0.89, 1.69, 0.35, 13.97, 2);
                yield return new wagnerGrowth(5, 28.04, -1.47, 2.06, -0.81, 0.63, 2);
                yield return new wagnerGrowth(6, 35.22, -2.87, 3.45, 0.59, -1.99, 2);
                yield return new wagnerGrowth(7, 32.49, -1.89, 3.21, 1.88, 13.1, 2);
                yield return new wagnerGrowth(8, 19.21, 0.36, 3.02, 2.98, 15.42, 2);
                yield return new wagnerGrowth(9, 34.99, -4.95, 3.3, 0.68, 19.65, 2);
                yield return new wagnerGrowth(10, 30.2, -3.02, 2.93, 0.48, 8.45, 2);
                yield return new wagnerGrowth(11, 33.33, 0.06, 2.45, 0.24, 9.04, 2);
                yield return new wagnerGrowth(12, 33.71, -4.67, 1.46, 2.59, 9.47, 2);
                yield return new wagnerGrowth(13, 29.38, -2.74, 2.17, 0.07, 24.18, 2);
                yield return new wagnerGrowth(14, 35.63, -0.51, 2.24, 0.62, 9.09, 2);
                yield return new wagnerGrowth(15, 34.61, -5.36, 1.32, 0.61, -1.89, 2);
                yield return new wagnerGrowth(16, 38.83, -6.83, 2.34, 0.71, 14.62, 2);
                yield return new wagnerGrowth(17, 40.37, -3.94, 1.35, 0.45, -0.44, 2);
                yield return new wagnerGrowth(18, 34.44, 1.37, 2.79, 1.27, 17.84, 2);
                yield return new wagnerGrowth(19, 44.84, -7.7, 1.25, 0.8, 10.95, 2);
                yield return new wagnerGrowth(20, 37.37, -5.87, 1.88, 0.8, -1.55, 2);
                yield return new wagnerGrowth(21, 26.75, -1.83, 5.63, 1.35, -1.66, 2);
                yield return new wagnerGrowth(1, 48.04, -4.03, 2.01, 0.4, 3.72, 3);
                yield return new wagnerGrowth(2, 30.79, -3.1, 3.34, 0.25, 9.29, 3);
                yield return new wagnerGrowth(3, 25.23, -4.29, 3.11, 0.88, 25.59, 3);
                yield return new wagnerGrowth(4, 27.14, -2.45, 2.04, 1.95, 27.41, 3);
                yield return new wagnerGrowth(5, 26.57, 1.31, 1.25, 0.67, 18.32, 3);
                yield return new wagnerGrowth(6, 32.35, -1.25, 4.04, 0.23, 11.2, 3);
                yield return new wagnerGrowth(7, 30.6, -3.21, 5.09, -0.17, 21.95, 3);
                yield return new wagnerGrowth(8, 19.57, 2.48, 6, 2.27, 33.03, 3);
                yield return new wagnerGrowth(9, 30.04, -0.79, 3.98, 0.55, 22.02, 3);
                yield return new wagnerGrowth(10, 27.18, -1.14, 3.41, 0.28, 13.68, 3);
                yield return new wagnerGrowth(11, 33.39, -0.42, 2.69, -0.18, 11.24, 3);
                yield return new wagnerGrowth(12, 29.04, 1.4, 4.05, -0.05, 15.06, 3);
                yield return new wagnerGrowth(13, 26.64, 1.04, 2.24, 0.12, 10.73, 3);
                yield return new wagnerGrowth(14, 35.12, -0.81, 2.86, 0.25, 1.53, 3);
                yield return new wagnerGrowth(15, 29.25, -2.56, 1.93, 0.3, 11.37, 3);
                yield return new wagnerGrowth(16, 32, 1.68, 3.05, 0.78, -0.07, 3);
                yield return new wagnerGrowth(17, 36.43, 1, 1.8, 0.37, 14.17, 3);
                yield return new wagnerGrowth(18, 35.81, -2.29, 4.06, 0.18, 8.05, 3);
                yield return new wagnerGrowth(19, 37.14, 1.59, 2.05, 0.82, 15.96, 3);
                yield return new wagnerGrowth(20, 31.5, 0.7, 2.68, -0.17, 9.91, 3);
                yield return new wagnerGrowth(21, 24.92, -0.14, 6.98, 0.59, 6.94, 3);
            }
        }
    }
}
