// ReSharper disable All

namespace Rdatasets.vcd
{
    using System.Collections.Generic;

    /// <summary>
    /// Pre-marital Sex and Divorce
    /// </summary>

    public class PreSex
    {
        public readonly string MaritalStatus;
        public readonly string ExtramaritalSex;
        public readonly string PremaritalSex;
        public readonly string Gender;
        public readonly int Freq;

        public PreSex(string MaritalStatus, string ExtramaritalSex, string PremaritalSex, string Gender, int Freq)
        {
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
                yield return new PreSex("Divorced", "Yes", "Yes", "Women", 17);
                yield return new PreSex("Married", "Yes", "Yes", "Women", 4);
                yield return new PreSex("Divorced", "No", "Yes", "Women", 54);
                yield return new PreSex("Married", "No", "Yes", "Women", 25);
                yield return new PreSex("Divorced", "Yes", "No", "Women", 36);
                yield return new PreSex("Married", "Yes", "No", "Women", 4);
                yield return new PreSex("Divorced", "No", "No", "Women", 214);
                yield return new PreSex("Married", "No", "No", "Women", 322);
                yield return new PreSex("Divorced", "Yes", "Yes", "Men", 28);
                yield return new PreSex("Married", "Yes", "Yes", "Men", 11);
                yield return new PreSex("Divorced", "No", "Yes", "Men", 60);
                yield return new PreSex("Married", "No", "Yes", "Men", 42);
                yield return new PreSex("Divorced", "Yes", "No", "Men", 17);
                yield return new PreSex("Married", "Yes", "No", "Men", 4);
                yield return new PreSex("Divorced", "No", "No", "Men", 68);
                yield return new PreSex("Married", "No", "No", "Men", 130);
            }
        }
    }
}
