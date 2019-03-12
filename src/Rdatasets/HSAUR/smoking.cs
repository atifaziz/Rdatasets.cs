// ReSharper disable All

namespace Rdatasets.HSAUR
{
    using System.Collections.Generic;

    /// <summary>
    /// Nicotine Gum and Smoking Cessation
    /// </summary>

    public class smoking
    {
        public readonly string κ;
        public readonly int qt;
        public readonly int tt;
        public readonly int qc;
        public readonly int tc;

        public smoking(string κ, int qt, int tt, int qc, int tc)
        {
            this.κ = κ;
            this.qt = qt;
            this.tt = tt;
            this.qc = qc;
            this.tc = tc;
        }

        public static IEnumerable<smoking> Data
        {
            get
            {
                yield return new smoking("Blondal89", 37, 92, 24, 90);
                yield return new smoking("Campbell91", 21, 107, 21, 105);
                yield return new smoking("Fagerstrom82", 30, 50, 23, 50);
                yield return new smoking("Fee82", 23, 180, 15, 172);
                yield return new smoking("Garcia89", 21, 68, 5, 38);
                yield return new smoking("Garvey00", 75, 405, 17, 203);
                yield return new smoking("Gross95", 37, 131, 6, 46);
                yield return new smoking("Hall85", 18, 41, 10, 36);
                yield return new smoking("Hall87", 30, 71, 14, 68);
                yield return new smoking("Hall96", 24, 98, 28, 103);
                yield return new smoking("Hjalmarson84", 31, 106, 16, 100);
                yield return new smoking("Huber88", 31, 54, 11, 60);
                yield return new smoking("Jarvis82", 22, 58, 9, 58);
                yield return new smoking("Jensen91", 90, 211, 28, 82);
                yield return new smoking("Killen84", 16, 44, 6, 20);
                yield return new smoking("Killen90", 129, 600, 112, 617);
                yield return new smoking("Malcolm80", 6, 73, 3, 121);
                yield return new smoking("McGovern92", 51, 146, 40, 127);
                yield return new smoking("Nakamura90", 13, 30, 5, 30);
                yield return new smoking("Niaura94", 5, 84, 4, 89);
                yield return new smoking("Pirie92", 75, 206, 50, 211);
                yield return new smoking("Puska79", 29, 116, 21, 113);
                yield return new smoking("Schneider85", 9, 30, 6, 30);
                yield return new smoking("Tonnesen88", 23, 60, 12, 53);
                yield return new smoking("Villa99", 11, 21, 10, 26);
                yield return new smoking("Zelman92", 23, 58, 18, 58);
            }
        }
    }
}
