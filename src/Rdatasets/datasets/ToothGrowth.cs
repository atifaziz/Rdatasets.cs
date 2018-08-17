// ReSharper disable All

namespace Rdatasets.datasets
{
    using System.Collections.Generic;

    /// <summary>
    /// The Effect of Vitamin C on Tooth Growth in Guinea Pigs
    /// </summary>

    public class ToothGrowth
    {
        public readonly double len;
        public readonly string supp;
        public readonly double dose;

        public ToothGrowth(double len, string supp, double dose)
        {
            this.len = len;
            this.supp = supp;
            this.dose = dose;
        }

        public static IEnumerable<ToothGrowth> Data
        {
            get
            {
                yield return new ToothGrowth(4.2, "VC", 0.5);
                yield return new ToothGrowth(11.5, "VC", 0.5);
                yield return new ToothGrowth(7.3, "VC", 0.5);
                yield return new ToothGrowth(5.8, "VC", 0.5);
                yield return new ToothGrowth(6.4, "VC", 0.5);
                yield return new ToothGrowth(10, "VC", 0.5);
                yield return new ToothGrowth(11.2, "VC", 0.5);
                yield return new ToothGrowth(11.2, "VC", 0.5);
                yield return new ToothGrowth(5.2, "VC", 0.5);
                yield return new ToothGrowth(7, "VC", 0.5);
                yield return new ToothGrowth(16.5, "VC", 1);
                yield return new ToothGrowth(16.5, "VC", 1);
                yield return new ToothGrowth(15.2, "VC", 1);
                yield return new ToothGrowth(17.3, "VC", 1);
                yield return new ToothGrowth(22.5, "VC", 1);
                yield return new ToothGrowth(17.3, "VC", 1);
                yield return new ToothGrowth(13.6, "VC", 1);
                yield return new ToothGrowth(14.5, "VC", 1);
                yield return new ToothGrowth(18.8, "VC", 1);
                yield return new ToothGrowth(15.5, "VC", 1);
                yield return new ToothGrowth(23.6, "VC", 2);
                yield return new ToothGrowth(18.5, "VC", 2);
                yield return new ToothGrowth(33.9, "VC", 2);
                yield return new ToothGrowth(25.5, "VC", 2);
                yield return new ToothGrowth(26.4, "VC", 2);
                yield return new ToothGrowth(32.5, "VC", 2);
                yield return new ToothGrowth(26.7, "VC", 2);
                yield return new ToothGrowth(21.5, "VC", 2);
                yield return new ToothGrowth(23.3, "VC", 2);
                yield return new ToothGrowth(29.5, "VC", 2);
                yield return new ToothGrowth(15.2, "OJ", 0.5);
                yield return new ToothGrowth(21.5, "OJ", 0.5);
                yield return new ToothGrowth(17.6, "OJ", 0.5);
                yield return new ToothGrowth(9.7, "OJ", 0.5);
                yield return new ToothGrowth(14.5, "OJ", 0.5);
                yield return new ToothGrowth(10, "OJ", 0.5);
                yield return new ToothGrowth(8.2, "OJ", 0.5);
                yield return new ToothGrowth(9.4, "OJ", 0.5);
                yield return new ToothGrowth(16.5, "OJ", 0.5);
                yield return new ToothGrowth(9.7, "OJ", 0.5);
                yield return new ToothGrowth(19.7, "OJ", 1);
                yield return new ToothGrowth(23.3, "OJ", 1);
                yield return new ToothGrowth(23.6, "OJ", 1);
                yield return new ToothGrowth(26.4, "OJ", 1);
                yield return new ToothGrowth(20, "OJ", 1);
                yield return new ToothGrowth(25.2, "OJ", 1);
                yield return new ToothGrowth(25.8, "OJ", 1);
                yield return new ToothGrowth(21.2, "OJ", 1);
                yield return new ToothGrowth(14.5, "OJ", 1);
                yield return new ToothGrowth(27.3, "OJ", 1);
                yield return new ToothGrowth(25.5, "OJ", 2);
                yield return new ToothGrowth(26.4, "OJ", 2);
                yield return new ToothGrowth(22.4, "OJ", 2);
                yield return new ToothGrowth(24.5, "OJ", 2);
                yield return new ToothGrowth(24.8, "OJ", 2);
                yield return new ToothGrowth(30.9, "OJ", 2);
                yield return new ToothGrowth(26.4, "OJ", 2);
                yield return new ToothGrowth(27.3, "OJ", 2);
                yield return new ToothGrowth(29.4, "OJ", 2);
                yield return new ToothGrowth(23, "OJ", 2);
            }
        }
    }
}
