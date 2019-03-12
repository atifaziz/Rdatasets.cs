// ReSharper disable All

namespace Rdatasets.Zelig
{
    using System.Collections.Generic;

    /// <summary>
    /// 1932 Weimar election data
    /// </summary>

    public class Weimar
    {
        public readonly int κ;
        public readonly int Nazi;
        public readonly int Government;
        public readonly int Communists;
        public readonly int FarRight;
        public readonly int Other;
        public readonly double shareunemployed;
        public readonly double shareblue;
        public readonly double sharewhite;
        public readonly double shareself;
        public readonly double sharedomestic;
        public readonly double shareprotestants;

        public Weimar(int κ, int Nazi, int Government, int Communists, int FarRight, int Other, double shareunemployed, double shareblue, double sharewhite, double shareself, double sharedomestic, double shareprotestants)
        {
            this.κ = κ;
            this.Nazi = Nazi;
            this.Government = Government;
            this.Communists = Communists;
            this.FarRight = FarRight;
            this.Other = Other;
            this.shareunemployed = shareunemployed;
            this.shareblue = shareblue;
            this.sharewhite = sharewhite;
            this.shareself = shareself;
            this.sharedomestic = sharedomestic;
            this.shareprotestants = shareprotestants;
        }

        public static IEnumerable<Weimar> Data
        {
            get
            {
                yield return new Weimar(1, 6710, 6854, 1747, 1440, 4024, 0.075565, 0.4667877, 0.0751894, 0.1452451, 0.2372128, 0.9708675);
                yield return new Weimar(2, 14006, 26892, 3904, 5046, 12117, 0.0841387, 0.37847, 0.0886076, 0.1776995, 0.2710842, 0.4913195);
                yield return new Weimar(3, 4411, 15359, 1620, 2901, 7418, 0.0685777, 0.2878295, 0.061648, 0.21005, 0.3718949, 0.0613757);
                yield return new Weimar(4, 26095, 16502, 10764, 7174, 17918, 0.0887963, 0.4592575, 0.0911449, 0.1498591, 0.2109423, 0.9626554);
                yield return new Weimar(5, 75760, 42647, 33878, 10478, 51069, 0.234548, 0.2782162, 0.2976835, 0.1146592, 0.0748931, 0.8933946);
                yield return new Weimar(6, 11339, 3936, 4404, 1948, 9413, 0.0690353, 0.3040565, 0.0573774, 0.2145604, 0.3549705, 0.9769614);
                yield return new Weimar(7, 12468, 6386, 1957, 4274, 7844, 0.0699124, 0.3878074, 0.0623398, 0.1842659, 0.2956744, 0.9476545);
                yield return new Weimar(8, 18987, 12960, 6048, 6074, 12977, 0.0829753, 0.4434049, 0.0756757, 0.1596905, 0.2382536, 0.9487126);
                yield return new Weimar(9, 10866, 4226, 1427, 2357, 4526, 0.0513157, 0.4367858, 0.0648391, 0.1704057, 0.2766537, 0.9395571);
                yield return new Weimar(10, 10904, 7230, 3472, 3475, 5015, 0.098927, 0.4601309, 0.1309826, 0.1285784, 0.1813811, 0.9099904);
            }
        }
    }
}
