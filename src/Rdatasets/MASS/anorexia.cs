// ReSharper disable All

namespace Rdatasets.MASS
{
    using System.Collections.Generic;

    /// <summary>
    /// Anorexia Data on Weight Change
    /// </summary>

    public class anorexia
    {
        public readonly int κ;
        public readonly string Treat;
        public readonly double Prewt;
        public readonly double Postwt;

        public anorexia(int κ, string Treat, double Prewt, double Postwt)
        {
            this.κ = κ;
            this.Treat = Treat;
            this.Prewt = Prewt;
            this.Postwt = Postwt;
        }

        public static IEnumerable<anorexia> Data
        {
            get
            {
                yield return new anorexia(1, "Cont", 80.7, 80.2);
                yield return new anorexia(2, "Cont", 89.4, 80.1);
                yield return new anorexia(3, "Cont", 91.8, 86.4);
                yield return new anorexia(4, "Cont", 74, 86.3);
                yield return new anorexia(5, "Cont", 78.1, 76.1);
                yield return new anorexia(6, "Cont", 88.3, 78.1);
                yield return new anorexia(7, "Cont", 87.3, 75.1);
                yield return new anorexia(8, "Cont", 75.1, 86.7);
                yield return new anorexia(9, "Cont", 80.6, 73.5);
                yield return new anorexia(10, "Cont", 78.4, 84.6);
                yield return new anorexia(11, "Cont", 77.6, 77.4);
                yield return new anorexia(12, "Cont", 88.7, 79.5);
                yield return new anorexia(13, "Cont", 81.3, 89.6);
                yield return new anorexia(14, "Cont", 78.1, 81.4);
                yield return new anorexia(15, "Cont", 70.5, 81.8);
                yield return new anorexia(16, "Cont", 77.3, 77.3);
                yield return new anorexia(17, "Cont", 85.2, 84.2);
                yield return new anorexia(18, "Cont", 86, 75.4);
                yield return new anorexia(19, "Cont", 84.1, 79.5);
                yield return new anorexia(20, "Cont", 79.7, 73);
                yield return new anorexia(21, "Cont", 85.5, 88.3);
                yield return new anorexia(22, "Cont", 84.4, 84.7);
                yield return new anorexia(23, "Cont", 79.6, 81.4);
                yield return new anorexia(24, "Cont", 77.5, 81.2);
                yield return new anorexia(25, "Cont", 72.3, 88.2);
                yield return new anorexia(26, "Cont", 89, 78.8);
                yield return new anorexia(27, "CBT", 80.5, 82.2);
                yield return new anorexia(28, "CBT", 84.9, 85.6);
                yield return new anorexia(29, "CBT", 81.5, 81.4);
                yield return new anorexia(30, "CBT", 82.6, 81.9);
                yield return new anorexia(31, "CBT", 79.9, 76.4);
                yield return new anorexia(32, "CBT", 88.7, 103.6);
                yield return new anorexia(33, "CBT", 94.9, 98.4);
                yield return new anorexia(34, "CBT", 76.3, 93.4);
                yield return new anorexia(35, "CBT", 81, 73.4);
                yield return new anorexia(36, "CBT", 80.5, 82.1);
                yield return new anorexia(37, "CBT", 85, 96.7);
                yield return new anorexia(38, "CBT", 89.2, 95.3);
                yield return new anorexia(39, "CBT", 81.3, 82.4);
                yield return new anorexia(40, "CBT", 76.5, 72.5);
                yield return new anorexia(41, "CBT", 70, 90.9);
                yield return new anorexia(42, "CBT", 80.4, 71.3);
                yield return new anorexia(43, "CBT", 83.3, 85.4);
                yield return new anorexia(44, "CBT", 83, 81.6);
                yield return new anorexia(45, "CBT", 87.7, 89.1);
                yield return new anorexia(46, "CBT", 84.2, 83.9);
                yield return new anorexia(47, "CBT", 86.4, 82.7);
                yield return new anorexia(48, "CBT", 76.5, 75.7);
                yield return new anorexia(49, "CBT", 80.2, 82.6);
                yield return new anorexia(50, "CBT", 87.8, 100.4);
                yield return new anorexia(51, "CBT", 83.3, 85.2);
                yield return new anorexia(52, "CBT", 79.7, 83.6);
                yield return new anorexia(53, "CBT", 84.5, 84.6);
                yield return new anorexia(54, "CBT", 80.8, 96.2);
                yield return new anorexia(55, "CBT", 87.4, 86.7);
                yield return new anorexia(56, "FT", 83.8, 95.2);
                yield return new anorexia(57, "FT", 83.3, 94.3);
                yield return new anorexia(58, "FT", 86, 91.5);
                yield return new anorexia(59, "FT", 82.5, 91.9);
                yield return new anorexia(60, "FT", 86.7, 100.3);
                yield return new anorexia(61, "FT", 79.6, 76.7);
                yield return new anorexia(62, "FT", 76.9, 76.8);
                yield return new anorexia(63, "FT", 94.2, 101.6);
                yield return new anorexia(64, "FT", 73.4, 94.9);
                yield return new anorexia(65, "FT", 80.5, 75.2);
                yield return new anorexia(66, "FT", 81.6, 77.8);
                yield return new anorexia(67, "FT", 82.1, 95.5);
                yield return new anorexia(68, "FT", 77.6, 90.7);
                yield return new anorexia(69, "FT", 83.5, 92.5);
                yield return new anorexia(70, "FT", 89.9, 93.8);
                yield return new anorexia(71, "FT", 86, 91.7);
                yield return new anorexia(72, "FT", 87.3, 98);
            }
        }
    }
}
