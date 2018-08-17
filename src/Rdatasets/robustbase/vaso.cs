// ReSharper disable All

namespace Rdatasets.robustbase
{
    using System.Collections.Generic;

    /// <summary>
    /// Vaso Constriction Skin Data Set
    /// </summary>

    public class vaso
    {
        public readonly double Volume;
        public readonly double Rate;
        public readonly int Y;

        public vaso(double Volume, double Rate, int Y)
        {
            this.Volume = Volume;
            this.Rate = Rate;
            this.Y = Y;
        }

        public static IEnumerable<vaso> Data
        {
            get
            {
                yield return new vaso(3.7, 0.825, 1);
                yield return new vaso(3.5, 1.09, 1);
                yield return new vaso(1.25, 2.5, 1);
                yield return new vaso(0.75, 1.5, 1);
                yield return new vaso(0.8, 3.2, 1);
                yield return new vaso(0.7, 3.5, 1);
                yield return new vaso(0.6, 0.75, 0);
                yield return new vaso(1.1, 1.7, 0);
                yield return new vaso(0.9, 0.75, 0);
                yield return new vaso(0.9, 0.45, 0);
                yield return new vaso(0.8, 0.57, 0);
                yield return new vaso(0.55, 2.75, 0);
                yield return new vaso(0.6, 3, 0);
                yield return new vaso(1.4, 2.33, 1);
                yield return new vaso(0.75, 3.75, 1);
                yield return new vaso(2.3, 1.64, 1);
                yield return new vaso(3.2, 1.6, 1);
                yield return new vaso(0.85, 1.415, 1);
                yield return new vaso(1.7, 1.06, 0);
                yield return new vaso(1.8, 1.8, 1);
                yield return new vaso(0.4, 2, 0);
                yield return new vaso(0.95, 1.36, 0);
                yield return new vaso(1.35, 1.35, 0);
                yield return new vaso(1.5, 1.36, 0);
                yield return new vaso(1.6, 1.78, 1);
                yield return new vaso(0.6, 1.5, 0);
                yield return new vaso(1.8, 1.5, 1);
                yield return new vaso(0.95, 1.9, 0);
                yield return new vaso(1.9, 0.95, 1);
                yield return new vaso(1.6, 0.4, 0);
                yield return new vaso(2.7, 0.75, 1);
                yield return new vaso(2.35, 0.03, 0);
                yield return new vaso(1.1, 1.83, 0);
                yield return new vaso(1.1, 2.2, 1);
                yield return new vaso(1.2, 2, 1);
                yield return new vaso(0.8, 3.33, 1);
                yield return new vaso(0.95, 1.9, 0);
                yield return new vaso(0.75, 1.9, 0);
                yield return new vaso(1.3, 1.625, 1);
            }
        }
    }
}
