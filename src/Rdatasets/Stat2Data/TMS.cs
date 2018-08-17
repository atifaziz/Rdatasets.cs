// ReSharper disable All

namespace Rdatasets.Stat2Data
{
    using System.Collections.Generic;

    /// <summary>
    /// TMS
    /// </summary>

    public class TMS
    {
        public readonly string Group;
        public readonly int Yes;
        public readonly int No;
        public readonly int Trials;

        public TMS(string Group, int Yes, int No, int Trials)
        {
            this.Group = Group;
            this.Yes = Yes;
            this.No = No;
            this.Trials = Trials;
        }

        public static IEnumerable<TMS> Data
        {
            get
            {
                yield return new TMS("TMS", 39, 61, 100);
                yield return new TMS("Placebo", 22, 78, 100);
            }
        }
    }
}
