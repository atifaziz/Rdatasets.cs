// ReSharper disable All

namespace Rdatasets.robustbase
{
    using System.Collections.Generic;

    /// <summary>
    /// Vaso Constriction Skin Data Set
    /// </summary>

    public class vaso
    {
        public readonly int κ;
        public readonly double Volume;
        public readonly double Rate;
        public readonly int Y;

        public vaso(int κ, double Volume, double Rate, int Y)
        {
            this.κ = κ;
            this.Volume = Volume;
            this.Rate = Rate;
            this.Y = Y;
        }

        public static IEnumerable<vaso> Data
        {
            get
            {
                yield return new vaso(1, 3.7, 0.825, 1);
                yield return new vaso(2, 3.5, 1.09, 1);
                yield return new vaso(3, 1.25, 2.5, 1);
                yield return new vaso(4, 0.75, 1.5, 1);
                yield return new vaso(5, 0.8, 3.2, 1);
                yield return new vaso(6, 0.7, 3.5, 1);
                yield return new vaso(7, 0.6, 0.75, 0);
                yield return new vaso(8, 1.1, 1.7, 0);
                yield return new vaso(9, 0.9, 0.75, 0);
                yield return new vaso(10, 0.9, 0.45, 0);
                yield return new vaso(11, 0.8, 0.57, 0);
                yield return new vaso(12, 0.55, 2.75, 0);
                yield return new vaso(13, 0.6, 3, 0);
                yield return new vaso(14, 1.4, 2.33, 1);
                yield return new vaso(15, 0.75, 3.75, 1);
                yield return new vaso(16, 2.3, 1.64, 1);
                yield return new vaso(17, 3.2, 1.6, 1);
                yield return new vaso(18, 0.85, 1.415, 1);
                yield return new vaso(19, 1.7, 1.06, 0);
                yield return new vaso(20, 1.8, 1.8, 1);
                yield return new vaso(21, 0.4, 2, 0);
                yield return new vaso(22, 0.95, 1.36, 0);
                yield return new vaso(23, 1.35, 1.35, 0);
                yield return new vaso(24, 1.5, 1.36, 0);
                yield return new vaso(25, 1.6, 1.78, 1);
                yield return new vaso(26, 0.6, 1.5, 0);
                yield return new vaso(27, 1.8, 1.5, 1);
                yield return new vaso(28, 0.95, 1.9, 0);
                yield return new vaso(29, 1.9, 0.95, 1);
                yield return new vaso(30, 1.6, 0.4, 0);
                yield return new vaso(31, 2.7, 0.75, 1);
                yield return new vaso(32, 2.35, 0.03, 0);
                yield return new vaso(33, 1.1, 1.83, 0);
                yield return new vaso(34, 1.1, 2.2, 1);
                yield return new vaso(35, 1.2, 2, 1);
                yield return new vaso(36, 0.8, 3.33, 1);
                yield return new vaso(37, 0.95, 1.9, 0);
                yield return new vaso(38, 0.75, 1.9, 0);
                yield return new vaso(39, 1.3, 1.625, 1);
            }
        }
    }
}
