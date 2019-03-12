// ReSharper disable All

namespace Rdatasets.datasets
{
    using System.Collections.Generic;

    /// <summary>
    /// Results from an Experiment on Plant Growth
    /// </summary>

    public class PlantGrowth
    {
        public readonly int κ;
        public readonly double weight;
        public readonly string group;

        public PlantGrowth(int κ, double weight, string group)
        {
            this.κ = κ;
            this.weight = weight;
            this.group = group;
        }

        public static IEnumerable<PlantGrowth> Data
        {
            get
            {
                yield return new PlantGrowth(1, 4.17, "ctrl");
                yield return new PlantGrowth(2, 5.58, "ctrl");
                yield return new PlantGrowth(3, 5.18, "ctrl");
                yield return new PlantGrowth(4, 6.11, "ctrl");
                yield return new PlantGrowth(5, 4.5, "ctrl");
                yield return new PlantGrowth(6, 4.61, "ctrl");
                yield return new PlantGrowth(7, 5.17, "ctrl");
                yield return new PlantGrowth(8, 4.53, "ctrl");
                yield return new PlantGrowth(9, 5.33, "ctrl");
                yield return new PlantGrowth(10, 5.14, "ctrl");
                yield return new PlantGrowth(11, 4.81, "trt1");
                yield return new PlantGrowth(12, 4.17, "trt1");
                yield return new PlantGrowth(13, 4.41, "trt1");
                yield return new PlantGrowth(14, 3.59, "trt1");
                yield return new PlantGrowth(15, 5.87, "trt1");
                yield return new PlantGrowth(16, 3.83, "trt1");
                yield return new PlantGrowth(17, 6.03, "trt1");
                yield return new PlantGrowth(18, 4.89, "trt1");
                yield return new PlantGrowth(19, 4.32, "trt1");
                yield return new PlantGrowth(20, 4.69, "trt1");
                yield return new PlantGrowth(21, 6.31, "trt2");
                yield return new PlantGrowth(22, 5.12, "trt2");
                yield return new PlantGrowth(23, 5.54, "trt2");
                yield return new PlantGrowth(24, 5.5, "trt2");
                yield return new PlantGrowth(25, 5.37, "trt2");
                yield return new PlantGrowth(26, 5.29, "trt2");
                yield return new PlantGrowth(27, 4.92, "trt2");
                yield return new PlantGrowth(28, 6.15, "trt2");
                yield return new PlantGrowth(29, 5.8, "trt2");
                yield return new PlantGrowth(30, 5.26, "trt2");
            }
        }
    }
}
