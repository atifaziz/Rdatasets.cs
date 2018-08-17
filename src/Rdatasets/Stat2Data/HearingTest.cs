// ReSharper disable All

namespace Rdatasets.Stat2Data
{
    using System.Collections.Generic;

    /// <summary>
    /// HearingTest
    /// </summary>

    public class HearingTest
    {
        public readonly int Subj;
        public readonly string List;
        public readonly int Percent;

        public HearingTest(int Subj, string List, int Percent)
        {
            this.Subj = Subj;
            this.List = List;
            this.Percent = Percent;
        }

        public static IEnumerable<HearingTest> Data
        {
            get
            {
                yield return new HearingTest(1, "L1", 28);
                yield return new HearingTest(2, "L1", 24);
                yield return new HearingTest(3, "L1", 32);
                yield return new HearingTest(4, "L1", 30);
                yield return new HearingTest(5, "L1", 34);
                yield return new HearingTest(6, "L1", 30);
                yield return new HearingTest(7, "L1", 36);
                yield return new HearingTest(8, "L1", 32);
                yield return new HearingTest(9, "L1", 48);
                yield return new HearingTest(10, "L1", 32);
                yield return new HearingTest(11, "L1", 32);
                yield return new HearingTest(12, "L1", 38);
                yield return new HearingTest(13, "L1", 32);
                yield return new HearingTest(14, "L1", 40);
                yield return new HearingTest(15, "L1", 28);
                yield return new HearingTest(16, "L1", 48);
                yield return new HearingTest(17, "L1", 34);
                yield return new HearingTest(18, "L1", 28);
                yield return new HearingTest(19, "L1", 40);
                yield return new HearingTest(20, "L1", 18);
                yield return new HearingTest(21, "L1", 20);
                yield return new HearingTest(22, "L1", 26);
                yield return new HearingTest(23, "L1", 36);
                yield return new HearingTest(24, "L1", 40);
                yield return new HearingTest(1, "L2", 20);
                yield return new HearingTest(2, "L2", 16);
                yield return new HearingTest(3, "L2", 38);
                yield return new HearingTest(4, "L2", 20);
                yield return new HearingTest(5, "L2", 34);
                yield return new HearingTest(6, "L2", 30);
                yield return new HearingTest(7, "L2", 30);
                yield return new HearingTest(8, "L2", 28);
                yield return new HearingTest(9, "L2", 42);
                yield return new HearingTest(10, "L2", 36);
                yield return new HearingTest(11, "L2", 32);
                yield return new HearingTest(12, "L2", 36);
                yield return new HearingTest(13, "L2", 28);
                yield return new HearingTest(14, "L2", 38);
                yield return new HearingTest(15, "L2", 36);
                yield return new HearingTest(16, "L2", 28);
                yield return new HearingTest(17, "L2", 34);
                yield return new HearingTest(18, "L2", 16);
                yield return new HearingTest(19, "L2", 34);
                yield return new HearingTest(20, "L2", 22);
                yield return new HearingTest(21, "L2", 20);
                yield return new HearingTest(22, "L2", 30);
                yield return new HearingTest(23, "L2", 20);
                yield return new HearingTest(24, "L2", 44);
                yield return new HearingTest(1, "L3", 24);
                yield return new HearingTest(2, "L3", 32);
                yield return new HearingTest(3, "L3", 20);
                yield return new HearingTest(4, "L3", 14);
                yield return new HearingTest(5, "L3", 32);
                yield return new HearingTest(6, "L3", 22);
                yield return new HearingTest(7, "L3", 20);
                yield return new HearingTest(8, "L3", 26);
                yield return new HearingTest(9, "L3", 26);
                yield return new HearingTest(10, "L3", 38);
                yield return new HearingTest(11, "L3", 30);
                yield return new HearingTest(12, "L3", 16);
                yield return new HearingTest(13, "L3", 36);
                yield return new HearingTest(14, "L3", 32);
                yield return new HearingTest(15, "L3", 38);
                yield return new HearingTest(16, "L3", 14);
                yield return new HearingTest(17, "L3", 26);
                yield return new HearingTest(18, "L3", 14);
                yield return new HearingTest(19, "L3", 38);
                yield return new HearingTest(20, "L3", 20);
                yield return new HearingTest(21, "L3", 14);
                yield return new HearingTest(22, "L3", 18);
                yield return new HearingTest(23, "L3", 22);
                yield return new HearingTest(24, "L3", 34);
                yield return new HearingTest(1, "L4", 26);
                yield return new HearingTest(2, "L4", 24);
                yield return new HearingTest(3, "L4", 22);
                yield return new HearingTest(4, "L4", 18);
                yield return new HearingTest(5, "L4", 24);
                yield return new HearingTest(6, "L4", 30);
                yield return new HearingTest(7, "L4", 22);
                yield return new HearingTest(8, "L4", 28);
                yield return new HearingTest(9, "L4", 30);
                yield return new HearingTest(10, "L4", 16);
                yield return new HearingTest(11, "L4", 18);
                yield return new HearingTest(12, "L4", 34);
                yield return new HearingTest(13, "L4", 32);
                yield return new HearingTest(14, "L4", 34);
                yield return new HearingTest(15, "L4", 32);
                yield return new HearingTest(16, "L4", 18);
                yield return new HearingTest(17, "L4", 20);
                yield return new HearingTest(18, "L4", 20);
                yield return new HearingTest(19, "L4", 40);
                yield return new HearingTest(20, "L4", 26);
                yield return new HearingTest(21, "L4", 14);
                yield return new HearingTest(22, "L4", 14);
                yield return new HearingTest(23, "L4", 30);
                yield return new HearingTest(24, "L4", 42);
            }
        }
    }
}
