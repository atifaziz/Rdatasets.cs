// ReSharper disable All

namespace Rdatasets.DAAG
{
    using System.Collections.Generic;

    /// <summary>
    /// Canadian Labour Force Summary Data (1995-96)
    /// </summary>

    public class jobs
    {
        public readonly int κ;
        public readonly int BC;
        public readonly int Alberta;
        public readonly int Prairies;
        public readonly int Ontario;
        public readonly int Quebec;
        public readonly int Atlantic;
        public readonly double Date;

        public jobs(int κ, int BC, int Alberta, int Prairies, int Ontario, int Quebec, int Atlantic, double Date)
        {
            this.κ = κ;
            this.BC = BC;
            this.Alberta = Alberta;
            this.Prairies = Prairies;
            this.Ontario = Ontario;
            this.Quebec = Quebec;
            this.Atlantic = Atlantic;
            this.Date = Date;
        }

        public static IEnumerable<jobs> Data
        {
            get
            {
                yield return new jobs(1, 1752, 1366, 982, 5239, 3196, 947, 95);
                yield return new jobs(2, 1737, 1369, 981, 5233, 3205, 946, 95.08333);
                yield return new jobs(3, 1765, 1380, 984, 5212, 3191, 954, 95.16667);
                yield return new jobs(4, 1762, 1372, 982, 5222, 3197, 953, 95.25);
                yield return new jobs(5, 1754, 1368, 981, 5229, 3202, 952, 95.33333);
                yield return new jobs(6, 1759, 1375, 983, 5225, 3201, 949, 95.41667);
                yield return new jobs(7, 1766, 1371, 983, 5220, 3194, 951, 95.5);
                yield return new jobs(8, 1775, 1376, 983, 5216, 3203, 957, 95.58333);
                yield return new jobs(9, 1777, 1374, 983, 5226, 3208, 960, 95.66667);
                yield return new jobs(10, 1771, 1379, 979, 5249, 3222, 961, 95.75);
                yield return new jobs(11, 1757, 1378, 973, 5252, 3207, 956, 95.83333);
                yield return new jobs(12, 1766, 1380, 979, 5258, 3225, 968, 95.91667);
                yield return new jobs(13, 1786, 1389, 974, 5261, 3253, 958, 96);
                yield return new jobs(14, 1784, 1396, 981, 5292, 3257, 950, 96.08333);
                yield return new jobs(15, 1791, 1410, 985, 5291, 3238, 941, 96.16667);
                yield return new jobs(16, 1800, 1417, 987, 5299, 3238, 952, 96.25);
                yield return new jobs(17, 1800, 1407, 986, 5282, 3243, 952, 96.33333);
                yield return new jobs(18, 1798, 1408, 980, 5278, 3202, 950, 96.41667);
                yield return new jobs(19, 1814, 1420, 983, 5309, 3167, 951, 96.5);
                yield return new jobs(20, 1803, 1409, 983, 5360, 3208, 953, 96.58333);
                yield return new jobs(21, 1796, 1413, 988, 5325, 3199, 945, 96.66667);
                yield return new jobs(22, 1818, 1416, 994, 5352, 3199, 944, 96.75);
                yield return new jobs(23, 1829, 1426, 990, 5347, 3193, 943, 96.83333);
                yield return new jobs(24, 1840, 1436, 999, 5335, 3207, 942, 96.91667);
            }
        }
    }
}
