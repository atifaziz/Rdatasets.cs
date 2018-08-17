// ReSharper disable All

namespace Rdatasets.Stat2Data
{
    using System.Collections.Generic;

    /// <summary>
    /// FGByDistance
    /// </summary>

    public class FGByDistance
    {
        public readonly int Row;
        public readonly int Dist;
        public readonly int N;
        public readonly int Makes;
        public readonly double PropMakes;
        public readonly int Blocked;
        public readonly double PropBlocked;

        public FGByDistance(int Row, int Dist, int N, int Makes, double PropMakes, int Blocked, double PropBlocked)
        {
            this.Row = Row;
            this.Dist = Dist;
            this.N = N;
            this.Makes = Makes;
            this.PropMakes = PropMakes;
            this.Blocked = Blocked;
            this.PropBlocked = PropBlocked;
        }

        public static IEnumerable<FGByDistance> Data
        {
            get
            {
                yield return new FGByDistance(1, 18, 15, 15, 1, 0, 0);
                yield return new FGByDistance(2, 19, 107, 105, 0.981308411, 1, 0.009345794);
                yield return new FGByDistance(3, 20, 204, 201, 0.985294118, 1, 0.004901961);
                yield return new FGByDistance(4, 21, 197, 194, 0.984771574, 0, 0);
                yield return new FGByDistance(5, 22, 244, 239, 0.979508197, 2, 0.008196721);
                yield return new FGByDistance(6, 23, 298, 291, 0.976510067, 2, 0.006711409);
                yield return new FGByDistance(7, 24, 241, 233, 0.966804979, 1, 0.004149378);
                yield return new FGByDistance(8, 25, 211, 202, 0.957345972, 5, 0.023696682);
                yield return new FGByDistance(9, 26, 237, 226, 0.953586498, 1, 0.004219409);
                yield return new FGByDistance(10, 27, 238, 226, 0.949579832, 1, 0.004201681);
                yield return new FGByDistance(11, 28, 282, 256, 0.907801418, 6, 0.021276596);
                yield return new FGByDistance(12, 29, 235, 210, 0.893617021, 4, 0.017021277);
                yield return new FGByDistance(13, 30, 236, 208, 0.881355932, 7, 0.029661017);
                yield return new FGByDistance(14, 31, 238, 214, 0.899159664, 7, 0.029411765);
                yield return new FGByDistance(15, 32, 259, 229, 0.884169884, 8, 0.030888031);
                yield return new FGByDistance(16, 33, 313, 273, 0.872204473, 3, 0.009584665);
                yield return new FGByDistance(17, 34, 223, 182, 0.816143498, 5, 0.022421525);
                yield return new FGByDistance(18, 35, 238, 200, 0.840336134, 7, 0.029411765);
                yield return new FGByDistance(19, 36, 223, 191, 0.856502242, 4, 0.01793722);
                yield return new FGByDistance(20, 37, 266, 220, 0.827067669, 7, 0.026315789);
                yield return new FGByDistance(21, 38, 293, 244, 0.832764505, 9, 0.030716724);
                yield return new FGByDistance(22, 39, 270, 217, 0.803703704, 5, 0.018518519);
                yield return new FGByDistance(23, 40, 292, 231, 0.79109589, 7, 0.023972603);
                yield return new FGByDistance(24, 41, 269, 208, 0.773234201, 6, 0.022304833);
                yield return new FGByDistance(25, 42, 315, 241, 0.765079365, 4, 0.012698413);
                yield return new FGByDistance(26, 43, 289, 201, 0.69550173, 15, 0.051903114);
                yield return new FGByDistance(27, 44, 265, 173, 0.652830189, 11, 0.041509434);
                yield return new FGByDistance(28, 45, 237, 166, 0.700421941, 6, 0.025316456);
                yield return new FGByDistance(29, 46, 252, 166, 0.658730159, 9, 0.035714286);
                yield return new FGByDistance(30, 47, 251, 173, 0.689243028, 7, 0.027888446);
                yield return new FGByDistance(31, 48, 284, 167, 0.588028169, 14, 0.049295775);
                yield return new FGByDistance(32, 49, 207, 128, 0.618357488, 6, 0.028985507);
                yield return new FGByDistance(33, 50, 178, 105, 0.58988764, 5, 0.028089888);
                yield return new FGByDistance(34, 51, 160, 97, 0.60625, 6, 0.0375);
                yield return new FGByDistance(35, 52, 142, 73, 0.514084507, 6, 0.042253521);
                yield return new FGByDistance(36, 53, 129, 69, 0.534883721, 1, 0.007751938);
                yield return new FGByDistance(37, 54, 74, 43, 0.581081081, 1, 0.013513514);
                yield return new FGByDistance(38, 55, 32, 14, 0.4375, 2, 0.0625);
                yield return new FGByDistance(39, 56, 17, 9, 0.529411765, 1, 0.058823529);
                yield return new FGByDistance(40, 57, 17, 5, 0.294117647, 0, 0);
                yield return new FGByDistance(41, 58, 11, 2, 0.181818182, 0, 0);
                yield return new FGByDistance(42, 59, 9, 0, 0, 0, 0);
                yield return new FGByDistance(43, 60, 7, 1, 0.142857143, 2, 0.285714286);
                yield return new FGByDistance(44, 61, 1, 0, 0, 0, 0);
                yield return new FGByDistance(45, 62, 4, 1, 0.25, 1, 0.25);
                yield return new FGByDistance(46, 63, 1, 0, 0, 0, 0);
                yield return new FGByDistance(47, 64, 2, 0, 0, 0, 0);
                yield return new FGByDistance(48, 65, 4, 0, 0, 0, 0);
                yield return new FGByDistance(49, 68, 1, 0, 0, 0, 0);
                yield return new FGByDistance(50, 69, 1, 0, 0, 0, 0);
                yield return new FGByDistance(51, 76, 1, 0, 0, 0, 0);
            }
        }
    }
}
