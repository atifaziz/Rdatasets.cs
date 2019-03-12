// ReSharper disable All

namespace Rdatasets.MASS
{
    using System.Collections.Generic;

    /// <summary>
    /// AFM Compositions of Aphyric Skye Lavas
    /// </summary>

    public class Skye
    {
        public readonly int κ;
        public readonly int A;
        public readonly int F;
        public readonly int M;

        public Skye(int κ, int A, int F, int M)
        {
            this.κ = κ;
            this.A = A;
            this.F = F;
            this.M = M;
        }

        public static IEnumerable<Skye> Data
        {
            get
            {
                yield return new Skye(1, 52, 42, 6);
                yield return new Skye(2, 52, 44, 4);
                yield return new Skye(3, 47, 48, 5);
                yield return new Skye(4, 45, 49, 6);
                yield return new Skye(5, 40, 50, 10);
                yield return new Skye(6, 37, 54, 9);
                yield return new Skye(7, 27, 58, 15);
                yield return new Skye(8, 27, 54, 19);
                yield return new Skye(9, 23, 59, 18);
                yield return new Skye(10, 22, 59, 19);
                yield return new Skye(11, 21, 60, 19);
                yield return new Skye(12, 25, 53, 22);
                yield return new Skye(13, 24, 54, 22);
                yield return new Skye(14, 22, 55, 23);
                yield return new Skye(15, 22, 56, 22);
                yield return new Skye(16, 20, 58, 22);
                yield return new Skye(17, 16, 62, 22);
                yield return new Skye(18, 17, 57, 26);
                yield return new Skye(19, 14, 54, 32);
                yield return new Skye(20, 13, 55, 32);
                yield return new Skye(21, 13, 52, 35);
                yield return new Skye(22, 14, 47, 39);
                yield return new Skye(23, 24, 56, 20);
            }
        }
    }
}
