// ReSharper disable All

namespace Rdatasets.HSAUR
{
    using System.Collections.Generic;

    /// <summary>
    /// Bladder Cancer Data
    /// </summary>

    public class bladdercancer
    {
        public readonly int κ;
        public readonly int time;
        public readonly string tumorsize;
        public readonly int number;

        public bladdercancer(int κ, int time, string tumorsize, int number)
        {
            this.κ = κ;
            this.time = time;
            this.tumorsize = tumorsize;
            this.number = number;
        }

        public static IEnumerable<bladdercancer> Data
        {
            get
            {
                yield return new bladdercancer(1, 2, "<=3cm", 1);
                yield return new bladdercancer(2, 3, "<=3cm", 1);
                yield return new bladdercancer(3, 6, "<=3cm", 1);
                yield return new bladdercancer(4, 8, "<=3cm", 1);
                yield return new bladdercancer(5, 9, "<=3cm", 1);
                yield return new bladdercancer(6, 10, "<=3cm", 1);
                yield return new bladdercancer(7, 11, "<=3cm", 1);
                yield return new bladdercancer(8, 13, "<=3cm", 1);
                yield return new bladdercancer(9, 14, "<=3cm", 1);
                yield return new bladdercancer(10, 16, "<=3cm", 1);
                yield return new bladdercancer(11, 21, "<=3cm", 1);
                yield return new bladdercancer(12, 22, "<=3cm", 1);
                yield return new bladdercancer(13, 24, "<=3cm", 1);
                yield return new bladdercancer(14, 26, "<=3cm", 1);
                yield return new bladdercancer(15, 27, "<=3cm", 1);
                yield return new bladdercancer(16, 7, "<=3cm", 2);
                yield return new bladdercancer(17, 13, "<=3cm", 2);
                yield return new bladdercancer(18, 15, "<=3cm", 2);
                yield return new bladdercancer(19, 18, "<=3cm", 2);
                yield return new bladdercancer(20, 23, "<=3cm", 2);
                yield return new bladdercancer(21, 20, "<=3cm", 3);
                yield return new bladdercancer(22, 24, "<=3cm", 4);
                yield return new bladdercancer(23, 1, ">3cm", 1);
                yield return new bladdercancer(24, 5, ">3cm", 1);
                yield return new bladdercancer(25, 17, ">3cm", 1);
                yield return new bladdercancer(26, 18, ">3cm", 1);
                yield return new bladdercancer(27, 25, ">3cm", 1);
                yield return new bladdercancer(28, 18, ">3cm", 2);
                yield return new bladdercancer(29, 25, ">3cm", 2);
                yield return new bladdercancer(30, 4, ">3cm", 3);
                yield return new bladdercancer(31, 19, ">3cm", 4);
            }
        }
    }
}
