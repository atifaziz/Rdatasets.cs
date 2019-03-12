// ReSharper disable All

namespace Rdatasets.KMsurv
{
    using System.Collections.Generic;

    /// <summary>
    /// data from Section 1.9
    /// </summary>

    public class alloauto
    {
        public readonly int κ;
        public readonly double time;
        public readonly int type;
        public readonly int delta;

        public alloauto(int κ, double time, int type, int delta)
        {
            this.κ = κ;
            this.time = time;
            this.type = type;
            this.delta = delta;
        }

        public static IEnumerable<alloauto> Data
        {
            get
            {
                yield return new alloauto(1, 0.03, 1, 1);
                yield return new alloauto(2, 0.493, 1, 1);
                yield return new alloauto(3, 0.855, 1, 1);
                yield return new alloauto(4, 1.184, 1, 1);
                yield return new alloauto(5, 1.283, 1, 1);
                yield return new alloauto(6, 1.48, 1, 1);
                yield return new alloauto(7, 1.776, 1, 1);
                yield return new alloauto(8, 2.138, 1, 1);
                yield return new alloauto(9, 2.5, 1, 1);
                yield return new alloauto(10, 2.763, 1, 1);
                yield return new alloauto(11, 2.993, 1, 1);
                yield return new alloauto(12, 3.224, 1, 1);
                yield return new alloauto(13, 3.421, 1, 1);
                yield return new alloauto(14, 4.178, 1, 1);
                yield return new alloauto(15, 4.441, 1, 0);
                yield return new alloauto(16, 5.691, 1, 1);
                yield return new alloauto(17, 5.855, 1, 0);
                yield return new alloauto(18, 6.941, 1, 0);
                yield return new alloauto(19, 6.941, 1, 1);
                yield return new alloauto(20, 7.993, 1, 0);
                yield return new alloauto(21, 8.882, 1, 1);
                yield return new alloauto(22, 8.882, 1, 1);
                yield return new alloauto(23, 9.145, 1, 0);
                yield return new alloauto(24, 11.48, 1, 1);
                yield return new alloauto(25, 11.513, 1, 1);
                yield return new alloauto(26, 12.105, 1, 0);
                yield return new alloauto(27, 12.796, 1, 1);
                yield return new alloauto(28, 12.993, 1, 0);
                yield return new alloauto(29, 13.849, 1, 0);
                yield return new alloauto(30, 16.612, 1, 0);
                yield return new alloauto(31, 17.138, 1, 0);
                yield return new alloauto(32, 20.066, 1, 1);
                yield return new alloauto(33, 20.329, 1, 0);
                yield return new alloauto(34, 22.368, 1, 0);
                yield return new alloauto(35, 26.776, 1, 0);
                yield return new alloauto(36, 28.717, 1, 0);
                yield return new alloauto(37, 28.717, 1, 0);
                yield return new alloauto(38, 32.928, 1, 0);
                yield return new alloauto(39, 33.783, 1, 0);
                yield return new alloauto(40, 34.221, 1, 0);
                yield return new alloauto(41, 34.77, 1, 0);
                yield return new alloauto(42, 39.593, 1, 0);
                yield return new alloauto(43, 41.118, 1, 0);
                yield return new alloauto(44, 45.003, 1, 0);
                yield return new alloauto(45, 46.053, 1, 0);
                yield return new alloauto(46, 46.941, 1, 0);
                yield return new alloauto(47, 48.289, 1, 0);
                yield return new alloauto(48, 57.401, 1, 0);
                yield return new alloauto(49, 58.322, 1, 0);
                yield return new alloauto(50, 60.625, 1, 0);
                yield return new alloauto(51, 0.658, 2, 1);
                yield return new alloauto(52, 0.822, 2, 1);
                yield return new alloauto(53, 1.414, 2, 1);
                yield return new alloauto(54, 2.5, 2, 1);
                yield return new alloauto(55, 3.322, 2, 1);
                yield return new alloauto(56, 3.816, 2, 1);
                yield return new alloauto(57, 4.737, 2, 1);
                yield return new alloauto(58, 4.836, 2, 0);
                yield return new alloauto(59, 4.934, 2, 1);
                yield return new alloauto(60, 5.033, 2, 1);
                yield return new alloauto(61, 5.757, 2, 1);
                yield return new alloauto(62, 5.855, 2, 1);
                yield return new alloauto(63, 5.987, 2, 1);
                yield return new alloauto(64, 6.151, 2, 1);
                yield return new alloauto(65, 6.217, 2, 1);
                yield return new alloauto(66, 6.447, 2, 0);
                yield return new alloauto(67, 8.651, 2, 1);
                yield return new alloauto(68, 8.711, 2, 1);
                yield return new alloauto(69, 9.441, 2, 0);
                yield return new alloauto(70, 10.329, 2, 1);
                yield return new alloauto(71, 11.48, 2, 1);
                yield return new alloauto(72, 12.007, 2, 1);
                yield return new alloauto(73, 12.007, 2, 0);
                yield return new alloauto(74, 12.237, 2, 1);
                yield return new alloauto(75, 12.401, 2, 0);
                yield return new alloauto(76, 13.059, 2, 0);
                yield return new alloauto(77, 14.474, 2, 0);
                yield return new alloauto(78, 15, 2, 0);
                yield return new alloauto(79, 15.461, 2, 1);
                yield return new alloauto(80, 15.757, 2, 1);
                yield return new alloauto(81, 16.48, 2, 1);
                yield return new alloauto(82, 16.711, 2, 1);
                yield return new alloauto(83, 17.204, 2, 0);
                yield return new alloauto(84, 17.237, 2, 1);
                yield return new alloauto(85, 17.303, 2, 0);
                yield return new alloauto(86, 17.664, 2, 0);
                yield return new alloauto(87, 18.092, 2, 1);
                yield return new alloauto(88, 18.092, 2, 0);
                yield return new alloauto(89, 18.75, 2, 0);
                yield return new alloauto(90, 20.625, 2, 0);
                yield return new alloauto(91, 23.158, 2, 1);
                yield return new alloauto(92, 27.73, 2, 0);
                yield return new alloauto(93, 31.184, 2, 0);
                yield return new alloauto(94, 32.434, 2, 0);
                yield return new alloauto(95, 35.921, 2, 0);
                yield return new alloauto(96, 42.237, 2, 0);
                yield return new alloauto(97, 44.638, 2, 0);
                yield return new alloauto(98, 46.48, 2, 0);
                yield return new alloauto(99, 47.467, 2, 0);
                yield return new alloauto(100, 48.322, 2, 0);
                yield return new alloauto(101, 56.086, 2, 1);
            }
        }
    }
}
