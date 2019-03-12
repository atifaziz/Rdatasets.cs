// ReSharper disable All

namespace Rdatasets.carData
{
    using System.Collections.Generic;

    /// <summary>
    /// American Math Society Survey Data
    /// </summary>

    public class AMSsurvey
    {
        public readonly int κ;
        public readonly string type;
        public readonly string sex;
        public readonly string citizen;
        public readonly int count;
        public readonly int count11;

        public AMSsurvey(int κ, string type, string sex, string citizen, int count, int count11)
        {
            this.κ = κ;
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
                yield return new AMSsurvey(1, "I(Pu)", "Male", "US", 132, 148);
                yield return new AMSsurvey(2, "I(Pu)", "Female", "US", 35, 40);
                yield return new AMSsurvey(3, "I(Pr)", "Male", "US", 87, 63);
                yield return new AMSsurvey(4, "I(Pr)", "Female", "US", 20, 22);
                yield return new AMSsurvey(5, "II", "Male", "US", 96, 161);
                yield return new AMSsurvey(6, "II", "Female", "US", 47, 53);
                yield return new AMSsurvey(7, "III", "Male", "US", 47, 71);
                yield return new AMSsurvey(8, "III", "Female", "US", 32, 28);
                yield return new AMSsurvey(9, "IV", "Male", "US", 71, 89);
                yield return new AMSsurvey(10, "IV", "Female", "US", 54, 55);
                yield return new AMSsurvey(11, "Va", "Male", "US", 34, 42);
                yield return new AMSsurvey(12, "Va", "Female", "US", 14, 21);
                yield return new AMSsurvey(13, "I(Pu)", "Male", "Non-US", 130, 136);
                yield return new AMSsurvey(14, "I(Pu)", "Female", "Non-US", 29, 32);
                yield return new AMSsurvey(15, "I(Pr)", "Male", "Non-US", 79, 82);
                yield return new AMSsurvey(16, "I(Pr)", "Female", "Non-US", 25, 26);
                yield return new AMSsurvey(17, "II", "Male", "Non-US", 89, 116);
                yield return new AMSsurvey(18, "II", "Female", "Non-US", 50, 56);
                yield return new AMSsurvey(19, "III", "Male", "Non-US", 53, 61);
                yield return new AMSsurvey(20, "III", "Female", "Non-US", 39, 30);
                yield return new AMSsurvey(21, "IV", "Male", "Non-US", 122, 153);
                yield return new AMSsurvey(22, "IV", "Female", "Non-US", 105, 115);
                yield return new AMSsurvey(23, "Va", "Male", "Non-US", 28, 27);
                yield return new AMSsurvey(24, "Va", "Female", "Non-US", 12, 17);
            }
        }
    }
}
