// ReSharper disable All

namespace Rdatasets.MASS
{
    using System.Collections.Generic;

    /// <summary>
    /// Anorexia Data on Weight Change
    /// </summary>

    public class anorexia
    {
        public readonly string Treat;
        public readonly double Prewt;
        public readonly double Postwt;

        public anorexia(string Treat, double Prewt, double Postwt)
        {
            this.Treat = Treat;
            this.Prewt = Prewt;
            this.Postwt = Postwt;
        }

        public static IEnumerable<anorexia> Data
        {
            get
            {
                yield return new anorexia("Cont", 80.7, 80.2);
                yield return new anorexia("Cont", 89.4, 80.1);
                yield return new anorexia("Cont", 91.8, 86.4);
                yield return new anorexia("Cont", 74, 86.3);
                yield return new anorexia("Cont", 78.1, 76.1);
                yield return new anorexia("Cont", 88.3, 78.1);
                yield return new anorexia("Cont", 87.3, 75.1);
                yield return new anorexia("Cont", 75.1, 86.7);
                yield return new anorexia("Cont", 80.6, 73.5);
                yield return new anorexia("Cont", 78.4, 84.6);
                yield return new anorexia("Cont", 77.6, 77.4);
                yield return new anorexia("Cont", 88.7, 79.5);
                yield return new anorexia("Cont", 81.3, 89.6);
                yield return new anorexia("Cont", 78.1, 81.4);
                yield return new anorexia("Cont", 70.5, 81.8);
                yield return new anorexia("Cont", 77.3, 77.3);
                yield return new anorexia("Cont", 85.2, 84.2);
                yield return new anorexia("Cont", 86, 75.4);
                yield return new anorexia("Cont", 84.1, 79.5);
                yield return new anorexia("Cont", 79.7, 73);
                yield return new anorexia("Cont", 85.5, 88.3);
                yield return new anorexia("Cont", 84.4, 84.7);
                yield return new anorexia("Cont", 79.6, 81.4);
                yield return new anorexia("Cont", 77.5, 81.2);
                yield return new anorexia("Cont", 72.3, 88.2);
                yield return new anorexia("Cont", 89, 78.8);
                yield return new anorexia("CBT", 80.5, 82.2);
                yield return new anorexia("CBT", 84.9, 85.6);
                yield return new anorexia("CBT", 81.5, 81.4);
                yield return new anorexia("CBT", 82.6, 81.9);
                yield return new anorexia("CBT", 79.9, 76.4);
                yield return new anorexia("CBT", 88.7, 103.6);
                yield return new anorexia("CBT", 94.9, 98.4);
                yield return new anorexia("CBT", 76.3, 93.4);
                yield return new anorexia("CBT", 81, 73.4);
                yield return new anorexia("CBT", 80.5, 82.1);
                yield return new anorexia("CBT", 85, 96.7);
                yield return new anorexia("CBT", 89.2, 95.3);
                yield return new anorexia("CBT", 81.3, 82.4);
                yield return new anorexia("CBT", 76.5, 72.5);
                yield return new anorexia("CBT", 70, 90.9);
                yield return new anorexia("CBT", 80.4, 71.3);
                yield return new anorexia("CBT", 83.3, 85.4);
                yield return new anorexia("CBT", 83, 81.6);
                yield return new anorexia("CBT", 87.7, 89.1);
                yield return new anorexia("CBT", 84.2, 83.9);
                yield return new anorexia("CBT", 86.4, 82.7);
                yield return new anorexia("CBT", 76.5, 75.7);
                yield return new anorexia("CBT", 80.2, 82.6);
                yield return new anorexia("CBT", 87.8, 100.4);
                yield return new anorexia("CBT", 83.3, 85.2);
                yield return new anorexia("CBT", 79.7, 83.6);
                yield return new anorexia("CBT", 84.5, 84.6);
                yield return new anorexia("CBT", 80.8, 96.2);
                yield return new anorexia("CBT", 87.4, 86.7);
                yield return new anorexia("FT", 83.8, 95.2);
                yield return new anorexia("FT", 83.3, 94.3);
                yield return new anorexia("FT", 86, 91.5);
                yield return new anorexia("FT", 82.5, 91.9);
                yield return new anorexia("FT", 86.7, 100.3);
                yield return new anorexia("FT", 79.6, 76.7);
                yield return new anorexia("FT", 76.9, 76.8);
                yield return new anorexia("FT", 94.2, 101.6);
                yield return new anorexia("FT", 73.4, 94.9);
                yield return new anorexia("FT", 80.5, 75.2);
                yield return new anorexia("FT", 81.6, 77.8);
                yield return new anorexia("FT", 82.1, 95.5);
                yield return new anorexia("FT", 77.6, 90.7);
                yield return new anorexia("FT", 83.5, 92.5);
                yield return new anorexia("FT", 89.9, 93.8);
                yield return new anorexia("FT", 86, 91.7);
                yield return new anorexia("FT", 87.3, 98);
            }
        }
    }
}
