// ReSharper disable All

namespace Rdatasets.Stat2Data
{
    using System.Collections.Generic;

    /// <summary>
    /// Leukemia
    /// </summary>

    public class Leukemia
    {
        public readonly int κ;
        public readonly int Age;
        public readonly int Smear;
        public readonly int Infil;
        public readonly int Index;
        public readonly double Blasts;
        public readonly int Temp;
        public readonly int Resp;
        public readonly int Time;
        public readonly int Status;

        public Leukemia(int κ, int Age, int Smear, int Infil, int Index, double Blasts, int Temp, int Resp, int Time, int Status)
        {
            this.κ = κ;
            this.Age = Age;
            this.Smear = Smear;
            this.Infil = Infil;
            this.Index = Index;
            this.Blasts = Blasts;
            this.Temp = Temp;
            this.Resp = Resp;
            this.Time = Time;
            this.Status = Status;
        }

        public static IEnumerable<Leukemia> Data
        {
            get
            {
                yield return new Leukemia(1, 20, 78, 39, 7, 0.6, 990, 1, 18, 0);
                yield return new Leukemia(2, 25, 64, 61, 16, 35, 1030, 1, 31, 1);
                yield return new Leukemia(3, 26, 61, 55, 12, 7.5, 982, 1, 31, 0);
                yield return new Leukemia(4, 26, 64, 64, 16, 21, 1000, 1, 31, 0);
                yield return new Leukemia(5, 27, 95, 95, 6, 7.5, 980, 1, 36, 0);
                yield return new Leukemia(6, 27, 80, 64, 8, 0.6, 1010, 0, 1, 0);
                yield return new Leukemia(7, 28, 88, 88, 20, 4.8, 986, 1, 9, 0);
                yield return new Leukemia(8, 28, 70, 70, 14, 10, 1010, 1, 39, 1);
                yield return new Leukemia(9, 31, 72, 72, 5, 2.3, 988, 1, 20, 1);
                yield return new Leukemia(10, 33, 58, 58, 7, 5.7, 986, 0, 4, 0);
                yield return new Leukemia(11, 33, 92, 92, 5, 2.6, 980, 1, 45, 1);
                yield return new Leukemia(12, 33, 42, 38, 12, 2.5, 984, 1, 36, 0);
                yield return new Leukemia(13, 34, 26, 26, 7, 7, 982, 0, 12, 0);
                yield return new Leukemia(14, 36, 55, 55, 14, 4.5, 986, 1, 8, 0);
                yield return new Leukemia(15, 37, 71, 71, 15, 4.4, 1020, 0, 1, 0);
                yield return new Leukemia(16, 40, 91, 91, 9, 35, 986, 1, 15, 0);
                yield return new Leukemia(17, 40, 52, 49, 12, 2.1, 988, 1, 24, 0);
                yield return new Leukemia(18, 43, 74, 63, 4, 0.1, 986, 0, 2, 0);
                yield return new Leukemia(19, 45, 78, 47, 14, 4.2, 980, 1, 33, 0);
                yield return new Leukemia(20, 45, 60, 36, 10, 0.6, 992, 1, 29, 1);
                yield return new Leukemia(21, 45, 82, 32, 10, 28.1, 1016, 0, 7, 0);
                yield return new Leukemia(22, 45, 79, 79, 4, 1.1, 1030, 0, 0, 0);
                yield return new Leukemia(23, 47, 56, 28, 2, 0.9, 990, 0, 1, 0);
                yield return new Leukemia(24, 48, 60, 54, 10, 2.2, 1002, 0, 2, 0);
                yield return new Leukemia(25, 50, 83, 66, 19, 11.6, 996, 1, 12, 0);
                yield return new Leukemia(26, 50, 36, 32, 14, 4.5, 992, 1, 9, 0);
                yield return new Leukemia(27, 51, 88, 70, 8, 0.5, 982, 0, 1, 0);
                yield return new Leukemia(28, 52, 87, 87, 7, 10.3, 986, 0, 1, 0);
                yield return new Leukemia(29, 53, 75, 68, 13, 2.3, 980, 1, 9, 0);
                yield return new Leukemia(30, 53, 65, 65, 6, 2.3, 982, 0, 5, 0);
                yield return new Leukemia(31, 56, 97, 92, 10, 16, 992, 1, 27, 1);
                yield return new Leukemia(32, 57, 87, 83, 19, 21.6, 1020, 0, 1, 0);
                yield return new Leukemia(33, 59, 45, 45, 8, 1.1, 999, 0, 13, 0);
                yield return new Leukemia(34, 59, 36, 34, 5, 0, 1038, 0, 1, 0);
                yield return new Leukemia(35, 60, 39, 33, 7, 0.9, 988, 0, 5, 0);
                yield return new Leukemia(36, 60, 76, 53, 12, 0.4, 982, 0, 1, 0);
                yield return new Leukemia(37, 61, 46, 37, 4, 1.4, 1006, 0, 3, 0);
                yield return new Leukemia(38, 61, 39, 8, 8, 0.3, 990, 0, 4, 0);
                yield return new Leukemia(39, 61, 90, 90, 1, 9.9, 990, 0, 1, 0);
                yield return new Leukemia(40, 62, 84, 84, 19, 115, 1020, 1, 18, 0);
                yield return new Leukemia(41, 63, 42, 27, 5, 0.3, 1014, 0, 1, 0);
                yield return new Leukemia(42, 65, 75, 75, 10, 20, 1004, 0, 2, 0);
                yield return new Leukemia(43, 71, 44, 22, 6, 0.3, 990, 0, 1, 0);
                yield return new Leukemia(44, 71, 63, 63, 11, 10, 986, 1, 8, 0);
                yield return new Leukemia(45, 73, 33, 33, 4, 0.5, 1010, 0, 3, 0);
                yield return new Leukemia(46, 73, 93, 84, 6, 38, 1020, 0, 4, 0);
                yield return new Leukemia(47, 74, 58, 58, 10, 2.4, 1002, 1, 14, 0);
                yield return new Leukemia(48, 74, 32, 30, 16, 6.7, 988, 0, 3, 0);
                yield return new Leukemia(49, 75, 60, 60, 17, 8.2, 990, 1, 13, 0);
                yield return new Leukemia(50, 77, 69, 69, 9, 1.5, 986, 1, 13, 0);
                yield return new Leukemia(51, 80, 73, 73, 7, 1.5, 986, 0, 1, 0);
            }
        }
    }
}
