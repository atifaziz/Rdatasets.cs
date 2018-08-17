// ReSharper disable All

namespace Rdatasets.HSAUR
{
    using System.Collections.Generic;

    /// <summary>
    /// Nicotine Gum and Smoking Cessation
    /// </summary>

    public class smoking
    {
        public readonly int qt;
        public readonly int tt;
        public readonly int qc;
        public readonly int tc;

        public smoking(int qt, int tt, int qc, int tc)
        {
            this.qt = qt;
            this.tt = tt;
            this.qc = qc;
            this.tc = tc;
        }

        public static IEnumerable<smoking> Data
        {
            get
            {
                yield return new smoking(37, 92, 24, 90);
                yield return new smoking(21, 107, 21, 105);
                yield return new smoking(30, 50, 23, 50);
                yield return new smoking(23, 180, 15, 172);
                yield return new smoking(21, 68, 5, 38);
                yield return new smoking(75, 405, 17, 203);
                yield return new smoking(37, 131, 6, 46);
                yield return new smoking(18, 41, 10, 36);
                yield return new smoking(30, 71, 14, 68);
                yield return new smoking(24, 98, 28, 103);
                yield return new smoking(31, 106, 16, 100);
                yield return new smoking(31, 54, 11, 60);
                yield return new smoking(22, 58, 9, 58);
                yield return new smoking(90, 211, 28, 82);
                yield return new smoking(16, 44, 6, 20);
                yield return new smoking(129, 600, 112, 617);
                yield return new smoking(6, 73, 3, 121);
                yield return new smoking(51, 146, 40, 127);
                yield return new smoking(13, 30, 5, 30);
                yield return new smoking(5, 84, 4, 89);
                yield return new smoking(75, 206, 50, 211);
                yield return new smoking(29, 116, 21, 113);
                yield return new smoking(9, 30, 6, 30);
                yield return new smoking(23, 60, 12, 53);
                yield return new smoking(11, 21, 10, 26);
                yield return new smoking(23, 58, 18, 58);
            }
        }
    }
}
