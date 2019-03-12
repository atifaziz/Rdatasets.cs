// ReSharper disable All

namespace Rdatasets.HSAUR
{
    using System.Collections.Generic;

    /// <summary>
    /// General Health Questionnaire
    /// </summary>

    public class GHQ
    {
        public readonly int κ;
        public readonly int GHQ_;
        public readonly string sex;
        public readonly int cases;
        public readonly int non_cases;

        public GHQ(int κ, int GHQ_, string sex, int cases, int non_cases)
        {
            this.κ = κ;
            this.GHQ_ = GHQ_;
            this.sex = sex;
            this.cases = cases;
            this.non_cases = non_cases;
        }

        public static IEnumerable<GHQ> Data
        {
            get
            {
                yield return new GHQ(1, 0, "female", 4, 80);
                yield return new GHQ(2, 1, "female", 4, 29);
                yield return new GHQ(3, 2, "female", 8, 15);
                yield return new GHQ(4, 3, "female", 6, 3);
                yield return new GHQ(5, 4, "female", 4, 2);
                yield return new GHQ(6, 5, "female", 6, 1);
                yield return new GHQ(7, 6, "female", 3, 1);
                yield return new GHQ(8, 7, "female", 2, 0);
                yield return new GHQ(9, 8, "female", 3, 0);
                yield return new GHQ(10, 9, "female", 2, 0);
                yield return new GHQ(11, 10, "female", 1, 0);
                yield return new GHQ(12, 0, "male", 1, 36);
                yield return new GHQ(13, 1, "male", 2, 25);
                yield return new GHQ(14, 2, "male", 2, 8);
                yield return new GHQ(15, 3, "male", 1, 4);
                yield return new GHQ(16, 4, "male", 3, 1);
                yield return new GHQ(17, 5, "male", 3, 1);
                yield return new GHQ(18, 6, "male", 2, 1);
                yield return new GHQ(19, 7, "male", 4, 2);
                yield return new GHQ(20, 8, "male", 3, 1);
                yield return new GHQ(21, 9, "male", 2, 0);
                yield return new GHQ(22, 10, "male", 2, 0);
            }
        }
    }
}
