// ReSharper disable All

namespace Rdatasets.vcd
{
    using System.Collections.Generic;

    /// <summary>
    /// Employment Status
    /// </summary>

    public class Employment
    {
        public readonly int κ;
        public readonly string EmploymentStatus;
        public readonly string EmploymentLength;
        public readonly string LayoffCause;
        public readonly int Freq;

        public Employment(int κ, string EmploymentStatus, string EmploymentLength, string LayoffCause, int Freq)
        {
            this.κ = κ;
            this.EmploymentStatus = EmploymentStatus;
            this.EmploymentLength = EmploymentLength;
            this.LayoffCause = LayoffCause;
            this.Freq = Freq;
        }

        public static IEnumerable<Employment> Data
        {
            get
            {
                yield return new Employment(1, "NewJob", "<1Mo", "Closure", 8);
                yield return new Employment(2, "Unemployed", "<1Mo", "Closure", 10);
                yield return new Employment(3, "NewJob", "1-3Mo", "Closure", 35);
                yield return new Employment(4, "Unemployed", "1-3Mo", "Closure", 42);
                yield return new Employment(5, "NewJob", "3-12Mo", "Closure", 70);
                yield return new Employment(6, "Unemployed", "3-12Mo", "Closure", 86);
                yield return new Employment(7, "NewJob", "1-2Yr", "Closure", 62);
                yield return new Employment(8, "Unemployed", "1-2Yr", "Closure", 80);
                yield return new Employment(9, "NewJob", "2-5Yr", "Closure", 56);
                yield return new Employment(10, "Unemployed", "2-5Yr", "Closure", 67);
                yield return new Employment(11, "NewJob", ">5Yr", "Closure", 38);
                yield return new Employment(12, "Unemployed", ">5Yr", "Closure", 35);
                yield return new Employment(13, "NewJob", "<1Mo", "Replaced", 40);
                yield return new Employment(14, "Unemployed", "<1Mo", "Replaced", 24);
                yield return new Employment(15, "NewJob", "1-3Mo", "Replaced", 85);
                yield return new Employment(16, "Unemployed", "1-3Mo", "Replaced", 42);
                yield return new Employment(17, "NewJob", "3-12Mo", "Replaced", 181);
                yield return new Employment(18, "Unemployed", "3-12Mo", "Replaced", 41);
                yield return new Employment(19, "NewJob", "1-2Yr", "Replaced", 85);
                yield return new Employment(20, "Unemployed", "1-2Yr", "Replaced", 16);
                yield return new Employment(21, "NewJob", "2-5Yr", "Replaced", 118);
                yield return new Employment(22, "Unemployed", "2-5Yr", "Replaced", 27);
                yield return new Employment(23, "NewJob", ">5Yr", "Replaced", 56);
                yield return new Employment(24, "Unemployed", ">5Yr", "Replaced", 10);
            }
        }
    }
}
