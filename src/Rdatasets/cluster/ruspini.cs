// ReSharper disable All

namespace Rdatasets.cluster
{
    using System.Collections.Generic;

    /// <summary>
    /// Ruspini Data
    /// </summary>

    public class ruspini
    {
        public readonly int κ;
        public readonly int x;
        public readonly int y;

        public ruspini(int κ, int x, int y)
        {
            this.κ = κ;
            this.x = x;
            this.y = y;
        }

        public static IEnumerable<ruspini> Data
        {
            get
            {
                yield return new ruspini(1, 4, 53);
                yield return new ruspini(2, 5, 63);
                yield return new ruspini(3, 10, 59);
                yield return new ruspini(4, 9, 77);
                yield return new ruspini(5, 13, 49);
                yield return new ruspini(6, 13, 69);
                yield return new ruspini(7, 12, 88);
                yield return new ruspini(8, 15, 75);
                yield return new ruspini(9, 18, 61);
                yield return new ruspini(10, 19, 65);
                yield return new ruspini(11, 22, 74);
                yield return new ruspini(12, 27, 72);
                yield return new ruspini(13, 28, 76);
                yield return new ruspini(14, 24, 58);
                yield return new ruspini(15, 27, 55);
                yield return new ruspini(16, 28, 60);
                yield return new ruspini(17, 30, 52);
                yield return new ruspini(18, 31, 60);
                yield return new ruspini(19, 32, 61);
                yield return new ruspini(20, 36, 72);
                yield return new ruspini(21, 28, 147);
                yield return new ruspini(22, 32, 149);
                yield return new ruspini(23, 35, 153);
                yield return new ruspini(24, 33, 154);
                yield return new ruspini(25, 38, 151);
                yield return new ruspini(26, 41, 150);
                yield return new ruspini(27, 38, 145);
                yield return new ruspini(28, 38, 143);
                yield return new ruspini(29, 32, 143);
                yield return new ruspini(30, 34, 141);
                yield return new ruspini(31, 44, 156);
                yield return new ruspini(32, 44, 149);
                yield return new ruspini(33, 44, 143);
                yield return new ruspini(34, 46, 142);
                yield return new ruspini(35, 47, 149);
                yield return new ruspini(36, 49, 152);
                yield return new ruspini(37, 50, 142);
                yield return new ruspini(38, 53, 144);
                yield return new ruspini(39, 52, 152);
                yield return new ruspini(40, 55, 155);
                yield return new ruspini(41, 54, 124);
                yield return new ruspini(42, 60, 136);
                yield return new ruspini(43, 63, 139);
                yield return new ruspini(44, 86, 132);
                yield return new ruspini(45, 85, 115);
                yield return new ruspini(46, 85, 96);
                yield return new ruspini(47, 78, 94);
                yield return new ruspini(48, 74, 96);
                yield return new ruspini(49, 97, 122);
                yield return new ruspini(50, 98, 116);
                yield return new ruspini(51, 98, 124);
                yield return new ruspini(52, 99, 119);
                yield return new ruspini(53, 99, 128);
                yield return new ruspini(54, 101, 115);
                yield return new ruspini(55, 108, 111);
                yield return new ruspini(56, 110, 111);
                yield return new ruspini(57, 108, 116);
                yield return new ruspini(58, 111, 126);
                yield return new ruspini(59, 115, 117);
                yield return new ruspini(60, 117, 115);
                yield return new ruspini(61, 70, 4);
                yield return new ruspini(62, 77, 12);
                yield return new ruspini(63, 83, 21);
                yield return new ruspini(64, 61, 15);
                yield return new ruspini(65, 69, 15);
                yield return new ruspini(66, 78, 16);
                yield return new ruspini(67, 66, 18);
                yield return new ruspini(68, 58, 13);
                yield return new ruspini(69, 64, 20);
                yield return new ruspini(70, 69, 21);
                yield return new ruspini(71, 66, 23);
                yield return new ruspini(72, 61, 25);
                yield return new ruspini(73, 76, 27);
                yield return new ruspini(74, 72, 31);
                yield return new ruspini(75, 64, 30);
            }
        }
    }
}
