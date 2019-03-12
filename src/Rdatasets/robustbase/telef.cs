// ReSharper disable All

namespace Rdatasets.robustbase
{
    using System.Collections.Generic;

    /// <summary>
    /// Number of International Calls from Belgium
    /// </summary>

    public class telef
    {
        public readonly int κ;
        public readonly int Year;
        public readonly double Calls;

        public telef(int κ, int Year, double Calls)
        {
            this.κ = κ;
            this.Year = Year;
            this.Calls = Calls;
        }

        public static IEnumerable<telef> Data
        {
            get
            {
                yield return new telef(1, 50, 0.44);
                yield return new telef(2, 51, 0.47);
                yield return new telef(3, 52, 0.47);
                yield return new telef(4, 53, 0.59);
                yield return new telef(5, 54, 0.66);
                yield return new telef(6, 55, 0.73);
                yield return new telef(7, 56, 0.81);
                yield return new telef(8, 57, 0.88);
                yield return new telef(9, 58, 1.06);
                yield return new telef(10, 59, 1.2);
                yield return new telef(11, 60, 1.35);
                yield return new telef(12, 61, 1.49);
                yield return new telef(13, 62, 1.61);
                yield return new telef(14, 63, 2.12);
                yield return new telef(15, 64, 11.9);
                yield return new telef(16, 65, 12.4);
                yield return new telef(17, 66, 14.2);
                yield return new telef(18, 67, 15.9);
                yield return new telef(19, 68, 18.2);
                yield return new telef(20, 69, 21.2);
                yield return new telef(21, 70, 4.3);
                yield return new telef(22, 71, 2.4);
                yield return new telef(23, 72, 2.7);
                yield return new telef(24, 73, 2.9);
            }
        }
    }
}
