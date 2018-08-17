// ReSharper disable All

namespace Rdatasets.vcd
{
    using System.Collections.Generic;

    /// <summary>
    /// Sex is Fun
    /// </summary>

    public class SexualFun
    {
        public readonly string Husband;
        public readonly string Wife;
        public readonly int Freq;

        public SexualFun(string Husband, string Wife, int Freq)
        {
            this.Husband = Husband;
            this.Wife = Wife;
            this.Freq = Freq;
        }

        public static IEnumerable<SexualFun> Data
        {
            get
            {
                yield return new SexualFun("Never Fun", "Never Fun", 7);
                yield return new SexualFun("Fairly Often", "Never Fun", 2);
                yield return new SexualFun("Very Often", "Never Fun", 1);
                yield return new SexualFun("Always fun", "Never Fun", 2);
                yield return new SexualFun("Never Fun", "Fairly Often", 7);
                yield return new SexualFun("Fairly Often", "Fairly Often", 8);
                yield return new SexualFun("Very Often", "Fairly Often", 5);
                yield return new SexualFun("Always fun", "Fairly Often", 8);
                yield return new SexualFun("Never Fun", "Very Often", 2);
                yield return new SexualFun("Fairly Often", "Very Often", 3);
                yield return new SexualFun("Very Often", "Very Often", 4);
                yield return new SexualFun("Always fun", "Very Often", 9);
                yield return new SexualFun("Never Fun", "Always fun", 3);
                yield return new SexualFun("Fairly Often", "Always fun", 7);
                yield return new SexualFun("Very Often", "Always fun", 9);
                yield return new SexualFun("Always fun", "Always fun", 14);
            }
        }
    }
}
