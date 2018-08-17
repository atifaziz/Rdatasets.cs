// ReSharper disable All

namespace Rdatasets.MASS
{
    using System.Collections.Generic;

    /// <summary>
    /// AFM Compositions of Aphyric Skye Lavas
    /// </summary>

    public class Skye
    {
        public readonly int A;
        public readonly int F;
        public readonly int M;

        public Skye(int A, int F, int M)
        {
            this.A = A;
            this.F = F;
            this.M = M;
        }

        public static IEnumerable<Skye> Data
        {
            get
            {
                yield return new Skye(52, 42, 6);
                yield return new Skye(52, 44, 4);
                yield return new Skye(47, 48, 5);
                yield return new Skye(45, 49, 6);
                yield return new Skye(40, 50, 10);
                yield return new Skye(37, 54, 9);
                yield return new Skye(27, 58, 15);
                yield return new Skye(27, 54, 19);
                yield return new Skye(23, 59, 18);
                yield return new Skye(22, 59, 19);
                yield return new Skye(21, 60, 19);
                yield return new Skye(25, 53, 22);
                yield return new Skye(24, 54, 22);
                yield return new Skye(22, 55, 23);
                yield return new Skye(22, 56, 22);
                yield return new Skye(20, 58, 22);
                yield return new Skye(16, 62, 22);
                yield return new Skye(17, 57, 26);
                yield return new Skye(14, 54, 32);
                yield return new Skye(13, 55, 32);
                yield return new Skye(13, 52, 35);
                yield return new Skye(14, 47, 39);
                yield return new Skye(24, 56, 20);
            }
        }
    }
}
