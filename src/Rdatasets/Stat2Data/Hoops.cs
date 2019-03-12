// ReSharper disable All

namespace Rdatasets.Stat2Data
{
    using System.Collections.Generic;

    /// <summary>
    /// Hoops
    /// </summary>

    public class Hoops
    {
        public readonly int κ;
        public readonly int Game;
        public readonly string Opp;
        public readonly int Home;
        public readonly int OppAtt;
        public readonly int GrAtt;
        public readonly int Gr3Att;
        public readonly int GrFT;
        public readonly int OppFT;
        public readonly int GrRB;
        public readonly int GrOR;
        public readonly int OppDR;
        public readonly int OppPoint;
        public readonly int GrPoint;
        public readonly int GrAss;
        public readonly int OppTO;
        public readonly int GrTO;
        public readonly int GrBlocks;
        public readonly int GrSteal;
        public readonly int? X40Point;
        public readonly int X30Point;
        public readonly int WinLoss;
        public readonly int PtDiff;

        public Hoops(int κ, int Game, string Opp, int Home, int OppAtt, int GrAtt, int Gr3Att, int GrFT, int OppFT, int GrRB, int GrOR, int OppDR, int OppPoint, int GrPoint, int GrAss, int OppTO, int GrTO, int GrBlocks, int GrSteal, int? X40Point, int X30Point, int WinLoss, int PtDiff)
        {
            this.κ = κ;
            this.Game = Game;
            this.Opp = Opp;
            this.Home = Home;
            this.OppAtt = OppAtt;
            this.GrAtt = GrAtt;
            this.Gr3Att = Gr3Att;
            this.GrFT = GrFT;
            this.OppFT = OppFT;
            this.GrRB = GrRB;
            this.GrOR = GrOR;
            this.OppDR = OppDR;
            this.OppPoint = OppPoint;
            this.GrPoint = GrPoint;
            this.GrAss = GrAss;
            this.OppTO = OppTO;
            this.GrTO = GrTO;
            this.GrBlocks = GrBlocks;
            this.GrSteal = GrSteal;
            this.X40Point = X40Point;
            this.X30Point = X30Point;
            this.WinLoss = WinLoss;
            this.PtDiff = PtDiff;
        }

