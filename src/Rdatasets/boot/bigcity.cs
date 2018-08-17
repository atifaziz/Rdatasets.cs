// ReSharper disable All

namespace Rdatasets.boot
{
    using System.Collections.Generic;

    /// <summary>
    /// Population of U.S. Cities
    /// </summary>

    public class bigcity
    {
        public readonly int u;
        public readonly int x;

        public bigcity(int u, int x)
        {
            this.u = u;
            this.x = x;
        }

        public static IEnumerable<bigcity> Data
        {
            get
            {
                yield return new bigcity(138, 143);
                yield return new bigcity(93, 104);
                yield return new bigcity(61, 69);
                yield return new bigcity(179, 260);
                yield return new bigcity(48, 75);
                yield return new bigcity(37, 63);
                yield return new bigcity(29, 50);
                yield return new bigcity(23, 48);
                yield return new bigcity(30, 111);
                yield return new bigcity(2, 50);
                yield return new bigcity(38, 52);
                yield return new bigcity(46, 53);
                yield return new bigcity(71, 79);
                yield return new bigcity(25, 57);
                yield return new bigcity(298, 317);
                yield return new bigcity(74, 93);
                yield return new bigcity(50, 58);
                yield return new bigcity(76, 80);
                yield return new bigcity(381, 464);
                yield return new bigcity(387, 459);
                yield return new bigcity(78, 106);
                yield return new bigcity(60, 57);
                yield return new bigcity(507, 634);
                yield return new bigcity(50, 64);
                yield return new bigcity(77, 89);
                yield return new bigcity(64, 77);
                yield return new bigcity(40, 60);
                yield return new bigcity(136, 139);
                yield return new bigcity(243, 291);
                yield return new bigcity(256, 288);
                yield return new bigcity(94, 85);
                yield return new bigcity(36, 46);
                yield return new bigcity(45, 53);
                yield return new bigcity(67, 67);
                yield return new bigcity(120, 115);
                yield return new bigcity(172, 183);
                yield return new bigcity(66, 86);
                yield return new bigcity(46, 65);
                yield return new bigcity(121, 113);
                yield return new bigcity(44, 58);
                yield return new bigcity(64, 63);
                yield return new bigcity(56, 142);
                yield return new bigcity(40, 64);
                yield return new bigcity(116, 130);
                yield return new bigcity(87, 105);
                yield return new bigcity(43, 61);
                yield return new bigcity(43, 50);
                yield return new bigcity(161, 232);
                yield return new bigcity(36, 54);
            }
        }
    }
}
