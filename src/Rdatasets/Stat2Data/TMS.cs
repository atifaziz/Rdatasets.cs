// ReSharper disable All

namespace Rdatasets.Stat2Data
{
    using System.Collections.Generic;

    /// <summary>
    /// TMS
    /// </summary>

    public class TMS
    {
        public readonly int κ;
        public readonly string Group;
        public readonly int Yes;
        public readonly int No;
        public readonly int Trials;

        public TMS(int κ, string Group, int Yes, int No, int Trials)
        {
            this.κ = κ;
            this.Group = Group;
            this.Yes = Yes;
            this.No = No;
            this.Trials = Trials;
        }

        public static IEnumerable<TMS> Data
        {
            get
            {
                yield return new TMS(1, "TMS", 39, 61, 100);
                yield return new TMS(2, "Placebo", 22, 78, 100);
            }
        }
    }
}
