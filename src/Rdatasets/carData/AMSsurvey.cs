// ReSharper disable All

namespace Rdatasets.carData
{
    using System.Collections.Generic;

    /// <summary>
    /// American Math Society Survey Data
    /// </summary>

    public class AMSsurvey
    {
        public readonly string type;
        public readonly string sex;
        public readonly string citizen;
        public readonly int count;
        public readonly int count11;

        public AMSsurvey(string type, string sex, string citizen, int count, int count11)
        {
            this.type = type;
            this.sex = sex;
            this.citizen = citizen;
            this.count = count;
            this.count11 = count11;
        }

        public static IEnumerable<AMSsurvey> Data
        {
            get
            {
                yield return new AMSsurvey("I(Pu)", "Male", "US", 132, 148);
                yield return new AMSsurvey("I(Pu)", "Female", "US", 35, 40);
                yield return new AMSsurvey("I(Pr)", "Male", "US", 87, 63);
                yield return new AMSsurvey("I(Pr)", "Female", "US", 20, 22);
                yield return new AMSsurvey("II", "Male", "US", 96, 161);
                yield return new AMSsurvey("II", "Female", "US", 47, 53);
                yield return new AMSsurvey("III", "Male", "US", 47, 71);
                yield return new AMSsurvey("III", "Female", "US", 32, 28);
                yield return new AMSsurvey("IV", "Male", "US", 71, 89);
                yield return new AMSsurvey("IV", "Female", "US", 54, 55);
                yield return new AMSsurvey("Va", "Male", "US", 34, 42);
                yield return new AMSsurvey("Va", "Female", "US", 14, 21);
                yield return new AMSsurvey("I(Pu)", "Male", "Non-US", 130, 136);
                yield return new AMSsurvey("I(Pu)", "Female", "Non-US", 29, 32);
                yield return new AMSsurvey("I(Pr)", "Male", "Non-US", 79, 82);
                yield return new AMSsurvey("I(Pr)", "Female", "Non-US", 25, 26);
                yield return new AMSsurvey("II", "Male", "Non-US", 89, 116);
                yield return new AMSsurvey("II", "Female", "Non-US", 50, 56);
                yield return new AMSsurvey("III", "Male", "Non-US", 53, 61);
                yield return new AMSsurvey("III", "Female", "Non-US", 39, 30);
                yield return new AMSsurvey("IV", "Male", "Non-US", 122, 153);
                yield return new AMSsurvey("IV", "Female", "Non-US", 105, 115);
                yield return new AMSsurvey("Va", "Male", "Non-US", 28, 27);
                yield return new AMSsurvey("Va", "Female", "Non-US", 12, 17);
            }
        }
    }
}
