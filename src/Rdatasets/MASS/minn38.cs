// ReSharper disable All

namespace Rdatasets.MASS
{
    using System.Collections.Generic;

    /// <summary>
    /// Minnesota High School Graduates of 1938
    /// </summary>

    public class minn38
    {
        public readonly int κ;
        public readonly string hs;
        public readonly string phs;
        public readonly string fol;
        public readonly string sex;
        public readonly int f;

        public minn38(int κ, string hs, string phs, string fol, string sex, int f)
        {
            this.κ = κ;
            this.hs = hs;
            this.phs = phs;
            this.fol = fol;
            this.sex = sex;
            this.f = f;
        }

        public static IEnumerable<minn38> Data
        {
            get
            {
                yield return new minn38(1, "L", "C", "F1", "M", 87);
                yield return new minn38(2, "L", "C", "F2", "M", 72);
                yield return new minn38(3, "L", "C", "F3", "M", 52);
                yield return new minn38(4, "L", "C", "F4", "M", 88);
                yield return new minn38(5, "L", "C", "F5", "M", 32);
                yield return new minn38(6, "L", "C", "F6", "M", 14);
                yield return new minn38(7, "L", "C", "F7", "M", 20);
                yield return new minn38(8, "L", "N", "F1", "M", 3);
                yield return new minn38(9, "L", "N", "F2", "M", 6);
                yield return new minn38(10, "L", "N", "F3", "M", 17);
                yield return new minn38(11, "L", "N", "F4", "M", 9);
                yield return new minn38(12, "L", "N", "F5", "M", 1);
                yield return new minn38(13, "L", "N", "F6", "M", 2);
                yield return new minn38(14, "L", "N", "F7", "M", 3);
                yield return new minn38(15, "L", "E", "F1", "M", 17);
                yield return new minn38(16, "L", "E", "F2", "M", 18);
                yield return new minn38(17, "L", "E", "F3", "M", 14);
                yield return new minn38(18, "L", "E", "F4", "M", 14);
                yield return new minn38(19, "L", "E", "F5", "M", 12);
                yield return new minn38(20, "L", "E", "F6", "M", 5);
                yield return new minn38(21, "L", "E", "F7", "M", 4);
                yield return new minn38(22, "L", "O", "F1", "M", 105);
                yield return new minn38(23, "L", "O", "F2", "M", 209);
                yield return new minn38(24, "L", "O", "F3", "M", 541);
                yield return new minn38(25, "L", "O", "F4", "M", 328);
                yield return new minn38(26, "L", "O", "F5", "M", 124);
                yield return new minn38(27, "L", "O", "F6", "M", 148);
                yield return new minn38(28, "L", "O", "F7", "M", 109);
                yield return new minn38(29, "M", "C", "F1", "M", 216);
                yield return new minn38(30, "M", "C", "F2", "M", 159);
                yield return new minn38(31, "M", "C", "F3", "M", 119);
                yield return new minn38(32, "M", "C", "F4", "M", 158);
                yield return new minn38(33, "M", "C", "F5", "M", 43);
                yield return new minn38(34, "M", "C", "F6", "M", 24);
                yield return new minn38(35, "M", "C", "F7", "M", 41);
                yield return new minn38(36, "M", "N", "F1", "M", 4);
                yield return new minn38(37, "M", "N", "F2", "M", 14);
                yield return new minn38(38, "M", "N", "F3", "M", 13);
                yield return new minn38(39, "M", "N", "F4", "M", 15);
                yield return new minn38(40, "M", "N", "F5", "M", 5);
                yield return new minn38(41, "M", "N", "F6", "M", 6);
                yield return new minn38(42, "M", "N", "F7", "M", 5);
                yield return new minn38(43, "M", "E", "F1", "M", 14);
                yield return new minn38(44, "M", "E", "F2", "M", 28);
                yield return new minn38(45, "M", "E", "F3", "M", 44);
                yield return new minn38(46, "M", "E", "F4", "M", 36);
                yield return new minn38(47, "M", "E", "F5", "M", 7);
                yield return new minn38(48, "M", "E", "F6", "M", 15);
                yield return new minn38(49, "M", "E", "F7", "M", 13);
                yield return new minn38(50, "M", "O", "F1", "M", 118);
                yield return new minn38(51, "M", "O", "F2", "M", 227);
                yield return new minn38(52, "M", "O", "F3", "M", 578);
                yield return new minn38(53, "M", "O", "F4", "M", 304);
                yield return new minn38(54, "M", "O", "F5", "M", 119);
                yield return new minn38(55, "M", "O", "F6", "M", 131);
                yield return new minn38(56, "M", "O", "F7", "M", 88);
                yield return new minn38(57, "U", "C", "F1", "M", 256);
                yield return new minn38(58, "U", "C", "F2", "M", 176);
                yield return new minn38(59, "U", "C", "F3", "M", 119);
                yield return new minn38(60, "U", "C", "F4", "M", 144);
                yield return new minn38(61, "U", "C", "F5", "M", 42);
                yield return new minn38(62, "U", "C", "F6", "M", 24);
                yield return new minn38(63, "U", "C", "F7", "M", 32);
                yield return new minn38(64, "U", "N", "F1", "M", 2);
                yield return new minn38(65, "U", "N", "F2", "M", 8);
                yield return new minn38(66, "U", "N", "F3", "M", 10);
                yield return new minn38(67, "U", "N", "F4", "M", 12);
                yield return new minn38(68, "U", "N", "F5", "M", 2);
                yield return new minn38(69, "U", "N", "F6", "M", 2);
                yield return new minn38(70, "U", "N", "F7", "M", 2);
                yield return new minn38(71, "U", "E", "F1", "M", 10);
                yield return new minn38(72, "U", "E", "F2", "M", 22);
                yield return new minn38(73, "U", "E", "F3", "M", 33);
                yield return new minn38(74, "U", "E", "F4", "M", 20);
                yield return new minn38(75, "U", "E", "F5", "M", 7);
                yield return new minn38(76, "U", "E", "F6", "M", 4);
                yield return new minn38(77, "U", "E", "F7", "M", 4);
                yield return new minn38(78, "U", "O", "F1", "M", 53);
                yield return new minn38(79, "U", "O", "F2", "M", 95);
                yield return new minn38(80, "U", "O", "F3", "M", 257);
                yield return new minn38(81, "U", "O", "F4", "M", 115);
                yield return new minn38(82, "U", "O", "F5", "M", 56);
                yield return new minn38(83, "U", "O", "F6", "M", 61);
                yield return new minn38(84, "U", "O", "F7", "M", 41);
                yield return new minn38(85, "L", "C", "F1", "F", 53);
                yield return new minn38(86, "L", "C", "F2", "F", 36);
                yield return new minn38(87, "L", "C", "F3", "F", 52);
                yield return new minn38(88, "L", "C", "F4", "F", 48);
                yield return new minn38(89, "L", "C", "F5", "F", 12);
                yield return new minn38(90, "L", "C", "F6", "F", 9);
                yield return new minn38(91, "L", "C", "F7", "F", 3);
                yield return new minn38(92, "L", "N", "F1", "F", 7);
                yield return new minn38(93, "L", "N", "F2", "F", 16);
                yield return new minn38(94, "L", "N", "F3", "F", 28);
                yield return new minn38(95, "L", "N", "F4", "F", 18);
                yield return new minn38(96, "L", "N", "F5", "F", 5);
                yield return new minn38(97, "L", "N", "F6", "F", 1);
                yield return new minn38(98, "L", "N", "F7", "F", 1);
                yield return new minn38(99, "L", "E", "F1", "F", 13);
                yield return new minn38(100, "L", "E", "F2", "F", 11);
                yield return new minn38(101, "L", "E", "F3", "F", 49);
                yield return new minn38(102, "L", "E", "F4", "F", 29);
                yield return new minn38(103, "L", "E", "F5", "F", 10);
                yield return new minn38(104, "L", "E", "F6", "F", 15);
                yield return new minn38(105, "L", "E", "F7", "F", 6);
                yield return new minn38(106, "L", "O", "F1", "F", 76);
                yield return new minn38(107, "L", "O", "F2", "F", 111);
                yield return new minn38(108, "L", "O", "F3", "F", 521);
                yield return new minn38(109, "L", "O", "F4", "F", 191);
                yield return new minn38(110, "L", "O", "F5", "F", 101);
                yield return new minn38(111, "L", "O", "F6", "F", 130);
                yield return new minn38(112, "L", "O", "F7", "F", 88);
                yield return new minn38(113, "M", "C", "F1", "F", 163);
                yield return new minn38(114, "M", "C", "F2", "F", 116);
                yield return new minn38(115, "M", "C", "F3", "F", 162);
                yield return new minn38(116, "M", "C", "F4", "F", 130);
                yield return new minn38(117, "M", "C", "F5", "F", 35);
                yield return new minn38(118, "M", "C", "F6", "F", 19);
                yield return new minn38(119, "M", "C", "F7", "F", 25);
                yield return new minn38(120, "M", "N", "F1", "F", 30);
                yield return new minn38(121, "M", "N", "F2", "F", 41);
                yield return new minn38(122, "M", "N", "F3", "F", 64);
                yield return new minn38(123, "M", "N", "F4", "F", 47);
                yield return new minn38(124, "M", "N", "F5", "F", 11);
                yield return new minn38(125, "M", "N", "F6", "F", 13);
                yield return new minn38(126, "M", "N", "F7", "F", 9);
                yield return new minn38(127, "M", "E", "F1", "F", 28);
                yield return new minn38(128, "M", "E", "F2", "F", 53);
                yield return new minn38(129, "M", "E", "F3", "F", 129);
                yield return new minn38(130, "M", "E", "F4", "F", 62);
                yield return new minn38(131, "M", "E", "F5", "F", 37);
                yield return new minn38(132, "M", "E", "F6", "F", 22);
                yield return new minn38(133, "M", "E", "F7", "F", 15);
                yield return new minn38(134, "M", "O", "F1", "F", 118);
                yield return new minn38(135, "M", "O", "F2", "F", 214);
                yield return new minn38(136, "M", "O", "F3", "F", 708);
                yield return new minn38(137, "M", "O", "F4", "F", 305);
                yield return new minn38(138, "M", "O", "F5", "F", 152);
                yield return new minn38(139, "M", "O", "F6", "F", 174);
                yield return new minn38(140, "M", "O", "F7", "F", 158);
                yield return new minn38(141, "U", "C", "F1", "F", 309);
                yield return new minn38(142, "U", "C", "F2", "F", 225);
                yield return new minn38(143, "U", "C", "F3", "F", 243);
                yield return new minn38(144, "U", "C", "F4", "F", 237);
                yield return new minn38(145, "U", "C", "F5", "F", 72);
                yield return new minn38(146, "U", "C", "F6", "F", 42);
                yield return new minn38(147, "U", "C", "F7", "F", 36);
                yield return new minn38(148, "U", "N", "F1", "F", 17);
                yield return new minn38(149, "U", "N", "F2", "F", 49);
                yield return new minn38(150, "U", "N", "F3", "F", 79);
                yield return new minn38(151, "U", "N", "F4", "F", 57);
                yield return new minn38(152, "U", "N", "F5", "F", 20);
                yield return new minn38(153, "U", "N", "F6", "F", 10);
                yield return new minn38(154, "U", "N", "F7", "F", 14);
                yield return new minn38(155, "U", "E", "F1", "F", 38);
                yield return new minn38(156, "U", "E", "F2", "F", 68);
                yield return new minn38(157, "U", "E", "F3", "F", 284);
                yield return new minn38(158, "U", "E", "F4", "F", 63);
                yield return new minn38(159, "U", "E", "F5", "F", 21);
                yield return new minn38(160, "U", "E", "F6", "F", 19);
                yield return new minn38(161, "U", "E", "F7", "F", 19);
                yield return new minn38(162, "U", "O", "F1", "F", 89);
                yield return new minn38(163, "U", "O", "F2", "F", 210);
                yield return new minn38(164, "U", "O", "F3", "F", 448);
                yield return new minn38(165, "U", "O", "F4", "F", 219);
                yield return new minn38(166, "U", "O", "F5", "F", 95);
                yield return new minn38(167, "U", "O", "F6", "F", 105);
                yield return new minn38(168, "U", "O", "F7", "F", 93);
            }
        }
    }
}
