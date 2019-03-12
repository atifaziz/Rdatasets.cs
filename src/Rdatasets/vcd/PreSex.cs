// ReSharper disable All

namespace Rdatasets.vcd
{
    using System.Collections.Generic;

    /// <summary>
    /// Pre-marital Sex and Divorce
    /// </summary>

    public class PreSex
    {
        public readonly int κ;
        public readonly string MaritalStatus;
        public readonly string ExtramaritalSex;
        public readonly string PremaritalSex;
        public readonly string Gender;
        public readonly int Freq;

        public PreSex(int κ, string MaritalStatus, string ExtramaritalSex, string PremaritalSex, string Gender, int Freq)
        {
            this.κ = κ;
            this.MaritalStatus = MaritalStatus;
            this.ExtramaritalSex = ExtramaritalSex;
            this.PremaritalSex = PremaritalSex;
            this.Gender = Gender;
            this.Freq = Freq;
        }

        public static IEnumerable<PreSex> Data
        {
            get
            {
                yield return new PreSex(1, "Divorced", "Yes", "Yes", "Women", 17);
                yield return new PreSex(2, "Married", "Yes", "Yes", "Women", 4);
                yield return new PreSex(3, "Divorced", "No", "Yes", "Women", 54);
                yield return new PreSex(4, "Married", "No", "Yes", "Women", 25);
                yield return new PreSex(5, "Divorced", "Yes", "No", "Women", 36);
                yield return new PreSex(6, "Married", "Yes", "No", "Women", 4);
                yield return new PreSex(7, "Divorced", "No", "No", "Women", 214);
                yield return new PreSex(8, "Married", "No", "No", "Women", 322);
                yield return new PreSex(9, "Divorced", "Yes", "Yes", "Men", 28);
                yield return new PreSex(10, "Married", "Yes", "Yes", "Men", 11);
                yield return new PreSex(11, "Divorced", "No", "Yes", "Men", 60);
                yield return new PreSex(12, "Married", "No", "Yes", "Men", 42);
                yield return new PreSex(13, "Divorced", "Yes", "No", "Men", 17);
                yield return new PreSex(14, "Married", "Yes", "No", "Men", 4);
                yield return new PreSex(15, "Divorced", "No", "No", "Men", 68);
                yield return new PreSex(16, "Married", "No", "No", "Men", 130);
            }
        }
    }
}
