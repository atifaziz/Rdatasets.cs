// ReSharper disable All

namespace Rdatasets.Ecdat
{
    using System.Collections.Generic;

    /// <summary>
    /// Price and Earnings Index
    /// </summary>

    public class PE
    {
        public readonly double price;
        public readonly double earnings;

        public PE(double price, double earnings)
        {
            this.price = price;
            this.earnings = earnings;
        }

        public static IEnumerable<PE> Data
        {
            get
            {
                yield return new PE(4.69166666667, 0.4);
                yield return new PE(5.02916666667, 0.41625);
                yield return new PE(4.80166666667, 0.44625);
                yield return new PE(4.57, 0.46);
                yield return new PE(4.4475, 0.405833333333);
                yield return new PE(4.06083333333, 0.316666666667);
                yield return new PE(3.13583333333, 0.290833333333);
                yield return new PE(3.38333333333, 0.305416666667);
                yield return new PE(4.1225, 0.347916666667);
                yield return new PE(5.20916666667, 0.439583333333);
                yield return new PE(6.25416666667, 0.462916666667);
                yield return new PE(5.9, 0.434583333333);
                yield return new PE(5.63416666667, 0.41375);
                yield return new PE(4.74083333333, 0.35125);
                yield return new PE(4.59666666667, 0.288333333333);
                yield return new PE(5.36416666667, 0.3025);
                yield return new PE(5.53416666667, 0.34625);
                yield return new PE(5.20416666667, 0.305833333333);
                yield return new PE(5.32333333333, 0.281666666667);
                yield return new PE(5.26916666667, 0.294583333333);
                yield return new PE(5.02833333333, 0.317083333333);
                yield return new PE(5.55, 0.35625);
                yield return new PE(4.775, 0.310416666667);
                yield return new PE(4.38666666667, 0.205833333333);
                yield return new PE(4.525, 0.20875);
                yield return new PE(4.23333333333, 0.228333333333);
                yield return new PE(4.45083333333, 0.264166666667);
                yield return new PE(5.0525, 0.331666666667);
                yield return new PE(6.28833333333, 0.420416666667);
                yield return new PE(6.1475, 0.48);
                yield return new PE(7.8425, 0.490833333333);
                yield return new PE(8.41666666667, 0.570416666667);
                yield return new PE(7.21166666667, 0.575833333333);
                yield return new PE(7.04916666667, 0.508333333333);
                yield return new PE(8.98583333333, 0.5875);
                yield return new PE(9.62166666667, 0.71875);
                yield return new PE(7.84, 0.705833333333);
                yield return new PE(7.77583333333, 0.616666666667);
                yield return new PE(9.7125, 0.6775);
                yield return new PE(9.35166666667, 0.74375);
                yield return new PE(9.235, 0.654166666667);
                yield return new PE(9.535, 0.649583333333);
                yield return new PE(8.5075, 0.662083333333);
                yield return new PE(7.945, 0.570416666667);
                yield return new PE(8.305, 0.715);
                yield return new PE(9.46666666667, 1.232125);
                yield return new PE(8.495, 1.39466666667);
                yield return new PE(7.53916666667, 1.123);
                yield return new PE(8.7825, 0.9575);
                yield return new PE(7.9775, 0.859583333333);
                yield return new PE(6.8575, 0.52375);
                yield return new PE(8.41083333333, 0.506666666667);
                yield return new PE(8.57333333333, 0.847083333333);
                yield return new PE(9.04583333333, 0.952916666667);
                yield return new PE(11.15, 1.10333333333);
                yield return new PE(12.5866666667, 1.24458333333);
                yield return new PE(15.3433333333, 1.16966666667);
                yield return new PE(19.9533333333, 1.25616666667);
                yield return new PE(26.0183333333, 1.50458333333);
                yield return new PE(21.0266666667, 1.26333333333);
                yield return new PE(13.6591666667, 0.775);
                yield return new PE(6.92833333333, 0.501666666667);
                yield return new PE(8.95833333333, 0.42625);
                yield return new PE(9.84416666667, 0.467083333333);
                yield return new PE(10.5991666667, 0.7425);
                yield return new PE(15.4683333333, 0.885833333333);
                yield return new PE(15.4058333333, 1.14833333333);
                yield return new PE(11.4883333333, 0.790833333333);
                yield return new PE(12.0616666667, 0.773333333333);
                yield return new PE(11.0208333333, 1.0275);
                yield return new PE(9.82416666667, 1.11583333333);
                yield return new PE(8.67333333333, 1.00833333333);
                yield return new PE(11.5041666667, 1.05499975);
                yield return new PE(12.4683333333, 0.920833333333);
                yield return new PE(15.1558333333, 0.975);
                yield return new PE(17.0808333333, 0.914166416667);
                yield return new PE(15.1658333333, 1.42166666667);
                yield return new PE(15.5325, 1.92583333333);
                yield return new PE(15.23, 2.37);
                yield return new PE(18.4, 2.57416666667);
                yield return new PE(22.335, 2.65833333333);
                yield return new PE(24.4975, 2.37833333333);
                yield return new PE(24.7316666667, 2.49083333333);
                yield return new PE(29.6891666667, 2.62083333333);
                yield return new PE(40.4933333333, 3.23916666667);
                yield return new PE(46.6233333333, 3.5575);
                yield return new PE(44.38, 3.41833333333);
                yield return new PE(46.2383333333, 3);
                yield return new PE(57.3791666667, 3.29083333333);
                yield return new PE(55.85, 3.3075);
                yield return new PE(66.2725, 3.09666666667);
                yield return new PE(62.3825, 3.47);
                yield return new PE(69.865, 3.85333333333);
                yield return new PE(81.3683333333, 4.33833333333);
                yield return new PE(88.17, 4.86916666667);
                yield return new PE(85.2566666667, 5.435);
                yield return new PE(91.9283333333, 5.37083333333);
                yield return new PE(98.6941666667, 5.57166666667);
                yield return new PE(97.84, 5.83083333333);
                yield return new PE(83.22, 5.46416666667);
                yield return new PE(98.2833333333, 5.37);
                yield return new PE(109.208333333, 6.025);
                yield return new PE(107.423333333, 7.325);
                yield return new PE(82.5525, 8.71416666667);
                yield return new PE(86.1558333333, 8.11);
                yield return new PE(102.021666667, 9.18);
                yield return new PE(98.21, 10.4433308333);
                yield return new PE(96.02, 11.3925);
                yield return new PE(103.0225, 13.9816666667);
                yield return new PE(118.783333333, 14.9258333333);
                yield return new PE(128.041666667, 15.01);
                yield return new PE(119.725, 14.0216666667);
                yield return new PE(160.425, 12.9691666667);
                yield return new PE(160.466666667, 15.9475);
                yield return new PE(186.85, 15.6291666667);
                yield return new PE(236.358333333, 14.6508333333);
                yield return new PE(286.841666667, 15.4683333333);
                yield return new PE(265.783333333, 21.1658333333);
                yield return new PE(322.833333333, 24.2641666667);
                yield return new PE(334.5875, 21.6325);
                yield return new PE(376.1775, 18.95);
                yield return new PE(415.744166667, 17.335);
                yield return new PE(451.406666667, 20.1325);
                yield return new PE(460.329166667, 25.7333333333);
                yield return new PE(541.638333333, 33.75);
                yield return new PE(670.828333333, 35.5225);
                yield return new PE(872.673333333, 40.205);
                yield return new PE(1084.31083333, 38.745);
                yield return new PE(1326.06083333, 42.0108333333);
                yield return new PE(1427.0075, 51.4875);
                yield return new PE(1192.07833333, 35.9166666667);
                yield return new PE(995.651666667, 27.1008333333);
            }
        }
    }
}
