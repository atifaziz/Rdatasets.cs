// ReSharper disable All

namespace Rdatasets.boot
{
    using System.Collections.Generic;

    /// <summary>
    /// Tau Particle Decay Modes
    /// </summary>

    public class tau
    {
        public readonly double rate;
        public readonly string decay;

        public tau(double rate, string decay)
        {
            this.rate = rate;
            this.decay = decay;
        }

        public static IEnumerable<tau> Data
        {
            get
            {
                yield return new tau(84, "1");
                yield return new tau(84.7, "1");
                yield return new tau(84.7, "1");
                yield return new tau(85.1, "1");
                yield return new tau(85.2, "1");
                yield return new tau(85.2, "1");
                yield return new tau(86, "1");
                yield return new tau(86.1, "1");
                yield return new tau(86.7, "1");
                yield return new tau(86.9, "1");
                yield return new tau(87.2, "1");
                yield return new tau(87.8, "1");
                yield return new tau(87.9, "1");
                yield return new tau(20.5, "rho");
                yield return new tau(22.1, "rho");
                yield return new tau(22.3, "rho");
                yield return new tau(22.3, "rho");
                yield return new tau(22.6, "rho");
                yield return new tau(24, "rho");
                yield return new tau(8, "pi");
                yield return new tau(9, "pi");
                yield return new tau(9.9, "pi");
                yield return new tau(10, "pi");
                yield return new tau(10.7, "pi");
                yield return new tau(11.7, "pi");
                yield return new tau(11.8, "pi");
                yield return new tau(13, "e");
                yield return new tau(16, "e");
                yield return new tau(17, "e");
                yield return new tau(17.4, "e");
                yield return new tau(17.6, "e");
                yield return new tau(18.2, "e");
                yield return new tau(18.2, "e");
                yield return new tau(18.3, "e");
                yield return new tau(18.4, "e");
                yield return new tau(18.9, "e");
                yield return new tau(19, "e");
                yield return new tau(19.1, "e");
                yield return new tau(20.4, "e");
                yield return new tau(22.4, "e");
                yield return new tau(12.9, "mu");
                yield return new tau(15, "mu");
                yield return new tau(17.1, "mu");
                yield return new tau(17.4, "mu");
                yield return new tau(17.5, "mu");
                yield return new tau(17.6, "mu");
                yield return new tau(17.7, "mu");
                yield return new tau(17.7, "mu");
                yield return new tau(17.8, "mu");
                yield return new tau(18, "mu");
                yield return new tau(18.2, "mu");
                yield return new tau(18.3, "mu");
                yield return new tau(18.3, "mu");
                yield return new tau(18.8, "mu");
                yield return new tau(19.4, "mu");
                yield return new tau(21, "mu");
                yield return new tau(22, "mu");
                yield return new tau(22, "mu");
                yield return new tau(22.4, "mu");
                yield return new tau(35, "mu");
            }
        }
    }
}
