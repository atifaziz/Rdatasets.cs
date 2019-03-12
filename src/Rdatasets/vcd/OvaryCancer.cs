// ReSharper disable All

namespace Rdatasets.vcd
{
    using System.Collections.Generic;

    /// <summary>
    /// Ovary Cancer Data
    /// </summary>

    public class OvaryCancer
    {
        public readonly int κ;
        public readonly int Freq;
        public readonly string stage;
        public readonly string operation;
        public readonly string survival;
        public readonly string xray;

        public OvaryCancer(int κ, int Freq, string stage, string operation, string survival, string xray)
        {
            this.κ = κ;
            this.Freq = Freq;
            this.stage = stage;
            this.operation = operation;
            this.survival = survival;
            this.xray = xray;
        }

        public static IEnumerable<OvaryCancer> Data
        {
            get
            {
                yield return new OvaryCancer(1, 10, "early", "radical", "no", "no");
                yield return new OvaryCancer(2, 17, "early", "radical", "no", "yes");
                yield return new OvaryCancer(3, 41, "early", "radical", "yes", "no");
                yield return new OvaryCancer(4, 64, "early", "radical", "yes", "yes");
                yield return new OvaryCancer(5, 1, "early", "limited", "no", "no");
                yield return new OvaryCancer(6, 3, "early", "limited", "no", "yes");
                yield return new OvaryCancer(7, 13, "early", "limited", "yes", "no");
                yield return new OvaryCancer(8, 9, "early", "limited", "yes", "yes");
                yield return new OvaryCancer(9, 38, "advanced", "radical", "no", "no");
                yield return new OvaryCancer(10, 64, "advanced", "radical", "no", "yes");
                yield return new OvaryCancer(11, 6, "advanced", "radical", "yes", "no");
                yield return new OvaryCancer(12, 11, "advanced", "radical", "yes", "yes");
                yield return new OvaryCancer(13, 3, "advanced", "limited", "no", "no");
                yield return new OvaryCancer(14, 13, "advanced", "limited", "no", "yes");
                yield return new OvaryCancer(15, 1, "advanced", "limited", "yes", "no");
                yield return new OvaryCancer(16, 5, "advanced", "limited", "yes", "yes");
            }
        }
    }
}
