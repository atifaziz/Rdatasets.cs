// ReSharper disable All

namespace Rdatasets.datasets
{
    using System.Collections.Generic;

    /// <summary>
    /// Chicken Weights by Feed Type
    /// </summary>

    public class chickwts
    {
        public readonly int weight;
        public readonly string feed;

        public chickwts(int weight, string feed)
        {
            this.weight = weight;
            this.feed = feed;
        }

        public static IEnumerable<chickwts> Data
        {
            get
            {
                yield return new chickwts(179, "horsebean");
                yield return new chickwts(160, "horsebean");
                yield return new chickwts(136, "horsebean");
                yield return new chickwts(227, "horsebean");
                yield return new chickwts(217, "horsebean");
                yield return new chickwts(168, "horsebean");
                yield return new chickwts(108, "horsebean");
                yield return new chickwts(124, "horsebean");
                yield return new chickwts(143, "horsebean");
                yield return new chickwts(140, "horsebean");
                yield return new chickwts(309, "linseed");
                yield return new chickwts(229, "linseed");
                yield return new chickwts(181, "linseed");
                yield return new chickwts(141, "linseed");
                yield return new chickwts(260, "linseed");
                yield return new chickwts(203, "linseed");
                yield return new chickwts(148, "linseed");
                yield return new chickwts(169, "linseed");
                yield return new chickwts(213, "linseed");
                yield return new chickwts(257, "linseed");
                yield return new chickwts(244, "linseed");
                yield return new chickwts(271, "linseed");
                yield return new chickwts(243, "soybean");
                yield return new chickwts(230, "soybean");
                yield return new chickwts(248, "soybean");
                yield return new chickwts(327, "soybean");
                yield return new chickwts(329, "soybean");
                yield return new chickwts(250, "soybean");
                yield return new chickwts(193, "soybean");
                yield return new chickwts(271, "soybean");
                yield return new chickwts(316, "soybean");
                yield return new chickwts(267, "soybean");
                yield return new chickwts(199, "soybean");
                yield return new chickwts(171, "soybean");
                yield return new chickwts(158, "soybean");
                yield return new chickwts(248, "soybean");
                yield return new chickwts(423, "sunflower");
                yield return new chickwts(340, "sunflower");
                yield return new chickwts(392, "sunflower");
                yield return new chickwts(339, "sunflower");
                yield return new chickwts(341, "sunflower");
                yield return new chickwts(226, "sunflower");
                yield return new chickwts(320, "sunflower");
                yield return new chickwts(295, "sunflower");
                yield return new chickwts(334, "sunflower");
                yield return new chickwts(322, "sunflower");
                yield return new chickwts(297, "sunflower");
                yield return new chickwts(318, "sunflower");
                yield return new chickwts(325, "meatmeal");
                yield return new chickwts(257, "meatmeal");
                yield return new chickwts(303, "meatmeal");
                yield return new chickwts(315, "meatmeal");
                yield return new chickwts(380, "meatmeal");
                yield return new chickwts(153, "meatmeal");
                yield return new chickwts(263, "meatmeal");
                yield return new chickwts(242, "meatmeal");
                yield return new chickwts(206, "meatmeal");
                yield return new chickwts(344, "meatmeal");
                yield return new chickwts(258, "meatmeal");
                yield return new chickwts(368, "casein");
                yield return new chickwts(390, "casein");
                yield return new chickwts(379, "casein");
                yield return new chickwts(260, "casein");
                yield return new chickwts(404, "casein");
                yield return new chickwts(318, "casein");
                yield return new chickwts(352, "casein");
                yield return new chickwts(359, "casein");
                yield return new chickwts(216, "casein");
                yield return new chickwts(222, "casein");
                yield return new chickwts(283, "casein");
                yield return new chickwts(332, "casein");
            }
        }
    }
}
