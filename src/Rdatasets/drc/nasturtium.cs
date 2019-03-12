// ReSharper disable All

namespace Rdatasets.drc
{
    using System.Collections.Generic;

    /// <summary>
    /// Dose-response profile of degradation of agrochemical using nasturtium
    /// </summary>

    public class nasturtium
    {
        public readonly int κ;
        public readonly double conc;
        public readonly int weight;

        public nasturtium(int κ, double conc, int weight)
        {
            this.κ = κ;
            this.conc = conc;
            this.weight = weight;
        }

        public static IEnumerable<nasturtium> Data
        {
            get
            {
                yield return new nasturtium(1, 0, 920);
                yield return new nasturtium(2, 0, 889);
                yield return new nasturtium(3, 0, 866);
                yield return new nasturtium(4, 0, 930);
                yield return new nasturtium(5, 0, 992);
                yield return new nasturtium(6, 0, 1017);
                yield return new nasturtium(7, 0.025, 919);
                yield return new nasturtium(8, 0.025, 878);
                yield return new nasturtium(9, 0.025, 882);
                yield return new nasturtium(10, 0.025, 854);
                yield return new nasturtium(11, 0.025, 851);
                yield return new nasturtium(12, 0.025, 850);
                yield return new nasturtium(13, 0.075, 870);
                yield return new nasturtium(14, 0.075, 825);
                yield return new nasturtium(15, 0.075, 953);
                yield return new nasturtium(16, 0.075, 834);
                yield return new nasturtium(17, 0.075, 810);
                yield return new nasturtium(18, 0.075, 875);
                yield return new nasturtium(19, 0.25, 880);
                yield return new nasturtium(20, 0.25, 834);
                yield return new nasturtium(21, 0.25, 795);
                yield return new nasturtium(22, 0.25, 837);
                yield return new nasturtium(23, 0.25, 834);
                yield return new nasturtium(24, 0.25, 810);
                yield return new nasturtium(25, 0.75, 693);
                yield return new nasturtium(26, 0.75, 690);
                yield return new nasturtium(27, 0.75, 722);
                yield return new nasturtium(28, 0.75, 738);
                yield return new nasturtium(29, 0.75, 563);
                yield return new nasturtium(30, 0.75, 591);
                yield return new nasturtium(31, 2, 429);
                yield return new nasturtium(32, 2, 395);
                yield return new nasturtium(33, 2, 435);
                yield return new nasturtium(34, 2, 412);
                yield return new nasturtium(35, 2, 273);
                yield return new nasturtium(36, 2, 257);
                yield return new nasturtium(37, 4, 200);
                yield return new nasturtium(38, 4, 244);
                yield return new nasturtium(39, 4, 209);
                yield return new nasturtium(40, 4, 225);
                yield return new nasturtium(41, 4, 128);
                yield return new nasturtium(42, 4, 221);
            }
        }
    }
}
