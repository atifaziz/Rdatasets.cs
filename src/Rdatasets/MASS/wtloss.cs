// ReSharper disable All

namespace Rdatasets.MASS
{
    using System.Collections.Generic;

    /// <summary>
    /// Weight Loss Data from an Obese Patient
    /// </summary>

    public class wtloss
    {
        public readonly int Days;
        public readonly double Weight;

        public wtloss(int Days, double Weight)
        {
            this.Days = Days;
            this.Weight = Weight;
        }

        public static IEnumerable<wtloss> Data
        {
            get
            {
                yield return new wtloss(0, 184.35);
                yield return new wtloss(4, 182.51);
                yield return new wtloss(7, 180.45);
                yield return new wtloss(7, 179.91);
                yield return new wtloss(11, 177.91);
                yield return new wtloss(18, 175.81);
                yield return new wtloss(24, 173.11);
                yield return new wtloss(30, 170.06);
                yield return new wtloss(32, 169.31);
                yield return new wtloss(43, 165.1);
                yield return new wtloss(46, 163.11);
                yield return new wtloss(60, 158.3);
                yield return new wtloss(64, 155.8);
                yield return new wtloss(70, 154.31);
                yield return new wtloss(71, 153.86);
                yield return new wtloss(71, 154.2);
                yield return new wtloss(73, 152.2);
                yield return new wtloss(74, 152.8);
                yield return new wtloss(84, 150.3);
                yield return new wtloss(88, 147.8);
                yield return new wtloss(95, 146.1);
                yield return new wtloss(102, 145.6);
                yield return new wtloss(106, 142.5);
                yield return new wtloss(109, 142.3);
                yield return new wtloss(115, 139.4);
                yield return new wtloss(122, 137.9);
                yield return new wtloss(133, 133.7);
                yield return new wtloss(137, 133.7);
                yield return new wtloss(140, 133.3);
                yield return new wtloss(143, 131.2);
                yield return new wtloss(147, 133);
                yield return new wtloss(148, 132.2);
                yield return new wtloss(149, 130.8);
                yield return new wtloss(150, 131.3);
                yield return new wtloss(153, 129);
                yield return new wtloss(156, 127.9);
                yield return new wtloss(161, 126.9);
                yield return new wtloss(164, 127.7);
                yield return new wtloss(165, 129.5);
                yield return new wtloss(165, 128.4);
                yield return new wtloss(170, 125.4);
                yield return new wtloss(176, 124.9);
                yield return new wtloss(179, 124.9);
                yield return new wtloss(198, 118.2);
                yield return new wtloss(214, 118.2);
                yield return new wtloss(218, 115.3);
                yield return new wtloss(221, 115.7);
                yield return new wtloss(225, 116);
                yield return new wtloss(233, 115.5);
                yield return new wtloss(238, 112.6);
                yield return new wtloss(241, 114);
                yield return new wtloss(246, 112.6);
            }
        }
    }
}
