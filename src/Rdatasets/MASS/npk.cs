// ReSharper disable All

namespace Rdatasets.MASS
{
    using System.Collections.Generic;

    /// <summary>
    /// Classical N, P, K Factorial Experiment
    /// </summary>

    public class npk
    {
        public readonly int block;
        public readonly int N;
        public readonly int P;
        public readonly int K;
        public readonly double yield;

        public npk(int block, int N, int P, int K, double yield)
        {
            this.block = block;
            this.N = N;
            this.P = P;
            this.K = K;
            this.yield = yield;
        }

        public static IEnumerable<npk> Data
        {
            get
            {
                yield return new npk(1, 0, 1, 1, 49.5);
                yield return new npk(1, 1, 1, 0, 62.8);
                yield return new npk(1, 0, 0, 0, 46.8);
                yield return new npk(1, 1, 0, 1, 57);
                yield return new npk(2, 1, 0, 0, 59.8);
                yield return new npk(2, 1, 1, 1, 58.5);
                yield return new npk(2, 0, 0, 1, 55.5);
                yield return new npk(2, 0, 1, 0, 56);
                yield return new npk(3, 0, 1, 0, 62.8);
                yield return new npk(3, 1, 1, 1, 55.8);
                yield return new npk(3, 1, 0, 0, 69.5);
                yield return new npk(3, 0, 0, 1, 55);
                yield return new npk(4, 1, 0, 0, 62);
                yield return new npk(4, 1, 1, 1, 48.8);
                yield return new npk(4, 0, 0, 1, 45.5);
                yield return new npk(4, 0, 1, 0, 44.2);
                yield return new npk(5, 1, 1, 0, 52);
                yield return new npk(5, 0, 0, 0, 51.5);
                yield return new npk(5, 1, 0, 1, 49.8);
                yield return new npk(5, 0, 1, 1, 48.8);
                yield return new npk(6, 1, 0, 1, 57.2);
                yield return new npk(6, 1, 1, 0, 59);
                yield return new npk(6, 0, 1, 1, 53.2);
                yield return new npk(6, 0, 0, 0, 56);
            }
        }
    }
}
