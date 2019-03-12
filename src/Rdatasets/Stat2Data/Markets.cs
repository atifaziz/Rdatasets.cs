// ReSharper disable All

namespace Rdatasets.Stat2Data
{
    using System.Collections.Generic;

    /// <summary>
    /// Markets
    /// </summary>

    public class Markets
    {
        public readonly int κ;
        public readonly int DJIAch;
        public readonly string Date;
        public readonly int Nik225ch;
        public readonly int Up;
        public readonly int lagNik;

        public Markets(int κ, int DJIAch, string Date, int Nik225ch, int Up, int lagNik)
        {
            this.κ = κ;
            this.DJIAch = DJIAch;
            this.Date = Date;
            this.Nik225ch = Nik225ch;
            this.Up = Up;
            this.lagNik = lagNik;
        }

        public static IEnumerable<Markets> Data
        {
            get
            {
                yield return new Markets(1, -39, "6-Aug-09", 136, 1, -122);
                yield return new Markets(2, -25, "7-Aug-09", 24, 1, 136);
                yield return new Markets(3, 114, "10-Aug-09", 112, 1, 24);
                yield return new Markets(4, -32, "11-Aug-09", 61, 1, 112);
                yield return new Markets(5, -97, "12-Aug-09", -150, 0, 61);
                yield return new Markets(6, 120, "13-Aug-09", 82, 1, -150);
                yield return new Markets(7, 37, "14-Aug-09", 80, 1, 82);
                yield return new Markets(8, -77, "17-Aug-09", -329, 0, 80);
                yield return new Markets(9, -186, "18-Aug-09", 16, 1, -329);
                yield return new Markets(10, 83, "19-Aug-09", -81, 0, 16);
                yield return new Markets(11, 61, "20-Aug-09", 179, 1, -81);
                yield return new Markets(12, 71, "21-Aug-09", -145, 0, 179);
                yield return new Markets(13, 156, "24-Aug-09", 343, 1, -145);
                yield return new Markets(14, 3, "25-Aug-09", -84, 0, 343);
                yield return new Markets(15, 30, "26-Aug-09", 142, 1, -84);
                yield return new Markets(16, 4, "27-Aug-09", -166, 0, 142);
                yield return new Markets(17, 37, "28-Aug-09", 60, 1, -166);
                yield return new Markets(18, -36, "31-Aug-09", -42, 0, 60);
                yield return new Markets(19, -48, "1-Sep-09", 38, 1, -42);
                yield return new Markets(20, -186, "2-Sep-09", -250, 0, 38);
                yield return new Markets(21, -30, "3-Sep-09", -66, 0, -250);
                yield return new Markets(22, 64, "4-Sep-09", -28, 0, -66);
                yield return new Markets(23, 97, "7-Sep-09", 134, 1, -28);
                yield return new Markets(24, 56, "9-Sep-09", -81, 0, 72);
                yield return new Markets(25, 50, "10-Sep-09", 202, 1, -81);
                yield return new Markets(26, 80, "11-Sep-09", -69, 0, 202);
                yield return new Markets(27, -22, "14-Sep-09", -242, 0, -69);
                yield return new Markets(28, 21, "15-Sep-09", 16, 1, -242);
                yield return new Markets(29, 57, "16-Sep-09", 53, 1, 16);
                yield return new Markets(30, 108, "17-Sep-09", 173, 1, 53);
                yield return new Markets(31, -8, "18-Sep-09", -73, 0, 173);
                yield return new Markets(32, -41, "25-Sep-09", -278, 0, 174);
                yield return new Markets(33, -42, "28-Sep-09", -256, 0, -278);
                yield return new Markets(34, 124, "29-Sep-09", 91, 1, -256);
                yield return new Markets(35, -47, "30-Sep-09", 33, 1, 91);
                yield return new Markets(36, -30, "1-Oct-09", -155, 0, 33);
                yield return new Markets(37, -203, "2-Oct-09", -247, 0, -155);
                yield return new Markets(38, -22, "5-Oct-09", -57, 0, -247);
                yield return new Markets(39, 112, "6-Oct-09", 17, 1, -57);
                yield return new Markets(40, 132, "7-Oct-09", 108, 1, 17);
                yield return new Markets(41, -6, "8-Oct-09", 33, 1, 108);
                yield return new Markets(42, 61, "9-Oct-09", 184, 1, 33);
                yield return new Markets(43, -15, "14-Oct-09", -16, 0, 60);
                yield return new Markets(44, 145, "15-Oct-09", 178, 1, -16);
                yield return new Markets(45, 47, "16-Oct-09", 19, 1, 178);
                yield return new Markets(46, -67, "19-Oct-09", -21, 0, 19);
                yield return new Markets(47, 96, "20-Oct-09", 100, 1, -21);
                yield return new Markets(48, -51, "21-Oct-09", -3, 0, 100);
                yield return new Markets(49, -92, "22-Oct-09", -66, 0, -3);
                yield return new Markets(50, 132, "23-Oct-09", 16, 1, -66);
                yield return new Markets(51, -109, "26-Oct-09", 80, 1, 16);
                yield return new Markets(52, -104, "27-Oct-09", -150, 0, 80);
                yield return new Markets(53, 14, "28-Oct-09", -137, 0, -150);
                yield return new Markets(54, -119, "29-Oct-09", -184, 0, -137);
                yield return new Markets(55, 200, "30-Oct-09", 144, 1, -184);
                yield return new Markets(56, -250, "2-Nov-09", -232, 0, 144);
            }
        }
    }
}
