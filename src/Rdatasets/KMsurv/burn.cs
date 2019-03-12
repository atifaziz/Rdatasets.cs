// ReSharper disable All

namespace Rdatasets.KMsurv
{
    using System.Collections.Generic;

    /// <summary>
    /// data from Section 1.6
    /// </summary>

    public class burn
    {
        public readonly int κ;
        public readonly int Obs;
        public readonly int Z1;
        public readonly int Z2;
        public readonly int Z3;
        public readonly int Z4;
        public readonly int Z5;
        public readonly int Z6;
        public readonly int Z7;
        public readonly int Z8;
        public readonly int Z9;
        public readonly int Z10;
        public readonly int Z11;
        public readonly int T1;
        public readonly int D1;
        public readonly int T2;
        public readonly int D2;
        public readonly int T3;
        public readonly int D3;

        public burn(int κ, int Obs, int Z1, int Z2, int Z3, int Z4, int Z5, int Z6, int Z7, int Z8, int Z9, int Z10, int Z11, int T1, int D1, int T2, int D2, int T3, int D3)
        {
            this.κ = κ;
            this.Obs = Obs;
            this.Z1 = Z1;
            this.Z2 = Z2;
            this.Z3 = Z3;
            this.Z4 = Z4;
            this.Z5 = Z5;
            this.Z6 = Z6;
            this.Z7 = Z7;
            this.Z8 = Z8;
            this.Z9 = Z9;
            this.Z10 = Z10;
            this.Z11 = Z11;
            this.T1 = T1;
            this.D1 = D1;
            this.T2 = T2;
            this.D2 = D2;
            this.T3 = T3;
            this.D3 = D3;
        }

