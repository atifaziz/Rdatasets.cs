// ReSharper disable All

namespace Rdatasets.DAAG
{
    using System.Collections.Generic;

    /// <summary>
    /// Deaths from whooping cough, in London
    /// </summary>

    public class whoops
    {
        public readonly int wcough;
        public readonly double ratio;
        public readonly int alldeaths;

        public whoops(int wcough, double ratio, int alldeaths)
        {
            this.wcough = wcough;
            this.ratio = ratio;
            this.alldeaths = alldeaths;
        }

        public static IEnumerable<whoops> Data
        {
            get
            {
                yield return new whoops(280, 9.09, 30811);
                yield return new whoops(100, 3.1, 32169);
                yield return new whoops(122, 4.48, 27483);
                yield return new whoops(92, 3.07, 25200);
                yield return new whoops(46, 2.23, 20606);
                yield return new whoops(135, 6.34, 21296);
                yield return new whoops(95, 3.37, 28157);
                yield return new whoops(151, 5.92, 25494);
                yield return new whoops(150, 6.29, 23869);
                yield return new whoops(82, 3.21, 25516);
                yield return new whoops(55, 2.32, 23727);
                yield return new whoops(275, 13.08, 21028);
                yield return new whoops(188, 9.17, 20485);
                yield return new whoops(65, 3.37, 19276);
                yield return new whoops(336, 14.8, 22696);
                yield return new whoops(93, 4.24, 21917);
                yield return new whoops(199, 9.53, 20872);
                yield return new whoops(239, 11.25, 21313);
                yield return new whoops(84, 4.78, 17576);
                yield return new whoops(227, 11.58, 19604);
                yield return new whoops(414, 22.88, 19830);
                yield return new whoops(197, 9.35, 21063);
                yield return new whoops(300, 8.26, 26326);
                yield return new whoops(291, 11.13, 26148);
                yield return new whoops(251, 10.82, 23202);
                yield return new whoops(225, 9.68, 23230);
                yield return new whoops(213, 9.99, 23911);
                yield return new whoops(364, 16.1, 22612);
                yield return new whoops(262, 11.09, 23639);
                yield return new whoops(318, 14.56, 21847);
                yield return new whoops(218, 9.69, 22434);
                yield return new whoops(249, 11.43, 21780);
                yield return new whoops(385, 14.77, 26053);
                yield return new whoops(234, 10.8, 21656);
                yield return new whoops(554, 26.04, 20884);
                yield return new whoops(224, 10.92, 20514);
                yield return new whoops(187, 9.81, 19048);
                yield return new whoops(536, 22.97, 23334);
                yield return new whoops(381, 18.67, 20399);
                yield return new whoops(268, 13.12, 20420);
                yield return new whoops(578, 2.82, 20517);
                yield return new whoops(165, 7.96, 20709);
                yield return new whoops(78, 4.35, 17918);
                yield return new whoops(268, 14.08, 19029);
                yield return new whoops(467, 26.19, 17828);
                yield return new whoops(194, 10.25, 18919);
                yield return new whoops(200, 9.77, 20454);
                yield return new whoops(228, 11.78, 19349);
                yield return new whoops(298, 15.13, 19697);
                yield return new whoops(374, 18.02, 20749);
                yield return new whoops(391, 25, 18038);
                yield return new whoops(279, 14.87, 18760);
                yield return new whoops(311, 15.38, 20213);
                yield return new whoops(352, 16.19, 21749);
                yield return new whoops(469, 24.37, 19241);
                yield return new whoops(311, 14.49, 21179);
                yield return new whoops(536, 27.79, 19288);
                yield return new whoops(367, 21.57, 17014);
                yield return new whoops(418, 23.02, 18155);
                yield return new whoops(451, 24.87, 18134);
                yield return new whoops(380, 16.47, 23068);
                yield return new whoops(428, 22.06, 19374);
                yield return new whoops(1004, 51.81, 19379);
                yield return new whoops(586, 39.92, 19582);
                yield return new whoops(697, 40.9, 17034);
                yield return new whoops(703, 40.05, 17565);
                yield return new whoops(623, 34.72, 17938);
                yield return new whoops(439, 23.94, 18334);
                yield return new whoops(326, 16.33, 19954);
                yield return new whoops(591, 35.43, 16680);
                yield return new whoops(449, 22.57, 19893);
                yield return new whoops(486, 28.51, 17043);
                yield return new whoops(508, 27.77, 18295);
                yield return new whoops(389, 22.45, 17322);
                yield return new whoops(864, 44.8, 19283);
                yield return new whoops(729, 37.27, 19560);
                yield return new whoops(666, 32.78, 20316);
                yield return new whoops(645, 32.3, 19968);
                yield return new whoops(839, 43.58, 19705);
                yield return new whoops(750, 38.88, 19228);
                yield return new whoops(794, 41.04, 19348);
                yield return new whoops(614, 33.27, 18451);
                yield return new whoops(757, 40.12, 18865);
                yield return new whoops(799, 38.81, 20587);
                yield return new whoops(627, 30.99, 20237);
                yield return new whoops(420, 19.97, 21026);
                yield return new whoops(674, 32.47, 20758);
                yield return new whoops(767, 34.41, 22292);
                yield return new whoops(717, 33.03, 21709);
                yield return new whoops(633, 26.9, 23524);
                yield return new whoops(552, 25.5, 21645);
                yield return new whoops(1738, 68.59, 25337);
                yield return new whoops(2278, 50.05, 45507);
                yield return new whoops(1603, 35.31, 45400);
                yield return new whoops(1908, 39.17, 48718);
                yield return new whoops(1292, 25.28, 51110);
                yield return new whoops(1816, 37.58, 48318);
                yield return new whoops(2035, 41.15, 49450);
                yield return new whoops(1600, 27.05, 59131);
                yield return new whoops(1630, 28.21, 57771);
                yield return new whoops(2349, 34.16, 68755);
                yield return new whoops(1568, 32.03, 48950);
                yield return new whoops(2185, 39.37, 55488);
                yield return new whoops(1569, 28.71, 54638);
                yield return new whoops(2667, 44.39, 60069);
                yield return new whoops(2502, 33.95, 73697);
                yield return new whoops(2438, 39.36, 61942);
                yield return new whoops(2092, 36.52, 57274);
                yield return new whoops(2527, 42.75, 59103);
                yield return new whoops(2708, 42.25, 64093);
                yield return new whoops(1742, 28.16, 61860);
                yield return new whoops(2067, 33.17, 62309);
                yield return new whoops(3548, 54.37, 65251);
                yield return new whoops(2168, 32.18, 67371);
                yield return new whoops(2175, 30.61, 71060);
                yield return new whoops(2423, 30.97, 78238);
                yield return new whoops(2935, 40.59, 73531);
                yield return new whoops(2960, 36.69, 80453);
                yield return new whoops(2278, 32.12, 70924);
                yield return new whoops(2338, 48.27, 73798);
                yield return new whoops(3769, 25.19, 78082);
                yield return new whoops(1956, 25.19, 77634);
                yield return new whoops(2291, 28.48, 80430);
                yield return new whoops(3259, 45.67, 71355);
                yield return new whoops(2620, 34.72, 75459);
                yield return new whoops(1867, 24.3, 76813);
                yield return new whoops(3204, 39.09, 81964);
                yield return new whoops(2737, 36.52, 77671);
                yield return new whoops(1817, 23.43, 77449);
                yield return new whoops(4483, 53.25, 84188);
                yield return new whoops(2934, 35.01, 83805);
                yield return new whoops(3516, 42.96, 81128);
                yield return new whoops(1961, 24.18, 81071);
                yield return new whoops(280, 9.09, 30811);
                yield return new whoops(100, 3.1, 32169);
                yield return new whoops(122, 4.48, 27483);
                yield return new whoops(92, 3.07, 25200);
                yield return new whoops(46, 2.23, 20606);
                yield return new whoops(135, 6.34, 21296);
                yield return new whoops(95, 3.37, 28157);
                yield return new whoops(151, 5.92, 25494);
                yield return new whoops(150, 6.29, 23869);
            }
        }
    }
}
