// ReSharper disable All

namespace Rdatasets.vcd
{
    using System.Collections.Generic;

    /// <summary>
    /// Sex is Fun
    /// </summary>

    public class SexualFun
    {
        public readonly int κ;
        public readonly string Husband;
        public readonly string Wife;
        public readonly int Freq;

        public SexualFun(int κ, string Husband, string Wife, int Freq)
        {
            this.κ = κ;
            this.Husband = Husband;
            this.Wife = Wife;
            this.Freq = Freq;
        }

        public static IEnumerable<SexualFun> Data
        {
            get
            {
                yield return new SexualFun(1, "Never Fun", "Never Fun", 7);
                yield return new SexualFun(2, "Fairly Often", "Never Fun", 2);
                yield return new SexualFun(3, "Very Often", "Never Fun", 1);
                yield return new SexualFun(4, "Always fun", "Never Fun", 2);
                yield return new SexualFun(5, "Never Fun", "Fairly Often", 7);
                yield return new SexualFun(6, "Fairly Often", "Fairly Often", 8);
                yield return new SexualFun(7, "Very Often", "Fairly Often", 5);
                yield return new SexualFun(8, "Always fun", "Fairly Often", 8);
                yield return new SexualFun(9, "Never Fun", "Very Often", 2);
                yield return new SexualFun(10, "Fairly Often", "Very Often", 3);
                yield return new SexualFun(11, "Very Often", "Very Often", 4);
                yield return new SexualFun(12, "Always fun", "Very Often", 9);
                yield return new SexualFun(13, "Never Fun", "Always fun", 3);
                yield return new SexualFun(14, "Fairly Often", "Always fun", 7);
                yield return new SexualFun(15, "Very Often", "Always fun", 9);
                yield return new SexualFun(16, "Always fun", "Always fun", 14);
            }
        }
    }
}
