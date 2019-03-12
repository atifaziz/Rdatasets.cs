// ReSharper disable All

namespace Rdatasets.datasets
{
    using System.Collections.Generic;

    /// <summary>
    /// Chicken Weights by Feed Type
    /// </summary>

    public class chickwts
    {
        public readonly int κ;
        public readonly int weight;
        public readonly string feed;

        public chickwts(int κ, int weight, string feed)
        {
            this.κ = κ;
            this.weight = weight;
            this.feed = feed;
        }

        public static IEnumerable<chickwts> Data
        {
            get
            {
                yield return new chickwts(1, 179, "horsebean");
                yield return new chickwts(2, 160, "horsebean");
                yield return new chickwts(3, 136, "horsebean");
                yield return new chickwts(4, 227, "horsebean");
                yield return new chickwts(5, 217, "horsebean");
                yield return new chickwts(6, 168, "horsebean");
                yield return new chickwts(7, 108, "horsebean");
                yield return new chickwts(8, 124, "horsebean");
                yield return new chickwts(9, 143, "horsebean");
                yield return new chickwts(10, 140, "horsebean");
                yield return new chickwts(11, 309, "linseed");
                yield return new chickwts(12, 229, "linseed");
                yield return new chickwts(13, 181, "linseed");
                yield return new chickwts(14, 141, "linseed");
                yield return new chickwts(15, 260, "linseed");
                yield return new chickwts(16, 203, "linseed");
                yield return new chickwts(17, 148, "linseed");
                yield return new chickwts(18, 169, "linseed");
                yield return new chickwts(19, 213, "linseed");
                yield return new chickwts(20, 257, "linseed");
                yield return new chickwts(21, 244, "linseed");
                yield return new chickwts(22, 271, "linseed");
                yield return new chickwts(23, 243, "soybean");
                yield return new chickwts(24, 230, "soybean");
                yield return new chickwts(25, 248, "soybean");
                yield return new chickwts(26, 327, "soybean");
                yield return new chickwts(27, 329, "soybean");
                yield return new chickwts(28, 250, "soybean");
                yield return new chickwts(29, 193, "soybean");
                yield return new chickwts(30, 271, "soybean");
                yield return new chickwts(31, 316, "soybean");
                yield return new chickwts(32, 267, "soybean");
                yield return new chickwts(33, 199, "soybean");
                yield return new chickwts(34, 171, "soybean");
                yield return new chickwts(35, 158, "soybean");
                yield return new chickwts(36, 248, "soybean");
                yield return new chickwts(37, 423, "sunflower");
                yield return new chickwts(38, 340, "sunflower");
                yield return new chickwts(39, 392, "sunflower");
                yield return new chickwts(40, 339, "sunflower");
                yield return new chickwts(41, 341, "sunflower");
                yield return new chickwts(42, 226, "sunflower");
                yield return new chickwts(43, 320, "sunflower");
                yield return new chickwts(44, 295, "sunflower");
                yield return new chickwts(45, 334, "sunflower");
                yield return new chickwts(46, 322, "sunflower");
                yield return new chickwts(47, 297, "sunflower");
                yield return new chickwts(48, 318, "sunflower");
                yield return new chickwts(49, 325, "meatmeal");
                yield return new chickwts(50, 257, "meatmeal");
                yield return new chickwts(51, 303, "meatmeal");
                yield return new chickwts(52, 315, "meatmeal");
                yield return new chickwts(53, 380, "meatmeal");
                yield return new chickwts(54, 153, "meatmeal");
                yield return new chickwts(55, 263, "meatmeal");
                yield return new chickwts(56, 242, "meatmeal");
                yield return new chickwts(57, 206, "meatmeal");
                yield return new chickwts(58, 344, "meatmeal");
                yield return new chickwts(59, 258, "meatmeal");
                yield return new chickwts(60, 368, "casein");
                yield return new chickwts(61, 390, "casein");
                yield return new chickwts(62, 379, "casein");
                yield return new chickwts(63, 260, "casein");
                yield return new chickwts(64, 404, "casein");
                yield return new chickwts(65, 318, "casein");
                yield return new chickwts(66, 352, "casein");
                yield return new chickwts(67, 359, "casein");
                yield return new chickwts(68, 216, "casein");
                yield return new chickwts(69, 222, "casein");
                yield return new chickwts(70, 283, "casein");
                yield return new chickwts(71, 332, "casein");
            }
        }
    }
}
