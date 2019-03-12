// ReSharper disable All

namespace Rdatasets.COUNT
{
    using System.Collections.Generic;

    /// <summary>
    /// lbwgrp
    /// </summary>

    public class lbwgrp
    {
        public readonly int κ;
        public readonly int lowbw;
        public readonly int cases;
        public readonly int smoke;
        public readonly int race1;
        public readonly int race2;
        public readonly int race3;
        public readonly int low;

        public lbwgrp(int κ, int lowbw, int cases, int smoke, int race1, int race2, int race3, int low)
        {
            this.κ = κ;
            this.lowbw = lowbw;
            this.cases = cases;
            this.smoke = smoke;
            this.race1 = race1;
            this.race2 = race2;
            this.race3 = race3;
            this.low = low;
        }

        public static IEnumerable<lbwgrp> Data
        {
            get
            {
                yield return new lbwgrp(1, 60, 165, 0, 0, 0, 1, 0);
                yield return new lbwgrp(2, 15, 48, 0, 0, 1, 0, 0);
                yield return new lbwgrp(3, 12, 132, 0, 1, 0, 0, 0);
                yield return new lbwgrp(4, 15, 36, 1, 0, 0, 1, 1);
                yield return new lbwgrp(5, 18, 30, 1, 0, 1, 0, 1);
                yield return new lbwgrp(6, 57, 156, 1, 1, 0, 0, 1);
            }
        }
    }
}
