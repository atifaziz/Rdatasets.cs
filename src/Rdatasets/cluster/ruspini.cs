// ReSharper disable All

namespace Rdatasets.cluster
{
    using System.Collections.Generic;

    /// <summary>
    /// Ruspini Data
    /// </summary>

    public class ruspini
    {
        public readonly int x;
        public readonly int y;

        public ruspini(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public static IEnumerable<ruspini> Data
        {
            get
            {
                yield return new ruspini(4, 53);
                yield return new ruspini(5, 63);
                yield return new ruspini(10, 59);
                yield return new ruspini(9, 77);
                yield return new ruspini(13, 49);
                yield return new ruspini(13, 69);
                yield return new ruspini(12, 88);
                yield return new ruspini(15, 75);
                yield return new ruspini(18, 61);
                yield return new ruspini(19, 65);
                yield return new ruspini(22, 74);
                yield return new ruspini(27, 72);
                yield return new ruspini(28, 76);
                yield return new ruspini(24, 58);
                yield return new ruspini(27, 55);
                yield return new ruspini(28, 60);
                yield return new ruspini(30, 52);
                yield return new ruspini(31, 60);
                yield return new ruspini(32, 61);
                yield return new ruspini(36, 72);
                yield return new ruspini(28, 147);
                yield return new ruspini(32, 149);
                yield return new ruspini(35, 153);
                yield return new ruspini(33, 154);
                yield return new ruspini(38, 151);
                yield return new ruspini(41, 150);
                yield return new ruspini(38, 145);
                yield return new ruspini(38, 143);
                yield return new ruspini(32, 143);
                yield return new ruspini(34, 141);
                yield return new ruspini(44, 156);
                yield return new ruspini(44, 149);
                yield return new ruspini(44, 143);
                yield return new ruspini(46, 142);
                yield return new ruspini(47, 149);
                yield return new ruspini(49, 152);
                yield return new ruspini(50, 142);
                yield return new ruspini(53, 144);
                yield return new ruspini(52, 152);
                yield return new ruspini(55, 155);
                yield return new ruspini(54, 124);
                yield return new ruspini(60, 136);
                yield return new ruspini(63, 139);
                yield return new ruspini(86, 132);
                yield return new ruspini(85, 115);
                yield return new ruspini(85, 96);
                yield return new ruspini(78, 94);
                yield return new ruspini(74, 96);
                yield return new ruspini(97, 122);
                yield return new ruspini(98, 116);
                yield return new ruspini(98, 124);
                yield return new ruspini(99, 119);
                yield return new ruspini(99, 128);
                yield return new ruspini(101, 115);
                yield return new ruspini(108, 111);
                yield return new ruspini(110, 111);
                yield return new ruspini(108, 116);
                yield return new ruspini(111, 126);
                yield return new ruspini(115, 117);
                yield return new ruspini(117, 115);
                yield return new ruspini(70, 4);
                yield return new ruspini(77, 12);
                yield return new ruspini(83, 21);
                yield return new ruspini(61, 15);
                yield return new ruspini(69, 15);
                yield return new ruspini(78, 16);
                yield return new ruspini(66, 18);
                yield return new ruspini(58, 13);
                yield return new ruspini(64, 20);
                yield return new ruspini(69, 21);
                yield return new ruspini(66, 23);
                yield return new ruspini(61, 25);
                yield return new ruspini(76, 27);
                yield return new ruspini(72, 31);
                yield return new ruspini(64, 30);
            }
        }
    }
}
