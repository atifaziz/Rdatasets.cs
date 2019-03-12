// ReSharper disable All

namespace Rdatasets.carData
{
    using System.Collections.Generic;

    /// <summary>
    /// Status, Authoritarianism, and Conformity
    /// </summary>

    public class Moore
    {
        public readonly int κ;
        public readonly string partner_status;
        public readonly int conformity;
        public readonly string fcategory;
        public readonly int fscore;

        public Moore(int κ, string partner_status, int conformity, string fcategory, int fscore)
        {
            this.κ = κ;
            this.partner_status = partner_status;
            this.conformity = conformity;
            this.fcategory = fcategory;
            this.fscore = fscore;
        }

        public static IEnumerable<Moore> Data
        {
            get
            {
                yield return new Moore(1, "low", 8, "low", 37);
                yield return new Moore(2, "low", 4, "high", 57);
                yield return new Moore(3, "low", 8, "high", 65);
                yield return new Moore(4, "low", 7, "low", 20);
                yield return new Moore(5, "low", 10, "low", 36);
                yield return new Moore(6, "low", 6, "low", 18);
                yield return new Moore(7, "low", 12, "medium", 51);
                yield return new Moore(8, "low", 4, "medium", 44);
                yield return new Moore(9, "low", 13, "low", 31);
                yield return new Moore(10, "low", 12, "low", 36);
                yield return new Moore(11, "low", 4, "medium", 42);
                yield return new Moore(12, "low", 13, "high", 56);
                yield return new Moore(13, "low", 7, "low", 28);
                yield return new Moore(14, "low", 9, "medium", 43);
                yield return new Moore(15, "low", 9, "high", 65);
                yield return new Moore(16, "low", 24, "high", 57);
                yield return new Moore(17, "low", 6, "low", 28);
                yield return new Moore(18, "low", 7, "high", 61);
                yield return new Moore(19, "low", 23, "high", 57);
                yield return new Moore(20, "low", 13, "high", 55);
                yield return new Moore(21, "low", 8, "low", 17);
                yield return new Moore(22, "low", 12, "low", 35);
                yield return new Moore(23, "high", 19, "high", 68);
                yield return new Moore(24, "high", 12, "medium", 41);
                yield return new Moore(25, "high", 21, "low", 16);
                yield return new Moore(26, "high", 9, "high", 63);
                yield return new Moore(27, "high", 23, "low", 15);
                yield return new Moore(28, "high", 7, "high", 54);
                yield return new Moore(29, "high", 17, "medium", 48);
                yield return new Moore(30, "high", 14, "medium", 42);
                yield return new Moore(31, "high", 11, "high", 59);
                yield return new Moore(32, "high", 16, "medium", 45);
                yield return new Moore(33, "high", 15, "low", 30);
                yield return new Moore(34, "high", 20, "medium", 44);
                yield return new Moore(35, "high", 8, "medium", 42);
                yield return new Moore(36, "high", 12, "low", 22);
                yield return new Moore(37, "high", 14, "high", 52);
                yield return new Moore(38, "high", 14, "medium", 42);
                yield return new Moore(39, "high", 17, "medium", 41);
                yield return new Moore(40, "high", 7, "medium", 50);
                yield return new Moore(41, "high", 17, "medium", 39);
                yield return new Moore(42, "high", 13, "high", 57);
                yield return new Moore(43, "high", 16, "low", 35);
                yield return new Moore(44, "high", 10, "high", 52);
                yield return new Moore(45, "high", 15, "medium", 44);
            }
        }
    }
}
