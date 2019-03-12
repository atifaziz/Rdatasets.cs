// ReSharper disable All

namespace Rdatasets.HSAUR
{
    using System.Collections.Generic;

    /// <summary>
    /// CYG OB1 Star Cluster Data
    /// </summary>

    public class CYGOB1
    {
        public readonly string κ;
        public readonly double logst;
        public readonly double logli;

        public CYGOB1(string κ, double logst, double logli)
        {
            this.κ = κ;
            this.logst = logst;
            this.logli = logli;
        }

        public static IEnumerable<CYGOB1> Data
        {
            get
            {
                yield return new CYGOB1("[1,]", 4.37, 5.23);
                yield return new CYGOB1("[2,]", 4.56, 5.74);
                yield return new CYGOB1("[3,]", 4.26, 4.93);
                yield return new CYGOB1("[4,]", 4.56, 5.74);
                yield return new CYGOB1("[5,]", 4.3, 5.19);
                yield return new CYGOB1("[6,]", 4.46, 5.46);
                yield return new CYGOB1("[7,]", 3.84, 4.65);
                yield return new CYGOB1("[8,]", 4.57, 5.27);
                yield return new CYGOB1("[9,]", 4.26, 5.57);
                yield return new CYGOB1("[10,]", 4.37, 5.12);
                yield return new CYGOB1("[11,]", 3.49, 5.73);
                yield return new CYGOB1("[12,]", 4.43, 5.45);
                yield return new CYGOB1("[13,]", 4.48, 5.42);
                yield return new CYGOB1("[14,]", 4.01, 4.05);
                yield return new CYGOB1("[15,]", 4.29, 4.26);
                yield return new CYGOB1("[16,]", 4.42, 4.58);
                yield return new CYGOB1("[17,]", 4.23, 3.94);
                yield return new CYGOB1("[18,]", 4.42, 4.18);
                yield return new CYGOB1("[19,]", 4.23, 4.18);
                yield return new CYGOB1("[20,]", 3.49, 5.89);
                yield return new CYGOB1("[21,]", 4.29, 4.38);
                yield return new CYGOB1("[22,]", 4.29, 4.22);
                yield return new CYGOB1("[23,]", 4.42, 4.42);
                yield return new CYGOB1("[24,]", 4.49, 4.85);
                yield return new CYGOB1("[25,]", 4.38, 5.02);
                yield return new CYGOB1("[26,]", 4.42, 4.66);
                yield return new CYGOB1("[27,]", 4.29, 4.66);
                yield return new CYGOB1("[28,]", 4.38, 4.9);
                yield return new CYGOB1("[29,]", 4.22, 4.39);
                yield return new CYGOB1("[30,]", 3.48, 6.05);
                yield return new CYGOB1("[31,]", 4.38, 4.42);
                yield return new CYGOB1("[32,]", 4.56, 5.1);
                yield return new CYGOB1("[33,]", 4.45, 5.22);
                yield return new CYGOB1("[34,]", 3.49, 6.29);
                yield return new CYGOB1("[35,]", 4.23, 4.34);
                yield return new CYGOB1("[36,]", 4.62, 5.62);
                yield return new CYGOB1("[37,]", 4.53, 5.1);
                yield return new CYGOB1("[38,]", 4.45, 5.22);
                yield return new CYGOB1("[39,]", 4.53, 5.18);
                yield return new CYGOB1("[40,]", 4.43, 5.57);
                yield return new CYGOB1("[41,]", 4.38, 4.62);
                yield return new CYGOB1("[42,]", 4.45, 5.06);
                yield return new CYGOB1("[43,]", 4.5, 5.34);
                yield return new CYGOB1("[44,]", 4.45, 5.34);
                yield return new CYGOB1("[45,]", 4.55, 5.54);
                yield return new CYGOB1("[46,]", 4.45, 4.98);
                yield return new CYGOB1("[47,]", 4.42, 4.5);
            }
        }
    }
}
