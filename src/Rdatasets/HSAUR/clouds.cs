// ReSharper disable All

namespace Rdatasets.HSAUR
{
    using System.Collections.Generic;

    /// <summary>
    /// Cloud Seeding Data
    /// </summary>

    public class clouds
    {
        public readonly string seeding;
        public readonly int time;
        public readonly double sne;
        public readonly double cloudcover;
        public readonly double prewetness;
        public readonly string echomotion;
        public readonly double rainfall;

        public clouds(string seeding, int time, double sne, double cloudcover, double prewetness, string echomotion, double rainfall)
        {
            this.seeding = seeding;
            this.time = time;
            this.sne = sne;
            this.cloudcover = cloudcover;
            this.prewetness = prewetness;
            this.echomotion = echomotion;
            this.rainfall = rainfall;
        }

        public static IEnumerable<clouds> Data
        {
            get
            {
                yield return new clouds("no", 0, 1.75, 13.4, 0.274, "stationary", 12.85);
                yield return new clouds("yes", 1, 2.7, 37.9, 1.267, "moving", 5.52);
                yield return new clouds("yes", 3, 4.1, 3.9, 0.198, "stationary", 6.29);
                yield return new clouds("no", 4, 2.35, 5.3, 0.526, "moving", 6.11);
                yield return new clouds("yes", 6, 4.25, 7.1, 0.25, "moving", 2.45);
                yield return new clouds("no", 9, 1.6, 6.9, 0.018, "stationary", 3.61);
                yield return new clouds("no", 18, 1.3, 4.6, 0.307, "moving", 0.47);
                yield return new clouds("no", 25, 3.35, 4.9, 0.194, "moving", 4.56);
                yield return new clouds("no", 27, 2.85, 12.1, 0.751, "moving", 6.35);
                yield return new clouds("yes", 28, 2.2, 5.2, 0.084, "moving", 5.06);
                yield return new clouds("yes", 29, 4.4, 4.1, 0.236, "moving", 2.76);
                yield return new clouds("yes", 32, 3.1, 2.8, 0.214, "moving", 4.05);
                yield return new clouds("no", 33, 3.95, 6.8, 0.796, "moving", 5.74);
                yield return new clouds("yes", 35, 2.9, 3, 0.124, "moving", 4.84);
                yield return new clouds("yes", 38, 2.05, 7, 0.144, "moving", 11.86);
                yield return new clouds("no", 39, 4, 11.3, 0.398, "moving", 4.45);
                yield return new clouds("no", 53, 3.35, 4.2, 0.237, "stationary", 3.66);
                yield return new clouds("yes", 55, 3.7, 3.3, 0.96, "moving", 4.22);
                yield return new clouds("no", 56, 3.8, 2.2, 0.23, "moving", 1.16);
                yield return new clouds("yes", 59, 3.4, 6.5, 0.142, "stationary", 5.45);
                yield return new clouds("yes", 65, 3.15, 3.1, 0.073, "moving", 2.02);
                yield return new clouds("no", 68, 3.15, 2.6, 0.136, "moving", 0.82);
                yield return new clouds("yes", 82, 4.01, 8.3, 0.123, "moving", 1.09);
                yield return new clouds("no", 83, 4.65, 7.4, 0.168, "moving", 0.28);
            }
        }
    }
}
