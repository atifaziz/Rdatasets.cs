// ReSharper disable All

namespace Rdatasets.boot
{
    using System.Collections.Generic;

    /// <summary>
    /// Tau Particle Decay Modes
    /// </summary>

    public class tau
    {
        public readonly int κ;
        public readonly double rate;
        public readonly string decay;

        public tau(int κ, double rate, string decay)
        {
            this.κ = κ;
            this.rate = rate;
            this.decay = decay;
        }

        public static IEnumerable<tau> Data
        {
            get
            {
                yield return new tau(1, 84, "1");
                yield return new tau(2, 84.7, "1");
                yield return new tau(3, 84.7, "1");
                yield return new tau(4, 85.1, "1");
                yield return new tau(5, 85.2, "1");
                yield return new tau(6, 85.2, "1");
                yield return new tau(7, 86, "1");
                yield return new tau(8, 86.1, "1");
                yield return new tau(9, 86.7, "1");
                yield return new tau(10, 86.9, "1");
                yield return new tau(11, 87.2, "1");
                yield return new tau(12, 87.8, "1");
                yield return new tau(13, 87.9, "1");
                yield return new tau(14, 20.5, "rho");
                yield return new tau(15, 22.1, "rho");
                yield return new tau(16, 22.3, "rho");
                yield return new tau(17, 22.3, "rho");
                yield return new tau(18, 22.6, "rho");
                yield return new tau(19, 24, "rho");
                yield return new tau(20, 8, "pi");
                yield return new tau(21, 9, "pi");
                yield return new tau(22, 9.9, "pi");
                yield return new tau(23, 10, "pi");
                yield return new tau(24, 10.7, "pi");
                yield return new tau(25, 11.7, "pi");
                yield return new tau(26, 11.8, "pi");
                yield return new tau(27, 13, "e");
                yield return new tau(28, 16, "e");
                yield return new tau(29, 17, "e");
                yield return new tau(30, 17.4, "e");
                yield return new tau(31, 17.6, "e");
                yield return new tau(32, 18.2, "e");
                yield return new tau(33, 18.2, "e");
                yield return new tau(34, 18.3, "e");
                yield return new tau(35, 18.4, "e");
                yield return new tau(36, 18.9, "e");
                yield return new tau(37, 19, "e");
                yield return new tau(38, 19.1, "e");
                yield return new tau(39, 20.4, "e");
                yield return new tau(40, 22.4, "e");
                yield return new tau(41, 12.9, "mu");
                yield return new tau(42, 15, "mu");
                yield return new tau(43, 17.1, "mu");
                yield return new tau(44, 17.4, "mu");
                yield return new tau(45, 17.5, "mu");
                yield return new tau(46, 17.6, "mu");
                yield return new tau(47, 17.7, "mu");
                yield return new tau(48, 17.7, "mu");
                yield return new tau(49, 17.8, "mu");
                yield return new tau(50, 18, "mu");
                yield return new tau(51, 18.2, "mu");
                yield return new tau(52, 18.3, "mu");
                yield return new tau(53, 18.3, "mu");
                yield return new tau(54, 18.8, "mu");
                yield return new tau(55, 19.4, "mu");
                yield return new tau(56, 21, "mu");
                yield return new tau(57, 22, "mu");
                yield return new tau(58, 22, "mu");
                yield return new tau(59, 22.4, "mu");
                yield return new tau(60, 35, "mu");
            }
        }
    }
}
