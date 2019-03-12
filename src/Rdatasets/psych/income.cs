// ReSharper disable All

namespace Rdatasets.psych
{
    using System.Collections.Generic;

    /// <summary>
    /// US family income from US census 2008
    /// </summary>

    public class income
    {
        public readonly int κ;
        public readonly int value;
        public readonly int count;
        public readonly int mean;
        public readonly double prop;

        public income(int κ, int value, int count, int mean, double prop)
        {
            this.κ = κ;
            this.value = value;
            this.count = count;
            this.mean = mean;
            this.prop = prop;
        }

        public static IEnumerable<income> Data
        {
            get
            {
                yield return new income(1, 0, 2588, 298, 0.0220851147350725);
                yield return new income(2, 2500, 971, 3792, 0.00828618485616514);
                yield return new income(3, 5000, 1677, 6261, 0.0143109495404624);
                yield return new income(4, 7500, 3141, 8705, 0.0268042292824044);
                yield return new income(5, 10000, 3684, 11223, 0.0314380072194772);
                yield return new income(6, 12500, 3163, 13687, 0.0269919698249746);
                yield return new income(7, 15000, 3600, 16074, 0.0307211796933002);
                yield return new income(8, 17500, 3116, 18662, 0.0265908877567565);
                yield return new income(9, 20000, 3967, 21064, 0.0338530332898117);
                yield return new income(10, 22500, 3117, 23698, 0.0265994214177824);
                yield return new income(11, 25000, 3620, 26003, 0.0308918529138186);
                yield return new income(12, 27500, 2808, 28637, 0.0239625201607742);
                yield return new income(13, 30000, 3736, 30982, 0.0318817575928249);
                yield return new income(14, 32500, 2569, 33706, 0.0219229751755801);
                yield return new income(15, 35000, 3517, 35966, 0.0300128858281491);
                yield return new income(16, 37500, 2483, 38664, 0.0211890803273512);
                yield return new income(17, 40000, 3343, 40970, 0.0285280288096396);
                yield return new income(18, 42500, 2250, 43635, 0.0192007373083126);
                yield return new income(19, 45000, 2698, 45964, 0.0230238174479233);
                yield return new income(20, 47500, 2141, 48639, 0.0182705682564877);
                yield return new income(21, 50000, 3325, 50939, 0.0283744229111731);
                yield return new income(22, 52500, 1822, 53679, 0.0155483303892203);
                yield return new income(23, 55000, 2311, 56004, 0.0197212906308936);
                yield return new income(24, 57500, 1776, 58637, 0.0151557819820281);
                yield return new income(25, 60000, 2784, 60923, 0.0237577122961522);
                yield return new income(26, 62500, 1666, 63684, 0.0142170792691773);
                yield return new income(27, 65000, 2096, 65950, 0.0178865535103215);
                yield return new income(28, 67500, 1502, 68595, 0.0128175588609269);
                yield return new income(29, 70000, 2203, 71004, 0.0187996552400946);
                yield return new income(30, 72500, 1492, 73673, 0.0127322222506678);
                yield return new income(31, 75000, 2051, 75923, 0.0175025387641552);
                yield return new income(32, 77500, 1337, 78621, 0.0114095047916507);
                yield return new income(33, 80000, 1870, 80918, 0.0159579461184643);
                yield return new income(34, 82500, 1207, 83692, 0.0103001288582815);
                yield return new income(35, 85000, 1555, 85985, 0.0132698428953005);
                yield return new income(36, 87500, 1220, 88603, 0.0104110664516184);
                yield return new income(37, 90000, 1575, 90955, 0.0134405161158188);
                yield return new income(38, 92500, 1010, 93628, 0.0086189976361759);
                yield return new income(39, 95000, 1290, 96048, 0.0110084227234326);
                yield return new income(40, 97500, 889, 98649, 0.00758642465203997);
                yield return new income(41, 100000, 14286, 119762, 0.121911881416246);
                yield return new income(42, 150000, 5250, 169550, 0.0448017203860628);
                yield return new income(43, 200000, 2001, 218319, 0.0170758557128594);
                yield return new income(44, 250000, 2476, 415517, 0.0211293447001698);
            }
        }
    }
}
