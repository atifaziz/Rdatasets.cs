// ReSharper disable All

namespace Rdatasets.Stat2Data
{
    using System.Collections.Generic;

    /// <summary>
    /// ArcheryData
    /// </summary>

    public class ArcheryData
    {
        public readonly int κ;
        public readonly int Attendance;
        public readonly double Average;
        public readonly string Sex;
        public readonly int Day1;
        public readonly int LastDay;
        public readonly int Improvement;
        public readonly int Improve;

        public ArcheryData(int κ, int Attendance, double Average, string Sex, int Day1, int LastDay, int Improvement, int Improve)
        {
            this.κ = κ;
            this.Attendance = Attendance;
            this.Average = Average;
            this.Sex = Sex;
            this.Day1 = Day1;
            this.LastDay = LastDay;
            this.Improvement = Improvement;
            this.Improve = Improve;
        }

        public static IEnumerable<ArcheryData> Data
        {
            get
            {
                yield return new ArcheryData(1, 21, 229.619, "m", 195, 226, 31, 1);
                yield return new ArcheryData(2, 20, 188.9, "m", 140, 251, 111, 1);
                yield return new ArcheryData(3, 20, 91.65, "f", 51, 142, 91, 1);
                yield return new ArcheryData(4, 22, 188.227, "m", 133, 255, 122, 1);
                yield return new ArcheryData(5, 21, 162.048, "m", 151, 182, 31, 1);
                yield return new ArcheryData(6, 21, 169.952, "m", 201, 253, 52, 1);
                yield return new ArcheryData(7, 21, 95.381, "m", 42, 184, 142, 1);
                yield return new ArcheryData(8, 22, 116.5, "f", 62, 85, 23, 1);
                yield return new ArcheryData(9, 19, 188.368, "m", 174, 191, 17, 1);
                yield return new ArcheryData(10, 22, 122.727, "f", 56, 168, 112, 1);
                yield return new ArcheryData(11, 22, 123.818, "f", 86, 173, 87, 1);
                yield return new ArcheryData(12, 20, 97.5, "f", 86, 131, 45, 1);
                yield return new ArcheryData(13, 22, 95.5, "f", 109, 99, -10, 0);
                yield return new ArcheryData(14, 21, 165.143, "m", 141, 183, 42, 1);
                yield return new ArcheryData(15, 21, 193.762, "m", 174, 173, -1, 0);
                yield return new ArcheryData(16, 20, 98.4, "f", 51, 49, -2, 0);
                yield return new ArcheryData(17, 16, 158.625, "m", 164, 232, 68, 1);
                yield return new ArcheryData(18, 22, 66.818, "f", 16, 78, 62, 1);
            }
        }
    }
}
