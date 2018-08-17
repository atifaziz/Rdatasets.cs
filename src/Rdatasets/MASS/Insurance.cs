// ReSharper disable All

namespace Rdatasets.MASS
{
    using System.Collections.Generic;

    /// <summary>
    /// Numbers of Car Insurance claims
    /// </summary>

    public class Insurance
    {
        public readonly int District;
        public readonly string Group;
        public readonly string Age;
        public readonly int Holders;
        public readonly int Claims;

        public Insurance(int District, string Group, string Age, int Holders, int Claims)
        {
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
                yield return new Insurance(1, "<1l", "<25", 197, 38);
                yield return new Insurance(1, "<1l", "25-29", 264, 35);
                yield return new Insurance(1, "<1l", "30-35", 246, 20);
                yield return new Insurance(1, "<1l", ">35", 1680, 156);
                yield return new Insurance(1, "1-1.5l", "<25", 284, 63);
                yield return new Insurance(1, "1-1.5l", "25-29", 536, 84);
                yield return new Insurance(1, "1-1.5l", "30-35", 696, 89);
                yield return new Insurance(1, "1-1.5l", ">35", 3582, 400);
                yield return new Insurance(1, "1.5-2l", "<25", 133, 19);
                yield return new Insurance(1, "1.5-2l", "25-29", 286, 52);
                yield return new Insurance(1, "1.5-2l", "30-35", 355, 74);
                yield return new Insurance(1, "1.5-2l", ">35", 1640, 233);
                yield return new Insurance(1, ">2l", "<25", 24, 4);
                yield return new Insurance(1, ">2l", "25-29", 71, 18);
                yield return new Insurance(1, ">2l", "30-35", 99, 19);
                yield return new Insurance(1, ">2l", ">35", 452, 77);
                yield return new Insurance(2, "<1l", "<25", 85, 22);
                yield return new Insurance(2, "<1l", "25-29", 139, 19);
                yield return new Insurance(2, "<1l", "30-35", 151, 22);
                yield return new Insurance(2, "<1l", ">35", 931, 87);
                yield return new Insurance(2, "1-1.5l", "<25", 149, 25);
                yield return new Insurance(2, "1-1.5l", "25-29", 313, 51);
                yield return new Insurance(2, "1-1.5l", "30-35", 419, 49);
                yield return new Insurance(2, "1-1.5l", ">35", 2443, 290);
                yield return new Insurance(2, "1.5-2l", "<25", 66, 14);
                yield return new Insurance(2, "1.5-2l", "25-29", 175, 46);
                yield return new Insurance(2, "1.5-2l", "30-35", 221, 39);
                yield return new Insurance(2, "1.5-2l", ">35", 1110, 143);
                yield return new Insurance(2, ">2l", "<25", 9, 4);
                yield return new Insurance(2, ">2l", "25-29", 48, 15);
                yield return new Insurance(2, ">2l", "30-35", 72, 12);
                yield return new Insurance(2, ">2l", ">35", 322, 53);
                yield return new Insurance(3, "<1l", "<25", 35, 5);
                yield return new Insurance(3, "<1l", "25-29", 73, 11);
                yield return new Insurance(3, "<1l", "30-35", 89, 10);
                yield return new Insurance(3, "<1l", ">35", 648, 67);
                yield return new Insurance(3, "1-1.5l", "<25", 53, 10);
                yield return new Insurance(3, "1-1.5l", "25-29", 155, 24);
                yield return new Insurance(3, "1-1.5l", "30-35", 240, 37);
                yield return new Insurance(3, "1-1.5l", ">35", 1635, 187);
                yield return new Insurance(3, "1.5-2l", "<25", 24, 8);
                yield return new Insurance(3, "1.5-2l", "25-29", 78, 19);
                yield return new Insurance(3, "1.5-2l", "30-35", 121, 24);
                yield return new Insurance(3, "1.5-2l", ">35", 692, 101);
                yield return new Insurance(3, ">2l", "<25", 7, 3);
                yield return new Insurance(3, ">2l", "25-29", 29, 2);
                yield return new Insurance(3, ">2l", "30-35", 43, 8);
                yield return new Insurance(3, ">2l", ">35", 245, 37);
                yield return new Insurance(4, "<1l", "<25", 20, 2);
                yield return new Insurance(4, "<1l", "25-29", 33, 5);
                yield return new Insurance(4, "<1l", "30-35", 40, 4);
                yield return new Insurance(4, "<1l", ">35", 316, 36);
                yield return new Insurance(4, "1-1.5l", "<25", 31, 7);
                yield return new Insurance(4, "1-1.5l", "25-29", 81, 10);
                yield return new Insurance(4, "1-1.5l", "30-35", 122, 22);
                yield return new Insurance(4, "1-1.5l", ">35", 724, 102);
                yield return new Insurance(4, "1.5-2l", "<25", 18, 5);
                yield return new Insurance(4, "1.5-2l", "25-29", 39, 7);
                yield return new Insurance(4, "1.5-2l", "30-35", 68, 16);
                yield return new Insurance(4, "1.5-2l", ">35", 344, 63);
                yield return new Insurance(4, ">2l", "<25", 3, 0);
                yield return new Insurance(4, ">2l", "25-29", 16, 6);
                yield return new Insurance(4, ">2l", "30-35", 25, 8);
                yield return new Insurance(4, ">2l", ">35", 114, 33);
            }
        }
    }
}
