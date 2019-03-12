// ReSharper disable All

namespace Rdatasets.datasets
{
    using System.Collections.Generic;

    /// <summary>
    /// The Effect of Vitamin C on Tooth Growth in Guinea Pigs
    /// </summary>

    public class ToothGrowth
    {
        public readonly int κ;
        public readonly double len;
        public readonly string supp;
        public readonly double dose;

        public ToothGrowth(int κ, double len, string supp, double dose)
        {
            this.κ = κ;
            this.len = len;
            this.supp = supp;
            this.dose = dose;
        }

        public static IEnumerable<ToothGrowth> Data
        {
            get
            {
                yield return new ToothGrowth(1, 4.2, "VC", 0.5);
                yield return new ToothGrowth(2, 11.5, "VC", 0.5);
                yield return new ToothGrowth(3, 7.3, "VC", 0.5);
                yield return new ToothGrowth(4, 5.8, "VC", 0.5);
                yield return new ToothGrowth(5, 6.4, "VC", 0.5);
                yield return new ToothGrowth(6, 10, "VC", 0.5);
                yield return new ToothGrowth(7, 11.2, "VC", 0.5);
                yield return new ToothGrowth(8, 11.2, "VC", 0.5);
                yield return new ToothGrowth(9, 5.2, "VC", 0.5);
                yield return new ToothGrowth(10, 7, "VC", 0.5);
                yield return new ToothGrowth(11, 16.5, "VC", 1);
                yield return new ToothGrowth(12, 16.5, "VC", 1);
                yield return new ToothGrowth(13, 15.2, "VC", 1);
                yield return new ToothGrowth(14, 17.3, "VC", 1);
                yield return new ToothGrowth(15, 22.5, "VC", 1);
                yield return new ToothGrowth(16, 17.3, "VC", 1);
                yield return new ToothGrowth(17, 13.6, "VC", 1);
                yield return new ToothGrowth(18, 14.5, "VC", 1);
                yield return new ToothGrowth(19, 18.8, "VC", 1);
                yield return new ToothGrowth(20, 15.5, "VC", 1);
                yield return new ToothGrowth(21, 23.6, "VC", 2);
                yield return new ToothGrowth(22, 18.5, "VC", 2);
                yield return new ToothGrowth(23, 33.9, "VC", 2);
                yield return new ToothGrowth(24, 25.5, "VC", 2);
                yield return new ToothGrowth(25, 26.4, "VC", 2);
                yield return new ToothGrowth(26, 32.5, "VC", 2);
                yield return new ToothGrowth(27, 26.7, "VC", 2);
                yield return new ToothGrowth(28, 21.5, "VC", 2);
                yield return new ToothGrowth(29, 23.3, "VC", 2);
                yield return new ToothGrowth(30, 29.5, "VC", 2);
                yield return new ToothGrowth(31, 15.2, "OJ", 0.5);
                yield return new ToothGrowth(32, 21.5, "OJ", 0.5);
                yield return new ToothGrowth(33, 17.6, "OJ", 0.5);
                yield return new ToothGrowth(34, 9.7, "OJ", 0.5);
                yield return new ToothGrowth(35, 14.5, "OJ", 0.5);
                yield return new ToothGrowth(36, 10, "OJ", 0.5);
                yield return new ToothGrowth(37, 8.2, "OJ", 0.5);
                yield return new ToothGrowth(38, 9.4, "OJ", 0.5);
                yield return new ToothGrowth(39, 16.5, "OJ", 0.5);
                yield return new ToothGrowth(40, 9.7, "OJ", 0.5);
                yield return new ToothGrowth(41, 19.7, "OJ", 1);
                yield return new ToothGrowth(42, 23.3, "OJ", 1);
                yield return new ToothGrowth(43, 23.6, "OJ", 1);
                yield return new ToothGrowth(44, 26.4, "OJ", 1);
                yield return new ToothGrowth(45, 20, "OJ", 1);
                yield return new ToothGrowth(46, 25.2, "OJ", 1);
                yield return new ToothGrowth(47, 25.8, "OJ", 1);
                yield return new ToothGrowth(48, 21.2, "OJ", 1);
                yield return new ToothGrowth(49, 14.5, "OJ", 1);
                yield return new ToothGrowth(50, 27.3, "OJ", 1);
                yield return new ToothGrowth(51, 25.5, "OJ", 2);
                yield return new ToothGrowth(52, 26.4, "OJ", 2);
                yield return new ToothGrowth(53, 22.4, "OJ", 2);
                yield return new ToothGrowth(54, 24.5, "OJ", 2);
                yield return new ToothGrowth(55, 24.8, "OJ", 2);
                yield return new ToothGrowth(56, 30.9, "OJ", 2);
                yield return new ToothGrowth(57, 26.4, "OJ", 2);
                yield return new ToothGrowth(58, 27.3, "OJ", 2);
                yield return new ToothGrowth(59, 29.4, "OJ", 2);
                yield return new ToothGrowth(60, 23, "OJ", 2);
            }
        }
    }
}
