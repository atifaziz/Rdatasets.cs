// ReSharper disable All

namespace Rdatasets.datasets
{
    using System.Collections.Generic;

    /// <summary>
    /// Elisa assay of DNase
    /// </summary>

    public class DNase
    {
        public readonly int Run;
        public readonly double conc;
        public readonly double density;

        public DNase(int Run, double conc, double density)
        {
            this.Run = Run;
            this.conc = conc;
            this.density = density;
        }

        public static IEnumerable<DNase> Data
        {
            get
            {
                yield return new DNase(1, 0.04882812, 0.017);
                yield return new DNase(1, 0.04882812, 0.018);
                yield return new DNase(1, 0.1953125, 0.121);
                yield return new DNase(1, 0.1953125, 0.124);
                yield return new DNase(1, 0.390625, 0.206);
                yield return new DNase(1, 0.390625, 0.215);
                yield return new DNase(1, 0.78125, 0.377);
                yield return new DNase(1, 0.78125, 0.374);
                yield return new DNase(1, 1.5625, 0.614);
                yield return new DNase(1, 1.5625, 0.609);
                yield return new DNase(1, 3.125, 1.019);
                yield return new DNase(1, 3.125, 1.001);
                yield return new DNase(1, 6.25, 1.334);
                yield return new DNase(1, 6.25, 1.364);
                yield return new DNase(1, 12.5, 1.73);
                yield return new DNase(1, 12.5, 1.71);
                yield return new DNase(2, 0.04882812, 0.045);
                yield return new DNase(2, 0.04882812, 0.05);
                yield return new DNase(2, 0.1953125, 0.137);
                yield return new DNase(2, 0.1953125, 0.123);
                yield return new DNase(2, 0.390625, 0.225);
                yield return new DNase(2, 0.390625, 0.207);
                yield return new DNase(2, 0.78125, 0.401);
                yield return new DNase(2, 0.78125, 0.383);
                yield return new DNase(2, 1.5625, 0.672);
                yield return new DNase(2, 1.5625, 0.681);
                yield return new DNase(2, 3.125, 1.116);
                yield return new DNase(2, 3.125, 1.078);
                yield return new DNase(2, 6.25, 1.554);
                yield return new DNase(2, 6.25, 1.526);
                yield return new DNase(2, 12.5, 1.932);
                yield return new DNase(2, 12.5, 1.914);
                yield return new DNase(3, 0.04882812, 0.07);
                yield return new DNase(3, 0.04882812, 0.068);
                yield return new DNase(3, 0.1953125, 0.173);
                yield return new DNase(3, 0.1953125, 0.165);
                yield return new DNase(3, 0.390625, 0.277);
                yield return new DNase(3, 0.390625, 0.248);
                yield return new DNase(3, 0.78125, 0.434);
                yield return new DNase(3, 0.78125, 0.426);
                yield return new DNase(3, 1.5625, 0.703);
                yield return new DNase(3, 1.5625, 0.689);
                yield return new DNase(3, 3.125, 1.067);
                yield return new DNase(3, 3.125, 1.077);
                yield return new DNase(3, 6.25, 1.629);
                yield return new DNase(3, 6.25, 1.479);
                yield return new DNase(3, 12.5, 2.003);
                yield return new DNase(3, 12.5, 1.884);
                yield return new DNase(4, 0.04882812, 0.011);
                yield return new DNase(4, 0.04882812, 0.016);
                yield return new DNase(4, 0.1953125, 0.118);
                yield return new DNase(4, 0.1953125, 0.108);
                yield return new DNase(4, 0.390625, 0.2);
                yield return new DNase(4, 0.390625, 0.206);
                yield return new DNase(4, 0.78125, 0.364);
                yield return new DNase(4, 0.78125, 0.36);
                yield return new DNase(4, 1.5625, 0.62);
                yield return new DNase(4, 1.5625, 0.64);
                yield return new DNase(4, 3.125, 0.979);
                yield return new DNase(4, 3.125, 0.973);
                yield return new DNase(4, 6.25, 1.424);
                yield return new DNase(4, 6.25, 1.399);
                yield return new DNase(4, 12.5, 1.74);
                yield return new DNase(4, 12.5, 1.732);
                yield return new DNase(5, 0.04882812, 0.035);
                yield return new DNase(5, 0.04882812, 0.035);
                yield return new DNase(5, 0.1953125, 0.132);
                yield return new DNase(5, 0.1953125, 0.135);
                yield return new DNase(5, 0.390625, 0.224);
                yield return new DNase(5, 0.390625, 0.22);
                yield return new DNase(5, 0.78125, 0.385);
                yield return new DNase(5, 0.78125, 0.39);
                yield return new DNase(5, 1.5625, 0.658);
                yield return new DNase(5, 1.5625, 0.647);
                yield return new DNase(5, 3.125, 1.06);
                yield return new DNase(5, 3.125, 1.031);
                yield return new DNase(5, 6.25, 1.425);
                yield return new DNase(5, 6.25, 1.409);
                yield return new DNase(5, 12.5, 1.75);
                yield return new DNase(5, 12.5, 1.738);
                yield return new DNase(6, 0.04882812, 0.086);
                yield return new DNase(6, 0.04882812, 0.103);
                yield return new DNase(6, 0.1953125, 0.191);
                yield return new DNase(6, 0.1953125, 0.189);
                yield return new DNase(6, 0.390625, 0.272);
                yield return new DNase(6, 0.390625, 0.277);
                yield return new DNase(6, 0.78125, 0.44);
                yield return new DNase(6, 0.78125, 0.426);
                yield return new DNase(6, 1.5625, 0.686);
                yield return new DNase(6, 1.5625, 0.676);
                yield return new DNase(6, 3.125, 1.062);
                yield return new DNase(6, 3.125, 1.072);
                yield return new DNase(6, 6.25, 1.424);
                yield return new DNase(6, 6.25, 1.459);
                yield return new DNase(6, 12.5, 1.768);
                yield return new DNase(6, 12.5, 1.806);
                yield return new DNase(7, 0.04882812, 0.094);
                yield return new DNase(7, 0.04882812, 0.092);
                yield return new DNase(7, 0.1953125, 0.182);
                yield return new DNase(7, 0.1953125, 0.182);
                yield return new DNase(7, 0.390625, 0.282);
                yield return new DNase(7, 0.390625, 0.273);
                yield return new DNase(7, 0.78125, 0.444);
                yield return new DNase(7, 0.78125, 0.439);
                yield return new DNase(7, 1.5625, 0.686);
                yield return new DNase(7, 1.5625, 0.668);
                yield return new DNase(7, 3.125, 1.052);
                yield return new DNase(7, 3.125, 1.035);
                yield return new DNase(7, 6.25, 1.409);
                yield return new DNase(7, 6.25, 1.392);
                yield return new DNase(7, 12.5, 1.759);
                yield return new DNase(7, 12.5, 1.739);
                yield return new DNase(8, 0.04882812, 0.054);
                yield return new DNase(8, 0.04882812, 0.054);
                yield return new DNase(8, 0.1953125, 0.152);
                yield return new DNase(8, 0.1953125, 0.148);
                yield return new DNase(8, 0.390625, 0.226);
                yield return new DNase(8, 0.390625, 0.222);
                yield return new DNase(8, 0.78125, 0.392);
                yield return new DNase(8, 0.78125, 0.383);
                yield return new DNase(8, 1.5625, 0.658);
                yield return new DNase(8, 1.5625, 0.644);
                yield return new DNase(8, 3.125, 1.043);
                yield return new DNase(8, 3.125, 1.002);
                yield return new DNase(8, 6.25, 1.466);
                yield return new DNase(8, 6.25, 1.381);
                yield return new DNase(8, 12.5, 1.743);
                yield return new DNase(8, 12.5, 1.724);
                yield return new DNase(9, 0.04882812, 0.032);
                yield return new DNase(9, 0.04882812, 0.043);
                yield return new DNase(9, 0.1953125, 0.142);
                yield return new DNase(9, 0.1953125, 0.155);
                yield return new DNase(9, 0.390625, 0.239);
                yield return new DNase(9, 0.390625, 0.242);
                yield return new DNase(9, 0.78125, 0.42);
                yield return new DNase(9, 0.78125, 0.395);
                yield return new DNase(9, 1.5625, 0.624);
                yield return new DNase(9, 1.5625, 0.705);
                yield return new DNase(9, 3.125, 1.046);
                yield return new DNase(9, 3.125, 1.026);
                yield return new DNase(9, 6.25, 1.398);
                yield return new DNase(9, 6.25, 1.405);
                yield return new DNase(9, 12.5, 1.693);
                yield return new DNase(9, 12.5, 1.729);
                yield return new DNase(10, 0.04882812, 0.052);
                yield return new DNase(10, 0.04882812, 0.094);
                yield return new DNase(10, 0.1953125, 0.164);
                yield return new DNase(10, 0.1953125, 0.166);
                yield return new DNase(10, 0.390625, 0.259);
                yield return new DNase(10, 0.390625, 0.256);
                yield return new DNase(10, 0.78125, 0.439);
                yield return new DNase(10, 0.78125, 0.439);
                yield return new DNase(10, 1.5625, 0.69);
                yield return new DNase(10, 1.5625, 0.701);
                yield return new DNase(10, 3.125, 1.042);
                yield return new DNase(10, 3.125, 1.075);
                yield return new DNase(10, 6.25, 1.34);
                yield return new DNase(10, 6.25, 1.406);
                yield return new DNase(10, 12.5, 1.699);
                yield return new DNase(10, 12.5, 1.708);
                yield return new DNase(11, 0.04882812, 0.047);
                yield return new DNase(11, 0.04882812, 0.057);
                yield return new DNase(11, 0.1953125, 0.159);
                yield return new DNase(11, 0.1953125, 0.155);
                yield return new DNase(11, 0.390625, 0.246);
                yield return new DNase(11, 0.390625, 0.252);
                yield return new DNase(11, 0.78125, 0.427);
                yield return new DNase(11, 0.78125, 0.411);
                yield return new DNase(11, 1.5625, 0.704);
                yield return new DNase(11, 1.5625, 0.684);
                yield return new DNase(11, 3.125, 0.994);
                yield return new DNase(11, 3.125, 0.98);
                yield return new DNase(11, 6.25, 1.421);
                yield return new DNase(11, 6.25, 1.385);
                yield return new DNase(11, 12.5, 1.715);
                yield return new DNase(11, 12.5, 1.721);
            }
        }
    }
}
