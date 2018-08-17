// ReSharper disable All

namespace Rdatasets.DAAG
{
    using System.Collections.Generic;

    /// <summary>
    /// Sugar Data
    /// </summary>

    public class sugar
    {
        public readonly double weight;
        public readonly string trt;

        public sugar(double weight, string trt)
        {
            this.weight = weight;
            this.trt = trt;
        }

        public static IEnumerable<sugar> Data
        {
            get
            {
                yield return new sugar(82, "Control");
                yield return new sugar(97.8, "Control");
                yield return new sugar(69.9, "Control");
                yield return new sugar(58.3, "A");
                yield return new sugar(67.9, "A");
                yield return new sugar(59.3, "A");
                yield return new sugar(68.1, "B");
                yield return new sugar(70.8, "B");
                yield return new sugar(63.6, "B");
                yield return new sugar(50.7, "C");
                yield return new sugar(47.1, "C");
                yield return new sugar(48.9, "C");
            }
        }
    }
}
