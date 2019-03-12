// ReSharper disable All

namespace Rdatasets.boot
{
    using System.Collections.Generic;

    /// <summary>
    /// Population of U.S. Cities
    /// </summary>

    public class bigcity
    {
        public readonly int κ;
        public readonly int u;
        public readonly int x;

        public bigcity(int κ, int u, int x)
        {
            this.κ = κ;
            this.u = u;
            this.x = x;
        }

        public static IEnumerable<bigcity> Data
        {
            get
            {
                yield return new bigcity(1, 138, 143);
                yield return new bigcity(2, 93, 104);
                yield return new bigcity(3, 61, 69);
                yield return new bigcity(4, 179, 260);
                yield return new bigcity(5, 48, 75);
                yield return new bigcity(6, 37, 63);
                yield return new bigcity(7, 29, 50);
                yield return new bigcity(8, 23, 48);
                yield return new bigcity(9, 30, 111);
                yield return new bigcity(10, 2, 50);
                yield return new bigcity(11, 38, 52);
                yield return new bigcity(12, 46, 53);
                yield return new bigcity(13, 71, 79);
                yield return new bigcity(14, 25, 57);
                yield return new bigcity(15, 298, 317);
                yield return new bigcity(16, 74, 93);
                yield return new bigcity(17, 50, 58);
                yield return new bigcity(18, 76, 80);
                yield return new bigcity(19, 381, 464);
                yield return new bigcity(20, 387, 459);
                yield return new bigcity(21, 78, 106);
                yield return new bigcity(22, 60, 57);
                yield return new bigcity(23, 507, 634);
                yield return new bigcity(24, 50, 64);
                yield return new bigcity(25, 77, 89);
                yield return new bigcity(26, 64, 77);
                yield return new bigcity(27, 40, 60);
                yield return new bigcity(28, 136, 139);
                yield return new bigcity(29, 243, 291);
                yield return new bigcity(30, 256, 288);
                yield return new bigcity(31, 94, 85);
                yield return new bigcity(32, 36, 46);
                yield return new bigcity(33, 45, 53);
                yield return new bigcity(34, 67, 67);
                yield return new bigcity(35, 120, 115);
                yield return new bigcity(36, 172, 183);
                yield return new bigcity(37, 66, 86);
                yield return new bigcity(38, 46, 65);
                yield return new bigcity(39, 121, 113);
                yield return new bigcity(40, 44, 58);
                yield return new bigcity(41, 64, 63);
                yield return new bigcity(42, 56, 142);
                yield return new bigcity(43, 40, 64);
                yield return new bigcity(44, 116, 130);
                yield return new bigcity(45, 87, 105);
                yield return new bigcity(46, 43, 61);
                yield return new bigcity(47, 43, 50);
                yield return new bigcity(48, 161, 232);
                yield return new bigcity(49, 36, 54);
            }
        }
    }
}
