// ReSharper disable All

namespace Rdatasets.vcd
{
    using System.Collections.Generic;

    /// <summary>
    /// Broken Marriage Data
    /// </summary>

    public class BrokenMarriage
    {
        public readonly int κ;
        public readonly int Freq;
        public readonly string gender;
        public readonly string rank;
        public readonly string broken;

        public BrokenMarriage(int κ, int Freq, string gender, string rank, string broken)
        {
            this.κ = κ;
            this.Freq = Freq;
            this.gender = gender;
            this.rank = rank;
            this.broken = broken;
        }

        public static IEnumerable<BrokenMarriage> Data
        {
            get
            {
                yield return new BrokenMarriage(1, 14, "male", "I", "yes");
                yield return new BrokenMarriage(2, 102, "male", "I", "no");
                yield return new BrokenMarriage(3, 39, "male", "II", "yes");
                yield return new BrokenMarriage(4, 151, "male", "II", "no");
                yield return new BrokenMarriage(5, 42, "male", "III", "yes");
                yield return new BrokenMarriage(6, 292, "male", "III", "no");
                yield return new BrokenMarriage(7, 79, "male", "IV", "yes");
                yield return new BrokenMarriage(8, 293, "male", "IV", "no");
                yield return new BrokenMarriage(9, 66, "male", "V", "yes");
                yield return new BrokenMarriage(10, 261, "male", "V", "no");
                yield return new BrokenMarriage(11, 12, "female", "I", "yes");
                yield return new BrokenMarriage(12, 25, "female", "I", "no");
                yield return new BrokenMarriage(13, 23, "female", "II", "yes");
                yield return new BrokenMarriage(14, 79, "female", "II", "no");
                yield return new BrokenMarriage(15, 37, "female", "III", "yes");
                yield return new BrokenMarriage(16, 151, "female", "III", "no");
                yield return new BrokenMarriage(17, 102, "female", "IV", "yes");
                yield return new BrokenMarriage(18, 557, "female", "IV", "no");
                yield return new BrokenMarriage(19, 58, "female", "V", "yes");
                yield return new BrokenMarriage(20, 321, "female", "V", "no");
            }
        }
    }
}
