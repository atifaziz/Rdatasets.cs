// ReSharper disable All

namespace Rdatasets.Stat2Data
{
    using System.Collections.Generic;

    /// <summary>
    /// BritishUnions
    /// </summary>

    public class BritishUnions
    {
        public readonly int κ;
        public readonly string Date;
        public readonly int AgreePct;
        public readonly int DisagreePct;
        public readonly int NetSupport;
        public readonly int Months;
        public readonly int Late;
        public readonly double Unemployment;

        public BritishUnions(int κ, string Date, int AgreePct, int DisagreePct, int NetSupport, int Months, int Late, double Unemployment)
        {
            this.κ = κ;
            this.Date = Date;
            this.AgreePct = AgreePct;
            this.DisagreePct = DisagreePct;
            this.NetSupport = NetSupport;
            this.Months = Months;
            this.Late = Late;
            this.Unemployment = Unemployment;
        }

        public static IEnumerable<BritishUnions> Data
        {
            get
            {
                yield return new BritishUnions(1, "Oct-75", 75, 16, -59, 2, 0, 4.9);
                yield return new BritishUnions(2, "Aug-77", 79, 17, -62, 23, 0, 5.7);
                yield return new BritishUnions(3, "Sep-78", 82, 16, -66, 36, 0, 5.5);
                yield return new BritishUnions(4, "Sep-79", 80, 16, -64, 48, 0, 5.4);
                yield return new BritishUnions(5, "Jul-80", 72, 19, -53, 58, 0, 6.8);
                yield return new BritishUnions(6, "Nov-81", 70, 22, -48, 74, 0, 10.2);
                yield return new BritishUnions(7, "Aug-82", 71, 21, -50, 83, 0, 10.8);
                yield return new BritishUnions(8, "Aug-83", 68, 25, -43, 95, 0, 11.5);
                yield return new BritishUnions(9, "Aug-84", 68, 24, -44, 107, 0, 11.7);
                yield return new BritishUnions(10, "Aug-89", 41, 42, 1, 167, 1, 7.1);
                yield return new BritishUnions(11, "Jan-90", 35, 54, 19, 172, 1, 6.9);
                yield return new BritishUnions(12, "Aug-90", 38, 45, 7, 179, 1, 7.1);
                yield return new BritishUnions(13, "Feb-92", 27, 64, 37, 197, 1, 9.7);
                yield return new BritishUnions(14, "Dec-92", 24, 56, 32, 207, 1, 10.5);
                yield return new BritishUnions(15, "Aug-93", 26, 55, 29, 215, 1, 10.2);
                yield return new BritishUnions(16, "Aug-94", 26, 56, 30, 227, 1, 9.4);
                yield return new BritishUnions(17, "Aug-95", 24, 57, 33, 239, 1, 8.6);
            }
        }
    }
}
