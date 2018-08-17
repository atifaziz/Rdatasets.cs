// ReSharper disable All

namespace Rdatasets.vcd
{
    using System.Collections.Generic;

    /// <summary>
    /// Ovary Cancer Data
    /// </summary>

    public class OvaryCancer
    {
        public readonly int Freq;
        public readonly string stage;
        public readonly string operation;
        public readonly string survival;
        public readonly string xray;

        public OvaryCancer(int Freq, string stage, string operation, string survival, string xray)
        {
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
                yield return new OvaryCancer(10, "early", "radical", "no", "no");
                yield return new OvaryCancer(17, "early", "radical", "no", "yes");
                yield return new OvaryCancer(41, "early", "radical", "yes", "no");
                yield return new OvaryCancer(64, "early", "radical", "yes", "yes");
                yield return new OvaryCancer(1, "early", "limited", "no", "no");
                yield return new OvaryCancer(3, "early", "limited", "no", "yes");
                yield return new OvaryCancer(13, "early", "limited", "yes", "no");
                yield return new OvaryCancer(9, "early", "limited", "yes", "yes");
                yield return new OvaryCancer(38, "advanced", "radical", "no", "no");
                yield return new OvaryCancer(64, "advanced", "radical", "no", "yes");
                yield return new OvaryCancer(6, "advanced", "radical", "yes", "no");
                yield return new OvaryCancer(11, "advanced", "radical", "yes", "yes");
                yield return new OvaryCancer(3, "advanced", "limited", "no", "no");
                yield return new OvaryCancer(13, "advanced", "limited", "no", "yes");
                yield return new OvaryCancer(1, "advanced", "limited", "yes", "no");
                yield return new OvaryCancer(5, "advanced", "limited", "yes", "yes");
            }
        }
    }
}
