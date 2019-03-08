// ReSharper disable All

namespace Rdatasets.drc
{
    using System.Collections.Generic;

    /// <summary>
    /// Mechlorprop and terbythylazine tested on Lemna minor
    /// </summary>

    public class mecter
    {
        public readonly int dose;
        public readonly int pct;
        public readonly double rgr;

        public mecter(int dose, int pct, double rgr)
        {
            this.dose = dose;
            this.pct = pct;
            this.rgr = rgr;
        }

        public static IEnumerable<mecter> Data
        {
            get
            {
                yield return new mecter(0, 999, 0.293726713);
                yield return new mecter(0, 999, 0.290214555);
                yield return new mecter(0, 999, 0.408123234);
                yield return new mecter(0, 999, 0.274742662);
                yield return new mecter(0, 999, 0.26766742);
                yield return new mecter(0, 999, 0.288626845);
                yield return new mecter(0, 999, 0.275329308);
                yield return new mecter(0, 999, 0.303009934);
                yield return new mecter(0, 999, 0.29956711);
                yield return new mecter(0, 999, 0.275279886);
                yield return new mecter(0, 999, 0.267620355);
                yield return new mecter(0, 999, 0.276377454);
                yield return new mecter(1024, 100, 0.281886101);
                yield return new mecter(1024, 100, 0.285999153);
                yield return new mecter(1024, 100, 0.280001664);
                yield return new mecter(2560, 100, 0.255480114);
                yield return new mecter(2560, 100, 0.235606553);
                yield return new mecter(2560, 100, 0.250240023);
                yield return new mecter(6400, 100, 0.215583987);
                yield return new mecter(6400, 100, 0.191535962);
                yield return new mecter(6400, 100, 0.204105682);
                yield return new mecter(16000, 100, 0.162190894);
                yield return new mecter(16000, 100, 0.14319896);
                yield return new mecter(16000, 100, 0.173528609);
                yield return new mecter(40000, 100, 0.012026506);
                yield return new mecter(40000, 100, 0.011789853);
                yield return new mecter(40000, 100, -0.005967201);
                yield return new mecter(100000, 100, -0.002178111);
                yield return new mecter(100000, 100, -0.003074334);
                yield return new mecter(100000, 100, -0.010631828);
                yield return new mecter(1024, 75, 0.303592586);
                yield return new mecter(1024, 75, 0.317949341);
                yield return new mecter(1024, 75, 0.299087133);
                yield return new mecter(2560, 75, 0.288929512);
                yield return new mecter(2560, 75, 0.308488577);
                yield return new mecter(2560, 75, 0.309697206);
                yield return new mecter(6400, 75, 0.271305033);
                yield return new mecter(6400, 75, 0.26117919);
                yield return new mecter(6400, 75, 0.275695036);
                yield return new mecter(16000, 75, 0.164165935);
                yield return new mecter(16000, 75, 0.181943837);
                yield return new mecter(16000, 75, 0.16935227);
                yield return new mecter(40000, 75, 0.108353974);
                yield return new mecter(40000, 75, 0.118120303);
                yield return new mecter(40000, 75, 0.113293626);
                yield return new mecter(100000, 75, 0.0190647);
                yield return new mecter(100000, 75, 0.011733692);
                yield return new mecter(100000, 75, 0.052485174);
                yield return new mecter(1024, 50, 0.2937648);
                yield return new mecter(1024, 50, 0.313745132);
                yield return new mecter(1024, 50, 0.320127094);
                yield return new mecter(2560, 50, 0.285723619);
                yield return new mecter(2560, 50, 0.301751401);
                yield return new mecter(2560, 50, 0.309118149);
                yield return new mecter(6400, 50, 0.259603096);
                yield return new mecter(6400, 50, 0.249605976);
                yield return new mecter(6400, 50, 0.286085368);
                yield return new mecter(16000, 50, 0.161284481);
                yield return new mecter(16000, 50, 0.17869189);
                yield return new mecter(16000, 50, 0.16391615);
                yield return new mecter(40000, 50, 0.113088103);
                yield return new mecter(40000, 50, 0.104354377);
                yield return new mecter(40000, 50, 0.091819366);
                yield return new mecter(100000, 50, 0.094392522);
                yield return new mecter(100000, 50, 0.006761336);
                yield return new mecter(100000, 50, -0.003144108);
                yield return new mecter(1024, 25, 0.244500506);
                yield return new mecter(1024, 25, 0.256438076);
                yield return new mecter(1024, 25, 0.265605304);
                yield return new mecter(2560, 25, 0.221768193);
                yield return new mecter(2560, 25, 0.226489353);
                yield return new mecter(2560, 25, 0.240990769);
                yield return new mecter(6400, 25, 0.208155109);
                yield return new mecter(6400, 25, 0.210848444);
                yield return new mecter(6400, 25, 0.258197193);
                yield return new mecter(16000, 25, 0.121002597);
                yield return new mecter(16000, 25, 0.14325961);
                yield return new mecter(16000, 25, 0.196410423);
                yield return new mecter(40000, 25, 0.069673546);
                yield return new mecter(40000, 25, 0.108514343);
                yield return new mecter(40000, 25, 0.067263749);
                yield return new mecter(100000, 25, -0.000477791);
                yield return new mecter(100000, 25, -0.012296428);
                yield return new mecter(100000, 25, -0.004769964);
                yield return new mecter(1024, 0, 0.31223592);
                yield return new mecter(1024, 0, 0.309772862);
                yield return new mecter(1024, 0, 0.308196513);
                yield return new mecter(2560, 0, 0.25250223);
                yield return new mecter(2560, 0, 0.28236495);
                yield return new mecter(2560, 0, 0.268927576);
                yield return new mecter(6400, 0, 0.235784375);
                yield return new mecter(6400, 0, 0.225837736);
                yield return new mecter(6400, 0, 0.234110866);
                yield return new mecter(16000, 0, 0.126068691);
                yield return new mecter(16000, 0, 0.121992329);
                yield return new mecter(16000, 0, 0.148191912);
                yield return new mecter(40000, 0, 0.075904577);
                yield return new mecter(40000, 0, 0.058909219);
                yield return new mecter(40000, 0, 0.067530086);
                yield return new mecter(100000, 0, 0.030367365);
                yield return new mecter(100000, 0, 0.024563507);
                yield return new mecter(100000, 0, 0.020057414);
            }
        }
    }
}
