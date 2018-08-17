// ReSharper disable All

namespace Rdatasets.vcd
{
    using System.Collections.Generic;

    /// <summary>
    /// Job Satisfaction Data
    /// </summary>

    public class JobSatisfaction
    {
        public readonly int Freq;
        public readonly string management;
        public readonly string supervisor;
        public readonly string own;

        public JobSatisfaction(int Freq, string management, string supervisor, string own)
        {
            this.Freq = Freq;
            this.management = management;
            this.supervisor = supervisor;
            this.own = own;
        }

        public static IEnumerable<JobSatisfaction> Data
        {
            get
            {
                yield return new JobSatisfaction(103, "bad", "low", "low");
                yield return new JobSatisfaction(87, "bad", "low", "high");
                yield return new JobSatisfaction(32, "bad", "high", "low");
                yield return new JobSatisfaction(42, "bad", "high", "high");
                yield return new JobSatisfaction(59, "good", "low", "low");
                yield return new JobSatisfaction(109, "good", "low", "high");
                yield return new JobSatisfaction(78, "good", "high", "low");
                yield return new JobSatisfaction(205, "good", "high", "high");
            }
        }
    }
}
