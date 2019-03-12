// ReSharper disable All

namespace Rdatasets.robustbase
{
    using System.Collections.Generic;

    /// <summary>
    /// Alcohol Solubility in Water Data
    /// </summary>

    public class alcohol
    {
        public readonly int κ;
        public readonly double SAG;
        public readonly double V;
        public readonly double logPC;
        public readonly double P;
        public readonly double RM;
        public readonly double Mass;
        public readonly double logSolubility;

        public alcohol(int κ, double SAG, double V, double logPC, double P, double RM, double Mass, double logSolubility)
        {
            this.κ = κ;
            this.SAG = SAG;
            this.V = V;
            this.logPC = logPC;
            this.P = P;
            this.RM = RM;
            this.Mass = Mass;
            this.logSolubility = logSolubility;
        }

        public static IEnumerable<alcohol> Data
        {
            get
            {
                yield return new alcohol(1, 251.94, 348.23, 0.94, 8.75, 22.13, 74.12, 0.09531);
                yield return new alcohol(2, 247.55, 344.91, 0.96, 8.75, 21.95, 74.12, 0.06579);
                yield return new alcohol(3, 281.6, 401.41, 1.34, 10.59, 26.74, 88.15, -1.34707);
                yield return new alcohol(4, 273.15, 392.64, 1.43, 10.59, 26.48, 88.15, -0.48613);
                yield return new alcohol(5, 268.75, 389.56, 1.34, 10.59, 26.61, 88.15, -1.0584);
                yield return new alcohol(6, 273.54, 389.93, 1.27, 10.59, 26.68, 88.15, -1.1796);
                yield return new alcohol(7, 266.07, 383.33, 1.04, 10.59, 26.59, 88.15, 0.33861);
                yield return new alcohol(8, 269.3, 385.05, 1.36, 10.59, 26.42, 88.15, -0.40497);
                yield return new alcohol(9, 312.98, 455.53, 1.73, 12.42, 31.34, 102.18, -2.7181);
                yield return new alcohol(10, 306.26, 446.43, 1.82, 12.42, 31.08, 102.18, -1.83258);
                yield return new alcohol(11, 290.96, 427.07, 1.71, 12.42, 31.16, 102.18, -2.59027);
                yield return new alcohol(12, 292.28, 430.59, 1.68, 12.42, 31.15, 102.18, -0.85097);
                yield return new alcohol(13, 288.65, 430.29, 1.74, 12.42, 31.21, 102.18, -2.78709);
                yield return new alcohol(14, 303.32, 443.4, 1.67, 12.42, 31.28, 102.18, -2.28278);
                yield return new alcohol(15, 293.04, 432.16, 1.76, 12.42, 31.02, 102.18, -1.6399);
                yield return new alcohol(16, 299.38, 438.27, 1.69, 12.42, 31.1, 102.18, -1.81401);
                yield return new alcohol(17, 291.8, 434.04, 1.83, 12.42, 30.95, 102.18, -1.60944);
                yield return new alcohol(18, 286.68, 427.75, 1.51, 12.42, 31.11, 102.18, -0.83011);
                yield return new alcohol(19, 342.35, 508.64, 2.13, 14.26, 35.94, 116.2, -4.07454);
                yield return new alcohol(20, 335.69, 499.42, 2.22, 14.26, 35.68, 116.2, -3.19418);
                yield return new alcohol(21, 336.59, 500.42, 2.22, 14.26, 35.68, 116.2, -3.19662);
                yield return new alcohol(22, 311.71, 473.87, 2.23, 14.26, 35.42, 116.2, -2.80181);
                yield return new alcohol(23, 307.49, 470.06, 2.34, 14.26, 35.35, 116.2, -2.64367);
                yield return new alcohol(24, 305.76, 467.78, 1.91, 14.26, 35.59, 116.2, -1.93794);
                yield return new alcohol(25, 328.11, 491.34, 1.83, 14.26, 35.79, 116.2, -2.47337);
                yield return new alcohol(26, 373.75, 563.02, 2.53, 16.09, 40.54, 130.23, -5.40146);
                yield return new alcohol(27, 370.46, 559.98, 2.54, 16.09, 40.36, 130.23, -4.756);
                yield return new alcohol(28, 350.77, 535.64, 2.53, 16.09, 40.41, 130.23, -4.99673);
                yield return new alcohol(29, 403.26, 615.97, 2.92, 17.93, 45.14, 144.26, -6.90776);
                yield return new alcohol(30, 401.55, 613.37, 2.94, 17.93, 44.96, 144.26, -6.31997);
                yield return new alcohol(31, 395.82, 608.3, 3.01, 17.93, 44.88, 144.26, -5.95224);
                yield return new alcohol(32, 396.25, 607.83, 3.01, 17.93, 44.88, 144.26, -5.7446);
                yield return new alcohol(33, 360.85, 564.46, 2.83, 17.93, 44.91, 144.26, -5.76992);
                yield return new alcohol(34, 374.83, 584.21, 2.88, 17.93, 44.78, 144.26, -5.77635);
                yield return new alcohol(35, 358.77, 566.85, 3.03, 17.93, 44.62, 144.26, -5.29832);
                yield return new alcohol(36, 395.75, 604.55, 2.86, 17.93, 45.09, 144.26, -5.7446);
                yield return new alcohol(37, 434.8, 670.25, 3.32, 19.76, 49.74, 158.28, -8.2208);
                yield return new alcohol(38, 493.36, 776.25, 4.11, 23.43, 58.94, 186.34, -10.68);
                yield return new alcohol(39, 309.25, 469.46, 1.97, 14.26, 36.64, 116.2, -1.91732);
                yield return new alcohol(40, 317.34, 499.03, 2.41, 16.09, 39.98, 130.23, -2.93182);
                yield return new alcohol(41, 350.39, 561.72, 3.04, 17.93, 44.81, 144.26, -5.57275);
                yield return new alcohol(42, 266.68, 384.11, 1.45, 10.59, 26.4, 88.15, -0.64626);
                yield return new alcohol(43, 556.88, 888.52, 4.81, 27.1, 68.14, 214.39, -12.77171);
                yield return new alcohol(44, 587, 938.54, 5.3, 28.94, 72.75, 228.42, -14.61402);
            }
        }
    }
}
