// ReSharper disable All

namespace Rdatasets.carData
{
    using System.Collections.Generic;

    /// <summary>
    /// Data on Infant-Mortality
    /// </summary>

    public class Leinhardt
    {
        public readonly int income;
        public readonly string infant;
        public readonly string region;
        public readonly string oil;

        public Leinhardt(int income, string infant, string region, string oil)
        {
            this.income = income;
            this.infant = infant;
            this.region = region;
            this.oil = oil;
        }

        public static IEnumerable<Leinhardt> Data
        {
            get
            {
                yield return new Leinhardt(3426, "26.7", "Asia", "no");
                yield return new Leinhardt(3350, "23.7", "Europe", "no");
                yield return new Leinhardt(3346, "17", "Europe", "no");
                yield return new Leinhardt(4751, "16.8", "Americas", "no");
                yield return new Leinhardt(5029, "13.5", "Europe", "no");
                yield return new Leinhardt(3312, "10.1", "Europe", "no");
                yield return new Leinhardt(3403, "12.9", "Europe", "no");
                yield return new Leinhardt(5040, "20.4", "Europe", "no");
                yield return new Leinhardt(2009, "17.8", "Europe", "no");
                yield return new Leinhardt(2298, "25.7", "Europe", "no");
                yield return new Leinhardt(3292, "11.7", "Europe", "no");
                yield return new Leinhardt(4103, "11.6", "Europe", "no");
                yield return new Leinhardt(3723, "16.2", "Asia", "no");
                yield return new Leinhardt(4102, "11.3", "Europe", "no");
                yield return new Leinhardt(956, "44.8", "Europe", "no");
                yield return new Leinhardt(1000, "71.5", "Africa", "no");
                yield return new Leinhardt(5596, "9.6", "Europe", "no");
                yield return new Leinhardt(2963, "12.8", "Europe", "no");
                yield return new Leinhardt(2503, "17.5", "Europe", "no");
                yield return new Leinhardt(5523, "17.6", "Americas", "no");
                yield return new Leinhardt(400, "86.3", "Africa", "yes");
                yield return new Leinhardt(250, "78.5", "Americas", "yes");
                yield return new Leinhardt(110, "125", "Asia", "yes");
                yield return new Leinhardt(1280, null, "Asia", "yes");
                yield return new Leinhardt(560, "28.1", "Asia", "yes");
                yield return new Leinhardt(3010, "300", "Africa", "yes");
                yield return new Leinhardt(220, "58", "Africa", "yes");
                yield return new Leinhardt(1530, "650", "Asia", "yes");
                yield return new Leinhardt(1240, "51.7", "Americas", "yes");
                yield return new Leinhardt(1191, "59.6", "Americas", "no");
                yield return new Leinhardt(425, "170", "Americas", "no");
                yield return new Leinhardt(590, "78", "Americas", "no");
                yield return new Leinhardt(426, "62.8", "Americas", "no");
                yield return new Leinhardt(725, "54.4", "Americas", "no");
                yield return new Leinhardt(406, "48.8", "Americas", "no");
                yield return new Leinhardt(1760, "27.8", "Europe", "no");
                yield return new Leinhardt(302, "79.1", "Americas", "no");
                yield return new Leinhardt(2526, "22.1", "Asia", "no");
                yield return new Leinhardt(727, "26.2", "Americas", "no");
                yield return new Leinhardt(631, "13.6", "Asia", "no");
                yield return new Leinhardt(295, "32", "Asia", "no");
                yield return new Leinhardt(684, "60.9", "Americas", "no");
                yield return new Leinhardt(507, "46", "Americas", "no");
                yield return new Leinhardt(754, "34.1", "Americas", "no");
                yield return new Leinhardt(335, "65.1", "Americas", "no");
                yield return new Leinhardt(1268, "20.4", "Asia", "no");
                yield return new Leinhardt(1256, "15.1", "Europe", "no");
                yield return new Leinhardt(261, "19.1", "Asia", "no");
                yield return new Leinhardt(732, "26.2", "Americas", "no");
                yield return new Leinhardt(434, "76.3", "Africa", "no");
                yield return new Leinhardt(799, "40.4", "Americas", "no");
                yield return new Leinhardt(406, "43.3", "Europe", "no");
                yield return new Leinhardt(310, "259", "Africa", "no");
                yield return new Leinhardt(200, "60.4", "Americas", "no");
                yield return new Leinhardt(100, "137", "Africa", "no");
                yield return new Leinhardt(281, "180", "Africa", "no");
                yield return new Leinhardt(210, "114", "Africa", "no");
                yield return new Leinhardt(319, "58.2", "Americas", "no");
                yield return new Leinhardt(217, "63.7", "Africa", "no");
                yield return new Leinhardt(284, "39.3", "Americas", "no");
                yield return new Leinhardt(387, "138", "Africa", "no");
                yield return new Leinhardt(334, "21.3", "Asia", "no");
                yield return new Leinhardt(344, "58", "Asia", "no");
                yield return new Leinhardt(197, "159.2", "Africa", "no");
                yield return new Leinhardt(279, "149", "Africa", "no");
                yield return new Leinhardt(477, "10.2", "Asia", "no");
                yield return new Leinhardt(347, "38.6", "Americas", "no");
                yield return new Leinhardt(230, "67.9", "Asia", "no");
                yield return new Leinhardt(334, "21.7", "Asia", "no");
                yield return new Leinhardt(210, "27", "Asia", "no");
                yield return new Leinhardt(435, "153", "Asia", "no");
                yield return new Leinhardt(130, "100", "Asia", "no");
                yield return new Leinhardt(75, "400", "Asia", "no");
                yield return new Leinhardt(100, "124.3", "Asia", "no");
                yield return new Leinhardt(73, "200", "Asia", "no");
                yield return new Leinhardt(68, "150", "Africa", "no");
                yield return new Leinhardt(123, "100", "Asia", "no");
                yield return new Leinhardt(122, "190", "Africa", "no");
                yield return new Leinhardt(70, "160", "Africa", "no");
                yield return new Leinhardt(81, "109.6", "Africa", "no");
                yield return new Leinhardt(79, "84.2", "Africa", "no");
                yield return new Leinhardt(79, "216", "Africa", "no");
                yield return new Leinhardt(100, null, "Americas", "no");
                yield return new Leinhardt(93, "60.6", "Asia", "no");
                yield return new Leinhardt(169, "55", "Africa", "no");
                yield return new Leinhardt(71, null, "Asia", "no");
                yield return new Leinhardt(120, "102", "Africa", "no");
                yield return new Leinhardt(130, "148.3", "Africa", "no");
                yield return new Leinhardt(50, "120", "Africa", "no");
                yield return new Leinhardt(174, "187", "Africa", "no");
                yield return new Leinhardt(90, null, "Asia", "no");
                yield return new Leinhardt(70, "200", "Africa", "no");
                yield return new Leinhardt(102, "124.3", "Asia", "no");
                yield return new Leinhardt(61, "132.9", "Africa", "no");
                yield return new Leinhardt(148, "170", "Africa", "no");
                yield return new Leinhardt(85, "158", "Africa", "no");
                yield return new Leinhardt(162, "45.1", "Asia", "no");
                yield return new Leinhardt(125, "129.4", "Africa", "no");
                yield return new Leinhardt(120, "162.5", "Africa", "no");
                yield return new Leinhardt(160, "127", "Africa", "no");
                yield return new Leinhardt(134, "160", "Africa", "no");
                yield return new Leinhardt(82, "180", "Africa", "no");
                yield return new Leinhardt(96, "80", "Asia", "no");
                yield return new Leinhardt(77, "50", "Asia", "no");
                yield return new Leinhardt(118, "104", "Africa", "no");
            }
        }
    }
}
