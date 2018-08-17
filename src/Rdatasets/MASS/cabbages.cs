// ReSharper disable All

namespace Rdatasets.MASS
{
    using System.Collections.Generic;

    /// <summary>
    /// Data from a cabbage field trial
    /// </summary>

    public class cabbages
    {
        public readonly string Cult;
        public readonly string Date;
        public readonly double HeadWt;
        public readonly int VitC;

        public cabbages(string Cult, string Date, double HeadWt, int VitC)
        {
            this.Cult = Cult;
            this.Date = Date;
            this.HeadWt = HeadWt;
            this.VitC = VitC;
        }

        public static IEnumerable<cabbages> Data
        {
            get
            {
                yield return new cabbages("c39", "d16", 2.5, 51);
                yield return new cabbages("c39", "d16", 2.2, 55);
                yield return new cabbages("c39", "d16", 3.1, 45);
                yield return new cabbages("c39", "d16", 4.3, 42);
                yield return new cabbages("c39", "d16", 2.5, 53);
                yield return new cabbages("c39", "d16", 4.3, 50);
                yield return new cabbages("c39", "d16", 3.8, 50);
                yield return new cabbages("c39", "d16", 4.3, 52);
                yield return new cabbages("c39", "d16", 1.7, 56);
                yield return new cabbages("c39", "d16", 3.1, 49);
                yield return new cabbages("c39", "d20", 3, 65);
                yield return new cabbages("c39", "d20", 2.8, 52);
                yield return new cabbages("c39", "d20", 2.8, 41);
                yield return new cabbages("c39", "d20", 2.7, 51);
                yield return new cabbages("c39", "d20", 2.6, 41);
                yield return new cabbages("c39", "d20", 2.8, 45);
                yield return new cabbages("c39", "d20", 2.6, 51);
                yield return new cabbages("c39", "d20", 2.6, 45);
                yield return new cabbages("c39", "d20", 2.6, 61);
                yield return new cabbages("c39", "d20", 3.5, 42);
                yield return new cabbages("c39", "d21", 2.2, 54);
                yield return new cabbages("c39", "d21", 1.8, 59);
                yield return new cabbages("c39", "d21", 1.6, 66);
                yield return new cabbages("c39", "d21", 2.1, 54);
                yield return new cabbages("c39", "d21", 3.3, 45);
                yield return new cabbages("c39", "d21", 3.8, 49);
                yield return new cabbages("c39", "d21", 3.2, 49);
                yield return new cabbages("c39", "d21", 3.6, 55);
                yield return new cabbages("c39", "d21", 4.2, 49);
                yield return new cabbages("c39", "d21", 1.6, 68);
                yield return new cabbages("c52", "d16", 2, 58);
                yield return new cabbages("c52", "d16", 2.4, 55);
                yield return new cabbages("c52", "d16", 1.9, 67);
                yield return new cabbages("c52", "d16", 2.8, 61);
                yield return new cabbages("c52", "d16", 1.7, 67);
                yield return new cabbages("c52", "d16", 3.2, 68);
                yield return new cabbages("c52", "d16", 2, 58);
                yield return new cabbages("c52", "d16", 2.2, 63);
                yield return new cabbages("c52", "d16", 2.2, 56);
                yield return new cabbages("c52", "d16", 2.2, 72);
                yield return new cabbages("c52", "d20", 4, 52);
                yield return new cabbages("c52", "d20", 2.8, 70);
                yield return new cabbages("c52", "d20", 3.1, 57);
                yield return new cabbages("c52", "d20", 4.2, 58);
                yield return new cabbages("c52", "d20", 3.7, 47);
                yield return new cabbages("c52", "d20", 3, 56);
                yield return new cabbages("c52", "d20", 2.2, 72);
                yield return new cabbages("c52", "d20", 2.3, 63);
                yield return new cabbages("c52", "d20", 3.8, 54);
                yield return new cabbages("c52", "d20", 2, 60);
                yield return new cabbages("c52", "d21", 1.5, 78);
                yield return new cabbages("c52", "d21", 1.4, 75);
                yield return new cabbages("c52", "d21", 1.7, 70);
                yield return new cabbages("c52", "d21", 1.3, 84);
                yield return new cabbages("c52", "d21", 1.7, 71);
                yield return new cabbages("c52", "d21", 1.6, 72);
                yield return new cabbages("c52", "d21", 1.4, 62);
                yield return new cabbages("c52", "d21", 1, 68);
                yield return new cabbages("c52", "d21", 1.5, 66);
                yield return new cabbages("c52", "d21", 1.6, 72);
            }
        }
    }
}
