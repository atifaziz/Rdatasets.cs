// ReSharper disable All

namespace Rdatasets.mosaicData
{
    using System.Collections.Generic;

    /// <summary>
    /// Volume of Users of a Rail Trail
    /// </summary>

    public class RailTrail
    {
        public readonly int κ;
        public readonly int hightemp;
        public readonly int lowtemp;
        public readonly double avgtemp;
        public readonly int spring;
        public readonly int summer;
        public readonly int fall;
        public readonly double cloudcover;
        public readonly double precip;
        public readonly int volume;
        public readonly bool weekday;
        public readonly string dayType;

        public RailTrail(int κ, int hightemp, int lowtemp, double avgtemp, int spring, int summer, int fall, double cloudcover, double precip, int volume, bool weekday, string dayType)
        {
            this.κ = κ;
            this.hightemp = hightemp;
            this.lowtemp = lowtemp;
            this.avgtemp = avgtemp;
            this.spring = spring;
            this.summer = summer;
            this.fall = fall;
            this.cloudcover = cloudcover;
            this.precip = precip;
            this.volume = volume;
            this.weekday = weekday;
            this.dayType = dayType;
        }

        public static IEnumerable<RailTrail> Data
        {
            get
            {
                yield return new RailTrail(1, 83, 50, 66.5, 0, 1, 0, 7.59999990463257, 0, 501, true, "weekday");
                yield return new RailTrail(2, 73, 49, 61, 0, 1, 0, 6.30000019073486, 0.28999999165535, 419, true, "weekday");
                yield return new RailTrail(3, 74, 52, 63, 1, 0, 0, 7.5, 0.319999992847443, 397, true, "weekday");
                yield return new RailTrail(4, 95, 61, 78, 0, 1, 0, 2.59999990463257, 0, 385, false, "weekend");
                yield return new RailTrail(5, 44, 52, 48, 1, 0, 0, 10, 0.140000000596046, 200, true, "weekday");
                yield return new RailTrail(6, 69, 54, 61.5, 1, 0, 0, 6.59999990463257, 0.0199999995529652, 375, true, "weekday");
                yield return new RailTrail(7, 66, 39, 52.5, 1, 0, 0, 2.40000009536743, 0, 417, true, "weekday");
                yield return new RailTrail(8, 66, 38, 52, 1, 0, 0, 0, 0, 629, false, "weekend");
                yield return new RailTrail(9, 80, 55, 67.5, 0, 1, 0, 3.79999995231628, 0, 533, false, "weekend");
                yield return new RailTrail(10, 79, 45, 62, 0, 1, 0, 4.09999990463257, 0, 547, true, "weekday");
                yield return new RailTrail(11, 78, 55, 66.5, 0, 1, 0, 8.5, 0, 432, true, "weekday");
                yield return new RailTrail(12, 65, 48, 56.5, 1, 0, 0, 7.19999980926514, 0, 418, true, "weekday");
                yield return new RailTrail(13, 41, 49, 45, 1, 0, 0, 10, 0.0299999993294477, 193, true, "weekday");
                yield return new RailTrail(14, 59, 35, 47, 0, 0, 1, 7.69999980926514, 0, 331, true, "weekday");
                yield return new RailTrail(15, 50, 35, 42.5, 0, 0, 1, 5.80000019073486, 0, 280, true, "weekday");
                yield return new RailTrail(16, 54, 32, 43, 1, 0, 0, 3.59999990463257, 0, 304, true, "weekday");
                yield return new RailTrail(17, 97, 71, 84, 0, 1, 0, 6.09999990463257, 0.680000007152557, 352, false, "weekend");
                yield return new RailTrail(18, 75, 43, 59, 1, 0, 0, 6.30000019073486, 0, 156, true, "weekday");
                yield return new RailTrail(19, 63, 35, 49, 1, 0, 0, 8.60000038146973, 0, 365, true, "weekday");
                yield return new RailTrail(20, 42, 37, 39.5, 0, 0, 1, 10, 0.150000005960464, 181, true, "weekday");
                yield return new RailTrail(21, 70, 49, 59.5, 1, 0, 0, 7.90000009536743, 0, 514, false, "weekend");
                yield return new RailTrail(22, 57, 48, 52.5, 1, 0, 0, 6.80000019073486, 0, 259, true, "weekday");
                yield return new RailTrail(23, 71, 39, 55, 1, 0, 0, 5.19999980926514, 0, 452, true, "weekday");
                yield return new RailTrail(24, 46, 30, 38, 0, 0, 1, 9.69999980926514, 0.200000002980232, 189, true, "weekday");
                yield return new RailTrail(25, 61, 35, 48, 1, 0, 0, 4.40000009536743, 0, 362, true, "weekday");
                yield return new RailTrail(26, 81, 65, 73, 0, 1, 0, 10, 1.44000005722046, 256, true, "weekday");
                yield return new RailTrail(27, 64, 58, 61, 0, 1, 0, 10, 1.14999997615814, 155, true, "weekday");
                yield return new RailTrail(28, 57, 36, 46.5, 1, 0, 0, 6.5, 0.00999999977648258, 174, true, "weekday");
                yield return new RailTrail(29, 62, 36, 49, 1, 0, 0, 0, 0, 259, true, "weekday");
                yield return new RailTrail(30, 83, 54, 68.5, 0, 1, 0, 1.20000004768372, 0, 535, false, "weekend");
                yield return new RailTrail(31, 76, 44, 60, 1, 0, 0, 1.79999995231628, 0, 650, false, "weekend");
                yield return new RailTrail(32, 74, 50, 62, 1, 0, 0, 8, 0.119999997317791, 409, true, "weekday");
                yield return new RailTrail(33, 59, 40, 49.5, 1, 0, 0, 9.39999961853027, 0.340000003576279, 311, true, "weekday");
                yield return new RailTrail(34, 77, 52, 64.5, 1, 0, 0, 5, 0, 736, false, "weekend");
                yield return new RailTrail(35, 52, 43, 47.5, 1, 0, 0, 5.80000019073486, 0.00999999977648258, 186, true, "weekday");
                yield return new RailTrail(36, 67, 43, 55, 1, 0, 0, 6.69999980926514, 0, 371, true, "weekday");
                yield return new RailTrail(37, 51, 19, 35, 0, 0, 1, 0, 0, 291, false, "weekend");
                yield return new RailTrail(38, 41, 25, 33, 0, 0, 1, 0, 0, 287, true, "weekday");
                yield return new RailTrail(39, 90, 65, 77.5, 0, 1, 0, 8.39999961853027, 0, 411, true, "weekday");
                yield return new RailTrail(40, 70, 30, 50, 1, 0, 0, 0, 0, 461, false, "weekend");
                yield return new RailTrail(41, 81, 39, 60, 1, 0, 0, 0, 0, 540, true, "weekday");
                yield return new RailTrail(42, 72, 53, 62.5, 0, 1, 0, 7.90000009536743, 0, 376, true, "weekday");
                yield return new RailTrail(43, 70, 63, 66.5, 0, 1, 0, 9.89999961853027, 0, 554, true, "weekday");
                yield return new RailTrail(44, 69, 41, 55, 0, 0, 1, 6.40000009536743, 0, 339, true, "weekday");
                yield return new RailTrail(45, 59, 34, 46.5, 1, 0, 0, 2.40000009536743, 0, 344, true, "weekday");
                yield return new RailTrail(46, 60, 32, 46, 0, 0, 1, 1.20000004768372, 0, 348, false, "weekend");
                yield return new RailTrail(47, 72, 47, 59.5, 1, 0, 0, 4.09999990463257, 0, 517, true, "weekday");
                yield return new RailTrail(48, 70, 47, 58.5, 1, 0, 0, 9.89999961853027, 0, 328, true, "weekday");
                yield return new RailTrail(49, 76, 72, 74, 0, 1, 0, 9.69999980926514, 0.349999994039536, 298, true, "weekday");
                yield return new RailTrail(50, 56, 38, 47, 1, 0, 0, 0, 0, 335, true, "weekday");
                yield return new RailTrail(51, 66, 38, 52, 1, 0, 0, 3.90000009536743, 0, 186, true, "weekday");
                yield return new RailTrail(52, 84, 69, 76.5, 0, 1, 0, 8.89999961853027, 0.00999999977648258, 505, true, "weekday");
                yield return new RailTrail(53, 58, 51, 54.5, 1, 0, 0, 10, 0.150000005960464, 156, true, "weekday");
                yield return new RailTrail(54, 56, 41, 48.5, 1, 0, 0, 7, 0, 362, true, "weekday");
                yield return new RailTrail(55, 79, 47, 63, 1, 0, 0, 7, 0.00999999977648258, 507, false, "weekend");
                yield return new RailTrail(56, 67, 39, 53, 1, 0, 0, 6.80000019073486, 0.0199999995529652, 407, false, "weekend");
                yield return new RailTrail(57, 75, 47, 61, 1, 0, 0, 6.80000019073486, 0, 421, true, "weekday");
                yield return new RailTrail(58, 65, 30, 47.5, 1, 0, 0, 4.30000019073486, 0, 393, true, "weekday");
                yield return new RailTrail(59, 70, 41, 55.5, 1, 0, 0, 5.09999990463257, 0, 422, true, "weekday");
                yield return new RailTrail(60, 64, 41, 52.5, 1, 0, 0, 3.40000009536743, 0, 349, true, "weekday");
                yield return new RailTrail(61, 51, 39, 45, 1, 0, 0, 10, 0.159999996423721, 150, true, "weekday");
                yield return new RailTrail(62, 77, 43, 60, 1, 0, 0, 0.400000005960464, 0, 429, true, "weekday");
                yield return new RailTrail(63, 60, 34, 47, 1, 0, 0, 10, 0, 293, true, "weekday");
                yield return new RailTrail(64, 74, 55, 64.5, 0, 1, 0, 4.59999990463257, 0, 461, true, "weekday");
                yield return new RailTrail(65, 84, 70, 77, 0, 1, 0, 9.89999961853027, 1.49000000953674, 388, true, "weekday");
                yield return new RailTrail(66, 61, 42, 51.5, 1, 0, 0, 6.40000009536743, 0.00999999977648258, 322, true, "weekday");
                yield return new RailTrail(67, 49, 43, 46, 1, 0, 0, 9.69999980926514, 0.119999997317791, 129, false, "weekend");
                yield return new RailTrail(68, 71, 42, 56.5, 0, 0, 1, 4, 0, 415, false, "weekend");
                yield return new RailTrail(69, 70, 62, 66, 1, 0, 0, 3, 0, 460, true, "weekday");
                yield return new RailTrail(70, 83, 60, 71.5, 0, 1, 0, 8.19999980926514, 0.140000000596046, 405, true, "weekday");
                yield return new RailTrail(71, 90, 66, 78, 0, 1, 0, 6.59999990463257, 0, 453, true, "weekday");
                yield return new RailTrail(72, 92, 66, 79, 0, 1, 0, 7.90000009536743, 0, 395, true, "weekday");
                yield return new RailTrail(73, 88, 54, 71, 0, 1, 0, 6.19999980926514, 0, 531, true, "weekday");
                yield return new RailTrail(74, 62, 39, 50.5, 1, 0, 0, 0.800000011920929, 0, 236, true, "weekday");
                yield return new RailTrail(75, 86, 50, 68, 1, 0, 0, 6.19999980926514, 0, 484, true, "weekday");
                yield return new RailTrail(76, 67, 43, 55, 1, 0, 0, 0.400000005960464, 0, 445, true, "weekday");
                yield return new RailTrail(77, 59, 35, 47, 0, 0, 1, 1.70000004768372, 0, 252, true, "weekday");
                yield return new RailTrail(78, 89, 69, 79, 0, 1, 0, 9, 0.360000014305115, 286, false, "weekend");
                yield return new RailTrail(79, 63, 46, 54.5, 1, 0, 0, 6.90000009536743, 0.170000001788139, 400, false, "weekend");
                yield return new RailTrail(80, 59, 46, 52.5, 0, 0, 1, 10, 0, 261, false, "weekend");
                yield return new RailTrail(81, 74, 55, 64.5, 1, 0, 0, 7.80000019073486, 0, 339, false, "weekend");
                yield return new RailTrail(82, 80, 33, 56.5, 1, 0, 0, 0.699999988079071, 0, 617, false, "weekend");
                yield return new RailTrail(83, 55, 45, 50, 1, 0, 0, 9.60000038146973, 0.200000002980232, 316, false, "weekend");
                yield return new RailTrail(84, 62, 28, 45, 0, 0, 1, 5.69999980926514, 0.0199999995529652, 367, false, "weekend");
                yield return new RailTrail(85, 74, 33, 53.5, 1, 0, 0, 2.5, 0, 635, false, "weekend");
                yield return new RailTrail(86, 95, 66, 80.5, 0, 1, 0, 4.09999990463257, 0, 449, false, "weekend");
                yield return new RailTrail(87, 65, 20, 42.5, 1, 0, 0, 9.39999961853027, 0.219999998807907, 314, false, "weekend");
                yield return new RailTrail(88, 55, 43, 49, 1, 0, 0, 9, 0, 264, false, "weekend");
                yield return new RailTrail(89, 89, 57, 73, 0, 1, 0, 1.89999997615814, 0, 356, false, "weekend");
                yield return new RailTrail(90, 80, 53, 66.5, 0, 1, 0, 3.79999995231628, 0, 564, false, "weekend");
            }
        }
    }
}
