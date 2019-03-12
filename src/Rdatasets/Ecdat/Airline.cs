// ReSharper disable All

namespace Rdatasets.Ecdat
{
    using System.Collections.Generic;

    /// <summary>
    /// Cost for U.S. Airlines
    /// </summary>

    public class Airline
    {
        public readonly int κ;
        public readonly int airline;
        public readonly int year;
        public readonly int cost;
        public readonly double output;
        public readonly int pf;
        public readonly double lf;

        public Airline(int κ, int airline, int year, int cost, double output, int pf, double lf)
        {
            this.κ = κ;
            this.airline = airline;
            this.year = year;
            this.cost = cost;
            this.output = output;
            this.pf = pf;
            this.lf = lf;
        }

        public static IEnumerable<Airline> Data
        {
            get
            {
                yield return new Airline(1, 1, 1, 1140640, 0.952757, 106650, 0.534487);
                yield return new Airline(2, 1, 2, 1215690, 0.986757, 110307, 0.532328);
                yield return new Airline(3, 1, 3, 1309570, 1.09198, 110574, 0.547736);
                yield return new Airline(4, 1, 4, 1511530, 1.17578, 121974, 0.540846);
                yield return new Airline(5, 1, 5, 1676730, 1.16017, 196606, 0.591167);
                yield return new Airline(6, 1, 6, 1823740, 1.17376, 265609, 0.575417);
                yield return new Airline(7, 1, 7, 2022890, 1.29051, 263451, 0.594495);
                yield return new Airline(8, 1, 8, 2314760, 1.39067, 316411, 0.597409);
                yield return new Airline(9, 1, 9, 2639160, 1.61273, 384110, 0.638522);
                yield return new Airline(10, 1, 10, 3247620, 1.82544, 569251, 0.676287);
                yield return new Airline(11, 1, 11, 3787750, 1.54604, 871636, 0.605735);
                yield return new Airline(12, 1, 12, 3867750, 1.5279, 997239, 0.61436);
                yield return new Airline(13, 1, 13, 3996020, 1.6602, 938002, 0.633366);
                yield return new Airline(14, 1, 14, 4282880, 1.82231, 859572, 0.650117);
                yield return new Airline(15, 1, 15, 4748320, 1.93646, 823411, 0.625603);
                yield return new Airline(16, 2, 1, 569292, 0.520635, 103795, 0.490851);
                yield return new Airline(17, 2, 2, 640614, 0.534627, 111477, 0.473449);
                yield return new Airline(18, 2, 3, 777655, 0.655192, 118664, 0.503013);
                yield return new Airline(19, 2, 4, 999294, 0.791575, 114797, 0.512501);
                yield return new Airline(20, 2, 5, 1203970, 0.842945, 215322, 0.566782);
                yield return new Airline(21, 2, 6, 1358100, 0.852892, 281704, 0.558133);
                yield return new Airline(22, 2, 7, 1501350, 0.922843, 304818, 0.558799);
                yield return new Airline(23, 2, 8, 1709270, 1, 348609, 0.57207);
                yield return new Airline(24, 2, 9, 2025400, 1.19845, 374579, 0.624763);
                yield return new Airline(25, 2, 10, 2548370, 1.34067, 544109, 0.628706);
                yield return new Airline(26, 2, 11, 3137740, 1.32624, 853356, 0.58915);
                yield return new Airline(27, 2, 12, 3557700, 1.24852, 1003200, 0.532612);
                yield return new Airline(28, 2, 13, 3717740, 1.25432, 941977, 0.526652);
                yield return new Airline(29, 2, 14, 3962370, 1.37177, 856533, 0.540163);
                yield return new Airline(30, 2, 15, 4209390, 1.38974, 821361, 0.528775);
                yield return new Airline(31, 3, 1, 286298, 0.262424, 118788, 0.524334);
                yield return new Airline(32, 3, 2, 309290, 0.266433, 123798, 0.537185);
                yield return new Airline(33, 3, 3, 342056, 0.306043, 122882, 0.582119);
                yield return new Airline(34, 3, 4, 374595, 0.325586, 131274, 0.579489);
                yield return new Airline(35, 3, 5, 450037, 0.345706, 222037, 0.606592);
                yield return new Airline(36, 3, 6, 510412, 0.367517, 278721, 0.60727);
                yield return new Airline(37, 3, 7, 575347, 0.409937, 306564, 0.582425);
                yield return new Airline(38, 3, 8, 669331, 0.448023, 356073, 0.573972);
                yield return new Airline(39, 3, 9, 783799, 0.539595, 378311, 0.654256);
                yield return new Airline(40, 3, 10, 913883, 0.539382, 555267, 0.631055);
                yield return new Airline(41, 3, 11, 1041520, 0.467967, 850322, 0.56924);
                yield return new Airline(42, 3, 12, 1125800, 0.450544, 1015610, 0.589682);
                yield return new Airline(43, 3, 13, 1096070, 0.468793, 954508, 0.587953);
                yield return new Airline(44, 3, 14, 1198930, 0.494397, 886999, 0.565388);
                yield return new Airline(45, 3, 15, 1170470, 0.493317, 844079, 0.577078);
                yield return new Airline(46, 4, 1, 145167, 0.086393, 114987, 0.432066);
                yield return new Airline(47, 4, 2, 170192, 0.09674, 120501, 0.439669);
                yield return new Airline(48, 4, 3, 247506, 0.1415, 121908, 0.488932);
                yield return new Airline(49, 4, 4, 309391, 0.169715, 127220, 0.484181);
                yield return new Airline(50, 4, 5, 354338, 0.173805, 209405, 0.529925);
                yield return new Airline(51, 4, 6, 373941, 0.164272, 263148, 0.532723);
                yield return new Airline(52, 4, 7, 420915, 0.170906, 316724, 0.549067);
                yield return new Airline(53, 4, 8, 474017, 0.17784, 363598, 0.55714);
                yield return new Airline(54, 4, 9, 532590, 0.192248, 389436, 0.611377);
                yield return new Airline(55, 4, 10, 676771, 0.242469, 547376, 0.645319);
                yield return new Airline(56, 4, 11, 880438, 0.256505, 850418, 0.611734);
                yield return new Airline(57, 4, 12, 1052020, 0.249657, 1011170, 0.580884);
                yield return new Airline(58, 4, 13, 1193680, 0.273923, 951934, 0.572047);
                yield return new Airline(59, 4, 14, 1303390, 0.371131, 881323, 0.59457);
                yield return new Airline(60, 4, 15, 1436970, 0.421411, 831374, 0.585525);
                yield return new Airline(61, 5, 1, 91361, 0.051028, 118222, 0.442875);
                yield return new Airline(62, 5, 2, 95428, 0.052646, 116223, 0.462473);
                yield return new Airline(63, 5, 3, 98187, 0.056348, 115853, 0.519118);
                yield return new Airline(64, 5, 4, 115967, 0.066953, 129372, 0.529331);
                yield return new Airline(65, 5, 5, 138382, 0.070308, 243266, 0.557797);
                yield return new Airline(66, 5, 6, 156228, 0.073961, 277930, 0.556181);
                yield return new Airline(67, 5, 7, 183169, 0.084946, 317273, 0.569327);
                yield return new Airline(68, 5, 8, 210212, 0.095474, 358794, 0.583465);
                yield return new Airline(69, 5, 9, 274024, 0.119814, 397667, 0.631818);
                yield return new Airline(70, 5, 10, 356915, 0.150046, 566672, 0.604723);
                yield return new Airline(71, 5, 11, 432344, 0.144014, 848393, 0.587921);
                yield return new Airline(72, 5, 12, 524294, 0.1693, 1005740, 0.616159);
                yield return new Airline(73, 5, 13, 530924, 0.172761, 958231, 0.605868);
                yield return new Airline(74, 5, 14, 581447, 0.18667, 872924, 0.594688);
                yield return new Airline(75, 5, 15, 610257, 0.213279, 844622, 0.635545);
                yield return new Airline(76, 6, 1, 68978, 0.037682, 117112, 0.448539);
                yield return new Airline(77, 6, 2, 74904, 0.039784, 119420, 0.475889);
                yield return new Airline(78, 6, 3, 83829, 0.044331, 116087, 0.500562);
                yield return new Airline(79, 6, 4, 98148, 0.050245, 122997, 0.500344);
                yield return new Airline(80, 6, 5, 118449, 0.055046, 194309, 0.528897);
                yield return new Airline(81, 6, 6, 133161, 0.052462, 307923, 0.495361);
                yield return new Airline(82, 6, 7, 145062, 0.056977, 323595, 0.510342);
                yield return new Airline(83, 6, 8, 170711, 0.06149, 363081, 0.518296);
                yield return new Airline(84, 6, 9, 199775, 0.069027, 386422, 0.546723);
                yield return new Airline(85, 6, 10, 276797, 0.092749, 564867, 0.554276);
                yield return new Airline(86, 6, 11, 381478, 0.11264, 874818, 0.517766);
                yield return new Airline(87, 6, 12, 506969, 0.154154, 1013170, 0.580049);
                yield return new Airline(88, 6, 13, 633388, 0.186461, 930477, 0.556024);
                yield return new Airline(89, 6, 14, 804388, 0.246847, 851676, 0.537791);
                yield return new Airline(90, 6, 15, 1009500, 0.304013, 819476, 0.525775);
            }
        }
    }
}
