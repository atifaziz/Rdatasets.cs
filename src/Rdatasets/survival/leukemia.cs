// ReSharper disable All

namespace Rdatasets.survival
{
    using System.Collections.Generic;

    /// <summary>
    /// Acute Myelogenous Leukemia survival data
    /// </summary>

    public class leukemia
    {
        public readonly int time;
        public readonly int status;
        public readonly string x;

        public leukemia(int time, int status, string x)
        {
            this.time = time;
            this.status = status;
            this.x = x;
        }

        public static IEnumerable<leukemia> Data
        {
            get
            {
                yield return new leukemia(9, 1, "Maintained");
                yield return new leukemia(13, 1, "Maintained");
                yield return new leukemia(13, 0, "Maintained");
                yield return new leukemia(18, 1, "Maintained");
                yield return new leukemia(23, 1, "Maintained");
                yield return new leukemia(28, 0, "Maintained");
                yield return new leukemia(31, 1, "Maintained");
                yield return new leukemia(34, 1, "Maintained");
                yield return new leukemia(45, 0, "Maintained");
                yield return new leukemia(48, 1, "Maintained");
                yield return new leukemia(161, 0, "Maintained");
                yield return new leukemia(5, 1, "Nonmaintained");
                yield return new leukemia(5, 1, "Nonmaintained");
                yield return new leukemia(8, 1, "Nonmaintained");
                yield return new leukemia(8, 1, "Nonmaintained");
                yield return new leukemia(12, 1, "Nonmaintained");
                yield return new leukemia(16, 0, "Nonmaintained");
                yield return new leukemia(23, 1, "Nonmaintained");
                yield return new leukemia(27, 1, "Nonmaintained");
                yield return new leukemia(30, 1, "Nonmaintained");
                yield return new leukemia(33, 1, "Nonmaintained");
                yield return new leukemia(43, 1, "Nonmaintained");
                yield return new leukemia(45, 1, "Nonmaintained");
            }
        }
    }
}
