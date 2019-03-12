// ReSharper disable All

namespace Rdatasets.fpp2
{
    using System.Collections.Generic;

    /// <summary>
    /// Electrical equipment manufactured in the Euro area.
    /// </summary>

    public class elecequip
    {
        public readonly int κ;
        public readonly double time;
        public readonly double value;

        public elecequip(int κ, double time, double value)
        {
            this.κ = κ;
            this.time = time;
            this.value = value;
        }

        public static IEnumerable<elecequip> Data
        {
            get
            {
                yield return new elecequip(1, 1996, 79.35);
                yield return new elecequip(2, 1996.08333333333, 75.78);
                yield return new elecequip(3, 1996.16666666667, 86.32);
                yield return new elecequip(4, 1996.25, 72.6);
                yield return new elecequip(5, 1996.33333333333, 74.86);
                yield return new elecequip(6, 1996.41666666667, 83.81);
                yield return new elecequip(7, 1996.5, 79.8);
                yield return new elecequip(8, 1996.58333333333, 62.41);
                yield return new elecequip(9, 1996.66666666667, 85.41);
                yield return new elecequip(10, 1996.75, 83.11);
                yield return new elecequip(11, 1996.83333333333, 84.21);
                yield return new elecequip(12, 1996.91666666667, 89.7);
                yield return new elecequip(13, 1997, 78.64);
                yield return new elecequip(14, 1997.08333333333, 77.42);
                yield return new elecequip(15, 1997.16666666667, 89.86);
                yield return new elecequip(16, 1997.25, 81.27);
                yield return new elecequip(17, 1997.33333333333, 78.68);
                yield return new elecequip(18, 1997.41666666667, 89.51);
                yield return new elecequip(19, 1997.5, 83.67);
                yield return new elecequip(20, 1997.58333333333, 69.8);
                yield return new elecequip(21, 1997.66666666667, 91.09);
                yield return new elecequip(22, 1997.75, 89.43);
                yield return new elecequip(23, 1997.83333333333, 91.04);
                yield return new elecequip(24, 1997.91666666667, 92.87);
                yield return new elecequip(25, 1998, 81.87);
                yield return new elecequip(26, 1998.08333333333, 85.36);
                yield return new elecequip(27, 1998.16666666667, 92.98);
                yield return new elecequip(28, 1998.25, 81.09);
                yield return new elecequip(29, 1998.33333333333, 85.64);
                yield return new elecequip(30, 1998.41666666667, 91.14);
                yield return new elecequip(31, 1998.5, 83.46);
                yield return new elecequip(32, 1998.58333333333, 66.37);
                yield return new elecequip(33, 1998.66666666667, 93.34);
                yield return new elecequip(34, 1998.75, 85.93);
                yield return new elecequip(35, 1998.83333333333, 86.81);
                yield return new elecequip(36, 1998.91666666667, 93.3);
                yield return new elecequip(37, 1999, 81.59);
                yield return new elecequip(38, 1999.08333333333, 81.77);
                yield return new elecequip(39, 1999.16666666667, 91.24);
                yield return new elecequip(40, 1999.25, 79.45);
                yield return new elecequip(41, 1999.33333333333, 86.99);
                yield return new elecequip(42, 1999.41666666667, 96.6);
                yield return new elecequip(43, 1999.5, 97.99);
                yield return new elecequip(44, 1999.58333333333, 79.13);
                yield return new elecequip(45, 1999.66666666667, 103.56);
                yield return new elecequip(46, 1999.75, 100.89);
                yield return new elecequip(47, 1999.83333333333, 99.4);
                yield return new elecequip(48, 1999.91666666667, 111.8);
                yield return new elecequip(49, 2000, 95.3);
                yield return new elecequip(50, 2000.08333333333, 97.77);
                yield return new elecequip(51, 2000.16666666667, 116.23);
                yield return new elecequip(52, 2000.25, 100.98);
                yield return new elecequip(53, 2000.33333333333, 104.07);
                yield return new elecequip(54, 2000.41666666667, 114.64);
                yield return new elecequip(55, 2000.5, 107.62);
                yield return new elecequip(56, 2000.58333333333, 96.12);
                yield return new elecequip(57, 2000.66666666667, 123.5);
                yield return new elecequip(58, 2000.75, 116.12);
                yield return new elecequip(59, 2000.83333333333, 116.86);
                yield return new elecequip(60, 2000.91666666667, 128.61);
                yield return new elecequip(61, 2001, 100.56);
                yield return new elecequip(62, 2001.08333333333, 103.05);
                yield return new elecequip(63, 2001.16666666667, 119.06);
                yield return new elecequip(64, 2001.25, 92.46);
                yield return new elecequip(65, 2001.33333333333, 98.75);
                yield return new elecequip(66, 2001.41666666667, 111.14);
                yield return new elecequip(67, 2001.5, 96.13);
                yield return new elecequip(68, 2001.58333333333, 79.72);
                yield return new elecequip(69, 2001.66666666667, 102.07);
                yield return new elecequip(70, 2001.75, 96.18);
                yield return new elecequip(71, 2001.83333333333, 101.26);
                yield return new elecequip(72, 2001.91666666667, 109.85);
                yield return new elecequip(73, 2002, 89.52);
                yield return new elecequip(74, 2002.08333333333, 89.27);
                yield return new elecequip(75, 2002.16666666667, 104.35);
                yield return new elecequip(76, 2002.25, 87.05);
                yield return new elecequip(77, 2002.33333333333, 89.33);
                yield return new elecequip(78, 2002.41666666667, 102.2);
                yield return new elecequip(79, 2002.5, 88.13);
                yield return new elecequip(80, 2002.58333333333, 75.68);
                yield return new elecequip(81, 2002.66666666667, 99.48);
                yield return new elecequip(82, 2002.75, 96.4);
                yield return new elecequip(83, 2002.83333333333, 96.16);
                yield return new elecequip(84, 2002.91666666667, 101);
                yield return new elecequip(85, 2003, 89.34);
                yield return new elecequip(86, 2003.08333333333, 86.91);
                yield return new elecequip(87, 2003.16666666667, 98.9);
                yield return new elecequip(88, 2003.25, 85.54);
                yield return new elecequip(89, 2003.33333333333, 85.25);
                yield return new elecequip(90, 2003.41666666667, 101.14);
                yield return new elecequip(91, 2003.5, 91.8);
                yield return new elecequip(92, 2003.58333333333, 76.98);
                yield return new elecequip(93, 2003.66666666667, 104.33);
                yield return new elecequip(94, 2003.75, 99.72);
                yield return new elecequip(95, 2003.83333333333, 101.06);
                yield return new elecequip(96, 2003.91666666667, 109);
                yield return new elecequip(97, 2004, 89.88);
                yield return new elecequip(98, 2004.08333333333, 92.27);
                yield return new elecequip(99, 2004.16666666667, 105.11);
                yield return new elecequip(100, 2004.25, 91.5);
                yield return new elecequip(101, 2004.33333333333, 92.56);
                yield return new elecequip(102, 2004.41666666667, 104.35);
                yield return new elecequip(103, 2004.5, 96.21);
                yield return new elecequip(104, 2004.58333333333, 79.58);
                yield return new elecequip(105, 2004.66666666667, 105.43);
                yield return new elecequip(106, 2004.75, 99.18);
                yield return new elecequip(107, 2004.83333333333, 99.77);
                yield return new elecequip(108, 2004.91666666667, 113.55);
                yield return new elecequip(109, 2005, 91.65);
                yield return new elecequip(110, 2005.08333333333, 90.56);
                yield return new elecequip(111, 2005.16666666667, 105.52);
                yield return new elecequip(112, 2005.25, 92.18);
                yield return new elecequip(113, 2005.33333333333, 91.22);
                yield return new elecequip(114, 2005.41666666667, 109.04);
                yield return new elecequip(115, 2005.5, 99.26);
                yield return new elecequip(116, 2005.58333333333, 83.36);
                yield return new elecequip(117, 2005.66666666667, 110.8);
                yield return new elecequip(118, 2005.75, 104.95);
                yield return new elecequip(119, 2005.83333333333, 107.07);
                yield return new elecequip(120, 2005.91666666667, 114.4);
                yield return new elecequip(121, 2006, 99.16);
                yield return new elecequip(122, 2006.08333333333, 99.86);
                yield return new elecequip(123, 2006.16666666667, 116.14);
                yield return new elecequip(124, 2006.25, 103.48);
                yield return new elecequip(125, 2006.33333333333, 103.07);
                yield return new elecequip(126, 2006.41666666667, 119.32);
                yield return new elecequip(127, 2006.5, 107.94);
                yield return new elecequip(128, 2006.58333333333, 90.59);
                yield return new elecequip(129, 2006.66666666667, 121.8);
                yield return new elecequip(130, 2006.75, 117.11);
                yield return new elecequip(131, 2006.83333333333, 113.71);
                yield return new elecequip(132, 2006.91666666667, 120.37);
                yield return new elecequip(133, 2007, 103.93);
                yield return new elecequip(134, 2007.08333333333, 104.1);
                yield return new elecequip(135, 2007.16666666667, 125.72);
                yield return new elecequip(136, 2007.25, 104.7);
                yield return new elecequip(137, 2007.33333333333, 108.45);
                yield return new elecequip(138, 2007.41666666667, 123.11);
                yield return new elecequip(139, 2007.5, 108.89);
                yield return new elecequip(140, 2007.58333333333, 94.07);
                yield return new elecequip(141, 2007.66666666667, 121.88);
                yield return new elecequip(142, 2007.75, 116.81);
                yield return new elecequip(143, 2007.83333333333, 115.87);
                yield return new elecequip(144, 2007.91666666667, 127.14);
                yield return new elecequip(145, 2008, 109.45);
                yield return new elecequip(146, 2008.08333333333, 105.23);
                yield return new elecequip(147, 2008.16666666667, 121.32);
                yield return new elecequip(148, 2008.25, 108.78);
                yield return new elecequip(149, 2008.33333333333, 103.2);
                yield return new elecequip(150, 2008.41666666667, 117.93);
                yield return new elecequip(151, 2008.5, 103.76);
                yield return new elecequip(152, 2008.58333333333, 89.27);
                yield return new elecequip(153, 2008.66666666667, 109.5);
                yield return new elecequip(154, 2008.75, 104.02);
                yield return new elecequip(155, 2008.83333333333, 100.12);
                yield return new elecequip(156, 2008.91666666667, 101.18);
                yield return new elecequip(157, 2009, 77.38);
                yield return new elecequip(158, 2009.08333333333, 75.19);
                yield return new elecequip(159, 2009.16666666667, 86.4);
                yield return new elecequip(160, 2009.25, 74.13);
                yield return new elecequip(161, 2009.33333333333, 74.1);
                yield return new elecequip(162, 2009.41666666667, 85.61);
                yield return new elecequip(163, 2009.5, 79.9);
                yield return new elecequip(164, 2009.58333333333, 65.36);
                yield return new elecequip(165, 2009.66666666667, 88.09);
                yield return new elecequip(166, 2009.75, 84.6);
                yield return new elecequip(167, 2009.83333333333, 88.09);
                yield return new elecequip(168, 2009.91666666667, 102.52);
                yield return new elecequip(169, 2010, 79.28);
                yield return new elecequip(170, 2010.08333333333, 78.74);
                yield return new elecequip(171, 2010.16666666667, 94.62);
                yield return new elecequip(172, 2010.25, 84.66);
                yield return new elecequip(173, 2010.33333333333, 85.2);
                yield return new elecequip(174, 2010.41666666667, 103.94);
                yield return new elecequip(175, 2010.5, 89.87);
                yield return new elecequip(176, 2010.58333333333, 78.14);
                yield return new elecequip(177, 2010.66666666667, 96.5);
                yield return new elecequip(178, 2010.75, 94.68);
                yield return new elecequip(179, 2010.83333333333, 101.77);
                yield return new elecequip(180, 2010.91666666667, 103.48);
                yield return new elecequip(181, 2011, 92.57);
                yield return new elecequip(182, 2011.08333333333, 89.16);
                yield return new elecequip(183, 2011.16666666667, 104.48);
                yield return new elecequip(184, 2011.25, 89.45);
                yield return new elecequip(185, 2011.33333333333, 93.4);
                yield return new elecequip(186, 2011.41666666667, 102.9);
                yield return new elecequip(187, 2011.5, 93.77);
                yield return new elecequip(188, 2011.58333333333, 77.58);
                yield return new elecequip(189, 2011.66666666667, 95.04);
                yield return new elecequip(190, 2011.75, 91.77);
                yield return new elecequip(191, 2011.83333333333, 93.37);
                yield return new elecequip(192, 2011.91666666667, 98.34);
                yield return new elecequip(193, 2012, 86.44);
                yield return new elecequip(194, 2012.08333333333, 85.04);
                yield return new elecequip(195, 2012.16666666667, 97.8);
            }
        }
    }
}
