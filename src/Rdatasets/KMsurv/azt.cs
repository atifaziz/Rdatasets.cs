// ReSharper disable All

namespace Rdatasets.KMsurv
{
    using System.Collections.Generic;

    /// <summary>
    /// data from Exercise 4.7, p122
    /// </summary>

    public class azt
    {
        public readonly int κ;
        public readonly int patient;
        public readonly int ageentry;
        public readonly int age;
        public readonly int death;

        public azt(int κ, int patient, int ageentry, int age, int death)
        {
            this.κ = κ;
            this.patient = patient;
            this.ageentry = ageentry;
            this.age = age;
            this.death = death;
        }

        public static IEnumerable<azt> Data
        {
            get
            {
                yield return new azt(1, 1, 241, 464, 0);
                yield return new azt(2, 2, 421, 668, 0);
                yield return new azt(3, 3, 375, 727, 0);
                yield return new azt(4, 4, 289, 515, 1);
                yield return new azt(5, 5, 510, 871, 1);
                yield return new azt(6, 6, 486, 677, 1);
                yield return new azt(7, 7, 326, 593, 1);
                yield return new azt(8, 8, 293, 977, 0);
                yield return new azt(9, 9, 296, 298, 1);
                yield return new azt(10, 10, 259, 844, 0);
                yield return new azt(11, 11, 465, 973, 0);
                yield return new azt(12, 12, 349, 762, 1);
                yield return new azt(13, 13, 255, 730, 0);
                yield return new azt(14, 14, 433, 451, 1);
                yield return new azt(15, 15, 482, 543, 1);
                yield return new azt(16, 16, 518, 1125, 0);
                yield return new azt(17, 17, 333, 468, 1);
                yield return new azt(18, 18, 463, 494, 1);
                yield return new azt(19, 19, 337, 404, 1);
                yield return new azt(20, 20, 224, 873, 0);
                yield return new azt(21, 21, 288, 968, 0);
                yield return new azt(22, 22, 390, 948, 0);
                yield return new azt(23, 23, 256, 391, 1);
                yield return new azt(24, 24, 298, 1090, 0);
                yield return new azt(25, 25, 279, 925, 0);
                yield return new azt(26, 26, 356, 549, 1);
                yield return new azt(27, 27, 334, 689, 0);
                yield return new azt(28, 28, 394, 645, 0);
                yield return new azt(29, 29, 409, 513, 1);
                yield return new azt(30, 30, 333, 683, 0);
                yield return new azt(31, 31, 316, 346, 1);
                yield return new azt(32, 32, 309, 563, 0);
                yield return new azt(33, 33, 277, 1177, 0);
                yield return new azt(34, 34, 496, 851, 1);
                yield return new azt(35, 35, 482, 754, 1);
                yield return new azt(36, 36, 312, 807, 0);
                yield return new azt(37, 37, 426, 1412, 0);
                yield return new azt(38, 38, 470, 966, 0);
                yield return new azt(39, 39, 248, 293, 1);
                yield return new azt(40, 40, 469, 676, 1);
                yield return new azt(41, 41, 444, 772, 0);
                yield return new azt(42, 42, 267, 918, 0);
                yield return new azt(43, 43, 422, 773, 1);
                yield return new azt(44, 44, 308, 973, 0);
                yield return new azt(45, 45, 396, 816, 0);
            }
        }
    }
}
