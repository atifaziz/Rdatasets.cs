// ReSharper disable All

namespace Rdatasets.Stat2Data
{
    using System.Collections.Generic;

    /// <summary>
    /// HearingTest
    /// </summary>

    public class HearingTest
    {
        public readonly int κ;
        public readonly int Subj;
        public readonly string List;
        public readonly int Percent;

        public HearingTest(int κ, int Subj, string List, int Percent)
        {
            this.κ = κ;
            this.Subj = Subj;
            this.List = List;
            this.Percent = Percent;
        }

        public static IEnumerable<HearingTest> Data
        {
            get
            {
                yield return new HearingTest(1, 1, "L1", 28);
                yield return new HearingTest(2, 2, "L1", 24);
                yield return new HearingTest(3, 3, "L1", 32);
                yield return new HearingTest(4, 4, "L1", 30);
                yield return new HearingTest(5, 5, "L1", 34);
                yield return new HearingTest(6, 6, "L1", 30);
                yield return new HearingTest(7, 7, "L1", 36);
                yield return new HearingTest(8, 8, "L1", 32);
                yield return new HearingTest(9, 9, "L1", 48);
                yield return new HearingTest(10, 10, "L1", 32);
                yield return new HearingTest(11, 11, "L1", 32);
                yield return new HearingTest(12, 12, "L1", 38);
                yield return new HearingTest(13, 13, "L1", 32);
                yield return new HearingTest(14, 14, "L1", 40);
                yield return new HearingTest(15, 15, "L1", 28);
                yield return new HearingTest(16, 16, "L1", 48);
                yield return new HearingTest(17, 17, "L1", 34);
                yield return new HearingTest(18, 18, "L1", 28);
                yield return new HearingTest(19, 19, "L1", 40);
                yield return new HearingTest(20, 20, "L1", 18);
                yield return new HearingTest(21, 21, "L1", 20);
                yield return new HearingTest(22, 22, "L1", 26);
                yield return new HearingTest(23, 23, "L1", 36);
                yield return new HearingTest(24, 24, "L1", 40);
                yield return new HearingTest(25, 1, "L2", 20);
                yield return new HearingTest(26, 2, "L2", 16);
                yield return new HearingTest(27, 3, "L2", 38);
                yield return new HearingTest(28, 4, "L2", 20);
                yield return new HearingTest(29, 5, "L2", 34);
                yield return new HearingTest(30, 6, "L2", 30);
                yield return new HearingTest(31, 7, "L2", 30);
                yield return new HearingTest(32, 8, "L2", 28);
                yield return new HearingTest(33, 9, "L2", 42);
                yield return new HearingTest(34, 10, "L2", 36);
                yield return new HearingTest(35, 11, "L2", 32);
                yield return new HearingTest(36, 12, "L2", 36);
                yield return new HearingTest(37, 13, "L2", 28);
                yield return new HearingTest(38, 14, "L2", 38);
                yield return new HearingTest(39, 15, "L2", 36);
                yield return new HearingTest(40, 16, "L2", 28);
                yield return new HearingTest(41, 17, "L2", 34);
                yield return new HearingTest(42, 18, "L2", 16);
                yield return new HearingTest(43, 19, "L2", 34);
                yield return new HearingTest(44, 20, "L2", 22);
                yield return new HearingTest(45, 21, "L2", 20);
                yield return new HearingTest(46, 22, "L2", 30);
                yield return new HearingTest(47, 23, "L2", 20);
                yield return new HearingTest(48, 24, "L2", 44);
                yield return new HearingTest(49, 1, "L3", 24);
                yield return new HearingTest(50, 2, "L3", 32);
                yield return new HearingTest(51, 3, "L3", 20);
                yield return new HearingTest(52, 4, "L3", 14);
                yield return new HearingTest(53, 5, "L3", 32);
                yield return new HearingTest(54, 6, "L3", 22);
                yield return new HearingTest(55, 7, "L3", 20);
                yield return new HearingTest(56, 8, "L3", 26);
                yield return new HearingTest(57, 9, "L3", 26);
                yield return new HearingTest(58, 10, "L3", 38);
                yield return new HearingTest(59, 11, "L3", 30);
                yield return new HearingTest(60, 12, "L3", 16);
                yield return new HearingTest(61, 13, "L3", 36);
                yield return new HearingTest(62, 14, "L3", 32);
                yield return new HearingTest(63, 15, "L3", 38);
                yield return new HearingTest(64, 16, "L3", 14);
                yield return new HearingTest(65, 17, "L3", 26);
                yield return new HearingTest(66, 18, "L3", 14);
                yield return new HearingTest(67, 19, "L3", 38);
                yield return new HearingTest(68, 20, "L3", 20);
                yield return new HearingTest(69, 21, "L3", 14);
                yield return new HearingTest(70, 22, "L3", 18);
                yield return new HearingTest(71, 23, "L3", 22);
                yield return new HearingTest(72, 24, "L3", 34);
                yield return new HearingTest(73, 1, "L4", 26);
                yield return new HearingTest(74, 2, "L4", 24);
                yield return new HearingTest(75, 3, "L4", 22);
                yield return new HearingTest(76, 4, "L4", 18);
                yield return new HearingTest(77, 5, "L4", 24);
                yield return new HearingTest(78, 6, "L4", 30);
                yield return new HearingTest(79, 7, "L4", 22);
                yield return new HearingTest(80, 8, "L4", 28);
                yield return new HearingTest(81, 9, "L4", 30);
                yield return new HearingTest(82, 10, "L4", 16);
                yield return new HearingTest(83, 11, "L4", 18);
                yield return new HearingTest(84, 12, "L4", 34);
                yield return new HearingTest(85, 13, "L4", 32);
                yield return new HearingTest(86, 14, "L4", 34);
                yield return new HearingTest(87, 15, "L4", 32);
                yield return new HearingTest(88, 16, "L4", 18);
                yield return new HearingTest(89, 17, "L4", 20);
                yield return new HearingTest(90, 18, "L4", 20);
                yield return new HearingTest(91, 19, "L4", 40);
                yield return new HearingTest(92, 20, "L4", 26);
                yield return new HearingTest(93, 21, "L4", 14);
                yield return new HearingTest(94, 22, "L4", 14);
                yield return new HearingTest(95, 23, "L4", 30);
                yield return new HearingTest(96, 24, "L4", 42);
            }
        }
    }
}
