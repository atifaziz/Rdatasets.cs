// ReSharper disable All

namespace Rdatasets.MASS
{
    using System.Collections.Generic;

    /// <summary>
    /// Numbers of Car Insurance claims
    /// </summary>

    public class Insurance
    {
        public readonly int κ;
        public readonly int District;
        public readonly string Group;
        public readonly string Age;
        public readonly int Holders;
        public readonly int Claims;

        public Insurance(int κ, int District, string Group, string Age, int Holders, int Claims)
        {
            this.κ = κ;
            this.District = District;
            this.Group = Group;
            this.Age = Age;
            this.Holders = Holders;
            this.Claims = Claims;
        }

        public static IEnumerable<Insurance> Data
        {
            get
            {
                yield return new Insurance(1, 1, "<1l", "<25", 197, 38);
                yield return new Insurance(2, 1, "<1l", "25-29", 264, 35);
                yield return new Insurance(3, 1, "<1l", "30-35", 246, 20);
                yield return new Insurance(4, 1, "<1l", ">35", 1680, 156);
                yield return new Insurance(5, 1, "1-1.5l", "<25", 284, 63);
                yield return new Insurance(6, 1, "1-1.5l", "25-29", 536, 84);
                yield return new Insurance(7, 1, "1-1.5l", "30-35", 696, 89);
                yield return new Insurance(8, 1, "1-1.5l", ">35", 3582, 400);
                yield return new Insurance(9, 1, "1.5-2l", "<25", 133, 19);
                yield return new Insurance(10, 1, "1.5-2l", "25-29", 286, 52);
                yield return new Insurance(11, 1, "1.5-2l", "30-35", 355, 74);
                yield return new Insurance(12, 1, "1.5-2l", ">35", 1640, 233);
                yield return new Insurance(13, 1, ">2l", "<25", 24, 4);
                yield return new Insurance(14, 1, ">2l", "25-29", 71, 18);
                yield return new Insurance(15, 1, ">2l", "30-35", 99, 19);
                yield return new Insurance(16, 1, ">2l", ">35", 452, 77);
                yield return new Insurance(17, 2, "<1l", "<25", 85, 22);
                yield return new Insurance(18, 2, "<1l", "25-29", 139, 19);
                yield return new Insurance(19, 2, "<1l", "30-35", 151, 22);
                yield return new Insurance(20, 2, "<1l", ">35", 931, 87);
                yield return new Insurance(21, 2, "1-1.5l", "<25", 149, 25);
                yield return new Insurance(22, 2, "1-1.5l", "25-29", 313, 51);
                yield return new Insurance(23, 2, "1-1.5l", "30-35", 419, 49);
                yield return new Insurance(24, 2, "1-1.5l", ">35", 2443, 290);
                yield return new Insurance(25, 2, "1.5-2l", "<25", 66, 14);
                yield return new Insurance(26, 2, "1.5-2l", "25-29", 175, 46);
                yield return new Insurance(27, 2, "1.5-2l", "30-35", 221, 39);
                yield return new Insurance(28, 2, "1.5-2l", ">35", 1110, 143);
                yield return new Insurance(29, 2, ">2l", "<25", 9, 4);
                yield return new Insurance(30, 2, ">2l", "25-29", 48, 15);
                yield return new Insurance(31, 2, ">2l", "30-35", 72, 12);
                yield return new Insurance(32, 2, ">2l", ">35", 322, 53);
                yield return new Insurance(33, 3, "<1l", "<25", 35, 5);
                yield return new Insurance(34, 3, "<1l", "25-29", 73, 11);
                yield return new Insurance(35, 3, "<1l", "30-35", 89, 10);
                yield return new Insurance(36, 3, "<1l", ">35", 648, 67);
                yield return new Insurance(37, 3, "1-1.5l", "<25", 53, 10);
                yield return new Insurance(38, 3, "1-1.5l", "25-29", 155, 24);
                yield return new Insurance(39, 3, "1-1.5l", "30-35", 240, 37);
                yield return new Insurance(40, 3, "1-1.5l", ">35", 1635, 187);
                yield return new Insurance(41, 3, "1.5-2l", "<25", 24, 8);
                yield return new Insurance(42, 3, "1.5-2l", "25-29", 78, 19);
                yield return new Insurance(43, 3, "1.5-2l", "30-35", 121, 24);
                yield return new Insurance(44, 3, "1.5-2l", ">35", 692, 101);
                yield return new Insurance(45, 3, ">2l", "<25", 7, 3);
                yield return new Insurance(46, 3, ">2l", "25-29", 29, 2);
                yield return new Insurance(47, 3, ">2l", "30-35", 43, 8);
                yield return new Insurance(48, 3, ">2l", ">35", 245, 37);
                yield return new Insurance(49, 4, "<1l", "<25", 20, 2);
                yield return new Insurance(50, 4, "<1l", "25-29", 33, 5);
                yield return new Insurance(51, 4, "<1l", "30-35", 40, 4);
                yield return new Insurance(52, 4, "<1l", ">35", 316, 36);
                yield return new Insurance(53, 4, "1-1.5l", "<25", 31, 7);
                yield return new Insurance(54, 4, "1-1.5l", "25-29", 81, 10);
                yield return new Insurance(55, 4, "1-1.5l", "30-35", 122, 22);
                yield return new Insurance(56, 4, "1-1.5l", ">35", 724, 102);
                yield return new Insurance(57, 4, "1.5-2l", "<25", 18, 5);
                yield return new Insurance(58, 4, "1.5-2l", "25-29", 39, 7);
                yield return new Insurance(59, 4, "1.5-2l", "30-35", 68, 16);
                yield return new Insurance(60, 4, "1.5-2l", ">35", 344, 63);
                yield return new Insurance(61, 4, ">2l", "<25", 3, 0);
                yield return new Insurance(62, 4, ">2l", "25-29", 16, 6);
                yield return new Insurance(63, 4, ">2l", "30-35", 25, 8);
                yield return new Insurance(64, 4, ">2l", ">35", 114, 33);
            }
        }
    }
}
