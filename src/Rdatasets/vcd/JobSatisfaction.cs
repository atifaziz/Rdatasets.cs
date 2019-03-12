// ReSharper disable All

namespace Rdatasets.vcd
{
    using System.Collections.Generic;

    /// <summary>
    /// Job Satisfaction Data
    /// </summary>

    public class JobSatisfaction
    {
        public readonly int κ;
        public readonly int Freq;
        public readonly string management;
        public readonly string supervisor;
        public readonly string own;

        public JobSatisfaction(int κ, int Freq, string management, string supervisor, string own)
        {
            this.κ = κ;
            this.Freq = Freq;
            this.management = management;
            this.supervisor = supervisor;
            this.own = own;
        }

        public static IEnumerable<JobSatisfaction> Data
        {
            get
            {
                yield return new JobSatisfaction(1, 103, "bad", "low", "low");
                yield return new JobSatisfaction(2, 87, "bad", "low", "high");
                yield return new JobSatisfaction(3, 32, "bad", "high", "low");
                yield return new JobSatisfaction(4, 42, "bad", "high", "high");
                yield return new JobSatisfaction(5, 59, "good", "low", "low");
                yield return new JobSatisfaction(6, 109, "good", "low", "high");
                yield return new JobSatisfaction(7, 78, "good", "high", "low");
                yield return new JobSatisfaction(8, 205, "good", "high", "high");
            }
        }
    }
}
