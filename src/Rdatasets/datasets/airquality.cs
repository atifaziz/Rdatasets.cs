// ReSharper disable All

namespace Rdatasets.datasets
{
    using System.Collections.Generic;

    /// <summary>
    /// New York Air Quality Measurements
    /// </summary>

    public class airquality
    {
        public readonly string Ozone;
        public readonly string Solar_R;
        public readonly double Wind;
        public readonly int Temp;
        public readonly int Month;
        public readonly int Day;

        public airquality(string Ozone, string Solar_R, double Wind, int Temp, int Month, int Day)
        {
            this.Ozone = Ozone;
            this.Solar_R = Solar_R;
            this.Wind = Wind;
            this.Temp = Temp;
            this.Month = Month;
            this.Day = Day;
        }

        public static IEnumerable<airquality> Data
        {
            get
            {
                yield return new airquality("41", "190", 7.4, 67, 5, 1);
                yield return new airquality("36", "118", 8, 72, 5, 2);
                yield return new airquality("12", "149", 12.6, 74, 5, 3);
                yield return new airquality("18", "313", 11.5, 62, 5, 4);
                yield return new airquality(null, null, 14.3, 56, 5, 5);
                yield return new airquality("28", null, 14.9, 66, 5, 6);
                yield return new airquality("23", "299", 8.6, 65, 5, 7);
                yield return new airquality("19", "99", 13.8, 59, 5, 8);
                yield return new airquality("8", "19", 20.1, 61, 5, 9);
                yield return new airquality(null, "194", 8.6, 69, 5, 10);
                yield return new airquality("7", null, 6.9, 74, 5, 11);
                yield return new airquality("16", "256", 9.7, 69, 5, 12);
                yield return new airquality("11", "290", 9.2, 66, 5, 13);
                yield return new airquality("14", "274", 10.9, 68, 5, 14);
                yield return new airquality("18", "65", 13.2, 58, 5, 15);
                yield return new airquality("14", "334", 11.5, 64, 5, 16);
                yield return new airquality("34", "307", 12, 66, 5, 17);
                yield return new airquality("6", "78", 18.4, 57, 5, 18);
                yield return new airquality("30", "322", 11.5, 68, 5, 19);
                yield return new airquality("11", "44", 9.7, 62, 5, 20);
                yield return new airquality("1", "8", 9.7, 59, 5, 21);
                yield return new airquality("11", "320", 16.6, 73, 5, 22);
                yield return new airquality("4", "25", 9.7, 61, 5, 23);
                yield return new airquality("32", "92", 12, 61, 5, 24);
                yield return new airquality(null, "66", 16.6, 57, 5, 25);
                yield return new airquality(null, "266", 14.9, 58, 5, 26);
                yield return new airquality(null, null, 8, 57, 5, 27);
                yield return new airquality("23", "13", 12, 67, 5, 28);
                yield return new airquality("45", "252", 14.9, 81, 5, 29);
                yield return new airquality("115", "223", 5.7, 79, 5, 30);
                yield return new airquality("37", "279", 7.4, 76, 5, 31);
                yield return new airquality(null, "286", 8.6, 78, 6, 1);
                yield return new airquality(null, "287", 9.7, 74, 6, 2);
                yield return new airquality(null, "242", 16.1, 67, 6, 3);
                yield return new airquality(null, "186", 9.2, 84, 6, 4);
                yield return new airquality(null, "220", 8.6, 85, 6, 5);
                yield return new airquality(null, "264", 14.3, 79, 6, 6);
                yield return new airquality("29", "127", 9.7, 82, 6, 7);
                yield return new airquality(null, "273", 6.9, 87, 6, 8);
                yield return new airquality("71", "291", 13.8, 90, 6, 9);
                yield return new airquality("39", "323", 11.5, 87, 6, 10);
                yield return new airquality(null, "259", 10.9, 93, 6, 11);
                yield return new airquality(null, "250", 9.2, 92, 6, 12);
                yield return new airquality("23", "148", 8, 82, 6, 13);
                yield return new airquality(null, "332", 13.8, 80, 6, 14);
                yield return new airquality(null, "322", 11.5, 79, 6, 15);
                yield return new airquality("21", "191", 14.9, 77, 6, 16);
                yield return new airquality("37", "284", 20.7, 72, 6, 17);
                yield return new airquality("20", "37", 9.2, 65, 6, 18);
                yield return new airquality("12", "120", 11.5, 73, 6, 19);
                yield return new airquality("13", "137", 10.3, 76, 6, 20);
                yield return new airquality(null, "150", 6.3, 77, 6, 21);
                yield return new airquality(null, "59", 1.7, 76, 6, 22);
                yield return new airquality(null, "91", 4.6, 76, 6, 23);
                yield return new airquality(null, "250", 6.3, 76, 6, 24);
                yield return new airquality(null, "135", 8, 75, 6, 25);
                yield return new airquality(null, "127", 8, 78, 6, 26);
                yield return new airquality(null, "47", 10.3, 73, 6, 27);
                yield return new airquality(null, "98", 11.5, 80, 6, 28);
                yield return new airquality(null, "31", 14.9, 77, 6, 29);
                yield return new airquality(null, "138", 8, 83, 6, 30);
                yield return new airquality("135", "269", 4.1, 84, 7, 1);
                yield return new airquality("49", "248", 9.2, 85, 7, 2);
                yield return new airquality("32", "236", 9.2, 81, 7, 3);
                yield return new airquality(null, "101", 10.9, 84, 7, 4);
                yield return new airquality("64", "175", 4.6, 83, 7, 5);
                yield return new airquality("40", "314", 10.9, 83, 7, 6);
                yield return new airquality("77", "276", 5.1, 88, 7, 7);
                yield return new airquality("97", "267", 6.3, 92, 7, 8);
                yield return new airquality("97", "272", 5.7, 92, 7, 9);
                yield return new airquality("85", "175", 7.4, 89, 7, 10);
                yield return new airquality(null, "139", 8.6, 82, 7, 11);
                yield return new airquality("10", "264", 14.3, 73, 7, 12);
                yield return new airquality("27", "175", 14.9, 81, 7, 13);
                yield return new airquality(null, "291", 14.9, 91, 7, 14);
                yield return new airquality("7", "48", 14.3, 80, 7, 15);
                yield return new airquality("48", "260", 6.9, 81, 7, 16);
                yield return new airquality("35", "274", 10.3, 82, 7, 17);
                yield return new airquality("61", "285", 6.3, 84, 7, 18);
                yield return new airquality("79", "187", 5.1, 87, 7, 19);
                yield return new airquality("63", "220", 11.5, 85, 7, 20);
                yield return new airquality("16", "7", 6.9, 74, 7, 21);
                yield return new airquality(null, "258", 9.7, 81, 7, 22);
                yield return new airquality(null, "295", 11.5, 82, 7, 23);
                yield return new airquality("80", "294", 8.6, 86, 7, 24);
                yield return new airquality("108", "223", 8, 85, 7, 25);
                yield return new airquality("20", "81", 8.6, 82, 7, 26);
                yield return new airquality("52", "82", 12, 86, 7, 27);
                yield return new airquality("82", "213", 7.4, 88, 7, 28);
                yield return new airquality("50", "275", 7.4, 86, 7, 29);
                yield return new airquality("64", "253", 7.4, 83, 7, 30);
                yield return new airquality("59", "254", 9.2, 81, 7, 31);
                yield return new airquality("39", "83", 6.9, 81, 8, 1);
                yield return new airquality("9", "24", 13.8, 81, 8, 2);
                yield return new airquality("16", "77", 7.4, 82, 8, 3);
                yield return new airquality("78", null, 6.9, 86, 8, 4);
                yield return new airquality("35", null, 7.4, 85, 8, 5);
                yield return new airquality("66", null, 4.6, 87, 8, 6);
                yield return new airquality("122", "255", 4, 89, 8, 7);
                yield return new airquality("89", "229", 10.3, 90, 8, 8);
                yield return new airquality("110", "207", 8, 90, 8, 9);
                yield return new airquality(null, "222", 8.6, 92, 8, 10);
                yield return new airquality(null, "137", 11.5, 86, 8, 11);
                yield return new airquality("44", "192", 11.5, 86, 8, 12);
                yield return new airquality("28", "273", 11.5, 82, 8, 13);
                yield return new airquality("65", "157", 9.7, 80, 8, 14);
                yield return new airquality(null, "64", 11.5, 79, 8, 15);
                yield return new airquality("22", "71", 10.3, 77, 8, 16);
                yield return new airquality("59", "51", 6.3, 79, 8, 17);
                yield return new airquality("23", "115", 7.4, 76, 8, 18);
                yield return new airquality("31", "244", 10.9, 78, 8, 19);
                yield return new airquality("44", "190", 10.3, 78, 8, 20);
                yield return new airquality("21", "259", 15.5, 77, 8, 21);
                yield return new airquality("9", "36", 14.3, 72, 8, 22);
                yield return new airquality(null, "255", 12.6, 75, 8, 23);
                yield return new airquality("45", "212", 9.7, 79, 8, 24);
                yield return new airquality("168", "238", 3.4, 81, 8, 25);
                yield return new airquality("73", "215", 8, 86, 8, 26);
                yield return new airquality(null, "153", 5.7, 88, 8, 27);
                yield return new airquality("76", "203", 9.7, 97, 8, 28);
                yield return new airquality("118", "225", 2.3, 94, 8, 29);
                yield return new airquality("84", "237", 6.3, 96, 8, 30);
                yield return new airquality("85", "188", 6.3, 94, 8, 31);
                yield return new airquality("96", "167", 6.9, 91, 9, 1);
                yield return new airquality("78", "197", 5.1, 92, 9, 2);
                yield return new airquality("73", "183", 2.8, 93, 9, 3);
                yield return new airquality("91", "189", 4.6, 93, 9, 4);
                yield return new airquality("47", "95", 7.4, 87, 9, 5);
                yield return new airquality("32", "92", 15.5, 84, 9, 6);
                yield return new airquality("20", "252", 10.9, 80, 9, 7);
                yield return new airquality("23", "220", 10.3, 78, 9, 8);
                yield return new airquality("21", "230", 10.9, 75, 9, 9);
                yield return new airquality("24", "259", 9.7, 73, 9, 10);
                yield return new airquality("44", "236", 14.9, 81, 9, 11);
                yield return new airquality("21", "259", 15.5, 76, 9, 12);
                yield return new airquality("28", "238", 6.3, 77, 9, 13);
                yield return new airquality("9", "24", 10.9, 71, 9, 14);
                yield return new airquality("13", "112", 11.5, 71, 9, 15);
                yield return new airquality("46", "237", 6.9, 78, 9, 16);
                yield return new airquality("18", "224", 13.8, 67, 9, 17);
                yield return new airquality("13", "27", 10.3, 76, 9, 18);
                yield return new airquality("24", "238", 10.3, 68, 9, 19);
                yield return new airquality("16", "201", 8, 82, 9, 20);
                yield return new airquality("13", "238", 12.6, 64, 9, 21);
                yield return new airquality("23", "14", 9.2, 71, 9, 22);
                yield return new airquality("36", "139", 10.3, 81, 9, 23);
                yield return new airquality("7", "49", 10.3, 69, 9, 24);
                yield return new airquality("14", "20", 16.6, 63, 9, 25);
                yield return new airquality("30", "193", 6.9, 70, 9, 26);
                yield return new airquality(null, "145", 13.2, 77, 9, 27);
                yield return new airquality("14", "191", 14.3, 75, 9, 28);
                yield return new airquality("18", "131", 8, 76, 9, 29);
                yield return new airquality("20", "223", 11.5, 68, 9, 30);
            }
        }
    }
}
