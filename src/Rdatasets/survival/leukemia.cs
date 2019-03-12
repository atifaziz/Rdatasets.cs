// ReSharper disable All

namespace Rdatasets.survival
{
    using System.Collections.Generic;

    /// <summary>
    /// Acute Myelogenous Leukemia survival data
    /// </summary>

    public class leukemia
    {
        public readonly int κ;
        public readonly int time;
        public readonly int status;
        public readonly string x;

        public leukemia(int κ, int time, int status, string x)
        {
            this.κ = κ;
            this.time = time;
            this.status = status;
            this.x = x;
        }

        public static IEnumerable<leukemia> Data
        {
            get
            {
                yield return new leukemia(1, 9, 1, "Maintained");
                yield return new leukemia(2, 13, 1, "Maintained");
                yield return new leukemia(3, 13, 0, "Maintained");
                yield return new leukemia(4, 18, 1, "Maintained");
                yield return new leukemia(5, 23, 1, "Maintained");
                yield return new leukemia(6, 28, 0, "Maintained");
                yield return new leukemia(7, 31, 1, "Maintained");
                yield return new leukemia(8, 34, 1, "Maintained");
                yield return new leukemia(9, 45, 0, "Maintained");
                yield return new leukemia(10, 48, 1, "Maintained");
                yield return new leukemia(11, 161, 0, "Maintained");
                yield return new leukemia(12, 5, 1, "Nonmaintained");
                yield return new leukemia(13, 5, 1, "Nonmaintained");
                yield return new leukemia(14, 8, 1, "Nonmaintained");
                yield return new leukemia(15, 8, 1, "Nonmaintained");
                yield return new leukemia(16, 12, 1, "Nonmaintained");
                yield return new leukemia(17, 16, 0, "Nonmaintained");
                yield return new leukemia(18, 23, 1, "Nonmaintained");
                yield return new leukemia(19, 27, 1, "Nonmaintained");
                yield return new leukemia(20, 30, 1, "Nonmaintained");
                yield return new leukemia(21, 33, 1, "Nonmaintained");
                yield return new leukemia(22, 43, 1, "Nonmaintained");
                yield return new leukemia(23, 45, 1, "Nonmaintained");
            }
        }
    }
}
