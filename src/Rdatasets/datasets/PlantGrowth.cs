// ReSharper disable All

namespace Rdatasets.datasets
{
    using System.Collections.Generic;

    /// <summary>
    /// Results from an Experiment on Plant Growth
    /// </summary>

    public class PlantGrowth
    {
        public readonly double weight;
        public readonly string group;

        public PlantGrowth(double weight, string group)
        {
            this.weight = weight;
            this.group = group;
        }

        public static IEnumerable<PlantGrowth> Data
        {
            get
            {
                yield return new PlantGrowth(4.17, "ctrl");
                yield return new PlantGrowth(5.58, "ctrl");
                yield return new PlantGrowth(5.18, "ctrl");
                yield return new PlantGrowth(6.11, "ctrl");
                yield return new PlantGrowth(4.5, "ctrl");
                yield return new PlantGrowth(4.61, "ctrl");
                yield return new PlantGrowth(5.17, "ctrl");
                yield return new PlantGrowth(4.53, "ctrl");
                yield return new PlantGrowth(5.33, "ctrl");
                yield return new PlantGrowth(5.14, "ctrl");
                yield return new PlantGrowth(4.81, "trt1");
                yield return new PlantGrowth(4.17, "trt1");
                yield return new PlantGrowth(4.41, "trt1");
                yield return new PlantGrowth(3.59, "trt1");
                yield return new PlantGrowth(5.87, "trt1");
                yield return new PlantGrowth(3.83, "trt1");
                yield return new PlantGrowth(6.03, "trt1");
                yield return new PlantGrowth(4.89, "trt1");
                yield return new PlantGrowth(4.32, "trt1");
                yield return new PlantGrowth(4.69, "trt1");
                yield return new PlantGrowth(6.31, "trt2");
                yield return new PlantGrowth(5.12, "trt2");
                yield return new PlantGrowth(5.54, "trt2");
                yield return new PlantGrowth(5.5, "trt2");
                yield return new PlantGrowth(5.37, "trt2");
                yield return new PlantGrowth(5.29, "trt2");
                yield return new PlantGrowth(4.92, "trt2");
                yield return new PlantGrowth(6.15, "trt2");
                yield return new PlantGrowth(5.8, "trt2");
                yield return new PlantGrowth(5.26, "trt2");
            }
        }
    }
}
