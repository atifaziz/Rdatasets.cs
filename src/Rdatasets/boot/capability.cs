// ReSharper disable All

namespace Rdatasets.boot
{
    using System.Collections.Generic;

    /// <summary>
    /// Simulated Manufacturing Process Data
    /// </summary>

    public class capability
    {
        public readonly int κ;
        public readonly double y;

        public capability(int κ, double y)
        {
            this.κ = κ;
            this.y = y;
        }

        public static IEnumerable<capability> Data
        {
            get
            {
                yield return new capability(1, 5.66);
                yield return new capability(2, 5.5);
                yield return new capability(3, 5.65);
                yield return new capability(4, 5.59);
                yield return new capability(5, 5.64);
                yield return new capability(6, 5.61);
                yield return new capability(7, 5.6);
                yield return new capability(8, 5.55);
                yield return new capability(9, 5.68);
                yield return new capability(10, 5.63);
                yield return new capability(11, 5.58);
                yield return new capability(12, 5.62);
                yield return new capability(13, 5.57);
                yield return new capability(14, 5.58);
                yield return new capability(15, 5.63);
                yield return new capability(16, 5.54);
                yield return new capability(17, 5.59);
                yield return new capability(18, 5.59);
                yield return new capability(19, 5.59);
                yield return new capability(20, 5.65);
                yield return new capability(21, 5.6);
                yield return new capability(22, 5.67);
                yield return new capability(23, 5.55);
                yield return new capability(24, 5.57);
                yield return new capability(25, 5.61);
                yield return new capability(26, 5.62);
                yield return new capability(27, 5.63);
                yield return new capability(28, 5.62);
                yield return new capability(29, 5.66);
                yield return new capability(30, 5.67);
                yield return new capability(31, 5.59);
                yield return new capability(32, 5.67);
                yield return new capability(33, 5.66);
                yield return new capability(34, 5.54);
                yield return new capability(35, 5.55);
                yield return new capability(36, 5.57);
                yield return new capability(37, 5.54);
                yield return new capability(38, 5.55);
                yield return new capability(39, 5.59);
                yield return new capability(40, 5.66);
                yield return new capability(41, 5.61);
                yield return new capability(42, 5.65);
                yield return new capability(43, 5.55);
                yield return new capability(44, 5.66);
                yield return new capability(45, 5.62);
                yield return new capability(46, 5.6);
                yield return new capability(47, 5.62);
                yield return new capability(48, 5.65);
                yield return new capability(49, 5.67);
                yield return new capability(50, 5.61);
                yield return new capability(51, 5.58);
                yield return new capability(52, 5.65);
                yield return new capability(53, 5.65);
                yield return new capability(54, 5.63);
                yield return new capability(55, 5.51);
                yield return new capability(56, 5.58);
                yield return new capability(57, 5.51);
                yield return new capability(58, 5.6);
                yield return new capability(59, 5.68);
                yield return new capability(60, 5.58);
                yield return new capability(61, 5.67);
                yield return new capability(62, 5.59);
                yield return new capability(63, 5.65);
                yield return new capability(64, 5.69);
                yield return new capability(65, 5.67);
                yield return new capability(66, 5.66);
                yield return new capability(67, 5.59);
                yield return new capability(68, 5.72);
                yield return new capability(69, 5.63);
                yield return new capability(70, 5.57);
                yield return new capability(71, 5.59);
                yield return new capability(72, 5.58);
                yield return new capability(73, 5.67);
                yield return new capability(74, 5.67);
                yield return new capability(75, 5.69);
            }
        }
    }
}
