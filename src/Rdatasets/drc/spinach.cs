// ReSharper disable All

namespace Rdatasets.drc
{
    using System.Collections.Generic;

    /// <summary>
    /// Inhibition of photosynthesis
    /// </summary>

    public class spinach
    {
        public readonly int κ;
        public readonly int CURVE;
        public readonly string HERBICIDE;
        public readonly double DOSE;
        public readonly string SLOPE;

        public spinach(int κ, int CURVE, string HERBICIDE, double DOSE, string SLOPE)
        {
            this.κ = κ;
            this.CURVE = CURVE;
            this.HERBICIDE = HERBICIDE;
            this.DOSE = DOSE;
            this.SLOPE = SLOPE;
        }

        public static IEnumerable<spinach> Data
        {
            get
            {
                yield return new spinach(1, 1, "bentazon", 0, "1.81295");
                yield return new spinach(2, 1, "bentazon", 0, "1.86704");
                yield return new spinach(3, 1, "bentazon", 0, "1.95606");
                yield return new spinach(4, 1, "bentazon", 0.62, "1.39073");
                yield return new spinach(5, 1, "bentazon", 0.62, "1.15721");
                yield return new spinach(6, 1, "bentazon", 0.62, "1.06126");
                yield return new spinach(7, 1, "bentazon", 1.85, "0.99409");
                yield return new spinach(8, 1, "bentazon", 1.85, "0.83298");
                yield return new spinach(9, 1, "bentazon", 1.85, "0.8334");
                yield return new spinach(10, 1, "bentazon", 5.56, "0.72513");
                yield return new spinach(11, 1, "bentazon", 5.56, "0.69548");
                yield return new spinach(12, 1, "bentazon", 5.56, "0.65299");
                yield return new spinach(13, 1, "bentazon", 16.67, "0.49855");
                yield return new spinach(14, 1, "bentazon", 16.67, "0.36873");
                yield return new spinach(15, 1, "bentazon", 16.67, "0.42617");
                yield return new spinach(16, 1, "bentazon", 50, "0.26666");
                yield return new spinach(17, 1, "bentazon", 50, "0.26896");
                yield return new spinach(18, 1, "bentazon", 50, "0.25989");
                yield return new spinach(19, 1, "bentazon", 150, "0.16074");
                yield return new spinach(20, 1, "bentazon", 150, "0.16404");
                yield return new spinach(21, 1, "bentazon", 150, "0.1475");
                yield return new spinach(22, 2, "bentazon", 0, "1.02654");
                yield return new spinach(23, 2, "bentazon", 0, "0.91306");
                yield return new spinach(24, 2, "bentazon", 0, "0.89371");
                yield return new spinach(25, 2, "bentazon", 0.62, "0.59074");
                yield return new spinach(26, 2, "bentazon", 0.62, "0.669");
                yield return new spinach(27, 2, "bentazon", 0.62, "0.5965");
                yield return new spinach(28, 2, "bentazon", 1.85, "0.37561");
                yield return new spinach(29, 2, "bentazon", 1.85, "0.44823");
                yield return new spinach(30, 2, "bentazon", 1.85, "0.42093");
                yield return new spinach(31, 2, "bentazon", 5.56, "0.31874");
                yield return new spinach(32, 2, "bentazon", 5.56, "0.27342");
                yield return new spinach(33, 2, "bentazon", 5.56, "0.2725");
                yield return new spinach(34, 2, "bentazon", 16.67, "0.27182");
                yield return new spinach(35, 2, "bentazon", 16.67, "0.21752");
                yield return new spinach(36, 2, "bentazon", 16.67, "0.19981");
                yield return new spinach(37, 2, "bentazon", 50, "0.17332");
                yield return new spinach(38, 2, "bentazon", 50, "0.17949");
                yield return new spinach(39, 2, "bentazon", 50, "0.15623");
                yield return new spinach(40, 2, "bentazon", 150, "0.12855");
                yield return new spinach(41, 2, "bentazon", 150, "0.14524");
                yield return new spinach(42, 2, "bentazon", 150, "0.11533");
                yield return new spinach(43, 3, "bentazon", 0, "1.03872");
                yield return new spinach(44, 3, "bentazon", 0, "1.0917");
                yield return new spinach(45, 3, "bentazon", 0, "1.10324");
                yield return new spinach(46, 3, "bentazon", 0.15, "0.94274");
                yield return new spinach(47, 3, "bentazon", 0.15, "0.91256");
                yield return new spinach(48, 3, "bentazon", 0.15, "1.02352");
                yield return new spinach(49, 3, "bentazon", 0.59, "0.78689");
                yield return new spinach(50, 3, "bentazon", 0.59, "0.69706");
                yield return new spinach(51, 3, "bentazon", 0.59, "0.65989");
                yield return new spinach(52, 3, "bentazon", 2.34, "0.5372");
                yield return new spinach(53, 3, "bentazon", 2.34, "0.51324");
                yield return new spinach(54, 3, "bentazon", 2.34, "0.54981");
                yield return new spinach(55, 3, "bentazon", 9.38, "0.37401");
                yield return new spinach(56, 3, "bentazon", 9.38, "0.34033");
                yield return new spinach(57, 3, "bentazon", 9.38, "0.32491");
                yield return new spinach(58, 3, "bentazon", 37.5, "0.30518");
                yield return new spinach(59, 3, "bentazon", 37.5, "0.24593");
                yield return new spinach(60, 3, "bentazon", 37.5, "0.289");
                yield return new spinach(61, 3, "bentazon", 150, "0.17414");
                yield return new spinach(62, 3, "bentazon", 150, "0.12275");
                yield return new spinach(63, 3, "bentazon", 150, "0.14788");
                yield return new spinach(64, 4, "diuron", 0, "2.20963");
                yield return new spinach(65, 4, "diuron", 0, "2.27931");
                yield return new spinach(66, 4, "diuron", 0, "2.14703");
                yield return new spinach(67, 4, "diuron", 0.01, "2.18831");
                yield return new spinach(68, 4, "diuron", 0.01, "2.08863");
                yield return new spinach(69, 4, "diuron", 0.01, "2.06676");
                yield return new spinach(70, 4, "diuron", 0.03, "2.18827");
                yield return new spinach(71, 4, "diuron", 0.03, "2.10748");
                yield return new spinach(72, 4, "diuron", 0.03, "1.84474");
                yield return new spinach(73, 4, "diuron", 0.1, "1.78805");
                yield return new spinach(74, 4, "diuron", 0.1, "1.75547");
                yield return new spinach(75, 4, "diuron", 0.1, "1.61381");
                yield return new spinach(76, 4, "diuron", 0.3, "0.70295");
                yield return new spinach(77, 4, "diuron", 0.3, "0.6983");
                yield return new spinach(78, 4, "diuron", 0.3, "0.74045");
                yield return new spinach(79, 4, "diuron", 1, "0.20673");
                yield return new spinach(80, 4, "diuron", 1, "0.20784");
                yield return new spinach(81, 4, "diuron", 1, "0.22402");
                yield return new spinach(82, 4, "diuron", 3, "0.05268");
                yield return new spinach(83, 4, "diuron", 3, "0.06519");
                yield return new spinach(84, 4, "diuron", 3, "0.09258");
                yield return new spinach(85, 5, "diuron", 0, "1.94033");
                yield return new spinach(86, 5, "diuron", 0, "1.80193");
                yield return new spinach(87, 5, "diuron", 0, "1.71586");
                yield return new spinach(88, 5, "diuron", 0.01, "1.71586");
                yield return new spinach(89, 5, "diuron", 0.01, "1.98471");
                yield return new spinach(90, 5, "diuron", 0.01, "1.74905");
                yield return new spinach(91, 5, "diuron", 0.03, "1.87795");
                yield return new spinach(92, 5, "diuron", 0.03, "1.64081");
                yield return new spinach(93, 5, "diuron", 0.03, "1.53094");
                yield return new spinach(94, 5, "diuron", 0.1, "1.50709");
                yield return new spinach(95, 5, "diuron", 0.1, "1.41035");
                yield return new spinach(96, 5, "diuron", 0.1, "1.35367");
                yield return new spinach(97, 5, "diuron", 0.3, "0.64427");
                yield return new spinach(98, 5, "diuron", 0.3, "0.62185");
                yield return new spinach(99, 5, "diuron", 0.3, "0.60337");
                yield return new spinach(100, 5, "diuron", 1, "0.14073");
                yield return new spinach(101, 5, "diuron", 1, "0.12928");
                yield return new spinach(102, 5, "diuron", 1, "0.15016");
                yield return new spinach(103, 5, "diuron", 3, "8e-05");
                yield return new spinach(104, 5, "diuron", 3, "0.00262");
                yield return new spinach(105, 5, "diuron", 3, "0.00303");
            }
        }
    }
}
