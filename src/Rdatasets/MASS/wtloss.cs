// ReSharper disable All

namespace Rdatasets.MASS
{
    using System.Collections.Generic;

    /// <summary>
    /// Weight Loss Data from an Obese Patient
    /// </summary>

    public class wtloss
    {
        public readonly int κ;
        public readonly int Days;
        public readonly double Weight;

        public wtloss(int κ, int Days, double Weight)
        {
            this.κ = κ;
            this.Days = Days;
            this.Weight = Weight;
        }

        public static IEnumerable<wtloss> Data
        {
            get
            {
                yield return new wtloss(1, 0, 184.35);
                yield return new wtloss(2, 4, 182.51);
                yield return new wtloss(3, 7, 180.45);
                yield return new wtloss(4, 7, 179.91);
                yield return new wtloss(5, 11, 177.91);
                yield return new wtloss(6, 18, 175.81);
                yield return new wtloss(7, 24, 173.11);
                yield return new wtloss(8, 30, 170.06);
                yield return new wtloss(9, 32, 169.31);
                yield return new wtloss(10, 43, 165.1);
                yield return new wtloss(11, 46, 163.11);
                yield return new wtloss(12, 60, 158.3);
                yield return new wtloss(13, 64, 155.8);
                yield return new wtloss(14, 70, 154.31);
                yield return new wtloss(15, 71, 153.86);
                yield return new wtloss(16, 71, 154.2);
                yield return new wtloss(17, 73, 152.2);
                yield return new wtloss(18, 74, 152.8);
                yield return new wtloss(19, 84, 150.3);
                yield return new wtloss(20, 88, 147.8);
                yield return new wtloss(21, 95, 146.1);
                yield return new wtloss(22, 102, 145.6);
                yield return new wtloss(23, 106, 142.5);
                yield return new wtloss(24, 109, 142.3);
                yield return new wtloss(25, 115, 139.4);
                yield return new wtloss(26, 122, 137.9);
                yield return new wtloss(27, 133, 133.7);
                yield return new wtloss(28, 137, 133.7);
                yield return new wtloss(29, 140, 133.3);
                yield return new wtloss(30, 143, 131.2);
                yield return new wtloss(31, 147, 133);
                yield return new wtloss(32, 148, 132.2);
                yield return new wtloss(33, 149, 130.8);
                yield return new wtloss(34, 150, 131.3);
                yield return new wtloss(35, 153, 129);
                yield return new wtloss(36, 156, 127.9);
                yield return new wtloss(37, 161, 126.9);
                yield return new wtloss(38, 164, 127.7);
                yield return new wtloss(39, 165, 129.5);
                yield return new wtloss(40, 165, 128.4);
                yield return new wtloss(41, 170, 125.4);
                yield return new wtloss(42, 176, 124.9);
                yield return new wtloss(43, 179, 124.9);
                yield return new wtloss(44, 198, 118.2);
                yield return new wtloss(45, 214, 118.2);
                yield return new wtloss(46, 218, 115.3);
                yield return new wtloss(47, 221, 115.7);
                yield return new wtloss(48, 225, 116);
                yield return new wtloss(49, 233, 115.5);
                yield return new wtloss(50, 238, 112.6);
                yield return new wtloss(51, 241, 114);
                yield return new wtloss(52, 246, 112.6);
            }
        }
    }
}
