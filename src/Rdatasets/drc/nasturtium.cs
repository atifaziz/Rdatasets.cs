// ReSharper disable All

namespace Rdatasets.drc
{
    using System.Collections.Generic;

    /// <summary>
    /// Dose-response profile of degradation of agrochemical using nasturtium
    /// </summary>

    public class nasturtium
    {
        public readonly double conc;
        public readonly int weight;

        public nasturtium(double conc, int weight)
        {
            this.conc = conc;
            this.weight = weight;
        }

        public static IEnumerable<nasturtium> Data
        {
            get
            {
                yield return new nasturtium(0, 920);
                yield return new nasturtium(0, 889);
                yield return new nasturtium(0, 866);
                yield return new nasturtium(0, 930);
                yield return new nasturtium(0, 992);
                yield return new nasturtium(0, 1017);
                yield return new nasturtium(0.025, 919);
                yield return new nasturtium(0.025, 878);
                yield return new nasturtium(0.025, 882);
                yield return new nasturtium(0.025, 854);
                yield return new nasturtium(0.025, 851);
                yield return new nasturtium(0.025, 850);
                yield return new nasturtium(0.075, 870);
                yield return new nasturtium(0.075, 825);
                yield return new nasturtium(0.075, 953);
                yield return new nasturtium(0.075, 834);
                yield return new nasturtium(0.075, 810);
                yield return new nasturtium(0.075, 875);
                yield return new nasturtium(0.25, 880);
                yield return new nasturtium(0.25, 834);
                yield return new nasturtium(0.25, 795);
                yield return new nasturtium(0.25, 837);
                yield return new nasturtium(0.25, 834);
                yield return new nasturtium(0.25, 810);
                yield return new nasturtium(0.75, 693);
                yield return new nasturtium(0.75, 690);
                yield return new nasturtium(0.75, 722);
                yield return new nasturtium(0.75, 738);
                yield return new nasturtium(0.75, 563);
                yield return new nasturtium(0.75, 591);
                yield return new nasturtium(2, 429);
                yield return new nasturtium(2, 395);
                yield return new nasturtium(2, 435);
                yield return new nasturtium(2, 412);
                yield return new nasturtium(2, 273);
                yield return new nasturtium(2, 257);
                yield return new nasturtium(4, 200);
                yield return new nasturtium(4, 244);
                yield return new nasturtium(4, 209);
                yield return new nasturtium(4, 225);
                yield return new nasturtium(4, 128);
                yield return new nasturtium(4, 221);
            }
        }
    }
}
