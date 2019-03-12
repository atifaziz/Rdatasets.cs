// ReSharper disable All

namespace Rdatasets.HSAUR
{
    using System.Collections.Generic;

    /// <summary>
    /// Beat the Blues Data
    /// </summary>

    public class BtheB
    {
        public readonly int κ;
        public readonly string drug;
        public readonly string length;
        public readonly string treatment;
        public readonly int bdi_pre;
        public readonly int? bdi_2m;
        public readonly int? bdi_4m;
        public readonly int? bdi_6m;
        public readonly int? bdi_8m;

        public BtheB(int κ, string drug, string length, string treatment, int bdi_pre, int? bdi_2m, int? bdi_4m, int? bdi_6m, int? bdi_8m)
        {
            this.κ = κ;
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
                yield return new BtheB(1, "No", ">6m", "TAU", 29, 2, 2, null, null);
                yield return new BtheB(2, "Yes", ">6m", "BtheB", 32, 16, 24, 17, 20);
                yield return new BtheB(3, "Yes", "<6m", "TAU", 25, 20, null, null, null);
                yield return new BtheB(4, "No", ">6m", "BtheB", 21, 17, 16, 10, 9);
                yield return new BtheB(5, "Yes", ">6m", "BtheB", 26, 23, null, null, null);
                yield return new BtheB(6, "Yes", "<6m", "BtheB", 7, 0, 0, 0, 0);
                yield return new BtheB(7, "Yes", "<6m", "TAU", 17, 7, 7, 3, 7);
                yield return new BtheB(8, "No", ">6m", "TAU", 20, 20, 21, 19, 13);
                yield return new BtheB(9, "Yes", "<6m", "BtheB", 18, 13, 14, 20, 11);
                yield return new BtheB(10, "Yes", ">6m", "BtheB", 20, 5, 5, 8, 12);
                yield return new BtheB(11, "No", ">6m", "TAU", 30, 32, 24, 12, 2);
                yield return new BtheB(12, "Yes", "<6m", "BtheB", 49, 35, null, null, null);
                yield return new BtheB(13, "No", ">6m", "TAU", 26, 27, 23, null, null);
                yield return new BtheB(14, "Yes", ">6m", "TAU", 30, 26, 36, 27, 22);
                yield return new BtheB(15, "Yes", ">6m", "BtheB", 23, 13, 13, 12, 23);
                yield return new BtheB(16, "No", "<6m", "TAU", 16, 13, 3, 2, 0);
                yield return new BtheB(17, "No", ">6m", "BtheB", 30, 30, 29, null, null);
                yield return new BtheB(18, "No", "<6m", "BtheB", 13, 8, 8, 7, 6);
                yield return new BtheB(19, "No", ">6m", "TAU", 37, 30, 33, 31, 22);
                yield return new BtheB(20, "Yes", "<6m", "BtheB", 35, 12, 10, 8, 10);
                yield return new BtheB(21, "No", ">6m", "BtheB", 21, 6, null, null, null);
                yield return new BtheB(22, "No", "<6m", "TAU", 26, 17, 17, 20, 12);
                yield return new BtheB(23, "No", ">6m", "TAU", 29, 22, 10, null, null);
                yield return new BtheB(24, "No", ">6m", "TAU", 20, 21, null, null, null);
                yield return new BtheB(25, "No", ">6m", "TAU", 33, 23, null, null, null);
                yield return new BtheB(26, "No", ">6m", "BtheB", 19, 12, 13, null, null);
                yield return new BtheB(27, "Yes", "<6m", "TAU", 12, 15, null, null, null);
                yield return new BtheB(28, "Yes", ">6m", "TAU", 47, 36, 49, 34, null);
                yield return new BtheB(29, "Yes", ">6m", "BtheB", 36, 6, 0, 0, 2);
                yield return new BtheB(30, "No", "<6m", "BtheB", 10, 8, 6, 3, 3);
                yield return new BtheB(31, "No", "<6m", "TAU", 27, 7, 15, 16, 0);
                yield return new BtheB(32, "No", "<6m", "BtheB", 18, 10, 10, 6, 8);
                yield return new BtheB(33, "Yes", "<6m", "BtheB", 11, 8, 3, 2, 15);
                yield return new BtheB(34, "Yes", "<6m", "BtheB", 6, 7, null, null, null);
                yield return new BtheB(35, "Yes", ">6m", "BtheB", 44, 24, 20, 29, 14);
                yield return new BtheB(36, "No", "<6m", "TAU", 38, 38, null, null, null);
                yield return new BtheB(37, "No", "<6m", "TAU", 21, 14, 20, 1, 8);
                yield return new BtheB(38, "Yes", ">6m", "TAU", 34, 17, 8, 9, 13);
                yield return new BtheB(39, "Yes", "<6m", "BtheB", 9, 7, 1, null, null);
                yield return new BtheB(40, "Yes", ">6m", "TAU", 38, 27, 19, 20, 30);
                yield return new BtheB(41, "Yes", "<6m", "BtheB", 46, 40, null, null, null);
                yield return new BtheB(42, "No", "<6m", "TAU", 20, 19, 18, 19, 18);
                yield return new BtheB(43, "Yes", ">6m", "TAU", 17, 29, 2, 0, 0);
                yield return new BtheB(44, "No", ">6m", "BtheB", 18, 20, null, null, null);
                yield return new BtheB(45, "Yes", ">6m", "BtheB", 42, 1, 8, 10, 6);
                yield return new BtheB(46, "No", "<6m", "BtheB", 30, 30, null, null, null);
                yield return new BtheB(47, "Yes", "<6m", "BtheB", 33, 27, 16, 30, 15);
                yield return new BtheB(48, "No", "<6m", "BtheB", 12, 1, 0, 0, null);
                yield return new BtheB(49, "Yes", "<6m", "BtheB", 2, 5, null, null, null);
                yield return new BtheB(50, "No", ">6m", "TAU", 36, 42, 49, 47, 40);
                yield return new BtheB(51, "No", "<6m", "TAU", 35, 30, null, null, null);
                yield return new BtheB(52, "No", "<6m", "BtheB", 23, 20, null, null, null);
                yield return new BtheB(53, "No", ">6m", "TAU", 31, 48, 38, 38, 37);
                yield return new BtheB(54, "Yes", "<6m", "BtheB", 8, 5, 7, null, null);
                yield return new BtheB(55, "Yes", "<6m", "TAU", 23, 21, 26, null, null);
                yield return new BtheB(56, "Yes", "<6m", "BtheB", 7, 7, 5, 4, 0);
                yield return new BtheB(57, "No", "<6m", "TAU", 14, 13, 14, null, null);
                yield return new BtheB(58, "No", "<6m", "TAU", 40, 36, 33, null, null);
                yield return new BtheB(59, "Yes", "<6m", "BtheB", 23, 30, null, null, null);
                yield return new BtheB(60, "No", ">6m", "BtheB", 14, 3, null, null, null);
                yield return new BtheB(61, "No", ">6m", "TAU", 22, 20, 16, 24, 16);
                yield return new BtheB(62, "No", ">6m", "TAU", 23, 23, 15, 25, 17);
                yield return new BtheB(63, "No", "<6m", "TAU", 15, 7, 13, 13, null);
                yield return new BtheB(64, "No", ">6m", "TAU", 8, 12, 11, 26, null);
                yield return new BtheB(65, "No", ">6m", "BtheB", 12, 18, null, null, null);
                yield return new BtheB(66, "No", ">6m", "TAU", 7, 6, 2, 1, null);
                yield return new BtheB(67, "Yes", "<6m", "TAU", 17, 9, 3, 1, 0);
                yield return new BtheB(68, "Yes", "<6m", "BtheB", 33, 18, 16, null, null);
                yield return new BtheB(69, "No", "<6m", "TAU", 27, 20, null, null, null);
                yield return new BtheB(70, "No", "<6m", "BtheB", 27, 30, null, null, null);
                yield return new BtheB(71, "No", "<6m", "BtheB", 9, 6, 10, 1, 0);
                yield return new BtheB(72, "No", ">6m", "BtheB", 40, 30, 12, null, null);
                yield return new BtheB(73, "No", ">6m", "TAU", 11, 8, 7, null, null);
                yield return new BtheB(74, "No", "<6m", "TAU", 9, 8, null, null, null);
                yield return new BtheB(75, "No", ">6m", "TAU", 14, 22, 21, 24, 19);
                yield return new BtheB(76, "Yes", ">6m", "BtheB", 28, 9, 20, 18, 13);
                yield return new BtheB(77, "No", ">6m", "BtheB", 15, 9, 13, 14, 10);
                yield return new BtheB(78, "Yes", ">6m", "BtheB", 22, 10, 5, 5, 12);
                yield return new BtheB(79, "No", "<6m", "TAU", 23, 9, null, null, null);
                yield return new BtheB(80, "No", ">6m", "TAU", 21, 22, 24, 23, 22);
                yield return new BtheB(81, "No", ">6m", "TAU", 27, 31, 28, 22, 14);
                yield return new BtheB(82, "Yes", ">6m", "BtheB", 14, 15, null, null, null);
                yield return new BtheB(83, "No", ">6m", "TAU", 10, 13, 12, 8, 20);
                yield return new BtheB(84, "Yes", "<6m", "TAU", 21, 9, 6, 7, 1);
                yield return new BtheB(85, "Yes", ">6m", "BtheB", 46, 36, 53, null, null);
                yield return new BtheB(86, "No", ">6m", "BtheB", 36, 14, 7, 15, 15);
                yield return new BtheB(87, "Yes", ">6m", "BtheB", 23, 17, null, null, null);
                yield return new BtheB(88, "Yes", ">6m", "TAU", 35, 0, 6, 0, 1);
                yield return new BtheB(89, "Yes", "<6m", "BtheB", 33, 13, 13, 10, 8);
                yield return new BtheB(90, "No", "<6m", "BtheB", 19, 4, 27, 1, 2);
                yield return new BtheB(91, "No", "<6m", "TAU", 16, null, null, null, null);
                yield return new BtheB(92, "Yes", "<6m", "BtheB", 30, 26, 28, null, null);
                yield return new BtheB(93, "Yes", "<6m", "BtheB", 17, 8, 7, 12, null);
                yield return new BtheB(94, "No", ">6m", "BtheB", 19, 4, 3, 3, 3);
                yield return new BtheB(95, "No", ">6m", "BtheB", 16, 11, 4, 2, 3);
                yield return new BtheB(96, "Yes", ">6m", "BtheB", 16, 16, 10, 10, 8);
                yield return new BtheB(97, "Yes", "<6m", "TAU", 28, null, null, null, null);
                yield return new BtheB(98, "No", ">6m", "BtheB", 11, 22, 9, 11, 11);
                yield return new BtheB(99, "No", "<6m", "TAU", 13, 5, 5, 0, 6);
                yield return new BtheB(100, "Yes", "<6m", "TAU", 43, null, null, null, null);
            }
        }
    }
}
