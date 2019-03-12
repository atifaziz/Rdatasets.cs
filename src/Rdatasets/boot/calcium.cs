// ReSharper disable All

namespace Rdatasets.boot
{
    using System.Collections.Generic;

    /// <summary>
    /// Calcium Uptake Data
    /// </summary>

    public class calcium
    {
        public readonly int κ;
        public readonly double time;
        public readonly double cal;

        public calcium(int κ, double time, double cal)
        {
            this.κ = κ;
            this.time = time;
            this.cal = cal;
        }

        public static IEnumerable<calcium> Data
        {
            get
            {
                yield return new calcium(1, 0.45, 0.3417);
                yield return new calcium(2, 0.45, -0.00438);
                yield return new calcium(3, 0.45, 0.82531);
                yield return new calcium(4, 1.3, 1.77967);
                yield return new calcium(5, 1.3, 0.95384);
                yield return new calcium(6, 1.3, 0.6408);
                yield return new calcium(7, 2.4, 1.75136);
                yield return new calcium(8, 2.4, 1.27497);
                yield return new calcium(9, 2.4, 1.17332);
                yield return new calcium(10, 4, 3.12273);
                yield return new calcium(11, 4, 2.60958);
                yield return new calcium(12, 4, 2.57429);
                yield return new calcium(13, 6.1, 3.17881);
                yield return new calcium(14, 6.1, 3.00782);
                yield return new calcium(15, 6.1, 2.67061);
                yield return new calcium(16, 8.05, 3.05959);
                yield return new calcium(17, 8.05, 3.94321);
                yield return new calcium(18, 8.05, 3.43726);
                yield return new calcium(19, 11.15, 4.80735);
                yield return new calcium(20, 11.15, 3.35583);
                yield return new calcium(21, 11.15, 2.78309);
                yield return new calcium(22, 13.15, 5.13825);
                yield return new calcium(23, 13.15, 4.70274);
                yield return new calcium(24, 13.15, 4.25702);
                yield return new calcium(25, 15, 3.60407);
                yield return new calcium(26, 15, 4.15029);
                yield return new calcium(27, 15, 3.42484);
            }
        }
    }
}
