// ReSharper disable All

namespace Rdatasets.HSAUR
{
    using System.Collections.Generic;

    /// <summary>
    /// Bladder Cancer Data
    /// </summary>

    public class bladdercancer
    {
        public readonly int time;
        public readonly string tumorsize;
        public readonly int number;

        public bladdercancer(int time, string tumorsize, int number)
        {
            this.time = time;
            this.tumorsize = tumorsize;
            this.number = number;
        }

        public static IEnumerable<bladdercancer> Data
        {
            get
            {
                yield return new bladdercancer(2, "<=3cm", 1);
                yield return new bladdercancer(3, "<=3cm", 1);
                yield return new bladdercancer(6, "<=3cm", 1);
                yield return new bladdercancer(8, "<=3cm", 1);
                yield return new bladdercancer(9, "<=3cm", 1);
                yield return new bladdercancer(10, "<=3cm", 1);
                yield return new bladdercancer(11, "<=3cm", 1);
                yield return new bladdercancer(13, "<=3cm", 1);
                yield return new bladdercancer(14, "<=3cm", 1);
                yield return new bladdercancer(16, "<=3cm", 1);
                yield return new bladdercancer(21, "<=3cm", 1);
                yield return new bladdercancer(22, "<=3cm", 1);
                yield return new bladdercancer(24, "<=3cm", 1);
                yield return new bladdercancer(26, "<=3cm", 1);
                yield return new bladdercancer(27, "<=3cm", 1);
                yield return new bladdercancer(7, "<=3cm", 2);
                yield return new bladdercancer(13, "<=3cm", 2);
                yield return new bladdercancer(15, "<=3cm", 2);
                yield return new bladdercancer(18, "<=3cm", 2);
                yield return new bladdercancer(23, "<=3cm", 2);
                yield return new bladdercancer(20, "<=3cm", 3);
                yield return new bladdercancer(24, "<=3cm", 4);
                yield return new bladdercancer(1, ">3cm", 1);
                yield return new bladdercancer(5, ">3cm", 1);
                yield return new bladdercancer(17, ">3cm", 1);
                yield return new bladdercancer(18, ">3cm", 1);
                yield return new bladdercancer(25, ">3cm", 1);
                yield return new bladdercancer(18, ">3cm", 2);
                yield return new bladdercancer(25, ">3cm", 2);
                yield return new bladdercancer(4, ">3cm", 3);
                yield return new bladdercancer(19, ">3cm", 4);
            }
        }
    }
}
