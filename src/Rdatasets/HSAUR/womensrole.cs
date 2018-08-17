// ReSharper disable All

namespace Rdatasets.HSAUR
{
    using System.Collections.Generic;

    /// <summary>
    /// Womens Role in Society
    /// </summary>

    public class womensrole
    {
        public readonly int education;
        public readonly string sex;
        public readonly int agree;
        public readonly int disagree;

        public womensrole(int education, string sex, int agree, int disagree)
        {
            this.education = education;
            this.sex = sex;
            this.agree = agree;
            this.disagree = disagree;
        }

        public static IEnumerable<womensrole> Data
        {
            get
            {
                yield return new womensrole(0, "Male", 4, 2);
                yield return new womensrole(1, "Male", 2, 0);
                yield return new womensrole(2, "Male", 4, 0);
                yield return new womensrole(3, "Male", 6, 3);
                yield return new womensrole(4, "Male", 5, 5);
                yield return new womensrole(5, "Male", 13, 7);
                yield return new womensrole(6, "Male", 25, 9);
                yield return new womensrole(7, "Male", 27, 15);
                yield return new womensrole(8, "Male", 75, 49);
                yield return new womensrole(9, "Male", 29, 29);
                yield return new womensrole(10, "Male", 32, 45);
                yield return new womensrole(11, "Male", 36, 59);
                yield return new womensrole(12, "Male", 115, 245);
                yield return new womensrole(13, "Male", 31, 70);
                yield return new womensrole(14, "Male", 28, 79);
                yield return new womensrole(15, "Male", 9, 23);
                yield return new womensrole(16, "Male", 15, 110);
                yield return new womensrole(17, "Male", 3, 29);
                yield return new womensrole(18, "Male", 1, 28);
                yield return new womensrole(19, "Male", 2, 13);
                yield return new womensrole(20, "Male", 3, 20);
                yield return new womensrole(0, "Female", 4, 2);
                yield return new womensrole(1, "Female", 1, 0);
                yield return new womensrole(2, "Female", 0, 0);
                yield return new womensrole(3, "Female", 6, 1);
                yield return new womensrole(4, "Female", 10, 0);
                yield return new womensrole(5, "Female", 14, 7);
                yield return new womensrole(6, "Female", 17, 5);
                yield return new womensrole(7, "Female", 26, 16);
                yield return new womensrole(8, "Female", 91, 36);
                yield return new womensrole(9, "Female", 30, 35);
                yield return new womensrole(10, "Female", 55, 67);
                yield return new womensrole(11, "Female", 50, 62);
                yield return new womensrole(12, "Female", 190, 403);
                yield return new womensrole(13, "Female", 17, 92);
                yield return new womensrole(14, "Female", 18, 81);
                yield return new womensrole(15, "Female", 7, 34);
                yield return new womensrole(16, "Female", 13, 115);
                yield return new womensrole(17, "Female", 3, 28);
                yield return new womensrole(18, "Female", 0, 21);
                yield return new womensrole(19, "Female", 1, 2);
                yield return new womensrole(20, "Female", 2, 4);
            }
        }
    }
}
