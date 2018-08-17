// ReSharper disable All

namespace Rdatasets.Stat2Data
{
    using System.Collections.Generic;

    /// <summary>
    /// ArcheryData
    /// </summary>

    public class ArcheryData
    {
        public readonly int Attendance;
        public readonly double Average;
        public readonly string Sex;
        public readonly int Day1;
        public readonly int LastDay;
        public readonly int Improvement;
        public readonly int Improve;

        public ArcheryData(int Attendance, double Average, string Sex, int Day1, int LastDay, int Improvement, int Improve)
        {
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
                yield return new ArcheryData(21, 229.619, "m", 195, 226, 31, 1);
                yield return new ArcheryData(20, 188.9, "m", 140, 251, 111, 1);
                yield return new ArcheryData(20, 91.65, "f", 51, 142, 91, 1);
                yield return new ArcheryData(22, 188.227, "m", 133, 255, 122, 1);
                yield return new ArcheryData(21, 162.048, "m", 151, 182, 31, 1);
                yield return new ArcheryData(21, 169.952, "m", 201, 253, 52, 1);
                yield return new ArcheryData(21, 95.381, "m", 42, 184, 142, 1);
                yield return new ArcheryData(22, 116.5, "f", 62, 85, 23, 1);
                yield return new ArcheryData(19, 188.368, "m", 174, 191, 17, 1);
                yield return new ArcheryData(22, 122.727, "f", 56, 168, 112, 1);
                yield return new ArcheryData(22, 123.818, "f", 86, 173, 87, 1);
                yield return new ArcheryData(20, 97.5, "f", 86, 131, 45, 1);
                yield return new ArcheryData(22, 95.5, "f", 109, 99, -10, 0);
                yield return new ArcheryData(21, 165.143, "m", 141, 183, 42, 1);
                yield return new ArcheryData(21, 193.762, "m", 174, 173, -1, 0);
                yield return new ArcheryData(20, 98.4, "f", 51, 49, -2, 0);
                yield return new ArcheryData(16, 158.625, "m", 164, 232, 68, 1);
                yield return new ArcheryData(22, 66.818, "f", 16, 78, 62, 1);
            }
        }
    }
}
