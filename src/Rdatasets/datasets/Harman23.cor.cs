// ReSharper disable All

namespace Rdatasets.datasets
{
    using System.Collections.Generic;

    /// <summary>
    /// Harman Example 2.3
    /// </summary>

    public class Harman23_cor
    {
        public readonly double cov_height;
        public readonly double cov_arm_span;
        public readonly double cov_forearm;
        public readonly double cov_lower_leg;
        public readonly double cov_weight;
        public readonly double cov_bitro_diameter;
        public readonly double cov_chest_girth;
        public readonly double cov_chest_width;
        public readonly int center;
        public readonly int n_obs;

        public Harman23_cor(double cov_height, double cov_arm_span, double cov_forearm, double cov_lower_leg, double cov_weight, double cov_bitro_diameter, double cov_chest_girth, double cov_chest_width, int center, int n_obs)
        {
            this.cov_height = cov_height;
            this.cov_arm_span = cov_arm_span;
            this.cov_forearm = cov_forearm;
            this.cov_lower_leg = cov_lower_leg;
            this.cov_weight = cov_weight;
            this.cov_bitro_diameter = cov_bitro_diameter;
            this.cov_chest_girth = cov_chest_girth;
            this.cov_chest_width = cov_chest_width;
            this.center = center;
            this.n_obs = n_obs;
        }

        public static IEnumerable<Harman23_cor> Data
        {
            get
            {
                yield return new Harman23_cor(1, 0.846, 0.805, 0.859, 0.473, 0.398, 0.301, 0.382, 0, 305);
                yield return new Harman23_cor(0.846, 1, 0.881, 0.826, 0.376, 0.326, 0.277, 0.415, 0, 305);
                yield return new Harman23_cor(0.805, 0.881, 1, 0.801, 0.38, 0.319, 0.237, 0.345, 0, 305);
                yield return new Harman23_cor(0.859, 0.826, 0.801, 1, 0.436, 0.329, 0.327, 0.365, 0, 305);
                yield return new Harman23_cor(0.473, 0.376, 0.38, 0.436, 1, 0.762, 0.73, 0.629, 0, 305);
                yield return new Harman23_cor(0.398, 0.326, 0.319, 0.329, 0.762, 1, 0.583, 0.577, 0, 305);
                yield return new Harman23_cor(0.301, 0.277, 0.237, 0.327, 0.73, 0.583, 1, 0.539, 0, 305);
                yield return new Harman23_cor(0.382, 0.415, 0.345, 0.365, 0.629, 0.577, 0.539, 1, 0, 305);
            }
        }
    }
}
