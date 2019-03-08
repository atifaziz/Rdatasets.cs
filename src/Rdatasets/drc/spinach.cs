// ReSharper disable All

namespace Rdatasets.drc
{
    using System.Collections.Generic;

    /// <summary>
    /// Inhibition of photosynthesis
    /// </summary>

    public class spinach
    {
        public readonly int CURVE;
        public readonly string HERBICIDE;
        public readonly double DOSE;
        public readonly string SLOPE;

        public spinach(int CURVE, string HERBICIDE, double DOSE, string SLOPE)
        {
            this.CURVE = CURVE;
            this.HERBICIDE = HERBICIDE;
            this.DOSE = DOSE;
            this.SLOPE = SLOPE;
        }

        public static IEnumerable<spinach> Data
        {
            get
            {
                yield return new spinach(1, "bentazon", 0, "1.81295");
                yield return new spinach(1, "bentazon", 0, "1.86704");
                yield return new spinach(1, "bentazon", 0, "1.95606");
                yield return new spinach(1, "bentazon", 0.62, "1.39073");
                yield return new spinach(1, "bentazon", 0.62, "1.15721");
                yield return new spinach(1, "bentazon", 0.62, "1.06126");
                yield return new spinach(1, "bentazon", 1.85, "0.99409");
                yield return new spinach(1, "bentazon", 1.85, "0.83298");
                yield return new spinach(1, "bentazon", 1.85, "0.8334");
                yield return new spinach(1, "bentazon", 5.56, "0.72513");
                yield return new spinach(1, "bentazon", 5.56, "0.69548");
                yield return new spinach(1, "bentazon", 5.56, "0.65299");
                yield return new spinach(1, "bentazon", 16.67, "0.49855");
                yield return new spinach(1, "bentazon", 16.67, "0.36873");
                yield return new spinach(1, "bentazon", 16.67, "0.42617");
                yield return new spinach(1, "bentazon", 50, "0.26666");
                yield return new spinach(1, "bentazon", 50, "0.26896");
                yield return new spinach(1, "bentazon", 50, "0.25989");
                yield return new spinach(1, "bentazon", 150, "0.16074");
                yield return new spinach(1, "bentazon", 150, "0.16404");
                yield return new spinach(1, "bentazon", 150, "0.1475");
                yield return new spinach(2, "bentazon", 0, "1.02654");
                yield return new spinach(2, "bentazon", 0, "0.91306");
                yield return new spinach(2, "bentazon", 0, "0.89371");
                yield return new spinach(2, "bentazon", 0.62, "0.59074");
                yield return new spinach(2, "bentazon", 0.62, "0.669");
                yield return new spinach(2, "bentazon", 0.62, "0.5965");
                yield return new spinach(2, "bentazon", 1.85, "0.37561");
                yield return new spinach(2, "bentazon", 1.85, "0.44823");
                yield return new spinach(2, "bentazon", 1.85, "0.42093");
                yield return new spinach(2, "bentazon", 5.56, "0.31874");
                yield return new spinach(2, "bentazon", 5.56, "0.27342");
                yield return new spinach(2, "bentazon", 5.56, "0.2725");
                yield return new spinach(2, "bentazon", 16.67, "0.27182");
                yield return new spinach(2, "bentazon", 16.67, "0.21752");
                yield return new spinach(2, "bentazon", 16.67, "0.19981");
                yield return new spinach(2, "bentazon", 50, "0.17332");
                yield return new spinach(2, "bentazon", 50, "0.17949");
                yield return new spinach(2, "bentazon", 50, "0.15623");
                yield return new spinach(2, "bentazon", 150, "0.12855");
                yield return new spinach(2, "bentazon", 150, "0.14524");
                yield return new spinach(2, "bentazon", 150, "0.11533");
                yield return new spinach(3, "bentazon", 0, "1.03872");
                yield return new spinach(3, "bentazon", 0, "1.0917");
                yield return new spinach(3, "bentazon", 0, "1.10324");
                yield return new spinach(3, "bentazon", 0.15, "0.94274");
                yield return new spinach(3, "bentazon", 0.15, "0.91256");
                yield return new spinach(3, "bentazon", 0.15, "1.02352");
                yield return new spinach(3, "bentazon", 0.59, "0.78689");
                yield return new spinach(3, "bentazon", 0.59, "0.69706");
                yield return new spinach(3, "bentazon", 0.59, "0.65989");
                yield return new spinach(3, "bentazon", 2.34, "0.5372");
                yield return new spinach(3, "bentazon", 2.34, "0.51324");
                yield return new spinach(3, "bentazon", 2.34, "0.54981");
                yield return new spinach(3, "bentazon", 9.38, "0.37401");
                yield return new spinach(3, "bentazon", 9.38, "0.34033");
                yield return new spinach(3, "bentazon", 9.38, "0.32491");
                yield return new spinach(3, "bentazon", 37.5, "0.30518");
                yield return new spinach(3, "bentazon", 37.5, "0.24593");
                yield return new spinach(3, "bentazon", 37.5, "0.289");
                yield return new spinach(3, "bentazon", 150, "0.17414");
                yield return new spinach(3, "bentazon", 150, "0.12275");
                yield return new spinach(3, "bentazon", 150, "0.14788");
                yield return new spinach(4, "diuron", 0, "2.20963");
                yield return new spinach(4, "diuron", 0, "2.27931");
                yield return new spinach(4, "diuron", 0, "2.14703");
                yield return new spinach(4, "diuron", 0.01, "2.18831");
                yield return new spinach(4, "diuron", 0.01, "2.08863");
                yield return new spinach(4, "diuron", 0.01, "2.06676");
                yield return new spinach(4, "diuron", 0.03, "2.18827");
                yield return new spinach(4, "diuron", 0.03, "2.10748");
                yield return new spinach(4, "diuron", 0.03, "1.84474");
                yield return new spinach(4, "diuron", 0.1, "1.78805");
                yield return new spinach(4, "diuron", 0.1, "1.75547");
                yield return new spinach(4, "diuron", 0.1, "1.61381");
                yield return new spinach(4, "diuron", 0.3, "0.70295");
                yield return new spinach(4, "diuron", 0.3, "0.6983");
                yield return new spinach(4, "diuron", 0.3, "0.74045");
                yield return new spinach(4, "diuron", 1, "0.20673");
                yield return new spinach(4, "diuron", 1, "0.20784");
                yield return new spinach(4, "diuron", 1, "0.22402");
                yield return new spinach(4, "diuron", 3, "0.05268");
                yield return new spinach(4, "diuron", 3, "0.06519");
                yield return new spinach(4, "diuron", 3, "0.09258");
                yield return new spinach(5, "diuron", 0, "1.94033");
                yield return new spinach(5, "diuron", 0, "1.80193");
                yield return new spinach(5, "diuron", 0, "1.71586");
                yield return new spinach(5, "diuron", 0.01, "1.71586");
                yield return new spinach(5, "diuron", 0.01, "1.98471");
                yield return new spinach(5, "diuron", 0.01, "1.74905");
                yield return new spinach(5, "diuron", 0.03, "1.87795");
                yield return new spinach(5, "diuron", 0.03, "1.64081");
                yield return new spinach(5, "diuron", 0.03, "1.53094");
                yield return new spinach(5, "diuron", 0.1, "1.50709");
                yield return new spinach(5, "diuron", 0.1, "1.41035");
                yield return new spinach(5, "diuron", 0.1, "1.35367");
                yield return new spinach(5, "diuron", 0.3, "0.64427");
                yield return new spinach(5, "diuron", 0.3, "0.62185");
                yield return new spinach(5, "diuron", 0.3, "0.60337");
                yield return new spinach(5, "diuron", 1, "0.14073");
                yield return new spinach(5, "diuron", 1, "0.12928");
                yield return new spinach(5, "diuron", 1, "0.15016");
                yield return new spinach(5, "diuron", 3, "8e-05");
                yield return new spinach(5, "diuron", 3, "0.00262");
                yield return new spinach(5, "diuron", 3, "0.00303");
            }
        }
    }
}
