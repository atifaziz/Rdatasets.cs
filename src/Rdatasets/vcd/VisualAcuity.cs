// ReSharper disable All

namespace Rdatasets.vcd
{
    using System.Collections.Generic;

    /// <summary>
    /// Visual Acuity in Left and Right Eyes
    /// </summary>

    public class VisualAcuity
    {
        public readonly int κ;
        public readonly int Freq;
        public readonly int right;
        public readonly int left;
        public readonly string gender;

        public VisualAcuity(int κ, int Freq, int right, int left, string gender)
        {
            this.κ = κ;
            this.Freq = Freq;
            this.right = right;
            this.left = left;
            this.gender = gender;
        }

        public static IEnumerable<VisualAcuity> Data
        {
            get
            {
                yield return new VisualAcuity(1, 1520, 1, 1, "female");
                yield return new VisualAcuity(2, 234, 2, 1, "female");
                yield return new VisualAcuity(3, 117, 3, 1, "female");
                yield return new VisualAcuity(4, 36, 4, 1, "female");
                yield return new VisualAcuity(5, 266, 1, 2, "female");
                yield return new VisualAcuity(6, 1512, 2, 2, "female");
                yield return new VisualAcuity(7, 362, 3, 2, "female");
                yield return new VisualAcuity(8, 82, 4, 2, "female");
                yield return new VisualAcuity(9, 124, 1, 3, "female");
                yield return new VisualAcuity(10, 432, 2, 3, "female");
                yield return new VisualAcuity(11, 1772, 3, 3, "female");
                yield return new VisualAcuity(12, 179, 4, 3, "female");
                yield return new VisualAcuity(13, 66, 1, 4, "female");
                yield return new VisualAcuity(14, 78, 2, 4, "female");
                yield return new VisualAcuity(15, 205, 3, 4, "female");
                yield return new VisualAcuity(16, 492, 4, 4, "female");
                yield return new VisualAcuity(17, 821, 1, 1, "male");
                yield return new VisualAcuity(18, 116, 2, 1, "male");
                yield return new VisualAcuity(19, 72, 3, 1, "male");
                yield return new VisualAcuity(20, 43, 4, 1, "male");
                yield return new VisualAcuity(21, 112, 1, 2, "male");
                yield return new VisualAcuity(22, 494, 2, 2, "male");
                yield return new VisualAcuity(23, 151, 3, 2, "male");
                yield return new VisualAcuity(24, 34, 4, 2, "male");
                yield return new VisualAcuity(25, 85, 1, 3, "male");
                yield return new VisualAcuity(26, 145, 2, 3, "male");
                yield return new VisualAcuity(27, 583, 3, 3, "male");
                yield return new VisualAcuity(28, 106, 4, 3, "male");
                yield return new VisualAcuity(29, 35, 1, 4, "male");
                yield return new VisualAcuity(30, 27, 2, 4, "male");
                yield return new VisualAcuity(31, 87, 3, 4, "male");
                yield return new VisualAcuity(32, 331, 4, 4, "male");
            }
        }
    }
}
