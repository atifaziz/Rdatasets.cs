// ReSharper disable All

namespace Rdatasets.carData
{
    using System.Collections.Generic;

    /// <summary>
    /// Duncan's Occupational Prestige Data
    /// </summary>

    public class Duncan
    {
        public readonly string type;
        public readonly int income;
        public readonly int education;
        public readonly int prestige;

        public Duncan(string type, int income, int education, int prestige)
        {
            this.type = type;
            this.income = income;
            this.education = education;
            this.prestige = prestige;
        }

        public static IEnumerable<Duncan> Data
        {
            get
            {
                yield return new Duncan("prof", 62, 86, 82);
                yield return new Duncan("prof", 72, 76, 83);
                yield return new Duncan("prof", 75, 92, 90);
                yield return new Duncan("prof", 55, 90, 76);
                yield return new Duncan("prof", 64, 86, 90);
                yield return new Duncan("prof", 21, 84, 87);
                yield return new Duncan("prof", 64, 93, 93);
                yield return new Duncan("prof", 80, 100, 90);
                yield return new Duncan("wc", 67, 87, 52);
                yield return new Duncan("prof", 72, 86, 88);
                yield return new Duncan("prof", 42, 74, 57);
                yield return new Duncan("prof", 76, 98, 89);
                yield return new Duncan("prof", 76, 97, 97);
                yield return new Duncan("prof", 41, 84, 59);
                yield return new Duncan("prof", 48, 91, 73);
                yield return new Duncan("wc", 76, 34, 38);
                yield return new Duncan("prof", 53, 45, 76);
                yield return new Duncan("prof", 60, 56, 81);
                yield return new Duncan("prof", 42, 44, 45);
                yield return new Duncan("prof", 78, 82, 92);
                yield return new Duncan("wc", 29, 72, 39);
                yield return new Duncan("wc", 48, 55, 34);
                yield return new Duncan("wc", 55, 71, 41);
                yield return new Duncan("wc", 29, 50, 16);
                yield return new Duncan("bc", 21, 23, 33);
                yield return new Duncan("bc", 47, 39, 53);
                yield return new Duncan("bc", 81, 28, 67);
                yield return new Duncan("bc", 36, 32, 57);
                yield return new Duncan("bc", 22, 22, 26);
                yield return new Duncan("bc", 44, 25, 29);
                yield return new Duncan("bc", 15, 29, 10);
                yield return new Duncan("bc", 7, 7, 15);
                yield return new Duncan("bc", 42, 26, 19);
                yield return new Duncan("bc", 9, 19, 10);
                yield return new Duncan("bc", 21, 15, 13);
                yield return new Duncan("bc", 21, 20, 24);
                yield return new Duncan("bc", 16, 26, 20);
                yield return new Duncan("bc", 16, 28, 7);
                yield return new Duncan("bc", 9, 17, 3);
                yield return new Duncan("bc", 14, 22, 16);
                yield return new Duncan("bc", 12, 30, 6);
                yield return new Duncan("bc", 17, 25, 11);
                yield return new Duncan("bc", 7, 20, 8);
                yield return new Duncan("bc", 34, 47, 41);
                yield return new Duncan("bc", 8, 32, 10);
            }
        }
    }
}
