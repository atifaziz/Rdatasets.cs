// ReSharper disable All

namespace Rdatasets.Ecdat
{
    using System.Collections.Generic;

    /// <summary>
    /// Statewide Data on Transportation Equipment Manufacturing
    /// </summary>

    public class TranspEq
    {
        public readonly string state;
        public readonly double va;
        public readonly double capital;
        public readonly double labor;
        public readonly int nfirm;

        public TranspEq(string state, double va, double capital, double labor, int nfirm)
        {
            this.state = state;
            this.va = va;
            this.capital = capital;
            this.labor = labor;
            this.nfirm = nfirm;
        }

        public static IEnumerable<TranspEq> Data
        {
            get
            {
                yield return new TranspEq("Alabama", 126.148, 3.804, 31.551, 68);
                yield return new TranspEq("California", 3201.486, 185.446, 452.844, 1372);
                yield return new TranspEq("Connecticut", 690.67, 39.712, 124.074, 154);
                yield return new TranspEq("Florida", 56.296, 6.547, 19.181, 292);
                yield return new TranspEq("Georgia", 304.531, 11.53, 45.534, 71);
                yield return new TranspEq("Illinois", 723.028, 58.987, 88.391, 275);
                yield return new TranspEq("Indiana", 992.169, 112.884, 148.53, 260);
                yield return new TranspEq("Iowa", 35.796, 2.698, 8.017, 75);
                yield return new TranspEq("Kansas", 494.515, 10.36, 86.189, 76);
                yield return new TranspEq("Kentucky", 124.948, 5.213, 12, 31);
                yield return new TranspEq("Louisiana", 73.328, 3.763, 15.9, 115);
                yield return new TranspEq("Maine", 29.467, 1.967, 6.47, 81);
                yield return new TranspEq("Maryland", 415.262, 17.546, 69.342, 129);
                yield return new TranspEq("Massachusetts", 241.53, 15.347, 39.416, 172);
                yield return new TranspEq("Michigan", 4079.554, 435.105, 490.384, 568);
                yield return new TranspEq("Missouri", 652.085, 32.84, 84.831, 125);
                yield return new TranspEq("NewJersey", 667.113, 33.292, 83.033, 247);
                yield return new TranspEq("NewYork", 940.43, 72.974, 190.094, 461);
                yield return new TranspEq("Ohio", 1611.899, 157.978, 259.916, 363);
                yield return new TranspEq("Pennsylvania", 617.579, 34.324, 98.152, 233);
                yield return new TranspEq("Texas", 527.413, 22.736, 109.728, 308);
                yield return new TranspEq("Virginia", 174.394, 7.173, 31.301, 85);
                yield return new TranspEq("Washington", 636.948, 30.807, 87.963, 179);
                yield return new TranspEq("WestVirginia", 22.7, 1.543, 4.063, 15);
                yield return new TranspEq("Wisconsin", 349.711, 22.001, 52.818, 142);
            }
        }
    }
}
