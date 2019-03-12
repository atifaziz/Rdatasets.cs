// ReSharper disable All

namespace Rdatasets.MASS
{
    using System.Collections.Generic;

    /// <summary>
    /// The Stormer Viscometer Data
    /// </summary>

    public class stormer
    {
        public readonly int κ;
        public readonly double Viscosity;
        public readonly int Wt;
        public readonly double Time;

        public stormer(int κ, double Viscosity, int Wt, double Time)
        {
            this.κ = κ;
            this.Viscosity = Viscosity;
            this.Wt = Wt;
            this.Time = Time;
        }

        public static IEnumerable<stormer> Data
        {
            get
            {
                yield return new stormer(1, 14.7, 20, 35.6);
                yield return new stormer(2, 27.5, 20, 54.3);
                yield return new stormer(3, 42, 20, 75.6);
                yield return new stormer(4, 75.7, 20, 121.2);
                yield return new stormer(5, 89.7, 20, 150.8);
                yield return new stormer(6, 146.6, 20, 229);
                yield return new stormer(7, 158.3, 20, 270);
                yield return new stormer(8, 14.7, 50, 17.6);
                yield return new stormer(9, 27.5, 50, 24.3);
                yield return new stormer(10, 42, 50, 31.4);
                yield return new stormer(11, 75.7, 50, 47.2);
                yield return new stormer(12, 89.7, 50, 58.3);
                yield return new stormer(13, 146.6, 50, 85.6);
                yield return new stormer(14, 158.3, 50, 101.1);
                yield return new stormer(15, 161.1, 50, 92.2);
                yield return new stormer(16, 298.3, 50, 187.2);
                yield return new stormer(17, 75.7, 100, 24.6);
                yield return new stormer(18, 89.7, 100, 30);
                yield return new stormer(19, 146.6, 100, 41.7);
                yield return new stormer(20, 158.3, 100, 50.3);
                yield return new stormer(21, 161.1, 100, 45.1);
                yield return new stormer(22, 298.3, 100, 89);
                yield return new stormer(23, 298.3, 100, 86.5);
            }
        }
    }
}