        public static IEnumerable<Hoops> Data
        {
            get
            {
                yield return new Hoops(1, 1, "Ripon", 1, 67, 89, 56, 13, 38, 40, 24, 29, 119, 107, 24, 28, 33, 2, 23, 0, 1, -1, -12);
                yield return new Hoops(2, 2, "Beloit", 1, 77, 93, 45, 54, 50, 45, 28, 28, 135, 142, 15, 35, 22, 1, 24, 0, 0, 1, 7);
                yield return new Hoops(3, 3, "Lake Forest", 0, 37, 68, 20, 34, 44, 25, 16, 35, 98, 83, 2, 35, 19, 0, 4, 0, 0, -1, -15);
                yield return new Hoops(4, 4, "Carroll", 0, 63, 89, 71, 37, 57, 49, 27, 27, 116, 112, 20, 28, 28, 1, 13, 0, 0, -1, -4);
                yield return new Hoops(5, 5, "Monmouth", 1, 52, 84, 46, 26, 40, 30, 22, 29, 109, 107, 17, 30, 15, 0, 21, 0, 0, -1, -2);
                yield return new Hoops(6, 6, "Knox", 1, 56, 97, 56, 16, 50, 41, 24, 46, 99, 85, 17, 31, 17, 2, 18, 0, 1, -1, -14);
                yield return new Hoops(7, 7, "Illinois College", 0, 73, 80, 41, 31, 50, 38, 15, 37, 104, 100, 12, 30, 25, 3, 21, 0, 1, -1, -4);
                yield return new Hoops(8, 8, "Lake Forest", 1, 59, 63, 38, 41, 27, 46, 19, 26, 78, 97, 8, 18, 16, 2, 8, 0, 1, 1, 19);
                yield return new Hoops(9, 9, "St. Norbert", 1, 56, 56, 34, 30, 34, 33, 10, 27, 72, 85, 13, 24, 23, 3, 11, 0, 1, 1, 13);
                yield return new Hoops(10, 10, "Knox", 0, 71, 86, 52, 10, 23, 51, 25, 36, 85, 71, 10, 13, 14, 0, 8, 0, 1, -1, -14);
                yield return new Hoops(11, 11, "Monmouth", 0, 65, 98, 76, 11, 26, 61, 37, 27, 73, 104, 8, 23, 21, 0, 9, 0, 0, 1, 31);
                yield return new Hoops(12, 12, "Illinois College", 1, 86, 121, 69, 32, 32, 46, 29, 44, 144, 149, 23, 32, 17, 6, 27, 1, 1, 1, 5);
                yield return new Hoops(13, 13, "Lawrence", 0, 72, 105, 74, 17, 39, 37, 17, 41, 127, 116, 12, 23, 20, 3, 10, 1, 1, -1, -11);
                yield return new Hoops(14, 14, "Illinois College", 1, 73, 95, 56, 28, 24, 47, 27, 31, 109, 111, 21, 40, 21, 6, 23, 0, 1, 1, 2);
                yield return new Hoops(15, 15, "Knox", 1, 73, 79, 46, 17, 21, 35, 15, 31, 98, 97, 22, 24, 20, 5, 16, 0, 1, -1, -1);
                yield return new Hoops(16, 16, "Beloit", 1, 65, 80, 54, 38, 36, 36, 19, 36, 106, 114, 22, 43, 26, 3, 27, 0, 1, 1, 8);
                yield return new Hoops(17, 17, "Monmouth", 0, 68, 103, 65, 29, 36, 45, 28, 41, 140, 107, 18, 23, 16, 0, 8, 0, 0, -1, -33);
                yield return new Hoops(18, 18, "Illinois College", 0, 84, 108, 71, 38, 66, 51, 28, 46, 140, 136, 10, 28, 17, 2, 14, 0, 1, -1, -4);
                yield return new Hoops(19, 19, "Beloit", 0, 69, 92, 56, 18, 24, 34, 15, 42, 105, 97, 9, 31, 14, 3, 21, 0, 0, -1, -8);
                yield return new Hoops(20, 20, "Ripon", 0, 76, 99, 74, 32, 54, 38, 22, 45, 143, 118, 17, 27, 25, 1, 10, 0, 0, -1, -25);
                yield return new Hoops(21, 21, "St. Norbert", 1, 76, 83, 52, 24, 24, 31, 16, 31, 130, 123, 23, 25, 21, 2, 15, 0, 0, -1, -7);
                yield return new Hoops(22, 22, "Carroll", 1, 75, 86, 68, 42, 23, 36, 21, 35, 126, 129, 24, 28, 22, 4, 11, 1, 1, 1, 3);
                yield return new Hoops(23, 23, "St. Norbert", 0, 62, 89, 55, 26, 38, 40, 25, 38, 119, 95, 19, 32, 24, 2, 11, 0, 0, -1, -24);
                yield return new Hoops(24, 24, "Lawrence", 0, 62, 99, 74, 11, 31, 40, 26, 45, 113, 83, 17, 42, 32, 0, 24, 0, 0, -1, -30);
                yield return new Hoops(25, 25, "Ripon", 1, 60, 79, 59, 16, 35, 31, 15, 31, 110, 107, 23, 23, 20, 6, 13, 1, 1, -1, -3);
                yield return new Hoops(26, 26, "Monmouth", 1, 69, 86, 48, 52, 38, 40, 20, 40, 115, 125, 21, 35, 16, 2, 19, 0, 0, 1, 10);
                yield return new Hoops(27, 27, "Lake Forest", 0, 44, 71, 59, 22, 33, 27, 12, 38, 77, 85, 18, 33, 21, 3, 16, 0, 0, 1, 8);
                yield return new Hoops(28, 28, "Knox", 0, 45, 81, 56, 25, 58, 43, 24, 30, 98, 97, 20, 29, 21, 3, 17, 0, 1, -1, -1);
                yield return new Hoops(29, 29, "Lake Forest", 1, 63, 91, 64, 28, 18, 36, 20, 41, 93, 104, 20, 33, 13, 5, 9, 1, 1, 1, 11);
                yield return new Hoops(30, 30, "Knox", 1, 68, 73, 45, 34, 27, 23, 11, 35, 124, 106, 17, 23, 20, 0, 15, 0, 1, -1, -18);
                yield return new Hoops(31, 31, "Beloit", 0, 54, 78, 54, 15, 27, 27, 14, 27, 98, 101, 12, 28, 20, 1, 9, 0, 1, 1, 3);
                yield return new Hoops(32, 32, "Illinois College", 1, 80, 81, 62, 36, 31, 36, 23, 33, 147, 104, 18, 21, 30, 1, 7, 0, 0, -1, -43);
                yield return new Hoops(33, 33, "Illinois College", 0, 58, 74, 35, 14, 21, 35, 21, 24, 97, 82, 17, 15, 11, 0, 4, 0, 0, -1, -15);
                yield return new Hoops(34, 34, "Monmouth", 0, 50, 49, 23, 16, 16, 34, 12, 17, 63, 60, 10, 6, 10, 3, 4, 0, 0, -1, -3);
                yield return new Hoops(35, 35, "Beloit", 1, 56, 68, 37, 43, 26, 32, 13, 28, 93, 111, 23, 24, 8, 2, 14, 1, 1, 1, 18);
                yield return new Hoops(36, 36, "Ripon", 1, 56, 77, 52, 14, 24, 39, 21, 34, 99, 74, 19, 16, 17, 1, 12, 0, 0, -1, -25);
                yield return new Hoops(37, 37, "St. Norbert", 0, 47, 72, 43, 6, 32, 25, 14, 28, 87, 79, 17, 20, 14, 0, 15, 0, 0, -1, -8);
                yield return new Hoops(38, 38, "Carroll", 0, 61, 83, 55, 36, 37, 30, 17, 37, 119, 92, 17, 29, 12, 1, 17, 0, 0, -1, -27);
                yield return new Hoops(39, 39, "St. Norbert", 1, 49, 95, 65, 40, 61, 32, 22, 39, 137, 126, 23, 39, 23, 0, 24, 0, 0, -1, -11);
                yield return new Hoops(40, 40, "Lawrence", 1, 68, 80, 55, 44, 41, 34, 17, 37, 129, 114, 22, 27, 19, 3, 19, 0, 0, -1, -15);
                yield return new Hoops(41, 41, "Ripon", 0, 61, 73, 53, 20, 26, 29, 14, 45, 99, 55, 10, 27, 23, 1, 16, 0, 0, -1, -44);
                yield return new Hoops(42, 42, "Monmouth", 1, 70, 110, 64, 35, 49, 33, 22, 43, 145, 150, 24, 37, 14, 0, 22, 0, 0, 1, 5);
                yield return new Hoops(43, 43, "Lake Forest", 1, 47, 102, 57, 24, 47, 41, 27, 46, 94, 91, 10, 45, 14, 1, 23, 0, 0, -1, -3);
                yield return new Hoops(44, 44, "Knox", 0, 54, 64, 36, 20, 36, 36, 19, 26, 84, 68, 10, 19, 21, 2, 11, 0, 0, -1, -16);
                yield return new Hoops(45, 45, "Lake Forest", 0, 57, 95, 51, 23, 44, 27, 16, 45, 133, 110, 15, 33, 21, 1, 19, 0, 0, -1, -23);
                yield return new Hoops(46, 46, "Knox", 1, 61, 70, 35, 24, 32, 33, 10, 27, 84, 105, 25, 24, 18, 2, 17, 0, 0, 1, 21);
                yield return new Hoops(47, 47, "Illinois College", 1, 64, 86, 48, 39, 16, 45, 28, 28, 93, 123, 29, 35, 22, 4, 17, 0, 0, 1, 30);
                yield return new Hoops(48, 48, "Carroll", 0, 72, 111, 69, 31, 52, 38, 22, 56, 139, 117, 21, 30, 14, 8, 18, 0, 0, -1, -22);
                yield return new Hoops(49, 49, "Lawrence", 0, 62, 108, 70, 25, 60, 41, 24, 52, 131, 104, 16, 29, 14, 1, 20, 0, 0, -1, -27);
                yield return new Hoops(50, 50, "Beloit", 1, 70, 90, 47, 30, 40, 33, 22, 32, 125, 126, 23, 23, 12, 2, 14, 0, 0, 1, 1);
                yield return new Hoops(51, 51, "St. Norbert", 1, 65, 74, 48, 37, 22, 29, 15, 27, 104, 119, 17, 24, 11, 4, 12, 0, 0, 1, 15);
                yield return new Hoops(52, 52, "Monmouth", 1, 68, 99, 51, 48, 39, 45, 20, 39, 118, 133, 23, 32, 15, 2, 21, 0, 1, 1, 15);
                yield return new Hoops(53, 53, "Ripon", 0, 60, 88, 49, 18, 31, 34, 14, 36, 103, 100, 23, 22, 14, 0, 8, 0, 0, -1, -3);
                yield return new Hoops(54, 54, "Beloit", 0, 51, 75, 33, 39, 40, 23, 14, 30, 112, 113, 14, 30, 13, 0, 20, 0, 0, 1, 1);
                yield return new Hoops(55, 55, "Knox", 0, 56, 85, 47, 30, 39, 44, 26, 31, 87, 95, 14, 24, 14, 0, 20, 0, 0, 1, 8);
                yield return new Hoops(56, 56, "Lawrence", 1, 64, 87, 41, 47, 40, 41, 21, 34, 126, 127, 22, 29, 18, 2, 12, 0, 0, 1, 1);
                yield return new Hoops(57, 57, "Carroll", 1, 50, 97, 56, 25, 39, 42, 23, 33, 83, 124, 24, 36, 11, 4, 24, 0, 0, 1, 41);
                yield return new Hoops(58, 58, "Lake Forest", 1, 62, 91, 44, 38, 24, 42, 30, 37, 93, 99, 15, 32, 10, 10, 22, 0, 0, 1, 6);
                yield return new Hoops(59, 59, "Monmouth", 0, 66, 107, 78, 32, 37, 51, 30, 46, 108, 118, 18, 32, 11, 1, 16, 0, 0, 1, 10);
                yield return new Hoops(60, 60, "Illinois College", 0, 68, 94, 69, 42, 57, 39, 20, 43, 121, 125, 27, 21, 11, 2, 13, 0, 0, 1, 4);
                yield return new Hoops(61, 61, "Beloit", 1, 63, 77, 38, 47, 44, 34, 15, 33, 109, 120, 18, 29, 14, 4, 14, 0, 0, 1, 11);
                yield return new Hoops(62, 62, "Illinois College", 1, 72, 95, 64, 37, 41, 37, 16, 42, 122, 130, 28, 19, 5, 3, 11, 0, 0, 1, 8);
                yield return new Hoops(63, 63, "Lake Forest", 1, 76, 114, 43, 33, 33, 40, 24, 44, 140, 135, 12, 28, 9, 1, 18, 0, 1, -1, -5);
                yield return new Hoops(64, 64, "Illinois College", 1, 80, 95, 57, 26, 35, 45, 19, 36, 130, 124, 28, 15, 15, 3, 9, 0, 0, -1, -6);
                yield return new Hoops(65, 65, "Monmouth", 0, 64, 105, 62, 38, 48, 51, 30, 40, 131, 124, 19, 33, 23, 2, 20, 0, 1, -1, -7);
                yield return new Hoops(66, 66, "Carroll", 1, 71, 108, 79, 23, 15, 52, 21, 33, 85, 143, 28, 34, 13, 5, 21, 0, 1, 1, 58);
                yield return new Hoops(67, 67, "Lawrence", 1, 71, 92, 42, 20, 29, 44, 12, 39, 89, 128, 25, 28, 15, 0, 15, 0, 0, 1, 39);
                yield return new Hoops(68, 68, "Knox", 0, 58, 92, 37, 16, 32, 41, 21, 27, 108, 110, 22, 19, 11, 1, 9, 0, 0, 1, 2);
                yield return new Hoops(69, 69, "Beloit", 0, 59, 89, 50, 21, 47, 44, 23, 32, 113, 106, 13, 24, 20, 1, 13, 0, 0, -1, -7);
                yield return new Hoops(70, 70, "St. Norbert", 0, 63, 92, 62, 27, 44, 39, 21, 46, 117, 94, 14, 33, 22, 0, 14, 0, 0, -1, -23);
                yield return new Hoops(71, 71, "Ripon", 1, 72, 102, 62, 27, 48, 45, 17, 40, 123, 135, 27, 25, 9, 1, 14, 0, 1, 1, 12);
                yield return new Hoops(72, 72, "Beloit", 1, 69, 85, 53, 60, 58, 33, 8, 46, 126, 139, 16, 25, 5, 1, 11, 1, 1, 1, 13);
                yield return new Hoops(73, 73, "Lawrence", 0, 59, 89, 51, 18, 42, 26, 17, 38, 128, 110, 22, 28, 21, 1, 20, 0, 0, -1, -18);
                yield return new Hoops(74, 74, "Carroll", 0, 78, 97, 67, 22, 30, 40, 19, 31, 122, 143, 29, 28, 17, 3, 13, 0, 1, 1, 21);
                yield return new Hoops(75, 75, "Monmouth", 1, 75, 97, 63, 29, 26, 34, 14, 38, 121, 135, 30, 31, 12, 1, 16, 0, 0, 1, 14);
                yield return new Hoops(76, 76, "Illinois College", 0, 67, 97, 63, 20, 48, 38, 16, 48, 113, 107, 22, 22, 8, 2, 13, 0, 0, -1, -6);
                yield return new Hoops(77, 77, "Knox", 1, 68, 104, 67, 16, 16, 49, 24, 31, 91, 130, 24, 26, 8, 3, 18, 0, 0, 1, 39);
                yield return new Hoops(78, 78, "Lake Forest", 0, 67, 79, 46, 37, 20, 34, 13, 37, 93, 111, 13, 28, 11, 2, 17, 0, 1, 1, 18);
                yield return new Hoops(79, 79, "St. Norbert", 0, 56, 86, 57, 31, 55, 32, 15, 40, 125, 114, 11, 30, 22, 0, 17, 0, 1, -1, -11);
                yield return new Hoops(80, 80, "Lake Forest", 0, 64, 90, 51, 19, 37, 41, 22, 26, 114, 127, 18, 20, 16, 2, 12, 0, 1, 1, 13);
                yield return new Hoops(81, 81, "Knox", 1, 63, 81, 54, 33, 19, 43, 23, 32, 88, 108, 18, 28, 17, 1, 7, 0, 1, 1, 20);
                yield return new Hoops(82, 82, "Illinois College", 0, 71, 85, 43, 13, 27, 38, 20, 26, 114, 106, 20, 17, 15, 2, 11, 0, 0, -1, -8);
                yield return new Hoops(83, 83, "Ripon", 0, 64, 114, 82, 32, 67, 53, 35, 46, 137, 130, 24, 22, 14, 2, 17, 0, 0, -1, -7);
                yield return new Hoops(84, 84, "St. Norbert", 0, 56, 85, 57, 35, 44, 34, 18, 33, 114, 124, 20, 29, 17, 1, 18, 0, 1, 1, 10);
                yield return new Hoops(85, 85, "Carroll", 1, 82, 112, 62, 41, 42, 59, 37, 39, 125, 133, 25, 24, 12, 4, 14, 0, 1, 1, 8);
                yield return new Hoops(86, 86, "Lawrence", 1, 86, 126, 74, 37, 52, 45, 29, 51, 149, 150, 19, 31, 13, 8, 18, 1, 1, 1, 1);
                yield return new Hoops(87, 87, "Beloit", 0, 68, 102, 66, 23, 46, 43, 22, 46, 120, 108, 18, 28, 15, 4, 13, 0, 1, -1, -12);
                yield return new Hoops(88, 88, "Carroll", 0, 82, 98, 75, 32, 33, 52, 27, 32, 128, 143, 25, 17, 13, 2, 8, 0, 1, 1, 15);
                yield return new Hoops(89, 89, "Monmouth", 0, 72, 101, 53, 34, 18, 49, 28, 31, 102, 141, 26, 37, 18, 4, 29, 0, 0, 1, 39);
                yield return new Hoops(90, 90, "St. Norbert", 1, 67, 106, 62, 28, 23, 42, 26, 43, 106, 118, 16, 31, 13, 4, 22, 0, 1, 1, 12);
                yield return new Hoops(91, 91, "Ripon", 1, 91, 92, 67, 46, 21, 52, 25, 33, 125, 139, 19, 16, 16, 1, 11, 0, 1, 1, 14);
                yield return new Hoops(92, 92, "Knox", 0, 55, 76, 53, 18, 13, 25, 14, 26, 80, 93, 15, 17, 5, 2, 9, 0, 0, 1, 13);
                yield return new Hoops(93, 93, "Lake Forest", 1, 54, 78, 44, 22, 20, 35, 21, 29, 85, 94, 14, 28, 14, 3, 10, 0, 0, 1, 9);
                yield return new Hoops(94, 94, "Monmouth", 1, 71, 99, 67, 23, 17, 32, 19, 40, 118, 129, 31, 35, 16, 5, 21, null, 0, 1, 11);
                yield return new Hoops(95, 95, "Illinois College", 1, 69, 85, 42, 47, 25, 41, 23, 34, 98, 118, 17, 24, 10, 4, 10, 0, 1, 1, 20);
                yield return new Hoops(96, 96, "Ripon", 1, 77, 75, 52, 38, 23, 40, 18, 32, 107, 112, 16, 25, 21, 3, 13, 0, 0, 1, 5);
                yield return new Hoops(97, 97, "Illinois College", 1, 61, 96, 62, 26, 31, 43, 25, 46, 101, 91, 15, 28, 11, 3, 10, 0, 0, -1, -10);
                yield return new Hoops(98, 98, "Lake Forest", 1, 57, 79, 37, 27, 27, 33, 15, 25, 103, 119, 19, 24, 10, 1, 12, 0, 1, 1, 16);
                yield return new Hoops(99, 99, "Illinois College", 1, 66, 99, 56, 21, 21, 40, 19, 34, 92, 141, 33, 29, 7, 1, 16, 0, 0, 1, 49);
                yield return new Hoops(100, 100, "Monmouth", 0, 88, 99, 53, 29, 25, 43, 20, 31, 136, 147, 19, 25, 14, 1, 16, 1, 1, 1, 11);
                yield return new Hoops(101, 101, "Ripon", 1, 79, 100, 70, 35, 27, 49, 26, 40, 120, 122, 21, 25, 14, 3, 15, 0, 0, 1, 2);
                yield return new Hoops(102, 102, "St. Norbert", 1, 75, 104, 77, 31, 26, 59, 37, 37, 111, 114, 20, 24, 14, 4, 12, 0, 0, 1, 3);
                yield return new Hoops(103, 103, "Knox", 0, 55, 74, 44, 25, 21, 32, 15, 32, 86, 98, 15, 24, 7, 3, 16, 0, 0, 1, 12);
                yield return new Hoops(104, 104, "Carroll", 0, 78, 98, 69, 36, 33, 50, 26, 35, 134, 129, 22, 17, 12, 3, 10, 0, 0, -1, -5);
                yield return new Hoops(105, 105, "Lawrence", 0, 70, 91, 58, 22, 35, 33, 18, 38, 125, 111, 7, 17, 13, 5, 12, 0, 1, -1, -14);
                yield return new Hoops(106, 106, "Beloit", 1, 86, 109, 57, 47, 32, 51, 29, 35, 138, 155, 17, 23, 14, 5, 11, 1, 1, 1, 17);
                yield return new Hoops(107, 107, "Carroll", 1, 98, 118, 80, 37, 19, 71, 42, 39, 133, 138, 23, 20, 13, 4, 9, 1, 1, 1, 5);
                yield return new Hoops(108, 108, "Monmouth", 1, 70, 117, 84, 38, 23, 64, 36, 38, 76, 152, 22, 36, 10, 5, 20, 1, 1, 1, 76);
                yield return new Hoops(109, 109, "St. Norbert", 0, 77, 95, 61, 22, 17, 50, 29, 30, 114, 113, 22, 18, 21, 7, 12, 0, 0, -1, -1);
                yield return new Hoops(110, 110, "Ripon", 0, 84, 95, 71, 26, 19, 50, 30, 44, 129, 87, 17, 13, 18, 2, 8, 0, 0, -1, -42);
                yield return new Hoops(111, 111, "Knox", 1, 62, 91, 59, 22, 20, 42, 27, 30, 105, 108, 15, 30, 18, 3, 19, 0, 1, 1, 3);
                yield return new Hoops(112, 112, "Lake Forest", 0, 57, 97, 73, 11, 21, 41, 29, 39, 109, 88, 13, 21, 12, 2, 14, 0, 0, -1, -21);
                yield return new Hoops(113, 113, "Illinois College", 0, 74, 102, 72, 31, 39, 44, 28, 37, 114, 127, 25, 21, 9, 3, 11, 0, 0, 1, 13);
                yield return new Hoops(114, 114, "Carroll", 0, 77, 104, 78, 11, 37, 43, 23, 39, 143, 127, 26, 11, 12, 1, 8, 0, 1, -1, -16);
                yield return new Hoops(115, 115, "Illinois College", 0, 74, 90, 53, 33, 23, 38, 20, 34, 114, 126, 23, 27, 12, 2, 19, 0, 0, 1, 12);
                yield return new Hoops(116, 116, "Knox", 0, 47, 87, 54, 16, 29, 41, 32, 28, 100, 86, 16, 33, 27, 1, 18, 0, 0, -1, -14);
                yield return new Hoops(117, 117, "Lake Forest", 0, 52, 85, 53, 13, 30, 28, 18, 32, 106, 99, 16, 23, 13, 0, 17, 0, 0, -1, -7);
                yield return new Hoops(118, 118, "Monmouth", 0, 71, 108, 65, 26, 37, 54, 31, 45, 116, 109, 16, 28, 17, 4, 13, 0, 0, -1, -7);
                yield return new Hoops(119, 119, "Beloit", 0, 70, 83, 40, 30, 31, 28, 15, 32, 118, 116, 16, 26, 14, 6, 11, 0, 0, -1, -2);
                yield return new Hoops(120, 120, "Ripon", 0, 71, 86, 65, 22, 38, 31, 20, 30, 129, 106, 29, 15, 19, 1, 11, 0, 0, -1, -23);
                yield return new Hoops(121, 121, "Lawrence", 1, 65, 86, 63, 24, 22, 32, 16, 38, 112, 85, 12, 25, 16, 2, 14, 0, 0, -1, -27);
                yield return new Hoops(122, 122, "St. Norbert", 1, 64, 88, 61, 36, 45, 47, 27, 28, 130, 121, 20, 29, 31, 2, 8, 0, 1, -1, -9);
                yield return new Hoops(123, 123, "Carroll", 0, 75, 81, 50, 18, 34, 25, 14, 27, 133, 111, 17, 24, 25, 5, 12, 0, 0, -1, -22);
                yield return new Hoops(124, 124, "Lawrence", 0, 62, 73, 47, 7, 32, 27, 10, 30, 104, 88, 19, 21, 19, 1, 3, 0, 0, -1, -16);
                yield return new Hoops(125, 125, "Monmouth", 1, 82, 95, 50, 42, 36, 46, 20, 39, 110, 127, 17, 32, 18, 13, 11, 0, 0, 1, 17);
                yield return new Hoops(126, 126, "Beloit", 1, 51, 96, 52, 23, 38, 46, 28, 38, 86, 85, 19, 32, 13, 6, 12, 0, 0, -1, -1);
                yield return new Hoops(127, 127, "Ripon", 1, 60, 84, 68, 25, 33, 33, 20, 35, 112, 102, 22, 27, 20, 3, 11, 0, 0, -1, -10);
                yield return new Hoops(128, 128, "Illinois College", 1, 61, 86, 50, 34, 38, 45, 26, 29, 108, 114, 17, 33, 26, 3, 16, 0, 0, 1, 6);
                yield return new Hoops(129, 129, "Knox", 1, 52, 75, 53, 19, 22, 31, 13, 32, 67, 94, 17, 30, 11, 5, 16, 0, 0, 1, 27);
                yield return new Hoops(130, 130, "Lake Forest", 1, 43, 85, 51, 24, 37, 37, 22, 31, 85, 97, 17, 26, 12, 1, 11, 0, 0, 1, 12);
                yield return new Hoops(131, 131, "Beloit", 1, 74, 91, 49, 35, 23, 41, 21, 26, 105, 133, 31, 28, 13, 2, 12, 0, 0, 1, 28);
                yield return new Hoops(132, 132, "Ripon", 1, 65, 100, 72, 31, 28, 41, 24, 45, 104, 110, 21, 27, 11, 4, 14, 0, 0, 1, 6);
                yield return new Hoops(133, 133, "Illinois College", 1, 77, 90, 45, 28, 25, 38, 16, 28, 104, 133, 28, 30, 15, 6, 18, 0, 1, 1, 29);
                yield return new Hoops(134, 134, "Monmouth", 0, 80, 121, 64, 25, 40, 56, 29, 51, 125, 128, 18, 36, 17, 6, 25, 1, 1, 1, 3);
                yield return new Hoops(135, 135, "Lawrence", 0, 63, 97, 51, 24, 52, 37, 23, 41, 125, 110, 10, 21, 15, 5, 14, 0, 1, -1, -15);
                yield return new Hoops(136, 136, "St. Norbert", 0, 79, 79, 52, 34, 29, 42, 19, 30, 112, 115, 16, 27, 25, 6, 13, 0, 1, 1, 3);
                yield return new Hoops(137, 137, "Lake Forest", 1, 61, 78, 38, 20, 19, 35, 18, 31, 86, 94, 20, 22, 12, 0, 11, 0, 0, 1, 8);
                yield return new Hoops(138, 138, "Knox", 0, 63, 91, 48, 14, 30, 41, 21, 30, 114, 113, 16, 25, 20, 2, 13, 0, 1, -1, -1);
                yield return new Hoops(139, 139, "Carroll", 1, 81, 98, 54, 18, 46, 39, 16, 33, 150, 138, 31, 21, 23, 6, 13, 0, 1, -1, -12);
                yield return new Hoops(140, 140, "Lawrence", 1, 62, 79, 43, 13, 27, 31, 15, 37, 98, 79, 14, 23, 16, 2, 16, 0, 0, -1, -19);
                yield return new Hoops(141, 141, "Monmouth", 1, 82, 86, 60, 14, 25, 28, 11, 30, 113, 123, 36, 26, 15, 4, 13, 0, 1, 1, 10);
                yield return new Hoops(142, 142, "Ripon", 0, 73, 82, 58, 37, 21, 29, 13, 34, 110, 124, 16, 35, 18, 0, 22, 1, 1, 1, 14);
                yield return new Hoops(143, 143, "Beloit", 0, 66, 93, 60, 12, 38, 27, 12, 45, 120, 112, 22, 21, 10, 1, 13, 0, 0, -1, -8);
                yield return new Hoops(144, 144, "Illinois College", 0, 72, 74, 49, 22, 22, 41, 17, 29, 89, 100, 18, 18, 21, 1, 15, 0, 1, 1, 11);
                yield return new Hoops(145, 145, "Knox", 1, 62, 96, 49, 12, 13, 46, 27, 27, 83, 102, 19, 25, 9, 1, 19, 0, 0, 1, 19);
                yield return new Hoops(146, 146, "Lake Forest", 0, 50, 75, 38, 22, 30, 21, 14, 33, 110, 93, 12, 20, 9, 0, 13, 0, 0, -1, -17);
                yield return new Hoops(147, 147, "Carroll", 0, 86, 104, 61, 21, 32, 37, 22, 39, 153, 127, 26, 21, 18, 3, 14, 0, 1, -1, -26);
            }
        }
    }
}
