// ReSharper disable All

namespace Rdatasets.carData
{
    using System.Collections.Generic;

    /// <summary>
    /// Status, Authoritarianism, and Conformity
    /// </summary>

    public class Moore
    {
        public readonly string partner_status;
        public readonly int conformity;
        public readonly string fcategory;
        public readonly int fscore;

        public Moore(string partner_status, int conformity, string fcategory, int fscore)
        {
            this.partner_status = partner_status;
            this.conformity = conformity;
            this.fcategory = fcategory;
            this.fscore = fscore;
        }

        public static IEnumerable<Moore> Data
        {
            get
            {
                yield return new Moore("low", 8, "low", 37);
                yield return new Moore("low", 4, "high", 57);
                yield return new Moore("low", 8, "high", 65);
                yield return new Moore("low", 7, "low", 20);
                yield return new Moore("low", 10, "low", 36);
                yield return new Moore("low", 6, "low", 18);
                yield return new Moore("low", 12, "medium", 51);
                yield return new Moore("low", 4, "medium", 44);
                yield return new Moore("low", 13, "low", 31);
                yield return new Moore("low", 12, "low", 36);
                yield return new Moore("low", 4, "medium", 42);
                yield return new Moore("low", 13, "high", 56);
                yield return new Moore("low", 7, "low", 28);
                yield return new Moore("low", 9, "medium", 43);
                yield return new Moore("low", 9, "high", 65);
                yield return new Moore("low", 24, "high", 57);
                yield return new Moore("low", 6, "low", 28);
                yield return new Moore("low", 7, "high", 61);
                yield return new Moore("low", 23, "high", 57);
                yield return new Moore("low", 13, "high", 55);
                yield return new Moore("low", 8, "low", 17);
                yield return new Moore("low", 12, "low", 35);
                yield return new Moore("high", 19, "high", 68);
                yield return new Moore("high", 12, "medium", 41);
                yield return new Moore("high", 21, "low", 16);
                yield return new Moore("high", 9, "high", 63);
                yield return new Moore("high", 23, "low", 15);
                yield return new Moore("high", 7, "high", 54);
                yield return new Moore("high", 17, "medium", 48);
                yield return new Moore("high", 14, "medium", 42);
                yield return new Moore("high", 11, "high", 59);
                yield return new Moore("high", 16, "medium", 45);
                yield return new Moore("high", 15, "low", 30);
                yield return new Moore("high", 20, "medium", 44);
                yield return new Moore("high", 8, "medium", 42);
                yield return new Moore("high", 12, "low", 22);
                yield return new Moore("high", 14, "high", 52);
                yield return new Moore("high", 14, "medium", 42);
                yield return new Moore("high", 17, "medium", 41);
                yield return new Moore("high", 7, "medium", 50);
                yield return new Moore("high", 17, "medium", 39);
                yield return new Moore("high", 13, "high", 57);
                yield return new Moore("high", 16, "low", 35);
                yield return new Moore("high", 10, "high", 52);
                yield return new Moore("high", 15, "medium", 44);
            }
        }
    }
}
