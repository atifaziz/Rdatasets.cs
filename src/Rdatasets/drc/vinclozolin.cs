// ReSharper disable All

namespace Rdatasets.drc
{
    using System.Collections.Generic;

    /// <summary>
    /// Vinclozolin from AR in vitro assay
    /// </summary>

    public class vinclozolin
    {
        public readonly int exper;
        public readonly double conc;
        public readonly int effect;

        public vinclozolin(int exper, double conc, int effect)
        {
            this.exper = exper;
            this.conc = conc;
            this.effect = effect;
        }

        public static IEnumerable<vinclozolin> Data
        {
            get
            {
                yield return new vinclozolin(10509, 0, 1003);
                yield return new vinclozolin(10509, 0.025, 908);
                yield return new vinclozolin(10509, 0.05, 997);
                yield return new vinclozolin(10509, 0.1, 744);
                yield return new vinclozolin(10509, 0.2, 567);
                yield return new vinclozolin(10509, 0.39, 314);
                yield return new vinclozolin(10509, 0.78, 325);
                yield return new vinclozolin(10509, 1.56, 146);
                yield return new vinclozolin(10509, 3.13, 113);
                yield return new vinclozolin(10821, 0, 1176);
                yield return new vinclozolin(10821, 0.025, 930);
                yield return new vinclozolin(10821, 0.05, 489);
                yield return new vinclozolin(10821, 0.1, 589);
                yield return new vinclozolin(10821, 0.2, 400);
                yield return new vinclozolin(10821, 0.39, 312);
                yield return new vinclozolin(10821, 0.78, 228);
                yield return new vinclozolin(10821, 1.56, 175);
                yield return new vinclozolin(10821, 3.13, 152);
                yield return new vinclozolin(10828, 0, 2830);
                yield return new vinclozolin(10828, 0.025, 1953);
                yield return new vinclozolin(10828, 0.05, 1994);
                yield return new vinclozolin(10828, 0.1, 1374);
                yield return new vinclozolin(10828, 0.2, 1429);
                yield return new vinclozolin(10828, 0.39, 1063);
                yield return new vinclozolin(10828, 0.78, 778);
                yield return new vinclozolin(10828, 1.56, 668);
                yield return new vinclozolin(10828, 3.13, 694);
                yield return new vinclozolin(10904, 0, 2694);
                yield return new vinclozolin(10904, 0.025, 1522);
                yield return new vinclozolin(10904, 0.05, 1114);
                yield return new vinclozolin(10904, 0.1, 950);
                yield return new vinclozolin(10904, 0.2, 1063);
                yield return new vinclozolin(10904, 0.39, 683);
                yield return new vinclozolin(10904, 0.78, 538);
                yield return new vinclozolin(10904, 1.56, 561);
                yield return new vinclozolin(10904, 3.13, 479);
                yield return new vinclozolin(11023, 0, 1425);
                yield return new vinclozolin(11023, 0.025, 996);
                yield return new vinclozolin(11023, 0.05, 1045);
                yield return new vinclozolin(11023, 0.1, 736);
                yield return new vinclozolin(11023, 0.2, 636);
                yield return new vinclozolin(11023, 0.39, 498);
                yield return new vinclozolin(11023, 0.78, 318);
                yield return new vinclozolin(11023, 1.56, 298);
                yield return new vinclozolin(11023, 3.13, 334);
                yield return new vinclozolin(11106, 0, 2649);
                yield return new vinclozolin(11106, 0.05, 1067);
                yield return new vinclozolin(11106, 0.1, 1042);
                yield return new vinclozolin(11106, 0.2, 706);
                yield return new vinclozolin(11106, 0.39, 607);
                yield return new vinclozolin(11106, 0.78, 588);
                yield return new vinclozolin(11106, 1.56, 364);
                yield return new vinclozolin(11106, 3.13, 440);
            }
        }
    }
}
