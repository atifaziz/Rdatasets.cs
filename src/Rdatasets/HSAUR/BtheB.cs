// ReSharper disable All

namespace Rdatasets.HSAUR
{
    using System.Collections.Generic;

    /// <summary>
    /// Beat the Blues Data
    /// </summary>

    public class BtheB
    {
        public readonly string drug;
        public readonly string length;
        public readonly string treatment;
        public readonly int bdi_pre;
        public readonly string bdi_2m;
        public readonly string bdi_4m;
        public readonly string bdi_6m;
        public readonly string bdi_8m;

        public BtheB(string drug, string length, string treatment, int bdi_pre, string bdi_2m, string bdi_4m, string bdi_6m, string bdi_8m)
        {
            this.drug = drug;
            this.length = length;
            this.treatment = treatment;
            this.bdi_pre = bdi_pre;
            this.bdi_2m = bdi_2m;
            this.bdi_4m = bdi_4m;
            this.bdi_6m = bdi_6m;
            this.bdi_8m = bdi_8m;
        }

        public static IEnumerable<BtheB> Data
        {
            get
            {
                yield return new BtheB("No", ">6m", "TAU", 29, "2", "2", null, null);
                yield return new BtheB("Yes", ">6m", "BtheB", 32, "16", "24", "17", "20");
                yield return new BtheB("Yes", "<6m", "TAU", 25, "20", null, null, null);
                yield return new BtheB("No", ">6m", "BtheB", 21, "17", "16", "10", "9");
                yield return new BtheB("Yes", ">6m", "BtheB", 26, "23", null, null, null);
                yield return new BtheB("Yes", "<6m", "BtheB", 7, "0", "0", "0", "0");
                yield return new BtheB("Yes", "<6m", "TAU", 17, "7", "7", "3", "7");
                yield return new BtheB("No", ">6m", "TAU", 20, "20", "21", "19", "13");
                yield return new BtheB("Yes", "<6m", "BtheB", 18, "13", "14", "20", "11");
                yield return new BtheB("Yes", ">6m", "BtheB", 20, "5", "5", "8", "12");
                yield return new BtheB("No", ">6m", "TAU", 30, "32", "24", "12", "2");
                yield return new BtheB("Yes", "<6m", "BtheB", 49, "35", null, null, null);
                yield return new BtheB("No", ">6m", "TAU", 26, "27", "23", null, null);
                yield return new BtheB("Yes", ">6m", "TAU", 30, "26", "36", "27", "22");
                yield return new BtheB("Yes", ">6m", "BtheB", 23, "13", "13", "12", "23");
                yield return new BtheB("No", "<6m", "TAU", 16, "13", "3", "2", "0");
                yield return new BtheB("No", ">6m", "BtheB", 30, "30", "29", null, null);
                yield return new BtheB("No", "<6m", "BtheB", 13, "8", "8", "7", "6");
                yield return new BtheB("No", ">6m", "TAU", 37, "30", "33", "31", "22");
                yield return new BtheB("Yes", "<6m", "BtheB", 35, "12", "10", "8", "10");
                yield return new BtheB("No", ">6m", "BtheB", 21, "6", null, null, null);
                yield return new BtheB("No", "<6m", "TAU", 26, "17", "17", "20", "12");
                yield return new BtheB("No", ">6m", "TAU", 29, "22", "10", null, null);
                yield return new BtheB("No", ">6m", "TAU", 20, "21", null, null, null);
                yield return new BtheB("No", ">6m", "TAU", 33, "23", null, null, null);
                yield return new BtheB("No", ">6m", "BtheB", 19, "12", "13", null, null);
                yield return new BtheB("Yes", "<6m", "TAU", 12, "15", null, null, null);
                yield return new BtheB("Yes", ">6m", "TAU", 47, "36", "49", "34", null);
                yield return new BtheB("Yes", ">6m", "BtheB", 36, "6", "0", "0", "2");
                yield return new BtheB("No", "<6m", "BtheB", 10, "8", "6", "3", "3");
                yield return new BtheB("No", "<6m", "TAU", 27, "7", "15", "16", "0");
                yield return new BtheB("No", "<6m", "BtheB", 18, "10", "10", "6", "8");
                yield return new BtheB("Yes", "<6m", "BtheB", 11, "8", "3", "2", "15");
                yield return new BtheB("Yes", "<6m", "BtheB", 6, "7", null, null, null);
                yield return new BtheB("Yes", ">6m", "BtheB", 44, "24", "20", "29", "14");
                yield return new BtheB("No", "<6m", "TAU", 38, "38", null, null, null);
                yield return new BtheB("No", "<6m", "TAU", 21, "14", "20", "1", "8");
                yield return new BtheB("Yes", ">6m", "TAU", 34, "17", "8", "9", "13");
                yield return new BtheB("Yes", "<6m", "BtheB", 9, "7", "1", null, null);
                yield return new BtheB("Yes", ">6m", "TAU", 38, "27", "19", "20", "30");
                yield return new BtheB("Yes", "<6m", "BtheB", 46, "40", null, null, null);
                yield return new BtheB("No", "<6m", "TAU", 20, "19", "18", "19", "18");
                yield return new BtheB("Yes", ">6m", "TAU", 17, "29", "2", "0", "0");
                yield return new BtheB("No", ">6m", "BtheB", 18, "20", null, null, null);
                yield return new BtheB("Yes", ">6m", "BtheB", 42, "1", "8", "10", "6");
                yield return new BtheB("No", "<6m", "BtheB", 30, "30", null, null, null);
                yield return new BtheB("Yes", "<6m", "BtheB", 33, "27", "16", "30", "15");
                yield return new BtheB("No", "<6m", "BtheB", 12, "1", "0", "0", null);
                yield return new BtheB("Yes", "<6m", "BtheB", 2, "5", null, null, null);
                yield return new BtheB("No", ">6m", "TAU", 36, "42", "49", "47", "40");
                yield return new BtheB("No", "<6m", "TAU", 35, "30", null, null, null);
                yield return new BtheB("No", "<6m", "BtheB", 23, "20", null, null, null);
                yield return new BtheB("No", ">6m", "TAU", 31, "48", "38", "38", "37");
                yield return new BtheB("Yes", "<6m", "BtheB", 8, "5", "7", null, null);
                yield return new BtheB("Yes", "<6m", "TAU", 23, "21", "26", null, null);
                yield return new BtheB("Yes", "<6m", "BtheB", 7, "7", "5", "4", "0");
                yield return new BtheB("No", "<6m", "TAU", 14, "13", "14", null, null);
                yield return new BtheB("No", "<6m", "TAU", 40, "36", "33", null, null);
                yield return new BtheB("Yes", "<6m", "BtheB", 23, "30", null, null, null);
                yield return new BtheB("No", ">6m", "BtheB", 14, "3", null, null, null);
                yield return new BtheB("No", ">6m", "TAU", 22, "20", "16", "24", "16");
                yield return new BtheB("No", ">6m", "TAU", 23, "23", "15", "25", "17");
                yield return new BtheB("No", "<6m", "TAU", 15, "7", "13", "13", null);
                yield return new BtheB("No", ">6m", "TAU", 8, "12", "11", "26", null);
                yield return new BtheB("No", ">6m", "BtheB", 12, "18", null, null, null);
                yield return new BtheB("No", ">6m", "TAU", 7, "6", "2", "1", null);
                yield return new BtheB("Yes", "<6m", "TAU", 17, "9", "3", "1", "0");
                yield return new BtheB("Yes", "<6m", "BtheB", 33, "18", "16", null, null);
                yield return new BtheB("No", "<6m", "TAU", 27, "20", null, null, null);
                yield return new BtheB("No", "<6m", "BtheB", 27, "30", null, null, null);
                yield return new BtheB("No", "<6m", "BtheB", 9, "6", "10", "1", "0");
                yield return new BtheB("No", ">6m", "BtheB", 40, "30", "12", null, null);
                yield return new BtheB("No", ">6m", "TAU", 11, "8", "7", null, null);
                yield return new BtheB("No", "<6m", "TAU", 9, "8", null, null, null);
                yield return new BtheB("No", ">6m", "TAU", 14, "22", "21", "24", "19");
                yield return new BtheB("Yes", ">6m", "BtheB", 28, "9", "20", "18", "13");
                yield return new BtheB("No", ">6m", "BtheB", 15, "9", "13", "14", "10");
                yield return new BtheB("Yes", ">6m", "BtheB", 22, "10", "5", "5", "12");
                yield return new BtheB("No", "<6m", "TAU", 23, "9", null, null, null);
                yield return new BtheB("No", ">6m", "TAU", 21, "22", "24", "23", "22");
                yield return new BtheB("No", ">6m", "TAU", 27, "31", "28", "22", "14");
                yield return new BtheB("Yes", ">6m", "BtheB", 14, "15", null, null, null);
                yield return new BtheB("No", ">6m", "TAU", 10, "13", "12", "8", "20");
                yield return new BtheB("Yes", "<6m", "TAU", 21, "9", "6", "7", "1");
                yield return new BtheB("Yes", ">6m", "BtheB", 46, "36", "53", null, null);
                yield return new BtheB("No", ">6m", "BtheB", 36, "14", "7", "15", "15");
                yield return new BtheB("Yes", ">6m", "BtheB", 23, "17", null, null, null);
                yield return new BtheB("Yes", ">6m", "TAU", 35, "0", "6", "0", "1");
                yield return new BtheB("Yes", "<6m", "BtheB", 33, "13", "13", "10", "8");
                yield return new BtheB("No", "<6m", "BtheB", 19, "4", "27", "1", "2");
                yield return new BtheB("No", "<6m", "TAU", 16, null, null, null, null);
                yield return new BtheB("Yes", "<6m", "BtheB", 30, "26", "28", null, null);
                yield return new BtheB("Yes", "<6m", "BtheB", 17, "8", "7", "12", null);
                yield return new BtheB("No", ">6m", "BtheB", 19, "4", "3", "3", "3");
                yield return new BtheB("No", ">6m", "BtheB", 16, "11", "4", "2", "3");
                yield return new BtheB("Yes", ">6m", "BtheB", 16, "16", "10", "10", "8");
                yield return new BtheB("Yes", "<6m", "TAU", 28, null, null, null, null);
                yield return new BtheB("No", ">6m", "BtheB", 11, "22", "9", "11", "11");
                yield return new BtheB("No", "<6m", "TAU", 13, "5", "5", "0", "6");
                yield return new BtheB("Yes", "<6m", "TAU", 43, null, null, null, null);
            }
        }
    }
}
