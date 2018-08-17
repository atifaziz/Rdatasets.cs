// ReSharper disable All

namespace Rdatasets.robustbase
{
    using System.Collections.Generic;

    /// <summary>
    /// Number of International Calls from Belgium
    /// </summary>

    public class telef
    {
        public readonly int Year;
        public readonly double Calls;

        public telef(int Year, double Calls)
        {
            this.Year = Year;
            this.Calls = Calls;
        }

        public static IEnumerable<telef> Data
        {
            get
            {
                yield return new telef(50, 0.44);
                yield return new telef(51, 0.47);
                yield return new telef(52, 0.47);
                yield return new telef(53, 0.59);
                yield return new telef(54, 0.66);
                yield return new telef(55, 0.73);
                yield return new telef(56, 0.81);
                yield return new telef(57, 0.88);
                yield return new telef(58, 1.06);
                yield return new telef(59, 1.2);
                yield return new telef(60, 1.35);
                yield return new telef(61, 1.49);
                yield return new telef(62, 1.61);
                yield return new telef(63, 2.12);
                yield return new telef(64, 11.9);
                yield return new telef(65, 12.4);
                yield return new telef(66, 14.2);
                yield return new telef(67, 15.9);
                yield return new telef(68, 18.2);
                yield return new telef(69, 21.2);
                yield return new telef(70, 4.3);
                yield return new telef(71, 2.4);
                yield return new telef(72, 2.7);
                yield return new telef(73, 2.9);
            }
        }
    }
}
