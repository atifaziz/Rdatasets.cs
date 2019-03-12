// ReSharper disable All

namespace Rdatasets.sem
{
    using System.Collections.Generic;

    /// <summary>
    /// Partly Artificial Data on the U. S. Economy
    /// </summary>

    public class Kmenta
    {
        public readonly int κ;
        public readonly double Q;
        public readonly double P;
        public readonly double D;
        public readonly double F;
        public readonly int A;

        public Kmenta(int κ, double Q, double P, double D, double F, int A)
        {
            this.κ = κ;
            this.Q = Q;
            this.P = P;
            this.D = D;
            this.F = F;
            this.A = A;
        }

        public static IEnumerable<Kmenta> Data
        {
            get
            {
                yield return new Kmenta(1, 98.485, 100.323, 87.4, 98, 1);
                yield return new Kmenta(2, 99.187, 104.264, 97.6, 99.1, 2);
                yield return new Kmenta(3, 102.163, 103.435, 96.7, 99.1, 3);
                yield return new Kmenta(4, 101.504, 104.506, 98.2, 98.1, 4);
                yield return new Kmenta(5, 104.24, 98.001, 99.8, 110.8, 5);
                yield return new Kmenta(6, 103.243, 99.456, 100.5, 108.2, 6);
                yield return new Kmenta(7, 103.993, 101.066, 103.2, 105.6, 7);
                yield return new Kmenta(8, 99.9, 104.763, 107.8, 109.8, 8);
                yield return new Kmenta(9, 100.35, 96.446, 96.6, 108.7, 9);
                yield return new Kmenta(10, 102.82, 91.228, 88.9, 100.6, 10);
                yield return new Kmenta(11, 95.435, 93.085, 75.1, 81, 11);
                yield return new Kmenta(12, 92.424, 98.801, 76.9, 68.6, 12);
                yield return new Kmenta(13, 94.535, 102.908, 84.6, 70.9, 13);
                yield return new Kmenta(14, 98.757, 98.756, 90.6, 81.4, 14);
                yield return new Kmenta(15, 105.797, 95.119, 103.1, 102.3, 15);
                yield return new Kmenta(16, 100.225, 98.451, 105.1, 105, 16);
                yield return new Kmenta(17, 103.522, 86.498, 96.4, 110.5, 17);
                yield return new Kmenta(18, 99.929, 104.016, 104.4, 92.5, 18);
                yield return new Kmenta(19, 105.223, 105.769, 110.7, 89.3, 19);
                yield return new Kmenta(20, 106.232, 113.49, 127.1, 93, 20);
            }
        }
    }
}
