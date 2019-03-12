// ReSharper disable All

namespace Rdatasets.DAAG
{
    using System.Collections.Generic;

    /// <summary>
    /// Sugar Data
    /// </summary>

    public class sugar
    {
        public readonly int κ;
        public readonly double weight;
        public readonly string trt;

        public sugar(int κ, double weight, string trt)
        {
            this.κ = κ;
            this.weight = weight;
            this.trt = trt;
        }

        public static IEnumerable<sugar> Data
        {
            get
            {
                yield return new sugar(1, 82, "Control");
                yield return new sugar(2, 97.8, "Control");
                yield return new sugar(3, 69.9, "Control");
                yield return new sugar(4, 58.3, "A");
                yield return new sugar(5, 67.9, "A");
                yield return new sugar(6, 59.3, "A");
                yield return new sugar(7, 68.1, "B");
                yield return new sugar(8, 70.8, "B");
                yield return new sugar(9, 63.6, "B");
                yield return new sugar(10, 50.7, "C");
                yield return new sugar(11, 47.1, "C");
                yield return new sugar(12, 48.9, "C");
            }
        }
    }
}
