// ReSharper disable All

namespace Rdatasets.KMsurv
{
    using System.Collections.Generic;

    /// <summary>
    /// data from Section 1.4
    /// </summary>

    public class kidney
    {
        public readonly int κ;
        public readonly double time;
        public readonly int delta;
        public readonly int type;

        public kidney(int κ, double time, int delta, int type)
        {
            this.κ = κ;
            this.time = time;
            this.delta = delta;
            this.type = type;
        }

        public static IEnumerable<kidney> Data
        {
            get
            {
                yield return new kidney(1, 1.5, 1, 1);
                yield return new kidney(2, 3.5, 1, 1);
                yield return new kidney(3, 4.5, 1, 1);
                yield return new kidney(4, 4.5, 1, 1);
                yield return new kidney(5, 5.5, 1, 1);
                yield return new kidney(6, 8.5, 1, 1);
                yield return new kidney(7, 8.5, 1, 1);
                yield return new kidney(8, 9.5, 1, 1);
                yield return new kidney(9, 10.5, 1, 1);
                yield return new kidney(10, 11.5, 1, 1);
                yield return new kidney(11, 15.5, 1, 1);
                yield return new kidney(12, 16.5, 1, 1);
                yield return new kidney(13, 18.5, 1, 1);
                yield return new kidney(14, 23.5, 1, 1);
                yield return new kidney(15, 26.5, 1, 1);
                yield return new kidney(16, 2.5, 0, 1);
                yield return new kidney(17, 2.5, 0, 1);
                yield return new kidney(18, 3.5, 0, 1);
                yield return new kidney(19, 3.5, 0, 1);
                yield return new kidney(20, 3.5, 0, 1);
                yield return new kidney(21, 4.5, 0, 1);
                yield return new kidney(22, 5.5, 0, 1);
                yield return new kidney(23, 6.5, 0, 1);
                yield return new kidney(24, 6.5, 0, 1);
                yield return new kidney(25, 7.5, 0, 1);
                yield return new kidney(26, 7.5, 0, 1);
                yield return new kidney(27, 7.5, 0, 1);
                yield return new kidney(28, 7.5, 0, 1);
                yield return new kidney(29, 8.5, 0, 1);
                yield return new kidney(30, 9.5, 0, 1);
                yield return new kidney(31, 10.5, 0, 1);
                yield return new kidney(32, 11.5, 0, 1);
                yield return new kidney(33, 12.5, 0, 1);
                yield return new kidney(34, 12.5, 0, 1);
                yield return new kidney(35, 13.5, 0, 1);
                yield return new kidney(36, 14.5, 0, 1);
                yield return new kidney(37, 14.5, 0, 1);
                yield return new kidney(38, 21.5, 0, 1);
                yield return new kidney(39, 21.5, 0, 1);
                yield return new kidney(40, 22.5, 0, 1);
                yield return new kidney(41, 22.5, 0, 1);
                yield return new kidney(42, 25.5, 0, 1);
                yield return new kidney(43, 27.5, 0, 1);
                yield return new kidney(44, 0.5, 1, 2);
                yield return new kidney(45, 0.5, 1, 2);
                yield return new kidney(46, 0.5, 1, 2);
                yield return new kidney(47, 0.5, 1, 2);
                yield return new kidney(48, 0.5, 1, 2);
                yield return new kidney(49, 0.5, 1, 2);
                yield return new kidney(50, 2.5, 1, 2);
                yield return new kidney(51, 2.5, 1, 2);
                yield return new kidney(52, 3.5, 1, 2);
                yield return new kidney(53, 6.5, 1, 2);
                yield return new kidney(54, 15.5, 1, 2);
                yield return new kidney(55, 0.5, 0, 2);
                yield return new kidney(56, 0.5, 0, 2);
                yield return new kidney(57, 0.5, 0, 2);
                yield return new kidney(58, 0.5, 0, 2);
                yield return new kidney(59, 0.5, 0, 2);
                yield return new kidney(60, 0.5, 0, 2);
                yield return new kidney(61, 0.5, 0, 2);
                yield return new kidney(62, 0.5, 0, 2);
                yield return new kidney(63, 0.5, 0, 2);
                yield return new kidney(64, 0.5, 0, 2);
                yield return new kidney(65, 1.5, 0, 2);
                yield return new kidney(66, 1.5, 0, 2);
                yield return new kidney(67, 1.5, 0, 2);
                yield return new kidney(68, 1.5, 0, 2);
                yield return new kidney(69, 2.5, 0, 2);
                yield return new kidney(70, 2.5, 0, 2);
                yield return new kidney(71, 2.5, 0, 2);
                yield return new kidney(72, 2.5, 0, 2);
                yield return new kidney(73, 2.5, 0, 2);
                yield return new kidney(74, 3.5, 0, 2);
                yield return new kidney(75, 3.5, 0, 2);
                yield return new kidney(76, 3.5, 0, 2);
                yield return new kidney(77, 3.5, 0, 2);
                yield return new kidney(78, 3.5, 0, 2);
                yield return new kidney(79, 4.5, 0, 2);
                yield return new kidney(80, 4.5, 0, 2);
                yield return new kidney(81, 4.5, 0, 2);
                yield return new kidney(82, 5.5, 0, 2);
                yield return new kidney(83, 5.5, 0, 2);
                yield return new kidney(84, 5.5, 0, 2);
                yield return new kidney(85, 5.5, 0, 2);
                yield return new kidney(86, 5.5, 0, 2);
                yield return new kidney(87, 6.5, 0, 2);
                yield return new kidney(88, 7.5, 0, 2);
                yield return new kidney(89, 7.5, 0, 2);
                yield return new kidney(90, 7.5, 0, 2);
                yield return new kidney(91, 8.5, 0, 2);
                yield return new kidney(92, 8.5, 0, 2);
                yield return new kidney(93, 8.5, 0, 2);
                yield return new kidney(94, 9.5, 0, 2);
                yield return new kidney(95, 9.5, 0, 2);
                yield return new kidney(96, 10.5, 0, 2);
                yield return new kidney(97, 10.5, 0, 2);
                yield return new kidney(98, 10.5, 0, 2);
                yield return new kidney(99, 11.5, 0, 2);
                yield return new kidney(100, 11.5, 0, 2);
                yield return new kidney(101, 12.5, 0, 2);
                yield return new kidney(102, 12.5, 0, 2);
                yield return new kidney(103, 12.5, 0, 2);
                yield return new kidney(104, 12.5, 0, 2);
                yield return new kidney(105, 14.5, 0, 2);
                yield return new kidney(106, 14.5, 0, 2);
                yield return new kidney(107, 16.5, 0, 2);
                yield return new kidney(108, 16.5, 0, 2);
                yield return new kidney(109, 18.5, 0, 2);
                yield return new kidney(110, 19.5, 0, 2);
                yield return new kidney(111, 19.5, 0, 2);
                yield return new kidney(112, 19.5, 0, 2);
                yield return new kidney(113, 20.5, 0, 2);
                yield return new kidney(114, 22.5, 0, 2);
                yield return new kidney(115, 24.5, 0, 2);
                yield return new kidney(116, 25.5, 0, 2);
                yield return new kidney(117, 26.5, 0, 2);
                yield return new kidney(118, 26.5, 0, 2);
                yield return new kidney(119, 28.5, 0, 2);
            }
        }
    }
}
