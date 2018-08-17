// ReSharper disable All

namespace Rdatasets.carData
{
    using System.Collections.Generic;

    /// <summary>
    /// Weight Loss Data
    /// </summary>

    public class WeightLoss
    {
        public readonly string group;
        public readonly int wl1;
        public readonly int wl2;
        public readonly int wl3;
        public readonly int se1;
        public readonly int se2;
        public readonly int se3;

        public WeightLoss(string group, int wl1, int wl2, int wl3, int se1, int se2, int se3)
        {
            this.group = group;
            this.wl1 = wl1;
            this.wl2 = wl2;
            this.wl3 = wl3;
            this.se1 = se1;
            this.se2 = se2;
            this.se3 = se3;
        }

        public static IEnumerable<WeightLoss> Data
        {
            get
            {
                yield return new WeightLoss("Control", 4, 3, 3, 14, 13, 15);
                yield return new WeightLoss("Control", 4, 4, 3, 13, 14, 17);
                yield return new WeightLoss("Control", 4, 3, 1, 17, 12, 16);
                yield return new WeightLoss("Control", 3, 2, 1, 11, 11, 12);
                yield return new WeightLoss("Control", 5, 3, 2, 16, 15, 14);
                yield return new WeightLoss("Control", 6, 5, 4, 17, 18, 18);
                yield return new WeightLoss("Control", 6, 5, 4, 17, 16, 19);
                yield return new WeightLoss("Control", 5, 4, 1, 13, 15, 15);
                yield return new WeightLoss("Control", 5, 4, 1, 14, 14, 15);
                yield return new WeightLoss("Control", 3, 3, 2, 14, 15, 13);
                yield return new WeightLoss("Control", 4, 2, 2, 16, 16, 11);
                yield return new WeightLoss("Control", 5, 2, 1, 15, 13, 16);
                yield return new WeightLoss("Diet", 6, 3, 2, 12, 11, 14);
                yield return new WeightLoss("Diet", 5, 4, 1, 13, 14, 15);
                yield return new WeightLoss("Diet", 7, 6, 3, 17, 11, 18);
                yield return new WeightLoss("Diet", 6, 4, 2, 16, 15, 18);
                yield return new WeightLoss("Diet", 3, 2, 1, 16, 17, 15);
                yield return new WeightLoss("Diet", 5, 5, 4, 13, 11, 18);
                yield return new WeightLoss("Diet", 4, 3, 1, 12, 11, 14);
                yield return new WeightLoss("Diet", 4, 2, 1, 12, 11, 11);
                yield return new WeightLoss("Diet", 6, 5, 3, 17, 16, 19);
                yield return new WeightLoss("Diet", 7, 6, 4, 19, 19, 19);
                yield return new WeightLoss("Diet", 4, 3, 2, 15, 15, 15);
                yield return new WeightLoss("Diet", 7, 4, 3, 16, 14, 18);
                yield return new WeightLoss("DietEx", 7, 7, 4, 15, 11, 19);
                yield return new WeightLoss("DietEx", 4, 7, 1, 16, 12, 18);
                yield return new WeightLoss("DietEx", 9, 7, 3, 13, 12, 17);
                yield return new WeightLoss("DietEx", 3, 4, 1, 16, 13, 17);
                yield return new WeightLoss("DietEx", 3, 5, 1, 13, 13, 16);
                yield return new WeightLoss("DietEx", 6, 5, 2, 15, 12, 18);
                yield return new WeightLoss("DietEx", 6, 6, 3, 15, 13, 18);
                yield return new WeightLoss("DietEx", 9, 5, 2, 16, 14, 17);
                yield return new WeightLoss("DietEx", 7, 9, 4, 16, 16, 19);
                yield return new WeightLoss("DietEx", 8, 6, 1, 17, 17, 17);
            }
        }
    }
}
