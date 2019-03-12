// ReSharper disable All

namespace Rdatasets.DAAG
{
    using System.Collections.Generic;

    /// <summary>
    /// Deaths from whooping cough, in London
    /// </summary>

    public class whoops
    {
        public readonly int κ;
        public readonly int wcough;
        public readonly double ratio;
        public readonly int alldeaths;

        public whoops(int κ, int wcough, double ratio, int alldeaths)
        {
            this.κ = κ;
            this.wcough = wcough;
            this.ratio = ratio;
            this.alldeaths = alldeaths;
        }

        public static IEnumerable<whoops> Data
        {
            get
            {
                yield return new whoops(1, 280, 9.09, 30811);
                yield return new whoops(2, 100, 3.1, 32169);
                yield return new whoops(3, 122, 4.48, 27483);
                yield return new whoops(4, 92, 3.07, 25200);
                yield return new whoops(5, 46, 2.23, 20606);
                yield return new whoops(6, 135, 6.34, 21296);
                yield return new whoops(7, 95, 3.37, 28157);
                yield return new whoops(8, 151, 5.92, 25494);
                yield return new whoops(9, 150, 6.29, 23869);
                yield return new whoops(10, 82, 3.21, 25516);
                yield return new whoops(11, 55, 2.32, 23727);
                yield return new whoops(12, 275, 13.08, 21028);
                yield return new whoops(13, 188, 9.17, 20485);
                yield return new whoops(14, 65, 3.37, 19276);
                yield return new whoops(15, 336, 14.8, 22696);
                yield return new whoops(16, 93, 4.24, 21917);
                yield return new whoops(17, 199, 9.53, 20872);
                yield return new whoops(18, 239, 11.25, 21313);
                yield return new whoops(19, 84, 4.78, 17576);
                yield return new whoops(20, 227, 11.58, 19604);
                yield return new whoops(21, 414, 22.88, 19830);
                yield return new whoops(22, 197, 9.35, 21063);
                yield return new whoops(23, 300, 8.26, 26326);
                yield return new whoops(24, 291, 11.13, 26148);
                yield return new whoops(25, 251, 10.82, 23202);
                yield return new whoops(26, 225, 9.68, 23230);
                yield return new whoops(27, 213, 9.99, 23911);
                yield return new whoops(28, 364, 16.1, 22612);
                yield return new whoops(29, 262, 11.09, 23639);
                yield return new whoops(30, 318, 14.56, 21847);
                yield return new whoops(31, 218, 9.69, 22434);
                yield return new whoops(32, 249, 11.43, 21780);
                yield return new whoops(33, 385, 14.77, 26053);
                yield return new whoops(34, 234, 10.8, 21656);
                yield return new whoops(35, 554, 26.04, 20884);
                yield return new whoops(36, 224, 10.92, 20514);
                yield return new whoops(37, 187, 9.81, 19048);
                yield return new whoops(38, 536, 22.97, 23334);
                yield return new whoops(39, 381, 18.67, 20399);
                yield return new whoops(40, 268, 13.12, 20420);
                yield return new whoops(41, 578, 2.82, 20517);
                yield return new whoops(42, 165, 7.96, 20709);
                yield return new whoops(43, 78, 4.35, 17918);
                yield return new whoops(44, 268, 14.08, 19029);
                yield return new whoops(45, 467, 26.19, 17828);
                yield return new whoops(46, 194, 10.25, 18919);
                yield return new whoops(47, 200, 9.77, 20454);
                yield return new whoops(48, 228, 11.78, 19349);
                yield return new whoops(49, 298, 15.13, 19697);
                yield return new whoops(50, 374, 18.02, 20749);
                yield return new whoops(51, 391, 25, 18038);
                yield return new whoops(52, 279, 14.87, 18760);
                yield return new whoops(53, 311, 15.38, 20213);
                yield return new whoops(54, 352, 16.19, 21749);
                yield return new whoops(55, 469, 24.37, 19241);
                yield return new whoops(56, 311, 14.49, 21179);
                yield return new whoops(57, 536, 27.79, 19288);
                yield return new whoops(58, 367, 21.57, 17014);
                yield return new whoops(59, 418, 23.02, 18155);
                yield return new whoops(60, 451, 24.87, 18134);
                yield return new whoops(61, 380, 16.47, 23068);
                yield return new whoops(62, 428, 22.06, 19374);
                yield return new whoops(63, 1004, 51.81, 19379);
                yield return new whoops(64, 586, 39.92, 19582);
                yield return new whoops(65, 697, 40.9, 17034);
                yield return new whoops(66, 703, 40.05, 17565);
                yield return new whoops(67, 623, 34.72, 17938);
                yield return new whoops(68, 439, 23.94, 18334);
                yield return new whoops(69, 326, 16.33, 19954);
                yield return new whoops(70, 591, 35.43, 16680);
                yield return new whoops(71, 449, 22.57, 19893);
                yield return new whoops(72, 486, 28.51, 17043);
                yield return new whoops(73, 508, 27.77, 18295);
                yield return new whoops(74, 389, 22.45, 17322);
                yield return new whoops(75, 864, 44.8, 19283);
                yield return new whoops(76, 729, 37.27, 19560);
                yield return new whoops(77, 666, 32.78, 20316);
                yield return new whoops(78, 645, 32.3, 19968);
                yield return new whoops(79, 839, 43.58, 19705);
                yield return new whoops(80, 750, 38.88, 19228);
                yield return new whoops(81, 794, 41.04, 19348);
                yield return new whoops(82, 614, 33.27, 18451);
                yield return new whoops(83, 757, 40.12, 18865);
                yield return new whoops(84, 799, 38.81, 20587);
                yield return new whoops(85, 627, 30.99, 20237);
                yield return new whoops(86, 420, 19.97, 21026);
                yield return new whoops(87, 674, 32.47, 20758);
                yield return new whoops(88, 767, 34.41, 22292);
                yield return new whoops(89, 717, 33.03, 21709);
                yield return new whoops(90, 633, 26.9, 23524);
                yield return new whoops(91, 552, 25.5, 21645);
                yield return new whoops(92, 1738, 68.59, 25337);
                yield return new whoops(93, 2278, 50.05, 45507);
                yield return new whoops(94, 1603, 35.31, 45400);
                yield return new whoops(95, 1908, 39.17, 48718);
                yield return new whoops(96, 1292, 25.28, 51110);
                yield return new whoops(97, 1816, 37.58, 48318);
                yield return new whoops(98, 2035, 41.15, 49450);
                yield return new whoops(99, 1600, 27.05, 59131);
                yield return new whoops(100, 1630, 28.21, 57771);
                yield return new whoops(101, 2349, 34.16, 68755);
                yield return new whoops(102, 1568, 32.03, 48950);
                yield return new whoops(103, 2185, 39.37, 55488);
                yield return new whoops(104, 1569, 28.71, 54638);
                yield return new whoops(105, 2667, 44.39, 60069);
                yield return new whoops(106, 2502, 33.95, 73697);
                yield return new whoops(107, 2438, 39.36, 61942);
                yield return new whoops(108, 2092, 36.52, 57274);
                yield return new whoops(109, 2527, 42.75, 59103);
                yield return new whoops(110, 2708, 42.25, 64093);
                yield return new whoops(111, 1742, 28.16, 61860);
                yield return new whoops(112, 2067, 33.17, 62309);
                yield return new whoops(113, 3548, 54.37, 65251);
                yield return new whoops(114, 2168, 32.18, 67371);
                yield return new whoops(115, 2175, 30.61, 71060);
                yield return new whoops(116, 2423, 30.97, 78238);
                yield return new whoops(117, 2935, 40.59, 73531);
                yield return new whoops(118, 2960, 36.69, 80453);
                yield return new whoops(119, 2278, 32.12, 70924);
                yield return new whoops(120, 2338, 48.27, 73798);
                yield return new whoops(121, 3769, 25.19, 78082);
                yield return new whoops(122, 1956, 25.19, 77634);
                yield return new whoops(123, 2291, 28.48, 80430);
                yield return new whoops(124, 3259, 45.67, 71355);
                yield return new whoops(125, 2620, 34.72, 75459);
                yield return new whoops(126, 1867, 24.3, 76813);
                yield return new whoops(127, 3204, 39.09, 81964);
                yield return new whoops(128, 2737, 36.52, 77671);
                yield return new whoops(129, 1817, 23.43, 77449);
                yield return new whoops(130, 4483, 53.25, 84188);
                yield return new whoops(131, 2934, 35.01, 83805);
                yield return new whoops(132, 3516, 42.96, 81128);
                yield return new whoops(133, 1961, 24.18, 81071);
                yield return new whoops(134, 280, 9.09, 30811);
                yield return new whoops(135, 100, 3.1, 32169);
                yield return new whoops(136, 122, 4.48, 27483);
                yield return new whoops(137, 92, 3.07, 25200);
                yield return new whoops(138, 46, 2.23, 20606);
                yield return new whoops(139, 135, 6.34, 21296);
                yield return new whoops(140, 95, 3.37, 28157);
                yield return new whoops(141, 151, 5.92, 25494);
                yield return new whoops(142, 150, 6.29, 23869);
            }
        }
    }
}
