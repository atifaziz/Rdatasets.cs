// ReSharper disable All

namespace Rdatasets.HSAUR
{
    using System.Collections.Generic;

    /// <summary>
    /// Students Estimates of Lecture Room Width
    /// </summary>

    public class roomwidth
    {
        public readonly int κ;
        public readonly string unit;
        public readonly int width;

        public roomwidth(int κ, string unit, int width)
        {
            this.κ = κ;
            this.unit = unit;
            this.width = width;
        }

        public static IEnumerable<roomwidth> Data
        {
            get
            {
                yield return new roomwidth(1, "metres", 8);
                yield return new roomwidth(2, "metres", 9);
                yield return new roomwidth(3, "metres", 10);
                yield return new roomwidth(4, "metres", 10);
                yield return new roomwidth(5, "metres", 10);
                yield return new roomwidth(6, "metres", 10);
                yield return new roomwidth(7, "metres", 10);
                yield return new roomwidth(8, "metres", 10);
                yield return new roomwidth(9, "metres", 11);
                yield return new roomwidth(10, "metres", 11);
                yield return new roomwidth(11, "metres", 11);
                yield return new roomwidth(12, "metres", 11);
                yield return new roomwidth(13, "metres", 12);
                yield return new roomwidth(14, "metres", 12);
                yield return new roomwidth(15, "metres", 13);
                yield return new roomwidth(16, "metres", 13);
                yield return new roomwidth(17, "metres", 13);
                yield return new roomwidth(18, "metres", 14);
                yield return new roomwidth(19, "metres", 14);
                yield return new roomwidth(20, "metres", 14);
                yield return new roomwidth(21, "metres", 15);
                yield return new roomwidth(22, "metres", 15);
                yield return new roomwidth(23, "metres", 15);
                yield return new roomwidth(24, "metres", 15);
                yield return new roomwidth(25, "metres", 15);
                yield return new roomwidth(26, "metres", 15);
                yield return new roomwidth(27, "metres", 15);
                yield return new roomwidth(28, "metres", 15);
                yield return new roomwidth(29, "metres", 16);
                yield return new roomwidth(30, "metres", 16);
                yield return new roomwidth(31, "metres", 16);
                yield return new roomwidth(32, "metres", 17);
                yield return new roomwidth(33, "metres", 17);
                yield return new roomwidth(34, "metres", 17);
                yield return new roomwidth(35, "metres", 17);
                yield return new roomwidth(36, "metres", 18);
                yield return new roomwidth(37, "metres", 18);
                yield return new roomwidth(38, "metres", 20);
                yield return new roomwidth(39, "metres", 22);
                yield return new roomwidth(40, "metres", 25);
                yield return new roomwidth(41, "metres", 27);
                yield return new roomwidth(42, "metres", 35);
                yield return new roomwidth(43, "metres", 38);
                yield return new roomwidth(44, "metres", 40);
                yield return new roomwidth(45, "feet", 24);
                yield return new roomwidth(46, "feet", 25);
                yield return new roomwidth(47, "feet", 27);
                yield return new roomwidth(48, "feet", 30);
                yield return new roomwidth(49, "feet", 30);
                yield return new roomwidth(50, "feet", 30);
                yield return new roomwidth(51, "feet", 30);
                yield return new roomwidth(52, "feet", 30);
                yield return new roomwidth(53, "feet", 30);
                yield return new roomwidth(54, "feet", 32);
                yield return new roomwidth(55, "feet", 32);
                yield return new roomwidth(56, "feet", 33);
                yield return new roomwidth(57, "feet", 34);
                yield return new roomwidth(58, "feet", 34);
                yield return new roomwidth(59, "feet", 34);
                yield return new roomwidth(60, "feet", 35);
                yield return new roomwidth(61, "feet", 35);
                yield return new roomwidth(62, "feet", 36);
                yield return new roomwidth(63, "feet", 36);
                yield return new roomwidth(64, "feet", 36);
                yield return new roomwidth(65, "feet", 37);
                yield return new roomwidth(66, "feet", 37);
                yield return new roomwidth(67, "feet", 40);
                yield return new roomwidth(68, "feet", 40);
                yield return new roomwidth(69, "feet", 40);
                yield return new roomwidth(70, "feet", 40);
                yield return new roomwidth(71, "feet", 40);
                yield return new roomwidth(72, "feet", 40);
                yield return new roomwidth(73, "feet", 40);
                yield return new roomwidth(74, "feet", 40);
                yield return new roomwidth(75, "feet", 40);
                yield return new roomwidth(76, "feet", 41);
                yield return new roomwidth(77, "feet", 41);
                yield return new roomwidth(78, "feet", 42);
                yield return new roomwidth(79, "feet", 42);
                yield return new roomwidth(80, "feet", 42);
                yield return new roomwidth(81, "feet", 42);
                yield return new roomwidth(82, "feet", 43);
                yield return new roomwidth(83, "feet", 43);
                yield return new roomwidth(84, "feet", 44);
                yield return new roomwidth(85, "feet", 44);
                yield return new roomwidth(86, "feet", 44);
                yield return new roomwidth(87, "feet", 45);
                yield return new roomwidth(88, "feet", 45);
                yield return new roomwidth(89, "feet", 45);
                yield return new roomwidth(90, "feet", 45);
                yield return new roomwidth(91, "feet", 45);
                yield return new roomwidth(92, "feet", 45);
                yield return new roomwidth(93, "feet", 46);
                yield return new roomwidth(94, "feet", 46);
                yield return new roomwidth(95, "feet", 47);
                yield return new roomwidth(96, "feet", 48);
                yield return new roomwidth(97, "feet", 48);
                yield return new roomwidth(98, "feet", 50);
                yield return new roomwidth(99, "feet", 50);
                yield return new roomwidth(100, "feet", 50);
                yield return new roomwidth(101, "feet", 51);
                yield return new roomwidth(102, "feet", 54);
                yield return new roomwidth(103, "feet", 54);
                yield return new roomwidth(104, "feet", 54);
                yield return new roomwidth(105, "feet", 55);
                yield return new roomwidth(106, "feet", 55);
                yield return new roomwidth(107, "feet", 60);
                yield return new roomwidth(108, "feet", 60);
                yield return new roomwidth(109, "feet", 63);
                yield return new roomwidth(110, "feet", 70);
                yield return new roomwidth(111, "feet", 75);
                yield return new roomwidth(112, "feet", 80);
                yield return new roomwidth(113, "feet", 94);
            }
        }
    }
}
