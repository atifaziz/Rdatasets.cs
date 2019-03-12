// ReSharper disable All

namespace Rdatasets.MASS
{
    using System.Collections.Generic;

    /// <summary>
    /// House Insulation: Whiteside's Data
    /// </summary>

    public class whiteside
    {
        public readonly int κ;
        public readonly string Insul;
        public readonly double Temp;
        public readonly double Gas;

        public whiteside(int κ, string Insul, double Temp, double Gas)
        {
            this.κ = κ;
            this.Insul = Insul;
            this.Temp = Temp;
            this.Gas = Gas;
        }

        public static IEnumerable<whiteside> Data
        {
            get
            {
                yield return new whiteside(1, "Before", -0.8, 7.2);
                yield return new whiteside(2, "Before", -0.7, 6.9);
                yield return new whiteside(3, "Before", 0.4, 6.4);
                yield return new whiteside(4, "Before", 2.5, 6);
                yield return new whiteside(5, "Before", 2.9, 5.8);
                yield return new whiteside(6, "Before", 3.2, 5.8);
                yield return new whiteside(7, "Before", 3.6, 5.6);
                yield return new whiteside(8, "Before", 3.9, 4.7);
                yield return new whiteside(9, "Before", 4.2, 5.8);
                yield return new whiteside(10, "Before", 4.3, 5.2);
                yield return new whiteside(11, "Before", 5.4, 4.9);
                yield return new whiteside(12, "Before", 6, 4.9);
                yield return new whiteside(13, "Before", 6, 4.3);
                yield return new whiteside(14, "Before", 6, 4.4);
                yield return new whiteside(15, "Before", 6.2, 4.5);
                yield return new whiteside(16, "Before", 6.3, 4.6);
                yield return new whiteside(17, "Before", 6.9, 3.7);
                yield return new whiteside(18, "Before", 7, 3.9);
                yield return new whiteside(19, "Before", 7.4, 4.2);
                yield return new whiteside(20, "Before", 7.5, 4);
                yield return new whiteside(21, "Before", 7.5, 3.9);
                yield return new whiteside(22, "Before", 7.6, 3.5);
                yield return new whiteside(23, "Before", 8, 4);
                yield return new whiteside(24, "Before", 8.5, 3.6);
                yield return new whiteside(25, "Before", 9.1, 3.1);
                yield return new whiteside(26, "Before", 10.2, 2.6);
                yield return new whiteside(27, "After", -0.7, 4.8);
                yield return new whiteside(28, "After", 0.8, 4.6);
                yield return new whiteside(29, "After", 1, 4.7);
                yield return new whiteside(30, "After", 1.4, 4);
                yield return new whiteside(31, "After", 1.5, 4.2);
                yield return new whiteside(32, "After", 1.6, 4.2);
                yield return new whiteside(33, "After", 2.3, 4.1);
                yield return new whiteside(34, "After", 2.5, 4);
                yield return new whiteside(35, "After", 2.5, 3.5);
                yield return new whiteside(36, "After", 3.1, 3.2);
                yield return new whiteside(37, "After", 3.9, 3.9);
                yield return new whiteside(38, "After", 4, 3.5);
                yield return new whiteside(39, "After", 4, 3.7);
                yield return new whiteside(40, "After", 4.2, 3.5);
                yield return new whiteside(41, "After", 4.3, 3.5);
                yield return new whiteside(42, "After", 4.6, 3.7);
                yield return new whiteside(43, "After", 4.7, 3.5);
                yield return new whiteside(44, "After", 4.9, 3.4);
                yield return new whiteside(45, "After", 4.9, 3.7);
                yield return new whiteside(46, "After", 4.9, 4);
                yield return new whiteside(47, "After", 5, 3.6);
                yield return new whiteside(48, "After", 5.3, 3.7);
                yield return new whiteside(49, "After", 6.2, 2.8);
                yield return new whiteside(50, "After", 7.1, 3);
                yield return new whiteside(51, "After", 7.2, 2.8);
                yield return new whiteside(52, "After", 7.5, 2.6);
                yield return new whiteside(53, "After", 8, 2.7);
                yield return new whiteside(54, "After", 8.7, 2.8);
                yield return new whiteside(55, "After", 8.8, 1.3);
                yield return new whiteside(56, "After", 9.7, 1.5);
            }
        }
    }
}
