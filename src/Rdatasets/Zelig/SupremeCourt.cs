// ReSharper disable All

namespace Rdatasets.Zelig
{
    using System.Collections.Generic;

    /// <summary>
    /// U.S. Supreme Court Vote Matrix
    /// </summary>

    public class SupremeCourt
    {
        public readonly int Rehnquist;
        public readonly int? Stevens;
        public readonly int? OConnor;
        public readonly int Scalia;
        public readonly int Kennedy;
        public readonly int Souter;
        public readonly int Thomas;
        public readonly int Ginsburg;
        public readonly int Breyer;

        public SupremeCourt(int Rehnquist, int? Stevens, int? OConnor, int Scalia, int Kennedy, int Souter, int Thomas, int Ginsburg, int Breyer)
        {
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
                yield return new SupremeCourt(0, 1, 1, 0, 1, 1, 0, 1, 1);
                yield return new SupremeCourt(0, 1, 0, 0, 0, 1, 0, 1, 1);
                yield return new SupremeCourt(0, 1, 0, 0, 0, 1, 0, 1, 1);
                yield return new SupremeCourt(0, 0, 0, 0, 0, 0, 0, 0, 1);
                yield return new SupremeCourt(1, 1, 0, 0, 1, 0, 0, 0, 0);
                yield return new SupremeCourt(0, 1, 0, 0, 0, 0, 0, 0, 0);
                yield return new SupremeCourt(0, 1, 1, 0, 0, 1, 0, 1, 1);
                yield return new SupremeCourt(0, 1, 0, 0, 0, 0, 0, 0, 0);
                yield return new SupremeCourt(0, 1, 0, 0, 1, 1, 0, 1, 1);
                yield return new SupremeCourt(1, 1, 1, 0, 1, 1, 0, 1, 1);
                yield return new SupremeCourt(0, 1, 1, 0, 1, 1, 0, 1, 1);
                yield return new SupremeCourt(0, 1, 0, 0, 0, 1, 0, 1, 1);
                yield return new SupremeCourt(1, 0, 1, 1, 1, 1, 1, 1, 0);
                yield return new SupremeCourt(0, 1, 0, 0, 0, 1, 0, 1, 1);
                yield return new SupremeCourt(0, 1, 1, 0, 0, 1, 0, 1, 1);
                yield return new SupremeCourt(0, 1, 0, 0, 0, 1, 0, 1, 1);
                yield return new SupremeCourt(0, 1, 1, 0, 0, 0, 0, 1, 1);
                yield return new SupremeCourt(0, 1, 0, 0, 0, 1, 0, 1, 1);
                yield return new SupremeCourt(0, 1, 0, 0, 0, 1, 0, 1, 1);
                yield return new SupremeCourt(0, 0, 0, 0, 0, 0, 0, 1, 0);
                yield return new SupremeCourt(0, 1, 0, 1, 0, 0, 1, 0, 1);
                yield return new SupremeCourt(0, 1, 1, 0, 1, 1, 0, 1, 1);
                yield return new SupremeCourt(1, null, null, 0, 1, 1, 0, 1, 1);
                yield return new SupremeCourt(0, 1, 0, 0, 0, 1, 0, 1, 1);
                yield return new SupremeCourt(1, 1, 1, 0, 1, 1, 0, 1, 1);
                yield return new SupremeCourt(0, 1, 0, 0, 0, 1, 0, 1, 1);
                yield return new SupremeCourt(0, 1, 1, 0, 1, 1, 0, 1, 1);
                yield return new SupremeCourt(0, 1, 0, 0, 0, 0, 0, 0, 0);
                yield return new SupremeCourt(0, 0, 0, 1, 0, 1, 1, 1, 1);
                yield return new SupremeCourt(0, 0, 1, 0, 0, 1, 0, 1, 1);
                yield return new SupremeCourt(0, 1, 0, 0, 0, 1, 0, 1, 0);
                yield return new SupremeCourt(0, 0, 0, 0, 0, 0, 0, 1, 1);
                yield return new SupremeCourt(1, 1, 1, 0, 1, 1, 1, 1, 1);
                yield return new SupremeCourt(0, 1, 1, 0, 0, 1, 0, 1, 1);
                yield return new SupremeCourt(0, 1, 0, 0, 1, 1, 0, 1, 1);
                yield return new SupremeCourt(0, 1, 0, 0, 1, 1, 0, 1, 1);
                yield return new SupremeCourt(1, 1, 0, 1, 1, 1, 1, 0, 0);
                yield return new SupremeCourt(0, 1, 1, 0, 0, 1, 0, 1, 1);
                yield return new SupremeCourt(1, 0, 1, 1, 1, 1, 1, 1, 0);
                yield return new SupremeCourt(1, 0, 1, 1, 1, 0, 1, 0, 0);
                yield return new SupremeCourt(0, 1, 0, 0, 0, 1, 0, 1, 1);
                yield return new SupremeCourt(0, 1, 0, 0, 0, 1, 0, 1, 1);
                yield return new SupremeCourt(0, 1, 1, 0, 0, 1, 0, 1, 1);
            }
        }
    }
}
