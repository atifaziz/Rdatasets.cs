// ReSharper disable All

namespace Rdatasets.MASS
{
    using System.Collections.Generic;

    /// <summary>
    /// US Naval Petroleum Reserve No. 1 data
    /// </summary>

    public class npr1
    {
        public readonly double x;
        public readonly double y;
        public readonly int perm;
        public readonly int por;

        public npr1(double x, double y, int perm, int por)
        {
            this.x = x;
            this.y = y;
            this.perm = perm;
            this.por = por;
        }

        public static IEnumerable<npr1> Data
        {
            get
            {
                yield return new npr1(8, 2.38, 327, 33);
                yield return new npr1(13.13, 2.5, 3369, 34);
                yield return new npr1(13.88, 3.13, 4770, 40);
                yield return new npr1(13.38, 2.63, 938, 35);
                yield return new npr1(13.38, 2.13, 568, 32);
                yield return new npr1(13.88, 2.13, 667, 34);
                yield return new npr1(12.25, 2.5, 2561, 32);
                yield return new npr1(12.88, 2.25, 2538, 34);
                yield return new npr1(11.25, 3, 1078, 36);
                yield return new npr1(11.38, 2.13, 1078, 34);
                yield return new npr1(12, 2.25, 3116, 36);
                yield return new npr1(10.25, 2.88, 1619, 34);
                yield return new npr1(10.25, 2.38, 1447, 34);
                yield return new npr1(10.63, 2.75, 1668, 34);
                yield return new npr1(10.75, 2.25, 208, 35);
                yield return new npr1(9.25, 2.75, 2994, 35);
                yield return new npr1(9.38, 2.25, 2079, 35);
                yield return new npr1(9.63, 2.63, 762, 33);
                yield return new npr1(9.75, 3, 539, 32);
                yield return new npr1(9.75, 2.13, 610, 35);
                yield return new npr1(8.25, 2.38, 2211, 32);
                yield return new npr1(8.75, 2.13, 2617, 32);
                yield return new npr1(8.88, 2.75, 993, 31);
                yield return new npr1(9, 2.13, 1096, 35);
                yield return new npr1(9.38, 1.25, 538, 33);
                yield return new npr1(9.5, 1.38, 745, 35);
                yield return new npr1(9.63, 1.25, 592, 34);
                yield return new npr1(9.75, 1.63, 937, 36);
                yield return new npr1(9.75, 1.25, 1239, 32);
                yield return new npr1(9.88, 1.25, 1055, 36);
                yield return new npr1(10, 1.63, 185, 27);
                yield return new npr1(10, 1.13, 1172, 35);
                yield return new npr1(10.13, 1.5, 1863, 35);
                yield return new npr1(10.13, 1.25, 1141, 33);
                yield return new npr1(10.25, 1.13, 892, 35);
                yield return new npr1(10.38, 1.25, 2124, 35);
                yield return new npr1(10.5, 1.13, 1090, 33);
                yield return new npr1(10.63, 1.25, 785, 32);
                yield return new npr1(10.75, 2, 280, 37);
                yield return new npr1(10.75, 1.38, 270, 32);
                yield return new npr1(10.75, 1.13, 1752, 32);
                yield return new npr1(10.88, 1.25, 2477, 32);
                yield return new npr1(11, 1.75, 683, 32);
                yield return new npr1(11, 1.13, 1109, 33);
                yield return new npr1(11.25, 1.38, 1385, 33);
                yield return new npr1(11.5, 1.63, 1864, 34);
                yield return new npr1(11.75, 1.75, 765, 34);
                yield return new npr1(11.88, 1.5, 727, 32);
                yield return new npr1(11.88, 1.25, 1351, 32);
                yield return new npr1(12.25, 1.88, 963, 33);
                yield return new npr1(12.25, 1.38, 1309, 30);
                yield return new npr1(12.63, 2, 1883, 35);
                yield return new npr1(12.75, 1.63, 926, 35);
                yield return new npr1(12.88, 1.13, 2558, 30);
                yield return new npr1(13.38, 1.75, 1339, 33);
                yield return new npr1(7.75, 4.13, 1393, 38);
                yield return new npr1(6.13, 3.38, 162, 34);
                yield return new npr1(7, 3.38, 857, 34);
                yield return new npr1(8.38, 5.63, 2048, 31);
                yield return new npr1(13.38, 4.25, 2105, 32);
                yield return new npr1(11.88, 4.25, 1217, 33);
                yield return new npr1(11.25, 4.38, 767, 34);
                yield return new npr1(10.13, 4.25, 2655, 35);
                yield return new npr1(10.88, 4.25, 3790, 35);
                yield return new npr1(9.38, 4.38, 3457, 37);
                yield return new npr1(9.5, 4.63, 785, 34);
                yield return new npr1(9.5, 4.13, 3360, 35);
                yield return new npr1(10, 4.13, 1255, 38);
                yield return new npr1(8.5, 4.5, 213, 33);
                yield return new npr1(8.75, 5, 248, 35);
                yield return new npr1(9, 4.75, 3091, 36);
                yield return new npr1(9, 4.25, 459, 34);
                yield return new npr1(8.75, 3.13, 4022, 31);
                yield return new npr1(9, 4, 1169, 34);
                yield return new npr1(9, 3.63, 681, 30);
                yield return new npr1(9.38, 3.25, 1690, 37);
                yield return new npr1(9.63, 3.75, 2341, 36);
                yield return new npr1(9.88, 4, 2763, 35);
                yield return new npr1(9.88, 3.75, 758, 35);
                yield return new npr1(10.13, 3.13, 305, 36);
                yield return new npr1(10.13, 3.75, 2569, 38);
                yield return new npr1(10.5, 3.88, 906, 30);
                yield return new npr1(10.5, 3.38, 1301, 34);
                yield return new npr1(10.75, 3.13, 80, 31);
                yield return new npr1(10.88, 3.38, 897, 38);
                yield return new npr1(11, 3.88, 2169, 33);
                yield return new npr1(11.38, 3.5, 1128, 28);
                yield return new npr1(11.5, 3.88, 4244, 34);
                yield return new npr1(11.13, 3.25, 3347, 36);
                yield return new npr1(11.63, 4, 2166, 36);
                yield return new npr1(12.38, 3.75, 2887, 36);
                yield return new npr1(13, 3.38, 2383, 35);
                yield return new npr1(12.25, 3.63, 4, 31);
                yield return new npr1(12.13, 3.13, 1437, 37);
                yield return new npr1(13, 3.63, 1423, 33);
                yield return new npr1(13.63, 4, 2005, 31);
                yield return new npr1(13.63, 3.63, 1659, 37);
                yield return new npr1(13.63, 3.5, 2011, 37);
                yield return new npr1(13.75, 3.88, 529, 32);
                yield return new npr1(13.88, 4, 1484, 33);
                yield return new npr1(13.88, 3.63, 918, 34);
                yield return new npr1(13.38, 3.63, 2319, 36);
                yield return new npr1(13.5, 3.75, 1611, 37);
                yield return new npr1(13.5, 3.13, 1454, 36);
            }
        }
    }
}
