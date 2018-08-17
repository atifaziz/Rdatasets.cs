// ReSharper disable All

namespace Rdatasets.vcd
{
    using System.Collections.Generic;

    /// <summary>
    /// Visual Acuity in Left and Right Eyes
    /// </summary>

    public class VisualAcuity
    {
        public readonly int Freq;
        public readonly int right;
        public readonly int left;
        public readonly string gender;

        public VisualAcuity(int Freq, int right, int left, string gender)
        {
            this.Freq = Freq;
            this.right = right;
            this.left = left;
            this.gender = gender;
        }

        public static IEnumerable<VisualAcuity> Data
        {
            get
            {
                yield return new VisualAcuity(1520, 1, 1, "female");
                yield return new VisualAcuity(234, 2, 1, "female");
                yield return new VisualAcuity(117, 3, 1, "female");
                yield return new VisualAcuity(36, 4, 1, "female");
                yield return new VisualAcuity(266, 1, 2, "female");
                yield return new VisualAcuity(1512, 2, 2, "female");
                yield return new VisualAcuity(362, 3, 2, "female");
                yield return new VisualAcuity(82, 4, 2, "female");
                yield return new VisualAcuity(124, 1, 3, "female");
                yield return new VisualAcuity(432, 2, 3, "female");
                yield return new VisualAcuity(1772, 3, 3, "female");
                yield return new VisualAcuity(179, 4, 3, "female");
                yield return new VisualAcuity(66, 1, 4, "female");
                yield return new VisualAcuity(78, 2, 4, "female");
                yield return new VisualAcuity(205, 3, 4, "female");
                yield return new VisualAcuity(492, 4, 4, "female");
                yield return new VisualAcuity(821, 1, 1, "male");
                yield return new VisualAcuity(116, 2, 1, "male");
                yield return new VisualAcuity(72, 3, 1, "male");
                yield return new VisualAcuity(43, 4, 1, "male");
                yield return new VisualAcuity(112, 1, 2, "male");
                yield return new VisualAcuity(494, 2, 2, "male");
                yield return new VisualAcuity(151, 3, 2, "male");
                yield return new VisualAcuity(34, 4, 2, "male");
                yield return new VisualAcuity(85, 1, 3, "male");
                yield return new VisualAcuity(145, 2, 3, "male");
                yield return new VisualAcuity(583, 3, 3, "male");
                yield return new VisualAcuity(106, 4, 3, "male");
                yield return new VisualAcuity(35, 1, 4, "male");
                yield return new VisualAcuity(27, 2, 4, "male");
                yield return new VisualAcuity(87, 3, 4, "male");
                yield return new VisualAcuity(331, 4, 4, "male");
            }
        }
    }
}
