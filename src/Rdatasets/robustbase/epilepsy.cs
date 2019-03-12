// ReSharper disable All

namespace Rdatasets.robustbase
{
    using System.Collections.Generic;

    /// <summary>
    /// Epilepsy Attacks Data Set
    /// </summary>

    public class epilepsy
    {
        public readonly int κ;
        public readonly int ID;
        public readonly int Y1;
        public readonly int Y2;
        public readonly int Y3;
        public readonly int Y4;
        public readonly int Base;
        public readonly int Age;
        public readonly string Trt;
        public readonly int Ysum;
        public readonly double Age10;
        public readonly double Base4;

        public epilepsy(int κ, int ID, int Y1, int Y2, int Y3, int Y4, int Base, int Age, string Trt, int Ysum, double Age10, double Base4)
        {
            this.κ = κ;
            this.ID = ID;
            this.Y1 = Y1;
            this.Y2 = Y2;
            this.Y3 = Y3;
            this.Y4 = Y4;
            this.Base = Base;
            this.Age = Age;
            this.Trt = Trt;
            this.Ysum = Ysum;
            this.Age10 = Age10;
            this.Base4 = Base4;
        }

        public static IEnumerable<epilepsy> Data
        {
            get
            {
                yield return new epilepsy(1, 104, 5, 3, 3, 3, 11, 31, "placebo", 14, 3.1, 2.75);
                yield return new epilepsy(2, 106, 3, 5, 3, 3, 11, 30, "placebo", 14, 3, 2.75);
                yield return new epilepsy(3, 107, 2, 4, 0, 5, 6, 25, "placebo", 11, 2.5, 1.5);
                yield return new epilepsy(4, 114, 4, 4, 1, 4, 8, 36, "placebo", 13, 3.6, 2);
                yield return new epilepsy(5, 116, 7, 18, 9, 21, 66, 22, "placebo", 55, 2.2, 16.5);
                yield return new epilepsy(6, 118, 5, 2, 8, 7, 27, 29, "placebo", 22, 2.9, 6.75);
                yield return new epilepsy(7, 123, 6, 4, 0, 2, 12, 31, "placebo", 12, 3.1, 3);
                yield return new epilepsy(8, 126, 40, 20, 23, 12, 52, 42, "placebo", 95, 4.2, 13);
                yield return new epilepsy(9, 130, 5, 6, 6, 5, 23, 37, "placebo", 22, 3.7, 5.75);
                yield return new epilepsy(10, 135, 14, 13, 6, 0, 10, 28, "placebo", 33, 2.8, 2.5);
                yield return new epilepsy(11, 141, 26, 12, 6, 22, 52, 36, "placebo", 66, 3.6, 13);
                yield return new epilepsy(12, 145, 12, 6, 8, 4, 33, 24, "placebo", 30, 2.4, 8.25);
                yield return new epilepsy(13, 201, 4, 4, 6, 2, 18, 23, "placebo", 16, 2.3, 4.5);
                yield return new epilepsy(14, 202, 7, 9, 12, 14, 42, 36, "placebo", 42, 3.6, 10.5);
                yield return new epilepsy(15, 205, 16, 24, 10, 9, 87, 26, "placebo", 59, 2.6, 21.75);
                yield return new epilepsy(16, 206, 11, 0, 0, 5, 50, 26, "placebo", 16, 2.6, 12.5);
                yield return new epilepsy(17, 210, 0, 0, 3, 3, 18, 28, "placebo", 6, 2.8, 4.5);
                yield return new epilepsy(18, 213, 37, 29, 28, 29, 111, 31, "placebo", 123, 3.1, 27.75);
                yield return new epilepsy(19, 215, 3, 5, 2, 5, 18, 32, "placebo", 15, 3.2, 4.5);
                yield return new epilepsy(20, 217, 3, 0, 6, 7, 20, 21, "placebo", 16, 2.1, 5);
                yield return new epilepsy(21, 219, 3, 4, 3, 4, 12, 29, "placebo", 14, 2.9, 3);
                yield return new epilepsy(22, 220, 3, 4, 3, 4, 9, 21, "placebo", 14, 2.1, 2.25);
                yield return new epilepsy(23, 222, 2, 3, 3, 5, 17, 32, "placebo", 13, 3.2, 4.25);
                yield return new epilepsy(24, 226, 8, 12, 2, 8, 28, 25, "placebo", 30, 2.5, 7);
                yield return new epilepsy(25, 227, 18, 24, 76, 25, 55, 30, "placebo", 143, 3, 13.75);
                yield return new epilepsy(26, 230, 2, 1, 2, 1, 9, 40, "placebo", 6, 4, 2.25);
                yield return new epilepsy(27, 234, 3, 1, 4, 2, 10, 19, "placebo", 10, 1.9, 2.5);
                yield return new epilepsy(28, 238, 13, 15, 13, 12, 47, 22, "placebo", 53, 2.2, 11.75);
                yield return new epilepsy(29, 101, 11, 14, 9, 8, 76, 18, "progabide", 42, 1.8, 19);
                yield return new epilepsy(30, 102, 8, 7, 9, 4, 38, 32, "progabide", 28, 3.2, 9.5);
                yield return new epilepsy(31, 103, 0, 4, 3, 0, 19, 20, "progabide", 7, 2, 4.75);
                yield return new epilepsy(32, 108, 3, 6, 1, 3, 10, 30, "progabide", 13, 3, 2.5);
                yield return new epilepsy(33, 110, 2, 6, 7, 4, 19, 18, "progabide", 19, 1.8, 4.75);
                yield return new epilepsy(34, 111, 4, 3, 1, 3, 24, 24, "progabide", 11, 2.4, 6);
                yield return new epilepsy(35, 112, 22, 17, 19, 16, 31, 30, "progabide", 74, 3, 7.75);
                yield return new epilepsy(36, 113, 5, 4, 7, 4, 14, 35, "progabide", 20, 3.5, 3.5);
                yield return new epilepsy(37, 117, 2, 4, 0, 4, 11, 27, "progabide", 10, 2.7, 2.75);
                yield return new epilepsy(38, 121, 3, 7, 7, 7, 67, 20, "progabide", 24, 2, 16.75);
                yield return new epilepsy(39, 122, 4, 18, 2, 5, 41, 22, "progabide", 29, 2.2, 10.25);
                yield return new epilepsy(40, 124, 2, 1, 1, 0, 7, 28, "progabide", 4, 2.8, 1.75);
                yield return new epilepsy(41, 128, 0, 2, 4, 0, 22, 23, "progabide", 6, 2.3, 5.5);
                yield return new epilepsy(42, 129, 5, 4, 0, 3, 13, 40, "progabide", 12, 4, 3.25);
                yield return new epilepsy(43, 137, 11, 14, 25, 15, 46, 33, "progabide", 65, 3.3, 11.5);
                yield return new epilepsy(44, 139, 10, 5, 3, 8, 36, 21, "progabide", 26, 2.1, 9);
                yield return new epilepsy(45, 143, 19, 7, 6, 7, 38, 35, "progabide", 39, 3.5, 9.5);
                yield return new epilepsy(46, 147, 1, 1, 2, 3, 7, 25, "progabide", 7, 2.5, 1.75);
                yield return new epilepsy(47, 203, 6, 10, 8, 8, 36, 26, "progabide", 32, 2.6, 9);
                yield return new epilepsy(48, 204, 2, 1, 0, 0, 11, 25, "progabide", 3, 2.5, 2.75);
                yield return new epilepsy(49, 207, 102, 65, 72, 63, 151, 22, "progabide", 302, 2.2, 37.75);
                yield return new epilepsy(50, 208, 4, 3, 2, 4, 22, 32, "progabide", 13, 3.2, 5.5);
                yield return new epilepsy(51, 209, 8, 6, 5, 7, 41, 25, "progabide", 26, 2.5, 10.25);
                yield return new epilepsy(52, 211, 1, 3, 1, 5, 32, 35, "progabide", 10, 3.5, 8);
                yield return new epilepsy(53, 214, 18, 11, 28, 13, 56, 21, "progabide", 70, 2.1, 14);
                yield return new epilepsy(54, 218, 6, 3, 4, 0, 24, 41, "progabide", 13, 4.1, 6);
                yield return new epilepsy(55, 221, 3, 5, 4, 3, 16, 32, "progabide", 15, 3.2, 4);
                yield return new epilepsy(56, 225, 1, 23, 19, 8, 22, 26, "progabide", 51, 2.6, 5.5);
                yield return new epilepsy(57, 228, 2, 3, 0, 1, 25, 21, "progabide", 6, 2.1, 6.25);
                yield return new epilepsy(58, 232, 0, 0, 0, 0, 13, 36, "progabide", 0, 3.6, 3.25);
                yield return new epilepsy(59, 236, 1, 4, 3, 2, 12, 37, "progabide", 10, 3.7, 3);
            }
        }
    }
}
