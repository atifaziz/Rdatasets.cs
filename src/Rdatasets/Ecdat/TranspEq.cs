// ReSharper disable All

namespace Rdatasets.Ecdat
{
    using System.Collections.Generic;

    /// <summary>
    /// Statewide Data on Transportation Equipment Manufacturing
    /// </summary>

    public class TranspEq
    {
        public readonly int κ;
        public readonly string state;
        public readonly double va;
        public readonly double capital;
        public readonly double labor;
        public readonly int nfirm;

        public TranspEq(int κ, string state, double va, double capital, double labor, int nfirm)
        {
            this.κ = κ;
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
                yield return new TranspEq(1, "Alabama", 126.148, 3.804, 31.551, 68);
                yield return new TranspEq(2, "California", 3201.486, 185.446, 452.844, 1372);
                yield return new TranspEq(3, "Connecticut", 690.67, 39.712, 124.074, 154);
                yield return new TranspEq(4, "Florida", 56.296, 6.547, 19.181, 292);
                yield return new TranspEq(5, "Georgia", 304.531, 11.53, 45.534, 71);
                yield return new TranspEq(6, "Illinois", 723.028, 58.987, 88.391, 275);
                yield return new TranspEq(7, "Indiana", 992.169, 112.884, 148.53, 260);
                yield return new TranspEq(8, "Iowa", 35.796, 2.698, 8.017, 75);
                yield return new TranspEq(9, "Kansas", 494.515, 10.36, 86.189, 76);
                yield return new TranspEq(10, "Kentucky", 124.948, 5.213, 12, 31);
                yield return new TranspEq(11, "Louisiana", 73.328, 3.763, 15.9, 115);
                yield return new TranspEq(12, "Maine", 29.467, 1.967, 6.47, 81);
                yield return new TranspEq(13, "Maryland", 415.262, 17.546, 69.342, 129);
                yield return new TranspEq(14, "Massachusetts", 241.53, 15.347, 39.416, 172);
                yield return new TranspEq(15, "Michigan", 4079.554, 435.105, 490.384, 568);
                yield return new TranspEq(16, "Missouri", 652.085, 32.84, 84.831, 125);
                yield return new TranspEq(17, "NewJersey", 667.113, 33.292, 83.033, 247);
                yield return new TranspEq(18, "NewYork", 940.43, 72.974, 190.094, 461);
                yield return new TranspEq(19, "Ohio", 1611.899, 157.978, 259.916, 363);
                yield return new TranspEq(20, "Pennsylvania", 617.579, 34.324, 98.152, 233);
                yield return new TranspEq(21, "Texas", 527.413, 22.736, 109.728, 308);
                yield return new TranspEq(22, "Virginia", 174.394, 7.173, 31.301, 85);
                yield return new TranspEq(23, "Washington", 636.948, 30.807, 87.963, 179);
                yield return new TranspEq(24, "WestVirginia", 22.7, 1.543, 4.063, 15);
                yield return new TranspEq(25, "Wisconsin", 349.711, 22.001, 52.818, 142);
            }
        }
    }
}
