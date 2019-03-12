// ReSharper disable All

namespace Rdatasets.drc
{
    using System.Collections.Generic;

    /// <summary>
    /// Vinclozolin from AR in vitro assay
    /// </summary>

    public class vinclozolin
    {
        public readonly int κ;
        public readonly int exper;
        public readonly double conc;
        public readonly int effect;

        public vinclozolin(int κ, int exper, double conc, int effect)
        {
            this.κ = κ;
            this.exper = exper;
            this.conc = conc;
            this.effect = effect;
        }

        public static IEnumerable<vinclozolin> Data
        {
            get
            {
                yield return new vinclozolin(1, 10509, 0, 1003);
                yield return new vinclozolin(2, 10509, 0.025, 908);
                yield return new vinclozolin(3, 10509, 0.05, 997);
                yield return new vinclozolin(4, 10509, 0.1, 744);
                yield return new vinclozolin(5, 10509, 0.2, 567);
                yield return new vinclozolin(6, 10509, 0.39, 314);
                yield return new vinclozolin(7, 10509, 0.78, 325);
                yield return new vinclozolin(8, 10509, 1.56, 146);
                yield return new vinclozolin(9, 10509, 3.13, 113);
                yield return new vinclozolin(10, 10821, 0, 1176);
                yield return new vinclozolin(11, 10821, 0.025, 930);
                yield return new vinclozolin(12, 10821, 0.05, 489);
                yield return new vinclozolin(13, 10821, 0.1, 589);
                yield return new vinclozolin(14, 10821, 0.2, 400);
                yield return new vinclozolin(15, 10821, 0.39, 312);
                yield return new vinclozolin(16, 10821, 0.78, 228);
                yield return new vinclozolin(17, 10821, 1.56, 175);
                yield return new vinclozolin(18, 10821, 3.13, 152);
                yield return new vinclozolin(19, 10828, 0, 2830);
                yield return new vinclozolin(20, 10828, 0.025, 1953);
                yield return new vinclozolin(21, 10828, 0.05, 1994);
                yield return new vinclozolin(22, 10828, 0.1, 1374);
                yield return new vinclozolin(23, 10828, 0.2, 1429);
                yield return new vinclozolin(24, 10828, 0.39, 1063);
                yield return new vinclozolin(25, 10828, 0.78, 778);
                yield return new vinclozolin(26, 10828, 1.56, 668);
                yield return new vinclozolin(27, 10828, 3.13, 694);
                yield return new vinclozolin(28, 10904, 0, 2694);
                yield return new vinclozolin(29, 10904, 0.025, 1522);
                yield return new vinclozolin(30, 10904, 0.05, 1114);
                yield return new vinclozolin(31, 10904, 0.1, 950);
                yield return new vinclozolin(32, 10904, 0.2, 1063);
                yield return new vinclozolin(33, 10904, 0.39, 683);
                yield return new vinclozolin(34, 10904, 0.78, 538);
                yield return new vinclozolin(35, 10904, 1.56, 561);
                yield return new vinclozolin(36, 10904, 3.13, 479);
                yield return new vinclozolin(37, 11023, 0, 1425);
                yield return new vinclozolin(38, 11023, 0.025, 996);
                yield return new vinclozolin(39, 11023, 0.05, 1045);
                yield return new vinclozolin(40, 11023, 0.1, 736);
                yield return new vinclozolin(41, 11023, 0.2, 636);
                yield return new vinclozolin(42, 11023, 0.39, 498);
                yield return new vinclozolin(43, 11023, 0.78, 318);
                yield return new vinclozolin(44, 11023, 1.56, 298);
                yield return new vinclozolin(45, 11023, 3.13, 334);
                yield return new vinclozolin(46, 11106, 0, 2649);
                yield return new vinclozolin(47, 11106, 0.05, 1067);
                yield return new vinclozolin(48, 11106, 0.1, 1042);
                yield return new vinclozolin(49, 11106, 0.2, 706);
                yield return new vinclozolin(50, 11106, 0.39, 607);
                yield return new vinclozolin(51, 11106, 0.78, 588);
                yield return new vinclozolin(52, 11106, 1.56, 364);
                yield return new vinclozolin(53, 11106, 3.13, 440);
            }
        }
    }
}