        public static IEnumerable<burn> Data
        {
            get
            {
                yield return new burn(1, 1, 0, 0, 0, 15, 0, 0, 1, 1, 0, 0, 2, 12, 0, 12, 0, 12, 0);
                yield return new burn(2, 2, 0, 0, 1, 20, 0, 0, 1, 0, 0, 0, 4, 9, 0, 9, 0, 9, 0);
                yield return new burn(3, 3, 0, 0, 1, 15, 0, 0, 0, 1, 1, 0, 2, 13, 0, 13, 0, 7, 1);
                yield return new burn(4, 4, 0, 0, 0, 20, 1, 0, 1, 0, 0, 0, 2, 11, 1, 29, 0, 29, 0);
                yield return new burn(5, 5, 0, 0, 1, 70, 1, 1, 1, 1, 0, 0, 2, 28, 1, 31, 0, 4, 1);
                yield return new burn(6, 6, 0, 0, 1, 20, 1, 0, 1, 0, 0, 0, 4, 11, 0, 11, 0, 8, 1);
                yield return new burn(7, 7, 0, 0, 1, 5, 0, 0, 0, 0, 0, 1, 4, 12, 0, 12, 0, 11, 1);
                yield return new burn(8, 8, 0, 0, 1, 30, 1, 0, 1, 1, 0, 0, 4, 8, 1, 34, 0, 4, 1);
                yield return new burn(9, 9, 0, 0, 1, 25, 0, 1, 0, 1, 1, 0, 4, 10, 1, 53, 0, 4, 1);
                yield return new burn(10, 10, 0, 0, 1, 20, 0, 1, 0, 1, 0, 0, 4, 7, 0, 1, 1, 7, 0);
                yield return new burn(11, 11, 0, 0, 1, 30, 1, 0, 1, 0, 0, 1, 4, 7, 1, 21, 1, 44, 1);
                yield return new burn(12, 12, 0, 0, 0, 20, 0, 0, 1, 0, 0, 1, 4, 20, 0, 1, 1, 20, 0);
                yield return new burn(13, 13, 0, 0, 1, 25, 0, 0, 1, 1, 1, 0, 4, 12, 1, 32, 0, 32, 0);
                yield return new burn(14, 14, 0, 0, 1, 70, 0, 0, 0, 0, 0, 1, 4, 16, 0, 16, 0, 16, 0);
                yield return new burn(15, 15, 0, 0, 1, 20, 1, 0, 1, 0, 0, 0, 4, 39, 0, 39, 0, 39, 0);
                yield return new burn(16, 16, 0, 0, 0, 10, 1, 0, 1, 0, 0, 1, 4, 23, 1, 34, 0, 34, 0);
                yield return new burn(17, 17, 0, 0, 1, 10, 1, 0, 0, 0, 0, 0, 4, 8, 0, 8, 0, 8, 0);
                yield return new burn(18, 18, 0, 0, 1, 15, 0, 0, 0, 0, 0, 0, 4, 15, 0, 15, 0, 6, 1);
                yield return new burn(19, 19, 0, 0, 1, 10, 0, 0, 0, 0, 0, 1, 4, 8, 0, 8, 0, 8, 0);
                yield return new burn(20, 20, 0, 0, 1, 15, 0, 0, 0, 0, 1, 0, 4, 24, 1, 32, 0, 32, 0);
                yield return new burn(21, 21, 0, 0, 1, 16, 0, 0, 1, 0, 0, 0, 4, 25, 1, 22, 1, 43, 0);
                yield return new burn(22, 22, 0, 1, 1, 55, 1, 0, 1, 1, 0, 0, 4, 14, 1, 3, 1, 56, 0);
                yield return new burn(23, 23, 0, 0, 1, 20, 1, 0, 1, 1, 0, 0, 4, 24, 1, 47, 0, 11, 1);
                yield return new burn(24, 24, 0, 0, 0, 30, 0, 0, 0, 1, 1, 0, 4, 6, 1, 43, 0, 43, 0);
                yield return new burn(25, 25, 0, 0, 1, 40, 0, 1, 0, 1, 1, 0, 1, 25, 0, 3, 1, 25, 0);
                yield return new burn(26, 26, 0, 0, 1, 15, 1, 0, 1, 1, 0, 0, 4, 12, 0, 12, 0, 12, 0);
                yield return new burn(27, 27, 0, 1, 1, 50, 0, 0, 1, 0, 0, 1, 4, 15, 1, 53, 0, 32, 1);
                yield return new burn(28, 28, 0, 0, 1, 40, 1, 0, 1, 1, 0, 0, 4, 18, 1, 52, 0, 51, 1);
                yield return new burn(29, 29, 0, 1, 1, 45, 0, 1, 1, 1, 1, 0, 4, 13, 1, 11, 1, 21, 0);
                yield return new burn(30, 30, 0, 1, 0, 40, 0, 1, 1, 1, 1, 0, 2, 29, 0, 2, 1, 29, 0);
                yield return new burn(31, 31, 0, 0, 1, 28, 0, 0, 1, 0, 0, 0, 2, 7, 0, 7, 0, 3, 1);
                yield return new burn(32, 32, 0, 0, 1, 19, 1, 0, 1, 0, 0, 0, 3, 16, 0, 16, 0, 16, 0);
                yield return new burn(33, 33, 0, 0, 1, 15, 0, 0, 1, 0, 0, 0, 2, 10, 0, 10, 0, 3, 1);
                yield return new burn(34, 34, 0, 0, 1, 5, 0, 0, 1, 0, 1, 0, 3, 6, 0, 6, 0, 4, 1);
                yield return new burn(35, 35, 0, 1, 1, 35, 0, 0, 1, 0, 0, 0, 4, 8, 1, 43, 0, 7, 1);
                yield return new burn(36, 36, 0, 0, 1, 2, 1, 0, 1, 0, 0, 0, 1, 1, 1, 27, 0, 27, 0);
                yield return new burn(37, 37, 0, 1, 1, 5, 0, 0, 1, 0, 0, 0, 2, 18, 0, 18, 0, 18, 0);
                yield return new burn(38, 38, 0, 0, 1, 55, 1, 0, 1, 0, 0, 1, 4, 6, 1, 5, 1, 47, 1);
                yield return new burn(39, 39, 0, 0, 0, 10, 0, 0, 0, 1, 0, 0, 2, 19, 1, 29, 0, 29, 0);
                yield return new burn(40, 40, 0, 0, 1, 15, 0, 0, 1, 0, 0, 0, 4, 5, 0, 5, 0, 5, 0);
                yield return new burn(41, 41, 0, 1, 1, 20, 1, 0, 1, 0, 0, 1, 4, 1, 1, 4, 1, 97, 0);
                yield return new burn(42, 42, 0, 1, 0, 30, 1, 0, 1, 1, 0, 1, 4, 15, 1, 28, 0, 28, 0);
                yield return new burn(43, 43, 0, 0, 1, 25, 1, 1, 1, 1, 0, 1, 4, 14, 1, 4, 1, 7, 1);
                yield return new burn(44, 44, 0, 0, 1, 95, 1, 1, 1, 1, 1, 1, 4, 9, 0, 9, 0, 3, 1);
                yield return new burn(45, 45, 0, 1, 1, 30, 0, 0, 0, 0, 1, 0, 4, 1, 1, 39, 0, 39, 0);
                yield return new burn(46, 46, 0, 0, 1, 15, 1, 0, 1, 0, 0, 0, 4, 10, 0, 10, 0, 10, 0);
                yield return new burn(47, 47, 0, 0, 1, 20, 0, 1, 1, 1, 0, 0, 4, 6, 1, 5, 1, 46, 0);
                yield return new burn(48, 48, 0, 1, 1, 6, 0, 0, 1, 0, 0, 0, 2, 13, 1, 28, 0, 28, 0);
                yield return new burn(49, 49, 0, 0, 1, 15, 0, 0, 1, 0, 0, 1, 4, 11, 1, 21, 0, 21, 0);
                yield return new burn(50, 50, 0, 0, 1, 7, 0, 0, 1, 1, 0, 0, 1, 8, 1, 17, 1, 38, 0);
                yield return new burn(51, 51, 0, 0, 1, 13, 0, 0, 1, 1, 1, 0, 4, 10, 0, 10, 0, 10, 0);
                yield return new burn(52, 52, 0, 0, 1, 25, 1, 0, 1, 0, 0, 1, 4, 6, 1, 40, 0, 5, 1);
                yield return new burn(53, 53, 0, 0, 1, 25, 1, 0, 1, 0, 1, 1, 4, 18, 1, 22, 0, 9, 1);
                yield return new burn(54, 54, 0, 1, 1, 20, 1, 0, 1, 0, 0, 1, 4, 16, 1, 16, 1, 21, 1);
                yield return new burn(55, 55, 0, 1, 1, 25, 0, 0, 1, 1, 0, 0, 4, 7, 1, 26, 0, 26, 0);
                yield return new burn(56, 56, 0, 0, 1, 95, 1, 0, 1, 1, 1, 1, 4, 14, 0, 14, 0, 14, 0);
                yield return new burn(57, 57, 0, 0, 1, 17, 1, 0, 1, 0, 0, 0, 4, 16, 0, 16, 0, 16, 0);
                yield return new burn(58, 58, 0, 0, 1, 3, 0, 0, 1, 0, 1, 0, 3, 4, 0, 4, 0, 1, 1);
                yield return new burn(59, 59, 0, 0, 1, 15, 1, 0, 1, 0, 0, 0, 4, 19, 0, 6, 1, 19, 0);
                yield return new burn(60, 60, 0, 0, 1, 65, 1, 1, 1, 1, 1, 1, 4, 21, 1, 8, 1, 10, 1);
                yield return new burn(61, 61, 0, 1, 1, 15, 1, 0, 1, 1, 1, 1, 4, 18, 0, 18, 0, 18, 0);
                yield return new burn(62, 62, 0, 0, 1, 40, 1, 0, 1, 0, 0, 0, 3, 31, 0, 31, 0, 13, 1);
                yield return new burn(63, 63, 0, 0, 1, 45, 1, 0, 1, 1, 0, 1, 4, 11, 1, 24, 1, 40, 0);
                yield return new burn(64, 64, 0, 1, 0, 35, 0, 0, 1, 1, 0, 0, 4, 4, 1, 5, 1, 47, 0);
                yield return new burn(65, 65, 0, 0, 1, 85, 1, 1, 1, 1, 0, 1, 4, 12, 1, 8, 1, 9, 1);
                yield return new burn(66, 66, 0, 1, 1, 15, 0, 1, 0, 1, 0, 1, 4, 11, 1, 35, 0, 19, 1);
                yield return new burn(67, 67, 0, 0, 1, 70, 0, 1, 1, 1, 1, 0, 2, 23, 1, 8, 1, 60, 0);
                yield return new burn(68, 68, 0, 0, 1, 6, 1, 0, 0, 0, 0, 1, 4, 7, 0, 7, 0, 7, 0);
                yield return new burn(69, 69, 0, 0, 1, 20, 0, 0, 1, 0, 0, 0, 4, 19, 1, 26, 0, 6, 1);
                yield return new burn(70, 70, 0, 1, 1, 36, 1, 0, 1, 0, 1, 1, 4, 16, 1, 20, 1, 23, 1);
                yield return new burn(71, 71, 1, 1, 1, 50, 1, 1, 1, 0, 1, 0, 4, 15, 0, 1, 1, 15, 0);
                yield return new burn(72, 72, 1, 0, 1, 21, 1, 0, 1, 0, 0, 0, 4, 6, 1, 13, 1, 23, 0);
                yield return new burn(73, 73, 1, 0, 1, 16, 1, 0, 1, 0, 0, 0, 4, 2, 1, 9, 0, 9, 0);
                yield return new burn(74, 74, 1, 1, 1, 3, 0, 0, 1, 0, 0, 0, 4, 6, 1, 14, 0, 14, 0);
                yield return new burn(75, 75, 1, 0, 1, 5, 1, 0, 1, 0, 0, 0, 3, 8, 0, 8, 0, 2, 1);
                yield return new burn(76, 76, 1, 0, 1, 32, 0, 1, 1, 1, 0, 1, 4, 18, 1, 51, 0, 18, 1);
                yield return new burn(77, 77, 1, 0, 1, 38, 0, 1, 1, 1, 0, 0, 4, 12, 1, 22, 0, 22, 0);
                yield return new burn(78, 78, 1, 0, 1, 16, 1, 0, 1, 0, 0, 0, 4, 7, 1, 16, 0, 16, 0);
                yield return new burn(79, 79, 1, 1, 1, 9, 0, 1, 0, 1, 0, 0, 4, 6, 1, 2, 1, 2, 1);
                yield return new burn(80, 80, 1, 0, 1, 17, 0, 1, 1, 0, 0, 0, 2, 10, 1, 10, 1, 22, 0);
                yield return new burn(81, 81, 1, 0, 1, 22, 1, 0, 1, 0, 0, 0, 4, 12, 1, 20, 0, 5, 1);
                yield return new burn(82, 82, 1, 0, 1, 10, 0, 0, 1, 0, 0, 0, 4, 5, 1, 5, 1, 14, 0);
                yield return new burn(83, 83, 1, 0, 1, 12, 1, 0, 1, 0, 0, 0, 4, 12, 0, 12, 0, 12, 0);
                yield return new burn(84, 84, 1, 0, 1, 80, 1, 1, 1, 1, 1, 1, 4, 6, 1, 4, 1, 41, 0);
                yield return new burn(85, 85, 1, 1, 1, 15, 0, 0, 1, 1, 0, 0, 4, 9, 1, 9, 1, 21, 0);
                yield return new burn(86, 86, 1, 0, 1, 50, 1, 0, 1, 0, 0, 1, 4, 18, 1, 7, 1, 56, 0);
                yield return new burn(87, 87, 1, 0, 1, 50, 1, 1, 1, 1, 1, 1, 4, 7, 1, 42, 1, 67, 0);
                yield return new burn(88, 88, 1, 0, 1, 15, 1, 0, 1, 0, 0, 0, 3, 11, 0, 11, 0, 11, 0);
                yield return new burn(89, 89, 1, 0, 1, 8, 1, 0, 1, 0, 0, 0, 4, 9, 1, 17, 0, 17, 0);
                yield return new burn(90, 90, 1, 1, 1, 45, 1, 1, 1, 1, 0, 0, 1, 11, 1, 11, 1, 18, 1);
                yield return new burn(91, 91, 1, 0, 1, 20, 0, 1, 1, 1, 0, 1, 4, 6, 1, 6, 1, 14, 1);
                yield return new burn(92, 92, 1, 0, 1, 5, 0, 0, 1, 0, 1, 0, 3, 4, 1, 8, 0, 5, 1);
                yield return new burn(93, 93, 1, 0, 1, 25, 0, 0, 1, 0, 0, 0, 2, 5, 1, 10, 0, 5, 1);
                yield return new burn(94, 94, 1, 0, 1, 40, 0, 1, 1, 1, 0, 0, 4, 11, 1, 8, 1, 31, 0);
                yield return new burn(95, 95, 1, 0, 1, 4, 0, 0, 1, 0, 1, 0, 3, 9, 1, 7, 1, 23, 0);
                yield return new burn(96, 96, 1, 0, 1, 25, 0, 0, 1, 1, 0, 1, 4, 4, 1, 14, 1, 46, 0);
                yield return new burn(97, 97, 1, 1, 1, 20, 0, 0, 1, 0, 1, 0, 4, 5, 1, 1, 1, 38, 0);
                yield return new burn(98, 98, 1, 1, 1, 26, 0, 0, 1, 0, 0, 1, 4, 8, 1, 3, 1, 35, 0);
                yield return new burn(99, 99, 1, 0, 1, 10, 0, 1, 1, 1, 0, 0, 4, 13, 1, 21, 0, 21, 0);
                yield return new burn(100, 100, 1, 1, 1, 85, 1, 1, 1, 1, 0, 1, 4, 11, 0, 3, 1, 11, 0);
                yield return new burn(101, 101, 1, 0, 1, 75, 1, 0, 1, 1, 1, 0, 4, 29, 1, 49, 0, 16, 1);
                yield return new burn(102, 102, 1, 0, 0, 5, 0, 0, 1, 0, 1, 0, 1, 13, 0, 13, 0, 13, 0);
                yield return new burn(103, 103, 1, 0, 1, 20, 1, 0, 1, 0, 0, 0, 4, 1, 1, 12, 0, 12, 0);
                yield return new burn(104, 104, 1, 1, 1, 8, 0, 1, 0, 1, 1, 0, 4, 6, 1, 6, 1, 13, 0);
                yield return new burn(105, 105, 1, 1, 1, 10, 0, 0, 1, 0, 0, 1, 4, 6, 1, 23, 0, 23, 0);
                yield return new burn(106, 106, 1, 0, 1, 10, 0, 0, 0, 0, 1, 1, 4, 3, 1, 31, 0, 31, 0);
                yield return new burn(107, 107, 1, 1, 0, 2, 0, 0, 1, 0, 0, 0, 1, 2, 1, 2, 1, 10, 0);
                yield return new burn(108, 108, 1, 0, 0, 5, 0, 0, 0, 0, 1, 0, 2, 4, 1, 4, 1, 17, 0);
                yield return new burn(109, 109, 1, 0, 1, 10, 1, 0, 0, 0, 1, 0, 4, 5, 1, 18, 0, 18, 0);
                yield return new burn(110, 110, 1, 0, 1, 18, 0, 0, 1, 1, 1, 0, 4, 6, 1, 5, 1, 33, 0);
                yield return new burn(111, 111, 1, 0, 1, 20, 1, 0, 1, 1, 0, 0, 4, 9, 1, 8, 1, 17, 0);
                yield return new burn(112, 112, 1, 0, 1, 80, 1, 1, 1, 1, 1, 1, 4, 4, 1, 11, 1, 13, 0);
                yield return new burn(113, 113, 1, 0, 0, 17, 1, 0, 1, 1, 1, 1, 4, 5, 1, 4, 1, 35, 0);
                yield return new burn(114, 114, 1, 0, 0, 35, 1, 0, 1, 0, 0, 0, 4, 7, 1, 7, 1, 71, 0);
                yield return new burn(115, 115, 1, 0, 1, 50, 1, 0, 1, 0, 1, 1, 4, 11, 0, 11, 0, 3, 1);
                yield return new burn(116, 116, 1, 0, 0, 20, 0, 0, 1, 0, 0, 0, 4, 6, 1, 31, 1, 42, 1);
                yield return new burn(117, 117, 1, 0, 1, 25, 0, 1, 1, 1, 0, 0, 3, 8, 0, 8, 0, 5, 1);
                yield return new burn(118, 118, 1, 0, 1, 20, 0, 0, 0, 1, 0, 1, 1, 3, 1, 2, 1, 30, 0);
                yield return new burn(119, 119, 1, 0, 1, 20, 0, 0, 1, 1, 0, 0, 4, 6, 1, 38, 0, 38, 0);
                yield return new burn(120, 120, 1, 0, 1, 10, 1, 0, 1, 0, 0, 0, 4, 16, 0, 16, 0, 16, 0);
                yield return new burn(121, 121, 1, 0, 0, 15, 1, 0, 1, 0, 0, 0, 2, 20, 0, 20, 0, 20, 0);
                yield return new burn(122, 122, 1, 0, 1, 15, 0, 0, 1, 0, 1, 0, 4, 30, 0, 2, 1, 30, 0);
                yield return new burn(123, 123, 1, 0, 1, 15, 0, 0, 1, 0, 0, 0, 4, 2, 1, 7, 0, 7, 0);
                yield return new burn(124, 124, 1, 0, 1, 20, 0, 0, 1, 1, 0, 0, 2, 8, 1, 6, 1, 22, 0);
                yield return new burn(125, 125, 1, 0, 1, 13, 1, 0, 1, 0, 0, 0, 4, 13, 0, 4, 1, 5, 1);
                yield return new burn(126, 126, 1, 0, 1, 25, 1, 0, 1, 0, 0, 1, 4, 13, 1, 1, 1, 31, 0);
                yield return new burn(127, 127, 1, 0, 1, 25, 0, 0, 1, 1, 0, 1, 4, 17, 0, 17, 0, 10, 1);
                yield return new burn(128, 128, 1, 0, 1, 8, 1, 0, 1, 0, 0, 0, 4, 14, 0, 14, 0, 14, 0);
                yield return new burn(129, 129, 1, 1, 1, 30, 1, 0, 1, 0, 0, 1, 4, 13, 0, 5, 1, 13, 0);
                yield return new burn(130, 130, 1, 0, 1, 40, 0, 1, 1, 1, 1, 0, 4, 24, 0, 7, 1, 17, 1);
                yield return new burn(131, 131, 1, 1, 1, 12, 0, 1, 1, 1, 1, 0, 1, 14, 1, 21, 0, 21, 0);
                yield return new burn(132, 132, 1, 0, 1, 15, 0, 0, 1, 0, 0, 0, 4, 8, 1, 19, 1, 25, 0);
                yield return new burn(133, 133, 1, 0, 1, 25, 1, 0, 1, 0, 0, 0, 4, 23, 0, 23, 0, 8, 1);
                yield return new burn(134, 134, 1, 0, 1, 15, 0, 0, 1, 0, 0, 0, 4, 17, 1, 17, 0, 11, 1);
                yield return new burn(135, 135, 1, 0, 0, 20, 0, 0, 1, 1, 1, 0, 4, 19, 1, 31, 0, 31, 0);
                yield return new burn(136, 136, 1, 0, 1, 22, 0, 1, 1, 0, 0, 0, 4, 14, 1, 20, 0, 20, 0);
                yield return new burn(137, 137, 1, 0, 1, 15, 1, 0, 1, 0, 1, 0, 4, 15, 1, 22, 0, 22, 0);
                yield return new burn(138, 138, 1, 0, 1, 7, 1, 0, 1, 0, 0, 0, 3, 13, 0, 3, 1, 13, 0);
                yield return new burn(139, 139, 1, 0, 1, 30, 0, 1, 1, 1, 1, 0, 2, 49, 0, 49, 0, 4, 1);
                yield return new burn(140, 140, 1, 0, 1, 20, 1, 0, 1, 0, 0, 1, 4, 14, 0, 10, 1, 14, 0);
                yield return new burn(141, 141, 1, 1, 1, 35, 1, 0, 1, 0, 0, 1, 4, 6, 1, 5, 1, 49, 0);
                yield return new burn(142, 142, 1, 0, 0, 10, 0, 0, 1, 0, 0, 0, 4, 12, 0, 12, 0, 12, 0);
                yield return new burn(143, 143, 1, 0, 1, 8, 0, 0, 1, 0, 1, 0, 3, 14, 0, 1, 1, 14, 0);
                yield return new burn(144, 144, 1, 0, 1, 13, 0, 0, 0, 0, 1, 0, 4, 32, 1, 38, 0, 38, 0);
                yield return new burn(145, 145, 1, 1, 0, 10, 0, 1, 1, 1, 0, 0, 2, 12, 1, 13, 1, 41, 0);
                yield return new burn(146, 146, 1, 0, 1, 8, 0, 0, 0, 1, 1, 0, 4, 10, 1, 18, 0, 18, 0);
                yield return new burn(147, 147, 1, 0, 1, 7, 1, 0, 1, 0, 0, 0, 4, 8, 0, 8, 0, 8, 0);
                yield return new burn(148, 148, 1, 0, 1, 52, 1, 0, 1, 1, 1, 1, 4, 15, 1, 39, 1, 76, 0);
                yield return new burn(149, 149, 1, 1, 1, 14, 0, 1, 1, 1, 1, 0, 4, 8, 1, 62, 0, 62, 0);
                yield return new burn(150, 150, 1, 1, 1, 7, 0, 0, 1, 0, 0, 0, 1, 5, 1, 17, 0, 17, 0);
                yield return new burn(151, 151, 1, 1, 1, 20, 1, 0, 1, 0, 0, 0, 4, 7, 1, 6, 1, 17, 1);
                yield return new burn(152, 152, 1, 0, 1, 15, 0, 0, 0, 1, 1, 1, 4, 19, 1, 3, 1, 42, 0);
                yield return new burn(153, 153, 1, 0, 1, 10, 0, 0, 1, 0, 0, 0, 4, 10, 0, 10, 0, 2, 1);
                yield return new burn(154, 154, 1, 0, 1, 35, 1, 1, 1, 0, 0, 0, 4, 10, 1, 27, 0, 27, 0);
            }
        }
    }
}
