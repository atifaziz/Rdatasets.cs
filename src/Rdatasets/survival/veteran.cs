// ReSharper disable All

namespace Rdatasets.survival
{
    using System.Collections.Generic;

    /// <summary>
    /// Veterans' Administration Lung Cancer study
    /// </summary>

    public class veteran
    {
        public readonly int κ;
        public readonly int trt;
        public readonly string celltype;
        public readonly int time;
        public readonly int status;
        public readonly int karno;
        public readonly int diagtime;
        public readonly int age;
        public readonly int prior;

        public veteran(int κ, int trt, string celltype, int time, int status, int karno, int diagtime, int age, int prior)
        {
            this.κ = κ;
            this.trt = trt;
            this.celltype = celltype;
            this.time = time;
            this.status = status;
            this.karno = karno;
            this.diagtime = diagtime;
            this.age = age;
            this.prior = prior;
        }

        public static IEnumerable<veteran> Data
        {
            get
            {
                yield return new veteran(1, 1, "squamous", 72, 1, 60, 7, 69, 0);
                yield return new veteran(2, 1, "squamous", 411, 1, 70, 5, 64, 10);
                yield return new veteran(3, 1, "squamous", 228, 1, 60, 3, 38, 0);
                yield return new veteran(4, 1, "squamous", 126, 1, 60, 9, 63, 10);
                yield return new veteran(5, 1, "squamous", 118, 1, 70, 11, 65, 10);
                yield return new veteran(6, 1, "squamous", 10, 1, 20, 5, 49, 0);
                yield return new veteran(7, 1, "squamous", 82, 1, 40, 10, 69, 10);
                yield return new veteran(8, 1, "squamous", 110, 1, 80, 29, 68, 0);
                yield return new veteran(9, 1, "squamous", 314, 1, 50, 18, 43, 0);
                yield return new veteran(10, 1, "squamous", 100, 0, 70, 6, 70, 0);
                yield return new veteran(11, 1, "squamous", 42, 1, 60, 4, 81, 0);
                yield return new veteran(12, 1, "squamous", 8, 1, 40, 58, 63, 10);
                yield return new veteran(13, 1, "squamous", 144, 1, 30, 4, 63, 0);
                yield return new veteran(14, 1, "squamous", 25, 0, 80, 9, 52, 10);
                yield return new veteran(15, 1, "squamous", 11, 1, 70, 11, 48, 10);
                yield return new veteran(16, 1, "smallcell", 30, 1, 60, 3, 61, 0);
                yield return new veteran(17, 1, "smallcell", 384, 1, 60, 9, 42, 0);
                yield return new veteran(18, 1, "smallcell", 4, 1, 40, 2, 35, 0);
                yield return new veteran(19, 1, "smallcell", 54, 1, 80, 4, 63, 10);
                yield return new veteran(20, 1, "smallcell", 13, 1, 60, 4, 56, 0);
                yield return new veteran(21, 1, "smallcell", 123, 0, 40, 3, 55, 0);
                yield return new veteran(22, 1, "smallcell", 97, 0, 60, 5, 67, 0);
                yield return new veteran(23, 1, "smallcell", 153, 1, 60, 14, 63, 10);
                yield return new veteran(24, 1, "smallcell", 59, 1, 30, 2, 65, 0);
                yield return new veteran(25, 1, "smallcell", 117, 1, 80, 3, 46, 0);
                yield return new veteran(26, 1, "smallcell", 16, 1, 30, 4, 53, 10);
                yield return new veteran(27, 1, "smallcell", 151, 1, 50, 12, 69, 0);
                yield return new veteran(28, 1, "smallcell", 22, 1, 60, 4, 68, 0);
                yield return new veteran(29, 1, "smallcell", 56, 1, 80, 12, 43, 10);
                yield return new veteran(30, 1, "smallcell", 21, 1, 40, 2, 55, 10);
                yield return new veteran(31, 1, "smallcell", 18, 1, 20, 15, 42, 0);
                yield return new veteran(32, 1, "smallcell", 139, 1, 80, 2, 64, 0);
                yield return new veteran(33, 1, "smallcell", 20, 1, 30, 5, 65, 0);
                yield return new veteran(34, 1, "smallcell", 31, 1, 75, 3, 65, 0);
                yield return new veteran(35, 1, "smallcell", 52, 1, 70, 2, 55, 0);
                yield return new veteran(36, 1, "smallcell", 287, 1, 60, 25, 66, 10);
                yield return new veteran(37, 1, "smallcell", 18, 1, 30, 4, 60, 0);
                yield return new veteran(38, 1, "smallcell", 51, 1, 60, 1, 67, 0);
                yield return new veteran(39, 1, "smallcell", 122, 1, 80, 28, 53, 0);
                yield return new veteran(40, 1, "smallcell", 27, 1, 60, 8, 62, 0);
                yield return new veteran(41, 1, "smallcell", 54, 1, 70, 1, 67, 0);
                yield return new veteran(42, 1, "smallcell", 7, 1, 50, 7, 72, 0);
                yield return new veteran(43, 1, "smallcell", 63, 1, 50, 11, 48, 0);
                yield return new veteran(44, 1, "smallcell", 392, 1, 40, 4, 68, 0);
                yield return new veteran(45, 1, "smallcell", 10, 1, 40, 23, 67, 10);
                yield return new veteran(46, 1, "adeno", 8, 1, 20, 19, 61, 10);
                yield return new veteran(47, 1, "adeno", 92, 1, 70, 10, 60, 0);
                yield return new veteran(48, 1, "adeno", 35, 1, 40, 6, 62, 0);
                yield return new veteran(49, 1, "adeno", 117, 1, 80, 2, 38, 0);
                yield return new veteran(50, 1, "adeno", 132, 1, 80, 5, 50, 0);
                yield return new veteran(51, 1, "adeno", 12, 1, 50, 4, 63, 10);
                yield return new veteran(52, 1, "adeno", 162, 1, 80, 5, 64, 0);
                yield return new veteran(53, 1, "adeno", 3, 1, 30, 3, 43, 0);
                yield return new veteran(54, 1, "adeno", 95, 1, 80, 4, 34, 0);
                yield return new veteran(55, 1, "large", 177, 1, 50, 16, 66, 10);
                yield return new veteran(56, 1, "large", 162, 1, 80, 5, 62, 0);
                yield return new veteran(57, 1, "large", 216, 1, 50, 15, 52, 0);
                yield return new veteran(58, 1, "large", 553, 1, 70, 2, 47, 0);
                yield return new veteran(59, 1, "large", 278, 1, 60, 12, 63, 0);
                yield return new veteran(60, 1, "large", 12, 1, 40, 12, 68, 10);
                yield return new veteran(61, 1, "large", 260, 1, 80, 5, 45, 0);
                yield return new veteran(62, 1, "large", 200, 1, 80, 12, 41, 10);
                yield return new veteran(63, 1, "large", 156, 1, 70, 2, 66, 0);
                yield return new veteran(64, 1, "large", 182, 0, 90, 2, 62, 0);
                yield return new veteran(65, 1, "large", 143, 1, 90, 8, 60, 0);
                yield return new veteran(66, 1, "large", 105, 1, 80, 11, 66, 0);
                yield return new veteran(67, 1, "large", 103, 1, 80, 5, 38, 0);
                yield return new veteran(68, 1, "large", 250, 1, 70, 8, 53, 10);
                yield return new veteran(69, 1, "large", 100, 1, 60, 13, 37, 10);
                yield return new veteran(70, 2, "squamous", 999, 1, 90, 12, 54, 10);
                yield return new veteran(71, 2, "squamous", 112, 1, 80, 6, 60, 0);
                yield return new veteran(72, 2, "squamous", 87, 0, 80, 3, 48, 0);
                yield return new veteran(73, 2, "squamous", 231, 0, 50, 8, 52, 10);
                yield return new veteran(74, 2, "squamous", 242, 1, 50, 1, 70, 0);
                yield return new veteran(75, 2, "squamous", 991, 1, 70, 7, 50, 10);
                yield return new veteran(76, 2, "squamous", 111, 1, 70, 3, 62, 0);
                yield return new veteran(77, 2, "squamous", 1, 1, 20, 21, 65, 10);
                yield return new veteran(78, 2, "squamous", 587, 1, 60, 3, 58, 0);
                yield return new veteran(79, 2, "squamous", 389, 1, 90, 2, 62, 0);
                yield return new veteran(80, 2, "squamous", 33, 1, 30, 6, 64, 0);
                yield return new veteran(81, 2, "squamous", 25, 1, 20, 36, 63, 0);
                yield return new veteran(82, 2, "squamous", 357, 1, 70, 13, 58, 0);
                yield return new veteran(83, 2, "squamous", 467, 1, 90, 2, 64, 0);
                yield return new veteran(84, 2, "squamous", 201, 1, 80, 28, 52, 10);
                yield return new veteran(85, 2, "squamous", 1, 1, 50, 7, 35, 0);
                yield return new veteran(86, 2, "squamous", 30, 1, 70, 11, 63, 0);
                yield return new veteran(87, 2, "squamous", 44, 1, 60, 13, 70, 10);
                yield return new veteran(88, 2, "squamous", 283, 1, 90, 2, 51, 0);
                yield return new veteran(89, 2, "squamous", 15, 1, 50, 13, 40, 10);
                yield return new veteran(90, 2, "smallcell", 25, 1, 30, 2, 69, 0);
                yield return new veteran(91, 2, "smallcell", 103, 0, 70, 22, 36, 10);
                yield return new veteran(92, 2, "smallcell", 21, 1, 20, 4, 71, 0);
                yield return new veteran(93, 2, "smallcell", 13, 1, 30, 2, 62, 0);
                yield return new veteran(94, 2, "smallcell", 87, 1, 60, 2, 60, 0);
                yield return new veteran(95, 2, "smallcell", 2, 1, 40, 36, 44, 10);
                yield return new veteran(96, 2, "smallcell", 20, 1, 30, 9, 54, 10);
                yield return new veteran(97, 2, "smallcell", 7, 1, 20, 11, 66, 0);
                yield return new veteran(98, 2, "smallcell", 24, 1, 60, 8, 49, 0);
                yield return new veteran(99, 2, "smallcell", 99, 1, 70, 3, 72, 0);
                yield return new veteran(100, 2, "smallcell", 8, 1, 80, 2, 68, 0);
                yield return new veteran(101, 2, "smallcell", 99, 1, 85, 4, 62, 0);
                yield return new veteran(102, 2, "smallcell", 61, 1, 70, 2, 71, 0);
                yield return new veteran(103, 2, "smallcell", 25, 1, 70, 2, 70, 0);
                yield return new veteran(104, 2, "smallcell", 95, 1, 70, 1, 61, 0);
                yield return new veteran(105, 2, "smallcell", 80, 1, 50, 17, 71, 0);
                yield return new veteran(106, 2, "smallcell", 51, 1, 30, 87, 59, 10);
                yield return new veteran(107, 2, "smallcell", 29, 1, 40, 8, 67, 0);
                yield return new veteran(108, 2, "adeno", 24, 1, 40, 2, 60, 0);
                yield return new veteran(109, 2, "adeno", 18, 1, 40, 5, 69, 10);
                yield return new veteran(110, 2, "adeno", 83, 0, 99, 3, 57, 0);
                yield return new veteran(111, 2, "adeno", 31, 1, 80, 3, 39, 0);
                yield return new veteran(112, 2, "adeno", 51, 1, 60, 5, 62, 0);
                yield return new veteran(113, 2, "adeno", 90, 1, 60, 22, 50, 10);
                yield return new veteran(114, 2, "adeno", 52, 1, 60, 3, 43, 0);
                yield return new veteran(115, 2, "adeno", 73, 1, 60, 3, 70, 0);
                yield return new veteran(116, 2, "adeno", 8, 1, 50, 5, 66, 0);
                yield return new veteran(117, 2, "adeno", 36, 1, 70, 8, 61, 0);
                yield return new veteran(118, 2, "adeno", 48, 1, 10, 4, 81, 0);
                yield return new veteran(119, 2, "adeno", 7, 1, 40, 4, 58, 0);
                yield return new veteran(120, 2, "adeno", 140, 1, 70, 3, 63, 0);
                yield return new veteran(121, 2, "adeno", 186, 1, 90, 3, 60, 0);
                yield return new veteran(122, 2, "adeno", 84, 1, 80, 4, 62, 10);
                yield return new veteran(123, 2, "adeno", 19, 1, 50, 10, 42, 0);
                yield return new veteran(124, 2, "adeno", 45, 1, 40, 3, 69, 0);
                yield return new veteran(125, 2, "adeno", 80, 1, 40, 4, 63, 0);
                yield return new veteran(126, 2, "large", 52, 1, 60, 4, 45, 0);
                yield return new veteran(127, 2, "large", 164, 1, 70, 15, 68, 10);
                yield return new veteran(128, 2, "large", 19, 1, 30, 4, 39, 10);
                yield return new veteran(129, 2, "large", 53, 1, 60, 12, 66, 0);
                yield return new veteran(130, 2, "large", 15, 1, 30, 5, 63, 0);
                yield return new veteran(131, 2, "large", 43, 1, 60, 11, 49, 10);
                yield return new veteran(132, 2, "large", 340, 1, 80, 10, 64, 10);
                yield return new veteran(133, 2, "large", 133, 1, 75, 1, 65, 0);
                yield return new veteran(134, 2, "large", 111, 1, 60, 5, 64, 0);
                yield return new veteran(135, 2, "large", 231, 1, 70, 18, 67, 10);
                yield return new veteran(136, 2, "large", 378, 1, 80, 4, 65, 0);
                yield return new veteran(137, 2, "large", 49, 1, 30, 3, 37, 0);
            }
        }
    }
}
