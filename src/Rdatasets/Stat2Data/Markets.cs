// ReSharper disable All

namespace Rdatasets.Stat2Data
{
    using System.Collections.Generic;

    /// <summary>
    /// Markets
    /// </summary>

    public class Markets
    {
        public readonly int DJIAch;
        public readonly string Date;
        public readonly int Nik225ch;
        public readonly int Up;
        public readonly int lagNik;

        public Markets(int DJIAch, string Date, int Nik225ch, int Up, int lagNik)
        {
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
                yield return new Markets(-39, "6-Aug-09", 136, 1, -122);
                yield return new Markets(-25, "7-Aug-09", 24, 1, 136);
                yield return new Markets(114, "10-Aug-09", 112, 1, 24);
                yield return new Markets(-32, "11-Aug-09", 61, 1, 112);
                yield return new Markets(-97, "12-Aug-09", -150, 0, 61);
                yield return new Markets(120, "13-Aug-09", 82, 1, -150);
                yield return new Markets(37, "14-Aug-09", 80, 1, 82);
                yield return new Markets(-77, "17-Aug-09", -329, 0, 80);
                yield return new Markets(-186, "18-Aug-09", 16, 1, -329);
                yield return new Markets(83, "19-Aug-09", -81, 0, 16);
                yield return new Markets(61, "20-Aug-09", 179, 1, -81);
                yield return new Markets(71, "21-Aug-09", -145, 0, 179);
                yield return new Markets(156, "24-Aug-09", 343, 1, -145);
                yield return new Markets(3, "25-Aug-09", -84, 0, 343);
                yield return new Markets(30, "26-Aug-09", 142, 1, -84);
                yield return new Markets(4, "27-Aug-09", -166, 0, 142);
                yield return new Markets(37, "28-Aug-09", 60, 1, -166);
                yield return new Markets(-36, "31-Aug-09", -42, 0, 60);
                yield return new Markets(-48, "1-Sep-09", 38, 1, -42);
                yield return new Markets(-186, "2-Sep-09", -250, 0, 38);
                yield return new Markets(-30, "3-Sep-09", -66, 0, -250);
                yield return new Markets(64, "4-Sep-09", -28, 0, -66);
                yield return new Markets(97, "7-Sep-09", 134, 1, -28);
                yield return new Markets(56, "9-Sep-09", -81, 0, 72);
                yield return new Markets(50, "10-Sep-09", 202, 1, -81);
                yield return new Markets(80, "11-Sep-09", -69, 0, 202);
                yield return new Markets(-22, "14-Sep-09", -242, 0, -69);
                yield return new Markets(21, "15-Sep-09", 16, 1, -242);
                yield return new Markets(57, "16-Sep-09", 53, 1, 16);
                yield return new Markets(108, "17-Sep-09", 173, 1, 53);
                yield return new Markets(-8, "18-Sep-09", -73, 0, 173);
                yield return new Markets(-41, "25-Sep-09", -278, 0, 174);
                yield return new Markets(-42, "28-Sep-09", -256, 0, -278);
                yield return new Markets(124, "29-Sep-09", 91, 1, -256);
                yield return new Markets(-47, "30-Sep-09", 33, 1, 91);
                yield return new Markets(-30, "1-Oct-09", -155, 0, 33);
                yield return new Markets(-203, "2-Oct-09", -247, 0, -155);
                yield return new Markets(-22, "5-Oct-09", -57, 0, -247);
                yield return new Markets(112, "6-Oct-09", 17, 1, -57);
                yield return new Markets(132, "7-Oct-09", 108, 1, 17);
                yield return new Markets(-6, "8-Oct-09", 33, 1, 108);
                yield return new Markets(61, "9-Oct-09", 184, 1, 33);
                yield return new Markets(-15, "14-Oct-09", -16, 0, 60);
                yield return new Markets(145, "15-Oct-09", 178, 1, -16);
                yield return new Markets(47, "16-Oct-09", 19, 1, 178);
                yield return new Markets(-67, "19-Oct-09", -21, 0, 19);
                yield return new Markets(96, "20-Oct-09", 100, 1, -21);
                yield return new Markets(-51, "21-Oct-09", -3, 0, 100);
                yield return new Markets(-92, "22-Oct-09", -66, 0, -3);
                yield return new Markets(132, "23-Oct-09", 16, 1, -66);
                yield return new Markets(-109, "26-Oct-09", 80, 1, 16);
                yield return new Markets(-104, "27-Oct-09", -150, 0, 80);
                yield return new Markets(14, "28-Oct-09", -137, 0, -150);
                yield return new Markets(-119, "29-Oct-09", -184, 0, -137);
                yield return new Markets(200, "30-Oct-09", 144, 1, -184);
                yield return new Markets(-250, "2-Nov-09", -232, 0, 144);
            }
        }
    }
}
