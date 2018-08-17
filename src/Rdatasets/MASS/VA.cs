// ReSharper disable All

namespace Rdatasets.MASS
{
    using System.Collections.Generic;

    /// <summary>
    /// Veteran's Administration Lung Cancer Trial
    /// </summary>

    public class VA
    {
        public readonly int stime;
        public readonly int status;
        public readonly int treat;
        public readonly int age;
        public readonly int Karn;
        public readonly int diag_time;
        public readonly int cell;
        public readonly int prior;

        public VA(int stime, int status, int treat, int age, int Karn, int diag_time, int cell, int prior)
        {
            this.stime = stime;
            this.status = status;
            this.treat = treat;
            this.age = age;
            this.Karn = Karn;
            this.diag_time = diag_time;
            this.cell = cell;
            this.prior = prior;
        }

        public static IEnumerable<VA> Data
        {
            get
            {
                yield return new VA(72, 1, 1, 69, 60, 7, 1, 0);
                yield return new VA(411, 1, 1, 64, 70, 5, 1, 10);
                yield return new VA(228, 1, 1, 38, 60, 3, 1, 0);
                yield return new VA(126, 1, 1, 63, 60, 9, 1, 10);
                yield return new VA(118, 1, 1, 65, 70, 11, 1, 10);
                yield return new VA(10, 1, 1, 49, 20, 5, 1, 0);
                yield return new VA(82, 1, 1, 69, 40, 10, 1, 10);
                yield return new VA(110, 1, 1, 68, 80, 29, 1, 0);
                yield return new VA(314, 1, 1, 43, 50, 18, 1, 0);
                yield return new VA(100, 0, 1, 70, 70, 6, 1, 0);
                yield return new VA(42, 1, 1, 81, 60, 4, 1, 0);
                yield return new VA(8, 1, 1, 63, 40, 58, 1, 10);
                yield return new VA(144, 1, 1, 63, 30, 4, 1, 0);
                yield return new VA(25, 0, 1, 52, 80, 9, 1, 10);
                yield return new VA(11, 1, 1, 48, 70, 11, 1, 10);
                yield return new VA(30, 1, 1, 61, 60, 3, 2, 0);
                yield return new VA(384, 1, 1, 42, 60, 9, 2, 0);
                yield return new VA(4, 1, 1, 35, 40, 2, 2, 0);
                yield return new VA(54, 1, 1, 63, 80, 4, 2, 10);
                yield return new VA(13, 1, 1, 56, 60, 4, 2, 0);
                yield return new VA(123, 0, 1, 55, 40, 3, 2, 0);
                yield return new VA(97, 0, 1, 67, 60, 5, 2, 0);
                yield return new VA(153, 1, 1, 63, 60, 14, 2, 10);
                yield return new VA(59, 1, 1, 65, 30, 2, 2, 0);
                yield return new VA(117, 1, 1, 46, 80, 3, 2, 0);
                yield return new VA(16, 1, 1, 53, 30, 4, 2, 10);
                yield return new VA(151, 1, 1, 69, 50, 12, 2, 0);
                yield return new VA(22, 1, 1, 68, 60, 4, 2, 0);
                yield return new VA(56, 1, 1, 43, 80, 12, 2, 10);
                yield return new VA(21, 1, 1, 55, 40, 2, 2, 10);
                yield return new VA(18, 1, 1, 42, 20, 15, 2, 0);
                yield return new VA(139, 1, 1, 64, 80, 2, 2, 0);
                yield return new VA(20, 1, 1, 65, 30, 5, 2, 0);
                yield return new VA(31, 1, 1, 65, 75, 3, 2, 0);
                yield return new VA(52, 1, 1, 55, 70, 2, 2, 0);
                yield return new VA(287, 1, 1, 66, 60, 25, 2, 10);
                yield return new VA(18, 1, 1, 60, 30, 4, 2, 0);
                yield return new VA(51, 1, 1, 67, 60, 1, 2, 0);
                yield return new VA(122, 1, 1, 53, 80, 28, 2, 0);
                yield return new VA(27, 1, 1, 62, 60, 8, 2, 0);
                yield return new VA(54, 1, 1, 67, 70, 1, 2, 0);
                yield return new VA(7, 1, 1, 72, 50, 7, 2, 0);
                yield return new VA(63, 1, 1, 48, 50, 11, 2, 0);
                yield return new VA(392, 1, 1, 68, 40, 4, 2, 0);
                yield return new VA(10, 1, 1, 67, 40, 23, 2, 10);
                yield return new VA(8, 1, 1, 61, 20, 19, 3, 10);
                yield return new VA(92, 1, 1, 60, 70, 10, 3, 0);
                yield return new VA(35, 1, 1, 62, 40, 6, 3, 0);
                yield return new VA(117, 1, 1, 38, 80, 2, 3, 0);
                yield return new VA(132, 1, 1, 50, 80, 5, 3, 0);
                yield return new VA(12, 1, 1, 63, 50, 4, 3, 10);
                yield return new VA(162, 1, 1, 64, 80, 5, 3, 0);
                yield return new VA(3, 1, 1, 43, 30, 3, 3, 0);
                yield return new VA(95, 1, 1, 34, 80, 4, 3, 0);
                yield return new VA(177, 1, 1, 66, 50, 16, 4, 10);
                yield return new VA(162, 1, 1, 62, 80, 5, 4, 0);
                yield return new VA(216, 1, 1, 52, 50, 15, 4, 0);
                yield return new VA(553, 1, 1, 47, 70, 2, 4, 0);
                yield return new VA(278, 1, 1, 63, 60, 12, 4, 0);
                yield return new VA(12, 1, 1, 68, 40, 12, 4, 10);
                yield return new VA(260, 1, 1, 45, 80, 5, 4, 0);
                yield return new VA(200, 1, 1, 41, 80, 12, 4, 10);
                yield return new VA(156, 1, 1, 66, 70, 2, 4, 0);
                yield return new VA(182, 0, 1, 62, 90, 2, 4, 0);
                yield return new VA(143, 1, 1, 60, 90, 8, 4, 0);
                yield return new VA(105, 1, 1, 66, 80, 11, 4, 0);
                yield return new VA(103, 1, 1, 38, 80, 5, 4, 0);
                yield return new VA(250, 1, 1, 53, 70, 8, 4, 10);
                yield return new VA(100, 1, 1, 37, 60, 13, 4, 10);
                yield return new VA(999, 1, 2, 54, 90, 12, 1, 10);
                yield return new VA(112, 1, 2, 60, 80, 6, 1, 0);
                yield return new VA(87, 0, 2, 48, 80, 3, 1, 0);
                yield return new VA(231, 0, 2, 52, 50, 8, 1, 10);
                yield return new VA(242, 1, 2, 70, 50, 1, 1, 0);
                yield return new VA(991, 1, 2, 50, 70, 7, 1, 10);
                yield return new VA(111, 1, 2, 62, 70, 3, 1, 0);
                yield return new VA(1, 1, 2, 65, 20, 21, 1, 10);
                yield return new VA(587, 1, 2, 58, 60, 3, 1, 0);
                yield return new VA(389, 1, 2, 62, 90, 2, 1, 0);
                yield return new VA(33, 1, 2, 64, 30, 6, 1, 0);
                yield return new VA(25, 1, 2, 63, 20, 36, 1, 0);
                yield return new VA(357, 1, 2, 58, 70, 13, 1, 0);
                yield return new VA(467, 1, 2, 64, 90, 2, 1, 0);
                yield return new VA(201, 1, 2, 52, 80, 28, 1, 10);
                yield return new VA(1, 1, 2, 35, 50, 7, 1, 0);
                yield return new VA(30, 1, 2, 63, 70, 11, 1, 0);
                yield return new VA(44, 1, 2, 70, 60, 13, 1, 10);
                yield return new VA(283, 1, 2, 51, 90, 2, 1, 0);
                yield return new VA(15, 1, 2, 40, 50, 13, 1, 10);
                yield return new VA(25, 1, 2, 69, 30, 2, 2, 0);
                yield return new VA(103, 0, 2, 36, 70, 22, 2, 10);
                yield return new VA(21, 1, 2, 71, 20, 4, 2, 0);
                yield return new VA(13, 1, 2, 62, 30, 2, 2, 0);
                yield return new VA(87, 1, 2, 60, 60, 2, 2, 0);
                yield return new VA(2, 1, 2, 44, 40, 36, 2, 10);
                yield return new VA(20, 1, 2, 54, 30, 9, 2, 10);
                yield return new VA(7, 1, 2, 66, 20, 11, 2, 0);
                yield return new VA(24, 1, 2, 49, 60, 8, 2, 0);
                yield return new VA(99, 1, 2, 72, 70, 3, 2, 0);
                yield return new VA(8, 1, 2, 68, 80, 2, 2, 0);
                yield return new VA(99, 1, 2, 62, 85, 4, 2, 0);
                yield return new VA(61, 1, 2, 71, 70, 2, 2, 0);
                yield return new VA(25, 1, 2, 70, 70, 2, 2, 0);
                yield return new VA(95, 1, 2, 61, 70, 1, 2, 0);
                yield return new VA(80, 1, 2, 71, 50, 17, 2, 0);
                yield return new VA(51, 1, 2, 59, 30, 87, 2, 10);
                yield return new VA(29, 1, 2, 67, 40, 8, 2, 0);
                yield return new VA(24, 1, 2, 60, 40, 2, 3, 0);
                yield return new VA(18, 1, 2, 69, 40, 5, 3, 10);
                yield return new VA(83, 0, 2, 57, 99, 3, 3, 0);
                yield return new VA(31, 1, 2, 39, 80, 3, 3, 0);
                yield return new VA(51, 1, 2, 62, 60, 5, 3, 0);
                yield return new VA(90, 1, 2, 50, 60, 22, 3, 10);
                yield return new VA(52, 1, 2, 43, 60, 3, 3, 0);
                yield return new VA(73, 1, 2, 70, 60, 3, 3, 0);
                yield return new VA(8, 1, 2, 66, 50, 5, 3, 0);
                yield return new VA(36, 1, 2, 61, 70, 8, 3, 0);
                yield return new VA(48, 1, 2, 81, 10, 4, 3, 0);
                yield return new VA(7, 1, 2, 58, 40, 4, 3, 0);
                yield return new VA(140, 1, 2, 63, 70, 3, 3, 0);
                yield return new VA(186, 1, 2, 60, 90, 3, 3, 0);
                yield return new VA(84, 1, 2, 62, 80, 4, 3, 10);
                yield return new VA(19, 1, 2, 42, 50, 10, 3, 0);
                yield return new VA(45, 1, 2, 69, 40, 3, 3, 0);
                yield return new VA(80, 1, 2, 63, 40, 4, 3, 0);
                yield return new VA(52, 1, 2, 45, 60, 4, 4, 0);
                yield return new VA(164, 1, 2, 68, 70, 15, 4, 10);
                yield return new VA(19, 1, 2, 39, 30, 4, 4, 10);
                yield return new VA(53, 1, 2, 66, 60, 12, 4, 0);
                yield return new VA(15, 1, 2, 63, 30, 5, 4, 0);
                yield return new VA(43, 1, 2, 49, 60, 11, 4, 10);
                yield return new VA(340, 1, 2, 64, 80, 10, 4, 10);
                yield return new VA(133, 1, 2, 65, 75, 1, 4, 0);
                yield return new VA(111, 1, 2, 64, 60, 5, 4, 0);
                yield return new VA(231, 1, 2, 67, 70, 18, 4, 10);
                yield return new VA(378, 1, 2, 65, 80, 4, 4, 0);
                yield return new VA(49, 1, 2, 37, 30, 3, 4, 0);
            }
        }
    }
}
