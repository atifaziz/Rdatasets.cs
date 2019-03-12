// ReSharper disable All

namespace Rdatasets.drc
{
    using System.Collections.Generic;

    /// <summary>
    /// Performance of decontaminants used in the culturing of a micro-organism
    /// </summary>

    public class decontaminants
    {
        public readonly int κ;
        public readonly double conc;
        public readonly int count;
        public readonly string group;

        public decontaminants(int κ, double conc, int count, string group)
        {
            this.κ = κ;
            this.conc = conc;
            this.count = count;
            this.group = group;
        }

        public static IEnumerable<decontaminants> Data
        {
            get
            {
                yield return new decontaminants(1, 0.75, 2, "hpc");
                yield return new decontaminants(2, 0.75, 4, "hpc");
                yield return new decontaminants(3, 0.75, 8, "hpc");
                yield return new decontaminants(4, 0.75, 9, "hpc");
                yield return new decontaminants(5, 0.75, 10, "hpc");
                yield return new decontaminants(6, 0.75, 1, "hpc");
                yield return new decontaminants(7, 0.75, 0, "hpc");
                yield return new decontaminants(8, 0.75, 5, "hpc");
                yield return new decontaminants(9, 0.75, 14, "hpc");
                yield return new decontaminants(10, 0.75, 7, "hpc");
                yield return new decontaminants(11, 0.375, 11, "hpc");
                yield return new decontaminants(12, 0.375, 12, "hpc");
                yield return new decontaminants(13, 0.375, 13, "hpc");
                yield return new decontaminants(14, 0.375, 12, "hpc");
                yield return new decontaminants(15, 0.375, 11, "hpc");
                yield return new decontaminants(16, 0.375, 13, "hpc");
                yield return new decontaminants(17, 0.375, 17, "hpc");
                yield return new decontaminants(18, 0.375, 16, "hpc");
                yield return new decontaminants(19, 0.375, 21, "hpc");
                yield return new decontaminants(20, 0.375, 2, "hpc");
                yield return new decontaminants(21, 0.1875, 16, "hpc");
                yield return new decontaminants(22, 0.1875, 6, "hpc");
                yield return new decontaminants(23, 0.1875, 20, "hpc");
                yield return new decontaminants(24, 0.1875, 23, "hpc");
                yield return new decontaminants(25, 0.1875, 23, "hpc");
                yield return new decontaminants(26, 0.1875, 39, "hpc");
                yield return new decontaminants(27, 0.1875, 18, "hpc");
                yield return new decontaminants(28, 0.1875, 23, "hpc");
                yield return new decontaminants(29, 0.1875, 33, "hpc");
                yield return new decontaminants(30, 0.1875, 21, "hpc");
                yield return new decontaminants(31, 0.09375, 33, "hpc");
                yield return new decontaminants(32, 0.09375, 46, "hpc");
                yield return new decontaminants(33, 0.09375, 42, "hpc");
                yield return new decontaminants(34, 0.09375, 18, "hpc");
                yield return new decontaminants(35, 0.09375, 35, "hpc");
                yield return new decontaminants(36, 0.09375, 20, "hpc");
                yield return new decontaminants(37, 0.09375, 19, "hpc");
                yield return new decontaminants(38, 0.09375, 29, "hpc");
                yield return new decontaminants(39, 0.09375, 41, "hpc");
                yield return new decontaminants(40, 0.09375, 36, "hpc");
                yield return new decontaminants(41, 0.075, 30, "hpc");
                yield return new decontaminants(42, 0.075, 30, "hpc");
                yield return new decontaminants(43, 0.075, 27, "hpc");
                yield return new decontaminants(44, 0.075, 53, "hpc");
                yield return new decontaminants(45, 0.075, 51, "hpc");
                yield return new decontaminants(46, 0.075, 39, "hpc");
                yield return new decontaminants(47, 0.075, 31, "hpc");
                yield return new decontaminants(48, 0.075, 36, "hpc");
                yield return new decontaminants(49, 0.075, 38, "hpc");
                yield return new decontaminants(50, 0.075, 22, "hpc");
                yield return new decontaminants(51, 0.0075, 53, "hpc");
                yield return new decontaminants(52, 0.0075, 62, "hpc");
                yield return new decontaminants(53, 0.0075, 38, "hpc");
                yield return new decontaminants(54, 0.0075, 54, "hpc");
                yield return new decontaminants(55, 0.0075, 54, "hpc");
                yield return new decontaminants(56, 0.0075, 38, "hpc");
                yield return new decontaminants(57, 0.0075, 46, "hpc");
                yield return new decontaminants(58, 0.0075, 58, "hpc");
                yield return new decontaminants(59, 0.0075, 54, "hpc");
                yield return new decontaminants(60, 0.0075, 57, "hpc");
                yield return new decontaminants(61, 0.00075, 42, "hpc");
                yield return new decontaminants(62, 0.00075, 45, "hpc");
                yield return new decontaminants(63, 0.00075, 49, "hpc");
                yield return new decontaminants(64, 0.00075, 32, "hpc");
                yield return new decontaminants(65, 0.00075, 39, "hpc");
                yield return new decontaminants(66, 0.00075, 40, "hpc");
                yield return new decontaminants(67, 0.00075, 34, "hpc");
                yield return new decontaminants(68, 0.00075, 45, "hpc");
                yield return new decontaminants(69, 0.00075, 51, "hpc");
                yield return new decontaminants(70, 5, 14, "oxalic");
                yield return new decontaminants(71, 5, 15, "oxalic");
                yield return new decontaminants(72, 5, 6, "oxalic");
                yield return new decontaminants(73, 5, 13, "oxalic");
                yield return new decontaminants(74, 5, 4, "oxalic");
                yield return new decontaminants(75, 5, 1, "oxalic");
                yield return new decontaminants(76, 5, 9, "oxalic");
                yield return new decontaminants(77, 5, 6, "oxalic");
                yield return new decontaminants(78, 5, 12, "oxalic");
                yield return new decontaminants(79, 5, 13, "oxalic");
                yield return new decontaminants(80, 0.5, 27, "oxalic");
                yield return new decontaminants(81, 0.5, 33, "oxalic");
                yield return new decontaminants(82, 0.5, 31, "oxalic");
                yield return new decontaminants(83, 0.5, 30, "oxalic");
                yield return new decontaminants(84, 0.5, 26, "oxalic");
                yield return new decontaminants(85, 0.5, 41, "oxalic");
                yield return new decontaminants(86, 0.5, 33, "oxalic");
                yield return new decontaminants(87, 0.5, 40, "oxalic");
                yield return new decontaminants(88, 0.5, 31, "oxalic");
                yield return new decontaminants(89, 0.5, 20, "oxalic");
                yield return new decontaminants(90, 0.05, 33, "oxalic");
                yield return new decontaminants(91, 0.05, 26, "oxalic");
                yield return new decontaminants(92, 0.05, 32, "oxalic");
                yield return new decontaminants(93, 0.05, 24, "oxalic");
                yield return new decontaminants(94, 0.05, 30, "oxalic");
                yield return new decontaminants(95, 0.05, 52, "oxalic");
                yield return new decontaminants(96, 0.05, 28, "oxalic");
                yield return new decontaminants(97, 0.05, 28, "oxalic");
                yield return new decontaminants(98, 0.05, 26, "oxalic");
                yield return new decontaminants(99, 0.05, 22, "oxalic");
                yield return new decontaminants(100, 0.005, 36, "oxalic");
                yield return new decontaminants(101, 0.005, 54, "oxalic");
                yield return new decontaminants(102, 0.005, 31, "oxalic");
                yield return new decontaminants(103, 0.005, 37, "oxalic");
                yield return new decontaminants(104, 0.005, 50, "oxalic");
                yield return new decontaminants(105, 0.005, 73, "oxalic");
                yield return new decontaminants(106, 0.005, 44, "oxalic");
                yield return new decontaminants(107, 0.005, 50, "oxalic");
                yield return new decontaminants(108, 0.005, 37, "oxalic");
                yield return new decontaminants(109, 0, 52, "oxalic");
                yield return new decontaminants(110, 0, 80, "oxalic");
                yield return new decontaminants(111, 0, 55, "oxalic");
                yield return new decontaminants(112, 0, 50, "oxalic");
                yield return new decontaminants(113, 0, 58, "oxalic");
                yield return new decontaminants(114, 0, 50, "oxalic");
                yield return new decontaminants(115, 0, 43, "oxalic");
                yield return new decontaminants(116, 0, 50, "oxalic");
                yield return new decontaminants(117, 0, 53, "oxalic");
                yield return new decontaminants(118, 0, 54, "oxalic");
                yield return new decontaminants(119, 0, 44, "oxalic");
                yield return new decontaminants(120, 0, 51, "oxalic");
                yield return new decontaminants(121, 0, 34, "oxalic");
                yield return new decontaminants(122, 0, 37, "oxalic");
                yield return new decontaminants(123, 0, 46, "oxalic");
                yield return new decontaminants(124, 0, 56, "oxalic");
                yield return new decontaminants(125, 0, 64, "oxalic");
                yield return new decontaminants(126, 0, 51, "oxalic");
                yield return new decontaminants(127, 0, 67, "oxalic");
                yield return new decontaminants(128, 0, 40, "oxalic");
            }
        }
    }
}
