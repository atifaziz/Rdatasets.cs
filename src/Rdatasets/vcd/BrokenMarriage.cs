// ReSharper disable All

namespace Rdatasets.vcd
{
    using System.Collections.Generic;

    /// <summary>
    /// Broken Marriage Data
    /// </summary>

    public class BrokenMarriage
    {
        public readonly int Freq;
        public readonly string gender;
        public readonly string rank;
        public readonly string broken;

        public BrokenMarriage(int Freq, string gender, string rank, string broken)
        {
            this.Freq = Freq;
            this.gender = gender;
            this.rank = rank;
            this.broken = broken;
        }

        public static IEnumerable<BrokenMarriage> Data
        {
            get
            {
                yield return new BrokenMarriage(14, "male", "I", "yes");
                yield return new BrokenMarriage(102, "male", "I", "no");
                yield return new BrokenMarriage(39, "male", "II", "yes");
                yield return new BrokenMarriage(151, "male", "II", "no");
                yield return new BrokenMarriage(42, "male", "III", "yes");
                yield return new BrokenMarriage(292, "male", "III", "no");
                yield return new BrokenMarriage(79, "male", "IV", "yes");
                yield return new BrokenMarriage(293, "male", "IV", "no");
                yield return new BrokenMarriage(66, "male", "V", "yes");
                yield return new BrokenMarriage(261, "male", "V", "no");
                yield return new BrokenMarriage(12, "female", "I", "yes");
                yield return new BrokenMarriage(25, "female", "I", "no");
                yield return new BrokenMarriage(23, "female", "II", "yes");
                yield return new BrokenMarriage(79, "female", "II", "no");
                yield return new BrokenMarriage(37, "female", "III", "yes");
                yield return new BrokenMarriage(151, "female", "III", "no");
                yield return new BrokenMarriage(102, "female", "IV", "yes");
                yield return new BrokenMarriage(557, "female", "IV", "no");
                yield return new BrokenMarriage(58, "female", "V", "yes");
                yield return new BrokenMarriage(321, "female", "V", "no");
            }
        }
    }
}
