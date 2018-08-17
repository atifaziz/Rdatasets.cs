// ReSharper disable All

namespace Rdatasets.MASS
{
    using System.Collections.Generic;

    /// <summary>
    /// The Stormer Viscometer Data
    /// </summary>

    public class stormer
    {
        public readonly double Viscosity;
        public readonly int Wt;
        public readonly double Time;

        public stormer(double Viscosity, int Wt, double Time)
        {
            this.Viscosity = Viscosity;
            this.Wt = Wt;
            this.Time = Time;
        }

        public static IEnumerable<stormer> Data
        {
            get
            {
                yield return new stormer(14.7, 20, 35.6);
                yield return new stormer(27.5, 20, 54.3);
                yield return new stormer(42, 20, 75.6);
                yield return new stormer(75.7, 20, 121.2);
                yield return new stormer(89.7, 20, 150.8);
                yield return new stormer(146.6, 20, 229);
                yield return new stormer(158.3, 20, 270);
                yield return new stormer(14.7, 50, 17.6);
                yield return new stormer(27.5, 50, 24.3);
                yield return new stormer(42, 50, 31.4);
                yield return new stormer(75.7, 50, 47.2);
                yield return new stormer(89.7, 50, 58.3);
                yield return new stormer(146.6, 50, 85.6);
                yield return new stormer(158.3, 50, 101.1);
                yield return new stormer(161.1, 50, 92.2);
                yield return new stormer(298.3, 50, 187.2);
                yield return new stormer(75.7, 100, 24.6);
                yield return new stormer(89.7, 100, 30);
                yield return new stormer(146.6, 100, 41.7);
                yield return new stormer(158.3, 100, 50.3);
                yield return new stormer(161.1, 100, 45.1);
                yield return new stormer(298.3, 100, 89);
                yield return new stormer(298.3, 100, 86.5);
            }
        }
    }
}
