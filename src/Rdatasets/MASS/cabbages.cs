// ReSharper disable All

namespace Rdatasets.MASS
{
    using System.Collections.Generic;

    /// <summary>
    /// Data from a cabbage field trial
    /// </summary>

    public class cabbages
    {
        public readonly int κ;
        public readonly string Cult;
        public readonly string Date;
        public readonly double HeadWt;
        public readonly int VitC;

        public cabbages(int κ, string Cult, string Date, double HeadWt, int VitC)
        {
            this.κ = κ;
            this.Cult = Cult;
            this.Date = Date;
            this.HeadWt = HeadWt;
            this.VitC = VitC;
        }

        public static IEnumerable<cabbages> Data
        {
            get
            {
                yield return new cabbages(1, "c39", "d16", 2.5, 51);
                yield return new cabbages(2, "c39", "d16", 2.2, 55);
                yield return new cabbages(3, "c39", "d16", 3.1, 45);
                yield return new cabbages(4, "c39", "d16", 4.3, 42);
                yield return new cabbages(5, "c39", "d16", 2.5, 53);
                yield return new cabbages(6, "c39", "d16", 4.3, 50);
                yield return new cabbages(7, "c39", "d16", 3.8, 50);
                yield return new cabbages(8, "c39", "d16", 4.3, 52);
                yield return new cabbages(9, "c39", "d16", 1.7, 56);
                yield return new cabbages(10, "c39", "d16", 3.1, 49);
                yield return new cabbages(11, "c39", "d20", 3, 65);
                yield return new cabbages(12, "c39", "d20", 2.8, 52);
                yield return new cabbages(13, "c39", "d20", 2.8, 41);
                yield return new cabbages(14, "c39", "d20", 2.7, 51);
                yield return new cabbages(15, "c39", "d20", 2.6, 41);
                yield return new cabbages(16, "c39", "d20", 2.8, 45);
                yield return new cabbages(17, "c39", "d20", 2.6, 51);
                yield return new cabbages(18, "c39", "d20", 2.6, 45);
                yield return new cabbages(19, "c39", "d20", 2.6, 61);
                yield return new cabbages(20, "c39", "d20", 3.5, 42);
                yield return new cabbages(21, "c39", "d21", 2.2, 54);
                yield return new cabbages(22, "c39", "d21", 1.8, 59);
                yield return new cabbages(23, "c39", "d21", 1.6, 66);
                yield return new cabbages(24, "c39", "d21", 2.1, 54);
                yield return new cabbages(25, "c39", "d21", 3.3, 45);
                yield return new cabbages(26, "c39", "d21", 3.8, 49);
                yield return new cabbages(27, "c39", "d21", 3.2, 49);
                yield return new cabbages(28, "c39", "d21", 3.6, 55);
                yield return new cabbages(29, "c39", "d21", 4.2, 49);
                yield return new cabbages(30, "c39", "d21", 1.6, 68);
                yield return new cabbages(31, "c52", "d16", 2, 58);
                yield return new cabbages(32, "c52", "d16", 2.4, 55);
                yield return new cabbages(33, "c52", "d16", 1.9, 67);
                yield return new cabbages(34, "c52", "d16", 2.8, 61);
                yield return new cabbages(35, "c52", "d16", 1.7, 67);
                yield return new cabbages(36, "c52", "d16", 3.2, 68);
                yield return new cabbages(37, "c52", "d16", 2, 58);
                yield return new cabbages(38, "c52", "d16", 2.2, 63);
                yield return new cabbages(39, "c52", "d16", 2.2, 56);
                yield return new cabbages(40, "c52", "d16", 2.2, 72);
                yield return new cabbages(41, "c52", "d20", 4, 52);
                yield return new cabbages(42, "c52", "d20", 2.8, 70);
                yield return new cabbages(43, "c52", "d20", 3.1, 57);
                yield return new cabbages(44, "c52", "d20", 4.2, 58);
                yield return new cabbages(45, "c52", "d20", 3.7, 47);
                yield return new cabbages(46, "c52", "d20", 3, 56);
                yield return new cabbages(47, "c52", "d20", 2.2, 72);
                yield return new cabbages(48, "c52", "d20", 2.3, 63);
                yield return new cabbages(49, "c52", "d20", 3.8, 54);
                yield return new cabbages(50, "c52", "d20", 2, 60);
                yield return new cabbages(51, "c52", "d21", 1.5, 78);
                yield return new cabbages(52, "c52", "d21", 1.4, 75);
                yield return new cabbages(53, "c52", "d21", 1.7, 70);
                yield return new cabbages(54, "c52", "d21", 1.3, 84);
                yield return new cabbages(55, "c52", "d21", 1.7, 71);
                yield return new cabbages(56, "c52", "d21", 1.6, 72);
                yield return new cabbages(57, "c52", "d21", 1.4, 62);
                yield return new cabbages(58, "c52", "d21", 1, 68);
                yield return new cabbages(59, "c52", "d21", 1.5, 66);
                yield return new cabbages(60, "c52", "d21", 1.6, 72);
            }
        }
    }
}
