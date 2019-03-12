// ReSharper disable All

namespace Rdatasets.HSAUR
{
    using System.Collections.Generic;

    /// <summary>
    /// Womens Role in Society
    /// </summary>

    public class womensrole
    {
        public readonly int κ;
        public readonly int education;
        public readonly string sex;
        public readonly int agree;
        public readonly int disagree;

        public womensrole(int κ, int education, string sex, int agree, int disagree)
        {
            this.κ = κ;
            this.education = education;
            this.sex = sex;
            this.agree = agree;
            this.disagree = disagree;
        }

        public static IEnumerable<womensrole> Data
        {
            get
            {
                yield return new womensrole(1, 0, "Male", 4, 2);
                yield return new womensrole(2, 1, "Male", 2, 0);
                yield return new womensrole(3, 2, "Male", 4, 0);
                yield return new womensrole(4, 3, "Male", 6, 3);
                yield return new womensrole(5, 4, "Male", 5, 5);
                yield return new womensrole(6, 5, "Male", 13, 7);
                yield return new womensrole(7, 6, "Male", 25, 9);
                yield return new womensrole(8, 7, "Male", 27, 15);
                yield return new womensrole(9, 8, "Male", 75, 49);
                yield return new womensrole(10, 9, "Male", 29, 29);
                yield return new womensrole(11, 10, "Male", 32, 45);
                yield return new womensrole(12, 11, "Male", 36, 59);
                yield return new womensrole(13, 12, "Male", 115, 245);
                yield return new womensrole(14, 13, "Male", 31, 70);
                yield return new womensrole(15, 14, "Male", 28, 79);
                yield return new womensrole(16, 15, "Male", 9, 23);
                yield return new womensrole(17, 16, "Male", 15, 110);
                yield return new womensrole(18, 17, "Male", 3, 29);
                yield return new womensrole(19, 18, "Male", 1, 28);
                yield return new womensrole(20, 19, "Male", 2, 13);
                yield return new womensrole(21, 20, "Male", 3, 20);
                yield return new womensrole(22, 0, "Female", 4, 2);
                yield return new womensrole(23, 1, "Female", 1, 0);
                yield return new womensrole(24, 2, "Female", 0, 0);
                yield return new womensrole(25, 3, "Female", 6, 1);
                yield return new womensrole(26, 4, "Female", 10, 0);
                yield return new womensrole(27, 5, "Female", 14, 7);
                yield return new womensrole(28, 6, "Female", 17, 5);
                yield return new womensrole(29, 7, "Female", 26, 16);
                yield return new womensrole(30, 8, "Female", 91, 36);
                yield return new womensrole(31, 9, "Female", 30, 35);
                yield return new womensrole(32, 10, "Female", 55, 67);
                yield return new womensrole(33, 11, "Female", 50, 62);
                yield return new womensrole(34, 12, "Female", 190, 403);
                yield return new womensrole(35, 13, "Female", 17, 92);
                yield return new womensrole(36, 14, "Female", 18, 81);
                yield return new womensrole(37, 15, "Female", 7, 34);
                yield return new womensrole(38, 16, "Female", 13, 115);
                yield return new womensrole(39, 17, "Female", 3, 28);
                yield return new womensrole(40, 18, "Female", 0, 21);
                yield return new womensrole(41, 19, "Female", 1, 2);
                yield return new womensrole(42, 20, "Female", 2, 4);
            }
        }
    }
}
