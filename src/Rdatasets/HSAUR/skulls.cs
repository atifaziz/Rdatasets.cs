// ReSharper disable All

namespace Rdatasets.HSAUR
{
    using System.Collections.Generic;

    /// <summary>
    /// Egyptian Skulls
    /// </summary>

    public class skulls
    {
        public readonly int κ;
        public readonly string epoch;
        public readonly int mb;
        public readonly int bh;
        public readonly int bl;
        public readonly int nh;

        public skulls(int κ, string epoch, int mb, int bh, int bl, int nh)
        {
            this.κ = κ;
            this.epoch = epoch;
            this.mb = mb;
            this.bh = bh;
            this.bl = bl;
            this.nh = nh;
        }

        public static IEnumerable<skulls> Data
        {
            get
            {
                yield return new skulls(1, "c4000BC", 131, 138, 89, 49);
                yield return new skulls(2, "c4000BC", 125, 131, 92, 48);
                yield return new skulls(3, "c4000BC", 131, 132, 99, 50);
                yield return new skulls(4, "c4000BC", 119, 132, 96, 44);
                yield return new skulls(5, "c4000BC", 136, 143, 100, 54);
                yield return new skulls(6, "c4000BC", 138, 137, 89, 56);
                yield return new skulls(7, "c4000BC", 139, 130, 108, 48);
                yield return new skulls(8, "c4000BC", 125, 136, 93, 48);
                yield return new skulls(9, "c4000BC", 131, 134, 102, 51);
                yield return new skulls(10, "c4000BC", 134, 134, 99, 51);
                yield return new skulls(11, "c4000BC", 129, 138, 95, 50);
                yield return new skulls(12, "c4000BC", 134, 121, 95, 53);
                yield return new skulls(13, "c4000BC", 126, 129, 109, 51);
                yield return new skulls(14, "c4000BC", 132, 136, 100, 50);
                yield return new skulls(15, "c4000BC", 141, 140, 100, 51);
                yield return new skulls(16, "c4000BC", 131, 134, 97, 54);
                yield return new skulls(17, "c4000BC", 135, 137, 103, 50);
                yield return new skulls(18, "c4000BC", 132, 133, 93, 53);
                yield return new skulls(19, "c4000BC", 139, 136, 96, 50);
                yield return new skulls(20, "c4000BC", 132, 131, 101, 49);
                yield return new skulls(21, "c4000BC", 126, 133, 102, 51);
                yield return new skulls(22, "c4000BC", 135, 135, 103, 47);
                yield return new skulls(23, "c4000BC", 134, 124, 93, 53);
                yield return new skulls(24, "c4000BC", 128, 134, 103, 50);
                yield return new skulls(25, "c4000BC", 130, 130, 104, 49);
                yield return new skulls(26, "c4000BC", 138, 135, 100, 55);
                yield return new skulls(27, "c4000BC", 128, 132, 93, 53);
                yield return new skulls(28, "c4000BC", 127, 129, 106, 48);
                yield return new skulls(29, "c4000BC", 131, 136, 114, 54);
                yield return new skulls(30, "c4000BC", 124, 138, 101, 46);
                yield return new skulls(31, "c3300BC", 124, 138, 101, 48);
                yield return new skulls(32, "c3300BC", 133, 134, 97, 48);
                yield return new skulls(33, "c3300BC", 138, 134, 98, 45);
                yield return new skulls(34, "c3300BC", 148, 129, 104, 51);
                yield return new skulls(35, "c3300BC", 126, 124, 95, 45);
                yield return new skulls(36, "c3300BC", 135, 136, 98, 52);
                yield return new skulls(37, "c3300BC", 132, 145, 100, 54);
                yield return new skulls(38, "c3300BC", 133, 130, 102, 48);
                yield return new skulls(39, "c3300BC", 131, 134, 96, 50);
                yield return new skulls(40, "c3300BC", 133, 125, 94, 46);
                yield return new skulls(41, "c3300BC", 133, 136, 103, 53);
                yield return new skulls(42, "c3300BC", 131, 139, 98, 51);
                yield return new skulls(43, "c3300BC", 131, 136, 99, 56);
                yield return new skulls(44, "c3300BC", 138, 134, 98, 49);
                yield return new skulls(45, "c3300BC", 130, 136, 104, 53);
                yield return new skulls(46, "c3300BC", 131, 128, 98, 45);
                yield return new skulls(47, "c3300BC", 138, 129, 107, 53);
                yield return new skulls(48, "c3300BC", 123, 131, 101, 51);
                yield return new skulls(49, "c3300BC", 130, 129, 105, 47);
                yield return new skulls(50, "c3300BC", 134, 130, 93, 54);
                yield return new skulls(51, "c3300BC", 137, 136, 106, 49);
                yield return new skulls(52, "c3300BC", 126, 131, 100, 48);
                yield return new skulls(53, "c3300BC", 135, 136, 97, 52);
                yield return new skulls(54, "c3300BC", 129, 126, 91, 50);
                yield return new skulls(55, "c3300BC", 134, 139, 101, 49);
                yield return new skulls(56, "c3300BC", 131, 134, 90, 53);
                yield return new skulls(57, "c3300BC", 132, 130, 104, 50);
                yield return new skulls(58, "c3300BC", 130, 132, 93, 52);
                yield return new skulls(59, "c3300BC", 135, 132, 98, 54);
                yield return new skulls(60, "c3300BC", 130, 128, 101, 51);
                yield return new skulls(61, "c1850BC", 137, 141, 96, 52);
                yield return new skulls(62, "c1850BC", 129, 133, 93, 47);
                yield return new skulls(63, "c1850BC", 132, 138, 87, 48);
                yield return new skulls(64, "c1850BC", 130, 134, 106, 50);
                yield return new skulls(65, "c1850BC", 134, 134, 96, 45);
                yield return new skulls(66, "c1850BC", 140, 133, 98, 50);
                yield return new skulls(67, "c1850BC", 138, 138, 95, 47);
                yield return new skulls(68, "c1850BC", 136, 145, 99, 55);
                yield return new skulls(69, "c1850BC", 136, 131, 92, 46);
                yield return new skulls(70, "c1850BC", 126, 136, 95, 56);
                yield return new skulls(71, "c1850BC", 137, 129, 100, 53);
                yield return new skulls(72, "c1850BC", 137, 139, 97, 50);
                yield return new skulls(73, "c1850BC", 136, 126, 101, 50);
                yield return new skulls(74, "c1850BC", 137, 133, 90, 49);
                yield return new skulls(75, "c1850BC", 129, 142, 104, 47);
                yield return new skulls(76, "c1850BC", 135, 138, 102, 55);
                yield return new skulls(77, "c1850BC", 129, 135, 92, 50);
                yield return new skulls(78, "c1850BC", 134, 125, 90, 60);
                yield return new skulls(79, "c1850BC", 138, 134, 96, 51);
                yield return new skulls(80, "c1850BC", 136, 135, 94, 53);
                yield return new skulls(81, "c1850BC", 132, 130, 91, 52);
                yield return new skulls(82, "c1850BC", 133, 131, 100, 50);
                yield return new skulls(83, "c1850BC", 138, 137, 94, 51);
                yield return new skulls(84, "c1850BC", 130, 127, 99, 45);
                yield return new skulls(85, "c1850BC", 136, 133, 91, 49);
                yield return new skulls(86, "c1850BC", 134, 123, 95, 52);
                yield return new skulls(87, "c1850BC", 136, 137, 101, 54);
                yield return new skulls(88, "c1850BC", 133, 131, 96, 49);
                yield return new skulls(89, "c1850BC", 138, 133, 100, 55);
                yield return new skulls(90, "c1850BC", 138, 133, 91, 46);
                yield return new skulls(91, "c200BC", 137, 134, 107, 54);
                yield return new skulls(92, "c200BC", 141, 128, 95, 53);
                yield return new skulls(93, "c200BC", 141, 130, 87, 49);
                yield return new skulls(94, "c200BC", 135, 131, 99, 51);
                yield return new skulls(95, "c200BC", 133, 120, 91, 46);
                yield return new skulls(96, "c200BC", 131, 135, 90, 50);
                yield return new skulls(97, "c200BC", 140, 137, 94, 60);
                yield return new skulls(98, "c200BC", 139, 130, 90, 48);
                yield return new skulls(99, "c200BC", 140, 134, 90, 51);
                yield return new skulls(100, "c200BC", 138, 140, 100, 52);
                yield return new skulls(101, "c200BC", 132, 133, 90, 53);
                yield return new skulls(102, "c200BC", 134, 134, 97, 54);
                yield return new skulls(103, "c200BC", 135, 135, 99, 50);
                yield return new skulls(104, "c200BC", 133, 136, 95, 52);
                yield return new skulls(105, "c200BC", 136, 130, 99, 55);
                yield return new skulls(106, "c200BC", 134, 137, 93, 52);
                yield return new skulls(107, "c200BC", 131, 141, 99, 55);
                yield return new skulls(108, "c200BC", 129, 135, 95, 47);
                yield return new skulls(109, "c200BC", 136, 128, 93, 54);
                yield return new skulls(110, "c200BC", 131, 125, 88, 48);
                yield return new skulls(111, "c200BC", 139, 130, 94, 53);
                yield return new skulls(112, "c200BC", 144, 124, 86, 50);
                yield return new skulls(113, "c200BC", 141, 131, 97, 53);
                yield return new skulls(114, "c200BC", 130, 131, 98, 53);
                yield return new skulls(115, "c200BC", 133, 128, 92, 51);
                yield return new skulls(116, "c200BC", 138, 126, 97, 54);
                yield return new skulls(117, "c200BC", 131, 142, 95, 53);
                yield return new skulls(118, "c200BC", 136, 138, 94, 55);
                yield return new skulls(119, "c200BC", 132, 136, 92, 52);
                yield return new skulls(120, "c200BC", 135, 130, 100, 51);
                yield return new skulls(121, "cAD150", 137, 123, 91, 50);
                yield return new skulls(122, "cAD150", 136, 131, 95, 49);
                yield return new skulls(123, "cAD150", 128, 126, 91, 57);
                yield return new skulls(124, "cAD150", 130, 134, 92, 52);
                yield return new skulls(125, "cAD150", 138, 127, 86, 47);
                yield return new skulls(126, "cAD150", 126, 138, 101, 52);
                yield return new skulls(127, "cAD150", 136, 138, 97, 58);
                yield return new skulls(128, "cAD150", 126, 126, 92, 45);
                yield return new skulls(129, "cAD150", 132, 132, 99, 55);
                yield return new skulls(130, "cAD150", 139, 135, 92, 54);
                yield return new skulls(131, "cAD150", 143, 120, 95, 51);
                yield return new skulls(132, "cAD150", 141, 136, 101, 54);
                yield return new skulls(133, "cAD150", 135, 135, 95, 56);
                yield return new skulls(134, "cAD150", 137, 134, 93, 53);
                yield return new skulls(135, "cAD150", 142, 135, 96, 52);
                yield return new skulls(136, "cAD150", 139, 134, 95, 47);
                yield return new skulls(137, "cAD150", 138, 125, 99, 51);
                yield return new skulls(138, "cAD150", 137, 135, 96, 54);
                yield return new skulls(139, "cAD150", 133, 125, 92, 50);
                yield return new skulls(140, "cAD150", 145, 129, 89, 47);
                yield return new skulls(141, "cAD150", 138, 136, 92, 46);
                yield return new skulls(142, "cAD150", 131, 129, 97, 44);
                yield return new skulls(143, "cAD150", 143, 126, 88, 54);
                yield return new skulls(144, "cAD150", 134, 124, 91, 55);
                yield return new skulls(145, "cAD150", 132, 127, 97, 52);
                yield return new skulls(146, "cAD150", 137, 125, 85, 57);
                yield return new skulls(147, "cAD150", 129, 128, 81, 52);
                yield return new skulls(148, "cAD150", 140, 135, 103, 48);
                yield return new skulls(149, "cAD150", 147, 129, 87, 48);
                yield return new skulls(150, "cAD150", 136, 133, 97, 51);
            }
        }
    }
}
