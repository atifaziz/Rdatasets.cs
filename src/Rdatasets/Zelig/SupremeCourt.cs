// ReSharper disable All

namespace Rdatasets.Zelig
{
    using System.Collections.Generic;

    /// <summary>
    /// U.S. Supreme Court Vote Matrix
    /// </summary>

    public class SupremeCourt
    {
        public readonly int κ;
        public readonly int Rehnquist;
        public readonly int? Stevens;
        public readonly int? OConnor;
        public readonly int Scalia;
        public readonly int Kennedy;
        public readonly int Souter;
        public readonly int Thomas;
        public readonly int Ginsburg;
        public readonly int Breyer;

        public SupremeCourt(int κ, int Rehnquist, int? Stevens, int? OConnor, int Scalia, int Kennedy, int Souter, int Thomas, int Ginsburg, int Breyer)
        {
            this.κ = κ;
            this.Rehnquist = Rehnquist;
            this.Stevens = Stevens;
            this.OConnor = OConnor;
            this.Scalia = Scalia;
            this.Kennedy = Kennedy;
            this.Souter = Souter;
            this.Thomas = Thomas;
            this.Ginsburg = Ginsburg;
            this.Breyer = Breyer;
        }

        public static IEnumerable<SupremeCourt> Data
        {
            get
            {
                yield return new SupremeCourt(1, 0, 1, 1, 0, 1, 1, 0, 1, 1);
                yield return new SupremeCourt(2, 0, 1, 0, 0, 0, 1, 0, 1, 1);
                yield return new SupremeCourt(3, 0, 1, 0, 0, 0, 1, 0, 1, 1);
                yield return new SupremeCourt(4, 0, 0, 0, 0, 0, 0, 0, 0, 1);
                yield return new SupremeCourt(5, 1, 1, 0, 0, 1, 0, 0, 0, 0);
                yield return new SupremeCourt(6, 0, 1, 0, 0, 0, 0, 0, 0, 0);
                yield return new SupremeCourt(7, 0, 1, 1, 0, 0, 1, 0, 1, 1);
                yield return new SupremeCourt(8, 0, 1, 0, 0, 0, 0, 0, 0, 0);
                yield return new SupremeCourt(9, 0, 1, 0, 0, 1, 1, 0, 1, 1);
                yield return new SupremeCourt(10, 1, 1, 1, 0, 1, 1, 0, 1, 1);
                yield return new SupremeCourt(11, 0, 1, 1, 0, 1, 1, 0, 1, 1);
                yield return new SupremeCourt(12, 0, 1, 0, 0, 0, 1, 0, 1, 1);
                yield return new SupremeCourt(13, 1, 0, 1, 1, 1, 1, 1, 1, 0);
                yield return new SupremeCourt(14, 0, 1, 0, 0, 0, 1, 0, 1, 1);
                yield return new SupremeCourt(15, 0, 1, 1, 0, 0, 1, 0, 1, 1);
                yield return new SupremeCourt(16, 0, 1, 0, 0, 0, 1, 0, 1, 1);
                yield return new SupremeCourt(17, 0, 1, 1, 0, 0, 0, 0, 1, 1);
                yield return new SupremeCourt(18, 0, 1, 0, 0, 0, 1, 0, 1, 1);
                yield return new SupremeCourt(19, 0, 1, 0, 0, 0, 1, 0, 1, 1);
                yield return new SupremeCourt(20, 0, 0, 0, 0, 0, 0, 0, 1, 0);
                yield return new SupremeCourt(21, 0, 1, 0, 1, 0, 0, 1, 0, 1);
                yield return new SupremeCourt(22, 0, 1, 1, 0, 1, 1, 0, 1, 1);
                yield return new SupremeCourt(23, 1, null, null, 0, 1, 1, 0, 1, 1);
                yield return new SupremeCourt(24, 0, 1, 0, 0, 0, 1, 0, 1, 1);
                yield return new SupremeCourt(25, 1, 1, 1, 0, 1, 1, 0, 1, 1);
                yield return new SupremeCourt(26, 0, 1, 0, 0, 0, 1, 0, 1, 1);
                yield return new SupremeCourt(27, 0, 1, 1, 0, 1, 1, 0, 1, 1);
                yield return new SupremeCourt(28, 0, 1, 0, 0, 0, 0, 0, 0, 0);
                yield return new SupremeCourt(29, 0, 0, 0, 1, 0, 1, 1, 1, 1);
                yield return new SupremeCourt(30, 0, 0, 1, 0, 0, 1, 0, 1, 1);
                yield return new SupremeCourt(31, 0, 1, 0, 0, 0, 1, 0, 1, 0);
                yield return new SupremeCourt(32, 0, 0, 0, 0, 0, 0, 0, 1, 1);
                yield return new SupremeCourt(33, 1, 1, 1, 0, 1, 1, 1, 1, 1);
                yield return new SupremeCourt(34, 0, 1, 1, 0, 0, 1, 0, 1, 1);
                yield return new SupremeCourt(35, 0, 1, 0, 0, 1, 1, 0, 1, 1);
                yield return new SupremeCourt(36, 0, 1, 0, 0, 1, 1, 0, 1, 1);
                yield return new SupremeCourt(37, 1, 1, 0, 1, 1, 1, 1, 0, 0);
                yield return new SupremeCourt(38, 0, 1, 1, 0, 0, 1, 0, 1, 1);
                yield return new SupremeCourt(39, 1, 0, 1, 1, 1, 1, 1, 1, 0);
                yield return new SupremeCourt(40, 1, 0, 1, 1, 1, 0, 1, 0, 0);
                yield return new SupremeCourt(41, 0, 1, 0, 0, 0, 1, 0, 1, 1);
                yield return new SupremeCourt(42, 0, 1, 0, 0, 0, 1, 0, 1, 1);
                yield return new SupremeCourt(43, 0, 1, 1, 0, 0, 1, 0, 1, 1);
            }
        }
    }
}
